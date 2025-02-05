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

namespace Goedel.Palimpsest;

public record ParsedPath {

    public HttpListenerContext Context { get; }

    public HttpListenerRequest Request => Context.Request;


    public PlaceHandle PlaceHandle { get; }

    public string Placename => PlaceHandle?.LocalName;


    public MemberHandle? Member { get; set; }

    public string MemberId => Member.CatalogedMember._PrimaryKey;


    public bool SignedIn => Member!= null;

    public string Command { get; }

    public Uri Uri { get; }

    public string ExternalUri => "https://" + Uri.Host  + Uri.LocalPath;
    public string ExternalUriQuery => "https://" + Uri.Host + Uri.PathAndQuery;
    public string LocalPath => Uri?.LocalPath;








    ///<summary>Holds the project ID or the static resource name</summary> 
    public string FirstId { get; }


    public string VisitorId => FirstId;

    /////<summary>The project Id is always the first in the path</summary> 
    //public string ProjectId => FirstId;


    ///<summary>Holds the document ID.</summary> 
    public string SecondId { get; }


    ///<summary>The topic Id is always the first in the path</summary> 
    public string TopicId => FirstId;


    ///<summary>The resource Id is always the first in the path</summary> 
    public string ResourceId => FirstId;


    ///<summary>Holds the fragment ID.</summary> 
    public string ThirdId { get; } 

    ///<summary>The post Id is always the second in the path</summary> 
    public string PostId => SecondId;

    ///<summary>The fragment Id is always the second in the path</summary> 
    public string FragmentId => SecondId;

    ///<summary>The original IP address of the request (filled by reverse proxy)</summary> 
    public string RealIp { get; }



    public ParsedPath(HttpListenerContext context, Forum forum) {
        Context = context;

        RealIp = Request.Headers["X-Real-IP"];
        //ReturnAddress = request.UserHostName + "/" + 

        forum.TryGetPlace(Request.UserHostName, out var place);
        PlaceHandle = place;

        // If signed in, set the member handle
        forum.TryGetVerifiedMemberHandle(Request, out var member);
        Member = member;

        Uri = Request.Url;
        if (LocalPath == null) {
            Command = null;
            return;
            }
        var split = LocalPath.Split('/');
        if (split.Length < 2) { // must have at least initial /
            Command = null;
            return;
            }

        var extension = Path.GetExtension(split[1]);
        if (extension.Length > 0) {
            Command = "resources";
            FirstId = split[1];
            }
        else {
            Command = split[1];
            }


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

    public string GetPostTarget() =>
    $"/{PalimpsestConstants.PostPost}/{FirstId}/{SecondId}" + (ThirdId is null ? "" : $"/{ThirdId}");

    public string GetMainCommentTarget() =>
    $"/{PalimpsestConstants.CommentPost}/{FirstId}/{SecondId}" + (ThirdId is null ? "" : $"/{ThirdId}");

    public string GetCommentTarget() =>
        $"/{PalimpsestConstants.PostCommentPost}/{FirstId}/{SecondId}" + (ThirdId is null ? "" : $"/{ThirdId}");


    public bool TryGetResource(
          out ResourceHandle resource) => PlaceHandle.TryGetForum(ResourceId, out resource);

    public bool TryGetTopic(
          out TopicHandle resource) => PlaceHandle.TryGetForum(TopicId, out resource);

    public bool TryGetPost(
            out TopicHandle topicHandle,
            out PostHandle postHandle) {
        if (!TryGetTopic(out topicHandle)) {
            postHandle = null;
            return false;
            }
        return topicHandle.TryGetPost(SecondId, out postHandle);

        }

    }
