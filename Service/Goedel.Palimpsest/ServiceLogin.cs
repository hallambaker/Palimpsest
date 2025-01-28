#region // Copyright - MIT License
//  © 2021 by Phill Hallam-Baker
//  
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//  
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//  
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
#endregion

using DocumentFormat.OpenXml.InkML;

using Goedel.Mesh;

using System.Reflection.Metadata;

namespace Goedel.Palimpsest;


public record TempBinding(
            DateTime issued,
            string redirectUri) {
    }



public partial class AnnotationService {



    public async Task ForumTermsConditions(
                    ParsedPath path) {

        var fields = new FormDataAccount();
        var annotations = Annotations.PostForm(this, fields, path);

        var nonceDns = new NonceDns("FORUM", Handle: fields.Handle);

        var prefill = new FormDataAcceptTerms() {
            From = nonceDns.State(),
            Handle = fields.Handle,
            };

        annotations.StartPage(Forum.Name);
        annotations.PageBoilerplate(TermsAndConditions, prefill);
        annotations.End();
        }

    public async Task PlaceTermsConditions(
                ParsedPath path) {

        var nonceDns = NonceDns.Parse(path.Uri.Query);
        var annotations = Annotations.Get(this, path);

        var prefill = new FormDataAcceptTerms() {
            From = nonceDns.State(),
            Handle = nonceDns.Handle,
            };

        annotations.StartPage(Forum.Name);
        annotations.PageBoilerplate(TermsAndConditions, prefill);
        annotations.End();
        }



    /// <summary>
    /// The explicit sign in page. This can be called on the Place or at the Forum
    /// <para>
    /// When called at a Place that is not the Forum login, a redirect is made to the Forum.
    /// </para>
    /// </summary>
    /// <param name="context"></param>
    /// <param name="path"></param>
    /// <returns></returns>
    public async Task GetSignIn(
                ParsedPath path) {

        if (!path.PlaceHandle?.IsForum == true) {
            await RedirectSignIn(path);
            return;
            }
        await ForumTermsConditions(path);
        return;
        }

    /// <summary>
    /// The page on the forum to which a visitor is redirected by RedirectSignIn.
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public async Task ForumPlaceSignIn(
                ParsedPath path) {
        
        if (path.Member is null) {
            // User has not logged in to the forum so present the T&C
            await PlaceTermsConditions(path);
            return;
            }

        // we are logged in so
        var nonceDns = NonceDns.Parse(path.Uri.Query);
        //var redirect = nonceDns.UriHandle(success.Handle, PalimpsestConstants.SignInComplete);

        // Are we logged into the requested account
        if (path.Member.LocalName != nonceDns.Handle) {
            // no - present T&C
            await PlaceTermsConditions(path);
            return;
            }

        var redirect = nonceDns.Uri(nonceDns.Place, PalimpsestConstants.SignInComplete);

        // We are logged in here under the account, bounce back to the place.
        var annotations = Annotations.Get(this, path);
        await annotations.Redirect(path.Context, redirect);
        }

    #region // Sign in/out

    public Dictionary<string, TempBinding> TempBindings { get; } = new();



    #region // Domain is PLACE
    public Task RedirectSignIn(
                ParsedPath path) {
        // Parse the form data to get the Username
        var fields = new FormDataAccount();
        var annotations = Annotations.PostForm(this, fields, path);

        var local = fields.From ?? "";
        var bindingReturn = $"https://{path.Uri.Host}/{local}";

        // create a temporary cookie to be used to validate the 
        var binding = new TempBinding(DateTime.Now, bindingReturn);
        var nonce = Udf.Nonce();
        var nonceDns = new NonceDns(nonce, path.Uri.Host, fields.Handle);

        var context = path.Context;

        TempBindings.Add(nonce, binding);
        var cookie = new Cookie(PalimpsestConstants.CookieTypeTemporaryTag, nonce);
        context.Response.SetCookie(cookie);

        var redirect = nonceDns.Uri(Domain, PalimpsestConstants.ForumPlaceSignIn);
        context.Response.Redirect(redirect);
        context.Response.OutputStream.Close();


        return Task.CompletedTask;
        }

    public async Task CompleteSignIn(
                ParsedPath path) {
        var context = path.Context;

        var nonceDns = NonceDns.Parse(path.Uri.Query);

        //var parsedUrl = path.Uri.Query;
        //var paramsCollection = HttpUtility.ParseQueryString(parsedUrl);
        //var nonce = paramsCollection["nonce"];
        //var handle = paramsCollection["handle"];

        if (!TempBindings.TryGetValue(nonceDns.Nonce, out var binding)) {
            throw new NYI();
            }



        var member = Forum.GetMember(nonceDns.Handle);
        var cookie = Forum.ServerCookieManager.GetCookie(
            PalimpsestConstants.CookieTypeSessionTag, member.PrimaryKey);
        context.Response.Cookies.Add(cookie);



        var annotations = Annotations.Get(this, context, path);
        await annotations.Redirect(context, binding.redirectUri);
        } 
    #endregion



    public async Task GetSignOut(
                ParsedPath path) {
        var context = path.Context;
        var annotations = Annotations.Get(this, context, path);

        // clear the HTTP cookie
        var cookie = ServerCookieManager.ClearCookie(PalimpsestConstants.CookieTypeSessionTag);
        context.Response.Cookies.Add(cookie);
        path.Member = null;

        await GetHome(path);
        }
    #endregion
    #region // Handle forms
    public async Task PostSignIn(
                ParsedPath path) {
        var context = path.Context;
        var member = path.Member;

        var fields = new FormDataAccount();
        var annotations = Annotations.PostForm(this, fields, path);
        var redirect = fields.From ?? "/";

        // Do we already have a local account for this handle?
        if (Forum.TryGetByHandle(fields.Handle, out var handle)) {
            await OAuthSignIn(annotations, context, fields.Handle, redirect, handle);
            }

        var prefill = new FormDataAcceptTerms() {
            From = redirect,
            Handle = fields.Handle,
            };

        annotations.StartPage(Forum.Name);
        annotations.PageBoilerplate(TermsAndConditions, prefill);
        annotations.End();

        return;
        }

    public async Task PostAcceptTerms(
                ParsedPath path) {
        var context = path.Context;
        var member = path.Member;

        var fields = new FormDataAcceptTerms();
        var annotations = Annotations.PostForm(this, fields, path);

        if (fields.Agree == "true") {
            await OAuthSignIn(annotations, context, fields.Handle, fields.From);
            return;
            // redirect to the oauth thingie here
            //await OAuthSignIn(annotations, context, fields.From, fields.Username);
            }

        fields.Insist = true;
        annotations.StartPage(Forum.Name);
        annotations.PageBoilerplate(TermsAndConditions, fields);
        annotations.End();
        }

    #endregion
    #region // Perform OAUTH actions

    public async Task OAuthSignIn(
            Annotations annotations,
            HttpListenerContext context,
            string userHandle,
            string? returnUri,
            MemberHandle member = null) {

        // Return uri defaults to the home page.
        returnUri ??= "/";

        // Perform OAUTH Push
        var redirect = await OauthClient.PreRequest(userHandle, returnUri);

        if (redirect is OauthClientResultFail fail) {
            // throw error here
            throw new NYI();
            }
        var success = redirect as OauthClientResultPreRequest;

        await annotations.Redirect(context, success.RedirectUri);
        }

    public async Task GetRedirect(
                ParsedPath path) {
        var context = path.Context;

        // Parse redirect data
        var result = OauthClient.ParseResponse(path.Uri);

        // If success redirect to preserve state
        if (result is OauthClientResultFail fail) {
            // throw error here
            throw new NYI();
            }

        // report error
        var success = result as OauthClientResultAuthRequest;
        var nonceDns = NonceDns.Parse(success.RedirectUri);
        if (success.Handle != nonceDns.Handle) {
            // throw error here, user authenticated but TO THE WRONG HANDLE!
            throw new NYI();
            }

        Console.WriteLine($"Stuff cookies into {context.Request.UserHostName}");

        var member = Forum.GetOrCreateMember(success.Handle, success.DID);
        // have authenticated against a DID and a handle. We are going to keep both.
        var cookie = Forum.ServerCookieManager.GetCookie(
            PalimpsestConstants.CookieTypeSessionTag, member.PrimaryKey);
        context.Response.Cookies.Add(cookie);

        // Send the redirect
        var annotations = Annotations.Get(this, path);

        //extract the nonce from success.RedirectUri
        if (nonceDns.Nonce == "FORUM") {
            await annotations.Redirect(context, "/");
            return;
            }

        // We are logged in here under the account, bounce back to the place.
        var redirect = nonceDns.Uri(nonceDns.Place, PalimpsestConstants.SignInComplete);
        await annotations.Redirect(context, redirect);
        }
    #endregion




    }