namespace Mplace2.Gui;




public partial class CreatePost  {



    static List<Goedel.Sitebuilder.Resource> resources = [
                new Stylesheet("Resources/quill.css", "text/css"),
                new Stylesheet("https://cdn.jsdelivr.net/npm/quill@2.0.3/dist/quill.snow.css", "text/css")];
    static List<Goedel.Sitebuilder.Resource> endResources = [
                new Script("https://cdn.jsdelivr.net/npm/quill@2.0.3/dist/quill.js","text/javascript"),
                new Script("Resources/quill.js","text/javascript")
                ];

    /// <inheritdoc/>
    public override FramePage GetPage(Goedel.Sitebuilder.IPersistSite persistPlace, IPageContext context) {
        var persist = persistPlace as PersistPlace;
        var path = context as ParsedPath;

        var result = new CreatePost() {
            FrameSet = FrameSet,
            Resources = resources,
            EndResources = endResources
            };

        path.Page = result;

        return result;
        }


    }
