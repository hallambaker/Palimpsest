namespace Mplace2.Gui;

public partial class PlacesPage {

    public override Goedel.Sitebuilder.FramePage GetPage(IPersistSite persistPlace, IPageContext context) {

        var path = context as ParsedPath;
        path.CheckAuthorization(Privilege.ReadSite);

        return base.GetPage(persistPlace, context);
        }

    }

