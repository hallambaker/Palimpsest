
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;

using DocumentFormat.OpenXml.Spreadsheet;

using Goedel.Contacts;
using Goedel.Cryptography.Jose;
using Goedel.Cryptography.Oauth;
using Goedel.Discovery;
using Goedel.IO;
using Goedel.Protocol.Service;

using Microsoft.Extensions.Hosting;


namespace Mplace2.Gui;

public class PersistPlace : IPersistPlace {



    public PlaceConfiguration PlaceConfiguration { get; }

    public CachedMembers CachedMembers { get; }
    public CachedPlaces CachedPlaces { get; }
    public CatalogCache CatalogCache { get; }

    public bool PlaceExists => HomePlace != null;

    public CatalogedPlace HomeCatalogedPlace { get; set; } = null;
    public Place? HomePlace { get; set; } = null;

    public List<Entry> RecentPlaces { get; set; } = new();


    public int MaxRecentPlaces { get; set; } = 10;

    /// <inheritdoc/>
    public ServerCookieManager ServerCookieManager { get; set; }
    public ResoourceLimits ResourceLimits { get; } = new();

    /// <inheritdoc/>
    public OauthClient OauthClient { get; set; }


    /// <inheritdoc/>
    public FrameSet FrameSet { get; set; }


    string PlaceDirectory { get; }
    string ContentDirectory { get;  }


    public int IdLength { get; set; } = 40;



    public Place DefaultPlace = new() {
        Description = "You haven't created a place yet!",
        Title = "Placeholder place"
        };



    public PersistPlace(FrameSet frameSet, PlaceConfiguration placeConfiguration) {
        PlaceConfiguration = placeConfiguration;
        FrameSet = frameSet;
        PlaceDirectory = FrameSet.Directory;
        ContentDirectory = FrameSet.RepositoryFiles;
        CatalogCache = new(PlaceDirectory);

        Directory.CreateDirectory(PlaceDirectory);
        Directory.CreateDirectory(ContentDirectory);

        AnnotationService.Initialized.AssertTrue(NYI.Throw);

        // Create the places file.
        CachedPlaces = CachedPlaces.Open(CatalogCache, PlaceDirectory);
        CachedMembers = CachedMembers.Open(CatalogCache, PlaceDirectory);
        InitializePlaces();
        SetResoourceLimits();
        PlaceConfiguration = placeConfiguration;
        }

    private void SetResoourceLimits() {
        ResourceLimits.RequestSize = SetLimit(PalimpsestConstants.LimitRequestSizeTag, ResourceLimits.RequestSize);
        ResourceLimits.PostsPerHour = SetLimit(PalimpsestConstants.LimitPostsPerHourTag, ResourceLimits.PostsPerHour);
        ResourceLimits.PostSize = SetLimit(PalimpsestConstants.LimitPostSizeTag, ResourceLimits.PostSize);
        ResourceLimits.CommentSize = SetLimit(PalimpsestConstants.LimitCommentSizeTag, ResourceLimits.CommentSize);
        ResourceLimits.UserStorage = SetLimit(PalimpsestConstants.LimitUserStorageTag, ResourceLimits.UserStorage);
        }

    private int SetLimit(string tag, int value) {
        PlaceConfiguration.Limits?.TryGetValue(tag, out value);
        return value;
        }


    private void InitializePlaces() {

        if (PlaceConfiguration.DefaultSite != null) {
            if (CachedPlaces.TryGetBySecondaryId(PlaceConfiguration.DefaultSite,
                    out var catalogedPlace)) {
                HomeCatalogedPlace = catalogedPlace;
                HomePlace = new(HomeCatalogedPlace, this);
                }
            }

        foreach (var place in CachedPlaces.EntriesReverse()) {
            if (RecentPlaces.Count >= MaxRecentPlaces) {
                break;
                }
            var recent = CachedPlaces.GetValue(place);
            if (recent.Uid != HomeCatalogedPlace.Uid) {
                RecentPlaces.Add(new Place(recent, this));
                }
            }


        // Set the site administrator flag for accounts in the 
        foreach (var admin in PlaceConfiguration.Administrators.IfEnumerable()) {
            if (CachedMembers.TryGetByHandle(admin,
                    out var catalogedMember)) {
                catalogedMember.IsAdministrator = true;
                }
            }


        }

    /// <inheritdoc/>
    public bool TryGetPlaceByDns(Uri uri, out CatalogedPlace? catalogedPlace) =>
        CachedPlaces.TryGetBySecondaryId(uri.Host, out catalogedPlace);

    /// <inheritdoc/>
    public CatalogedMember GetOrCreateMember(string handle, string did) {

        if (CachedMembers.TryGetByDid(did, out var member)) {
            return member;
            }

        var result = new CatalogedMember() {
            Did = did,
            LocalName = handle
            };

        foreach (var admin in PlaceConfiguration.Administrators.IfEnumerable()) {
            if (admin == handle) {
                result.IsAdministrator = true;
                }
            }

        CachedMembers.Add(result);
        return result;
        }





    /// <inheritdoc/>
    public bool GetMember(ParsedPath path, out CatalogedMember? member) =>
        (CachedMembers.TryGetById(path.UserId, out member));


    public User GetUser(string userId) {
        if (CachedMembers.TryGetById(userId, out var member)) {


            return new User() {
                Avatar = GetMemberAvatar(member._PrimaryKey),
                DisplayName = member.Display,
                DisplayHandle = member.DisplayHandle,
                Banned = false
                };

            }

        return new User() {
            Avatar = FrameSet.IconPath( "AvatarDefault.svg"),
            DisplayName = "Anonymous",
            DisplayHandle = "not.here",
            Banned = false
            
            };

        }



    public Cookie SignOut() =>

        ServerCookieManager.ClearCookie(PalimpsestConstants.CookieTypeSessionTag);



    public bool ValidateImage(BackingTypeFile? file) {
        // check size is in bounds


        // check type
        return file.ContentType switch {
            PalimpsestConstants.ImagePng or
            PalimpsestConstants.ImageGif or
            PalimpsestConstants.ImageJpeg => true,
            _ => false
            };


        }

    static string LockRepoFile = "";
    public string AddImage(BackingTypeFile file) {

        var id = Udf.ContentDigestOfDataString(file.Data, file.ContentType);
        var extension = file.ContentType.GetFileExtension();
        id = Path.ChangeExtension(id, extension);

        var filePath = Path.Combine(ContentDirectory, id);

        lock (LockRepoFile) {
            if (!File.Exists(filePath)) {
                filePath.WriteFileNew(file.Data);
                }
            }

        return id;
        }

    #region Manage places
    /// <summary></summary>
    /// <param name="catalogedPlace"></param>
    /// <remarks>Update is locked to ensure thread safety. If two places are added at 
    /// the same time, the list updates are performed sequentially.</remarks>
    public void Add(CatalogedPlace catalogedPlace) {
        catalogedPlace.Uid ??= CreatePlaceId();
        // create the identifier for the place and the default feed
        var placeId = catalogedPlace.Uid;
        var feedId = placeId;

        // initialize the default feed.
        using var placeFeeds = CatalogCache.CreatePlaceFeeds(placeId);
        var defaultFeed = new CatalogedFeed() {
            Uid = feedId
            };
        Add(placeFeeds.Value, placeId, defaultFeed);

        // add the place to the catalog
        CachedPlaces.Add(catalogedPlace);

        // Upodate the presentation information for the site home screen.
        var place = new Place(catalogedPlace, this);
        if (HomePlace is null) {
            HomeCatalogedPlace = catalogedPlace;
            HomePlace = place;
            }
        else {
            var newPlaces = new List<Entry> { place };
            lock (RecentPlaces) {
                foreach (var entry in RecentPlaces) {
                    if (newPlaces.Count < MaxRecentPlaces) {
                        newPlaces.Add(entry);
                        }
                    }
                }
            RecentPlaces = newPlaces;
            }
        }


    public void Update(CatalogedPlace catalogedPlace) {
        }

    public void Delete(CatalogedPlace catalogedPlace) {
        // NYI
        }

    #endregion

    /// <summary>Add the feed <paramref name="entry"/> to the place 
    /// <paramref name="place"/></summary>
    /// <param name="place">The place identifier</param>
    /// <param name="entry">The entry to add.</param>
    public void Add(string place, CatalogedFeed entry) {    
        entry.Uid ??= CreateFeedId();
        using var feeds = CatalogCache.GetPlaceFeeds(place);
        Add(feeds.Value, place, entry);
        }

    void Add(CachedFeeds feeds, string place, CatalogedFeed entry) {
        feeds.Add(entry);
        using var posts = CatalogCache.CreateFeedPosts(place, entry.Uid);

        }




    public void Update(string place, CatalogedFeed entry) {
        }

    public void Delete(string place, CatalogedFeed entry) {
        // NYI
        }

    public void Add(string place, string feed, CatalogedPost entry) {
        entry.Uid ??= CreatePostId();
        using var posts = CatalogCache.GetFeedPosts(place, feed??place);
        posts.Value.Add(entry);

        using var comments = CatalogCache.CreateFeedPosts(place, entry.Uid);
        }

    public void Update(string place, string feed, CatalogedPost entry) {
        }

    public void DeletePost(string place, string feedId, string entryId) {
        using var feed = CatalogCache.GetFeedPosts(place, feedId);
        feed.Value.Delete(entryId);
        // NYI
        }

    public void Add(string place, string feed, string post, CatalogedComment entry) {
        entry.Uid ??= CreateCommentId();
        using var comments = CatalogCache.GetComments(place, feed, post);
        comments.Value.Add(entry);
        }

    public void Update(string place, string feed, string post, CatalogedComment entry) {
        }

    public void DeleteComment(string place, string feed, string post, string entry) {
        using var comment = CatalogCache.GetComments(place, feed, post);
        comment.Value.Delete(entry);
        }





    /// <summary>Return the main entry for the place.</summary>
    /// <param name="context">The place to return the main entry for.</param>
    /// <returns>The main entry.</returns>
    /// <remarks>This is a thread safe operation because C# guarantees that reads and 
    /// writes of word sized memory locations are atomic.</remarks>
    public Place? GetMainEntry(ParsedPath context) {
        return HomePlace ?? DefaultPlace;
        }


    /// <summary>Return the list of main entries for the place.</summary>
    /// <param name="context">The place to return the entries for.</param>
    /// <returns>The list of entries.</returns>
    /// <remarks>This is a thread safe operation because C# guarantees that reads and 
    /// writes of word sized memory locations are atomic.</remarks>
    public List<Entry>? GetMainEntries(ParsedPath context) {
        return RecentPlaces;
        }


    public string SitePath => HomePlace?.DNS is null ? "/" : $"https://{HomePlace?.DNS}/";


    /// <summary>Return the path to the member avatar. This is canonically on the
    /// site DNS name.</summary>
    /// <param name="memberId">Member identifier.</param>
    /// <returns>The fully expanded HTTPS path.</returns>
    public string GetMemberAvatar(
        string memberId) => $"{SitePath}Avatar/{memberId}";

    /// <summary>Return the path to the member account page. This is canonically on the
    /// site DNS name.</summary>
    /// <param name="memberId">Member identifier.</param>
    /// <returns>The fully expanded HTTPS path.</returns>
    public string GetAuthorLink(
    string memberId) => $"{SitePath}MemberPage/{memberId}";



    public string GetFeedPath(
    string feedId) => $"/{feedId}";


    public string GetPostPath(
        string feedId,
        string postId) => $"/{feedId}/{postId}";

    public string GetCommentPath(
        string feedId,
        string postId,
        string commentId) => $"/{feedId}/{postId}/{commentId}";


    //public string GetFeedLink(
    //    string feedId) => $"/Posts{GetFeedPath(feedId)}";

    public string GetPostLink(
            string feedId,
            string postId) => $"/PostPage{GetPostPath(feedId, postId)}";


    // Links for referalls etc.
    public string GetPlaceLink(
        ParsedPath path) => $"https://{path.PlaceName}/";

    public string GetFeedLink(
        ParsedPath path) => $"https://{path.PlaceName}/PostsPage{GetFeedPath(path.FeedId)}";

    public string GetPostLink(
        ParsedPath path) => $"https://{path.PlaceName}/PostPage{GetPostPath(path.FeedId, path.PostId)}";

    public string GetCommentLink(
        ParsedPath path) => $"https://{path.PlaceName}/Posts{GetCommentPath(path.FeedId, path.PostId, path.CommentId)}";

    public string GetMemberLink(
        ParsedPath path) => $"https://{HomePlace}/MemberPage{GetAuthorLink(path.AuthorId)}";

    public string GetPlaceUri(CatalogedPlace place) => $"https://{place.LocalName}/";

    /// <summary>Return the resource URI for the object <paramref name="id"/> at 
    /// place <paramref name="placeId"/>.</summary>
    /// <param name="placeId"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public virtual string GetResourceUri(string placeId, string id) => SitebuilderConstants.Repository + id;

    public virtual string CreatePlaceId() => Udf.Nonce(IdLength);
    public virtual string CreateFeedId() => Udf.Nonce(IdLength);
    public virtual string CreatePostId() => Udf.Nonce(IdLength);


    public virtual string CreateCommentId() => Udf.Nonce(IdLength);


    public string GetAvatarPath(CatalogedMember member) {

        if (member is null) {
            return FrameSet.IconPath("Any");
            }


        return GetMemberAvatar(member._PrimaryKey);


        }

    }
