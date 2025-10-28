
using Goedel.Cryptography.Oauth;

using Mplace2.Gui;
namespace Goedel.Places.MPlace2;



//public record RequestContext (
//            string LanguageCode
//            ) {



//    }

//public record RequestContextUser (
//            string LanguageCode,
//            string UserId
//            ) : RequestContext(LanguageCode){



//    }




public class PersistPlace : IPersistPlace {

    /// <inheritdoc/>
    public ServerCookieManager ServerCookieManager { get; set; }


    /// <inheritdoc/>
    public OauthClient OauthClient { get; set; }


    /// <inheritdoc/>
    public FrameSet FrameSet { get; set; }

    public Place? GetMainPlace (ParsedPath context) => new Place() {
        Uid = Udf.Nonce(),
        DNS = "mplace2.social",
        Title = "MPlace2",
        Description = "Making personal places on the Web",
        Banner = "Mplace2Banner.png",
        Avatar = "avatar.png"
        };


    public List<Entry>? GetMainEntries(ParsedPath context) => [
        new Place() {
            Uid = Udf.Nonce(),
            DNS = "mplace2.social",
            Title = "MPlace2",
            Description = "Making personal places on the Web",
            Banner = "Mplace2Banner.png",
            Avatar = "avatar.png"
            },
        new Place() {
            Uid = Udf.Nonce(),
            DNS = "phill.hallambaker.com",
            Title = "Phill's Place",
            Description = "PHB's place on the Web",
            Banner = "PHBBanner.png",
            Avatar = "PHBInDalek.png"
            }
        ];


    }
