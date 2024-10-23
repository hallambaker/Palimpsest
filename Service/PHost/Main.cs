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


using Goedel.IO;
using Goedel.Palimpsest;
using Goedel.Protocol;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Windows.ApplicationModel.DataTransfer;

using static System.Net.Mime.MediaTypeNames;

namespace Annotate;

internal sealed class Program {

    // We can decorate this with stuff later.
    static void Main(string[] args) {
        var directory = args[0];
        var resources = args[1];

        var forum = Forum.Create(directory, resources, "The Draft");

        var AnnotationService = new AnnotationService(forum);
        AnnotationService.Start();
        }





    }


public class AnnotationService: IWebService {
    public Forum Forum { get; }
    private HttpListener HttpListener { get; set; }

    ///<inheritdoc/>
    public Dictionary<string, WebResource> ResourceMap => resourceMap;
    
    static Dictionary<string, WebResource> resourceMap = new() {
        { "", new (GetHome) },
        { "resources", new (GetResources) },
        { "favicon.ico", new (GetResources) },
        { "SignIn", new (GetSignIn) },
        { "SignOut", new (GetSignOut) },
        { "CreateAccount", new (GetCreateAccount) },
        { "CreateProject", new (GetCreateProject) },

        { "Upload", new (GetSelectUpload) },
        { "Append", new (PostUploadDocument) },
        { "Documents", new (GetListDocuments) },
        { "Actions", new (GetListActions) },
        { "Document", new (GetShowDocument) },
        { "Comment", new (GetComment) },
        { "CommentForm", new (MakeComment) },
        { "*", new (Error) }

        };


    public AnnotationService (Forum forum) {
        Forum = forum;
        HttpListener = new();
        HttpListener.Prefixes.Add("http://+:15099/");
        }


    public void Start() {
        HttpListener.Start();
        Console.WriteLine("Listening...");
        while (true) {
            HttpListenerContext context = HttpListener.GetContext();

            var task = HandleRequest(context);
            }
        }


    public async Task HandleRequest(HttpListenerContext context) {

        var request = context.Request;
        var response = context.Response;

        // This should never happen.
        if (request.Url is null) {
            await Error(this, context);
            return; 
            }


        Console.WriteLine($"Request {request.Url.LocalPath}");


        var parsed = new ParsedPath(request.Url.LocalPath);


        Console.WriteLine($"Start {parsed.Command}");

        // Look for a dispatch method and use it if found.
        if (ResourceMap.TryGetValue(parsed.Command, out var callback)) {
            await callback.Method(this, context);
            }
        else {
            await Error(this, context);
            }
        }



    public static async Task GetHome(
                IWebService service,
                HttpListenerContext context) {
        var annotation = service as AnnotationService;
        var annotations = Annotations.Get(annotation, context);
        annotations.PageHome();
        annotations.End();
        }


    public static async Task GetResources(
        IWebService service,
        HttpListenerContext context) {
        using var response = context.Response;
        var annotation = service as AnnotationService;

        Console.WriteLine("Helllooooo..");

        string path;
        var stroke = context.Request.Url.LocalPath.IndexOf('/', 1);
        if (stroke < 0) {
            path = annotation.Forum.Resources + context.Request.Url.LocalPath;
            }
        else {
            path = annotation.Forum.Resources + context.Request.Url.LocalPath[stroke..];
            }


        response.StatusCode = (int)HttpStatusCode.OK;
        response.StatusDescription = "Status OK";
        response.ContentType = path.GetFileType();

        using var file = path.OpenFileReadShared();

        file.CopyTo(response.OutputStream);

        response.OutputStream.Close();
        Console.WriteLine("Doneeeee..");
        }

    public static async Task GetSignIn(
                IWebService service,
                HttpListenerContext context) {
        var annotation = service as AnnotationService;
        var annotations = Annotations.Get(annotation, context);
        annotations.PageHome();
        annotations.End();
        }

    public static async Task GetSignOut(
            IWebService service,
            HttpListenerContext context) {
        var annotation = service as AnnotationService;
        var annotations = Annotations.Get(annotation, context);
        annotations.PageHome();
        annotations.End();
        }



    public static async Task GetCreateAccount(
            IWebService service,
            HttpListenerContext context) {
        var annotation = service as AnnotationService;
        var annotations = Annotations.Get(annotation, context);
        annotations.PageHome();
        annotations.End();
        }

    public static async Task GetCreateProject(
                IWebService service,
                HttpListenerContext context) {
        var annotation = service as AnnotationService;
        var annotations = Annotations.Get(annotation, context);
        annotations.PageSelect();
        annotations.End();
        }

    public static async Task GetSelectUpload(
        IWebService service,
        HttpListenerContext context) {
        var annotation = service as AnnotationService;
        var annotations = Annotations.Get(annotation, context);
        annotations.PageSelect();
        annotations.End();
        }


    public static async Task MakeComment(
            IWebService service,
            HttpListenerContext context) {
        var annotation = service as AnnotationService;
        var annotations = Annotations.Get(annotation, context);
        annotations.PageEnterComment();
        annotations.End();
        }


    public static async Task GetComment(
                IWebService service,
                HttpListenerContext context) {
        var annotation = service as AnnotationService;
        Annotations.PostComment(annotation, context);


        }


    public static async Task PostUploadDocument (
                IWebService service,
                HttpListenerContext context) {
        var annotation = service as AnnotationService;
        var fields = new FormDataUpload();

        var annotations = Annotations.PostForm(annotation, context, fields);

        //ParsedMultipart.Parse(annotations.PostData);


        annotations.PageUpload();
        annotations.End();
        }

    public static async Task GetListDocuments(
                IWebService service,
                HttpListenerContext context) {
        var annotation = service as AnnotationService;
        var annotations = Annotations.Get(annotation, context);
        annotations.PageDocuments();
        annotations.End();
        }

    public static async Task GetListActions(
                IWebService service,
                HttpListenerContext context) {
        var annotation = service as AnnotationService;
        var annotations = Annotations.Get(annotation, context);
        annotations.PageActions();
        annotations.End();
        }

    public static async Task GetShowDocument(
                IWebService service,
                HttpListenerContext context) {
        var annotation = service as AnnotationService;
        var annotations = Annotations.Get(annotation, context);
        annotations.PageDocument();
        annotations.End();
        }

    public static async Task Error(
                IWebService service,
                HttpListenerContext context) {
        var annotation = service as AnnotationService;
        var annotations = Annotations.Get(annotation, context);
        annotations.PageHome();
        annotations.End();
        }


    }



public record ParsedPath {

    public string Command { get; }
    public string? Document { get; } = null;

    public ParsedPath(string url) {
        if (url == null) {
            Command = null;
            return;
            }
        var split = url.Split('/');
        if (split.Length < 2) { // must have at least initial /
            Command = null;
            return;
            }

        Command = split[1];


        }

    }





public class FormDataUpload : FormData {

    protected override FormItem[] Items => items;
    static readonly FormItem[] items = [
        new ("data", FormEntryType.File, (form, s) => ((FormDataUpload)form).Data = s as FileField),
        new ("format", FormEntryType.String, (form, s) => ((FormDataUpload)form).Format = s as string)
        ];

    string? Format {get; set; }
    FileField? Data { get; set; }
        

    }


public class FormDataComment : FormData {

    protected override FormItem[] Items => items;
    static readonly FormItem[] items = [
        new ("user", FormEntryType.String, (form, s) => ((FormDataComment)form).User = s as string),
        new ("semantic", FormEntryType.String, (form, s) => ((FormDataComment)form).Semantic = s as string),
        new ("comment", FormEntryType.String, (form, s) => ((FormDataComment)form).Comment = s as string)
        ];

    string? User { get; set; }
    string? Semantic { get; set; }
    string? Comment { get; set; }

    }




public class PageOptions {
    }
