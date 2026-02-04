using Goedel.Cryptography.Dare;

namespace Mplace2.Gui;


public class CacheHandle<T> : Disposable where T : EarlCatalog {


    public T Value;

    public CacheHandle(T value) {
        Value = value;
        }

    protected override void Disposing() {
        Value.CloseStream();
        }

    }



public class CatalogCache (string PlaceDirectory) {

    #region // Feeds

    CacheHandle<T> Intern<T> (T value) where T:EarlCatalog => new (value);



    /// <summary>Return the feeds associated with a place</summary>
    /// <param name="place">The place uid</param>
    /// <returns>The cached feeds for the place</returns>
    public CacheHandle<CachedFeeds> CreatePlaceFeeds(
                string place) {
        // Initialize [PlaceDirectory]/[place]/Feeds.darc
        var directory = CachedFeeds.GetDirectory(PlaceDirectory, place);
        Directory.CreateDirectory(directory);
        return GetPlaceFeeds(place);
        }


    /// <summary>Return the feeds associated with a place</summary>
    /// <param name="place">The place uid</param>
    /// <returns>The cached feeds for the place</returns>
    public CacheHandle<CachedFeeds> GetPlaceFeeds(
                string place) {

        var directory = CachedFeeds.GetDirectory(PlaceDirectory, place);
        var catalog = CachedFeeds.Open(this, PlaceDirectory, place);
        return Intern(catalog);
        }

    public void Release(CachedFeeds feeds) {
        feeds.Dispose();
        }


    #endregion

    /// <summary>Return the feeds associated with a place</summary>
    /// <param name="place">The place uid</param>
    /// <returns>The cached feeds for the place</returns>
    public CacheHandle<CachedPosts> CreateFeedPosts(
                string place,
                string feed) {
        var directory = CachedFeeds.GetDirectory(PlaceDirectory, place);
        Directory.CreateDirectory(directory);
        return GetFeedPosts(place, feed);
        }

    /// <summary>Return the feeds associated with a place</summary>
    /// <param name="place">The place uid</param>
    /// <param name="feed">The feed uid</param>
    /// <returns>The cached feeds for the place</returns>
    public CacheHandle<CachedPosts> GetFeedPosts(
                string place,
                string feed) {

        var directory = CachedFeeds.GetDirectory(PlaceDirectory, place);
        var catalog = CachedPosts.Open(this, PlaceDirectory, place, feed);
        return Intern(catalog);
        }



    /// <summary>Return the feeds associated with a place</summary>
    /// <param name="place">The place uid</param>
    /// <returns>The cached feeds for the place</returns>
    public CacheHandle<CachedComments> CreatePostComments(
                string place,
                string feed,
                string post) {
        var directory = CachedFeeds.GetDirectory(PlaceDirectory, place);
        Directory.CreateDirectory(directory);
        return GetPostComments(place,feed,post);
        }

    /// <summary>Return the feeds associated with a place</summary>
    /// <param name="place">The place uid</param>
    /// <param name="feed">The feed uid</param>
    /// <param name="post">The post uid</param>
    /// <returns>The cached feeds for the place</returns>
    public CacheHandle<CachedComments> GetPostComments(
                string place,
                string feed,
                string post) {

        var catalog = CachedComments.Open(this, PlaceDirectory, place, feed, post);
        return Intern(catalog);
        }



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
