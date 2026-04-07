namespace Mplace2.Gui;



#region -- Page describing the member
public partial class MemberPage {



    public override Goedel.Sitebuilder.FramePage GetPage(IPersistSite persistPlace, IPageContext context) {

        var path = context as ParsedPath;
        path.CheckAuthorization(Privilege.ReadUser);
        var persist = path.PersistPlace as PersistPlace;


        var user = persist.GetUser(path.MemberId);


        var page = new MemberPage() {
            FrameSet = FrameSet,
            MainEntry = user
            };

        // here collect up the most recent activity from the member's activity log:

        return page;

        }

    }

#endregion
