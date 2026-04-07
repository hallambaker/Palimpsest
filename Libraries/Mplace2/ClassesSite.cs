using DocumentFormat.OpenXml.Spreadsheet;

namespace Mplace2.Gui;

public partial class PlacesPage {

    public override Goedel.Sitebuilder.FramePage GetPage(IPersistSite persistPlace, IPageContext context) {

        var path = context as ParsedPath;
        path.CheckAuthorization(Privilege.ReadSite);

        var persist = path.PersistPlace as PersistPlace;

        var page = new PlacesPage() {
            FrameSet = FrameSet,
            Entries = []
            };

        foreach (var placeindex  in persist.CachedPlaces.EntriesForward()) {
            var place = persist.CachedPlaces.GetValue(placeindex);
            page.Entries.Add(new Place(place, persist));
            }


        return page;
        }

    }

