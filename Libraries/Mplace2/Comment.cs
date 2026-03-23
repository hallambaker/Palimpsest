using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Wordprocessing;

namespace Mplace2.Gui;


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
                CatalogedComment catalogedComment) : this (catalogedComment.Uid) {
        Text = catalogedComment.Text;
        CommentId = catalogedComment.ReplyId;

        SetLinks(persist, placeId, feedId, postId, catalogedComment);
        }



    public override Task<CallbackResult> Callback(IPageContext context) {
        var pageContext = context as ParsedPath;
        var persist = pageContext.PersistPlace as PersistPlace;

        pageContext.CheckAuthorization(Privilege.CreateComment);

        //var catalogedPost = new Cat
        var catalogedPost = new CatalogedComment() {
            Author = pageContext.AuthorId,
            Text = Text,
            ReplyId = CommentId
            };
        persist.Add(pageContext.PlaceId, pageContext.FeedId, pageContext.PostId, catalogedPost);


        var returnPage = persist.GetPostLink(pageContext);
        return Task.FromResult(CallbackResult.CreatedRedirect(returnPage));
        }

    private void SetLinks(PersistPlace persist, string placeId, string feedId, string postId, CatalogedComment comment) {
        PostPath = persist.GetCommentPath(feedId, postId, comment._PrimaryKey);
        AuthorLink = persist.GetAuthorLink(comment.Author);
        }
    }