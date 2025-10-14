namespace Frame;



public enum SignInState {
    Initial =0,
    NoPersonalPlace = 1,
    HasPersonalPlace =2
    
    }





public partial class MainNav {

    public FramePage Page => FrameSet.Page;

    public bool IsAdmin { get; set; } = true;

    public SignInState SignInState { get; set; }

    public bool SignedIn => SignInState > SignInState.Initial;
    public bool HasPersonal => SignInState == SignInState.HasPersonalPlace;


    public ButtonVisibility? SignInActive => GetVisibility(Page is SignIn, SignedIn);

    public ButtonVisibility? SignOutActive => GetVisibility(Page is SwitchPage, !SignedIn);

    public ButtonVisibility? HomePageActive => GetVisibility(Page is HomePage);

    public ButtonVisibility? NotificationsActive => GetVisibility(Page is NotificationsPage,
        disable: !SignedIn);

    public ButtonVisibility? PlacesActive => GetVisibility(Page is PlacesPage,
        disable: !SignedIn);
    public ButtonVisibility? BookmarksActive => GetVisibility(Page is BookmarkPage,
        disable: !SignedIn);


    public ButtonVisibility? YourPlaceActive => GetVisibility(Page is YourPlacePage, !HasPersonal);

    public ButtonVisibility? CreateYourPlaceActive => GetVisibility(Page is YourPlacePageCreate, HasPersonal);

    
    public ButtonVisibility? SettingsActive => GetVisibility(Page is SettingsPage);

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