namespace Mplace2.Gui;

public partial class PostPage {

    public override Goedel.Sitebuilder.FramePage GetPage(IPersistSite persistPlace, IPageContext context) {

        var path = context as ParsedPath;
        var persist = path.PersistPlace as PersistPlace;
        var place = path.PlaceId;

        // if no feed is specified, use the first ID.
        var feedId = path.FeedId;
        var postId = path.PostId;


        using var postHandle = persist.CatalogCache.GetPostAndComments(place, feedId, postId);
        var comments = postHandle.Value;
        var catalogedPost = comments.CatalogedPost;



        var main = new Post(persist, place, feedId, catalogedPost);

        // present the comments


        //THIS IS WHAT TO DO NEXT!!!!
        // OPEN THE POST COMMENTS CATALOG!!!

        var page = new PostPage() {
            FrameSet = FrameSet,
            MainEntry = main,
            Entries = []
            };


        foreach (var commentIndex in comments.EntriesForward()) {
            var catalogedComment = comments.GetValue(commentIndex);
            var comment = new Comment(persist, place, feedId, postId, catalogedComment);
            page.Entries.Add(comment);
            }


        return page;

        }

    }