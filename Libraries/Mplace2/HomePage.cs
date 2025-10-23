
namespace Goedel.Places;



public partial class CreatePost {


    static List<Sitebuilder.Resource> resources = [
                new Stylesheet("Resources/quill.css", "text/css"),
                new Stylesheet("https://cdn.jsdelivr.net/npm/quill@2.0.3/dist/quill.snow.css", "text/css")];
    static List<Sitebuilder.Resource> endResources = [
                new Script("https://cdn.jsdelivr.net/npm/quill@2.0.3/dist/quill.js","text/javascript"),
                new Script("Resources/quill.js","text/javascript")
                ];
    /// <inheritdoc/>
    public override FramePage GetPage(IPageContext context) {
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

public partial class HomePage {



    ///<summary>Override the path stem to make the home page the default.</summary>
    public override string PathStem => "";

    /// <summary>
    /// Presentation formats for items shown in full (place banner)
    /// </summary>
    /// <param name="data">The item to show.</param>
    /// <returns>The presentation format.</returns>
    public static FramePresentation? FullPresentation(IBinding data) => data switch {
        Place => Place.PlaceReference,
        _ => null
        };

    /// <summary>
    /// Presentation formats for items shown in summary (list of toplevel entries)
    /// </summary>
    /// <param name="data">The item to show.</param>
    /// <returns>The presentation format.</returns>
    public static FramePresentation? SummaryPresentation(IBinding data) => data switch {
        Place => Place.PlaceReference,
        _ => null
        };


    /// <inheritdoc/>
    public override FramePage GetPage(IPageContext context) {

        var path = context as ParsedPath;

        var basePlace = new Place() {
            Uid = Udf.Nonce(),
            DNS = "mplace2.social",
            Title = "MPlace2",
            Description = "Making personal places on the Web",
            Banner = "Mplace2Banner.png",
            Avatar = "avatar.png"
            };

        var phbPlace = new Place() {
            Uid = Udf.Nonce(),
            DNS = "phill.hallambaker.com",
            Title = "Phill's Place",
            Description = "PHB's place on the Web",
            Banner = "PHBBanner.png",
            Avatar = "PHBInDalek.png"
            };

        var result = new HomePage() {
            FrameSet = FrameSet,
            MainEntry = basePlace,
            Entries = [basePlace, phbPlace]
            };

        path.Page = result;

        return result;
        }


    }
