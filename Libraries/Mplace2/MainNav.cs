namespace Goedel.Places;



/// <summary>
/// Sign in states
/// </summary>
public enum SignInState {
    ///<summary>The initial state, visitor is not signed in.</summary>
    Initial = 0,
    ///<summary>Visitor has signed in but has not created a personal place.</summary>
    NoPersonalPlace = 1,
    ///<summary>Visitor has signed in and has created a personal place.</summary>
    HasPersonalPlace = 2
    }





public partial class MainNav {



    /// <summary>If true, the visitor is an administrator.</summary>
    public bool IsAdmin { get; set; } = true;

    /// <summary>The sign in state.</summary>
    public SignInState SignInState { get; set; }

    /// <summary>True if the user has signed in.</summary>
    public bool SignedIn => SignInState > SignInState.Initial;

    /// <summary>True if the user has a personal page.</summary>
    public bool HasPersonal => SignInState == SignInState.HasPersonalPlace;


    /// <summary>State of the sign in button, only visible when signed out, active 
    /// on sign in page</summary>
    public ButtonVisibility? SignInActive => GetVisibility(Page is SignIn, SignedIn);

    /// <summary>State of the sign out button, only visible when signed in, active 
    /// on sign out page</summary>
    public ButtonVisibility? SignOutActive => GetVisibility(Page is SwitchPage, !SignedIn);

    /// <summary>State of the home page button, active on the home page.</summary>
    public ButtonVisibility? HomePageActive => GetVisibility(Page is HomePage);

    /// <summary>State of the homnotifications page button, active on the notifications page, disabled
    /// if not signed in.</summary>
    public ButtonVisibility? NotificationsActive => GetVisibility(Page is NotificationsPage,
        disable: !SignedIn);

    /// <summary>State of the places button, active on the places page, disabled
    /// if not signed in.</summary>
    public ButtonVisibility? PlacesActive => GetVisibility(Page is PlacesPage,
        disable: !SignedIn);

    /// <summary>State of the bookmarks button, active on the bookmarks page, disabled
    /// if not signed in.</summary>
    public ButtonVisibility? BookmarksActive => GetVisibility(Page is BookmarkPage,
        disable: !SignedIn);


    /// <summary>State of the your place button, active on the bookmarks page, only
    /// visible if visitor has a personal page</summary>
    public ButtonVisibility? YourPlaceActive => GetVisibility(Page is YourPlacePage, !HasPersonal);


    /// <summary>State of the create your page button, not visible if the user has a 
    /// personal page. Is never disabled (but user will be presented with a sign in
    /// screen if not logged in).</summary>
    public ButtonVisibility? CreateYourPlaceActive => GetVisibility(Page is YourPlacePageCreate, HasPersonal);


    /// <summary>State of the settings button, active on the settings page.</summary>
    public ButtonVisibility? SettingsActive => GetVisibility(Page is SettingsPage);

    /// <summary>State of the settings button, active on the new plage page, only visible if
    /// the visitor is logged in as an administrator..</summary>
    public ButtonVisibility? CreatePlaceActive => GetVisibility(Page is NewPlacePage, !IsAdmin);


    ButtonVisibility GetVisibility(
                bool active,
                bool hide = false, 
                bool disable = false) {
        if (hide) {
            return ButtonVisibility.None;
            }
        if (disable) {
            return ButtonVisibility.Disabled;
            }
        if (active) {
            return ButtonVisibility.Active;
            }
        return ButtonVisibility.Available;
        }




    }