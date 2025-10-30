namespace Mplace2.Gui;

public partial class HomePage  {



    ///<summary>Override the path stem to make the home page the default.</summary>
    public override string PathStem => "";





    public override HomePage GetPage(
            IPersistSite persistPlace,
            IPageContext context) {

        var persist = persistPlace as PersistPlace;
        var path = context as ParsedPath;


        var basePlace = persist.GetMainPlace(path);
        var entries = persist.GetMainEntries(path);

        var result = new HomePage() {
            FrameSet = FrameSet,
            MainEntry = basePlace,
            Entries = entries
            };

        path.Page = result;

        return result;
        }




    }
