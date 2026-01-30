using Goedel.Cryptography.Dare;

namespace Mplace2.Gui;

public class CachedCatalog<T> : EarlCatalog<T> where T : JsonObject, new() {

    CatalogCache CatalogCache;

    /// <summary>Constructor returning a new instance bound to cache 
    /// <paramref name="catalogCache"/> reading and writing to <paramref name="stream"/>.</summary>
    /// <param name="catalogCache"></param>
    /// <param name="stream"></param>
    public CachedCatalog(
            CatalogCache catalogCache,
            EarlStream stream) : base(stream) {
        CatalogCache = catalogCache;
        }

    /// <inheritdoc/>
    public override EarlEntryIndex<T> Add(T item) {
        return base.Add(item);
        }

    /// <inheritdoc/>
    public override EarlEntryIndex<T> Update(T item) {
        return base.Update(item);
        }

    /// <inheritdoc/>
    public override EarlEntryIndex<T> Delete(string id) {
        return base.Delete(id);
        }

    protected override ContentMeta GetContentMeta() => new ContentMeta() {
        UniqueId = Udf.Nonce(),
        Created = DateTime.UtcNow,
        MessageType = ContentType
        };

    }



///// <summary>
///// Cached catalog of projects.
///// </summary>
//public class CachedPlaces1 : Cache<PlaceHandle, CatalogedPlace> {


//    public PlaceHandle PrimaryHandle { get; set; } = null;

//    public IPersistPlace Place { get; }

//    /// <summary>
//    /// Constructor, return an instance of the projects catalog writing persistent
//    /// data to <paramref name="directory"/>.
//    /// </summary>
//    /// <param name="directory">The directory of the peristence store.</param>
//    public CachedPlaces1(
//                IPersistPlace place,
//                string directory,
//                bool create = false) : base(
//                    directory, PalimpsestConstants.StoreTypePlacesTag, create) {
//        Place = place;
//        CreateHandle = Factory;

//        Console.WriteLine($"Create Catalog Projects");

//        }

//    private PlaceHandle Factory(CatalogedPlace catalogedEntry)
//            => new(this, catalogedEntry);



//    public IEnumerable<CatalogedPlace> GetProjectEnumerator() {
//        var projects = new List<CatalogedPlace>();

//        foreach (var project in Catalog) {
//            projects.Add(project);
//            }


//        return projects;
//        }

//    /// <inheritdoc/>
//    public override void Add(PlaceHandle handle) {
//        base.Add(handle);

//        Console.WriteLine($"Add place {handle.Place.DNS}");
//        PrimaryHandle ??= handle;
//        }



//    }
