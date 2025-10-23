namespace Goedel.Places;

public partial class YourPlacePage {


    public static FramePresentation? FullPresentation(IBinding data) => data switch {
        Post => Post.PostFull,
        Place => Place.PlaceReference,
        _ => null
        };
    public static FramePresentation? SummaryPresentation(IBinding data) => data switch {
        Post => Post.PostSummary,
        Place => Place.PlaceReference,
        _ => null
        };

    }
