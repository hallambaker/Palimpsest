namespace Mplace2.Gui;
public partial class Place {

    public BackingTypeFile? AvatarFile { get; set; } = null;
    public BackingTypeFile? BannerFile { get; set; } = null;

    public BackingTypeLink? TitleLink { get => Utilities.GetPlacePage(Title, DNS);
        set { } }

    public BackingTypeLink? HandleLink {
        get => Utilities.GetPlacePage(DNS, DNS);
        set { }}

    }
