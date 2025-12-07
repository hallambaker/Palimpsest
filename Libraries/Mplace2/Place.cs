using System.Net;

using DocumentFormat.OpenXml.InkML;

using Goedel.Discovery;
using Goedel.Mesh;

namespace Mplace2.Gui;


public partial class FormPlace {


    public override async Task<CallbackResult> Callback(
            IPageContext context) {

        var path = context as ParsedPath;
        var persistPlace = path.PersistPlace as PersistPlace;


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

        var catalogedPlace = new CatalogedPlace() {
            Avatar = avatar,
            Banner = banner,
            Added = DateTime.Now,
            DNS = DNS,
            Description = Description,
            Owner = null,
            Title = Title ?? DNS
            };
        persistPlace.AddPlace(catalogedPlace);



        return new(HttpStatusCode.OK, null, "/");
        }


    }




public partial class Place {

    public BackingTypeFile? AvatarFile { get; set; } = null;
    public BackingTypeFile? BannerFile { get; set; } = null;

    public BackingTypeLink? TitleLink { get => Utilities.GetPlacePage(Title, DNS);
        set { } }

    public BackingTypeLink? HandleLink {
        get => Utilities.GetPlacePage(DNS, DNS);
        set { }}



    public Place(CatalogedPlace place) : this () {
        Uid = place.Uid;
        Avatar = place.Avatar;
        Banner = place.Banner;
        DNS = place.DNS;
        Title = place.Title;
        Description = place.Description;


        }


    }
