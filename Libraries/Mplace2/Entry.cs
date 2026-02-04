namespace Mplace2.Gui;



public partial class Entry {
    //   /// <summary>Field UserLink</summary>
    //   public BackingTypeLink? UserLink => Utilities.GetUserPage(User?.DisplayHandle, User?.DisplayHandle);

    //   /// <summary>Field EntryLink</summary>
    //public BackingTypeLink? EntryLink => Utilities.GetPostPage(User?.DisplayHandle, User?.DisplayHandle);

    ///<summary>Entry text.</summary>
    public virtual string? Text { get; set; } = "TBS";



    public CatalogedPlace? GetPlace(IPageContext context) {

        var parsedPath = context as ParsedPath;
        var persistPlace = parsedPath.PersistPlace as PersistPlace;



        var dns = parsedPath.Uri.Host;
        if (persistPlace.CachedPlaces.TryGetBySecondaryId(dns, out var place)) {
            return place;
            }



        return null;

        }

    }
