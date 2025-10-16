namespace Frame;


public partial class HomePage {


    public static FramePresentation? FullPresentation(IBinding data) => null;
    public static FramePresentation? SummaryPresentation(IBinding data) => null;

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


    public static FramePresentation? FullPresentation(IBinding data) => null;
    public static FramePresentation? SummaryPresentation(IBinding data) => null;

    }


public partial class PostPage {


    public static FramePresentation? PostPresentation(IBinding data) => null;
    public static FramePresentation? CommentPresentation(IBinding data) => null;

    }







public partial class Entry {
    /// <summary>Field UserLink</summary>
    public BackingTypeLink? UserLink => Utilities.GetUserPage(User?.DisplayHandle, User?.DisplayHandle);

    /// <summary>Field EntryLink</summary>
	public BackingTypeLink? EntryLink => Utilities.GetPostPage(User?.DisplayHandle, User?.DisplayHandle);

    public virtual string Text { get; set; } = "TBS";



    }
public partial class Post {

    public ButtonVisibility? Liked { get; set; }

    public ButtonVisibility? RequestedMore { get; set; }
    public ButtonVisibility? RequestedLess { get; set; }

    }
