using Goedel.Cryptography.Dare;

namespace Mplace2.Gui;


public class CacheHandle<T> : Disposable where T : EarlCatalog {


    public T Value;

    public CacheHandle(T value) {
        Console.WriteLine($"Open file {value?.Stream?.Filename}");
        Value = value;
        }

    protected override void Disposing() {
        Console.WriteLine($"Close file {Value?.Stream?.Filename}");
        Value?.CloseStream();
        }

    }




//public class CacheHandlePostComments : CacheHandle<CachedComments> {




//    public CacheHandlePostComments(CachedComments value) : base (value) { 
//        } 

//    }

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

        var catalog = CachedFeeds.Open(this, PlaceDirectory, place);
        return Intern(catalog);
        }


    #endregion

    /// <summary>Return the feeds associated with a place</summary>
    /// <param name="place">The place uid</param>
    /// <returns>The cached feeds for the place</returns>
    public CacheHandle<CachedPosts> CreateFeedPosts(
                string place,
                string feed) {
        var directory = CachedPosts.GetDirectory(PlaceDirectory, place, feed);
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

        var catalog = CachedPosts.Open(this, PlaceDirectory, place, feed);
        return Intern(catalog);
        }

    /// <summary>Return the feeds associated with a place</summary>
    /// <param name="place">The place uid</param>
    /// <param name="feed">The feed uid</param>
    /// <returns>The cached feeds for the place</returns>
    public CacheHandle<CachedComments> GetPostComments(
                string place,
                string feed,
                string postId,
                CatalogedPost cataloged=null) {

        var catalog = CachedComments.Open(this, PlaceDirectory, place, feed, postId);
        catalog.CatalogedPost = cataloged;
        return Intern(catalog);
        }



    /// <summary>Return the feeds associated with a place</summary>
    /// <param name="place">The place uid</param>
    /// <param name="feed">The feed uid</param>
    /// <param name="post">The post uid</param>
    /// <returns>The cached feeds for the place</returns>
    public CacheHandle<CachedComments> GetPostAndComments(
                string placeId,
                string feedId,
                string postId) {

        CatalogedPost catalogedPost;

        // We only need the catalog handle long enough to be able to acquire the CatalogedPost
        using (var postsHandle = GetFeedPosts(placeId, feedId)) {
            var posts = postsHandle.Value;
            posts.AssertNotNull(FeedNotFound.Throw, feedId);
            posts.TryGetById(postId, out catalogedPost).AssertTrue(PostNotFound.Throw, postId);
            }

        // open the catalog, and return a handle to it.
        return GetPostComments(placeId, feedId, postId, catalogedPost);
        }

    /// <summary>Return the feeds associated with a place</summary>
    /// <param name="place">The place uid</param>
    /// <param name="feed">The feed uid</param>
    /// <param name="post">The post uid</param>
    /// <returns>The cached feeds for the place</returns>
    public CatalogedPost GetPost(
                string placeId,
                string feedId,
                string postId) {

        // We only need the catalog handle long enough to be able to acquire the CatalogedPost
        using var postsHandle = GetFeedPosts(placeId, feedId);


        var posts = postsHandle.Value;
        posts.AssertNotNull(FeedNotFound.Throw, feedId);
        posts.TryGetById(postId, out var catalogedPost).AssertTrue(PostNotFound.Throw, postId);

        return catalogedPost;
        }

    /// <summary>Return the feeds associated with a place</summary>
    /// <param name="place">The place uid</param>
    /// <param name="feed">The feed uid</param>
    /// <param name="post">The post uid</param>
    /// <returns>The cached feeds for the place</returns>
    public CatalogedComment GetComment(
                string placeId,
                string feedId,
                string postId, 
                string commentId) {
        using var catalog = GetPostComments(placeId, feedId, postId);

        var comments = catalog.Value;
        comments.AssertNotNull(FeedNotFound.Throw, feedId);
        comments.TryGetById(commentId, out var catalogedComment).AssertTrue(PostNotFound.Throw, postId);

        return catalogedComment;
        }


    public CacheHandle<CachedComments> GetComments(
            string placeId,
            string feedId,
            string postId) {

        // open the catalog, and return a handle to it.
        var catalog = CachedComments.Open(this, PlaceDirectory, placeId, feedId, postId);
        return Intern(catalog);
        }

    }

