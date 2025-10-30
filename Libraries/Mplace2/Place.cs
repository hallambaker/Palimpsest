using Goedel.Mesh;

using System.Net;

namespace Mplace2.Gui;


public partial class FormPlace {

    public override async Task<CallbackResult> Callback(
            IPersistSite persistPlace) {
        List<FormReaction> reactions = [];

        return new(HttpStatusCode.OK, null, "");
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

    }
