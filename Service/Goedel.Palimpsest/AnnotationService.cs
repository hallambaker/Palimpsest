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


using DocumentFormat.OpenXml.Spreadsheet;

using Goedel.IO;
using Goedel.Palimpsest;

using System.Net.Mime;

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

public class AnnotationService : IWebService<ParsedPath> {

    #region // Properties
    ///<summary>The persistent data store</summary> 
    public Forum Forum { get; }

    ///<summary>The HTTP listener</summary> 
    private HttpListener HttpListener { get; set; }


    private string HttpEndpoint => "http://+:15099/";
    private string HttpsEndpoint => "https://+:15098/";

    public string HomeUrl => "/";

    ///<inheritdoc/>
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

        ResourceMap = new Dictionary<string, WebResource<ParsedPath>>{
            { "", new (GetHome, false) },

            // public pages, visible to all users but with possibly reduced functionality
            { PalimpsestConstants.resources, new (GetResources,false) },
            { PalimpsestConstants.SignIn, new (GetSignIn, false) },
            { PalimpsestConstants.SignInPost, new (PostSignIn, false) },
            { PalimpsestConstants.CreateAccount, new (GetCreateAccount, false) },
            { PalimpsestConstants.CreateAccountPost, new (PostCreateAccount, false) },

            // private pages, requires log in
            { PalimpsestConstants.SignOut, new (GetSignOut) },
            { PalimpsestConstants.Project, new (GetProject) },
            { PalimpsestConstants.AddDocument, new (GetAddDocument) },
            { PalimpsestConstants.AddTopic, new (GetAddTopic) },


            { PalimpsestConstants.WellKnown, new (GetWellKnown) },

            { PalimpsestConstants.Document, new (GetDocument) },
            { PalimpsestConstants.Topic, new (GetTopic) },
            { PalimpsestConstants.Post, new (GetPost) },
            { PalimpsestConstants.User, new (GetUser) },
                
            { PalimpsestConstants.CreateProject, new (GetCreateProject) },
            { PalimpsestConstants.CreateProjectPost, new (PostCreateProject) },
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

        Console.WriteLine($"Request {request.Url.LocalPath}");
        var parsed = new ParsedPath(request, Forum);

        Console.WriteLine($"Start {parsed.Command} Project {parsed.FirstId} Document {parsed.SecondId}");

        // Look for a dispatch method and use it if found.
        if (ResourceMap.TryGetValue(parsed.Command, out var callback)) {
            if ((parsed.Member is null) & callback.SignedIn) {
                await GetSignIn(context, parsed);
                return;
                }

            await callback.Method(context, parsed);
            }
        else {
            await Error(context, null);
            }
        }

    #endregion


    public Task CompletedTask => Task.CompletedTask;


    #region // Server Get Pages - primary

    public async Task GetHome(
                HttpListenerContext context,
                ParsedPath path) {
        var member = path.Member;

        var annotations = Annotations.Get(this, context, member);

        annotations.StartPage(Forum.Name);
        annotations.PageHome();
        annotations.End();

        await Task.CompletedTask;
        }

    public async Task GetProjectPage(
            HttpListenerContext context,
                ParsedPath path,
                Annotations annotations,
                Action<ProjectHandle> page) {
        Forum.TryGetProject(path.FirstId, out var projectHandle);
        annotations.StartPage($"{Forum.Name}: Project {projectHandle.LocalName}");
        page(projectHandle);
        annotations.End();

        await Task.CompletedTask;
        }


    #region // Sign in/out
    public Task GetSignIn(
            HttpListenerContext context,
            ParsedPath path) {
        var member = path.Member;

        var annotations = Annotations.Get(this, context, member);

        annotations.StartPage($"{Forum.Name}: Sign In");
        annotations.SignIn(path);
        annotations.End();

        return Task.CompletedTask;
        }

    public Task GetSignOut(
                HttpListenerContext context,
                ParsedPath path) {
        var member = path.Member;

        var annotations = Annotations.Get(this, context, member);

        // clear the HTTP cookie
        var cookie = ServerCookieManager.ClearCookie(
        PalimpsestConstants.CookieTypeSessionTag);
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
    #region // Resources
    public Task GetResources(
    HttpListenerContext context,
    ParsedPath path) {
        var member = path.Member;
        using var response = context.Response;

        string filePath;
        var stroke = context.Request.Url.LocalPath.IndexOf('/', 1);
        if (stroke < 0) {
            filePath = Forum.Resources + path.FirstId;
            }
        else {
            filePath = Forum.Resources + context.Request.Url.LocalPath[stroke..];
            }

        response.StatusCode = (int)HttpStatusCode.OK;
        response.StatusDescription = "Status OK";
        response.ContentType = filePath.GetFileType();

        using var file = filePath.OpenFileReadShared();
        file.CopyTo(response.OutputStream);

        response.OutputStream.Close();

        return Task.CompletedTask;
        } 
    #endregion
    #region // Item pages

    public async Task GetProject(
            HttpListenerContext context,
                ParsedPath path) {
        var member = path.Member;
        var annotations = Annotations.Get(this, context, member);
        await GetProjectPage(context, path, annotations, annotations.PageProject);
        }



    public async Task GetDocument(
            HttpListenerContext context,
                ParsedPath path) {
        var member = path.Member;
        var annotations = Annotations.Get(this, context, member);

        // need to modify this to get the project and account ids
        Forum.TryGetProject(path.FirstId, out var projectHandle);
        projectHandle.TryGetResource(path.SecondId, out var resourceHandle);

        await WritePage(annotations, resourceHandle);

        }


    public async Task GetTopic(
        HttpListenerContext context,
            ParsedPath path) {
        var annotations = Annotations.Get(this, context, path);

        if (!Forum.TryGetTopic(path, out var projectHandle, out var topicHandle)) {
            await Error(context, null);
            return;
            }

        annotations.StartPage($"{projectHandle.LocalName}: Topic {topicHandle.LocalName}");
        annotations.PageTopic(topicHandle);
        annotations.End();

        await Task.CompletedTask;

        }

    public async Task GetPost(
            HttpListenerContext context,
            ParsedPath path) {
        var member = path.Member;
        var annotations = Annotations.Get(this, context, member);

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
            HttpListenerContext context,
                ParsedPath path) {
        var member = path.Member;

        var annotations = Annotations.Get(this, context, member);

        if (!Forum.TryGetMemberRecord(path, out var memberHandle)) {
            await Error(context, null);
            return;
            }


        annotations.StartPage($"{Forum.Name}: Member {member.LocalName}");
        annotations.PageMember(memberHandle);
        annotations.End();

        await Task.CompletedTask;
        }


    #endregion

    public async Task GetAddDocument(
    HttpListenerContext context,
        ParsedPath path) {
        var member = path.Member;
        var annotations = Annotations.Get(this, context, member);
        await GetProjectPage(context, path, annotations, annotations.PageAddDocument);
        }
    public async Task GetAddTopic(
        HttpListenerContext context,
            ParsedPath path) {
        var member = path.Member;
        var annotations = Annotations.Get(this, context, member);
        await GetProjectPage(context, path, annotations, annotations.PageAddTopic);
        }







    public async Task WritePage(
            Annotations annotations,
            ResourceHandle resourceHandle,
            bool commentForm = true) {

        annotations.StartPage($"{Forum.Name}: Document {resourceHandle.LocalName}", "annotate.js");
        var anchor = $"/Comment/{resourceHandle.ProjectHandle.Uid}/{resourceHandle.Uid}";

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
    #region // Dialog pages - Create Account / Project / Document / Reaction






    public  Task GetCreateAccount(
                HttpListenerContext context,
                ParsedPath path) {
        var member = path.Member;


        var annotations = Annotations.Get(this, context, member);

        annotations.StartPage($"{Forum.Name}: Create Account");
        annotations.CreateAccount();
        annotations.End();

        return Task.CompletedTask;
        }

    public  Task GetCreateProject(
                HttpListenerContext context,
                ParsedPath path) {
        var member = path.Member;

        var annotations = Annotations.Get(this, context, member);


        annotations.StartPage($"{Forum.Name}: Create Project");
        annotations.CreateProject();
        annotations.End();

        return Task.CompletedTask;
        }

    public Task GetCommentForm(
                HttpListenerContext context,
                ParsedPath path) {
        var member = path.Member;

        var annotations = Annotations.Get(this, context, member);
        annotations.PageEnterComment(path, CommentMode.Annotation);
        annotations.End();
        return Task.CompletedTask;
        }

    public Task GetPostForm(
            HttpListenerContext context,
            ParsedPath path) {
        var member = path.Member;

        var annotations = Annotations.Get(this, context, member);
        annotations.PageEnterComment(path, CommentMode.Post);
        annotations.End();
        return Task.CompletedTask;
        }

    public Task GetPostCommentForm(
            HttpListenerContext context,
            ParsedPath path) {
        var member = path.Member;

        var annotations = Annotations.Get(this, context, member);
        annotations.PageEnterComment(path, CommentMode.Comment);
        annotations.End();
        return Task.CompletedTask;
        }




    public   Task GetListActions(
                HttpListenerContext context,
                ParsedPath path) {
        var member = path.Member;
        var annotations = Annotations.Get(this, context, member);

        annotations.StartPage($"{Forum.Name}: User {"TBS"}");
        annotations.PageActions();
        annotations.End();

        return Task.CompletedTask;
        }


    public  async Task Error(
                HttpListenerContext context,
                ParsedPath path) {
        var annotations = Annotations.Get(this, context, path);
        await ErrorPage(annotations);
        }

    public   Task ErrorPage(
            Annotations annotations) {

        annotations.StartPage($"{Forum.Name}: Error");
        annotations.PageError();
        annotations.End();

        return Task.CompletedTask;
        }
    #endregion
    #region // Server Post Pages

    public async Task PostCreateAccount(
                HttpListenerContext context,
                ParsedPath path) {
        var member = path.Member;

        var fields = new FormDataAccount();

        var annotations = Annotations.PostForm(this, context, member, fields);
        if (!fields.ValidateCreate()) {
            await ErrorPage(annotations);
            return;
            }

        // here we need to create a cataloged account entry
        var memberRecord = new CatalogedForumMember() {
            LocalName = fields.Username
            };

        member = Forum.AddMember(memberRecord, fields.Password);
        annotations.VerifiedAccount = member;

        var cookie = Forum.ServerCookieManager.GetCookie(
                    PalimpsestConstants.CookieTypeSessionTag, memberRecord._PrimaryKey);
        context.Response.Cookies.Add(cookie);


        await annotations.Redirect(context, HomeUrl);
        }

    public async Task PostCreateProject(
                HttpListenerContext context,
                ParsedPath path) {
        var member = path.Member;
        var fields = new FormDataProject();

        var annotations = Annotations.PostForm(this, context, member, fields);


        var project = new CatalogedProject {
            Uid = Udf.Nonce(),
            LocalName = fields.Name,
            Description = fields.Description
            };

        var projectHandle = Forum.CreateProject(project);

        await annotations.Redirect(context, $"/Project/{project.Uid}");
        }

    public async Task PostSignIn(
                HttpListenerContext context,
                ParsedPath path) {
        var member = path.Member;


        var fields = new FormDataAccount();

        var annotations = Annotations.PostForm(this, context, member, fields);
        if (!fields.ValidateSignIn()) {
            await ErrorPage(annotations);
            return;
            }

        if (Forum.TryGetVerifiedMemberHandle(
                fields.Username, fields.Password, out var handle)) {

            annotations.VerifiedAccount = handle;

            var cookie = Forum.ServerCookieManager.GetCookie(
            PalimpsestConstants.CookieTypeSessionTag, handle.CatalogedMember._PrimaryKey);

            context.Response.Cookies.Add(cookie);
            }

        var url = fields.From ?? HomeUrl;

        await annotations.Redirect(context, url);
        }   

    public async Task PostUploadDocument(
                HttpListenerContext context,
                ParsedPath path) {
        var member = path.Member;
        Forum.TryGetProject(path.FirstId, out var project).AssertTrue(NYI.Throw);


        var fields = new FormDataDocument();

        var annotations = Annotations.PostForm(this, context, member, fields);

        var contentType = "text/xml";
        var resourceRecord = new CatalogedResource() {
            Uid = Udf.Nonce(),
            LocalName = fields.Name,
            Description = fields.Description,
            ContentType = contentType
            };
        var resourceHandle = project.AddResource(resourceRecord, fields.Data);
        await annotations.Redirect(context, resourceHandle.Anchor);
        }

    public async Task PostCreateTopic(
                HttpListenerContext context,
                ParsedPath path) {
        var member = path.Member;
        Forum.TryGetProject(path.FirstId, out var project).AssertTrue(NYI.Throw);


        var fields = new FormDataDocument();

        var annotations = Annotations.PostForm(this, context, member, fields);

        var resourceRecord = new CatalogedTopic() {
            Uid = Udf.Nonce(),
            LocalName = fields.Name,
            Description = fields.Description,
            };
        var resourceHandle = project.AddTopic(resourceRecord);

        await annotations.Redirect(context, $"/Topic/{path.FirstId}/{resourceRecord.Uid}/Redirect");

        }

    public async Task PostComment(
                HttpListenerContext context,
                ParsedPath path) {
        var member = path.Member;

        var fields = new FormDataComment();
        var annotations = Annotations.PostForm(this, context, member, fields);

        //Annotations.PostComment(this, context);

        Forum.TryGetProject(path.FirstId, out var projectHandle);
        projectHandle.TryGetResource(path.SecondId, out var resourceHandle);


        var response = new CatalogedAnnotation() {
            Uid = Udf.Nonce(),
            MemberId = member.Uid,
            Text = fields.Comment,
            Anchor = fields.FragmentId,
            Semantic = fields.Semantic
            };
        resourceHandle.AddReaction(response);

        await annotations.Redirect(context, $"/Document/{path.FirstId}/{path.SecondId}/Redirect"); 
        }


    public async Task PostPost(
            HttpListenerContext context,
            ParsedPath path) {
        var member = path.Member;

        var fields = new FormDataComment();
        var annotations = Annotations.PostForm(this, context, member, fields);

        Forum.TryGetTopic(path, out var project, out var topic).AssertTrue(NYI.Throw);
        var response = new CatalogedPost() {
            Uid = Udf.Nonce(),
            Added = DateTime.UtcNow,
            MemberId = member.Uid,
            Text = fields.Comment,
            Subject = fields.Subject,
            Semantic = fields.Semantic
            };
        topic.AddReaction(response);

        await annotations.Redirect(context, topic.Anchor);
        }

    public async Task PostPostComment(
            HttpListenerContext context,
            ParsedPath path) {
        var member = path.Member;

        var fields = new FormDataComment();
        var annotations = Annotations.PostForm(this, context, member, fields);

        if (!Forum.TryGetPost(path, out var projectHandle, out var topicHandle, out var postHandle)) {
            await Error(context, null);
            return;
            }

        var response = new CatalogedComment() {
            Uid = Udf.Nonce(),
            MemberId = member.Uid,
            Text = fields.Comment,
            Added = DateTime.UtcNow
            };
        postHandle.AddReaction(response);

        await annotations.Redirect(context, postHandle.Anchor);
        }

    #endregion

    public async Task GetWellKnown(
            HttpListenerContext context,
            ParsedPath path) {
        var member = path.Member;

        var annotations = Annotations.Get(this, context, member);

        annotations.StartPage(Forum.Name);
        annotations.PageHome();
        annotations.End();

        await Task.CompletedTask;
        }


    }
