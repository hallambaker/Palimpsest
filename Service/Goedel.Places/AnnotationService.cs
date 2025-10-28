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


using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Drawing.Diagrams;

using Goedel.Protocol;
using Goedel.Sitebuilder;

using System.Net;
using System.Net.Mail;

namespace Goedel.Places;


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
    //public Forum Forum { get; }



    ///<summary>The HTTP listener</summary> 
    private HttpListener HttpListener { get; set; }

    ///<summary>The local HTTP Endpoint (will be overriden)</summary>
    private string HttpEndpoint => "http://+:15099/";

    ///<summary>The local HTTPS Endpoint (will be overriden)</summary>
    private string HttpsEndpoint => "https://+:15098/";

    ///<summary>The frame defintions being serviced.</summary>
    public FrameSet FrameSet { get; }

    ///<summary>The persisted place.</summary>
    public IPersistPlace PersistPlace { get; }


    ///<summary>State management interface to keep us logged in.</summary>
    public ServerCookieManager ServerCookieManager { get; } = new();

    ///<summary>DNS Client</summary>
    public DnsClient DnsClient { get; }

    ///<summary>Earl Client</summary>
    public EarlClient EarlClient { get; }

    ///<summary>Domain (will be replaced)</summary>
    public string Domain => "mplace2.social";

    ///<summary>The Client endpoint.</summary>
    public string ClientEndpoint => $"https://{Domain}/";

    ///<summary>Sign in endpoint</summary>
    public string SignInEndpoint => ClientEndpoint + PalimpsestConstants.SignIn;

    ///<summary>Location of the client metadata</summary>
    public string ClientMetadataLocation => ClientEndpoint + PalimpsestConstants.ClientMetadata;

    ///<summary>Redirect location for OAUTH.</summary>
    public string RedirectLocation => ClientEndpoint + PalimpsestConstants.Redirect;


    public Dictionary<string, Func<ParsedPath, Task>> Callbacks { get; }



    ///<summary>The Oauth Client</summary>
    public OauthClient OauthClient { get; }

    ///<summary>Oauth client signature key</summary>
    public KeyPair OauthClientSignature { get; set; }

    ///<summary>Oauth client encryption key</summary>
    public KeyPair OauthClientEncryption { get; set; }

    public JWKS JWKS { get; set; }



    public Dictionary<string, WebResource<ParsedPath>> ResourceMap { get; }


    public TextWriter LogFile { get; set; }
    #endregion
    #region // Constructor


    static AnnotationService() {
        JmapBaseSchema._Initialized.AssertTrue(NYI.Throw);
        Goedel.Contacts.Contacts._Initialized.AssertTrue(NYI.Throw);
        }


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
    public AnnotationService(FrameSet frameset, IPersistPlace persistPlace) {

        FrameSet = frameset;
        PersistPlace = persistPlace;

        HttpListener = new();
        HttpListener.Prefixes.Add(HttpEndpoint);
        HttpListener.Prefixes.Add(HttpsEndpoint);

        //// Bind the OAUTH client here

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

        Callbacks = new() {
            {".well-known", WellKnown},
            {"Resources", Resource},
            {PalimpsestConstants.Redirect,Redirect},
            {PalimpsestConstants.ClientMetadata, ClientMetadata}
            };

        // Bind the services to be made accessible in callbacks.
        PersistPlace.ServerCookieManager = ServerCookieManager;
        PersistPlace.OauthClient = OauthClient;
        PersistPlace.FrameSet = FrameSet;


        }


    #endregion
    #region // The HTTP service and dispatch

    /// <summary>
    /// Start the service
    /// </summary>
    public void Start() {
        HttpListener.Start();
        Console.WriteLine($"Listening {HttpEndpoint}");

        var now = System.DateTime.UtcNow.ToFileSpec();
        var logfile = $"Log{now}.log";

        var logStream = logfile.OpenFileAppendShare();
        LogFile = new StreamWriter(logStream);

        while (true) {
            HttpListenerContext context = HttpListener.GetContext();

            switch (context.Request.HttpMethod) {
                case "GET": {
                    HandleRequestGet(context);
                    break;
                    }
                case "POST": {
                    HandleRequestPost(context);
                    break;
                    }
                }
            }
        }

    private int transactionCount = 0;

    ///<summary>Handle get request asynchronously.</summary> 
    ///<param name="context">The listener context.</param>
    private async Task HandleRequestPost(HttpListenerContext context) {
        
        var path = new ParsedPath(context);
        var response = path.Context.Response;

        if (FrameSet.PageDirectory.TryGetValue(path.Command, out var templatePage)) {
            var form = GetForm(templatePage.Fields, path.Uri.Query[1..]);
            form.AssertNotNull(NYI.Throw);

            var result = form.Factory();
            ParsedMultipartFrame.Bind(result, path.Request.InputStream);

            // Validate the inputs
            var validate = await result.Callback(PersistPlace);
            if (validate.Code == HttpStatusCode.OK) { // Success, redirect to the updated page
                response.Redirect(validate.Redirect ?? "/");
                response.Close();
                return;
                }
            else if (validate.Reactions is not null) { // Input validation failure
                var page = templatePage.GetPage(PersistPlace, path);
                form.Set(page, result);
                await RenderPage(path, page, validate.Reactions);
                return;
                }
            else { // Illegal input
                await Error(path, "bad data", validate.Code);
                return;
                }
            }
        }


    FrameRefForm? GetForm(List<IFrameField> fields, string tag) {
        foreach (var field in fields) {
            if (field.Id == tag) {
                if (field is FrameRefForm menu) {
                    return menu;
                    }
                }
            }

        return null;
        }

    ///<summary>Handle get request asynchronously.</summary> 
    ///<param name="context">The listener context.</param>
    private async Task HandleRequestPut(HttpListenerContext context) {
        }

    ///<summary>Handle get request asynchronously.</summary> 
    ///<param name="context">The listener context.</param>
    private async Task HandleRequestGet(HttpListenerContext context) {
        var request = context.Request;
        var response = context.Response;

        var path = new ParsedPath(context);

        var transactionId = Interlocked.Increment(ref transactionCount);
        var start = DateTime.UtcNow;
        var logEntry = $"{transactionId} {start.ToRFC3339()} {path.RealIp} {path.ExternalUri}";
        LogFile.WriteLine(logEntry);
        LogFile.Flush();

        if (FrameSet.PageDirectory.TryGetValue(path.Command, out var templatePage)) {
            var page = templatePage.GetPage(PersistPlace, path);
            RenderPage(path, page);
            }
        else if (Callbacks.TryGetValue(path.Command, out var callback)) {
            await callback(path);
            }
        else {
            await Error(path, "");
            }

        }


    public async Task RenderPage(ParsedPath path, FramePage page, List<FormReaction>? reactions=null) {

        using var stream = new MemoryStream();
        using var textwriter = new StreamWriter(stream);
        var writer = new PageWriter(page, textwriter) {
            Reactions = reactions};
        writer.Render();
        textwriter.Flush();
        var data = stream.ToArray();

        var response = path.Context.Response;
        response.StatusCode = (int)HttpStatusCode.OK;
        response.Close(data, false);

        return;
        }

    public async Task Error(ParsedPath path, string? message, 
                HttpStatusCode httpStatusCode= HttpStatusCode.NotFound) {

        var response = path.Context.Response;
        response.StatusCode = (int)httpStatusCode;
        response.Close();

        return;
        }


    public async Task WellKnown(ParsedPath path) {
        await Error(path, "", HttpStatusCode.NotImplemented);

        var filePath = FrameSet.ResourceFiles + path.LocalPath;
        var response = path.Context.Response;
        
        response.StatusCode = (int)HttpStatusCode.OK;
        response.StatusDescription = "Status OK";
        response.ContentType = filePath.GetFileType();

        using var file = filePath.OpenFileReadShared();
        file.CopyTo(response.OutputStream);

        response.OutputStream.Close();


        return;
        }


    public async Task Resource(ParsedPath path) {
        var response = path.Context.Response;

        try {
            var filePath = FrameSet.ResourceFiles + path.LocalPath;
            
            response.StatusCode = (int)HttpStatusCode.OK;
            response.StatusDescription = "Status OK";
            response.ContentType = filePath.GetFileType();

            using var file = filePath.OpenFileReadShared();
            file.CopyTo(response.OutputStream);

            response.OutputStream.Close();
            }
        catch (FileNotFoundException) {
            response.StatusCode = (int)HttpStatusCode.NotFound;
            response.OutputStream.Close();
            }

        catch {
            response.StatusCode = (int)HttpStatusCode.RequestEntityTooLarge;
            response.OutputStream.Close();
            }

        return;
        }

    public async Task Redirect(ParsedPath path) {
        var response = path.Context.Response;
        response.StatusCode = (int)HttpStatusCode.NotFound;
        response.OutputStream.Close();
        }

    public async Task ClientMetadata(ParsedPath path) {
        var response = path.Context.Response;
        response.StatusCode = (int)HttpStatusCode.NotFound;
        response.OutputStream.Close();
        }

    #endregion
    #region // Header and footer


    #endregion





    }



