
using System.IO;
using System.Net;

using DocumentFormat.OpenXml.Spreadsheet;

using Goedel.Contacts;
using Goedel.Cryptography.Oauth;
using Goedel.IO;


namespace Mplace2.Gui;

public class PersistPlace : IPersistPlace {



    public CachedPlaces CachedPlaces { get; }
    public CatalogCache CatalogCache { get; }

    CatalogedPlace HomeCatalogedPlace { get; set; } = null;
    public Place? HomePlace { get; set; } = null;

    public List<Entry> RecentPlaces { get; set; } = new();


    public int MaxRecentPlaces { get; set; } = 10;

    /// <inheritdoc/>
    public ServerCookieManager ServerCookieManager { get; set; }


    /// <inheritdoc/>
    public OauthClient OauthClient { get; set; }


    /// <inheritdoc/>
    public FrameSet FrameSet { get; set; }


    string PlaceDirectory { get; }
    string ContentDirectory { get;  }




    public Dictionary<string, MemberHandle> Members { get; } = [];


    public Place DefaultPlace = new() {
        Description = "You haven't created a place yet!",
        Title = "Placeholder place"
        };



    public PersistPlace(FrameSet frameSet) {
        FrameSet = frameSet;
        PlaceDirectory = FrameSet.Directory;
        ContentDirectory = FrameSet.RepositoryFiles;
        CatalogCache = new();

        Directory.CreateDirectory(PlaceDirectory);
        Directory.CreateDirectory(ContentDirectory);

        AnnotationService.Initialized.AssertTrue(NYI.Throw);

        // Create the places file.
        CachedPlaces = CachedPlaces.Open(CatalogCache, PlaceDirectory);
        InitializePlaces();
        }


    private void InitializePlaces() {
        CachedPlaces.FillIndex();

        // Hack:  change  this to  read  first frame.
        foreach (var place in CachedPlaces.EntriesForward()) {
            HomeCatalogedPlace = CachedPlaces.GetValue(place);
            HomePlace = new(HomeCatalogedPlace);
            break;
            }

        foreach (var place in CachedPlaces.EntriesReverse()) {
            if (RecentPlaces.Count >= MaxRecentPlaces) {
                break;
                }
            var recent = CachedPlaces.GetValue(place); ;
            RecentPlaces.Add(new Place(recent));
            }

        }




    /// <inheritdoc/>
    public MemberHandle GetOrCreateMember(string handle, string did) {
        var member = new CatalogedForumVisitor() {
            Did = did,
            LocalName = handle
            };
        var result = new MemberHandle(member);

        Members.Add(did, result);
        return result;
        }

    /// <inheritdoc/>
    public MemberHandle? GetMember(ParsedPath path) {
        if (!ServerCookieManager.TryGetCookie(
            path.Context.Request, PalimpsestConstants.CookieTypeSessionTag, out var did)) {
            return null;
            }
        if (did is null) {
            return null;
            }

        if (Members.TryGetValue(did, out var member)) {
            path.MemberHandle = member;
            return member;
            }
        return null;
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

        // create the identifier for the place and the default feed
        var placeId = Udf.Nonce();
        var feedId = placeId;
        catalogedPlace.Uid = placeId;

        // initialize the default feed.
        using var placeFeeds = CatalogCache.CreatePlaceFeeds(placeId);
        var defaultFeed = new CatalogedFeed() {
            Uid = feedId
            };
        Add(placeFeeds.Value, placeId, defaultFeed);

        // add the place to the catalog
        CachedPlaces.Add(catalogedPlace);

        // Upodate the presentation information for the site home screen.
        var place = new Place(catalogedPlace);
        if (HomePlace is null) {
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
        entry.Uid ??= Udf.Nonce();
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
        entry.Uid ??= Udf.Nonce();
        using var posts = CatalogCache.GetFeedPosts(place, feed);
        posts.Value.Add(entry);

        using var comments = CatalogCache.CreateFeedPosts(place, entry.Uid);
        }

    public void Update(string place, string feed, CatalogedPost entry) {
        }

    public void Delete(string place, string feed, CatalogedPost entry) {
        // NYI
        }

    public void Add(string place, string feed, string post, CatalogedComment entry) {
        entry.Uid ??= Udf.Nonce();
        using var comments = CatalogCache.GetPostComments(place, feed, post);
        comments.Value.Add(entry);
        }

    public void Update(string place, string feed, string post, CatalogedComment entry) {
        }

    public void Delete(string place, string feed, string post, CatalogedComment entry) {
        // NYI
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







    }
