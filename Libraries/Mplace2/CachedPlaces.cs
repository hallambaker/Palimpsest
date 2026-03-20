using Goedel.Cryptography.Dare;


namespace Mplace2.Gui;


/// <summary>
/// Cached persistence store for places. Note that all ancilliary services
/// are managed by the PersistPlace 
/// </summary>
public class CachedPlaces : CachedCatalog<CatalogedPlace> {
    public const string FileName = "Places.darc";



    public static string GetFile(
                string directory) => Path.Combine(directory, FileName);


    public CatalogedPlace? HomePlace { get; set; }

    public CachedPlaces(
                CatalogCache catalogCache,
                EarlStream stream) : base(catalogCache, stream) {


        }

    public static CachedPlaces Open(CatalogCache catalogCache, string directory) {

        var fileName = GetFile(directory);
        var stream = EarlStream.Open(fileName, DareConstants.TypeIdentifierDareSequence);
        var result = new CachedPlaces(catalogCache, stream);



        return result;
        }
    }


/// <summary>
/// Cached persistence store for places. Note that all ancilliary services
/// are managed by the PersistPlace 
/// </summary>
public class CachedMembers : CachedCatalog<CatalogedMember> {
    public const string FileName = "Members.darc";



    public static string GetFile(
                string directory) => Path.Combine(directory, FileName);


    public CatalogedPlace? HomePlace { get; set; }

    public CachedMembers(
                CatalogCache catalogCache,
                EarlStream stream) : base(catalogCache, stream) {
        }

    public static CachedMembers Open(CatalogCache catalogCache, string directory) {

        var fileName = GetFile(directory);
        var stream = EarlStream.Open(fileName, DareConstants.TypeIdentifierDareSequence);
        var result = new CachedMembers(catalogCache, stream);



        return result;
        }


    public bool TryGetByHandle (string id, out CatalogedMember? result) =>
        TryGetBySecondaryId(id, out result);

    public bool TryGetByDid(string id, out CatalogedMember? result) =>
        TryGetById(CatalogedMember.DidToPrimaryKey( id), out result);


    }


public class CachedFeeds : CachedCatalog<CatalogedFeed> {
    public const string FileName = "Feeds.darc";

    public static string GetDirectory(
                string directory,
                string place) => Path.Combine(directory, place);

    public static string GetFile(
                string directory,
                string place)=> Path.Combine(directory, place, FileName);


    public CachedFeeds(
            CatalogCache catalogCache,
            EarlStream stream) : base(catalogCache, stream) {
        }

    public static CachedFeeds Open(
                CatalogCache catalogCache, 
                string directory, 
                string place) {
        var fileName = GetFile(directory, place);
        var stream = EarlStream.Open(fileName, DareConstants.TypeIdentifierDareSequence);
        var result = new CachedFeeds(catalogCache, stream);

        return result;
        }

    }



public class CachedPosts : CachedCatalog<CatalogedPost> {
    public const string FileName = "Posts.darc";

    public static string GetDirectory(
            string directory,
            string place,
            string feed) => Path.Combine(directory, place, feed);
    public static string GetFile(
                string directory,
                string place,
                string feed) => Path.Combine(directory, place, feed, FileName);

    public CachedPosts(
            CatalogCache catalogCache,
            EarlStream stream) : base(catalogCache, stream) {
        }

    public static CachedPosts Open(
                CatalogCache catalogCache, 
                string directory, 
                string place, 
                string feed) {
        var fileName = GetFile(directory, place, feed);
        var stream = EarlStream.Open(fileName, DareConstants.TypeIdentifierDareSequence);
        var result = new CachedPosts(catalogCache, stream);

        return result;
        }


    }

public class CachedComments : CachedCatalog<CatalogedComment> {

    /// <summary>The post entry in the catalog.</summary>
    public CatalogedPost CatalogedPost { get; set; }


    public static string GetDirectory(
            string directory,
            string place,
            string feed) => Path.Combine(directory, place, feed);
    public static string GetFile(
                string directory,
                string place,
                string feed,
                string post) => Path.Combine(directory, place, feed, post+".darc");

    public CachedComments(
            CatalogCache catalogCache,
            EarlStream stream) : base(catalogCache, stream) {
        }

    public static CachedComments Open(
                CatalogCache catalogCache,
                string directory,
                string place,
                string feed,
                string post) {
        var fileName = GetFile(directory, place, feed, post);
        var stream = EarlStream.Open(fileName, DareConstants.TypeIdentifierDareSequence);
        var result = new CachedComments(catalogCache, stream);

        return result;
        }


    }

