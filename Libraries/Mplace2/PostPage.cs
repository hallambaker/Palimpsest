namespace Mplace2.Gui;
public partial class PostPage {


    public static FramePresentation? PostPresentation(IBinding data) => data switch {
        Post => Post.PostFull,
        _ => null
        };

    public static FramePresentation? CommentPresentation(IBinding data) => data switch {
        Post => Post.PostSummary,
        Comment => Comment.CommentFull,
        _ => null
        };

    }
