namespace Mplace2.Gui;


public partial class MemberPage {

    public override Goedel.Sitebuilder.FramePage GetPage(IPersistSite persistPlace, IPageContext context) {

        var path = context as ParsedPath;
        path.CheckAuthorization(Privilege.ReadPost);


        var persist = path.PersistPlace as PersistPlace;



        var page = new MemberPage() {
            FrameSet = FrameSet,

            };



        return page;

        }

    }






#region // Post Page Presentation Class

public partial class PostPage {

    public override Goedel.Sitebuilder.FramePage GetPage(IPersistSite persistPlace, IPageContext context) {

        var path = context as ParsedPath;
        path.CheckAuthorization(Privilege.ReadPost);


        var persist = path.PersistPlace as PersistPlace;
        var place = path.PlaceId;

        // if no feed is specified, use the first ID.
        var feedId = path.FeedId;
        var postId = path.PostId;


        using var postHandle = persist.CatalogCache.GetPostAndComments(place, feedId, postId);
        var comments = postHandle.Value;
        var catalogedPost = comments.CatalogedPost;

        var main = new Post(persist, place, feedId, catalogedPost);

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
#endregion
#region -- Create Post Action
public partial class Post {

    public ButtonVisibility? Liked { get; set; }
    public ButtonVisibility? RequestedMore { get; set; }
    public ButtonVisibility? RequestedLess { get; set; }

    public string PostLink { get; set; }
    public string AuthorLink { get; set; }
    public string PostPath { get; set; }

    public Post(
                    PersistPlace persist,
                    string placeId,
                    string feedId,
                    CatalogedPost catalogedPost) : this(catalogedPost.Uid) {
        Body = catalogedPost.Body;
        Summary = catalogedPost.Summary;
        Title = catalogedPost.Title;
        User = persist.GetUser(catalogedPost.Author);
        //User = post.Author;

        SetLinks(persist, placeId, feedId, catalogedPost);
        }


    public override Task<CallbackResult> Callback(IPageContext context) {
        var pageContext = context as ParsedPath;
        var persist = pageContext.PersistPlace as PersistPlace;

        pageContext.CheckAuthorization(Privilege.CreatePost, FeedId).AssertTrue(NYI.Throw);


        if (Body != null) {
            var valid = RichtextValidator.Validate(Body);
            if (valid != RichetextResult.Valid) {
                Body = null;
                }
            }


        var catalogedPost = new CatalogedPost() {
            Uid = persist.CreatePostId(),
            Title = Title,
            Author = pageContext.AuthorId,
            Summary = Summary,
            Body = Body
            };

        persist.Add(pageContext.PlaceId, FeedId, catalogedPost);
        SetLinks(persist, pageContext.PlaceId, FeedId, catalogedPost);



        var returnPage = persist.GetFeedLink(pageContext);
        return Task.FromResult(CallbackResult.CreatedRedirect(returnPage));

        }

    private void SetLinks(PersistPlace persist, string placeId, string feedId, CatalogedPost post) {
        PostLink = persist.GetPostLink(feedId, post._PrimaryKey);
        PostPath = persist.GetPostPath(feedId, post._PrimaryKey);
        AuthorLink = persist.GetAuthorLink(post.Author);
        //AuthorAvatar = persist.GetMemberAvatar(post.Author);
        }

    }

#endregion
#region -- Create Post Form

public partial class CreatePost {

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

#endregion
#region -- Delete Post Form

public partial class DeletePost {
    public override Goedel.Sitebuilder.FramePage GetPage(IPersistSite persistPlace, IPageContext context) {

        var path = context as ParsedPath;
        path.CheckAuthorization(Privilege.ReadPost);

        return null;
        }
    }

#endregion
