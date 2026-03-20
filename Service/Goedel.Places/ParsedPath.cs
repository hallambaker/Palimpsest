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
using DocumentFormat.OpenXml.Spreadsheet;

namespace Goedel.Places;



public record ParsedPath : IPageContext {

    public HttpListenerContext Context { get; }

    public HttpListenerRequest Request => Context.Request;


    public PageText PageText { get; set; } = PageText.English;

    public FramePage Page { get; set; }

    public IPersistPlace PersistPlace { get; }

    public CatalogedMember? MemberHandle { get; set; }
    //public PlaceHandle PlaceHandle { get; }

    //public string Placename => PlaceHandle?.LocalName;


    public string Command { get; }

    public Uri Uri { get; }

    public string ExternalUri => "https://" + Uri.Host  + Uri.LocalPath;
    public string ExternalUriQuery => "https://" + Uri.Host + Uri.PathAndQuery;
    public string LocalPath => Uri?.LocalPath;

    ///<summary>Holds the project ID or the static resource name</summary> 
    string FirstId { get; }


    ///<summary>Holds the document ID.</summary> 
    string SecondId { get; }

    ///<summary>Holds the fragment ID.</summary> 
    string ThirdId { get; } 

    ///<summary>The original IP address of the request (filled by reverse proxy)</summary> 
    public string RealIp { get; }

    public string ForwardedFor { get; }
    public string? UserId { get; set; } = null;

    CatalogedPlace? CatalogedPlace;
    CatalogedFeed? CatalogedFeed;
    CatalogedPost? CatalogedPost;
    CatalogedComment? CatalogedComment;

    public string AuthorId => MemberHandle?._PrimaryKey;
    public string PlaceId => CatalogedPlace?.Uid;
    public string FeedId => FirstId ?? CatalogedPlace?.DefaultFeed ?? PlaceId;
    public string PostId => SecondId;
    public string CommentId => ThirdId;

    public string ResourceId => FirstId;

    /// <summary>Check to see if the current user has the authorization 
    /// <paramref name="privilege"/> to access the objects specified in the 
    /// parameters and parsed URL.</summary>
    /// <param name="privilege">The privilege to check.</param>
    /// <param name="feedId"></param>
    /// <param name="postId"></param>
    /// <param name="commentId"></param>
    /// <returns>True if the user is authorized, otherwise false.</returns>
    public bool CheckAuthorization(
                Privilege privilege,
                string feedId = null,
                string postId = null,
                string commentId = null) {

        feedId ??= FeedId;
        postId ??= PostId;
        commentId ??= CommentId;

        if (MemberHandle?.IsAdministrator == true) {
            return true;
            }

        return false;
        }









    /// <summary>
    /// Constructor, return a parsed path for the listener context <paramref name="context"/>
    /// with backing store <paramref name="persistPlace"/>.
    /// </summary>
    /// <param name="context"></param>
    /// <param name="persistPlace"></param>
    public ParsedPath(HttpListenerContext context, IPersistPlace persistPlace) {
        Context = context;
        PersistPlace = persistPlace;

        RealIp = Request.Headers["X-Real-IP"];
        ForwardedFor = Request.Headers["X-Forwarded-For"];
        if (persistPlace.ServerCookieManager.TryGetCookie(
            Request, PalimpsestConstants.CookieTypeSessionTag, out var userId)) {
            UserId = userId;
            PersistPlace.GetMember(this, out var member);
            MemberHandle = member;
            }

        else {
            //UserId = "did:plc:k647x4n6h3jm347u3t5cm6ki";
            }


        Uri = Request.Url;
        PersistPlace.TryGetPlaceByDns(Request.Url, out CatalogedPlace);

        if (LocalPath == null) {
            Command = null;
            return;
            }
        var split = LocalPath.Split('/');
        if (split.Length < 2) { // must have at least initial /
            Command = null;
            return;
            }

        if (split[1] == ".well-known") {
            Command = ".well-known";
            if (split.Length < 3) {
                SecondId = null;
                return;
                }
            SecondId = split[2];

            if (split.Length < 4) {
                SecondId = null;
                return;
                }
            SecondId = split[3];
            return;
            }

        Command = split[1];
        if (split.Length > 2) {
            FirstId = split[2];
            }
        if (split.Length > 3) {
            SecondId = split[3];
            }
        if (split.Length > 4) {
            ThirdId = split[4];
            }
        }




    }
