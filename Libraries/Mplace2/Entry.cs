namespace Frame;


public partial class HomePage {


    public static FramePresentation? FullPresentation(IBinding data) => data switch {
        Place => Place.PlaceReference,
        _ => null
        };
    public static FramePresentation? SummaryPresentation(IBinding data) => data switch {
        Place => Place.PlaceReference,
        _ => null
        };

    }


public partial class NotificationsPage {


    public static FramePresentation? FullPresentation(IBinding data) => null;
    public static FramePresentation? SummaryPresentation(IBinding data) => null;

    }

public partial class PlacesPage {


    public static FramePresentation? FullPresentation(IBinding data) => null;
    public static FramePresentation? SummaryPresentation(IBinding data) => null;

    }


public partial class BookmarkPage {


    public static FramePresentation? FullPresentation(IBinding data) => null;
    public static FramePresentation? SummaryPresentation(IBinding data) => null;

    }


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



public partial class Place {

    public BackingTypeLink? TitleLink { get => Utilities.GetPlacePage(Title, DNS);
        set { } }

    public BackingTypeLink? HandleLink {
        get => Utilities.GetPlacePage(DNS, DNS);
        set { }}

    }



public partial class Entry {
 //   /// <summary>Field UserLink</summary>
 //   public BackingTypeLink? UserLink => Utilities.GetUserPage(User?.DisplayHandle, User?.DisplayHandle);

 //   /// <summary>Field EntryLink</summary>
	//public BackingTypeLink? EntryLink => Utilities.GetPostPage(User?.DisplayHandle, User?.DisplayHandle);

    public virtual string Text { get; set; } = "TBS";



    }
public partial class Post {

    public ButtonVisibility? Liked { get; set; }

    public ButtonVisibility? RequestedMore { get; set; }
    public ButtonVisibility? RequestedLess { get; set; }

    }


public partial class Comment {

    public ButtonVisibility? Liked { get; set; }

    public ButtonVisibility? RequestedMore { get; set; }
    public ButtonVisibility? RequestedLess { get; set; }

    }