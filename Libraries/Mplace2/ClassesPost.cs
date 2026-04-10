namespace Mplace2.Gui;






#region // Post Page Presentation Class


public partial class PostPage {

    public override Goedel.Sitebuilder.FramePage GetPage(IPersistSite persistPlace, IPageContext context) {

        var pageContext = context as ParsedPath;
        pageContext.CheckAuthorization(Privilege.ReadPost);


        var persist = pageContext.PersistPlace as PersistPlace;
        var place = pageContext.PlaceId;
        var feedId = pageContext.FeedId;
        var postId = pageContext.PostId;


        using var postHandle = persist.CatalogCache.GetPostAndComments(place, feedId, postId);
        var comments = postHandle.Value;
        var catalogedPost = comments.CatalogedPost;

        var main = new Post(pageContext, place, feedId, catalogedPost);

        var page = new PostPage() {
            FrameSet = FrameSet,
            MainEntry = main,
            Entries = []
            };


        foreach (var commentIndex in comments.EntriesForward()) {
            var catalogedComment = comments.GetValue(commentIndex);
            var comment = new Comment(pageContext, place, feedId, postId, catalogedComment);
            page.Entries.Add(comment);
            }


        return page;

        }

    }
#endregion
#region -- Create Post Action
public partial class Post {

    /// <summary>-1, 1 or 0 according to whether the member has disliked, liked or not
    /// reacted.</summary>
    public int Liked { get; set; } = 0;

    /// <summary>Button visibility for request more, <see cref="ButtonVisibility.Checked"/>,
    /// <see cref="ButtonVisibility.Available"/> or <see cref="ButtonVisibility.Disabled"/>.</summary>
    public ButtonVisibility? RequestedMore =>
        Privilege.ButtonCheckedAvailableDisabled(Privilege.CreateComment, Liked > 0);

    /// <summary>Button visibility for request less, <see cref="ButtonVisibility.Checked"/>,
    /// <see cref="ButtonVisibility.Available"/> or <see cref="ButtonVisibility.Disabled"/>.</summary>
    public ButtonVisibility? RequestedLess =>
        Privilege.ButtonCheckedAvailableDisabled(Privilege.CreateComment, Liked < 0);

    /// <summary>Button visibility for permission to respond,
    /// <see cref="ButtonVisibility.Available"/> or <see cref="ButtonVisibility.Disabled"/>.</summary>
    public ButtonVisibility? PermissionRespond =>
        Privilege.ButtonAvailableDisabled(Privilege.CreateComment);

    /// <summary>Button visibility for permission to respond,
    /// <see cref="ButtonVisibility.Available"/> or <see cref="ButtonVisibility.None"/>.</summary>
    public ButtonVisibility? PermissionDelete =>
        Privilege.ButtonAvailableNone(Privilege.DeletePost);

    public string PostLink { get; set; }
    public string AuthorLink { get; set; }
    public string PostPath { get; set; }

    public Privilege Privilege { get; private set; }

    public Post(
                    //PersistPlace persist,
                    ParsedPath pageContext,
                    string placeId,
                    string feedId,
                    CatalogedPost catalogedPost) : this(catalogedPost.Uid) {
        var persist = pageContext.PersistPlace as PersistPlace;


        Body = catalogedPost.Body;
        Summary = catalogedPost.Summary;
        Title = catalogedPost.Title;
        User = persist.GetUser(catalogedPost.Author);
        //User = post.Author;

        SetLinks(pageContext, persist, placeId, feedId, catalogedPost);
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
        SetLinks(pageContext, persist, pageContext.PlaceId, FeedId, catalogedPost);

        var returnPage = persist.GetFeedLink(pageContext);
        return Task.FromResult(CallbackResult.CreatedRedirect(returnPage));
        }

    private void SetLinks(
                ParsedPath pageContext, 
                PersistPlace persist, 
                string placeId, 
                string feedId, 
                CatalogedPost post) {
        PostLink = persist.GetPostLink(feedId, post._PrimaryKey);
        PostPath = persist.GetPostPath(feedId, post._PrimaryKey);
        AuthorLink = persist.GetAuthorLink(post.Author);

        Privilege = pageContext.GetAuthorization(post);

        //PermissionRespond = ButtonVisibility.Disabled;
        //PermissionDelete = ButtonVisibility.None;
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
    public override async Task<CallbackResult> Callback(IPageContext context) {
        var pageContext = context as ParsedPath;

        pageContext.CheckAuthorization(Privilege.DeleteComment, FeedId, PostId);
        var persist = pageContext.PersistPlace as PersistPlace;

        persist.DeletePost(pageContext.PlaceId, pageContext.FeedId, pageContext.PostId);


        var returnPage = persist.GetFeedLink(pageContext);
        return CallbackResult.CreatedRedirect(returnPage);
        }
    }

// Need to refactor this so that the template is of type 'Deletepost' with just the identifiers.
// Same for comment

public partial class DeletePostPage {
    public override Goedel.Sitebuilder.FramePage GetPage(IPersistSite persistPlace, IPageContext context) {


        var pageContext = context as ParsedPath;
        var persist = pageContext.PersistPlace as PersistPlace;
        pageContext.CheckAuthorization(Privilege.DeletePost);

        var template = new DeletePost() {
            FeedId = pageContext.FeedId,
            PostId = pageContext.PostId
            };


        var post = persist.CatalogCache.GetPost(pageContext.PlaceId, pageContext.FeedId, pageContext.PostId);
        // should pull the comment here so we can show it 

        var result = new DeletePostPage() {
            FrameSet = FrameSet,
            Title = post.Title,
            Summary = post.Summary,
            Form = template
            };

        pageContext.Page = result;

        return result;


        }
    }

#endregion
