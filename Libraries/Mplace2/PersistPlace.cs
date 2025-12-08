
using System.IO;
using System.Net;

using DocumentFormat.OpenXml.Spreadsheet;

using Goedel.Contacts;
using Goedel.Cryptography.Oauth;
using Goedel.IO;


namespace Mplace2.Gui;

public class PersistPlace : IPersistPlace {



    public CachedPlaces CachedPlaces { get; }


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

        Directory.CreateDirectory(PlaceDirectory);
        Directory.CreateDirectory(ContentDirectory);

        AnnotationService.Initialized.AssertTrue(NYI.Throw);

        // Create the places file.
        CachedPlaces = new(this, PlaceDirectory, true);
        HomePlace = CachedPlaces.PrimaryHandle?.Place;

        }

    /// <inheritdoc/>
    public MemberHandle GetOrCreateMember(string handle, string did) {
        var member = new CatalogedForumMember() {
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


    /// <summary></summary>
    /// <param name="catalogedPlace"></param>
    /// <remarks>Update is locked to ensure threat safety. If two places are added at 
    /// the same time, the list updates are performed sequentially.</remarks>
    public void AddPlace(CatalogedPlace catalogedPlace) {
        catalogedPlace.Uid = Udf.Nonce();

        // Add place to repo
        //var handle = new PlaceHandle(CachedPlaces, catalogedPlace);
        //var place = handle.Place;

        //CachedPlaces.Add(handle);


        var handle = CachedPlaces.Create(catalogedPlace);
        var place = handle.Place;


        // Upodate the catalog
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
