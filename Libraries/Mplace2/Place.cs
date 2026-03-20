using System.Net;

using DocumentFormat.OpenXml.InkML;

using Goedel.Discovery;


namespace Mplace2.Gui;

public partial class FormPlace {


    public override async Task<CallbackResult> Callback(
                IPageContext context) {

        var pageContext = context as ParsedPath;
        pageContext.CheckAuthorization(Privilege.CreatePlace);

        var persistPlace = pageContext.PersistPlace as PersistPlace;

        List<FormReaction> reactions = [];
        if (DNS is null || DNS?.Length == 0) {
            reactions.Add(new("DNS", "Must not be null"));
            }
        else if (!DNS.TryParseServiceAddress(out var address)) {
            reactions.Add(new("DNS", "Must be a valid DNS address or handle"));
            }

        if (Description is null) {
            reactions.Add(new("Description", "Must specify a description"));
            }

        if (AvatarFile is null) {
            reactions.Add(new("Avatar", "Must specify an avatar image"));
            }
        if (BannerFile is null) {
            reactions.Add(new("Banner", "Must specify a banner image"));
            }

        if (reactions.Count > 0) {
            return new(HttpStatusCode.BadRequest, reactions, null);
            }

        var avatar = persistPlace.AddImage(AvatarFile);
        var banner = persistPlace.AddImage(BannerFile);

        var uid = persistPlace.CreatePlaceId();
        var added = DateTime.Now;

        var catalogedPlace = new CatalogedPlace() {
            Uid = uid,
            Avatar = avatar,
            Banner = banner,
            Added = added,
            LocalName = DNS,
            Description = Description,
            Owners = null,
            Title = Title ?? DNS,
            DefaultFeed = uid
            };
        persistPlace.Add(catalogedPlace);

        var returUri = persistPlace.GetPlaceUri(catalogedPlace);

        // create feed as well

        var catalogedFeed = new CatalogedFeed() {
            Uid = uid,
            Added = added
            };

        persistPlace.Add(uid, catalogedFeed);

        return new(HttpStatusCode.OK, null, returUri);
        }


    }



public partial class Place {

    public BackingTypeFile? AvatarFile { get; set; } = null;
    public BackingTypeFile? BannerFile { get; set; } = null;

    public string? TitleLink => "fred";
       

    public BackingTypeLink? HandleLink {
        get => Utilities.GetPlacePage(DNS, DNS);
        set { }}



    public Place(CatalogedPlace catalogedPlace, PersistPlace place) : this () {
        Uid = catalogedPlace.Uid;
        Avatar = place.GetResourceUri(catalogedPlace.Uid, catalogedPlace.Avatar);
        Banner = catalogedPlace.Banner;
        DNS = catalogedPlace.LocalName;
        Title = catalogedPlace.Title;
        Description = catalogedPlace.Description;


        }


    }
