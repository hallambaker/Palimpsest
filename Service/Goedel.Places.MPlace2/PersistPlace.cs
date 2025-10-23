
namespace Mplace2.Gui;



//public record RequestContext (
//            string LanguageCode
//            ) {



//    }

//public record RequestContextUser (
//            string LanguageCode,
//            string UserId
//            ) : RequestContext(LanguageCode){



//    }




public class PersistPlace {

    public Place? GetMainPlace () => new Place() {
        Uid = Udf.Nonce(),
        DNS = "mplace2.social",
        Title = "MPlace2",
        Description = "Making personal places on the Web",
        Banner = "Mplace2Banner.png",
        Avatar = "avatar.png"
        };





    }
