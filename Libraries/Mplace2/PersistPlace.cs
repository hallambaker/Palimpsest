
using DocumentFormat.OpenXml.Spreadsheet;

using Goedel.Cryptography.Oauth;
using Goedel.Places;


namespace Mplace2.Gui;

public static class Extensions {

    public static SignInState GetSignInState(
            this Goedel.Sitebuilder.FramePage page,
            out SignInState value) {
        value = GetSignInState(page);
        return value;
        }

    public static SignInState GetSignInState(
                this Goedel.Sitebuilder.FramePage page) {
        if (page.Context is not ParsedPath path) {
            return SignInState.Initial;
            }
        path.MemberHandle ??= path.PersistPlace.GetMember(path);
        var handle = path.MemberHandle;

        if (handle is null) {
            return SignInState.Initial;
            }

        var signedIn = SignInState.SignedIn;

        if (handle.LocalName == "phill.hallambaker.com") {
            signedIn |= SignInState.IsAdministrator ;
            }

        return signedIn;
        }



    }



public class PersistPlace : IPersistPlace {

    /// <inheritdoc/>
    public ServerCookieManager ServerCookieManager { get; set; }


    /// <inheritdoc/>
    public OauthClient OauthClient { get; set; }


    /// <inheritdoc/>
    public FrameSet FrameSet { get; set; }


    public Dictionary<string, MemberHandle> Members { get; } = [];

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
