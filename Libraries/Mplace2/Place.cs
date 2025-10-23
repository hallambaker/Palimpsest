namespace Goedel.Places;

public partial class Place {

    public BackingTypeLink? TitleLink { get => Utilities.GetPlacePage(Title, DNS);
        set { } }

    public BackingTypeLink? HandleLink {
        get => Utilities.GetPlacePage(DNS, DNS);
        set { }}

    }
