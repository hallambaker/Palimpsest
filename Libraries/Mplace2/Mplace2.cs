
#pragma warning disable IDE0028 // Simplify collection initialization
namespace Mplace2.Gui;


/// <summary>
/// Annotated backing classes for data driven GUI.
/// </summary>
public partial class MyClass : FrameSet{

	///<summary>HomePage</summary>
	public HomePage HomePage {get;} = new();

	///<summary>NotificationsPage</summary>
	public NotificationsPage NotificationsPage {get;} = new();

	///<summary>PlacesPage</summary>
	public PlacesPage PlacesPage {get;} = new();

	///<summary>FeedsPage</summary>
	public FeedsPage FeedsPage {get;} = new();

	///<summary>PostsPage</summary>
	public PostsPage PostsPage {get;} = new();

	///<summary>BookmarkPage</summary>
	public BookmarkPage BookmarkPage {get;} = new();

	///<summary>YourPlacePage</summary>
	public YourPlacePage YourPlacePage {get;} = new();

	///<summary>PostPage</summary>
	public PostPage PostPage {get;} = new();

	///<summary>MemberPage</summary>
	public MemberPage MemberPage {get;} = new();

	///<summary>SettingsPage</summary>
	public SettingsPage SettingsPage {get;} = new();

	///<summary>AccountSettings</summary>
	public AccountSettings AccountSettings {get;} = new();

	///<summary>AppearanceSettings</summary>
	public AppearanceSettings AppearanceSettings {get;} = new();

	///<summary>AboutSettingsPage</summary>
	public AboutSettingsPage AboutSettingsPage {get;} = new();

	///<summary>SignIn</summary>
	public SignIn SignIn {get;} = new();

	///<summary>SwitchPage</summary>
	public SwitchPage SwitchPage {get;} = new();

	///<summary>CreateFeed</summary>
	public CreateFeed CreateFeed {get;} = new();

	///<summary>DeleteFeedPage</summary>
	public DeleteFeedPage DeleteFeedPage {get;} = new();

	///<summary>CreatePost</summary>
	public CreatePost CreatePost {get;} = new();

	///<summary>DeletePostPage</summary>
	public DeletePostPage DeletePostPage {get;} = new();

	///<summary>CreateComment</summary>
	public CreateComment CreateComment {get;} = new();

	///<summary>DeleteCommentPage</summary>
	public DeleteCommentPage DeleteCommentPage {get;} = new();

	///<summary>NewPlacePage</summary>
	public NewPlacePage NewPlacePage {get;} = new();

	///<summary>DeletePlace</summary>
	public DeletePlace DeletePlace {get;} = new();

	///<summary>YourPlacePageCreate</summary>
	public YourPlacePageCreate YourPlacePageCreate {get;} = new();

	///<summary>Help</summary>
	public Help Help {get;} = new();

	///<summary>TermsOfService</summary>
	public TermsOfService TermsOfService {get;} = new();

	///<summary>PrivacyPolicy</summary>
	public PrivacyPolicy PrivacyPolicy {get;} = new();

	///<summary>Contributors</summary>
	public Contributors Contributors {get;} = new();

	///<summary>Status</summary>
	public Status Status {get;} = new();

	///<summary>SystemLog</summary>
	public SystemLog SystemLog {get;} = new();

	///<summary>Repository</summary>
	public Repository Repository {get;} = new();


	///<summary>MainNav</summary>
	public MainNav MainNav {get;} = new();

	///<summary>TopSettings</summary>
	public TopSettings TopSettings {get;} = new();

	///<summary>SettingsMenu</summary>
	public SettingsMenu SettingsMenu {get;} = new();

	///<summary>AboutSettings</summary>
	public AboutSettings AboutSettings {get;} = new();

	///<summary>SupportMenu</summary>
	public SupportMenu SupportMenu {get;} = new();



	 ///<summary>HandleInput</summary>
	 public HandleInput HandleInput {get;} = new();

	 ///<summary>SignOut</summary>
	 public SignOut SignOut {get;} = new();

	 ///<summary>FormPlace</summary>
	 public FormPlace FormPlace {get;} = new();

	 ///<summary>Handle</summary>
	 public Handle Handle {get;} = new();

	 ///<summary>Provider</summary>
	 public Provider Provider {get;} = new();

	 ///<summary>User</summary>
	 public User User {get;} = new();

	 ///<summary>Group</summary>
	 public Group Group {get;} = new();

	 ///<summary>Rights</summary>
	 public Rights Rights {get;} = new();

	 ///<summary>Access</summary>
	 public Access Access {get;} = new();

	 ///<summary>Privileges</summary>
	 public Privileges Privileges {get;} = new();

	 ///<summary>Entry</summary>
	 public Entry Entry {get;} = new();

	 ///<summary>Place</summary>
	 public Place Place {get;} = new();

	 ///<summary>DeleteFeed</summary>
	 public DeleteFeed DeleteFeed {get;} = new();

	 ///<summary>Feed</summary>
	 public Feed Feed {get;} = new();

	 ///<summary>DeletePost</summary>
	 public DeletePost DeletePost {get;} = new();

	 ///<summary>Post</summary>
	 public Post Post {get;} = new();

	 ///<summary>DeleteComment</summary>
	 public DeleteComment DeleteComment {get;} = new();

	 ///<summary>Comment</summary>
	 public Comment Comment {get;} = new();

	 ///<summary>Resource</summary>
	 public Resource Resource {get;} = new();

	 ///<summary>Contact</summary>
	 public Contact Contact {get;} = new();

	 ///<summary>Name</summary>
	 public Name Name {get;} = new();

	 ///<summary>TagValue</summary>
	 public TagValue TagValue {get;} = new();

	 ///<summary>Organization</summary>
	 public Organization Organization {get;} = new();

	 ///<summary>Pronouns</summary>
	 public Pronouns Pronouns {get;} = new();

	 ///<summary>Title</summary>
	 public Title Title {get;} = new();

	 ///<summary>RelatedTo</summary>
	 public RelatedTo RelatedTo {get;} = new();

	 ///<summary>Application</summary>
	 public Application Application {get;} = new();

	 ///<summary>Email</summary>
	 public Email Email {get;} = new();

	 ///<summary>Messaging</summary>
	 public Messaging Messaging {get;} = new();

	 ///<summary>Phone</summary>
	 public Phone Phone {get;} = new();

	 ///<summary>Service</summary>
	 public Service Service {get;} = new();

	 ///<summary>Key</summary>
	 public Key Key {get;} = new();

	 ///<summary>KeyData</summary>
	 public KeyData KeyData {get;} = new();

	 ///<summary>Media</summary>
	 public Media Media {get;} = new();

	 ///<summary>Option</summary>
	 public Option Option {get;} = new();

	 ///<summary>ServiceOption</summary>
	 public ServiceOption ServiceOption {get;} = new();

	/// <summary>
	/// Constructor, return a new instance.
	/// </summary>
	public MyClass () {

		Pages = [ 
			HomePage,
			NotificationsPage,
			PlacesPage,
			FeedsPage,
			PostsPage,
			BookmarkPage,
			YourPlacePage,
			PostPage,
			MemberPage,
			SettingsPage,
			AccountSettings,
			AppearanceSettings,
			AboutSettingsPage,
			SignIn,
			SwitchPage,
			CreateFeed,
			DeleteFeedPage,
			CreatePost,
			DeletePostPage,
			CreateComment,
			DeleteCommentPage,
			NewPlacePage,
			DeletePlace,
			YourPlacePageCreate,
			Help,
			TermsOfService,
			PrivacyPolicy,
			Contributors,
			Status,
			SystemLog,
			Repository
			];

		Menus = [ 
			MainNav,
			TopSettings,
			SettingsMenu,
			AboutSettings,
			SupportMenu
			];

		Selectors = [ 
			];

		Classes = [ 
			HandleInput,
			SignOut,
			FormPlace,
			Handle,
			Provider,
			User,
			Group,
			Rights,
			Access,
			Privileges,
			Entry,
			Place,
			DeleteFeed,
			Feed,
			DeletePost,
			Post,
			DeleteComment,
			Comment,
			Resource,
			Contact,
			Name,
			TagValue,
			Organization,
			Pronouns,
			Title,
			RelatedTo,
			Application,
			Email,
			Messaging,
			Phone,
			Service,
			Key,
			KeyData,
			Media,
			Option,
			ServiceOption
			];

			
		foreach (var backed in Pages) {
			ResolveReferences (backed); 
			}
		foreach (var backed in Menus) {
			ResolveReferences (backed); 
			}
		foreach (var backed in Selectors) {
			ResolveReferences (backed); 
			}
		foreach (var backed in Classes) {
			ResolveReferences (backed); 
			}
		}


	}



// Pages
/// <summary>
/// Backing class for HomePage
/// </summary>
public partial class HomePage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public HomePage () : base ("HomePage", "MPlace2 - Welcome! Everything is fine.", _Fields) {
		Container = null;
		}

    /// <summary>Field MainEntry</summary>
	public Place? MainEntry {get; set;}

    /// <summary>Field Entries</summary>
	public List<Entry>? Entries {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRefClass<Place> ("MainEntry","Place"){
			Presentation = FullPresentation,
			Get = (data) => (data as HomePage)?.MainEntry ,
			Set = (data, value) => {(data as HomePage)!.MainEntry = value as Place; }},
		new FrameRefList<Entry> ("Entries","Entry"){
			Presentation = SummaryPresentation,
			Get = (data) => (data as HomePage)?.Entries ,
			Set = (data, value) => {(data as HomePage)!.Entries = value as List<Entry>; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<HomePage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "HomePage",
		() => new HomePage(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for NotificationsPage
/// </summary>
public partial class NotificationsPage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public NotificationsPage () : base ("NotificationsPage", "Notifications", _Fields) {
		Container = "FlowPage";
		}

    /// <summary>Field Entries</summary>
	public List<Entry>? Entries {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRefList<Entry> ("Entries","Entry"){
			Presentation = SummaryPresentation,
			Get = (data) => (data as NotificationsPage)?.Entries ,
			Set = (data, value) => {(data as NotificationsPage)!.Entries = value as List<Entry>; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<NotificationsPage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "NotificationsPage",
		() => new NotificationsPage(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for PlacesPage
/// </summary>
public partial class PlacesPage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public PlacesPage () : base ("PlacesPage", "Places", _Fields) {
		Container = "FlowPage";
		}

    /// <summary>Field Entries</summary>
	public List<Entry>? Entries {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRefList<Entry> ("Entries","Entry"){
			Presentation = SummaryPresentation,
			Get = (data) => (data as PlacesPage)?.Entries ,
			Set = (data, value) => {(data as PlacesPage)!.Entries = value as List<Entry>; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<PlacesPage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "PlacesPage",
		() => new PlacesPage(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for FeedsPage
/// </summary>
public partial class FeedsPage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public FeedsPage () : base ("FeedsPage", "Places", _Fields) {
		Container = "FlowPage";
		}

    /// <summary>Field Entries</summary>
	public List<Entry>? Entries {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRefList<Entry> ("Entries","Entry"){
			Presentation = SummaryPresentation,
			Get = (data) => (data as FeedsPage)?.Entries ,
			Set = (data, value) => {(data as FeedsPage)!.Entries = value as List<Entry>; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<FeedsPage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "FeedsPage",
		() => new FeedsPage(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for PostsPage
/// </summary>
public partial class PostsPage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public PostsPage () : base ("PostsPage", "Posts", _Fields) {
		Container = "FlowPage";
		}

    /// <summary>Field Entries</summary>
	public List<Entry>? Entries {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRefList<Entry> ("Entries","Entry"){
			Presentation = SummaryPresentation,
			Get = (data) => (data as PostsPage)?.Entries ,
			Set = (data, value) => {(data as PostsPage)!.Entries = value as List<Entry>; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<PostsPage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "PostsPage",
		() => new PostsPage(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for BookmarkPage
/// </summary>
public partial class BookmarkPage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public BookmarkPage () : base ("BookmarkPage", "Saved", _Fields) {
		Container = "FlowPage";
		}

    /// <summary>Field Entries</summary>
	public List<Entry>? Entries {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRefList<Entry> ("Entries","Entry"){
			Presentation = SummaryPresentation,
			Get = (data) => (data as BookmarkPage)?.Entries ,
			Set = (data, value) => {(data as BookmarkPage)!.Entries = value as List<Entry>; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<BookmarkPage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "BookmarkPage",
		() => new BookmarkPage(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for YourPlacePage
/// </summary>
public partial class YourPlacePage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public YourPlacePage () : base ("YourPlacePage", "Your Place", _Fields) {
		Container = "FlowPage";
		}

    /// <summary>Field MainEntry</summary>
	public Place? MainEntry {get; set;}

    /// <summary>Field Entries</summary>
	public List<Entry>? Entries {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRefClass<Place> ("MainEntry","Place"){
			Presentation = FullPresentation,
			Get = (data) => (data as YourPlacePage)?.MainEntry ,
			Set = (data, value) => {(data as YourPlacePage)!.MainEntry = value as Place; }},
		new FrameRefList<Entry> ("Entries","Entry"){
			Presentation = SummaryPresentation,
			Get = (data) => (data as YourPlacePage)?.Entries ,
			Set = (data, value) => {(data as YourPlacePage)!.Entries = value as List<Entry>; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<YourPlacePage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "YourPlacePage",
		() => new YourPlacePage(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for PostPage
/// </summary>
public partial class PostPage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public PostPage () : base ("PostPage", "Post", _Fields) {
		Container = "PostPage";
		}

    /// <summary>Field MainEntry</summary>
	public Post? MainEntry {get; set;}

    /// <summary>Field Entries</summary>
	public List<Comment>? Entries {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRefClass<Post> ("MainEntry","Post"){
			Presentation = PostPresentation,
			Get = (data) => (data as PostPage)?.MainEntry ,
			Set = (data, value) => {(data as PostPage)!.MainEntry = value as Post; }},
		new FrameRefList<Comment> ("Entries","Comment"){
			Presentation = CommentPresentation,
			Get = (data) => (data as PostPage)?.Entries ,
			Set = (data, value) => {(data as PostPage)!.Entries = value as List<Comment>; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<PostPage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "PostPage",
		() => new PostPage(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for MemberPage
/// </summary>
public partial class MemberPage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public MemberPage () : base ("MemberPage", "MemberPage", _Fields) {
		Container = "MemberFlow";
		}

    /// <summary>Field MainEntry</summary>
	public User? MainEntry {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRefClass<User> ("MainEntry","User"){
			Presentation = MemberPresentation,
			Get = (data) => (data as MemberPage)?.MainEntry ,
			Set = (data, value) => {(data as MemberPage)!.MainEntry = value as User; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<MemberPage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "MemberPage",
		() => new MemberPage(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for SettingsPage
/// </summary>
public partial class SettingsPage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public SettingsPage () : base ("SettingsPage", "Settings", _Fields) {
		Container = "EntryPage";
		}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRefMenu ("SetingsCategory","SettingsMenu")
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<SettingsPage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "SettingsPage",
		() => new SettingsPage(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for AccountSettings
/// </summary>
public partial class AccountSettings : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public AccountSettings () : base ("AccountSettings", "Account Settings", _Fields) {
		Container = "EntryPage";
		}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav")
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<AccountSettings> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "AccountSettings",
		() => new AccountSettings(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for AppearanceSettings
/// </summary>
public partial class AppearanceSettings : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public AppearanceSettings () : base ("AppearanceSettings", "Appearance Settings", _Fields) {
		Container = "EntryPage";
		}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameDiv ("Description") { Fields = [

        		new FrameBlock ("P1") {Tag = "p", Text=[
        			"Here (eventually) provide a form to allow the user to control their settings."		    ]},
        		new FrameBlock ("P2") {Tag = "p", Text=[
        			"This should allow the user to choose a light or a dark theme, ",
        			"Select a larger or smaller font size and possibly a choice of font."		    ]}
				]
			}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<AppearanceSettings> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "AppearanceSettings",
		() => new AppearanceSettings(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for AboutSettingsPage
/// </summary>
public partial class AboutSettingsPage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public AboutSettingsPage () : base ("AboutSettingsPage", "About - MPlace2", _Fields) {
		Container = "EntryPage";
		}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRefMenu ("Settings","AboutSettings")
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<AboutSettingsPage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "AboutSettingsPage",
		() => new AboutSettingsPage(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for SignIn
/// </summary>
public partial class SignIn : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public SignIn () : base ("SignIn", "Sign In", _Fields) {
		Container = "EntryPage";
		}

    /// <summary>Field Form</summary>
	public HandleInput? Form {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameDiv ("Explanation") { Fields = [

        		new FrameBlock ("P1") {Tag = "p", Text=[
        			"Sign in using your BlueSky, Eurosky, BlackSky or other @nywhere account."		    ]},
        		new FrameBlock ("P2") {Tag = "p", Text=[
        			"If you do not have an @nywhere account, you can create one at any of the",
        			"following sites which will allow you to interact with any ATmosphere site."		    ]},
        		new FrameBlock ("BlueSky") {Tag = "li", Text=[
        			"<a href=\"https://bsky.app/\">BlueSky</a>"		    ]},
        		new FrameBlock ("BlackSky") {Tag = "li", Text=[
        			"<a href=\"https://blacksky.community/\">BlackSky</a>"		    ]},
        		new FrameBlock ("EuroSky") {Tag = "li", Text=[
        			"<a href=\"https://portal.eurosky.tech/create-account\">EuroSky</a>"		    ]}
				]
			},
		new FrameRefForm<HandleInput> ("Form","HandleInput", [
		new FrameString ("DNS",
			(data, value) => {(data as HandleInput)!.DNS = value; },
			(data) => (data as HandleInput)?.DNS) {
				Prompt = "@nywhere handle",
				Description = "The handle you use to log in to Blue Sky etc."
				}
				]){
			Get = (data) => (data as SignIn)?.Form ,
			Set = (data, value) => {(data as SignIn)!.Form = value as HandleInput; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<SignIn> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "SignIn",
		() => new SignIn(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for SwitchPage
/// </summary>
public partial class SwitchPage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public SwitchPage () : base ("SwitchPage", "Change Account", _Fields) {
		Container = "SwitchPage";
		}

    /// <summary>Field SignOut</summary>
	public SignOut? SignOut {get; set;}

    /// <summary>Field Form</summary>
	public HandleInput? Form {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameDiv ("SignOutDiv") { Fields = [

        		new FrameBlock ("SignOutTitle") {Tag = "h1", Text=[
        			"Sign out this account."		    ]}
				]
			},
		new FrameRefForm<SignOut> ("SignOut","SignOut", [
				]){
			Get = (data) => (data as SwitchPage)?.SignOut ,
			Set = (data, value) => {(data as SwitchPage)!.SignOut = value as SignOut; }},
		new FrameDiv ("SwitchDiv") { Fields = [

        		new FrameBlock ("SwitchTitle") {Tag = "h1", Text=[
        			"Switch to a different @nywhere account"		    ]}
				]
			},
		new FrameRefForm<HandleInput> ("Form","HandleInput", [
		new FrameString ("DNS",
			(data, value) => {(data as HandleInput)!.DNS = value; },
			(data) => (data as HandleInput)?.DNS) {
				Prompt = "@nywhere handle",
				Description = "The handle you use to log in to Blue Sky etc."
				}
				]){
			Get = (data) => (data as SwitchPage)?.Form ,
			Set = (data, value) => {(data as SwitchPage)!.Form = value as HandleInput; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<SwitchPage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "SwitchPage",
		() => new SwitchPage(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for CreateFeed
/// </summary>
public partial class CreateFeed : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public CreateFeed () : base ("CreateFeed", "Create New Post", _Fields) {
		Container = "EntryPage";
		}

    /// <summary>Field CreateFeedAction</summary>
	public Feed? CreateFeedAction {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRefForm<Feed> ("CreateFeedAction","Feed", [
		new FrameString ("Title",
			(data, value) => {(data as Feed)!.Title = value; },
			(data) => (data as Feed)?.Title) {
				Prompt = "Title",
				Description = "Title, should be short."
				},
		new FrameText ("Description",
			(data, value) => {(data as Feed)!.Description = value; },
			(data) => (data as Feed)?.Description) {
				Prompt = "Description",
				Description = "Feed description"
				},
		new FrameBoolean ("AllowPosts",
			(data, value) => {(data as Feed)!.AllowPosts = value; },
			(data) => (data as Feed)?.AllowPosts) {
				Prompt = "Allow text posts",
				Description = "Allow text posts in the feed."
				},
		new FrameBoolean ("AllowImages",
			(data, value) => {(data as Feed)!.AllowImages = value; },
			(data) => (data as Feed)?.AllowImages) {
				Prompt = "Allow images",
				Description = "Allow images in the feed."
				},
		new FrameBoolean ("AllowShort",
			(data, value) => {(data as Feed)!.AllowShort = value; },
			(data) => (data as Feed)?.AllowShort) {
				Prompt = "Allow short videos",
				Description = "Allow short videos in the feed."
				},
		new FrameBoolean ("AllowVideo",
			(data, value) => {(data as Feed)!.AllowVideo = value; },
			(data) => (data as Feed)?.AllowVideo) {
				Prompt = "Allow video",
				Description = "Allow longer videos in the feed."
				}
				]){
			Get = (data) => (data as CreateFeed)?.CreateFeedAction ,
			Set = (data, value) => {(data as CreateFeed)!.CreateFeedAction = value as Feed; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<CreateFeed> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "CreateFeed",
		() => new CreateFeed(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for DeleteFeedPage
/// </summary>
public partial class DeleteFeedPage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public DeleteFeedPage () : base ("DeleteFeedPage", "Delete Feed", _Fields) {
		Container = null;
		}


	static readonly List<IFrameField> _Fields = [
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<DeleteFeedPage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "DeleteFeedPage",
		() => new DeleteFeedPage(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for CreatePost
/// </summary>
public partial class CreatePost : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public CreatePost () : base ("CreatePost", "Create New Post", _Fields) {
		Container = "EntryPage";
		}

    /// <summary>Field CreatePostAction</summary>
	public Post? CreatePostAction {get; set;}

    /// <summary>Field Crosspost</summary>
	public List<Provider>? Crosspost {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRefForm<Post> ("CreatePostAction","Post", [
		new FrameString ("FeedId",
			(data, value) => {(data as Post)!.FeedId = value; },
			(data) => (data as Post)?.FeedId) {
				Hidden = true
				},
		new FrameString ("PostTitle",
			(data, value) => {(data as Post)!.PostTitle = value; },
			(data) => (data as Post)?.PostTitle) {
				Prompt = "Title",
				Description = "Title, should be short."
				},
		new FrameText ("Summary",
			(data, value) => {(data as Post)!.Summary = value; },
			(data) => (data as Post)?.Summary) {
				Prompt = "Summary",
				Description = "Short summary of the post to be used in lists of posts or to crosspost to other media"
				},
		new FrameRichText ("Body",
			(data, value) => {(data as Post)!.Body = value; },
			(data) => (data as Post)?.Body) {
				Prompt = "Body",
				Description = "What you want to say!"
				}
				]){
			Get = (data) => (data as CreatePost)?.CreatePostAction ,
			Set = (data, value) => {(data as CreatePost)!.CreatePostAction = value as Post; }},
		new FrameRefList<Provider> ("Crosspost","Provider"){
			Get = (data) => (data as CreatePost)?.Crosspost ,
			Set = (data, value) => {(data as CreatePost)!.Crosspost = value as List<Provider>; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<CreatePost> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "CreatePost",
		() => new CreatePost(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for DeletePostPage
/// </summary>
public partial class DeletePostPage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public DeletePostPage () : base ("DeletePostPage", "Delete Post", _Fields) {
		Container = "DeletePostPage";
		}

    /// <summary>Field PostTitle</summary>
	public string? PostTitle {get; set;}

    /// <summary>Field Summary</summary>
	public string? Summary {get; set;}

    /// <summary>Field Form</summary>
	public DeletePost? Form {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameString ("PostTitle",
			(data, value) => {(data as DeletePostPage)!.PostTitle = value; },
			(data) => (data as DeletePostPage)?.PostTitle) {
				Prompt = "Title",
				Description = "Title, should be short."
				},
		new FrameText ("Summary",
			(data, value) => {(data as DeletePostPage)!.Summary = value; },
			(data) => (data as DeletePostPage)?.Summary) {
				Prompt = "Summary",
				Description = "Short summary of the post to be used in lists of posts or to crosspost to other media"
				},
		new FrameRefForm<DeletePost> ("Form","DeletePost", [
		new FrameString ("FeedId",
			(data, value) => {(data as DeletePost)!.FeedId = value; },
			(data) => (data as DeletePost)?.FeedId) {
				Hidden = true
				},
		new FrameString ("PostId",
			(data, value) => {(data as DeletePost)!.PostId = value; },
			(data) => (data as DeletePost)?.PostId) {
				Hidden = true
				}
				]){
			Get = (data) => (data as DeletePostPage)?.Form ,
			Set = (data, value) => {(data as DeletePostPage)!.Form = value as DeletePost; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("PostTitle",
			(data, value) => {(data as DeletePostPage)!.PostTitle = value; },
			(data) => (data as DeletePostPage)?.PostTitle) {
				Prompt = "Title",
				Description = "Title, should be short."
				},
		new FrameText ("Summary",
			(data, value) => {(data as DeletePostPage)!.Summary = value; },
			(data) => (data as DeletePostPage)?.Summary) {
				Prompt = "Summary",
				Description = "Short summary of the post to be used in lists of posts or to crosspost to other media"
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<DeletePostPage> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"PostTitle", _properties[0]},
			{"Summary", _properties[1]}
			}, "DeletePostPage",
		() => new DeletePostPage(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for CreateComment
/// </summary>
public partial class CreateComment : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public CreateComment () : base ("CreateComment", "Create Comment", _Fields) {
		Container = "EntryPage";
		}

    /// <summary>Field Target</summary>
	public Comment? Target {get; set;}

    /// <summary>Field Form</summary>
	public Comment? Form {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRefClass<Comment> ("Target","Comment"){
			Get = (data) => (data as CreateComment)?.Target ,
			Set = (data, value) => {(data as CreateComment)!.Target = value as Comment; }},
		new FrameRefForm<Comment> ("Form","Comment", [
		new FrameString ("FeedId",
			(data, value) => {(data as Comment)!.FeedId = value; },
			(data) => (data as Comment)?.FeedId) {
				Hidden = true
				},
		new FrameString ("PostId",
			(data, value) => {(data as Comment)!.PostId = value; },
			(data) => (data as Comment)?.PostId) {
				Hidden = true
				},
		new FrameString ("CommentId",
			(data, value) => {(data as Comment)!.CommentId = value; },
			(data) => (data as Comment)?.CommentId) {
				Hidden = true
				},
		new FrameText ("Text",
			(data, value) => {(data as Comment)!.Text = value; },
			(data) => (data as Comment)?.Text) {
				Prompt = "Text"
				}
				]){
			Get = (data) => (data as CreateComment)?.Form ,
			Set = (data, value) => {(data as CreateComment)!.Form = value as Comment; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<CreateComment> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "CreateComment",
		() => new CreateComment(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for DeleteCommentPage
/// </summary>
public partial class DeleteCommentPage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public DeleteCommentPage () : base ("DeleteCommentPage", "Delete Comment", _Fields) {
		Container = "DeleteCommentPage";
		}

    /// <summary>Field Text</summary>
	public string? Text {get; set;}

    /// <summary>Field Form</summary>
	public DeleteComment? Form {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameText ("Text",
			(data, value) => {(data as DeleteCommentPage)!.Text = value; },
			(data) => (data as DeleteCommentPage)?.Text) {
				Prompt = "Text"
				},
		new FrameRefForm<DeleteComment> ("Form","DeleteComment", [
		new FrameString ("FeedId",
			(data, value) => {(data as DeleteComment)!.FeedId = value; },
			(data) => (data as DeleteComment)?.FeedId) {
				Hidden = true
				},
		new FrameString ("PostId",
			(data, value) => {(data as DeleteComment)!.PostId = value; },
			(data) => (data as DeleteComment)?.PostId) {
				Hidden = true
				},
		new FrameString ("CommentId",
			(data, value) => {(data as DeleteComment)!.CommentId = value; },
			(data) => (data as DeleteComment)?.CommentId) {
				Hidden = true
				}
				]){
			Get = (data) => (data as DeleteCommentPage)?.Form ,
			Set = (data, value) => {(data as DeleteCommentPage)!.Form = value as DeleteComment; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameText ("Text",
			(data, value) => {(data as DeleteCommentPage)!.Text = value; },
			(data) => (data as DeleteCommentPage)?.Text) {
				Prompt = "Text"
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<DeleteCommentPage> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Text", _properties[0]}
			}, "DeleteCommentPage",
		() => new DeleteCommentPage(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for NewPlacePage
/// </summary>
public partial class NewPlacePage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public NewPlacePage () : base ("NewPlacePage", "Create New Place", _Fields) {
		Container = "EntryPage";
		}

    /// <summary>Field Form</summary>
	public FormPlace? Form {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRefForm<FormPlace> ("Form","FormPlace", [
		new FrameString ("DNS",
			(data, value) => {(data as FormPlace)!.DNS = value; },
			(data) => (data as FormPlace)?.DNS) {
				Prompt = "DNS Address",
				Description = "Can be any DNS name that is resolved to the service."
				},
		new FrameString ("Title",
			(data, value) => {(data as FormPlace)!.Title = value; },
			(data) => (data as FormPlace)?.Title) {
				Prompt = "Name",
				Description = "The title the place will be known by."
				},
		new FrameText ("Description",
			(data, value) => {(data as FormPlace)!.Description = value; },
			(data) => (data as FormPlace)?.Description) {
				Prompt = "Description",
				Description = "Short description of the place."
				},
		new FrameFile ("AvatarFile"){
			FileType = "ImageFileType",
			Prompt = "Avatar",
			Description = "Icon representing the place.",
			Get = (data) => (data as FormPlace)?.AvatarFile ,
			Set = (data, value) => {(data as FormPlace)!.AvatarFile = value as BackingTypeFile; }},
		new FrameFile ("BannerFile"){
			FileType = "ImageFileType",
			Prompt = "Banner",
			Description = "Background image for the main page.",
			Get = (data) => (data as FormPlace)?.BannerFile ,
			Set = (data, value) => {(data as FormPlace)!.BannerFile = value as BackingTypeFile; }}
				]){
			Get = (data) => (data as NewPlacePage)?.Form ,
			Set = (data, value) => {(data as NewPlacePage)!.Form = value as FormPlace; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<NewPlacePage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "NewPlacePage",
		() => new NewPlacePage(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for DeletePlace
/// </summary>
public partial class DeletePlace : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public DeletePlace () : base ("DeletePlace", "Delete Place", _Fields) {
		Container = null;
		}


	static readonly List<IFrameField> _Fields = [
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<DeletePlace> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "DeletePlace",
		() => new DeletePlace(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for YourPlacePageCreate
/// </summary>
public partial class YourPlacePageCreate : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public YourPlacePageCreate () : base ("YourPlacePageCreate", "Create Your Personal Place", _Fields) {
		Container = "FlowPage";
		}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameDiv ("Explanation") { Fields = [

        		new FrameBlock ("P1") {Tag = "p", Text=[
        			"Coming soon"		    ]},
        		new FrameBlock ("P2") {Tag = "p", Text=[
        			"The goal of Places is to provide people with a place they can create",
        			"a personal feed posting longer articles than will fit into the 300 ",
        			"characters allowed in BlueSky Skeet."		    ]},
        		new FrameBlock ("P3") {Tag = "p", Text=[
        			"Since I am entirely self-funded, I won\'t be able to support an unlimited ",
        			"number of unlimited free accounts but I can support at least a million",
        			"free limited accounts with the current setup. Rather than take advertising,",
        			"I plan to adopt a freemium model to support build out of the platform if",
        			"that becomes necessary. Limited accounts should be available for free."		    ]},
        		new FrameBlock ("P4") {Tag = "p", Text=[
        			"Alternatively, if you have the necessary technical know how to set up",
        			"an Internet service, you can run your own places server. I will be making",
        			"How to tutorials in due course."		    ]}
				]
			}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<YourPlacePageCreate> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "YourPlacePageCreate",
		() => new YourPlacePageCreate(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for Help
/// </summary>
public partial class Help : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public Help () : base ("Help", "Help", _Fields) {
		Container = "Support";
		}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("SupportNav","SupportMenu"),
		new FrameDiv ("Explanation") { Fields = [

        		new FrameBlock ("P1") {Tag = "p", Text=[
        			"Should probably add some help information at some point."		    ]}
				]
			}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Help> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "Help",
		() => new Help(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for TermsOfService
/// </summary>
public partial class TermsOfService : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public TermsOfService () : base ("TermsOfService", "Terms of Service", _Fields) {
		Container = "Support";
		}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("SupportNav","SupportMenu"),
		new FrameDiv ("Explanation") { Fields = [

        		new FrameBlock ("P1") {Tag = "p", Text=[
        			"Places is an anti-censorhip platform but it is my anti-censorship platform",
        			"and content posted must be in accordance with the following rules."		    ]},
        		new FrameBlock ("P2") {Tag = "h1", Text=[
        			"Rule 0: Do not make us create any new rules."		    ]},
        		new FrameBlock ("P3") {Tag = "h1", Text=[
        			"Rule 1: No illegal content."		    ]},
        		new FrameBlock ("P4") {Tag = "p", Text=[
        			"If you post illegal content of any type and it is reported, I will forward ",
        			"it to the police without hesitation. "		    ]},
        		new FrameBlock ("P5") {Tag = "h1", Text=[
        			"Rule 2: No despicable content"		    ]},
        		new FrameBlock ("P6") {Tag = "p", Text=[
        			"I reserve the right to delete any material I find to be despicable including",
        			"material that is racist, homophobic, transphobic antisemitic or bigoted in",
        			"any way. I am proud to be woke and I am paying to support this platform."		    ]},
        		new FrameBlock ("P7") {Tag = "h1", Text=[
        			"Rule 3: No comment spam"		    ]},
        		new FrameBlock ("P8") {Tag = "p", Text=[
        			"You are entitled to your opinions, you are entitled to publish them. You are",
        			"not entitled to force anyone else to read them."		    ]},
        		new FrameBlock ("P7") {Tag = "h1", Text=[
        			"Rule 4: No bullying or harrassment"		    ]},
        		new FrameBlock ("P8") {Tag = "p", Text=[
        			"Other people are entitled to their opinions and to comment provided that they",
        			"don\'t breach the rules above. You are not entitled to suppress their views",
        			"with threatening or derrogatory language."		    ]},
        		new FrameBlock ("P7") {Tag = "h1", Text=[
        			"Rule 5: Copyright"		    ]},
        		new FrameBlock ("P8") {Tag = "p", Text=[
        			"You agree that you will only post/upload content which you are entitled",
        			"to publish here and that the site may publish it and make such uses of the",
        			"content as is usual for social media sites including testing."		    ]},
        		new FrameBlock ("P9") {Tag = "p", Text=[
        			"Site agrees that its use of the content published will be limited to those",
        			"uses normal for social media. But you acknowledge that the site has no control",
        			"over the use of any published material by third parties."		    ]},
        		new FrameBlock ("P7") {Tag = "h1", Text=[
        			"Rule 6: Indemnity"		    ]},
        		new FrameBlock ("P8") {Tag = "p", Text=[
        			"By using this site, you acknowledge that it is experimental and that no",
        			"warranty of fitness for any purpose is given or implied. Content may disappear",
        			"at any time, as may the entire service. "		    ]}
				]
			}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<TermsOfService> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "TermsOfService",
		() => new TermsOfService(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for PrivacyPolicy
/// </summary>
public partial class PrivacyPolicy : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public PrivacyPolicy () : base ("PrivacyPolicy", "Privacy Policy", _Fields) {
		Container = "Support";
		}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("SupportNav","SupportMenu"),
		new FrameDiv ("Explanation") { Fields = [

        		new FrameBlock ("P1") {Tag = "p", Text=[
        			"Places is built on the Mathematical Mesh, a cryptograpghic infrastructure",
        			"designed to protect privacy to the maximum extent possible using open",
        			"technology. It is however an experimental system and most of the protections",
        			"afforded by the platform are not yet supported in the production system."		    ]}
				]
			}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<PrivacyPolicy> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "PrivacyPolicy",
		() => new PrivacyPolicy(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for Contributors
/// </summary>
public partial class Contributors : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public Contributors () : base ("Contributors", "Contributors", _Fields) {
		Container = "Support";
		}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("SupportNav","SupportMenu"),
		new FrameDiv ("Explanation") { Fields = [

        		new FrameBlock ("P1") {Tag = "p", Text=[
        			"Places was designed and implemented by Phillip Hallam-Baker"		    ]},
        		new FrameBlock ("P2") {Tag = "p", Text=[
        			"The platform and support libraries were developed using Visual Studio Community and",
        			"DotNet 11.0. Domain Specific Languages implemented using the Goedel ",
        			"metasynthesis tool were used to convert specifications to code and",
        			"documentation. The principal target language is C# 14. The source code",
        			"is hosted on <a href=\"https://github.com/hallambaker/Palimpsest\">GitHub</a>."		    ]},
        		new FrameBlock ("P3") {Tag = "p", Text=[
        			"Icons from the free collection of <a href=\"https://fontawesome.com/\">Font Awesome</a>."		    ]}
				]
			}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Contributors> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "Contributors",
		() => new Contributors(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for Status
/// </summary>
public partial class Status : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public Status () : base ("Status", "System Status", _Fields) {
		Container = "Support";
		}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("SupportNav","SupportMenu"),
		new FrameDiv ("Explanation") { Fields = [

        		new FrameBlock ("P1") {Tag = "p", Text=[
        			"System status panel, TBS."		    ]}
				]
			}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Status> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "Status",
		() => new Status(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for SystemLog
/// </summary>
public partial class SystemLog : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public SystemLog () : base ("SystemLog", "System Log", _Fields) {
		Container = "Support";
		}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("SupportNav","SupportMenu"),
		new FrameDiv ("Explanation") { Fields = [

        		new FrameBlock ("P1") {Tag = "p", Text=[
        			"Record of major system changes TBS"		    ]}
				]
			}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<SystemLog> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "SystemLog",
		() => new SystemLog(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for Repository
/// </summary>
public partial class Repository : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public Repository () : base ("Repository", "Source Code Repository", _Fields) {
		Container = "Support";
		}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("SupportNav","SupportMenu"),
		new FrameDiv ("Explanation") { Fields = [

        		new FrameBlock ("P1") {Tag = "p", Text=[
        			"The source code for the Places server is hosted on ",
        			"<a href=\"https://github.com/hallambaker/Palimpsest\">GitHub Palimpsest</a>."		    ]},
        		new FrameBlock ("P2") {Tag = "p", Text=[
        			"The support libraries used by Places are part of the ",
        			"Mathematical Mesh hosted at <a href=\"https://github.com/hallambaker/Mathematical-Mesh\">GitHub Mathematical Mesh</a>."		    ]},
        		new FrameBlock ("P3") {Tag = "p", Text=[
        			"The domain specific languages used in Places and the Mesh are",
        			"hosted at <a href=\"https://github.com/hallambaker/Mathematical-Mesh\">GitHub Build Tools</a>."		    ]}
				]
			}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Repository> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "Repository",
		() => new Repository(), () => [], () => [], Parent: null, Generic: false);


	}

// Menus 
/// <summary>
/// Backing class for MainNav
/// </summary>
public partial class MainNav : FrameMenu {

	// Implement factory method returning a menu bound to a specific page.

    /// <inheritdoc/>
    public override Goedel.Sitebuilder.FramePage Page { 
            get => page ?? FrameSet.Page;
            init { page = value; } }
    Goedel.Sitebuilder.FramePage? page = null;

    /// <inheritdoc/>
    public override MainNav Create(Goedel.Sitebuilder.FramePage page) => new () {
        Page = page
        };

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public MainNav () : base ("MainNav", _Fields) {
		}

    /// <summary>Field NotificationCount</summary>
	public int? NotificationCount {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameInteger ("NotificationCount",
			(data, value) => {(data as MainNav)!.NotificationCount = value; },
			(data) => (data as MainNav)?.NotificationCount) {
				},
		new FrameButton ("Any", "Sign In", "SignIn") {
			GetActive = (data) => (data as MainNav)?.SignInActive,
			Description = "Sign in using your @nywhere account"
			},
		new FrameButton ("Avatar", "Account", "SwitchPage") {
			GetActive = (data) => (data as MainNav)?.SignOutActive,
			GetCustomized = (data, visibility) => (data as MainNav)?.GetUserAvatar(visibility),
			Description = "Sign out or switch account"
			},
		new FrameButton ("Home", "Home", "") {
			GetActive = (data) => (data as MainNav)?.HomePageActive
			},
		new FrameButton ("Places", "Places", "PlacesPage") {
			GetActive = (data) => (data as MainNav)?.PlacesActive
			},
		new FrameButton ("Feeds", "Feeds", "FeedsPage") {
			GetActive = (data) => (data as MainNav)?.FeedsActive
			},
		new FrameButton ("Posts", "Posts", "PostsPage") {
			GetActive = (data) => (data as MainNav)?.PostsActive
			},
		new FrameButton ("Place", "Your Place", "YourPlacePage") {
			GetActive = (data) => (data as MainNav)?.YourPlaceActive
			},
		new FrameButton ("CreateYour", "Your Place", "YourPlacePageCreate") {
			GetActive = (data) => (data as MainNav)?.CreateYourPlaceActive
			},
		new FrameButton ("Settings", "Settings", "SettingsPage") {
			GetActive = (data) => (data as MainNav)?.SettingsActive
			},
		new FrameButton ("NewPlace", "Create Place", "NewPlacePage") {
			GetActive = (data) => (data as MainNav)?.CreatePlaceActive
			},
		new FrameButton ("CreateFeed", "Create Feed", "CreateFeed") {
			GetActive = (data) => (data as MainNav)?.CreateFeedActive
			},
		new FrameButton ("CreatePost", "Create Post", "CreatePost") {
			GetActive = (data) => (data as MainNav)?.CreatePostActive
			}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameInteger ("NotificationCount",
			(data, value) => {(data as MainNav)!.NotificationCount = value; },
			(data) => (data as MainNav)?.NotificationCount) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<MainNav> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"NotificationCount", _properties[0]}
			}, "MainNav",
		() => new MainNav(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for TopSettings
/// </summary>
public partial class TopSettings : FrameMenu {

	// Implement factory method returning a menu bound to a specific page.

    /// <inheritdoc/>
    public override Goedel.Sitebuilder.FramePage Page { 
            get => page ?? FrameSet.Page;
            init { page = value; } }
    Goedel.Sitebuilder.FramePage? page = null;

    /// <inheritdoc/>
    public override TopSettings Create(Goedel.Sitebuilder.FramePage page) => new () {
        Page = page
        };

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public TopSettings () : base ("TopSettings", _Fields) {
		}


	static readonly List<IFrameField> _Fields = [
		new FrameButton ("Menu", "Menu", "SettingsPage") {
			},
		new FrameButton ("Settings", "Settings", "SettingsPage") {
			}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<TopSettings> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "TopSettings",
		() => new TopSettings(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for SettingsMenu
/// </summary>
public partial class SettingsMenu : FrameMenu {

	// Implement factory method returning a menu bound to a specific page.

    /// <inheritdoc/>
    public override Goedel.Sitebuilder.FramePage Page { 
            get => page ?? FrameSet.Page;
            init { page = value; } }
    Goedel.Sitebuilder.FramePage? page = null;

    /// <inheritdoc/>
    public override SettingsMenu Create(Goedel.Sitebuilder.FramePage page) => new () {
        Page = page
        };

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public SettingsMenu () : base ("SettingsMenu", _Fields) {
		}


	static readonly List<IFrameField> _Fields = [
		new FrameButton ("Account", "Account", "AccountSettings") {
			},
		new FrameButton ("Appearance", "Appearance", "AppearanceSettings") {
			},
		new FrameButton ("Help", "Help", "Help") {
			},
		new FrameButton ("About", "About", "AboutSettingsPage") {
			}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<SettingsMenu> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "SettingsMenu",
		() => new SettingsMenu(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for AboutSettings
/// </summary>
public partial class AboutSettings : FrameMenu {

	// Implement factory method returning a menu bound to a specific page.

    /// <inheritdoc/>
    public override Goedel.Sitebuilder.FramePage Page { 
            get => page ?? FrameSet.Page;
            init { page = value; } }
    Goedel.Sitebuilder.FramePage? page = null;

    /// <inheritdoc/>
    public override AboutSettings Create(Goedel.Sitebuilder.FramePage page) => new () {
        Page = page
        };

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public AboutSettings () : base ("AboutSettings", _Fields) {
		}


	static readonly List<IFrameField> _Fields = [
		new FrameButton ("TermsOfService", "Terms of Service", "TermsOfService") {
			},
		new FrameButton ("PrivacyPolicy", "Privacy Policy", "PrivacyPolicy") {
			},
		new FrameButton ("Contributors", "Contributors", "Contributors") {
			},
		new FrameButton ("Status", "Status Page", "Status") {
			},
		new FrameSeparator ("S1"),
		new FrameButton ("SystemLog", "System Log", "SystemLog") {
			}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<AboutSettings> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "AboutSettings",
		() => new AboutSettings(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for SupportMenu
/// </summary>
public partial class SupportMenu : FrameMenu {

	// Implement factory method returning a menu bound to a specific page.

    /// <inheritdoc/>
    public override Goedel.Sitebuilder.FramePage Page { 
            get => page ?? FrameSet.Page;
            init { page = value; } }
    Goedel.Sitebuilder.FramePage? page = null;

    /// <inheritdoc/>
    public override SupportMenu Create(Goedel.Sitebuilder.FramePage page) => new () {
        Page = page
        };

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public SupportMenu () : base ("SupportMenu", _Fields) {
		}


	static readonly List<IFrameField> _Fields = [
		new FrameButton ("Home", "Home", "") {
			},
		new FrameButton ("TermsOfService", "Terms of Service", "TermsOfService") {
			},
		new FrameButton ("Contributors", "Contributors", "Contributors") {
			},
		new FrameButton ("Repository", "Source", "Repository") {
			}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<SupportMenu> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "SupportMenu",
		() => new SupportMenu(), () => [], () => [], Parent: null, Generic: false);


	}

// Classes 



// Classes 
/// <summary>
/// Backing class for HandleInput
/// </summary>
public partial class HandleInput (string Id) : Handle (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public HandleInput() : this("HandleInput") { 
		}



    /// <summary>Field RememberAccount</summary>
	public bool? RememberAccount {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("DNS",
			(data, value) => {(data as Handle)!.DNS = value; },
			(data) => (data as Handle)?.DNS) {
				},
		new FrameBoolean ("RememberAccount",
			(data, value) => {(data as HandleInput)!.RememberAccount = value; },
			(data) => (data as HandleInput)?.RememberAccount) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameBoolean ("RememberAccount",
			(data, value) => {(data as HandleInput)!.RememberAccount = value; },
			(data) => (data as HandleInput)?.RememberAccount) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<HandleInput> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"RememberAccount", _properties[0]}
			}, "HandleInput",
		() => new HandleInput(), () => [], () => [], Parent: Handle._binding, Generic: false);


	}
/// <summary>
/// Backing class for SignOut
/// </summary>
public partial class SignOut (string Id) : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public SignOut() : this("SignOut") { 
		}




	static readonly List<IFrameField> _Fields = [
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<SignOut> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "SignOut",
		() => new SignOut(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for FormPlace
/// </summary>
public partial class FormPlace (string Id) : Place (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public FormPlace() : this("FormPlace") { 
		}



    /// <summary>Field AvatarFile</summary>
	public BackingTypeFile? AvatarFile {get; set;}

    /// <summary>Field BannerFile</summary>
	public BackingTypeFile? BannerFile {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("DNS",
			(data, value) => {(data as Place)!.DNS = value; },
			(data) => (data as Place)?.DNS) {
				Prompt = "DNS Address",
				Description = "Can be any DNS name that is resolved to the service."
				},
		new FrameString ("Title",
			(data, value) => {(data as Place)!.Title = value; },
			(data) => (data as Place)?.Title) {
				Prompt = "Name"
				},
		new FrameText ("Description",
			(data, value) => {(data as Place)!.Description = value; },
			(data) => (data as Place)?.Description) {
				Prompt = "Description"
				},
		new FrameAvatar ("Avatar"){
			Prompt = "Avatar Image",
			Get = (data) => (data as Place)?.Avatar },
		new FrameImage ("Banner",
			(data, value) => {(data as Place)!.Banner = value; },
			(data) => (data as Place)?.Banner) {
				Prompt = "Banner Image"
				},
		new FrameRefList<Rights> ("RightsTopics","Rights"){
			Get = (data) => (data as Place)?.RightsTopics ,
			Set = (data, value) => {(data as Place)!.RightsTopics = value as List<Rights>; }},
		new FrameRefList<Rights> ("RightsThreads","Rights"){
			Get = (data) => (data as Place)?.RightsThreads ,
			Set = (data, value) => {(data as Place)!.RightsThreads = value as List<Rights>; }},
		new FrameRefList<Rights> ("RightsComments","Rights"){
			Get = (data) => (data as Place)?.RightsComments ,
			Set = (data, value) => {(data as Place)!.RightsComments = value as List<Rights>; }},
		new FrameRef ("Topics"),
		PlaceReference,
		PlaceBanner,
		new FrameFile ("AvatarFile"){
			FileType = "ImageFileType",
			Prompt = "Avatar",
			Description = "Icon representing the place.",
			Get = (data) => (data as FormPlace)?.AvatarFile ,
			Set = (data, value) => {(data as FormPlace)!.AvatarFile = value as BackingTypeFile; }},
		new FrameFile ("BannerFile"){
			FileType = "ImageFileType",
			Prompt = "Banner",
			Description = "Background image for the main page.",
			Get = (data) => (data as FormPlace)?.BannerFile ,
			Set = (data, value) => {(data as FormPlace)!.BannerFile = value as BackingTypeFile; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameFile ("AvatarFile"){
			FileType = "ImageFileType",
			Prompt = "Avatar",
			Description = "Icon representing the place.",
			Get = (data) => (data as FormPlace)?.AvatarFile ,
			Set = (data, value) => {(data as FormPlace)!.AvatarFile = value as BackingTypeFile; }},
		new FrameFile ("BannerFile"){
			FileType = "ImageFileType",
			Prompt = "Banner",
			Description = "Background image for the main page.",
			Get = (data) => (data as FormPlace)?.BannerFile ,
			Set = (data, value) => {(data as FormPlace)!.BannerFile = value as BackingTypeFile; }}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<FormPlace> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"AvatarFile", _properties[0]},
			{"BannerFile", _properties[1]}
			}, "FormPlace",
		() => new FormPlace(), () => [], () => [], Parent: Place._binding, Generic: false);


	}
/// <summary>
/// Backing class for Handle
/// </summary>
public partial class Handle (string Id) : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public Handle() : this("Handle") { 
		}



    /// <summary>Field DNS</summary>
	public string? DNS {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("DNS",
			(data, value) => {(data as Handle)!.DNS = value; },
			(data) => (data as Handle)?.DNS) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("DNS",
			(data, value) => {(data as Handle)!.DNS = value; },
			(data) => (data as Handle)?.DNS) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Handle> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"DNS", _properties[0]}
			}, "Handle",
		() => new Handle(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for Provider
/// </summary>
public partial class Provider (string Id) : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public Provider() : this("Provider") { 
		}



    /// <summary>Field Signup</summary>
	public string? Signup {get; set;}

    /// <summary>Field Crosspost</summary>
	public string? Crosspost {get; set;}

    /// <summary>Field Title</summary>
	public string? Title {get; set;}

    /// <summary>Field Text</summary>
	public string? Text {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameText ("Signup",
			(data, value) => {(data as Provider)!.Signup = value; },
			(data) => (data as Provider)?.Signup) {
				},
		new FrameText ("Crosspost",
			(data, value) => {(data as Provider)!.Crosspost = value; },
			(data) => (data as Provider)?.Crosspost) {
				},
		new FrameString ("Title",
			(data, value) => {(data as Provider)!.Title = value; },
			(data) => (data as Provider)?.Title) {
				},
		new FrameString ("Text",
			(data, value) => {(data as Provider)!.Text = value; },
			(data) => (data as Provider)?.Text) {
				},
		new FrameIcon ("Logo")
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameText ("Signup",
			(data, value) => {(data as Provider)!.Signup = value; },
			(data) => (data as Provider)?.Signup) {
				},
		new FrameText ("Crosspost",
			(data, value) => {(data as Provider)!.Crosspost = value; },
			(data) => (data as Provider)?.Crosspost) {
				},
		new FrameString ("Title",
			(data, value) => {(data as Provider)!.Title = value; },
			(data) => (data as Provider)?.Title) {
				},
		new FrameString ("Text",
			(data, value) => {(data as Provider)!.Text = value; },
			(data) => (data as Provider)?.Text) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Provider> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Signup", _properties[0]},
			{"Crosspost", _properties[1]},
			{"Title", _properties[2]},
			{"Text", _properties[3]}
			}, "Provider",
		() => new Provider(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for User
/// </summary>
public partial class User (string Id) : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public User() : this("User") { 
		}

    /// <inheritdoc/>
    public override FramePresentation Presentation => MemberSummary;


    /// <summary>Field Uid</summary>
	public string? Uid {get; set;}

	///<summary>Avatar Avatar</summary>
	public string? Avatar {get; set;}

    /// <summary>Field DisplayName</summary>
	public string? DisplayName {get; set;}

    /// <summary>Field DisplayHandle</summary>
	public string? DisplayHandle {get; set;}

    /// <summary>Field Banned</summary>
	public bool? Banned {get; set;}

    /// <summary>Field Suspended</summary>
	public System.DateTime? Suspended {get; set;}

    /// <summary>Field Groups</summary>
	public List<Group>? Groups {get; set;}


	/// <summary>
	/// Presentation style MemberSummary
	/// </summary>
	public static FramePresentation MemberSummary => field ?? new FramePresentation ("MemberSummary") {
		GetUid = (data) => (data as User)?.Uid,
		Sections = [
			new FrameSection ("ImageArea") {
				Fields = [
            		new FrameAvatar ("Avatar"){
            			Prompt = null,
            			Get = (data) => (data as User)?.Avatar }
					]
				},
			new FrameSection ("NameArea") {
				Fields = [
            		new FrameString ("DisplayName",
            			(data, value) => {(data as User)!.DisplayName = value; },
            			(data) => (data as User)?.DisplayName) {
            				},
            		new FrameString ("DisplayHandle",
            			(data, value) => {(data as User)!.DisplayHandle = value; },
            			(data) => (data as User)?.DisplayHandle) {
            				}
					]
				}
			]
		}.CacheValue(out field)!;

	/// <summary>
	/// Presentation style MemberDetail
	/// </summary>
	public static FramePresentation MemberDetail => field ?? new FramePresentation ("MemberDetail") {
		GetUid = (data) => (data as User)?.Uid,
		Sections = [
			new FrameSection ("ImageArea") {
				Fields = [
            		new FrameAvatar ("Avatar"){
            			Prompt = null,
            			Get = (data) => (data as User)?.Avatar }
					]
				},
			new FrameSection ("NameArea") {
				Fields = [
            		new FrameString ("DisplayName",
            			(data, value) => {(data as User)!.DisplayName = value; },
            			(data) => (data as User)?.DisplayName) {
            				},
            		new FrameString ("DisplayHandle",
            			(data, value) => {(data as User)!.DisplayHandle = value; },
            			(data) => (data as User)?.DisplayHandle) {
            				}
					]
				},
			new FrameSection ("Moderation") {
				Fields = [
            		new FrameBoolean ("Banned",
            			(data, value) => {(data as User)!.Banned = value; },
            			(data) => (data as User)?.Banned) {
            				},
            		new FrameDateTime ("Suspended",
            			(data, value) => {(data as User)!.Suspended = value; },
            			(data) => (data as User)?.Suspended) {
            				}
					]
				}
			]
		}.CacheValue(out field)!;

	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(data, value) => {(data as User)!.Uid = value; },
			(data) => (data as User)?.Uid) {
				},
		new FrameAvatar ("Avatar"){
			Prompt = null,
			Get = (data) => (data as User)?.Avatar },
		new FrameString ("DisplayName",
			(data, value) => {(data as User)!.DisplayName = value; },
			(data) => (data as User)?.DisplayName) {
				},
		new FrameString ("DisplayHandle",
			(data, value) => {(data as User)!.DisplayHandle = value; },
			(data) => (data as User)?.DisplayHandle) {
				},
		new FrameBoolean ("Banned",
			(data, value) => {(data as User)!.Banned = value; },
			(data) => (data as User)?.Banned) {
				},
		new FrameDateTime ("Suspended",
			(data, value) => {(data as User)!.Suspended = value; },
			(data) => (data as User)?.Suspended) {
				},
		new FrameRefList<Group> ("Groups","Group"){
			Get = (data) => (data as User)?.Groups ,
			Set = (data, value) => {(data as User)!.Groups = value as List<Group>; }},
		MemberSummary,
		MemberDetail
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Uid",
			(data, value) => {(data as User)!.Uid = value; },
			(data) => (data as User)?.Uid) {
				},
		new FrameString ("DisplayName",
			(data, value) => {(data as User)!.DisplayName = value; },
			(data) => (data as User)?.DisplayName) {
				},
		new FrameString ("DisplayHandle",
			(data, value) => {(data as User)!.DisplayHandle = value; },
			(data) => (data as User)?.DisplayHandle) {
				},
		new FrameBoolean ("Banned",
			(data, value) => {(data as User)!.Banned = value; },
			(data) => (data as User)?.Banned) {
				},
		new FrameDateTime ("Suspended",
			(data, value) => {(data as User)!.Suspended = value; },
			(data) => (data as User)?.Suspended) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<User> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Uid", _properties[0]},
			{"DisplayName", _properties[1]},
			{"DisplayHandle", _properties[2]},
			{"Banned", _properties[3]},
			{"Suspended", _properties[4]}
			}, "User",
		() => new User(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for Group
/// </summary>
public partial class Group (string Id) : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public Group() : this("Group") { 
		}



    /// <summary>Field Uid</summary>
	public string? Uid {get; set;}

    /// <summary>Field Name</summary>
	public string? Name {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(data, value) => {(data as Group)!.Uid = value; },
			(data) => (data as Group)?.Uid) {
				},
		new FrameString ("Name",
			(data, value) => {(data as Group)!.Name = value; },
			(data) => (data as Group)?.Name) {
				},
		new FrameIcon ("Icon")
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Uid",
			(data, value) => {(data as Group)!.Uid = value; },
			(data) => (data as Group)?.Uid) {
				},
		new FrameString ("Name",
			(data, value) => {(data as Group)!.Name = value; },
			(data) => (data as Group)?.Name) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Group> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Uid", _properties[0]},
			{"Name", _properties[1]}
			}, "Group",
		() => new Group(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for Rights
/// </summary>
public partial class Rights (string Id) : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public Rights() : this("Rights") { 
		}



    /// <summary>Field GroupUid</summary>
	public string? GroupUid {get; set;}

    /// <summary>Field Grant</summary>
	public Privileges? Grant {get; set;}

    /// <summary>Field Deny</summary>
	public Privileges? Deny {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("GroupUid",
			(data, value) => {(data as Rights)!.GroupUid = value; },
			(data) => (data as Rights)?.GroupUid) {
				},
		new FrameRefClass<Privileges> ("Grant","Privileges"){
			Get = (data) => (data as Rights)?.Grant ,
			Set = (data, value) => {(data as Rights)!.Grant = value as Privileges; }},
		new FrameRefClass<Privileges> ("Deny","Privileges"){
			Get = (data) => (data as Rights)?.Deny ,
			Set = (data, value) => {(data as Rights)!.Deny = value as Privileges; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("GroupUid",
			(data, value) => {(data as Rights)!.GroupUid = value; },
			(data) => (data as Rights)?.GroupUid) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Rights> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"GroupUid", _properties[0]}
			}, "Rights",
		() => new Rights(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for Access
/// </summary>
public partial class Access (string Id) : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public Access() : this("Access") { 
		}



    /// <summary>Field Create</summary>
	public bool? Create {get; set;}

    /// <summary>Field Read</summary>
	public bool? Read {get; set;}

    /// <summary>Field Edit</summary>
	public bool? Edit {get; set;}

    /// <summary>Field Delete</summary>
	public bool? Delete {get; set;}

    /// <summary>Field Owner</summary>
	public bool? Owner {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameBoolean ("Create",
			(data, value) => {(data as Access)!.Create = value; },
			(data) => (data as Access)?.Create) {
				},
		new FrameBoolean ("Read",
			(data, value) => {(data as Access)!.Read = value; },
			(data) => (data as Access)?.Read) {
				},
		new FrameBoolean ("Edit",
			(data, value) => {(data as Access)!.Edit = value; },
			(data) => (data as Access)?.Edit) {
				},
		new FrameBoolean ("Delete",
			(data, value) => {(data as Access)!.Delete = value; },
			(data) => (data as Access)?.Delete) {
				},
		new FrameBoolean ("Owner",
			(data, value) => {(data as Access)!.Owner = value; },
			(data) => (data as Access)?.Owner) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameBoolean ("Create",
			(data, value) => {(data as Access)!.Create = value; },
			(data) => (data as Access)?.Create) {
				},
		new FrameBoolean ("Read",
			(data, value) => {(data as Access)!.Read = value; },
			(data) => (data as Access)?.Read) {
				},
		new FrameBoolean ("Edit",
			(data, value) => {(data as Access)!.Edit = value; },
			(data) => (data as Access)?.Edit) {
				},
		new FrameBoolean ("Delete",
			(data, value) => {(data as Access)!.Delete = value; },
			(data) => (data as Access)?.Delete) {
				},
		new FrameBoolean ("Owner",
			(data, value) => {(data as Access)!.Owner = value; },
			(data) => (data as Access)?.Owner) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Access> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Create", _properties[0]},
			{"Read", _properties[1]},
			{"Edit", _properties[2]},
			{"Delete", _properties[3]},
			{"Owner", _properties[4]}
			}, "Access",
		() => new Access(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for Privileges
/// </summary>
public partial class Privileges (string Id) : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public Privileges() : this("Privileges") { 
		}



    /// <summary>Field Places</summary>
	public Access? Places {get; set;}

    /// <summary>Field Topics</summary>
	public Access? Topics {get; set;}

    /// <summary>Field Threads</summary>
	public Access? Threads {get; set;}

    /// <summary>Field Others</summary>
	public Access? Others {get; set;}

    /// <summary>Field Self</summary>
	public Access? Self {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefClass<Access> ("Places","Access"){
			Get = (data) => (data as Privileges)?.Places ,
			Set = (data, value) => {(data as Privileges)!.Places = value as Access; }},
		new FrameRefClass<Access> ("Topics","Access"){
			Get = (data) => (data as Privileges)?.Topics ,
			Set = (data, value) => {(data as Privileges)!.Topics = value as Access; }},
		new FrameRefClass<Access> ("Threads","Access"){
			Get = (data) => (data as Privileges)?.Threads ,
			Set = (data, value) => {(data as Privileges)!.Threads = value as Access; }},
		new FrameRefClass<Access> ("Others","Access"){
			Get = (data) => (data as Privileges)?.Others ,
			Set = (data, value) => {(data as Privileges)!.Others = value as Access; }},
		new FrameRefClass<Access> ("Self","Access"){
			Get = (data) => (data as Privileges)?.Self ,
			Set = (data, value) => {(data as Privileges)!.Self = value as Access; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Privileges> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "Privileges",
		() => new Privileges(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for Entry
/// </summary>
public partial class Entry (string Id) : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public Entry() : this("Entry") { 
		}

    /// <inheritdoc/>
    public override FramePresentation Presentation => Brief;


    /// <summary>Field Uid</summary>
	public string? Uid {get; set;}

    /// <summary>Field Semantic</summary>
	public string? Semantic {get; set;}

    /// <summary>Field Rights</summary>
	public List<Rights>? Rights {get; set;}

    /// <summary>Field Created</summary>
	public System.DateTime? Created {get; set;}


	/// <summary>
	/// Presentation style Brief
	/// </summary>
	public static FramePresentation Brief => field ?? new FramePresentation ("Brief") {
		GetUid = (data) => (data as Entry)?.Uid,
		Sections = [
			new FrameSection ("Title") {
				Fields = [
            		new FrameDateTime ("Created",
            			(data, value) => {(data as Entry)!.Created = value; },
            			(data) => (data as Entry)?.Created) {
            				}
					]
				},
			new FrameSection ("Body") {
				Fields = [
            		new FrameText ("Text",
            			(data, value) => {(data as Entry)!.Text = value; },
            			(data) => (data as Entry)?.Text) {
            				}
					]
				}
			]
		}.CacheValue(out field)!;

	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(data, value) => {(data as Entry)!.Uid = value; },
			(data) => (data as Entry)?.Uid) {
				Hidden = true
				},
		new FrameString ("Semantic",
			(data, value) => {(data as Entry)!.Semantic = value; },
			(data) => (data as Entry)?.Semantic) {
				Hidden = true
				},
		new FrameRefList<Rights> ("Rights","Rights"){
			Get = (data) => (data as Entry)?.Rights ,
			Set = (data, value) => {(data as Entry)!.Rights = value as List<Rights>; }},
		new FrameDateTime ("Created",
			(data, value) => {(data as Entry)!.Created = value; },
			(data) => (data as Entry)?.Created) {
				},
		Brief
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Uid",
			(data, value) => {(data as Entry)!.Uid = value; },
			(data) => (data as Entry)?.Uid) {
				Hidden = true
				},
		new FrameString ("Semantic",
			(data, value) => {(data as Entry)!.Semantic = value; },
			(data) => (data as Entry)?.Semantic) {
				Hidden = true
				},
		new FrameDateTime ("Created",
			(data, value) => {(data as Entry)!.Created = value; },
			(data) => (data as Entry)?.Created) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Entry> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Uid", _properties[0]},
			{"Semantic", _properties[1]},
			{"Created", _properties[2]}
			}, "Entry",
		() => new Entry(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for Place
/// </summary>
public partial class Place (string Id) : Entry (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public Place() : this("Place") { 
		}

    /// <inheritdoc/>
    public override FramePresentation Presentation => PlaceReference;


    /// <summary>Field DNS</summary>
	public string? DNS {get; set;}

    /// <summary>Field Title</summary>
	public string? Title {get; set;}

    /// <summary>Field Description</summary>
	public string? Description {get; set;}

	///<summary>Avatar Avatar</summary>
	public string? Avatar {get; set;}

    /// <summary>Field Banner</summary>
	public string? Banner {get; set;}

    /// <summary>Field RightsTopics</summary>
	public List<Rights>? RightsTopics {get; set;}

    /// <summary>Field RightsThreads</summary>
	public List<Rights>? RightsThreads {get; set;}

    /// <summary>Field RightsComments</summary>
	public List<Rights>? RightsComments {get; set;}


	/// <summary>
	/// Presentation style PlaceReference
	/// </summary>
	public static FramePresentation PlaceReference => field ?? new FramePresentation ("PlaceReference") {
		GetUid = (data) => (data as Place)?.Uid,
		Sections = [
			new FrameSection ("Title") {
				Fields = [
            		new FrameString ("Title",
            			(data, value) => {(data as Place)!.Title = value; },
            			(data) => (data as Place)?.Title) {
            				},
            		new FrameString ("DNS",
            			(data, value) => {(data as Place)!.DNS = value; },
            			(data) => (data as Place)?.DNS) {
            				}
					]
				},
			new FrameSection ("Avatar") {
				Fields = [
            		new FrameAvatar ("Avatar"){
            			Prompt = null,
            			Get = (data) => (data as Place)?.Avatar }
					]
				},
			new FrameSection ("Banner") {
				Fields = [
            		new FrameImage ("Banner",
            			(data, value) => {(data as Place)!.Banner = value; },
            			(data) => (data as Place)?.Banner) {
            				}
					]
				},
			new FrameSection ("Body") {
				Fields = [
            		new FrameText ("Description",
            			(data, value) => {(data as Place)!.Description = value; },
            			(data) => (data as Place)?.Description) {
            				}
					]
				}
			]
		}.CacheValue(out field)!;

	/// <summary>
	/// Presentation style PlaceBanner
	/// </summary>
	public static FramePresentation PlaceBanner => field ?? new FramePresentation ("PlaceBanner") {
		GetUid = (data) => (data as Place)?.Uid,
		Sections = [
			new FrameSection ("Title") {
				GetAnchor = (data) => (data as Place)?.TitleLink,
				Fields = [
					]
				},
			new FrameSection ("Avatar") {
				Fields = [
            		new FrameAvatar ("Avatar"){
            			Prompt = null,
            			Get = (data) => (data as Place)?.Avatar }
					]
				},
			new FrameSection ("Banner") {
				Fields = [
            		new FrameImage ("Banner",
            			(data, value) => {(data as Place)!.Banner = value; },
            			(data) => (data as Place)?.Banner) {
            				}
					]
				},
			new FrameSection ("Body") {
				Fields = [
            		new FrameText ("Description",
            			(data, value) => {(data as Place)!.Description = value; },
            			(data) => (data as Place)?.Description) {
            				}
					]
				}
			]
		}.CacheValue(out field)!;

	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(data, value) => {(data as Entry)!.Uid = value; },
			(data) => (data as Entry)?.Uid) {
				Hidden = true
				},
		new FrameString ("Semantic",
			(data, value) => {(data as Entry)!.Semantic = value; },
			(data) => (data as Entry)?.Semantic) {
				Hidden = true
				},
		new FrameRefList<Rights> ("Rights","Rights"){
			Get = (data) => (data as Entry)?.Rights ,
			Set = (data, value) => {(data as Entry)!.Rights = value as List<Rights>; }},
		new FrameDateTime ("Created",
			(data, value) => {(data as Entry)!.Created = value; },
			(data) => (data as Entry)?.Created) {
				},
		Brief,
		new FrameString ("DNS",
			(data, value) => {(data as Place)!.DNS = value; },
			(data) => (data as Place)?.DNS) {
				Prompt = "DNS Address",
				Description = "Can be any DNS name that is resolved to the service."
				},
		new FrameString ("Title",
			(data, value) => {(data as Place)!.Title = value; },
			(data) => (data as Place)?.Title) {
				Prompt = "Name"
				},
		new FrameText ("Description",
			(data, value) => {(data as Place)!.Description = value; },
			(data) => (data as Place)?.Description) {
				Prompt = "Description"
				},
		new FrameAvatar ("Avatar"){
			Prompt = "Avatar Image",
			Get = (data) => (data as Place)?.Avatar },
		new FrameImage ("Banner",
			(data, value) => {(data as Place)!.Banner = value; },
			(data) => (data as Place)?.Banner) {
				Prompt = "Banner Image"
				},
		new FrameRefList<Rights> ("RightsTopics","Rights"){
			Get = (data) => (data as Place)?.RightsTopics ,
			Set = (data, value) => {(data as Place)!.RightsTopics = value as List<Rights>; }},
		new FrameRefList<Rights> ("RightsThreads","Rights"){
			Get = (data) => (data as Place)?.RightsThreads ,
			Set = (data, value) => {(data as Place)!.RightsThreads = value as List<Rights>; }},
		new FrameRefList<Rights> ("RightsComments","Rights"){
			Get = (data) => (data as Place)?.RightsComments ,
			Set = (data, value) => {(data as Place)!.RightsComments = value as List<Rights>; }},
		new FrameRef ("Topics"),
		PlaceReference,
		PlaceBanner
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("DNS",
			(data, value) => {(data as Place)!.DNS = value; },
			(data) => (data as Place)?.DNS) {
				Prompt = "DNS Address",
				Description = "Can be any DNS name that is resolved to the service."
				},
		new FrameString ("Title",
			(data, value) => {(data as Place)!.Title = value; },
			(data) => (data as Place)?.Title) {
				Prompt = "Name"
				},
		new FrameText ("Description",
			(data, value) => {(data as Place)!.Description = value; },
			(data) => (data as Place)?.Description) {
				Prompt = "Description"
				},
		new FrameImage ("Banner",
			(data, value) => {(data as Place)!.Banner = value; },
			(data) => (data as Place)?.Banner) {
				Prompt = "Banner Image"
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Place> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"DNS", _properties[0]},
			{"Title", _properties[1]},
			{"Description", _properties[2]},
			{"Banner", _properties[3]}
			}, "Place",
		() => new Place(), () => [], () => [], Parent: Entry._binding, Generic: false);


	}
/// <summary>
/// Backing class for DeleteFeed
/// </summary>
public partial class DeleteFeed (string Id) : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public DeleteFeed() : this("DeleteFeed") { 
		}



    /// <summary>Field FeedId</summary>
	public string? FeedId {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("FeedId",
			(data, value) => {(data as DeleteFeed)!.FeedId = value; },
			(data) => (data as DeleteFeed)?.FeedId) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("FeedId",
			(data, value) => {(data as DeleteFeed)!.FeedId = value; },
			(data) => (data as DeleteFeed)?.FeedId) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<DeleteFeed> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"FeedId", _properties[0]}
			}, "DeleteFeed",
		() => new DeleteFeed(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for Feed
/// </summary>
public partial class Feed (string Id) : Entry (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public Feed() : this("Feed") { 
		}



    /// <summary>Field Title</summary>
	public string? Title {get; set;}

    /// <summary>Field Description</summary>
	public string? Description {get; set;}

	///<summary>Avatar Avatar</summary>
	public string? Avatar {get; set;}

    /// <summary>Field Banner</summary>
	public string? Banner {get; set;}

    /// <summary>Field AllowPosts</summary>
	public bool? AllowPosts {get; set;}

    /// <summary>Field AllowImages</summary>
	public bool? AllowImages {get; set;}

    /// <summary>Field AllowShort</summary>
	public bool? AllowShort {get; set;}

    /// <summary>Field AllowVideo</summary>
	public bool? AllowVideo {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(data, value) => {(data as Entry)!.Uid = value; },
			(data) => (data as Entry)?.Uid) {
				Hidden = true
				},
		new FrameString ("Semantic",
			(data, value) => {(data as Entry)!.Semantic = value; },
			(data) => (data as Entry)?.Semantic) {
				Hidden = true
				},
		new FrameRefList<Rights> ("Rights","Rights"){
			Get = (data) => (data as Entry)?.Rights ,
			Set = (data, value) => {(data as Entry)!.Rights = value as List<Rights>; }},
		new FrameDateTime ("Created",
			(data, value) => {(data as Entry)!.Created = value; },
			(data) => (data as Entry)?.Created) {
				},
		Brief,
		new FrameString ("Title",
			(data, value) => {(data as Feed)!.Title = value; },
			(data) => (data as Feed)?.Title) {
				Prompt = "Name"
				},
		new FrameText ("Description",
			(data, value) => {(data as Feed)!.Description = value; },
			(data) => (data as Feed)?.Description) {
				Prompt = "Description"
				},
		new FrameAvatar ("Avatar"){
			Prompt = "Avatar Image",
			Get = (data) => (data as Feed)?.Avatar },
		new FrameImage ("Banner",
			(data, value) => {(data as Feed)!.Banner = value; },
			(data) => (data as Feed)?.Banner) {
				Prompt = "Banner Image"
				},
		new FrameBoolean ("AllowPosts",
			(data, value) => {(data as Feed)!.AllowPosts = value; },
			(data) => (data as Feed)?.AllowPosts) {
				Prompt = "Allow text posts",
				Description = "Allow text posts in the feed."
				},
		new FrameBoolean ("AllowImages",
			(data, value) => {(data as Feed)!.AllowImages = value; },
			(data) => (data as Feed)?.AllowImages) {
				Prompt = "Allow images",
				Description = "Allow images in the feed."
				},
		new FrameBoolean ("AllowShort",
			(data, value) => {(data as Feed)!.AllowShort = value; },
			(data) => (data as Feed)?.AllowShort) {
				Prompt = "Allow short videos",
				Description = "Allow short videos in the feed."
				},
		new FrameBoolean ("AllowVideo",
			(data, value) => {(data as Feed)!.AllowVideo = value; },
			(data) => (data as Feed)?.AllowVideo) {
				Prompt = "Allow video",
				Description = "Allow longer videos in the feed."
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Title",
			(data, value) => {(data as Feed)!.Title = value; },
			(data) => (data as Feed)?.Title) {
				Prompt = "Name"
				},
		new FrameText ("Description",
			(data, value) => {(data as Feed)!.Description = value; },
			(data) => (data as Feed)?.Description) {
				Prompt = "Description"
				},
		new FrameImage ("Banner",
			(data, value) => {(data as Feed)!.Banner = value; },
			(data) => (data as Feed)?.Banner) {
				Prompt = "Banner Image"
				},
		new FrameBoolean ("AllowPosts",
			(data, value) => {(data as Feed)!.AllowPosts = value; },
			(data) => (data as Feed)?.AllowPosts) {
				Prompt = "Allow text posts",
				Description = "Allow text posts in the feed."
				},
		new FrameBoolean ("AllowImages",
			(data, value) => {(data as Feed)!.AllowImages = value; },
			(data) => (data as Feed)?.AllowImages) {
				Prompt = "Allow images",
				Description = "Allow images in the feed."
				},
		new FrameBoolean ("AllowShort",
			(data, value) => {(data as Feed)!.AllowShort = value; },
			(data) => (data as Feed)?.AllowShort) {
				Prompt = "Allow short videos",
				Description = "Allow short videos in the feed."
				},
		new FrameBoolean ("AllowVideo",
			(data, value) => {(data as Feed)!.AllowVideo = value; },
			(data) => (data as Feed)?.AllowVideo) {
				Prompt = "Allow video",
				Description = "Allow longer videos in the feed."
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Feed> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Title", _properties[0]},
			{"Description", _properties[1]},
			{"Banner", _properties[2]},
			{"AllowPosts", _properties[3]},
			{"AllowImages", _properties[4]},
			{"AllowShort", _properties[5]},
			{"AllowVideo", _properties[6]}
			}, "Feed",
		() => new Feed(), () => [], () => [], Parent: Entry._binding, Generic: false);


	}
/// <summary>
/// Backing class for DeletePost
/// </summary>
public partial class DeletePost (string Id) : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public DeletePost() : this("DeletePost") { 
		}



    /// <summary>Field FeedId</summary>
	public string? FeedId {get; set;}

    /// <summary>Field PostId</summary>
	public string? PostId {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("FeedId",
			(data, value) => {(data as DeletePost)!.FeedId = value; },
			(data) => (data as DeletePost)?.FeedId) {
				},
		new FrameString ("PostId",
			(data, value) => {(data as DeletePost)!.PostId = value; },
			(data) => (data as DeletePost)?.PostId) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("FeedId",
			(data, value) => {(data as DeletePost)!.FeedId = value; },
			(data) => (data as DeletePost)?.FeedId) {
				},
		new FrameString ("PostId",
			(data, value) => {(data as DeletePost)!.PostId = value; },
			(data) => (data as DeletePost)?.PostId) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<DeletePost> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"FeedId", _properties[0]},
			{"PostId", _properties[1]}
			}, "DeletePost",
		() => new DeletePost(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for Post
/// </summary>
public partial class Post (string Id) : Entry (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public Post() : this("Post") { 
		}

    /// <inheritdoc/>
    public override FramePresentation Presentation => PostSummary;


    /// <summary>Field FeedId</summary>
	public string? FeedId {get; set;}

    /// <summary>Field User</summary>
	public User? User {get; set;}

    /// <summary>Field PostTitle</summary>
	public string? PostTitle {get; set;}

    /// <summary>Field Summary</summary>
	public string? Summary {get; set;}

    /// <summary>Field Body</summary>
	public string? Body {get; set;}

    /// <summary>Field Resources</summary>
	public List<Resource>? Resources {get; set;}

    /// <summary>Field Replies</summary>
	public string? Replies {get; set;}

    /// <summary>Field Comments</summary>
	public int? Comments {get; set;}

    /// <summary>Field Likes</summary>
	public int? Likes {get; set;}


	/// <summary>
	/// Presentation style PostSummary
	/// </summary>
	public static FramePresentation PostSummary => field ?? new FramePresentation ("PostSummary") {
		GetUid = (data) => (data as Post)?.Uid,
		Sections = [
			new FrameSection ("Avatar") {
				GetAnchor = (data) => (data as Post)?.AuthorLink,
				Fields = [
            		new FrameAvatar ("User.Avatar"){
            			Prompt = null,
            			Get = (data) => (data as Post)?.User?.Avatar }
					]
				},
			new FrameSection ("Author") {
				GetAnchor = (data) => (data as Post)?.AuthorLink,
				Fields = [
            		new FrameString ("User.DisplayName",
            			(data, value) => {(data as Post)!.User!.DisplayName = value; },
            			(data) => (data as Post)?.User?.DisplayName) {
            				},
            		new FrameString ("User.DisplayHandle",
            			(data, value) => {(data as Post)!.User!.DisplayHandle = value; },
            			(data) => (data as Post)?.User?.DisplayHandle) {
            				},
            		new FrameDateTime ("Created",
            			(data, value) => {(data as Post)!.Created = value; },
            			(data) => (data as Post)?.Created) {
            				}
					]
				},
			new FrameSection ("Rule") {
				Fields = [
					]
				},
			new FrameSection ("Body") {
				GetAnchor = (data) => (data as Post)?.PostLink,
				Fields = [
            		new FrameString ("PostTitle",
            			(data, value) => {(data as Post)!.PostTitle = value; },
            			(data) => (data as Post)?.PostTitle) {
            				},
            		new FrameText ("Summary",
            			(data, value) => {(data as Post)!.Summary = value; },
            			(data) => (data as Post)?.Summary) {
            				}
					]
				}
			]
		}.CacheValue(out field)!;

	/// <summary>
	/// Presentation style PostFull
	/// </summary>
	public static FramePresentation PostFull => field ?? new FramePresentation ("PostFull") {
		GetUid = (data) => (data as Post)?.Uid,
		Sections = [
			new FrameSection ("Avatar") {
				GetAnchor = (data) => (data as Post)?.AuthorLink,
				Fields = [
            		new FrameAvatar ("User.Avatar"){
            			Prompt = null,
            			Get = (data) => (data as Post)?.User?.Avatar }
					]
				},
			new FrameSection ("Author") {
				GetAnchor = (data) => (data as Post)?.AuthorLink,
				Fields = [
            		new FrameString ("User.DisplayName",
            			(data, value) => {(data as Post)!.User!.DisplayName = value; },
            			(data) => (data as Post)?.User?.DisplayName) {
            				},
            		new FrameString ("User.DisplayHandle",
            			(data, value) => {(data as Post)!.User!.DisplayHandle = value; },
            			(data) => (data as Post)?.User?.DisplayHandle) {
            				},
            		new FrameDateTime ("Created",
            			(data, value) => {(data as Post)!.Created = value; },
            			(data) => (data as Post)?.Created) {
            				}
					]
				},
			new FrameSection ("Rule") {
				Fields = [
					]
				},
			new FrameSection ("Summary") {
				Fields = [
            		new FrameString ("PostTitle",
            			(data, value) => {(data as Post)!.PostTitle = value; },
            			(data) => (data as Post)?.PostTitle) {
            				},
            		new FrameText ("Summary",
            			(data, value) => {(data as Post)!.Summary = value; },
            			(data) => (data as Post)?.Summary) {
            				}
					]
				},
			new FrameSection ("Body") {
				Fields = [
            		new FrameRichText ("Body",
            			(data, value) => {(data as Post)!.Body = value; },
            			(data) => (data as Post)?.Body) {
            				}
					]
				},
			new FrameSection ("Detail") {
				Fields = [
            		new FrameDateTime ("Created",
            			(data, value) => {(data as Post)!.Created = value; },
            			(data) => (data as Post)?.Created) {
            				},
            		new FrameString ("Replies",
            			(data, value) => {(data as Post)!.Replies = value; },
            			(data) => (data as Post)?.Replies) {
            				}
					]
				},
			new FrameSection ("Responses") {
				Fields = [
            		new FrameButton ("Comment", "Comment", "CreateComment") {
            			GetActive = (data) => (data as Post)?.PermissionRespond,
            			GetAnchor = (data) => (data as Post)?.PostPath,
            			GetInteger = (data) => (data as Post)?.Comments
            			},
            		new FrameButton ("Delete", "Delete", "DeletePostPage") {
            			GetActive = (data) => (data as Post)?.PermissionDelete,
            			GetAnchor = (data) => (data as Post)?.PostPath
            			}
					]
				}
			]
		}.CacheValue(out field)!;

	/// <summary>
	/// Presentation style PostFullSaved
	/// </summary>
	public static FramePresentation PostFullSaved => field ?? new FramePresentation ("PostFullSaved") {
		GetUid = (data) => (data as Post)?.Uid,
		Sections = [
			new FrameSection ("Avatar") {
				Fields = [
            		new FrameAvatar ("User.Avatar"){
            			Prompt = null,
            			Get = (data) => (data as Post)?.User?.Avatar }
					]
				},
			new FrameSection ("Author") {
				Fields = [
            		new FrameString ("User.DisplayName",
            			(data, value) => {(data as Post)!.User!.DisplayName = value; },
            			(data) => (data as Post)?.User?.DisplayName) {
            				},
            		new FrameString ("User.DisplayHandle",
            			(data, value) => {(data as Post)!.User!.DisplayHandle = value; },
            			(data) => (data as Post)?.User?.DisplayHandle) {
            				},
            		new FrameDateTime ("Created",
            			(data, value) => {(data as Post)!.Created = value; },
            			(data) => (data as Post)?.Created) {
            				}
					]
				},
			new FrameSection ("Rule") {
				Fields = [
					]
				},
			new FrameSection ("Summary") {
				Fields = [
            		new FrameString ("PostTitle",
            			(data, value) => {(data as Post)!.PostTitle = value; },
            			(data) => (data as Post)?.PostTitle) {
            				},
            		new FrameText ("Summary",
            			(data, value) => {(data as Post)!.Summary = value; },
            			(data) => (data as Post)?.Summary) {
            				}
					]
				},
			new FrameSection ("Body") {
				Fields = [
            		new FrameRichText ("Body",
            			(data, value) => {(data as Post)!.Body = value; },
            			(data) => (data as Post)?.Body) {
            				}
					]
				},
			new FrameSection ("Detail") {
				Fields = [
            		new FrameDateTime ("Created",
            			(data, value) => {(data as Post)!.Created = value; },
            			(data) => (data as Post)?.Created) {
            				},
            		new FrameString ("Replies",
            			(data, value) => {(data as Post)!.Replies = value; },
            			(data) => (data as Post)?.Replies) {
            				}
					]
				},
			new FrameSection ("Responses") {
				Fields = [
            		new FrameButton ("Comment", "Comment", "CreateComment") {
            			GetAnchor = (data) => (data as Post)?.PostPath,
            			GetInteger = (data) => (data as Post)?.Comments
            			},
            		new FrameSubmenu ("Repost", "Repost") {
            			Fields = [
                    		new FrameButton ("Repost", "Repost", "RepostAction") {
                    			},
                    		new FrameButton ("QuotePost", "Quote Post", "QuotePostAction") {
                    			}
            				]
            			},
            		new FrameSubmenu ("Share", "Share") {
            			Fields = [
                    		new FrameButton ("LinkCopy", "Copy link to post", "HomePage") {
                    			},
                    		new FrameButton ("Embed", "Embed post", "HomePage") {
                    			}
            				]
            			},
            		new FrameSubmenu ("Ellipsis", "More") {
            			Fields = [
                    		new FrameButton ("Translate", "Translate", "TranslateAction") {
                    			},
                    		new FrameButton ("CopyToClipboard", "Copy post text", "CopyPostAction") {
                    			},
                    		new FrameSeparator ("S1"),
                    		new FrameButton ("MuteThread", "Mute thread", "MuteThreadAction") {
                    			},
                    		new FrameButton ("MuteWords", "Mute words & tags", "MuteWordsAction") {
                    			},
                    		new FrameSeparator ("S2"),
                    		new FrameButton ("HidePost", "Hide post for me", "HidePostAction") {
                    			},
                    		new FrameSeparator ("S3"),
                    		new FrameButton ("MuteAccount", "Mute user", "MuteAccountAction") {
                    			ButtonAction = ButtonAction.Method
                    			},
                    		new FrameButton ("BlockAccount", "Block user", "BlockAccountAction") {
                    			ButtonAction = ButtonAction.Method
                    			},
                    		new FrameButton ("Report", "Report post", "ReportPostAction") {
                    			}
            				]
            			}
					]
				}
			]
		}.CacheValue(out field)!;

	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(data, value) => {(data as Entry)!.Uid = value; },
			(data) => (data as Entry)?.Uid) {
				Hidden = true
				},
		new FrameString ("Semantic",
			(data, value) => {(data as Entry)!.Semantic = value; },
			(data) => (data as Entry)?.Semantic) {
				Hidden = true
				},
		new FrameRefList<Rights> ("Rights","Rights"){
			Get = (data) => (data as Entry)?.Rights ,
			Set = (data, value) => {(data as Entry)!.Rights = value as List<Rights>; }},
		new FrameDateTime ("Created",
			(data, value) => {(data as Entry)!.Created = value; },
			(data) => (data as Entry)?.Created) {
				},
		Brief,
		new FrameString ("FeedId",
			(data, value) => {(data as Post)!.FeedId = value; },
			(data) => (data as Post)?.FeedId) {
				Hidden = true
				},
		new FrameRefClass<User> ("User","User"){
			Get = (data) => (data as Post)?.User ,
			Set = (data, value) => {(data as Post)!.User = value as User; }},
		new FrameString ("PostTitle",
			(data, value) => {(data as Post)!.PostTitle = value; },
			(data) => (data as Post)?.PostTitle) {
				Prompt = "Title"
				},
		new FrameText ("Summary",
			(data, value) => {(data as Post)!.Summary = value; },
			(data) => (data as Post)?.Summary) {
				Prompt = "Summary"
				},
		new FrameRichText ("Body",
			(data, value) => {(data as Post)!.Body = value; },
			(data) => (data as Post)?.Body) {
				Prompt = "Body"
				},
		new FrameRefList<Resource> ("Resources","Resource"){
			Get = (data) => (data as Post)?.Resources ,
			Set = (data, value) => {(data as Post)!.Resources = value as List<Resource>; }},
		new FrameString ("Replies",
			(data, value) => {(data as Post)!.Replies = value; },
			(data) => (data as Post)?.Replies) {
				},
		new FrameInteger ("Comments",
			(data, value) => {(data as Post)!.Comments = value; },
			(data) => (data as Post)?.Comments) {
				},
		new FrameInteger ("Likes",
			(data, value) => {(data as Post)!.Likes = value; },
			(data) => (data as Post)?.Likes) {
				},
		PostSummary,
		PostFull,
		PostFullSaved
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("FeedId",
			(data, value) => {(data as Post)!.FeedId = value; },
			(data) => (data as Post)?.FeedId) {
				Hidden = true
				},
		new FrameString ("PostTitle",
			(data, value) => {(data as Post)!.PostTitle = value; },
			(data) => (data as Post)?.PostTitle) {
				Prompt = "Title"
				},
		new FrameText ("Summary",
			(data, value) => {(data as Post)!.Summary = value; },
			(data) => (data as Post)?.Summary) {
				Prompt = "Summary"
				},
		new FrameRichText ("Body",
			(data, value) => {(data as Post)!.Body = value; },
			(data) => (data as Post)?.Body) {
				Prompt = "Body"
				},
		new FrameString ("Replies",
			(data, value) => {(data as Post)!.Replies = value; },
			(data) => (data as Post)?.Replies) {
				},
		new FrameInteger ("Comments",
			(data, value) => {(data as Post)!.Comments = value; },
			(data) => (data as Post)?.Comments) {
				},
		new FrameInteger ("Likes",
			(data, value) => {(data as Post)!.Likes = value; },
			(data) => (data as Post)?.Likes) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Post> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"FeedId", _properties[0]},
			{"PostTitle", _properties[1]},
			{"Summary", _properties[2]},
			{"Body", _properties[3]},
			{"Replies", _properties[4]},
			{"Comments", _properties[5]},
			{"Likes", _properties[6]}
			}, "Post",
		() => new Post(), () => [], () => [], Parent: Entry._binding, Generic: false);


	}
/// <summary>
/// Backing class for DeleteComment
/// </summary>
public partial class DeleteComment (string Id) : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public DeleteComment() : this("DeleteComment") { 
		}



    /// <summary>Field FeedId</summary>
	public string? FeedId {get; set;}

    /// <summary>Field PostId</summary>
	public string? PostId {get; set;}

    /// <summary>Field CommentId</summary>
	public string? CommentId {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("FeedId",
			(data, value) => {(data as DeleteComment)!.FeedId = value; },
			(data) => (data as DeleteComment)?.FeedId) {
				},
		new FrameString ("PostId",
			(data, value) => {(data as DeleteComment)!.PostId = value; },
			(data) => (data as DeleteComment)?.PostId) {
				},
		new FrameString ("CommentId",
			(data, value) => {(data as DeleteComment)!.CommentId = value; },
			(data) => (data as DeleteComment)?.CommentId) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("FeedId",
			(data, value) => {(data as DeleteComment)!.FeedId = value; },
			(data) => (data as DeleteComment)?.FeedId) {
				},
		new FrameString ("PostId",
			(data, value) => {(data as DeleteComment)!.PostId = value; },
			(data) => (data as DeleteComment)?.PostId) {
				},
		new FrameString ("CommentId",
			(data, value) => {(data as DeleteComment)!.CommentId = value; },
			(data) => (data as DeleteComment)?.CommentId) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<DeleteComment> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"FeedId", _properties[0]},
			{"PostId", _properties[1]},
			{"CommentId", _properties[2]}
			}, "DeleteComment",
		() => new DeleteComment(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for Comment
/// </summary>
public partial class Comment (string Id) : Entry (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public Comment() : this("Comment") { 
		}

    /// <inheritdoc/>
    public override FramePresentation Presentation => CommentFull;


    /// <summary>Field FeedId</summary>
	public string? FeedId {get; set;}

    /// <summary>Field PostId</summary>
	public string? PostId {get; set;}

    /// <summary>Field CommentId</summary>
	public string? CommentId {get; set;}

    /// <summary>Field User</summary>
	public User? User {get; set;}

    /// <summary>Field CommentText</summary>
	public string? CommentText {get; set;}

    /// <summary>Field Resources</summary>
	public Resource? Resources {get; set;}

    /// <summary>Field Likes</summary>
	public int? Likes {get; set;}

    /// <summary>Field Replies</summary>
	public string? Replies {get; set;}


	/// <summary>
	/// Presentation style CommentFull
	/// </summary>
	public static FramePresentation CommentFull => field ?? new FramePresentation ("CommentFull") {
		GetUid = (data) => (data as Comment)?.Uid,
		Sections = [
			new FrameSection ("Avatar") {
				GetAnchor = (data) => (data as Comment)?.AuthorLink,
				Fields = [
            		new FrameAvatar ("User.Avatar"){
            			Prompt = null,
            			Get = (data) => (data as Comment)?.User?.Avatar }
					]
				},
			new FrameSection ("Author") {
				GetAnchor = (data) => (data as Comment)?.AuthorLink,
				Fields = [
            		new FrameString ("User.DisplayName",
            			(data, value) => {(data as Comment)!.User!.DisplayName = value; },
            			(data) => (data as Comment)?.User?.DisplayName) {
            				},
            		new FrameString ("User.DisplayHandle",
            			(data, value) => {(data as Comment)!.User!.DisplayHandle = value; },
            			(data) => (data as Comment)?.User?.DisplayHandle) {
            				},
            		new FrameDateTime ("Created",
            			(data, value) => {(data as Comment)!.Created = value; },
            			(data) => (data as Comment)?.Created) {
            				}
					]
				},
			new FrameSection ("Rule") {
				Fields = [
					]
				},
			new FrameSection ("Body") {
				Fields = [
            		new FrameText ("Text",
            			(data, value) => {(data as Comment)!.Text = value; },
            			(data) => (data as Comment)?.Text) {
            				}
					]
				},
			new FrameSection ("Responses") {
				Fields = [
            		new FrameButton ("Comment", "Comment", "CreateComment") {
            			GetActive = (data) => (data as Comment)?.PermissionRespond,
            			GetAnchor = (data) => (data as Comment)?.PostPath
            			},
            		new FrameButton ("Delete", "Delete", "DeleteCommentPage") {
            			GetActive = (data) => (data as Comment)?.PermissionDelete,
            			GetAnchor = (data) => (data as Comment)?.PostPath
            			}
					]
				}
			]
		}.CacheValue(out field)!;

	/// <summary>
	/// Presentation style CommentFullSaved
	/// </summary>
	public static FramePresentation CommentFullSaved => field ?? new FramePresentation ("CommentFullSaved") {
		GetUid = (data) => (data as Comment)?.Uid,
		Sections = [
			new FrameSection ("Avatar") {
				GetAnchor = (data) => (data as Comment)?.AuthorLink,
				Fields = [
            		new FrameAvatar ("User.Avatar"){
            			Prompt = null,
            			Get = (data) => (data as Comment)?.User?.Avatar }
					]
				},
			new FrameSection ("Author") {
				GetAnchor = (data) => (data as Comment)?.AuthorLink,
				Fields = [
            		new FrameString ("User.DisplayName",
            			(data, value) => {(data as Comment)!.User!.DisplayName = value; },
            			(data) => (data as Comment)?.User?.DisplayName) {
            				},
            		new FrameString ("User.DisplayHandle",
            			(data, value) => {(data as Comment)!.User!.DisplayHandle = value; },
            			(data) => (data as Comment)?.User?.DisplayHandle) {
            				},
            		new FrameDateTime ("Created",
            			(data, value) => {(data as Comment)!.Created = value; },
            			(data) => (data as Comment)?.Created) {
            				}
					]
				},
			new FrameSection ("Rule") {
				Fields = [
					]
				},
			new FrameSection ("Body") {
				Fields = [
            		new FrameText ("Text",
            			(data, value) => {(data as Comment)!.Text = value; },
            			(data) => (data as Comment)?.Text) {
            				}
					]
				},
			new FrameSection ("Responses") {
				Fields = [
            		new FrameButton ("Comment", "Comment", "CreateComment") {
            			GetAnchor = (data) => (data as Comment)?.PostPath
            			},
            		new FrameSubmenu ("Repost", "Repost") {
            			Fields = [
                    		new FrameButton ("Repost", "Repost", "RepostAction") {
                    			GetAnchor = (data) => (data as Comment)?.PostPath
                    			},
                    		new FrameButton ("QuotePost", "Quote Post", "QuotePostAction") {
                    			GetAnchor = (data) => (data as Comment)?.PostPath
                    			}
            				]
            			},
            		new FrameSubmenu ("Share", "Share") {
            			Fields = [
                    		new FrameButton ("LinkCopy", "Copy link to post", "HomePage") {
                    			GetAnchor = (data) => (data as Comment)?.PostPath
                    			},
                    		new FrameButton ("SendByDM", "Send via direct message", "HomePage") {
                    			GetAnchor = (data) => (data as Comment)?.PostPath
                    			},
                    		new FrameButton ("Embed", "Embed post", "HomePage") {
                    			GetAnchor = (data) => (data as Comment)?.PostPath
                    			}
            				]
            			},
            		new FrameSubmenu ("Ellipsis", "More") {
            			Fields = [
                    		new FrameButton ("Translate", "Translate", "TranslateAction") {
                    			GetAnchor = (data) => (data as Comment)?.PostPath
                    			},
                    		new FrameButton ("CopyToClipboard", "Copy post text", "CopyPostAction") {
                    			GetAnchor = (data) => (data as Comment)?.PostPath
                    			},
                    		new FrameSeparator ("S1"),
                    		new FrameButton ("MuteThread", "Mute thread", "MuteThreadAction") {
                    			GetAnchor = (data) => (data as Comment)?.PostPath
                    			},
                    		new FrameButton ("MuteWords", "Mute words & tags", "MuteWordsAction") {
                    			GetAnchor = (data) => (data as Comment)?.PostPath
                    			},
                    		new FrameSeparator ("S2"),
                    		new FrameButton ("HidePost", "Hide post for me", "HidePostAction") {
                    			GetAnchor = (data) => (data as Comment)?.PostPath
                    			},
                    		new FrameSeparator ("S3"),
                    		new FrameButton ("MuteAccount", "Mute user", "MuteAccountAction") {
                    			GetAnchor = (data) => (data as Comment)?.AuthorLink
                    			},
                    		new FrameButton ("BlockAccount", "Block user", "BlockAccountAction") {
                    			GetAnchor = (data) => (data as Comment)?.AuthorLink
                    			},
                    		new FrameButton ("Report", "Report post", "ReportPostAction") {
                    			GetAnchor = (data) => (data as Comment)?.AuthorLink
                    			}
            				]
            			}
					]
				}
			]
		}.CacheValue(out field)!;

	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(data, value) => {(data as Entry)!.Uid = value; },
			(data) => (data as Entry)?.Uid) {
				Hidden = true
				},
		new FrameString ("Semantic",
			(data, value) => {(data as Entry)!.Semantic = value; },
			(data) => (data as Entry)?.Semantic) {
				Hidden = true
				},
		new FrameRefList<Rights> ("Rights","Rights"){
			Get = (data) => (data as Entry)?.Rights ,
			Set = (data, value) => {(data as Entry)!.Rights = value as List<Rights>; }},
		new FrameDateTime ("Created",
			(data, value) => {(data as Entry)!.Created = value; },
			(data) => (data as Entry)?.Created) {
				},
		Brief,
		new FrameString ("FeedId",
			(data, value) => {(data as Comment)!.FeedId = value; },
			(data) => (data as Comment)?.FeedId) {
				Hidden = true
				},
		new FrameString ("PostId",
			(data, value) => {(data as Comment)!.PostId = value; },
			(data) => (data as Comment)?.PostId) {
				Hidden = true
				},
		new FrameString ("CommentId",
			(data, value) => {(data as Comment)!.CommentId = value; },
			(data) => (data as Comment)?.CommentId) {
				Hidden = true
				},
		new FrameRefClass<User> ("User","User"){
			Get = (data) => (data as Comment)?.User ,
			Set = (data, value) => {(data as Comment)!.User = value as User; }},
		new FrameText ("CommentText",
			(data, value) => {(data as Comment)!.CommentText = value; },
			(data) => (data as Comment)?.CommentText) {
				},
		new FrameRefClass<Resource> ("Resources","Resource"){
			Get = (data) => (data as Comment)?.Resources ,
			Set = (data, value) => {(data as Comment)!.Resources = value as Resource; }},
		new FrameInteger ("Likes",
			(data, value) => {(data as Comment)!.Likes = value; },
			(data) => (data as Comment)?.Likes) {
				},
		new FrameString ("Replies",
			(data, value) => {(data as Comment)!.Replies = value; },
			(data) => (data as Comment)?.Replies) {
				},
		CommentFull,
		CommentFullSaved
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("FeedId",
			(data, value) => {(data as Comment)!.FeedId = value; },
			(data) => (data as Comment)?.FeedId) {
				Hidden = true
				},
		new FrameString ("PostId",
			(data, value) => {(data as Comment)!.PostId = value; },
			(data) => (data as Comment)?.PostId) {
				Hidden = true
				},
		new FrameString ("CommentId",
			(data, value) => {(data as Comment)!.CommentId = value; },
			(data) => (data as Comment)?.CommentId) {
				Hidden = true
				},
		new FrameText ("CommentText",
			(data, value) => {(data as Comment)!.CommentText = value; },
			(data) => (data as Comment)?.CommentText) {
				},
		new FrameInteger ("Likes",
			(data, value) => {(data as Comment)!.Likes = value; },
			(data) => (data as Comment)?.Likes) {
				},
		new FrameString ("Replies",
			(data, value) => {(data as Comment)!.Replies = value; },
			(data) => (data as Comment)?.Replies) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Comment> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"FeedId", _properties[0]},
			{"PostId", _properties[1]},
			{"CommentId", _properties[2]},
			{"CommentText", _properties[3]},
			{"Likes", _properties[4]},
			{"Replies", _properties[5]}
			}, "Comment",
		() => new Comment(), () => [], () => [], Parent: Entry._binding, Generic: false);


	}
/// <summary>
/// Backing class for Resource
/// </summary>
public partial class Resource (string Id) : Entry (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public Resource() : this("Resource") { 
		}



    /// <summary>Field Title</summary>
	public string? Title {get; set;}

    /// <summary>Field Size</summary>
	public int? Size {get; set;}

    /// <summary>Field MediaType</summary>
	public string? MediaType {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(data, value) => {(data as Entry)!.Uid = value; },
			(data) => (data as Entry)?.Uid) {
				Hidden = true
				},
		new FrameString ("Semantic",
			(data, value) => {(data as Entry)!.Semantic = value; },
			(data) => (data as Entry)?.Semantic) {
				Hidden = true
				},
		new FrameRefList<Rights> ("Rights","Rights"){
			Get = (data) => (data as Entry)?.Rights ,
			Set = (data, value) => {(data as Entry)!.Rights = value as List<Rights>; }},
		new FrameDateTime ("Created",
			(data, value) => {(data as Entry)!.Created = value; },
			(data) => (data as Entry)?.Created) {
				},
		Brief,
		new FrameString ("Title",
			(data, value) => {(data as Resource)!.Title = value; },
			(data) => (data as Resource)?.Title) {
				},
		new FrameInteger ("Size",
			(data, value) => {(data as Resource)!.Size = value; },
			(data) => (data as Resource)?.Size) {
				},
		new FrameString ("MediaType",
			(data, value) => {(data as Resource)!.MediaType = value; },
			(data) => (data as Resource)?.MediaType) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Title",
			(data, value) => {(data as Resource)!.Title = value; },
			(data) => (data as Resource)?.Title) {
				},
		new FrameInteger ("Size",
			(data, value) => {(data as Resource)!.Size = value; },
			(data) => (data as Resource)?.Size) {
				},
		new FrameString ("MediaType",
			(data, value) => {(data as Resource)!.MediaType = value; },
			(data) => (data as Resource)?.MediaType) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Resource> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Title", _properties[0]},
			{"Size", _properties[1]},
			{"MediaType", _properties[2]}
			}, "Resource",
		() => new Resource(), () => [], () => [], Parent: Entry._binding, Generic: false);


	}
/// <summary>
/// Backing class for Contact
/// </summary>
public partial class Contact (string Id) : Entry (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public Contact() : this("Contact") { 
		}



    /// <summary>Field Updated</summary>
	public System.DateTime? Updated {get; set;}

    /// <summary>Field User</summary>
	public User? User {get; set;}

    /// <summary>Field Name</summary>
	public Name? Name {get; set;}

    /// <summary>Field AltNames</summary>
	public List<Name>? AltNames {get; set;}

    /// <summary>Field NickNames</summary>
	public List<Name>? NickNames {get; set;}

    /// <summary>Field Organization</summary>
	public List<Organization>? Organization {get; set;}

    /// <summary>Field Pronouns</summary>
	public Pronouns? Pronouns {get; set;}

    /// <summary>Field RelatedTo</summary>
	public RelatedTo? RelatedTo {get; set;}

    /// <summary>Field Applications</summary>
	public List<Application>? Applications {get; set;}

    /// <summary>Field Media</summary>
	public List<Media>? Media {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(data, value) => {(data as Entry)!.Uid = value; },
			(data) => (data as Entry)?.Uid) {
				Hidden = true
				},
		new FrameString ("Semantic",
			(data, value) => {(data as Entry)!.Semantic = value; },
			(data) => (data as Entry)?.Semantic) {
				Hidden = true
				},
		new FrameRefList<Rights> ("Rights","Rights"){
			Get = (data) => (data as Entry)?.Rights ,
			Set = (data, value) => {(data as Entry)!.Rights = value as List<Rights>; }},
		new FrameDateTime ("Created",
			(data, value) => {(data as Entry)!.Created = value; },
			(data) => (data as Entry)?.Created) {
				},
		Brief,
		new FrameDateTime ("Updated",
			(data, value) => {(data as Contact)!.Updated = value; },
			(data) => (data as Contact)?.Updated) {
				Description = "Time of last contact update"
				},
		new FrameRefClass<User> ("User","User"){
			Get = (data) => (data as Contact)?.User ,
			Set = (data, value) => {(data as Contact)!.User = value as User; }},
		new FrameRefClass<Name> ("Name","Name"){
			Get = (data) => (data as Contact)?.Name ,
			Set = (data, value) => {(data as Contact)!.Name = value as Name; }},
		new FrameRefList<Name> ("AltNames","Name"){
			Get = (data) => (data as Contact)?.AltNames ,
			Set = (data, value) => {(data as Contact)!.AltNames = value as List<Name>; }},
		new FrameRefList<Name> ("NickNames","Name"){
			Get = (data) => (data as Contact)?.NickNames ,
			Set = (data, value) => {(data as Contact)!.NickNames = value as List<Name>; }},
		new FrameRefList<Organization> ("Organization","Organization"){
			Get = (data) => (data as Contact)?.Organization ,
			Set = (data, value) => {(data as Contact)!.Organization = value as List<Organization>; }},
		new FrameRefClass<Pronouns> ("Pronouns","Pronouns"){
			Get = (data) => (data as Contact)?.Pronouns ,
			Set = (data, value) => {(data as Contact)!.Pronouns = value as Pronouns; }},
		new FrameRefClass<RelatedTo> ("RelatedTo","RelatedTo"){
			Get = (data) => (data as Contact)?.RelatedTo ,
			Set = (data, value) => {(data as Contact)!.RelatedTo = value as RelatedTo; }},
		new FrameRef ("Addresses"),
		new FrameRefList<Application> ("Applications","Application"){
			Get = (data) => (data as Contact)?.Applications ,
			Set = (data, value) => {(data as Contact)!.Applications = value as List<Application>; }},
		new FrameRefList<Media> ("Media","Media"){
			Get = (data) => (data as Contact)?.Media ,
			Set = (data, value) => {(data as Contact)!.Media = value as List<Media>; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameDateTime ("Updated",
			(data, value) => {(data as Contact)!.Updated = value; },
			(data) => (data as Contact)?.Updated) {
				Description = "Time of last contact update"
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Contact> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Updated", _properties[0]}
			}, "Contact",
		() => new Contact(), () => [], () => [], Parent: Entry._binding, Generic: false);


	}
/// <summary>
/// Backing class for Name
/// </summary>
public partial class Name (string Id) : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public Name() : this("Name") { 
		}



    /// <summary>Field Full</summary>
	public string? Full {get; set;}

    /// <summary>Field Components</summary>
	public List<TagValue>? Components {get; set;}

    /// <summary>Field PhoneticSystem</summary>
	public string? PhoneticSystem {get; set;}

    /// <summary>Field PhoneticScript</summary>
	public string? PhoneticScript {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Full",
			(data, value) => {(data as Name)!.Full = value; },
			(data) => (data as Name)?.Full) {
				},
		new FrameRefList<TagValue> ("Components","TagValue"){
			Get = (data) => (data as Name)?.Components ,
			Set = (data, value) => {(data as Name)!.Components = value as List<TagValue>; }},
		new FrameString ("PhoneticSystem",
			(data, value) => {(data as Name)!.PhoneticSystem = value; },
			(data) => (data as Name)?.PhoneticSystem) {
				},
		new FrameString ("PhoneticScript",
			(data, value) => {(data as Name)!.PhoneticScript = value; },
			(data) => (data as Name)?.PhoneticScript) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Full",
			(data, value) => {(data as Name)!.Full = value; },
			(data) => (data as Name)?.Full) {
				},
		new FrameString ("PhoneticSystem",
			(data, value) => {(data as Name)!.PhoneticSystem = value; },
			(data) => (data as Name)?.PhoneticSystem) {
				},
		new FrameString ("PhoneticScript",
			(data, value) => {(data as Name)!.PhoneticScript = value; },
			(data) => (data as Name)?.PhoneticScript) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Name> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Full", _properties[0]},
			{"PhoneticSystem", _properties[1]},
			{"PhoneticScript", _properties[2]}
			}, "Name",
		() => new Name(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for TagValue
/// </summary>
public partial class TagValue (string Id) : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public TagValue() : this("TagValue") { 
		}



    /// <summary>Field FieldTag</summary>
	public string? FieldTag {get; set;}

    /// <summary>Field Value</summary>
	public string? Value {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("FieldTag",
			(data, value) => {(data as TagValue)!.FieldTag = value; },
			(data) => (data as TagValue)?.FieldTag) {
				},
		new FrameString ("Value",
			(data, value) => {(data as TagValue)!.Value = value; },
			(data) => (data as TagValue)?.Value) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("FieldTag",
			(data, value) => {(data as TagValue)!.FieldTag = value; },
			(data) => (data as TagValue)?.FieldTag) {
				},
		new FrameString ("Value",
			(data, value) => {(data as TagValue)!.Value = value; },
			(data) => (data as TagValue)?.Value) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<TagValue> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"FieldTag", _properties[0]},
			{"Value", _properties[1]}
			}, "TagValue",
		() => new TagValue(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for Organization
/// </summary>
public partial class Organization (string Id) : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public Organization() : this("Organization") { 
		}



    /// <summary>Field Name</summary>
	public string? Name {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Name",
			(data, value) => {(data as Organization)!.Name = value; },
			(data) => (data as Organization)?.Name) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Name",
			(data, value) => {(data as Organization)!.Name = value; },
			(data) => (data as Organization)?.Name) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Organization> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Name", _properties[0]}
			}, "Organization",
		() => new Organization(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for Pronouns
/// </summary>
public partial class Pronouns (string Id) : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public Pronouns() : this("Pronouns") { 
		}



    /// <summary>Field GramaticalGender</summary>
	public List<Option>? GramaticalGender {get; set;}

    /// <summary>Field Subjective</summary>
	public string? Subjective {get; set;}

    /// <summary>Field Objective</summary>
	public string? Objective {get; set;}

    /// <summary>Field Posessive</summary>
	public string? Posessive {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefList<Option> ("GramaticalGender","Option"){
			Get = (data) => (data as Pronouns)?.GramaticalGender ,
			Set = (data, value) => {(data as Pronouns)!.GramaticalGender = value as List<Option>; }},
		new FrameString ("Subjective",
			(data, value) => {(data as Pronouns)!.Subjective = value; },
			(data) => (data as Pronouns)?.Subjective) {
				},
		new FrameString ("Objective",
			(data, value) => {(data as Pronouns)!.Objective = value; },
			(data) => (data as Pronouns)?.Objective) {
				},
		new FrameString ("Posessive",
			(data, value) => {(data as Pronouns)!.Posessive = value; },
			(data) => (data as Pronouns)?.Posessive) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Subjective",
			(data, value) => {(data as Pronouns)!.Subjective = value; },
			(data) => (data as Pronouns)?.Subjective) {
				},
		new FrameString ("Objective",
			(data, value) => {(data as Pronouns)!.Objective = value; },
			(data) => (data as Pronouns)?.Objective) {
				},
		new FrameString ("Posessive",
			(data, value) => {(data as Pronouns)!.Posessive = value; },
			(data) => (data as Pronouns)?.Posessive) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Pronouns> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Subjective", _properties[0]},
			{"Objective", _properties[1]},
			{"Posessive", _properties[2]}
			}, "Pronouns",
		() => new Pronouns(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for Title
/// </summary>
public partial class Title (string Id) : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public Title() : this("Title") { 
		}



    /// <summary>Field Name</summary>
	public string? Name {get; set;}

    /// <summary>Field Organization</summary>
	public Organization? Organization {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Name",
			(data, value) => {(data as Title)!.Name = value; },
			(data) => (data as Title)?.Name) {
				},
		new FrameRefClass<Organization> ("Organization","Organization"){
			Get = (data) => (data as Title)?.Organization ,
			Set = (data, value) => {(data as Title)!.Organization = value as Organization; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Name",
			(data, value) => {(data as Title)!.Name = value; },
			(data) => (data as Title)?.Name) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Title> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Name", _properties[0]}
			}, "Title",
		() => new Title(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for RelatedTo
/// </summary>
public partial class RelatedTo (string Id) : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public RelatedTo() : this("RelatedTo") { 
		}



    /// <summary>Field Uid</summary>
	public string? Uid {get; set;}

    /// <summary>Field Relation</summary>
	public List<Option>? Relation {get; set;}

    /// <summary>Field Other</summary>
	public string? Other {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(data, value) => {(data as RelatedTo)!.Uid = value; },
			(data) => (data as RelatedTo)?.Uid) {
				Description = "URI of the related party"
				},
		new FrameRefList<Option> ("Relation","Option"){
			Get = (data) => (data as RelatedTo)?.Relation ,
			Set = (data, value) => {(data as RelatedTo)!.Relation = value as List<Option>; }},
		new FrameString ("Other",
			(data, value) => {(data as RelatedTo)!.Other = value; },
			(data) => (data as RelatedTo)?.Other) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Uid",
			(data, value) => {(data as RelatedTo)!.Uid = value; },
			(data) => (data as RelatedTo)?.Uid) {
				Description = "URI of the related party"
				},
		new FrameString ("Other",
			(data, value) => {(data as RelatedTo)!.Other = value; },
			(data) => (data as RelatedTo)?.Other) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<RelatedTo> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Uid", _properties[0]},
			{"Other", _properties[1]}
			}, "RelatedTo",
		() => new RelatedTo(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for Application
/// </summary>
public partial class Application (string Id) : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public Application() : this("Application") { 
		}



    /// <summary>Field ApplicationName</summary>
	public string? ApplicationName {get; set;}

    /// <summary>Field Address</summary>
	public string? Address {get; set;}

    /// <summary>Field Keys</summary>
	public List<Key>? Keys {get; set;}

    /// <summary>Field Preference</summary>
	public int? Preference {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("ApplicationName",
			(data, value) => {(data as Application)!.ApplicationName = value; },
			(data) => (data as Application)?.ApplicationName) {
				},
		new FrameString ("Address",
			(data, value) => {(data as Application)!.Address = value; },
			(data) => (data as Application)?.Address) {
				Description = "The user identifier at the service"
				},
		new FrameRefList<Key> ("Keys","Key"){
			Get = (data) => (data as Application)?.Keys ,
			Set = (data, value) => {(data as Application)!.Keys = value as List<Key>; }},
		new FrameInteger ("Preference",
			(data, value) => {(data as Application)!.Preference = value; },
			(data) => (data as Application)?.Preference) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("ApplicationName",
			(data, value) => {(data as Application)!.ApplicationName = value; },
			(data) => (data as Application)?.ApplicationName) {
				},
		new FrameString ("Address",
			(data, value) => {(data as Application)!.Address = value; },
			(data) => (data as Application)?.Address) {
				Description = "The user identifier at the service"
				},
		new FrameInteger ("Preference",
			(data, value) => {(data as Application)!.Preference = value; },
			(data) => (data as Application)?.Preference) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Application> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"ApplicationName", _properties[0]},
			{"Address", _properties[1]},
			{"Preference", _properties[2]}
			}, "Application",
		() => new Application(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for Email
/// </summary>
public partial class Email (string Id) : Application (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public Email() : this("Email") { 
		}




	static readonly List<IFrameField> _Fields = [
		new FrameString ("ApplicationName",
			(data, value) => {(data as Application)!.ApplicationName = value; },
			(data) => (data as Application)?.ApplicationName) {
				},
		new FrameString ("Address",
			(data, value) => {(data as Application)!.Address = value; },
			(data) => (data as Application)?.Address) {
				Description = "The user identifier at the service"
				},
		new FrameRefList<Key> ("Keys","Key"){
			Get = (data) => (data as Application)?.Keys ,
			Set = (data, value) => {(data as Application)!.Keys = value as List<Key>; }},
		new FrameInteger ("Preference",
			(data, value) => {(data as Application)!.Preference = value; },
			(data) => (data as Application)?.Preference) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Email> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "Email",
		() => new Email(), () => [], () => [], Parent: Application._binding, Generic: false);


	}
/// <summary>
/// Backing class for Messaging
/// </summary>
public partial class Messaging (string Id) : Application (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public Messaging() : this("Messaging") { 
		}



    /// <summary>Field Service</summary>
	public ServiceOption? Service {get; set;}

    /// <summary>Field Other</summary>
	public string? Other {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("ApplicationName",
			(data, value) => {(data as Application)!.ApplicationName = value; },
			(data) => (data as Application)?.ApplicationName) {
				},
		new FrameString ("Address",
			(data, value) => {(data as Application)!.Address = value; },
			(data) => (data as Application)?.Address) {
				Description = "The user identifier at the service"
				},
		new FrameRefList<Key> ("Keys","Key"){
			Get = (data) => (data as Application)?.Keys ,
			Set = (data, value) => {(data as Application)!.Keys = value as List<Key>; }},
		new FrameInteger ("Preference",
			(data, value) => {(data as Application)!.Preference = value; },
			(data) => (data as Application)?.Preference) {
				},
		new FrameRefClass<ServiceOption> ("Service","ServiceOption"){
			Get = (data) => (data as Messaging)?.Service ,
			Set = (data, value) => {(data as Messaging)!.Service = value as ServiceOption; }},
		new FrameString ("Other",
			(data, value) => {(data as Messaging)!.Other = value; },
			(data) => (data as Messaging)?.Other) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Other",
			(data, value) => {(data as Messaging)!.Other = value; },
			(data) => (data as Messaging)?.Other) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Messaging> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Other", _properties[0]}
			}, "Messaging",
		() => new Messaging(), () => [], () => [], Parent: Application._binding, Generic: false);


	}
/// <summary>
/// Backing class for Phone
/// </summary>
public partial class Phone (string Id) : Application (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public Phone() : this("Phone") { 
		}



    /// <summary>Field Features</summary>
	public List<Option>? Features {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("ApplicationName",
			(data, value) => {(data as Application)!.ApplicationName = value; },
			(data) => (data as Application)?.ApplicationName) {
				},
		new FrameString ("Address",
			(data, value) => {(data as Application)!.Address = value; },
			(data) => (data as Application)?.Address) {
				Description = "The user identifier at the service"
				},
		new FrameRefList<Key> ("Keys","Key"){
			Get = (data) => (data as Application)?.Keys ,
			Set = (data, value) => {(data as Application)!.Keys = value as List<Key>; }},
		new FrameInteger ("Preference",
			(data, value) => {(data as Application)!.Preference = value; },
			(data) => (data as Application)?.Preference) {
				},
		new FrameRefList<Option> ("Features","Option"){
			Get = (data) => (data as Phone)?.Features ,
			Set = (data, value) => {(data as Phone)!.Features = value as List<Option>; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Phone> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "Phone",
		() => new Phone(), () => [], () => [], Parent: Application._binding, Generic: false);


	}
/// <summary>
/// Backing class for Service
/// </summary>
public partial class Service (string Id) : Application (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public Service() : this("Service") { 
		}



    /// <summary>Field ServiceName</summary>
	public string? ServiceName {get; set;}

    /// <summary>Field Protocol</summary>
	public string? Protocol {get; set;}

    /// <summary>Field ServiceType</summary>
	public Option? ServiceType {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("ApplicationName",
			(data, value) => {(data as Application)!.ApplicationName = value; },
			(data) => (data as Application)?.ApplicationName) {
				},
		new FrameString ("Address",
			(data, value) => {(data as Application)!.Address = value; },
			(data) => (data as Application)?.Address) {
				Description = "The user identifier at the service"
				},
		new FrameRefList<Key> ("Keys","Key"){
			Get = (data) => (data as Application)?.Keys ,
			Set = (data, value) => {(data as Application)!.Keys = value as List<Key>; }},
		new FrameInteger ("Preference",
			(data, value) => {(data as Application)!.Preference = value; },
			(data) => (data as Application)?.Preference) {
				},
		new FrameString ("ServiceName",
			(data, value) => {(data as Service)!.ServiceName = value; },
			(data) => (data as Service)?.ServiceName) {
				Description = "The service address"
				},
		new FrameString ("Protocol",
			(data, value) => {(data as Service)!.Protocol = value; },
			(data) => (data as Service)?.Protocol) {
				},
		new FrameRefClass<Option> ("ServiceType","Option"){
			Get = (data) => (data as Service)?.ServiceType ,
			Set = (data, value) => {(data as Service)!.ServiceType = value as Option; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("ServiceName",
			(data, value) => {(data as Service)!.ServiceName = value; },
			(data) => (data as Service)?.ServiceName) {
				Description = "The service address"
				},
		new FrameString ("Protocol",
			(data, value) => {(data as Service)!.Protocol = value; },
			(data) => (data as Service)?.Protocol) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Service> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"ServiceName", _properties[0]},
			{"Protocol", _properties[1]}
			}, "Service",
		() => new Service(), () => [], () => [], Parent: Application._binding, Generic: false);


	}
/// <summary>
/// Backing class for Key
/// </summary>
public partial class Key (string Id) : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public Key() : this("Key") { 
		}



    /// <summary>Field KeyData</summary>
	public KeyData? KeyData {get; set;}

    /// <summary>Field Protocol</summary>
	public ServiceOption? Protocol {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefClass<KeyData> ("KeyData","KeyData"){
			Get = (data) => (data as Key)?.KeyData ,
			Set = (data, value) => {(data as Key)!.KeyData = value as KeyData; }},
		new FrameRefClass<ServiceOption> ("Protocol","ServiceOption"){
			Get = (data) => (data as Key)?.Protocol ,
			Set = (data, value) => {(data as Key)!.Protocol = value as ServiceOption; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here
		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Key> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "Key",
		() => new Key(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for KeyData
/// </summary>
public partial class KeyData (string Id) : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public KeyData() : this("KeyData") { 
		}



    /// <summary>Field UID</summary>
	public string? UID {get; set;}

    /// <summary>Field Encryption</summary>
	public bool? Encryption {get; set;}

    /// <summary>Field Signature</summary>
	public bool? Signature {get; set;}

    /// <summary>Field Value</summary>
	public string? Value {get; set;}

    /// <summary>Field Upload</summary>
	public BackingTypeFile? Upload {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("UID",
			(data, value) => {(data as KeyData)!.UID = value; },
			(data) => (data as KeyData)?.UID) {
				},
		new FrameBoolean ("Encryption",
			(data, value) => {(data as KeyData)!.Encryption = value; },
			(data) => (data as KeyData)?.Encryption) {
				},
		new FrameBoolean ("Signature",
			(data, value) => {(data as KeyData)!.Signature = value; },
			(data) => (data as KeyData)?.Signature) {
				},
		new FrameString ("Value",
			(data, value) => {(data as KeyData)!.Value = value; },
			(data) => (data as KeyData)?.Value) {
				},
		new FrameFile ("Upload"){
			FileType = null,
			Prompt = null,
			Description = null,
			Get = (data) => (data as KeyData)?.Upload ,
			Set = (data, value) => {(data as KeyData)!.Upload = value as BackingTypeFile; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("UID",
			(data, value) => {(data as KeyData)!.UID = value; },
			(data) => (data as KeyData)?.UID) {
				},
		new FrameBoolean ("Encryption",
			(data, value) => {(data as KeyData)!.Encryption = value; },
			(data) => (data as KeyData)?.Encryption) {
				},
		new FrameBoolean ("Signature",
			(data, value) => {(data as KeyData)!.Signature = value; },
			(data) => (data as KeyData)?.Signature) {
				},
		new FrameString ("Value",
			(data, value) => {(data as KeyData)!.Value = value; },
			(data) => (data as KeyData)?.Value) {
				},
		new FrameFile ("Upload"){
			FileType = null,
			Prompt = null,
			Description = null,
			Get = (data) => (data as KeyData)?.Upload ,
			Set = (data, value) => {(data as KeyData)!.Upload = value as BackingTypeFile; }}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<KeyData> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"UID", _properties[0]},
			{"Encryption", _properties[1]},
			{"Signature", _properties[2]},
			{"Value", _properties[3]},
			{"Upload", _properties[4]}
			}, "KeyData",
		() => new KeyData(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for Media
/// </summary>
public partial class Media (string Id) : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public Media() : this("Media") { 
		}



    /// <summary>Field Data</summary>
	public BackingTypeFile? Data {get; set;}

    /// <summary>Field MediaType</summary>
	public string? MediaType {get; set;}

    /// <summary>Field Width</summary>
	public int? Width {get; set;}

    /// <summary>Field Height</summary>
	public int? Height {get; set;}

    /// <summary>Field Length</summary>
	public int? Length {get; set;}

    /// <summary>Field Bytes</summary>
	public int? Bytes {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameFile ("Data"){
			FileType = null,
			Prompt = null,
			Description = "The media resource",
			Get = (data) => (data as Media)?.Data ,
			Set = (data, value) => {(data as Media)!.Data = value as BackingTypeFile; }},
		new FrameString ("MediaType",
			(data, value) => {(data as Media)!.MediaType = value; },
			(data) => (data as Media)?.MediaType) {
				Description = "The IANA Media Type"
				},
		new FrameInteger ("Width",
			(data, value) => {(data as Media)!.Width = value; },
			(data) => (data as Media)?.Width) {
				Description = "Width of image/video media in pixels"
				},
		new FrameInteger ("Height",
			(data, value) => {(data as Media)!.Height = value; },
			(data) => (data as Media)?.Height) {
				Description = "Height of image/video media in pixels"
				},
		new FrameInteger ("Length",
			(data, value) => {(data as Media)!.Length = value; },
			(data) => (data as Media)?.Length) {
				Description = "Length of audio/video media in seconds"
				},
		new FrameInteger ("Bytes",
			(data, value) => {(data as Media)!.Bytes = value; },
			(data) => (data as Media)?.Bytes) {
				Description = "Size of the resource in bytes"
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameFile ("Data"){
			FileType = null,
			Prompt = null,
			Description = "The media resource",
			Get = (data) => (data as Media)?.Data ,
			Set = (data, value) => {(data as Media)!.Data = value as BackingTypeFile; }},
		new FrameString ("MediaType",
			(data, value) => {(data as Media)!.MediaType = value; },
			(data) => (data as Media)?.MediaType) {
				Description = "The IANA Media Type"
				},
		new FrameInteger ("Width",
			(data, value) => {(data as Media)!.Width = value; },
			(data) => (data as Media)?.Width) {
				Description = "Width of image/video media in pixels"
				},
		new FrameInteger ("Height",
			(data, value) => {(data as Media)!.Height = value; },
			(data) => (data as Media)?.Height) {
				Description = "Height of image/video media in pixels"
				},
		new FrameInteger ("Length",
			(data, value) => {(data as Media)!.Length = value; },
			(data) => (data as Media)?.Length) {
				Description = "Length of audio/video media in seconds"
				},
		new FrameInteger ("Bytes",
			(data, value) => {(data as Media)!.Bytes = value; },
			(data) => (data as Media)?.Bytes) {
				Description = "Size of the resource in bytes"
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Media> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Data", _properties[0]},
			{"MediaType", _properties[1]},
			{"Width", _properties[2]},
			{"Height", _properties[3]},
			{"Length", _properties[4]},
			{"Bytes", _properties[5]}
			}, "Media",
		() => new Media(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for Option
/// </summary>
public partial class Option (string Id) : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public Option() : this("Option") { 
		}



    /// <summary>Field OptionId</summary>
	public string? OptionId {get; set;}

    /// <summary>Field Text</summary>
	public string? Text {get; set;}

    /// <summary>Field Icon</summary>
	public string? Icon {get; set;}

    /// <summary>Field Priority</summary>
	public int? Priority {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("OptionId",
			(data, value) => {(data as Option)!.OptionId = value; },
			(data) => (data as Option)?.OptionId) {
				Hidden = true,
				Description = "Unique identifier"
				},
		new FrameString ("Text",
			(data, value) => {(data as Option)!.Text = value; },
			(data) => (data as Option)?.Text) {
				Description = "Text prompt for the option"
				},
		new FrameString ("Icon",
			(data, value) => {(data as Option)!.Icon = value; },
			(data) => (data as Option)?.Icon) {
				Description = "Icon prompt for the option"
				},
		new FrameInteger ("Priority",
			(data, value) => {(data as Option)!.Priority = value; },
			(data) => (data as Option)?.Priority) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("OptionId",
			(data, value) => {(data as Option)!.OptionId = value; },
			(data) => (data as Option)?.OptionId) {
				Hidden = true,
				Description = "Unique identifier"
				},
		new FrameString ("Text",
			(data, value) => {(data as Option)!.Text = value; },
			(data) => (data as Option)?.Text) {
				Description = "Text prompt for the option"
				},
		new FrameString ("Icon",
			(data, value) => {(data as Option)!.Icon = value; },
			(data) => (data as Option)?.Icon) {
				Description = "Icon prompt for the option"
				},
		new FrameInteger ("Priority",
			(data, value) => {(data as Option)!.Priority = value; },
			(data) => (data as Option)?.Priority) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<Option> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"OptionId", _properties[0]},
			{"Text", _properties[1]},
			{"Icon", _properties[2]},
			{"Priority", _properties[3]}
			}, "Option",
		() => new Option(), () => [], () => [], Parent: null, Generic: false);


	}
/// <summary>
/// Backing class for ServiceOption
/// </summary>
public partial class ServiceOption (string Id) : Option (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

	/// <summary>
	/// Paramaterless constructor enabling use of new().
	/// </summary>
	public ServiceOption() : this("ServiceOption") { 
		}



    /// <summary>Field Uri</summary>
	public string? Uri {get; set;}

    /// <summary>Field Template</summary>
	public string? Template {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("OptionId",
			(data, value) => {(data as Option)!.OptionId = value; },
			(data) => (data as Option)?.OptionId) {
				Hidden = true,
				Description = "Unique identifier"
				},
		new FrameString ("Text",
			(data, value) => {(data as Option)!.Text = value; },
			(data) => (data as Option)?.Text) {
				Description = "Text prompt for the option"
				},
		new FrameString ("Icon",
			(data, value) => {(data as Option)!.Icon = value; },
			(data) => (data as Option)?.Icon) {
				Description = "Icon prompt for the option"
				},
		new FrameInteger ("Priority",
			(data, value) => {(data as Option)!.Priority = value; },
			(data) => (data as Option)?.Priority) {
				},
		new FrameString ("Uri",
			(data, value) => {(data as ServiceOption)!.Uri = value; },
			(data) => (data as ServiceOption)?.Uri) {
				Description = "The service address"
				},
		new FrameString ("Template",
			(data, value) => {(data as ServiceOption)!.Template = value; },
			(data) => (data as ServiceOption)?.Template) {
				Description = "Template that converts the user address to a URI"
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Uri",
			(data, value) => {(data as ServiceOption)!.Uri = value; },
			(data) => (data as ServiceOption)?.Uri) {
				Description = "The service address"
				},
		new FrameString ("Template",
			(data, value) => {(data as ServiceOption)!.Template = value; },
			(data) => (data as ServiceOption)?.Template) {
				Description = "Template that converts the user address to a URI"
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	protected static readonly new Binding<ServiceOption> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Uri", _properties[0]},
			{"Template", _properties[1]}
			}, "ServiceOption",
		() => new ServiceOption(), () => [], () => [], Parent: Option._binding, Generic: false);


	}

