﻿#region // Copyright - MIT License
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


using Goedel.Palimpsest;

namespace Annotate;





/// <summary>
/// Annotations class.
/// </summary>
public class Annotation  {


    public string User { get; set; }
    public string Anchor { get; set; }

    public string Semantic { get; set; }

    public string Text { get; set; }

    public bool Written { get; set; } = false;


    public List<string> References { get; set; }

    public Annotation() {
        }

    public Annotation(string user, string anchor, string text, string semantic = null) {
        User = user;
        Anchor = anchor;
        Semantic = semantic;
        References = new List<string>();
        Text = text;
        }


    }


public partial class Annotations {

    public Forum Forum => Annotation.Forum;


    public bool SignedIn => VerifiedAccount != null;

    public bool PermissionCreateProject => SignedIn;

    public bool PermissionUploadDocument => SignedIn;

    public string? VerifiedAccount { get; set; } = null;


    public AnnotationService Annotation { get; init; }
    public HttpListenerContext Context { get; init; }

    HttpListenerResponse Response => Context.Response;

    public PageOptions pageOptions = new PageOptions();


    public string UserName { get; set; } = "Fred";

    public byte[] PostData { get; set; }


    public static void PostComment(
                AnnotationService annotation,
                HttpListenerContext context) {

        var comment = JsonSerializer.Deserialize<Annotation>(context.Request.InputStream);

        }


    public static Annotations Get(
                AnnotationService? annotation,
                HttpListenerContext context) {
        var writer = new StreamWriter(context.Response.OutputStream);
        var result = new Annotations() {
            Annotation = annotation,
            Context = context,
            _Output = writer
            };

        result.Start();
        return result;
        }


    public static Annotations PostForm(
            AnnotationService? annotation,
            HttpListenerContext context,
            FormData formData
            ) {
        var result = Get(annotation, context);
        ParsedMultipart.Parse(context.Request.InputStream, formData);
        return result;
        }






     void Start () {
        StartPage();
        }

    public void End() {
        EndPage();
        _Output.Flush();
        Response.OutputStream.Close();
        }


    }