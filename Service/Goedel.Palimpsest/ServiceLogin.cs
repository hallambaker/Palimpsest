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

namespace Goedel.Palimpsest;


public partial class AnnotationService {
    #region // Sign in/out
    public Task GetSignIn(
        HttpListenerContext context,
        ParsedPath path) {
        var annotations = Annotations.Get(this, context, path);

        var from = path.Command == PalimpsestConstants.SignIn ? "/" : path.LocalPath;

        annotations.StartPage($"{Forum.Name}: Sign In");
        annotations.SignIn(from);
        annotations.End();

        return Task.CompletedTask;
        }

    public Task GetSignOut(
                HttpListenerContext context,
                ParsedPath path) {
        var annotations = Annotations.Get(this, context, path);

        // clear the HTTP cookie
        var cookie = ServerCookieManager.ClearCookie(PalimpsestConstants.CookieTypeSessionTag);
        context.Response.Cookies.Add(cookie);

        // clear the verified account handle
        annotations.VerifiedAccount = null;

        // roll the page including the header
        annotations.StartPage(Forum.Name);
        annotations.PageHome();
        annotations.End();

        return Task.CompletedTask;
        }
    #endregion
    #region // Handle forms
    public async Task PostSignIn(
            HttpListenerContext context,
            ParsedPath path) {
        var member = path.Member;

        var fields = new FormDataAccount();

        var annotations = Annotations.PostForm(this, context, fields, path);
        var redirect = fields.From ?? "/";

        // Do we already have a local account for this handle?
        if (Forum.TryGetByHandle(fields.Username, out var handle)) {
            await OAuthSignIn(annotations, context, fields.Username, redirect, handle);
            }

        var prefill = new FormDataAcceptTerms() {
            From = redirect,
            Username = fields.Username,
            };

        annotations.StartPage(Forum.Name);
        annotations.PageBoilerplate(TermsAndConditions, prefill);
        annotations.End();

        return;
        }

    public async Task PostAcceptTerms(
            HttpListenerContext context,
            ParsedPath path) {
        var member = path.Member;

        var fields = new FormDataAcceptTerms();
        var annotations = Annotations.PostForm(this, context, fields, path);

        if (fields.Agree == "true") {
            await OAuthSignIn(annotations, context, fields.Username, fields.From);
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
        HttpListenerContext context,
        ParsedPath path) {

        // https://mplace2.app/Redirect?
        // iss=https%3A%2F%2Fbsky.social
        // &state=7w2O5X7OmCP0NacKHLrTChYRjmn83kPimRV3_3YBbmz15C2NrlktZMY
        // KoC7lwo4qiQIzsNZBqwDdNZpKiUPO2RmdPNyhl60_Ds0nKn0Wj5x_755xhXRAS5HzQet2tZQselU8O82GXYYpFcfmt_
        // kFrS1iEwg
        // &code=cod-ed46b08e1b9de414d6421fe0e6f5201e6550112cdf7166d669fc94600b25b705

        // Parse redirect data
        var result = OauthClient.ParseResponse(path.Uri);

        // If success redirect to preserve state
        if (result is OauthClientResultFail fail) {
            // throw error here
            throw new NYI();
            }

        // report error
        var success = result as OauthClientResultAuthRequest;




        var member = Forum.GetOrCreateMember(success.Handle, success.DID);
        // have authenticated against a DID and a handle. We are going to keep both.
        var cookie = Forum.ServerCookieManager.GetCookie(
            PalimpsestConstants.CookieTypeSessionTag, member.PrimaryKey);
        context.Response.Cookies.Add(cookie);

        // Send the redirect
        var annotations = Annotations.Get(this, context, path);
        await annotations.Redirect(context, success.RedirectUri);
        }
    #endregion

    }