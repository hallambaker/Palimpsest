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

using System.Text;

namespace Goedel.Places;

public record NonceDns(
            string Nonce,
            string? Place=null,
            string? Handle=null
                ) {

    public string Uri(string host, string local) {
        var builder = new StringBuilder();
        builder.Append("https://");
        builder.Append(host);
        builder.Append("/");
        builder.Append(local);
        Query(builder);
        return builder.ToString();
        }


    public string State() {
        var builder = new StringBuilder();
        Query(builder);
        return builder.ToString();
        }

    public void Query(StringBuilder builder) {
        builder.Append("?nonce=");
        builder.Append(Nonce);
        if (Place is not null) {
            builder.Append("&place=");
            builder.Append(HttpUtility.UrlEncode(Place));
            }
        if (Handle is not null) {
            builder.Append("&handle=");
            builder.Append(HttpUtility.UrlEncode(Handle));
            }

        }


    //=> $"https://{host}/{local}?nonce={Nonce}&dns={Place}";
    //public string UriHandle(string handle, string local) => $"https://{Dns}/{local}?nonce={Nonce}&dns={handle}";
    public static NonceDns Parse(string query, string handle=null) {
        var paramsCollection = HttpUtility.ParseQueryString(query);
        var nonce = paramsCollection["nonce"];
        var host = paramsCollection["place"];
        handle ??= paramsCollection["handle"];

        return new NonceDns(nonce, host, handle);
        }
    }
