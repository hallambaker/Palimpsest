using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Wordprocessing;

namespace Mplace2.Gui;




public partial class Comment {

    public ButtonVisibility? Liked { get; set; }
    public ButtonVisibility? RequestedMore { get; set; }
    public ButtonVisibility? RequestedLess { get; set; }

    public string PostPath { get; set; }
    public string AuthorLink { get; set; }

    public Comment(
                PersistPlace persist,
                string placeId,
                string feedId,
                string postId,
                CatalogedComment catalogedComment) : this(catalogedComment.Uid) {
        Text = catalogedComment.Text;
        CommentId = catalogedComment.ReplyId;

        SetLinks(persist, placeId, feedId, postId, catalogedComment);
        }



    public override async Task<CallbackResult> Callback(IPageContext context) {
        var pageContext = context as ParsedPath;

        return pageContext.Command switch {
            "CreateComment" => await CreateComment (pageContext),
            "DeleteComment" => await DeleteComment(pageContext),
            _ => throw new NYI()
            };

        }


    Task<CallbackResult> CreateComment(ParsedPath pageContext) {
        pageContext.CheckAuthorization(Privilege.CreateComment, FeedId, PostId);
        var persist = pageContext.PersistPlace as PersistPlace;

        //var catalogedPost = new Cat
        var item = new CatalogedComment() {
            Author = pageContext.AuthorId,
            Text = Text,
            ReplyId = CommentId
            };
        persist.Add(pageContext.PlaceId, pageContext.FeedId, pageContext.PostId, item);

        var returnPage = persist.GetPostLink(pageContext);
        return Task.FromResult(CallbackResult.CreatedRedirect(returnPage));
        }

    Task<CallbackResult> DeleteComment(ParsedPath pageContext) {
        pageContext.CheckAuthorization(Privilege.CreateComment, FeedId, PostId);
        var persist = pageContext.PersistPlace as PersistPlace;

        persist.Delete(pageContext.PlaceId, pageContext.FeedId, pageContext.PostId, pageContext.CommentId);


        var returnPage = persist.GetPostLink(pageContext);
        return Task.FromResult(CallbackResult.CreatedRedirect(returnPage));
        }

    private void SetLinks(PersistPlace persist, string placeId, string feedId, string postId, CatalogedComment comment) {
        PostPath = persist.GetCommentPath(feedId, postId, comment._PrimaryKey);
        AuthorLink = persist.GetAuthorLink(comment.Author);
        }
    }



public partial class CreateComment {
    public override Goedel.Sitebuilder.FramePage GetPage(IPersistSite persistPlace, IPageContext context) {

        var pageContext = context as ParsedPath;
        pageContext.CheckAuthorization(Privilege.CreateComment);

        var template = new Comment() {
            FeedId = pageContext.FeedId,
            PostId = pageContext.PostId,
            CommentId = pageContext.CommentId
            };

        var result = new CreateComment() {
            FrameSet = FrameSet,
            Form = template
            };

        pageContext.Page = result;

        return result;

        }
    }



public partial class DeleteComment {
    public override Goedel.Sitebuilder.FramePage GetPage(IPersistSite persistPlace, IPageContext context) {

        var pageContext = context as ParsedPath;
        var persist = pageContext.PersistPlace as PersistPlace;
        pageContext.CheckAuthorization(Privilege.DeleteComment);

        var template = new Comment() {
            FeedId = pageContext.FeedId,
            PostId = pageContext.PostId,
            CommentId = pageContext.CommentId
            };


        // should pull the comment here so we can show it 

        var result = new DeleteComment() {
            FrameSet = FrameSet,
            Text="FOAD",
            Form = template
            };

        pageContext.Page = result;

        return result;
        }

    }


