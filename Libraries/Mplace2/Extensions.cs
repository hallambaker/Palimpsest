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


    public static PersistPlace GetContext(this IPageContext context) =>
    (context as ParsedPath)?.PersistPlace as PersistPlace;

    public static PersistPlace GetPersist(this IPageContext context) =>
        (context as ParsedPath)?.PersistPlace as PersistPlace;

    }
