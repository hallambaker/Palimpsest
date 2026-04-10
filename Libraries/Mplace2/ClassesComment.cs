using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Wordprocessing;

using Microsoft.Extensions.Hosting;

namespace Mplace2.Gui;




public partial class Comment {

    /// <summary>-1, 1 or 0 according to whether the member has disliked, liked or not
    /// reacted.</summary>
    public int Liked { get; set; }

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
        Privilege.ButtonAvailableNone(Privilege.DeleteComment);

    public string PostPath { get; set; }
    public string AuthorLink { get; set; }

    public Privilege Privilege { get; private set; }

    public Comment(
                ParsedPath pageContext,
                string placeId,
                string feedId,
                string postId,
                CatalogedComment catalogedComment) : this(catalogedComment.Uid) {
        var persist = pageContext.PersistPlace as PersistPlace;

        Text = catalogedComment.Text;
        CommentId = catalogedComment.ReplyId;
        User = persist.GetUser(catalogedComment.Author);

        SetLinks(pageContext, persist, placeId, feedId, postId, catalogedComment);
        }



    public override async Task<CallbackResult> Callback(IPageContext context) {
        var pageContext = context as ParsedPath;

        pageContext.CheckAuthorization(Privilege.CreateComment, FeedId, PostId);
        var persist = pageContext.PersistPlace as PersistPlace;

        var item = new CatalogedComment() {
            Author = pageContext.AuthorId,
            Text = Text,
            ReplyId = CommentId
            };
        persist.Add(pageContext.PlaceId, pageContext.FeedId, pageContext.PostId, item);
        SetLinks(pageContext, persist, pageContext.PlaceId, pageContext.FeedId, pageContext.PostId, item);

        var returnPage = persist.GetPostLink(pageContext);
        return CallbackResult.CreatedRedirect(returnPage);
        }



    private void SetLinks(
                ParsedPath pageContext,
                PersistPlace persist, 
                string placeId, 
                string feedId, 
                string postId, 
                CatalogedComment comment) {
        PostPath = persist.GetCommentPath(feedId, postId, comment._PrimaryKey);
        AuthorLink = persist.GetAuthorLink(comment.Author);

        Privilege = pageContext.GetAuthorization(comment);

        //PermissionRespond = ButtonVisibility.Disabled;
        //PermissionDelete = ButtonVisibility.None;
        //RequestedMore = ButtonVisibility.Active;
        //RequestedMore = ButtonVisibility.Available;
        }
    }

public partial class DeleteComment {

    public override async Task<CallbackResult> Callback(IPageContext context) {
        var pageContext = context as ParsedPath;

        pageContext.CheckAuthorization(Privilege.DeleteComment, FeedId, PostId, CommentId);
        var persist = pageContext.PersistPlace as PersistPlace;

        persist.DeleteComment(pageContext.PlaceId, pageContext.FeedId, pageContext.PostId, pageContext.CommentId);


        var returnPage = persist.GetPostLink(pageContext);
        return CallbackResult.CreatedRedirect(returnPage);
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



public partial class DeleteCommentPage {
    public override Goedel.Sitebuilder.FramePage GetPage(IPersistSite persistPlace, IPageContext context) {

        var pageContext = context as ParsedPath;
        var persist = pageContext.PersistPlace as PersistPlace;
        pageContext.CheckAuthorization(Privilege.DeleteComment);

        var template = new DeleteComment() {
            FeedId = pageContext.FeedId,
            PostId = pageContext.PostId,
            CommentId = pageContext.CommentId
            };


        // should pull the comment here so we can show it 

        var result = new DeleteCommentPage() {
            FrameSet = FrameSet,
            Text="FOAD",
            Form = template
            };

        pageContext.Page = result;

        return result;
        }

    }


