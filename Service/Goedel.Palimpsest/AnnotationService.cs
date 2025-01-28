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

using DocumentFormat.OpenXml.Drawing.Diagrams;

using System.Runtime.Serialization.DataContracts;

namespace Goedel.Palimpsest;

[Flags]
public enum CommentMode {



    Subject = 1,

    Text = 2,

    Semantic = 4,

    Annotation = Text | Semantic,

    Post = Subject | Text,

    Comment = Text,

    None = 0


    }

public partial class AnnotationService : IWebService<ParsedPath> {

    #region // Properties
    ///<summary>The persistent data store</summary> 
    public Forum Forum { get; }

    ///<summary>The HTTP listener</summary> 
    private HttpListener HttpListener { get; set; }


    private string HttpEndpoint => "http://+:15099/";
    private string HttpsEndpoint => "https://+:15098/";

    public string HomeUrl => "/";

    public string Domain => "mplace2.social";
    public string ClientEndpoint => $"https://{Domain}/";

    public string SignInEndpoint => ClientEndpoint + PalimpsestConstants.SignIn;

    public string ClientMetadataLocation => ClientEndpoint + PalimpsestConstants.ClientMetadata;



    public string ForumTermsAndConditions => $"https://{Domain}/{PalimpsestConstants.ForumTermsConditions}";

    OauthClient OauthClient { get; }

    public KeyPair OauthClientSignature { get; set; }
    public KeyPair OauthClientEncryption { get; set; }

    public JWKS JWKS { get; set; }


    public NavigationItem[] ForumNavigation = [
            new ("Home", ""),
            new ("Technology", "Technology", "technology.md"),
            new ("FAQ", "FAQ", "faq.md"),
            new ("About", "About", "about.md")
        ];

    public NavigationItem[] ForumAdditional = [
        new ("Terms", "Terms", "terms.md"),
        ];

    public BoilerplateHtml? TermsAndConditions {
        get {
            if (Boilerplate.TryGetValue("Terms", out var result)) {
                return result as BoilerplateHtml;
                }
            return null;


            }

        }
    public Navigation NavigationMain => new(ForumNavigation);
    public Navigation NavigationSplashpage => new(ForumNavigation) { 
                Login = false
                };

    public string RedirectLocation => ClientEndpoint + PalimpsestConstants.Redirect;

    public Dictionary<string, Boilerplate> Boilerplate { get; }


    ///<inheritdoc/>
    //public Dictionary<string, WebResource<ParsedPath>> BuiltInMap { get; }
    public Dictionary<string, WebResource<ParsedPath>> ResourceMap { get; }
    #endregion
    #region // Constructor

    ///<summary>
    ///Return an instance serving pages from <paramref name="forum"/>
    ///</summary> 
    ///<remarks>
    ///"Use the HttpCfg.exe tool to add SSL certificate"
    ///no, netsh!
    ///
    /// https://www.misterpki.com/netsh-http-add-sslcert/
    /// </remarks>
    ///<param name="forum">The persistence store.</param>
    public AnnotationService(Forum forum) {
        Forum = forum;
        HttpListener = new();
        HttpListener.Prefixes.Add(HttpEndpoint);
        HttpListener.Prefixes.Add(HttpsEndpoint);

        // Bind the OAUTH client here

        // These should all belong to Oauth client
        OauthClientSignature = OauthClient.GenKey(KeyUses.Sign);
        OauthClientEncryption = OauthClient.GenKey(KeyUses.Encrypt);

        JWKS = new JWKS {
            Keys = [JWK.Factory(OauthClientSignature)
                , JWK.Factory(OauthClientEncryption)
                ]
            };

        OauthClient = new OauthClient(
                    ClientMetadataLocation,
                    RedirectLocation,
                    JWKS
                    );


        var clientBoilerplate = new BoilerplateVerbatim() {
            Bytes = OauthClient.ClientMetadataBytes,
            ContentType = PalimpsestConstants.ClientMetadataType
            };

        Boilerplate = new Dictionary<string, Boilerplate>() {
                        { PalimpsestConstants.ClientMetadata, clientBoilerplate },
            };

        AddBoilerplate(ForumNavigation, true);
        AddBoilerplate(ForumAdditional);

        ResourceMap = new Dictionary<string, WebResource<ParsedPath>>{
            // public pages, visible to all users but with possibly reduced functionality
            { "", new (GetHome, false) }, // Home page
            { PalimpsestConstants.resources, new (GetResources,false) },

            { PalimpsestConstants.SignIn, new (GetSignIn, false) },
            { PalimpsestConstants.ForumTermsConditions, new (ForumTermsConditions, false) },
            { PalimpsestConstants.ForumPlaceSignIn, new (ForumPlaceSignIn, false) },
            { PalimpsestConstants.SignInComplete, new (CompleteSignIn, false) },
            { PalimpsestConstants.Redirect, new (GetRedirect, false) },
            /// Wet edge here, pages above have been fixed


            //{ PalimpsestConstants.SignInPost, new (PostSignIn, false) },

            { PalimpsestConstants.AcceptTerms, new (PostAcceptTerms, false) },
            //{ PalimpsestConstants.Terms, new (GetTerms, false) },

            //{ PalimpsestConstants.CreateAccount, new (GetCreateAccount, false) },
            //{ PalimpsestConstants.CreateAccountPost, new (PostCreateAccount, false) },




            // private pages, requires log in
            { PalimpsestConstants.SignOut, new (GetSignOut) },
            { PalimpsestConstants.Place, new (GetPlace) },
            { PalimpsestConstants.AddDocument, new (GetAddDocument) },
            { PalimpsestConstants.AddTopic, new (GetAddTopic) },

            { PalimpsestConstants.Document, new (GetDocument) },
            { PalimpsestConstants.Topic, new (GetTopic) },
            { PalimpsestConstants.Post, new (GetPost) },
            { PalimpsestConstants.User, new (GetUser) },

            { PalimpsestConstants.CreatePlace, new (GetCreatePlace) },
            { PalimpsestConstants.CreatePlacePost, new (PostCreatePlace) },
            { PalimpsestConstants.DocumentUpload, new (PostUploadDocument) },
            { PalimpsestConstants.TopicCreate, new (PostCreateTopic) },

            { PalimpsestConstants.Actions, new (GetListActions) },
            { PalimpsestConstants.Comment, new (GetCommentForm) },
            { PalimpsestConstants.CommentPost, new (PostComment) },

            { PalimpsestConstants.CreatePost, new (GetPostForm) },
            { PalimpsestConstants.PostPost, new (PostPost) },

            { PalimpsestConstants.CreatePostComment, new (GetPostCommentForm) },
            { PalimpsestConstants.PostCommentPost, new (PostPostComment) },

             { "*", new (Error) }

            };
        }

    void AddBoilerplate(NavigationItem[] items, bool indexed = false) {
        for (var i = 0; i < items.Length; i++) {
            var item = items[i];
            if (item.Filename is not null) {
                var boilerplate = new BoilerplateHtml() {
                    Filename = item.Filename
                    };
                if (indexed) {
                    boilerplate.Index = i;
                    }
                Boilerplate.Add(item.Uri, boilerplate);
                }
            }
        }



    #endregion
    #region // The HTTP service and dispatch

    /// <summary>
    /// Start the service
    /// </summary>
    public void Start() {
        HttpListener.Start();
        Console.WriteLine($"Listening {HttpEndpoint}");
        while (true) {
            HttpListenerContext context = HttpListener.GetContext();
            var task = HandleRequest(context);
            }
        }

    ///<summary>Handle request asynchronously.</summary> 
    private async Task HandleRequest(HttpListenerContext context) {

        var request = context.Request;
        var response = context.Response;

        // This should never happen.
        if (request.Url is null) {
            await Error(context, null);
            return;
            }

        var path = new ParsedPath(context, Forum);

        Console.WriteLine($"Request {request.UserHostName} {request.Url.LocalPath} from  {path.RealIp}");
        Console.WriteLine($"   Start {path.Command} Place {path.FirstId} Document {path.SecondId}");

        if (path.Member is not null) {
            Console.WriteLine($"   Member {path.Member.LocalName} is {path.Member.PermissionLabel} @{path.PlaceHandle?.LocalName}");
            }

        // Check for the boilerplate pages first
        if (Boilerplate.TryGetValue(path.Command, out var resource)) {
            await SendBoilerplate(context, path, resource);
            return;
            }

        // Look for a dispatch method and use it if found.
        if (ResourceMap.TryGetValue(path.Command, out var callback)) {
            if ((path.Member is null) & callback.SignedIn) {
                if (path.PlaceHandle?.IsForum == true) {
                    await ForumTermsConditions(path, path.Uri.PathAndQuery);
                    }
                else {
                    await RedirectSignIn(path, path.Uri.PathAndQuery);
                    }
                return;
                }

            await callback.Method(path);
            }
        else {
            await Error(context, null);
            }
        }

    #endregion
    #region // Header and footer

    public async Task PageHeader(Annotations annotations) {
        var title = $"@{annotations.ParsedPath.Placename} as {annotations.AccountHandle}";

        annotations.StartPage(title);
        annotations.HeaderNavigation(NavigationMain, -1);
        await Task.CompletedTask;
        }

    public async Task PageFooter(Annotations annotations) {
        annotations.Trailer();
        annotations.End();

        await Task.CompletedTask;
        }

    #endregion
    #region // Server Get Pages - primary

    public async Task GetHome(
                ParsedPath path) {
        var context = path.Context;


        if (path.Placename is null) {
            await HomePageForumEmpty(path);
            }
        else if (path.PlaceHandle.IsForum) {

            if (path.SignedIn) {
                await HomePageForumSignedIn(path);
                }
            else {
                await HomePageForumSignedOut(path);
                }
            }
        else {
            await HomePagePlace(path);
            }




        }

    public async Task GetPlacePage(
                ParsedPath path,
                Annotations annotations,
                Action<PlaceHandle> page) {

        await PageHeader(annotations);
        page(path.PlaceHandle);
        await PageFooter(annotations);
        await Task.CompletedTask;
        }





    #region // Resources


    public async Task GetPlace(
            ParsedPath path) {
        var annotations = Annotations.Get(this, path);
        await GetPlacePage(path, annotations, annotations.PagePlace);
        }



    public async Task SendBoilerplate (
            HttpListenerContext context,
            ParsedPath path,
            Boilerplate boilerplate) {

        switch (boilerplate) {
            case BoilerplateVerbatim verbatim: {
                context.Respond(verbatim.Bytes, verbatim.ContentType);
                return;
                }
            case BoilerplateHtml html: {

                var annotations = Annotations.Get(this, context, path);

                //if (html.HTML is null) {
                //    Forum.FetchBoilerplate(html);
                //    }

                annotations.StartPage(Forum.Name);
                annotations.PageBoilerplate(html);
                annotations.End();
                await Task.CompletedTask;

                return;
                }
            }



        throw new NYI();
        }





    public async Task GetResources(
                ParsedPath path) {
        var context = path.Context;

        if (Boilerplate.TryGetValue(path.FirstId, out var resource)) {
            await SendBoilerplate(context, path, resource);
            return;
            }


        var member = path.Member;
        using var response = context.Response;

        string filePath;
        var stroke = path.LocalPath.IndexOf('/', 1);
        if (stroke < 0) {
            filePath = Forum.Resources + path.FirstId;
            }
        else {
            filePath = Forum.Resources + path.LocalPath[stroke..];
            }

        response.StatusCode = (int)HttpStatusCode.OK;
        response.StatusDescription = "Status OK";
        response.ContentType = filePath.GetFileType();

        using var file = filePath.OpenFileReadShared();
        file.CopyTo(response.OutputStream);

        response.OutputStream.Close();

        return;
        }
    #endregion
    #region // Item pages





    public async Task GetDocument(
                ParsedPath path) {
        var context = path.Context;

        var annotations = Annotations.Get(this, context, path);

        // need to modify this to get the project and account ids
        Forum.TryGetPlace(path.FirstId, out var projectHandle);
        projectHandle.TryGetResource(path.SecondId, out var resourceHandle);

        await WritePage(annotations, resourceHandle);

        }


    public async Task GetTopic(
                ParsedPath path) {
        var context = path.Context;
        var annotations = Annotations.Get(this, context, path);

        // Place is specified in path.PlaceHandle
        if (!path.PlaceHandle.TryGetTopic (path.TopicId, out var topicHandle)) {
            await Error(context, null);
            return;
            }


        // Get the topic handle from Place



        //if (!Forum.TryGetTopic(path, out var projectHandle, out var topicHandle)) {
        //    await Error(context, null);
        //    return;
        //    }

        await PageHeader(annotations);
        annotations.PageTopic(topicHandle);
        await PageFooter(annotations);

        await Task.CompletedTask;

        }

    public async Task GetPost(
                ParsedPath path) {
        var context = path.Context;

        var annotations = Annotations.Get(this, context, path);

        if (!Forum.TryGetPost(path, out var projectHandle, out var topicHandle, out var postHandle)) {
            await Error(context, null);
            return;
            }

        annotations.StartPage($"{projectHandle.LocalName}: Topic {topicHandle.LocalName}");
        annotations.PagePost(postHandle);
        annotations.End();

        await Task.CompletedTask;

        }



    public async Task GetUser(
                ParsedPath path) {
        var context = path.Context;

        var annotations = Annotations.Get(this, context, path);

        if (!Forum.TryGetMemberRecord(path, out var memberHandle)) {
            await Error(context, null);
            return;
            }


        annotations.StartPage($"{Forum.Name}: Member {path.Member.LocalName}");
        annotations.PageMember(memberHandle);
        annotations.End();

        await Task.CompletedTask;
        }


    #endregion

    public async Task GetAddDocument(
                ParsedPath path) {
        var context = path.Context;

        var annotations = Annotations.Get(this, context, path);
        await GetPlacePage(path, annotations, annotations.PageAddDocument);
        }
    public async Task GetAddTopic(
                ParsedPath path) {
        var context = path.Context;

        var annotations = Annotations.Get(this, context, path);
        await GetPlacePage(path, annotations, annotations.PageAddTopic);
        }







    public async Task WritePage(
            Annotations annotations,
            ResourceHandle resourceHandle,
            bool commentForm = true) {

        annotations.StartPage($"{Forum.Name}: Document {resourceHandle.LocalName}", "annotate.js");
        var anchor = $"/Comment/{resourceHandle.PlaceHandle.Uid}/{resourceHandle.Uid}";

        try {
            resourceHandle.ParsedContent.ToHTML(annotations._Output,
                anchor, resourceHandle.Annotations, Forum);
            }
        catch {
            }

        //await annotations.WriteDocument(resourceHandle);
        annotations.FooterComment();
        annotations.End();

        await Task.CompletedTask;
        }





    #endregion
    #region // Dialog pages - Create Account / Place / Document / Reaction


    public Task GetCreatePlace(
                ParsedPath path) {
        var context = path.Context;
        var member = path.Member;

        var annotations = Annotations.Get(this, context, path);


        annotations.StartPage($"{Forum.Name}: Create Place");
        annotations.CreatePlace();
        annotations.End();

        return Task.CompletedTask;
        }

    public Task GetCommentForm(
                ParsedPath path) {
        var context = path.Context;


        var annotations = Annotations.Get(this, context, path);
        annotations.PageEnterComment(path, CommentMode.Annotation);
        annotations.End();
        return Task.CompletedTask;
        }

    public Task GetPostForm(
                ParsedPath path) {
        var context = path.Context;

        var annotations = Annotations.Get(this, context, path);
        annotations.PageEnterComment(path, CommentMode.Post);
        annotations.End();
        return Task.CompletedTask;
        }

    public Task GetPostCommentForm(
                ParsedPath path) {
        var context = path.Context;

        var annotations = Annotations.Get(this, context, path);
        annotations.PageEnterComment(path, CommentMode.Comment);
        annotations.End();
        return Task.CompletedTask;
        }


    public Task GetListActions(
                ParsedPath path) {
        var context = path.Context;

        var annotations = Annotations.Get(this, context, path);

        annotations.StartPage($"{Forum.Name}: User {"TBS"}");
        annotations.PageActions();
        annotations.End();

        return Task.CompletedTask;
        }

    public async Task Error(
            HttpListenerContext context,
            ParsedPath path) {
        var annotations = Annotations.Get(this, context, path);
        await ErrorPage(annotations);
        }



    public async Task Error(
                ParsedPath path) {
        var context = path.Context;
        var annotations = Annotations.Get(this, context, path);
        await ErrorPage(annotations);
        }

    public Task ErrorPage(
            Annotations annotations) {

        annotations.StartPage($"{Forum.Name}: Error");
        annotations.PageError();
        annotations.End();

        return Task.CompletedTask;
        }
    #endregion
    #region // Server Post Pages

    public async Task PostCreatePlace(
                ParsedPath path) {
        var context = path.Context;
        var fields = new FormDataPlace();
        var annotations = Annotations.PostForm(this, fields, path);


        var place = new CatalogedPlace {
            Uid = Udf.Nonce(),
            LocalName = fields.Name,
            Description = fields.Description
            };

        var placeHandle = Forum.CreatePlace(place);

        await annotations.Redirect(context, place.HomeUri);
        }


    public async Task PostUploadDocument(
                ParsedPath path) {
        var context = path.Context;
        Forum.TryGetPlace(path.FirstId, out var place).AssertTrue(NYI.Throw);


        var fields = new FormDataDocument();

        var annotations = Annotations.PostForm(this, fields, path);

        var contentType = "text/xml";
        var resourceRecord = new CatalogedResource() {
            Uid = Udf.Nonce(),
            LocalName = fields.Name,
            Description = fields.Description,
            ContentType = contentType
            };
        var resourceHandle = place.AddResource(resourceRecord, fields.Data);
        await annotations.Redirect(context, resourceHandle.Anchor);
        }

    public async Task PostCreateTopic(
                ParsedPath path) {
        var context = path.Context;

        //Forum.TryGetPlace(path.FirstId, out var place).AssertTrue(NYI.Throw);

        var place = path.PlaceHandle;
        var fields = new FormDataDocument();

        var annotations = Annotations.PostForm(this, fields, path);

        var resourceRecord = new CatalogedTopic() {
            Uid = Udf.Nonce(),
            LocalName = fields.Name,
            Description = fields.Description,
            };
        var resourceHandle = place.AddTopic(resourceRecord);

        await annotations.Redirect(context, $"/Topic/{resourceRecord.Uid}");

        }

    public async Task PostComment(
                ParsedPath path) {
        var context = path.Context;
        var fields = new FormDataComment();
        var annotations = Annotations.PostForm(this, fields, path);

        //Annotations.PostComment(this, context);

        Forum.TryGetPlace(path.FirstId, out var projectHandle);
        projectHandle.TryGetResource(path.SecondId, out var resourceHandle);


        var response = new CatalogedAnnotation() {
            Uid = Udf.Nonce(),
            MemberId = path.Member.Uid,
            Text = fields.Comment,
            Anchor = fields.FragmentId,
            Semantic = fields.Semantic
            };
        resourceHandle.AddReaction(response);

        await annotations.Redirect(context, $"/Document/{path.FirstId}/{path.SecondId}/Redirect");
        }


    public async Task PostPost(
                ParsedPath path) {
        var context = path.Context;
        var fields = new FormDataComment();
        var annotations = Annotations.PostForm(this, fields, path);

        Forum.TryGetTopic(path, out var project, out var topic).AssertTrue(NYI.Throw);
        var response = new CatalogedPost() {
            Uid = Udf.Nonce(),
            Added = DateTime.UtcNow,
            MemberId = path.Member.Uid,
            Text = fields.Comment,
            Subject = fields.Subject,
            Semantic = fields.Semantic
            };
        topic.AddReaction(response);

        await annotations.Redirect(context, topic.Anchor);
        }

    public async Task PostPostComment(
                ParsedPath path) {
        var context = path.Context;
        var fields = new FormDataComment();
        var annotations = Annotations.PostForm(this, fields, path);

        if (!Forum.TryGetPost(path, out var placeHandle, out var topicHandle, out var postHandle)) {
            await Error(context, null);
            return;
            }

        var response = new CatalogedComment() {
            Uid = Udf.Nonce(),
            MemberId = path.Member.Uid,
            Text = fields.Comment,
            Added = DateTime.UtcNow
            };
        postHandle.AddReaction(response);

        await annotations.Redirect(context, postHandle.Anchor);
        }

    #endregion





    }



