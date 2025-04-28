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
/// <summary>
/// Extensions class. Provides static convenience extensions.
/// </summary>
public static partial class Extensions {


    public static string GetFileType(this string file) {
        var extension = Path.GetExtension(file).ToLower();

        return extension switch {
            ".htm" or "html" => "text/html",
            ".txt" => "text/plain",
            ".css" => "text/css",
            ".script" => "text/javascript",
            ".jpg" or "jpeg" => "image/jpeg",
            ".gif" => "image/gif",
            ".png" => "image/png",
            ".svg" => "image/svg+xml",
            ".jscontact" => "application/jscontact",
            _ => "text/plain"
            };


        }


    public static void Respond(
                this HttpListenerContext context,
                byte[] data,
                string contentype,
                bool keepAlive = false) {
        var response = context.Response;
        response.StatusCode = (int)HttpStatusCode.OK;
        response.StatusDescription = "OK";
        response.ContentType = contentype;
        response.ContentLength64 = data.Length;
        response.KeepAlive = keepAlive;
        response.OutputStream.Write(data, 0, data.Length);
        response.OutputStream.Close();
        }
    }
