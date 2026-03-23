using DocumentFormat.OpenXml.InkML;

namespace Mplace2.Gui;




public partial class CreatePost  {

    static List<Goedel.Sitebuilder.Resource> resources = [
                new Stylesheet("/Resources/quill.css", "text/css"),
                new Stylesheet("https://cdn.jsdelivr.net/npm/quill@2.0.3/dist/quill.snow.css", "text/css")];
    static List<Goedel.Sitebuilder.Resource> endResources = [
                new Script("https://cdn.jsdelivr.net/npm/quill@2.0.3/dist/quill.js","text/javascript"),
                new Script("/Resources/quill.js","text/javascript")
                ];

    /// <inheritdoc/>
    public override FramePage GetPage(Goedel.Sitebuilder.IPersistSite persistPlace, IPageContext context) {
        var pageContext = context as ParsedPath;
        pageContext.CheckAuthorization(Privilege.CreatePost);

        var template = new Post() {
            FeedId = pageContext.FeedId
            };

        var result = new CreatePost() {
            FrameSet = FrameSet,
            Resources = resources,
            EndResources = endResources,
            CreatePostAction = template
            };

        pageContext.Page = result;

        return result;
        }


    }
