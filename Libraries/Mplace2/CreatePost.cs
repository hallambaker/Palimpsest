using DocumentFormat.OpenXml.InkML;

namespace Mplace2.Gui;


//public record PageContext {

//    public PersistPlace PersistPlace;
//    public ParsedPath ParsedPath;

//    CatalogedPlace? CatalogedPlace;
//    CatalogedFeed? CatalogedFeed;
//    CatalogedPost? CatalogedPost;
//    CatalogedComment? CatalogedComment;

//    public string AuthorId => ParsedPath.MemberHandle?._PrimaryKey;
//    public string PlaceId => CatalogedPlace?.Uid;
//    public string FeedId { get; }
//    public string PostId { get; }
//    public string CommentId { get; }

//    public Goedel.Sitebuilder.FramePage Page {
//        get => ParsedPath.Page;
//        set => ParsedPath.Page = value; }

//    public PageContext(
//                IPageContext context,
//                string feedId = null,
//                string postId = null,
//                string commentId = null) {
//        PersistPlace = context.GetPersist();
//        ParsedPath = context as ParsedPath;

//        var dns = ParsedPath.Uri.Host;
//        CatalogedPlace = PersistPlace.CachedPlaces.TryGetBySecondaryId(dns, out var place) ?
//            place : PersistPlace.HomeCatalogedPlace;

//        FeedId = feedId ?? ParsedPath.FirstId ?? PlaceId;
//        PostId = postId ?? ParsedPath.SecondId;
//        CommentId = commentId ?? ParsedPath.ThirdId;
//        }

//    public bool CheckAuthorization(Privilege privileges) {
//        if (ParsedPath.MemberHandle?.IsAdministrator == true) {
//            return true;
//            }

//        return false;
//        }

//    }

public partial class CreatePost  {

    static List<Goedel.Sitebuilder.Resource> resources = [
                new Stylesheet("/Resources/quill.css", "text/css"),
                new Stylesheet("https://cdn.jsdelivr.net/npm/quill@2.0.3/dist/quill.snow.css", "text/css")];
    static List<Goedel.Sitebuilder.Resource> endResources = [
                new Script("https://cdn.jsdelivr.net/npm/quill@2.0.3/dist/quill.js","text/javascript"),
                new Script("/Resources/quill.js","text/javascript")
                ];

    /// <inheritdoc/>
    public override FramePage GetPage(Goedel.Sitebuilder.IPersistSite persistPlace, IPageContext context) {
        var pageContext = context as ParsedPath;
        pageContext.CheckAuthorization(Privilege.CreatePost);

        var template = new Post() {
            FeedId = pageContext.FeedId
            };

        var result = new CreatePost() {
            FrameSet = FrameSet,
            Resources = resources,
            EndResources = endResources,
            CreatePostAction = template
            };

        pageContext.Page = result;

        return result;
        }


    }
