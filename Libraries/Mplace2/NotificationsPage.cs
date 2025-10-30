namespace Mplace2.Gui;

public partial class NotificationsPage {


    public static FramePresentation? FullPresentation(IBinding data) => null;
    public static FramePresentation? SummaryPresentation(IBinding data) => null;


    public override NotificationsPage GetPage(
        IPersistSite persistPlace,
        IPageContext context) {

        var persist = persistPlace as PersistPlace;
        var path = context as ParsedPath;

        var result = new NotificationsPage() {
            FrameSet = FrameSet
            };

        path.Page = result;

        return result;
        }



    }
