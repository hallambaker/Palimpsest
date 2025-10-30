
#pragma warning disable IDE0028 // Simplify collection initialization
namespace Mplace2.Gui;

public partial class FramePage : Goedel.Sitebuilder.FramePage {


    /// <summary>
    /// Presentation formats for items shown in full (place banner)
    /// </summary>
    /// <param name="data">The item to show.</param>
    /// <returns>The presentation format.</returns>
    public static FramePresentation? FullPresentation(IBinding data) => data switch {
        Post => Post.PostFull,
        Place => Place.PlaceReference,
        _ => null
        };

    /// <summary>
    /// Presentation formats for items shown in summary (list of toplevel entries)
    /// </summary>
    /// <param name="data">The item to show.</param>
    /// <returns>The presentation format.</returns>
    public static FramePresentation? SummaryPresentation(IBinding data) => data switch {
        Post => Post.PostSummary,
        Place => Place.PlaceReference,
        _ => null
        };

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

