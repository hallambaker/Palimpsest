
namespace Frame;

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

	///<summary>BookmarkPage</summary>
	public BookmarkPage BookmarkPage {get;} = new();

	///<summary>YourPlacePage</summary>
	public YourPlacePage YourPlacePage {get;} = new();

	///<summary>PostPage</summary>
	public PostPage PostPage {get;} = new();

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

	///<summary>CreatePost</summary>
	public CreatePost CreatePost {get;} = new();

	///<summary>CreateComment</summary>
	public CreateComment CreateComment {get;} = new();

	///<summary>NewPlacePage</summary>
	public NewPlacePage NewPlacePage {get;} = new();

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

	 ///<summary>Topic</summary>
	 public Topic Topic {get;} = new();

	 ///<summary>Post</summary>
	 public Post Post {get;} = new();

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
			BookmarkPage,
			YourPlacePage,
			PostPage,
			SettingsPage,
			AccountSettings,
			AppearanceSettings,
			AboutSettingsPage,
			SignIn,
			SwitchPage,
			CreatePost,
			CreateComment,
			NewPlacePage,
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
			Handle,
			Provider,
			User,
			Group,
			Rights,
			Access,
			Privileges,
			Entry,
			Place,
			Topic,
			Post,
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
			Get = (IBacked data) => (data as HomePage)?.MainEntry ,
			Set = (IBacked data, IBacked? value) => {(data as HomePage)!.MainEntry = value as Place; }},
		new FrameRefList<Entry> ("Entries","Entry"){
			Presentation = SummaryPresentation,
			Get = (IBacked data) => (data as HomePage)?.Entries ,
			Set = (IBacked data, Object? value) => {(data as HomePage)!.Entries = value as List<Entry>; }}
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
	static readonly new Binding<HomePage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "HomePage",
		() => new HomePage(), () => [], () => [], null, Generic: false);


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
		new FrameRefMenu ("TopSettings","TopSettings"),
		new FrameRefList<Entry> ("Entries","Entry"){
			Presentation = SummaryPresentation,
			Get = (IBacked data) => (data as NotificationsPage)?.Entries ,
			Set = (IBacked data, Object? value) => {(data as NotificationsPage)!.Entries = value as List<Entry>; }}
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
	static readonly new Binding<NotificationsPage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "NotificationsPage",
		() => new NotificationsPage(), () => [], () => [], null, Generic: false);


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
		new FrameRefMenu ("TopSettings","TopSettings"),
		new FrameRefList<Entry> ("Entries","Entry"){
			Presentation = SummaryPresentation,
			Get = (IBacked data) => (data as PlacesPage)?.Entries ,
			Set = (IBacked data, Object? value) => {(data as PlacesPage)!.Entries = value as List<Entry>; }}
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
	static readonly new Binding<PlacesPage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "PlacesPage",
		() => new PlacesPage(), () => [], () => [], null, Generic: false);


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
		new FrameRefMenu ("TopSettings","TopSettings"),
		new FrameRefList<Entry> ("Entries","Entry"){
			Presentation = SummaryPresentation,
			Get = (IBacked data) => (data as BookmarkPage)?.Entries ,
			Set = (IBacked data, Object? value) => {(data as BookmarkPage)!.Entries = value as List<Entry>; }}
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
	static readonly new Binding<BookmarkPage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "BookmarkPage",
		() => new BookmarkPage(), () => [], () => [], null, Generic: false);


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
		new FrameRefMenu ("TopSettings","TopSettings"),
		new FrameRefClass<Place> ("MainEntry","Place"){
			Presentation = FullPresentation,
			Get = (IBacked data) => (data as YourPlacePage)?.MainEntry ,
			Set = (IBacked data, IBacked? value) => {(data as YourPlacePage)!.MainEntry = value as Place; }},
		new FrameRefList<Entry> ("Entries","Entry"){
			Presentation = SummaryPresentation,
			Get = (IBacked data) => (data as YourPlacePage)?.Entries ,
			Set = (IBacked data, Object? value) => {(data as YourPlacePage)!.Entries = value as List<Entry>; }}
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
	static readonly new Binding<YourPlacePage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "YourPlacePage",
		() => new YourPlacePage(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for PostPage
/// </summary>
public partial class PostPage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public PostPage () : base ("PostPage", "Post", _Fields) {
		Container = "FlowPage";
		}

    /// <summary>Field MainEntry</summary>
	public Post? MainEntry {get; set;}

    /// <summary>Field Entries</summary>
	public List<Comment>? Entries {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRefClass<Post> ("MainEntry","Post"){
			Presentation = PostPresentation,
			Get = (IBacked data) => (data as PostPage)?.MainEntry ,
			Set = (IBacked data, IBacked? value) => {(data as PostPage)!.MainEntry = value as Post; }},
		new FrameRefList<Comment> ("Entries","Comment"){
			Presentation = CommentPresentation,
			Get = (IBacked data) => (data as PostPage)?.Entries ,
			Set = (IBacked data, Object? value) => {(data as PostPage)!.Entries = value as List<Comment>; }}
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
	static readonly new Binding<PostPage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "PostPage",
		() => new PostPage(), () => [], () => [], null, Generic: false);


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
	static readonly new Binding<SettingsPage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "SettingsPage",
		() => new SettingsPage(), () => [], () => [], null, Generic: false);


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
	static readonly new Binding<AccountSettings> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "AccountSettings",
		() => new AccountSettings(), () => [], () => [], null, Generic: false);


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
	static readonly new Binding<AppearanceSettings> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "AppearanceSettings",
		() => new AppearanceSettings(), () => [], () => [], null, Generic: false);


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
	static readonly new Binding<AboutSettingsPage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "AboutSettingsPage",
		() => new AboutSettingsPage(), () => [], () => [], null, Generic: false);


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

    /// <summary>Field Text</summary>
	public string? Text {get; set;}

    /// <summary>Field Form</summary>
	public Handle? Form {get; set;}

    /// <summary>Field RegisterText</summary>
	public string? RegisterText {get; set;}

    /// <summary>Field Providers</summary>
	public List<Provider>? Providers {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameString ("Text",
			(IBinding data, string? value) => {(data as SignIn)!.Text = value; },
			(IBinding data) => (data as SignIn)?.Text) {
				},
		new FrameRefForm<Handle> ("Form","Handle"){
			Get = (IBacked data) => (data as SignIn)?.Form ,
			Set = (IBacked data, IBacked? value) => {(data as SignIn)!.Form = value as Handle; }},
		new FrameString ("RegisterText",
			(IBinding data, string? value) => {(data as SignIn)!.RegisterText = value; },
			(IBinding data) => (data as SignIn)?.RegisterText) {
				},
		new FrameRefList<Provider> ("Providers","Provider"){
			Get = (IBacked data) => (data as SignIn)?.Providers ,
			Set = (IBacked data, Object? value) => {(data as SignIn)!.Providers = value as List<Provider>; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Text",
			(IBinding data, string? value) => {(data as SignIn)!.Text = value; },
			(IBinding data) => (data as SignIn)?.Text) {
				},
		new FrameString ("RegisterText",
			(IBinding data, string? value) => {(data as SignIn)!.RegisterText = value; },
			(IBinding data) => (data as SignIn)?.RegisterText) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<SignIn> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Text", _properties[0]},
			{"RegisterText", _properties[1]}
			}, "SignIn",
		() => new SignIn(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for SwitchPage
/// </summary>
public partial class SwitchPage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public SwitchPage () : base ("SwitchPage", "Switch Account", _Fields) {
		Container = "EntryPage";
		}


	static readonly List<IFrameField> _Fields = [
		new FrameButton ("SignOut", "Sign Out", "SignOut") {
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
	static readonly new Binding<SwitchPage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "SwitchPage",
		() => new SwitchPage(), () => [], () => [], null, Generic: false);


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

    /// <summary>Field Form</summary>
	public Post? Form {get; set;}

    /// <summary>Field Crosspost</summary>
	public List<Provider>? Crosspost {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRefForm<Post> ("Form","Post"){
			Get = (IBacked data) => (data as CreatePost)?.Form ,
			Set = (IBacked data, IBacked? value) => {(data as CreatePost)!.Form = value as Post; }},
		new FrameRefList<Provider> ("Crosspost","Provider"){
			Get = (IBacked data) => (data as CreatePost)?.Crosspost ,
			Set = (IBacked data, Object? value) => {(data as CreatePost)!.Crosspost = value as List<Provider>; }}
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
	static readonly new Binding<CreatePost> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "CreatePost",
		() => new CreatePost(), () => [], () => [], null, Generic: false);


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
			Get = (IBacked data) => (data as CreateComment)?.Target ,
			Set = (IBacked data, IBacked? value) => {(data as CreateComment)!.Target = value as Comment; }},
		new FrameRefForm<Comment> ("Form","Comment"){
			Get = (IBacked data) => (data as CreateComment)?.Form ,
			Set = (IBacked data, IBacked? value) => {(data as CreateComment)!.Form = value as Comment; }}
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
	static readonly new Binding<CreateComment> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "CreateComment",
		() => new CreateComment(), () => [], () => [], null, Generic: false);


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
	public Place? Form {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRefForm<Place> ("Form","Place"){
			Get = (IBacked data) => (data as NewPlacePage)?.Form ,
			Set = (IBacked data, IBacked? value) => {(data as NewPlacePage)!.Form = value as Place; }}
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
	static readonly new Binding<NewPlacePage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "NewPlacePage",
		() => new NewPlacePage(), () => [], () => [], null, Generic: false);


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

    /// <summary>Field Place</summary>
	public Place? Place {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRefForm<Place> ("Place","Place"){
			Get = (IBacked data) => (data as YourPlacePageCreate)?.Place ,
			Set = (IBacked data, IBacked? value) => {(data as YourPlacePageCreate)!.Place = value as Place; }}
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
	static readonly new Binding<YourPlacePageCreate> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "YourPlacePageCreate",
		() => new YourPlacePageCreate(), () => [], () => [], null, Generic: false);


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

    /// <summary>Field Text</summary>
	public string? Text {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("SupportNav","SupportMenu"),
		new FrameRichText ("Text",
			(IBinding data, string? value) => {(data as Help)!.Text = value; },
			(IBinding data) => (data as Help)?.Text) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameRichText ("Text",
			(IBinding data, string? value) => {(data as Help)!.Text = value; },
			(IBinding data) => (data as Help)?.Text) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Help> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Text", _properties[0]}
			}, "Help",
		() => new Help(), () => [], () => [], null, Generic: false);


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

    /// <summary>Field Text</summary>
	public string? Text {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("SupportNav","SupportMenu"),
		new FrameRichText ("Text",
			(IBinding data, string? value) => {(data as TermsOfService)!.Text = value; },
			(IBinding data) => (data as TermsOfService)?.Text) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameRichText ("Text",
			(IBinding data, string? value) => {(data as TermsOfService)!.Text = value; },
			(IBinding data) => (data as TermsOfService)?.Text) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<TermsOfService> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Text", _properties[0]}
			}, "TermsOfService",
		() => new TermsOfService(), () => [], () => [], null, Generic: false);


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

    /// <summary>Field Text</summary>
	public string? Text {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("SupportNav","SupportMenu"),
		new FrameRichText ("Text",
			(IBinding data, string? value) => {(data as PrivacyPolicy)!.Text = value; },
			(IBinding data) => (data as PrivacyPolicy)?.Text) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameRichText ("Text",
			(IBinding data, string? value) => {(data as PrivacyPolicy)!.Text = value; },
			(IBinding data) => (data as PrivacyPolicy)?.Text) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<PrivacyPolicy> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Text", _properties[0]}
			}, "PrivacyPolicy",
		() => new PrivacyPolicy(), () => [], () => [], null, Generic: false);


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

    /// <summary>Field Text</summary>
	public string? Text {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("SupportNav","SupportMenu"),
		new FrameRichText ("Text",
			(IBinding data, string? value) => {(data as Contributors)!.Text = value; },
			(IBinding data) => (data as Contributors)?.Text) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameRichText ("Text",
			(IBinding data, string? value) => {(data as Contributors)!.Text = value; },
			(IBinding data) => (data as Contributors)?.Text) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Contributors> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Text", _properties[0]}
			}, "Contributors",
		() => new Contributors(), () => [], () => [], null, Generic: false);


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

    /// <summary>Field Text</summary>
	public string? Text {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("SupportNav","SupportMenu"),
		new FrameRichText ("Text",
			(IBinding data, string? value) => {(data as Status)!.Text = value; },
			(IBinding data) => (data as Status)?.Text) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameRichText ("Text",
			(IBinding data, string? value) => {(data as Status)!.Text = value; },
			(IBinding data) => (data as Status)?.Text) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Status> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Text", _properties[0]}
			}, "Status",
		() => new Status(), () => [], () => [], null, Generic: false);


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

    /// <summary>Field Text</summary>
	public string? Text {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("SupportNav","SupportMenu"),
		new FrameRichText ("Text",
			(IBinding data, string? value) => {(data as SystemLog)!.Text = value; },
			(IBinding data) => (data as SystemLog)?.Text) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameRichText ("Text",
			(IBinding data, string? value) => {(data as SystemLog)!.Text = value; },
			(IBinding data) => (data as SystemLog)?.Text) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<SystemLog> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Text", _properties[0]}
			}, "SystemLog",
		() => new SystemLog(), () => [], () => [], null, Generic: false);


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

    /// <summary>Field Text</summary>
	public string? Text {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("SupportNav","SupportMenu"),
		new FrameRichText ("Text",
			(IBinding data, string? value) => {(data as Repository)!.Text = value; },
			(IBinding data) => (data as Repository)?.Text) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameRichText ("Text",
			(IBinding data, string? value) => {(data as Repository)!.Text = value; },
			(IBinding data) => (data as Repository)?.Text) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Repository> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Text", _properties[0]}
			}, "Repository",
		() => new Repository(), () => [], () => [], null, Generic: false);


	}

// Menus 
/// <summary>
/// Backing class for MainNav
/// </summary>
public partial class MainNav : FrameMenu {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public MainNav () : base ("MainNav", _Fields) {
		}

    /// <summary>Field NotificationCount</summary>
	public int? NotificationCount {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameInteger ("NotificationCount",
			(IBinding data, int? value) => {(data as MainNav)!.NotificationCount = value; },
			(IBinding data) => (data as MainNav)?.NotificationCount) {
				},
		new FrameButton ("Any", "Sign In", "SignIn") {
			GetActive = (IBinding data) => (data as MainNav)?.SignInActive
			},
		new FrameButton ("Avatar", "Sign Out", "SwitchPage") {
			GetActive = (IBinding data) => (data as MainNav)?.SignOutActive
			},
		new FrameButton ("Home", "Home", "HomePage") {
			GetActive = (IBinding data) => (data as MainNav)?.HomePageActive
			},
		new FrameButton ("Notifications", "Notifications", "NotificationsPage") {
			GetActive = (IBinding data) => (data as MainNav)?.NotificationsActive,
			GetInteger = (IBinding data) => (data as MainNav)?.NotificationCount
			},
		new FrameButton ("Places", "Places", "PlacesPage") {
			GetActive = (IBinding data) => (data as MainNav)?.PlacesActive
			},
		new FrameButton ("Bookmark", "Saved", "BookmarkPage") {
			GetActive = (IBinding data) => (data as MainNav)?.BookmarksActive
			},
		new FrameButton ("Place", "Your Place", "YourPlacePage") {
			GetActive = (IBinding data) => (data as MainNav)?.YourPlaceActive
			},
		new FrameButton ("CreateYour", "Your Place", "YourPlacePageCreate") {
			GetActive = (IBinding data) => (data as MainNav)?.CreateYourPlaceActive
			},
		new FrameButton ("Settings", "Settings", "SettingsPage") {
			GetActive = (IBinding data) => (data as MainNav)?.SettingsActive
			},
		new FrameButton ("NewPlace", "New Place", "NewPlacePage") {
			GetActive = (IBinding data) => (data as MainNav)?.CreatePlaceActive
			},
		new FrameButton ("CreatePost", "Create Post", "CreatePost") {
			},
		new FrameButton ("CreateComment", "Add Comment", "CreateComment") {
			},
		new FrameButton ("Post", "Test Post", "PostPage") {
			}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameInteger ("NotificationCount",
			(IBinding data, int? value) => {(data as MainNav)!.NotificationCount = value; },
			(IBinding data) => (data as MainNav)?.NotificationCount) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<MainNav> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"NotificationCount", _properties[0]}
			}, "MainNav",
		() => new MainNav(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for TopSettings
/// </summary>
public partial class TopSettings : FrameMenu {

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
	static readonly new Binding<TopSettings> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "TopSettings",
		() => new TopSettings(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for SettingsMenu
/// </summary>
public partial class SettingsMenu : FrameMenu {

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
	static readonly new Binding<SettingsMenu> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "SettingsMenu",
		() => new SettingsMenu(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for AboutSettings
/// </summary>
public partial class AboutSettings : FrameMenu {

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
	static readonly new Binding<AboutSettings> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "AboutSettings",
		() => new AboutSettings(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for SupportMenu
/// </summary>
public partial class SupportMenu : FrameMenu {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public SupportMenu () : base ("SupportMenu", _Fields) {
		}


	static readonly List<IFrameField> _Fields = [
		new FrameButton ("Home", "Home", "HomePage") {
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
	static readonly new Binding<SupportMenu> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "SupportMenu",
		() => new SupportMenu(), () => [], () => [], null, Generic: false);


	}

// Classes 



// Classes 
/// <summary>
/// Backing class for Handle
/// </summary>
public partial class Handle (string Id="Handle") : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field DNS</summary>
	public string? DNS {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("DNS",
			(IBinding data, string? value) => {(data as Handle)!.DNS = value; },
			(IBinding data) => (data as Handle)?.DNS) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("DNS",
			(IBinding data, string? value) => {(data as Handle)!.DNS = value; },
			(IBinding data) => (data as Handle)?.DNS) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Handle> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"DNS", _properties[0]}
			}, "Handle",
		() => new Handle(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Provider
/// </summary>
public partial class Provider (string Id="Provider") : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



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
			(IBinding data, string? value) => {(data as Provider)!.Signup = value; },
			(IBinding data) => (data as Provider)?.Signup) {
				},
		new FrameText ("Crosspost",
			(IBinding data, string? value) => {(data as Provider)!.Crosspost = value; },
			(IBinding data) => (data as Provider)?.Crosspost) {
				},
		new FrameString ("Title",
			(IBinding data, string? value) => {(data as Provider)!.Title = value; },
			(IBinding data) => (data as Provider)?.Title) {
				},
		new FrameString ("Text",
			(IBinding data, string? value) => {(data as Provider)!.Text = value; },
			(IBinding data) => (data as Provider)?.Text) {
				},
		new FrameIcon ("Logo")
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameText ("Signup",
			(IBinding data, string? value) => {(data as Provider)!.Signup = value; },
			(IBinding data) => (data as Provider)?.Signup) {
				},
		new FrameText ("Crosspost",
			(IBinding data, string? value) => {(data as Provider)!.Crosspost = value; },
			(IBinding data) => (data as Provider)?.Crosspost) {
				},
		new FrameString ("Title",
			(IBinding data, string? value) => {(data as Provider)!.Title = value; },
			(IBinding data) => (data as Provider)?.Title) {
				},
		new FrameString ("Text",
			(IBinding data, string? value) => {(data as Provider)!.Text = value; },
			(IBinding data) => (data as Provider)?.Text) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Provider> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Signup", _properties[0]},
			{"Crosspost", _properties[1]},
			{"Title", _properties[2]},
			{"Text", _properties[3]}
			}, "Provider",
		() => new Provider(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for User
/// </summary>
public partial class User (string Id="User") : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



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


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as User)!.Uid = value; },
			(IBinding data) => (data as User)?.Uid) {
				},
		new FrameAvatar ("Avatar"){
			Prompt = null,
			Get = (IBinding data) => (data as User)?.Avatar },
		new FrameString ("DisplayName",
			(IBinding data, string? value) => {(data as User)!.DisplayName = value; },
			(IBinding data) => (data as User)?.DisplayName) {
				},
		new FrameString ("DisplayHandle",
			(IBinding data, string? value) => {(data as User)!.DisplayHandle = value; },
			(IBinding data) => (data as User)?.DisplayHandle) {
				},
		new FrameBoolean ("Banned",
			(IBinding data, bool? value) => {(data as User)!.Banned = value; },
			(IBinding data) => (data as User)?.Banned) {
				},
		new FrameDateTime ("Suspended",
			(IBinding data, System.DateTime? value) => {(data as User)!.Suspended = value; },
			(IBinding data) => (data as User)?.Suspended) {
				},
		new FrameRefList<Group> ("Groups","Group"){
			Get = (IBacked data) => (data as User)?.Groups ,
			Set = (IBacked data, Object? value) => {(data as User)!.Groups = value as List<Group>; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as User)!.Uid = value; },
			(IBinding data) => (data as User)?.Uid) {
				},
		new FrameString ("DisplayName",
			(IBinding data, string? value) => {(data as User)!.DisplayName = value; },
			(IBinding data) => (data as User)?.DisplayName) {
				},
		new FrameString ("DisplayHandle",
			(IBinding data, string? value) => {(data as User)!.DisplayHandle = value; },
			(IBinding data) => (data as User)?.DisplayHandle) {
				},
		new FrameBoolean ("Banned",
			(IBinding data, bool? value) => {(data as User)!.Banned = value; },
			(IBinding data) => (data as User)?.Banned) {
				},
		new FrameDateTime ("Suspended",
			(IBinding data, System.DateTime? value) => {(data as User)!.Suspended = value; },
			(IBinding data) => (data as User)?.Suspended) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<User> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Uid", _properties[0]},
			{"DisplayName", _properties[1]},
			{"DisplayHandle", _properties[2]},
			{"Banned", _properties[3]},
			{"Suspended", _properties[4]}
			}, "User",
		() => new User(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Group
/// </summary>
public partial class Group (string Id="Group") : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Uid</summary>
	public string? Uid {get; set;}

    /// <summary>Field Name</summary>
	public string? Name {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as Group)!.Uid = value; },
			(IBinding data) => (data as Group)?.Uid) {
				},
		new FrameString ("Name",
			(IBinding data, string? value) => {(data as Group)!.Name = value; },
			(IBinding data) => (data as Group)?.Name) {
				},
		new FrameIcon ("Icon")
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as Group)!.Uid = value; },
			(IBinding data) => (data as Group)?.Uid) {
				},
		new FrameString ("Name",
			(IBinding data, string? value) => {(data as Group)!.Name = value; },
			(IBinding data) => (data as Group)?.Name) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Group> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Uid", _properties[0]},
			{"Name", _properties[1]}
			}, "Group",
		() => new Group(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Rights
/// </summary>
public partial class Rights (string Id="Rights") : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field GroupUid</summary>
	public string? GroupUid {get; set;}

    /// <summary>Field Grant</summary>
	public Privileges? Grant {get; set;}

    /// <summary>Field Deny</summary>
	public Privileges? Deny {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("GroupUid",
			(IBinding data, string? value) => {(data as Rights)!.GroupUid = value; },
			(IBinding data) => (data as Rights)?.GroupUid) {
				},
		new FrameRefClass<Privileges> ("Grant","Privileges"){
			Get = (IBacked data) => (data as Rights)?.Grant ,
			Set = (IBacked data, IBacked? value) => {(data as Rights)!.Grant = value as Privileges; }},
		new FrameRefClass<Privileges> ("Deny","Privileges"){
			Get = (IBacked data) => (data as Rights)?.Deny ,
			Set = (IBacked data, IBacked? value) => {(data as Rights)!.Deny = value as Privileges; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("GroupUid",
			(IBinding data, string? value) => {(data as Rights)!.GroupUid = value; },
			(IBinding data) => (data as Rights)?.GroupUid) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Rights> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"GroupUid", _properties[0]}
			}, "Rights",
		() => new Rights(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Access
/// </summary>
public partial class Access (string Id="Access") : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



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
			(IBinding data, bool? value) => {(data as Access)!.Create = value; },
			(IBinding data) => (data as Access)?.Create) {
				},
		new FrameBoolean ("Read",
			(IBinding data, bool? value) => {(data as Access)!.Read = value; },
			(IBinding data) => (data as Access)?.Read) {
				},
		new FrameBoolean ("Edit",
			(IBinding data, bool? value) => {(data as Access)!.Edit = value; },
			(IBinding data) => (data as Access)?.Edit) {
				},
		new FrameBoolean ("Delete",
			(IBinding data, bool? value) => {(data as Access)!.Delete = value; },
			(IBinding data) => (data as Access)?.Delete) {
				},
		new FrameBoolean ("Owner",
			(IBinding data, bool? value) => {(data as Access)!.Owner = value; },
			(IBinding data) => (data as Access)?.Owner) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameBoolean ("Create",
			(IBinding data, bool? value) => {(data as Access)!.Create = value; },
			(IBinding data) => (data as Access)?.Create) {
				},
		new FrameBoolean ("Read",
			(IBinding data, bool? value) => {(data as Access)!.Read = value; },
			(IBinding data) => (data as Access)?.Read) {
				},
		new FrameBoolean ("Edit",
			(IBinding data, bool? value) => {(data as Access)!.Edit = value; },
			(IBinding data) => (data as Access)?.Edit) {
				},
		new FrameBoolean ("Delete",
			(IBinding data, bool? value) => {(data as Access)!.Delete = value; },
			(IBinding data) => (data as Access)?.Delete) {
				},
		new FrameBoolean ("Owner",
			(IBinding data, bool? value) => {(data as Access)!.Owner = value; },
			(IBinding data) => (data as Access)?.Owner) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Access> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Create", _properties[0]},
			{"Read", _properties[1]},
			{"Edit", _properties[2]},
			{"Delete", _properties[3]},
			{"Owner", _properties[4]}
			}, "Access",
		() => new Access(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Privileges
/// </summary>
public partial class Privileges (string Id="Privileges") : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



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
			Get = (IBacked data) => (data as Privileges)?.Places ,
			Set = (IBacked data, IBacked? value) => {(data as Privileges)!.Places = value as Access; }},
		new FrameRefClass<Access> ("Topics","Access"){
			Get = (IBacked data) => (data as Privileges)?.Topics ,
			Set = (IBacked data, IBacked? value) => {(data as Privileges)!.Topics = value as Access; }},
		new FrameRefClass<Access> ("Threads","Access"){
			Get = (IBacked data) => (data as Privileges)?.Threads ,
			Set = (IBacked data, IBacked? value) => {(data as Privileges)!.Threads = value as Access; }},
		new FrameRefClass<Access> ("Others","Access"){
			Get = (IBacked data) => (data as Privileges)?.Others ,
			Set = (IBacked data, IBacked? value) => {(data as Privileges)!.Others = value as Access; }},
		new FrameRefClass<Access> ("Self","Access"){
			Get = (IBacked data) => (data as Privileges)?.Self ,
			Set = (IBacked data, IBacked? value) => {(data as Privileges)!.Self = value as Access; }}
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
	static readonly new Binding<Privileges> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "Privileges",
		() => new Privileges(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Entry
/// </summary>
public partial class Entry (string Id="Entry") : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

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
	public static FramePresentation Brief => brief ?? new FramePresentation ("Brief") {
		GetUid = (IBacked data) => (data as Entry)?.Uid,
		Sections = [
			new FrameSection ("Title") {
				Fields = [
            		new FrameDateTime ("Created",
            			(IBinding data, System.DateTime? value) => {(data as Entry)!.Created = value; },
            			(IBinding data) => (data as Entry)?.Created) {
            				}
					]
				},
			new FrameSection ("Body") {
				Fields = [
            		new FrameText ("Text",
            			(IBinding data, string? value) => {(data as Entry)!.Text = value; },
            			(IBinding data) => (data as Entry)?.Text) {
            				}
					]
				}
			]
		}.CacheValue(out brief)!;
	static FramePresentation? brief;

	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as Entry)!.Uid = value; },
			(IBinding data) => (data as Entry)?.Uid) {
				Hidden = true
				},
		new FrameString ("Semantic",
			(IBinding data, string? value) => {(data as Entry)!.Semantic = value; },
			(IBinding data) => (data as Entry)?.Semantic) {
				Hidden = true
				},
		new FrameRefList<Rights> ("Rights","Rights"){
			Get = (IBacked data) => (data as Entry)?.Rights ,
			Set = (IBacked data, Object? value) => {(data as Entry)!.Rights = value as List<Rights>; }},
		new FrameDateTime ("Created",
			(IBinding data, System.DateTime? value) => {(data as Entry)!.Created = value; },
			(IBinding data) => (data as Entry)?.Created) {
				},
		Brief
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as Entry)!.Uid = value; },
			(IBinding data) => (data as Entry)?.Uid) {
				Hidden = true
				},
		new FrameString ("Semantic",
			(IBinding data, string? value) => {(data as Entry)!.Semantic = value; },
			(IBinding data) => (data as Entry)?.Semantic) {
				Hidden = true
				},
		new FrameDateTime ("Created",
			(IBinding data, System.DateTime? value) => {(data as Entry)!.Created = value; },
			(IBinding data) => (data as Entry)?.Created) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Entry> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Uid", _properties[0]},
			{"Semantic", _properties[1]},
			{"Created", _properties[2]}
			}, "Entry",
		() => new Entry(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Place
/// </summary>
public partial class Place (string Id="Place") : Entry (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

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

    /// <summary>Field Topics</summary>
	public List<Topic>? Topics {get; set;}


	/// <summary>
	/// Presentation style PlaceReference
	/// </summary>
	public static FramePresentation PlaceReference => placereference ?? new FramePresentation ("PlaceReference") {
		GetUid = (IBacked data) => (data as Place)?.Uid,
		Sections = [
			new FrameSection ("Title") {
				Fields = [
            		new FrameString ("Title",
            			(IBinding data, string? value) => {(data as Place)!.Title = value; },
            			(IBinding data) => (data as Place)?.Title) {
            				},
            		new FrameString ("DNS",
            			(IBinding data, string? value) => {(data as Place)!.DNS = value; },
            			(IBinding data) => (data as Place)?.DNS) {
            				}
					]
				},
			new FrameSection ("Avatar") {
				Fields = [
            		new FrameAvatar ("Avatar"){
            			Prompt = null,
            			Get = (IBinding data) => (data as Place)?.Avatar }
					]
				},
			new FrameSection ("Banner") {
				Fields = [
            		new FrameImage ("Banner",
            			(IBinding data, string? value) => {(data as Place)!.Banner = value; },
            			(IBinding data) => (data as Place)?.Banner) {
            				}
					]
				},
			new FrameSection ("Body") {
				Fields = [
            		new FrameText ("Description",
            			(IBinding data, string? value) => {(data as Place)!.Description = value; },
            			(IBinding data) => (data as Place)?.Description) {
            				}
					]
				}
			]
		}.CacheValue(out placereference)!;
	static FramePresentation? placereference;

	/// <summary>
	/// Presentation style PlaceBanner
	/// </summary>
	public static FramePresentation PlaceBanner => placebanner ?? new FramePresentation ("PlaceBanner") {
		GetUid = (IBacked data) => (data as Place)?.Uid,
		Sections = [
			new FrameSection ("Title") {
				Fields = [
            		new FrameAnchor ("TitleLink",
            			(IBinding data, BackingTypeLink? value) => {(data as Place)!.TitleLink = value; },
            			(IBinding data) => (data as Place)?.TitleLink) {
            				},
            		new FrameAnchor ("HandleLink",
            			(IBinding data, BackingTypeLink? value) => {(data as Place)!.HandleLink = value; },
            			(IBinding data) => (data as Place)?.HandleLink) {
            				}
					]
				},
			new FrameSection ("Avatar") {
				Fields = [
            		new FrameAvatar ("Avatar"){
            			Prompt = null,
            			Get = (IBinding data) => (data as Place)?.Avatar }
					]
				},
			new FrameSection ("Banner") {
				Fields = [
            		new FrameImage ("Banner",
            			(IBinding data, string? value) => {(data as Place)!.Banner = value; },
            			(IBinding data) => (data as Place)?.Banner) {
            				}
					]
				},
			new FrameSection ("Body") {
				Fields = [
            		new FrameText ("Description",
            			(IBinding data, string? value) => {(data as Place)!.Description = value; },
            			(IBinding data) => (data as Place)?.Description) {
            				}
					]
				}
			]
		}.CacheValue(out placebanner)!;
	static FramePresentation? placebanner;

	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as Entry)!.Uid = value; },
			(IBinding data) => (data as Entry)?.Uid) {
				Hidden = true
				},
		new FrameString ("Semantic",
			(IBinding data, string? value) => {(data as Entry)!.Semantic = value; },
			(IBinding data) => (data as Entry)?.Semantic) {
				Hidden = true
				},
		new FrameRefList<Rights> ("Rights","Rights"){
			Get = (IBacked data) => (data as Entry)?.Rights ,
			Set = (IBacked data, Object? value) => {(data as Entry)!.Rights = value as List<Rights>; }},
		new FrameDateTime ("Created",
			(IBinding data, System.DateTime? value) => {(data as Entry)!.Created = value; },
			(IBinding data) => (data as Entry)?.Created) {
				},
		Brief,
		new FrameString ("DNS",
			(IBinding data, string? value) => {(data as Place)!.DNS = value; },
			(IBinding data) => (data as Place)?.DNS) {
				Prompt = "DNS Address",
				Description = "Can be any DNS name that is resolved to the service."
				},
		new FrameString ("Title",
			(IBinding data, string? value) => {(data as Place)!.Title = value; },
			(IBinding data) => (data as Place)?.Title) {
				Prompt = "Name"
				},
		new FrameText ("Description",
			(IBinding data, string? value) => {(data as Place)!.Description = value; },
			(IBinding data) => (data as Place)?.Description) {
				Prompt = "Description"
				},
		new FrameAvatar ("Avatar"){
			Prompt = "Avatar Image",
			Get = (IBinding data) => (data as Place)?.Avatar },
		new FrameImage ("Banner",
			(IBinding data, string? value) => {(data as Place)!.Banner = value; },
			(IBinding data) => (data as Place)?.Banner) {
				Prompt = "Banner Image"
				},
		new FrameRefList<Rights> ("RightsTopics","Rights"){
			Get = (IBacked data) => (data as Place)?.RightsTopics ,
			Set = (IBacked data, Object? value) => {(data as Place)!.RightsTopics = value as List<Rights>; }},
		new FrameRefList<Rights> ("RightsThreads","Rights"){
			Get = (IBacked data) => (data as Place)?.RightsThreads ,
			Set = (IBacked data, Object? value) => {(data as Place)!.RightsThreads = value as List<Rights>; }},
		new FrameRefList<Rights> ("RightsComments","Rights"){
			Get = (IBacked data) => (data as Place)?.RightsComments ,
			Set = (IBacked data, Object? value) => {(data as Place)!.RightsComments = value as List<Rights>; }},
		new FrameRefList<Topic> ("Topics","Topic"){
			Get = (IBacked data) => (data as Place)?.Topics ,
			Set = (IBacked data, Object? value) => {(data as Place)!.Topics = value as List<Topic>; }},
		PlaceReference,
		PlaceBanner
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("DNS",
			(IBinding data, string? value) => {(data as Place)!.DNS = value; },
			(IBinding data) => (data as Place)?.DNS) {
				Prompt = "DNS Address",
				Description = "Can be any DNS name that is resolved to the service."
				},
		new FrameString ("Title",
			(IBinding data, string? value) => {(data as Place)!.Title = value; },
			(IBinding data) => (data as Place)?.Title) {
				Prompt = "Name"
				},
		new FrameText ("Description",
			(IBinding data, string? value) => {(data as Place)!.Description = value; },
			(IBinding data) => (data as Place)?.Description) {
				Prompt = "Description"
				},
		new FrameImage ("Banner",
			(IBinding data, string? value) => {(data as Place)!.Banner = value; },
			(IBinding data) => (data as Place)?.Banner) {
				Prompt = "Banner Image"
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Place> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"DNS", _properties[0]},
			{"Title", _properties[1]},
			{"Description", _properties[2]},
			{"Banner", _properties[3]}
			}, "Place",
		() => new Place(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Topic
/// </summary>
public partial class Topic (string Id="Topic") : Entry (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Title</summary>
	public string? Title {get; set;}

    /// <summary>Field Posts</summary>
	public List<Post>? Posts {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as Entry)!.Uid = value; },
			(IBinding data) => (data as Entry)?.Uid) {
				Hidden = true
				},
		new FrameString ("Semantic",
			(IBinding data, string? value) => {(data as Entry)!.Semantic = value; },
			(IBinding data) => (data as Entry)?.Semantic) {
				Hidden = true
				},
		new FrameRefList<Rights> ("Rights","Rights"){
			Get = (IBacked data) => (data as Entry)?.Rights ,
			Set = (IBacked data, Object? value) => {(data as Entry)!.Rights = value as List<Rights>; }},
		new FrameDateTime ("Created",
			(IBinding data, System.DateTime? value) => {(data as Entry)!.Created = value; },
			(IBinding data) => (data as Entry)?.Created) {
				},
		Brief,
		new FrameString ("Title",
			(IBinding data, string? value) => {(data as Topic)!.Title = value; },
			(IBinding data) => (data as Topic)?.Title) {
				},
		new FrameRefList<Post> ("Posts","Post"){
			Get = (IBacked data) => (data as Topic)?.Posts ,
			Set = (IBacked data, Object? value) => {(data as Topic)!.Posts = value as List<Post>; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Title",
			(IBinding data, string? value) => {(data as Topic)!.Title = value; },
			(IBinding data) => (data as Topic)?.Title) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Topic> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Title", _properties[0]}
			}, "Topic",
		() => new Topic(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Post
/// </summary>
public partial class Post (string Id="Post") : Entry (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

    /// <inheritdoc/>
    public override FramePresentation Presentation => PostSummary;


    /// <summary>Field User</summary>
	public User? User {get; set;}

    /// <summary>Field Title</summary>
	public string? Title {get; set;}

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
	public static FramePresentation PostSummary => postsummary ?? new FramePresentation ("PostSummary") {
		GetUid = (IBacked data) => (data as Post)?.Uid,
		Sections = [
			new FrameSection ("Avatar") {
				Fields = [
            		new FrameAvatar ("User.Avatar"){
            			Prompt = null,
            			Get = (IBinding data) => (data as Post)?.User?.Avatar }
					]
				},
			new FrameSection ("Author") {
				Fields = [
            		new FrameString ("User.DisplayName",
            			(IBinding data, string? value) => {(data as Post)!.User!.DisplayName = value; },
            			(IBinding data) => (data as Post)?.User?.DisplayName) {
            				},
            		new FrameString ("User.DisplayHandle",
            			(IBinding data, string? value) => {(data as Post)!.User!.DisplayHandle = value; },
            			(IBinding data) => (data as Post)?.User?.DisplayHandle) {
            				},
            		new FrameDateTime ("Created",
            			(IBinding data, System.DateTime? value) => {(data as Post)!.Created = value; },
            			(IBinding data) => (data as Post)?.Created) {
            				}
					]
				},
			new FrameSection ("Rule") {
				Fields = [
					]
				},
			new FrameSection ("Body") {
				Fields = [
            		new FrameString ("Title",
            			(IBinding data, string? value) => {(data as Post)!.Title = value; },
            			(IBinding data) => (data as Post)?.Title) {
            				},
            		new FrameText ("Summary",
            			(IBinding data, string? value) => {(data as Post)!.Summary = value; },
            			(IBinding data) => (data as Post)?.Summary) {
            				}
					]
				}
			]
		}.CacheValue(out postsummary)!;
	static FramePresentation? postsummary;

	/// <summary>
	/// Presentation style PostFull
	/// </summary>
	public static FramePresentation PostFull => postfull ?? new FramePresentation ("PostFull") {
		GetUid = (IBacked data) => (data as Post)?.Uid,
		Sections = [
			new FrameSection ("Avatar") {
				Fields = [
            		new FrameAvatar ("User.Avatar"){
            			Prompt = null,
            			Get = (IBinding data) => (data as Post)?.User?.Avatar }
					]
				},
			new FrameSection ("Author") {
				Fields = [
            		new FrameString ("User.DisplayName",
            			(IBinding data, string? value) => {(data as Post)!.User!.DisplayName = value; },
            			(IBinding data) => (data as Post)?.User?.DisplayName) {
            				},
            		new FrameString ("User.DisplayHandle",
            			(IBinding data, string? value) => {(data as Post)!.User!.DisplayHandle = value; },
            			(IBinding data) => (data as Post)?.User?.DisplayHandle) {
            				},
            		new FrameDateTime ("Created",
            			(IBinding data, System.DateTime? value) => {(data as Post)!.Created = value; },
            			(IBinding data) => (data as Post)?.Created) {
            				}
					]
				},
			new FrameSection ("Rule") {
				Fields = [
					]
				},
			new FrameSection ("Summary") {
				Fields = [
            		new FrameString ("Title",
            			(IBinding data, string? value) => {(data as Post)!.Title = value; },
            			(IBinding data) => (data as Post)?.Title) {
            				},
            		new FrameText ("Summary",
            			(IBinding data, string? value) => {(data as Post)!.Summary = value; },
            			(IBinding data) => (data as Post)?.Summary) {
            				}
					]
				},
			new FrameSection ("Body") {
				Fields = [
            		new FrameRichText ("Body",
            			(IBinding data, string? value) => {(data as Post)!.Body = value; },
            			(IBinding data) => (data as Post)?.Body) {
            				}
					]
				},
			new FrameSection ("Detail") {
				Fields = [
            		new FrameDateTime ("Created",
            			(IBinding data, System.DateTime? value) => {(data as Post)!.Created = value; },
            			(IBinding data) => (data as Post)?.Created) {
            				},
            		new FrameString ("Replies",
            			(IBinding data, string? value) => {(data as Post)!.Replies = value; },
            			(IBinding data) => (data as Post)?.Replies) {
            				}
					]
				},
			new FrameSection ("Responses") {
				Fields = [
            		new FrameButton ("Comment", "Comment", "CommentAction") {
            			GetInteger = (IBinding data) => (data as Post)?.Comments
            			},
            		new FrameSubmenu ("Repost", "Repost") {
            			Fields = [
                    		new FrameButton ("Repost", "Repost", "RepostAction") {
                    			},
                    		new FrameButton ("QuotePost", "Quote Post", "QuotePostAction") {
                    			}
            				]
            			},
            		new FrameButton ("Like", "Like", "LikeAction") {
            			GetActive = (IBinding data) => (data as Post)?.Liked,
            			GetInteger = (IBinding data) => (data as Post)?.Likes
            			},
            		new FrameButton ("SeeMore", "More", "MoreAction") {
            			GetActive = (IBinding data) => (data as Post)?.RequestedMore
            			},
            		new FrameButton ("SeeLess", "Less", "LessAction") {
            			GetActive = (IBinding data) => (data as Post)?.RequestedLess
            			},
            		new FrameSubmenu ("Share", "Share") {
            			Fields = [
                    		new FrameButton ("LinkCopy", "Copy link to post", "HomePage") {
                    			},
                    		new FrameButton ("SendByDM", "Send via direct message", "HomePage") {
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
                    			},
                    		new FrameButton ("BlockAccount", "Block user", "BlockAccountAction") {
                    			},
                    		new FrameButton ("Report", "Report post", "ReportPostAction") {
                    			}
            				]
            			}
					]
				}
			]
		}.CacheValue(out postfull)!;
	static FramePresentation? postfull;

	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as Entry)!.Uid = value; },
			(IBinding data) => (data as Entry)?.Uid) {
				Hidden = true
				},
		new FrameString ("Semantic",
			(IBinding data, string? value) => {(data as Entry)!.Semantic = value; },
			(IBinding data) => (data as Entry)?.Semantic) {
				Hidden = true
				},
		new FrameRefList<Rights> ("Rights","Rights"){
			Get = (IBacked data) => (data as Entry)?.Rights ,
			Set = (IBacked data, Object? value) => {(data as Entry)!.Rights = value as List<Rights>; }},
		new FrameDateTime ("Created",
			(IBinding data, System.DateTime? value) => {(data as Entry)!.Created = value; },
			(IBinding data) => (data as Entry)?.Created) {
				},
		Brief,
		new FrameRefClass<User> ("User","User"){
			Get = (IBacked data) => (data as Post)?.User ,
			Set = (IBacked data, IBacked? value) => {(data as Post)!.User = value as User; }},
		new FrameString ("Title",
			(IBinding data, string? value) => {(data as Post)!.Title = value; },
			(IBinding data) => (data as Post)?.Title) {
				Prompt = "Title"
				},
		new FrameText ("Summary",
			(IBinding data, string? value) => {(data as Post)!.Summary = value; },
			(IBinding data) => (data as Post)?.Summary) {
				Prompt = "Summary"
				},
		new FrameRichText ("Body",
			(IBinding data, string? value) => {(data as Post)!.Body = value; },
			(IBinding data) => (data as Post)?.Body) {
				Prompt = "Body"
				},
		new FrameRefList<Resource> ("Resources","Resource"){
			Get = (IBacked data) => (data as Post)?.Resources ,
			Set = (IBacked data, Object? value) => {(data as Post)!.Resources = value as List<Resource>; }},
		new FrameString ("Replies",
			(IBinding data, string? value) => {(data as Post)!.Replies = value; },
			(IBinding data) => (data as Post)?.Replies) {
				},
		new FrameInteger ("Comments",
			(IBinding data, int? value) => {(data as Post)!.Comments = value; },
			(IBinding data) => (data as Post)?.Comments) {
				},
		new FrameInteger ("Likes",
			(IBinding data, int? value) => {(data as Post)!.Likes = value; },
			(IBinding data) => (data as Post)?.Likes) {
				},
		PostSummary,
		PostFull
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Title",
			(IBinding data, string? value) => {(data as Post)!.Title = value; },
			(IBinding data) => (data as Post)?.Title) {
				Prompt = "Title"
				},
		new FrameText ("Summary",
			(IBinding data, string? value) => {(data as Post)!.Summary = value; },
			(IBinding data) => (data as Post)?.Summary) {
				Prompt = "Summary"
				},
		new FrameRichText ("Body",
			(IBinding data, string? value) => {(data as Post)!.Body = value; },
			(IBinding data) => (data as Post)?.Body) {
				Prompt = "Body"
				},
		new FrameString ("Replies",
			(IBinding data, string? value) => {(data as Post)!.Replies = value; },
			(IBinding data) => (data as Post)?.Replies) {
				},
		new FrameInteger ("Comments",
			(IBinding data, int? value) => {(data as Post)!.Comments = value; },
			(IBinding data) => (data as Post)?.Comments) {
				},
		new FrameInteger ("Likes",
			(IBinding data, int? value) => {(data as Post)!.Likes = value; },
			(IBinding data) => (data as Post)?.Likes) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Post> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Title", _properties[0]},
			{"Summary", _properties[1]},
			{"Body", _properties[2]},
			{"Replies", _properties[3]},
			{"Comments", _properties[4]},
			{"Likes", _properties[5]}
			}, "Post",
		() => new Post(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Comment
/// </summary>
public partial class Comment (string Id="Comment") : Entry (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

    /// <inheritdoc/>
    public override FramePresentation Presentation => CommentFull;


    /// <summary>Field User</summary>
	public User? User {get; set;}

    /// <summary>Field Text</summary>
	public string? Text {get; set;}

    /// <summary>Field Resources</summary>
	public Resource? Resources {get; set;}


	/// <summary>
	/// Presentation style CommentFull
	/// </summary>
	public static FramePresentation CommentFull => commentfull ?? new FramePresentation ("CommentFull") {
		GetUid = (IBacked data) => (data as Comment)?.Uid,
		Sections = [
			new FrameSection ("Avatar") {
				Fields = [
            		new FrameAvatar ("User.Avatar"){
            			Prompt = null,
            			Get = (IBinding data) => (data as Comment)?.User?.Avatar }
					]
				},
			new FrameSection ("Author") {
				Fields = [
            		new FrameString ("User.DisplayName",
            			(IBinding data, string? value) => {(data as Comment)!.User!.DisplayName = value; },
            			(IBinding data) => (data as Comment)?.User?.DisplayName) {
            				},
            		new FrameString ("User.DisplayHandle",
            			(IBinding data, string? value) => {(data as Comment)!.User!.DisplayHandle = value; },
            			(IBinding data) => (data as Comment)?.User?.DisplayHandle) {
            				},
            		new FrameDateTime ("Created",
            			(IBinding data, System.DateTime? value) => {(data as Comment)!.Created = value; },
            			(IBinding data) => (data as Comment)?.Created) {
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
            			(IBinding data, string? value) => {(data as Comment)!.Text = value; },
            			(IBinding data) => (data as Comment)?.Text) {
            				}
					]
				}
			]
		}.CacheValue(out commentfull)!;
	static FramePresentation? commentfull;

	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as Entry)!.Uid = value; },
			(IBinding data) => (data as Entry)?.Uid) {
				Hidden = true
				},
		new FrameString ("Semantic",
			(IBinding data, string? value) => {(data as Entry)!.Semantic = value; },
			(IBinding data) => (data as Entry)?.Semantic) {
				Hidden = true
				},
		new FrameRefList<Rights> ("Rights","Rights"){
			Get = (IBacked data) => (data as Entry)?.Rights ,
			Set = (IBacked data, Object? value) => {(data as Entry)!.Rights = value as List<Rights>; }},
		new FrameDateTime ("Created",
			(IBinding data, System.DateTime? value) => {(data as Entry)!.Created = value; },
			(IBinding data) => (data as Entry)?.Created) {
				},
		Brief,
		new FrameRefClass<User> ("User","User"){
			Get = (IBacked data) => (data as Comment)?.User ,
			Set = (IBacked data, IBacked? value) => {(data as Comment)!.User = value as User; }},
		new FrameText ("Text",
			(IBinding data, string? value) => {(data as Comment)!.Text = value; },
			(IBinding data) => (data as Comment)?.Text) {
				},
		new FrameRefClass<Resource> ("Resources","Resource"){
			Get = (IBacked data) => (data as Comment)?.Resources ,
			Set = (IBacked data, IBacked? value) => {(data as Comment)!.Resources = value as Resource; }},
		CommentFull
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameText ("Text",
			(IBinding data, string? value) => {(data as Comment)!.Text = value; },
			(IBinding data) => (data as Comment)?.Text) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Comment> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Text", _properties[0]}
			}, "Comment",
		() => new Comment(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Resource
/// </summary>
public partial class Resource (string Id="Resource") : Entry (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Title</summary>
	public string? Title {get; set;}

    /// <summary>Field Size</summary>
	public int? Size {get; set;}

    /// <summary>Field Type</summary>
	public string? Type {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as Entry)!.Uid = value; },
			(IBinding data) => (data as Entry)?.Uid) {
				Hidden = true
				},
		new FrameString ("Semantic",
			(IBinding data, string? value) => {(data as Entry)!.Semantic = value; },
			(IBinding data) => (data as Entry)?.Semantic) {
				Hidden = true
				},
		new FrameRefList<Rights> ("Rights","Rights"){
			Get = (IBacked data) => (data as Entry)?.Rights ,
			Set = (IBacked data, Object? value) => {(data as Entry)!.Rights = value as List<Rights>; }},
		new FrameDateTime ("Created",
			(IBinding data, System.DateTime? value) => {(data as Entry)!.Created = value; },
			(IBinding data) => (data as Entry)?.Created) {
				},
		Brief,
		new FrameString ("Title",
			(IBinding data, string? value) => {(data as Resource)!.Title = value; },
			(IBinding data) => (data as Resource)?.Title) {
				},
		new FrameInteger ("Size",
			(IBinding data, int? value) => {(data as Resource)!.Size = value; },
			(IBinding data) => (data as Resource)?.Size) {
				},
		new FrameString ("Type",
			(IBinding data, string? value) => {(data as Resource)!.Type = value; },
			(IBinding data) => (data as Resource)?.Type) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Title",
			(IBinding data, string? value) => {(data as Resource)!.Title = value; },
			(IBinding data) => (data as Resource)?.Title) {
				},
		new FrameInteger ("Size",
			(IBinding data, int? value) => {(data as Resource)!.Size = value; },
			(IBinding data) => (data as Resource)?.Size) {
				},
		new FrameString ("Type",
			(IBinding data, string? value) => {(data as Resource)!.Type = value; },
			(IBinding data) => (data as Resource)?.Type) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Resource> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Title", _properties[0]},
			{"Size", _properties[1]},
			{"Type", _properties[2]}
			}, "Resource",
		() => new Resource(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Contact
/// </summary>
public partial class Contact (string Id="Contact") : Entry (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



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
			(IBinding data, string? value) => {(data as Entry)!.Uid = value; },
			(IBinding data) => (data as Entry)?.Uid) {
				Hidden = true
				},
		new FrameString ("Semantic",
			(IBinding data, string? value) => {(data as Entry)!.Semantic = value; },
			(IBinding data) => (data as Entry)?.Semantic) {
				Hidden = true
				},
		new FrameRefList<Rights> ("Rights","Rights"){
			Get = (IBacked data) => (data as Entry)?.Rights ,
			Set = (IBacked data, Object? value) => {(data as Entry)!.Rights = value as List<Rights>; }},
		new FrameDateTime ("Created",
			(IBinding data, System.DateTime? value) => {(data as Entry)!.Created = value; },
			(IBinding data) => (data as Entry)?.Created) {
				},
		Brief,
		new FrameDateTime ("Updated",
			(IBinding data, System.DateTime? value) => {(data as Contact)!.Updated = value; },
			(IBinding data) => (data as Contact)?.Updated) {
				Description = "Time of last contact update"
				},
		new FrameRefClass<User> ("User","User"){
			Get = (IBacked data) => (data as Contact)?.User ,
			Set = (IBacked data, IBacked? value) => {(data as Contact)!.User = value as User; }},
		new FrameRefClass<Name> ("Name","Name"){
			Get = (IBacked data) => (data as Contact)?.Name ,
			Set = (IBacked data, IBacked? value) => {(data as Contact)!.Name = value as Name; }},
		new FrameRefList<Name> ("AltNames","Name"){
			Get = (IBacked data) => (data as Contact)?.AltNames ,
			Set = (IBacked data, Object? value) => {(data as Contact)!.AltNames = value as List<Name>; }},
		new FrameRefList<Name> ("NickNames","Name"){
			Get = (IBacked data) => (data as Contact)?.NickNames ,
			Set = (IBacked data, Object? value) => {(data as Contact)!.NickNames = value as List<Name>; }},
		new FrameRefList<Organization> ("Organization","Organization"){
			Get = (IBacked data) => (data as Contact)?.Organization ,
			Set = (IBacked data, Object? value) => {(data as Contact)!.Organization = value as List<Organization>; }},
		new FrameRefClass<Pronouns> ("Pronouns","Pronouns"){
			Get = (IBacked data) => (data as Contact)?.Pronouns ,
			Set = (IBacked data, IBacked? value) => {(data as Contact)!.Pronouns = value as Pronouns; }},
		new FrameRefClass<RelatedTo> ("RelatedTo","RelatedTo"){
			Get = (IBacked data) => (data as Contact)?.RelatedTo ,
			Set = (IBacked data, IBacked? value) => {(data as Contact)!.RelatedTo = value as RelatedTo; }},
		new FrameRef ("Addresses"),
		new FrameRefList<Application> ("Applications","Application"){
			Get = (IBacked data) => (data as Contact)?.Applications ,
			Set = (IBacked data, Object? value) => {(data as Contact)!.Applications = value as List<Application>; }},
		new FrameRefList<Media> ("Media","Media"){
			Get = (IBacked data) => (data as Contact)?.Media ,
			Set = (IBacked data, Object? value) => {(data as Contact)!.Media = value as List<Media>; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameDateTime ("Updated",
			(IBinding data, System.DateTime? value) => {(data as Contact)!.Updated = value; },
			(IBinding data) => (data as Contact)?.Updated) {
				Description = "Time of last contact update"
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Contact> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Updated", _properties[0]}
			}, "Contact",
		() => new Contact(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Name
/// </summary>
public partial class Name (string Id="Name") : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



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
			(IBinding data, string? value) => {(data as Name)!.Full = value; },
			(IBinding data) => (data as Name)?.Full) {
				},
		new FrameRefList<TagValue> ("Components","TagValue"){
			Get = (IBacked data) => (data as Name)?.Components ,
			Set = (IBacked data, Object? value) => {(data as Name)!.Components = value as List<TagValue>; }},
		new FrameString ("PhoneticSystem",
			(IBinding data, string? value) => {(data as Name)!.PhoneticSystem = value; },
			(IBinding data) => (data as Name)?.PhoneticSystem) {
				},
		new FrameString ("PhoneticScript",
			(IBinding data, string? value) => {(data as Name)!.PhoneticScript = value; },
			(IBinding data) => (data as Name)?.PhoneticScript) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Full",
			(IBinding data, string? value) => {(data as Name)!.Full = value; },
			(IBinding data) => (data as Name)?.Full) {
				},
		new FrameString ("PhoneticSystem",
			(IBinding data, string? value) => {(data as Name)!.PhoneticSystem = value; },
			(IBinding data) => (data as Name)?.PhoneticSystem) {
				},
		new FrameString ("PhoneticScript",
			(IBinding data, string? value) => {(data as Name)!.PhoneticScript = value; },
			(IBinding data) => (data as Name)?.PhoneticScript) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Name> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Full", _properties[0]},
			{"PhoneticSystem", _properties[1]},
			{"PhoneticScript", _properties[2]}
			}, "Name",
		() => new Name(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for TagValue
/// </summary>
public partial class TagValue (string Id="TagValue") : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Tag</summary>
	public string? Tag {get; set;}

    /// <summary>Field Value</summary>
	public string? Value {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Tag",
			(IBinding data, string? value) => {(data as TagValue)!.Tag = value; },
			(IBinding data) => (data as TagValue)?.Tag) {
				},
		new FrameString ("Value",
			(IBinding data, string? value) => {(data as TagValue)!.Value = value; },
			(IBinding data) => (data as TagValue)?.Value) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Tag",
			(IBinding data, string? value) => {(data as TagValue)!.Tag = value; },
			(IBinding data) => (data as TagValue)?.Tag) {
				},
		new FrameString ("Value",
			(IBinding data, string? value) => {(data as TagValue)!.Value = value; },
			(IBinding data) => (data as TagValue)?.Value) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<TagValue> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Tag", _properties[0]},
			{"Value", _properties[1]}
			}, "TagValue",
		() => new TagValue(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Organization
/// </summary>
public partial class Organization (string Id="Organization") : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Name</summary>
	public string? Name {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Name",
			(IBinding data, string? value) => {(data as Organization)!.Name = value; },
			(IBinding data) => (data as Organization)?.Name) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Name",
			(IBinding data, string? value) => {(data as Organization)!.Name = value; },
			(IBinding data) => (data as Organization)?.Name) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Organization> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Name", _properties[0]}
			}, "Organization",
		() => new Organization(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Pronouns
/// </summary>
public partial class Pronouns (string Id="Pronouns") : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



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
			Get = (IBacked data) => (data as Pronouns)?.GramaticalGender ,
			Set = (IBacked data, Object? value) => {(data as Pronouns)!.GramaticalGender = value as List<Option>; }},
		new FrameString ("Subjective",
			(IBinding data, string? value) => {(data as Pronouns)!.Subjective = value; },
			(IBinding data) => (data as Pronouns)?.Subjective) {
				},
		new FrameString ("Objective",
			(IBinding data, string? value) => {(data as Pronouns)!.Objective = value; },
			(IBinding data) => (data as Pronouns)?.Objective) {
				},
		new FrameString ("Posessive",
			(IBinding data, string? value) => {(data as Pronouns)!.Posessive = value; },
			(IBinding data) => (data as Pronouns)?.Posessive) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Subjective",
			(IBinding data, string? value) => {(data as Pronouns)!.Subjective = value; },
			(IBinding data) => (data as Pronouns)?.Subjective) {
				},
		new FrameString ("Objective",
			(IBinding data, string? value) => {(data as Pronouns)!.Objective = value; },
			(IBinding data) => (data as Pronouns)?.Objective) {
				},
		new FrameString ("Posessive",
			(IBinding data, string? value) => {(data as Pronouns)!.Posessive = value; },
			(IBinding data) => (data as Pronouns)?.Posessive) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Pronouns> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Subjective", _properties[0]},
			{"Objective", _properties[1]},
			{"Posessive", _properties[2]}
			}, "Pronouns",
		() => new Pronouns(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Title
/// </summary>
public partial class Title (string Id="Title") : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Name</summary>
	public string? Name {get; set;}

    /// <summary>Field Organization</summary>
	public Organization? Organization {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Name",
			(IBinding data, string? value) => {(data as Title)!.Name = value; },
			(IBinding data) => (data as Title)?.Name) {
				},
		new FrameRefClass<Organization> ("Organization","Organization"){
			Get = (IBacked data) => (data as Title)?.Organization ,
			Set = (IBacked data, IBacked? value) => {(data as Title)!.Organization = value as Organization; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Name",
			(IBinding data, string? value) => {(data as Title)!.Name = value; },
			(IBinding data) => (data as Title)?.Name) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Title> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Name", _properties[0]}
			}, "Title",
		() => new Title(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for RelatedTo
/// </summary>
public partial class RelatedTo (string Id="RelatedTo") : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Uid</summary>
	public string? Uid {get; set;}

    /// <summary>Field Relation</summary>
	public List<Option>? Relation {get; set;}

    /// <summary>Field Other</summary>
	public string? Other {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as RelatedTo)!.Uid = value; },
			(IBinding data) => (data as RelatedTo)?.Uid) {
				Description = "URI of the related party"
				},
		new FrameRefList<Option> ("Relation","Option"){
			Get = (IBacked data) => (data as RelatedTo)?.Relation ,
			Set = (IBacked data, Object? value) => {(data as RelatedTo)!.Relation = value as List<Option>; }},
		new FrameString ("Other",
			(IBinding data, string? value) => {(data as RelatedTo)!.Other = value; },
			(IBinding data) => (data as RelatedTo)?.Other) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as RelatedTo)!.Uid = value; },
			(IBinding data) => (data as RelatedTo)?.Uid) {
				Description = "URI of the related party"
				},
		new FrameString ("Other",
			(IBinding data, string? value) => {(data as RelatedTo)!.Other = value; },
			(IBinding data) => (data as RelatedTo)?.Other) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<RelatedTo> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Uid", _properties[0]},
			{"Other", _properties[1]}
			}, "RelatedTo",
		() => new RelatedTo(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Application
/// </summary>
public partial class Application (string Id="Application") : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



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
			(IBinding data, string? value) => {(data as Application)!.ApplicationName = value; },
			(IBinding data) => (data as Application)?.ApplicationName) {
				},
		new FrameString ("Address",
			(IBinding data, string? value) => {(data as Application)!.Address = value; },
			(IBinding data) => (data as Application)?.Address) {
				Description = "The user identifier at the service"
				},
		new FrameRefList<Key> ("Keys","Key"){
			Get = (IBacked data) => (data as Application)?.Keys ,
			Set = (IBacked data, Object? value) => {(data as Application)!.Keys = value as List<Key>; }},
		new FrameInteger ("Preference",
			(IBinding data, int? value) => {(data as Application)!.Preference = value; },
			(IBinding data) => (data as Application)?.Preference) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("ApplicationName",
			(IBinding data, string? value) => {(data as Application)!.ApplicationName = value; },
			(IBinding data) => (data as Application)?.ApplicationName) {
				},
		new FrameString ("Address",
			(IBinding data, string? value) => {(data as Application)!.Address = value; },
			(IBinding data) => (data as Application)?.Address) {
				Description = "The user identifier at the service"
				},
		new FrameInteger ("Preference",
			(IBinding data, int? value) => {(data as Application)!.Preference = value; },
			(IBinding data) => (data as Application)?.Preference) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Application> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"ApplicationName", _properties[0]},
			{"Address", _properties[1]},
			{"Preference", _properties[2]}
			}, "Application",
		() => new Application(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Email
/// </summary>
public partial class Email (string Id="Email") : Application (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;




	static readonly List<IFrameField> _Fields = [
		new FrameString ("ApplicationName",
			(IBinding data, string? value) => {(data as Application)!.ApplicationName = value; },
			(IBinding data) => (data as Application)?.ApplicationName) {
				},
		new FrameString ("Address",
			(IBinding data, string? value) => {(data as Application)!.Address = value; },
			(IBinding data) => (data as Application)?.Address) {
				Description = "The user identifier at the service"
				},
		new FrameRefList<Key> ("Keys","Key"){
			Get = (IBacked data) => (data as Application)?.Keys ,
			Set = (IBacked data, Object? value) => {(data as Application)!.Keys = value as List<Key>; }},
		new FrameInteger ("Preference",
			(IBinding data, int? value) => {(data as Application)!.Preference = value; },
			(IBinding data) => (data as Application)?.Preference) {
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
	static readonly new Binding<Email> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "Email",
		() => new Email(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Messaging
/// </summary>
public partial class Messaging (string Id="Messaging") : Application (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Service</summary>
	public ServiceOption? Service {get; set;}

    /// <summary>Field Other</summary>
	public string? Other {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("ApplicationName",
			(IBinding data, string? value) => {(data as Application)!.ApplicationName = value; },
			(IBinding data) => (data as Application)?.ApplicationName) {
				},
		new FrameString ("Address",
			(IBinding data, string? value) => {(data as Application)!.Address = value; },
			(IBinding data) => (data as Application)?.Address) {
				Description = "The user identifier at the service"
				},
		new FrameRefList<Key> ("Keys","Key"){
			Get = (IBacked data) => (data as Application)?.Keys ,
			Set = (IBacked data, Object? value) => {(data as Application)!.Keys = value as List<Key>; }},
		new FrameInteger ("Preference",
			(IBinding data, int? value) => {(data as Application)!.Preference = value; },
			(IBinding data) => (data as Application)?.Preference) {
				},
		new FrameRefClass<ServiceOption> ("Service","ServiceOption"){
			Get = (IBacked data) => (data as Messaging)?.Service ,
			Set = (IBacked data, IBacked? value) => {(data as Messaging)!.Service = value as ServiceOption; }},
		new FrameString ("Other",
			(IBinding data, string? value) => {(data as Messaging)!.Other = value; },
			(IBinding data) => (data as Messaging)?.Other) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Other",
			(IBinding data, string? value) => {(data as Messaging)!.Other = value; },
			(IBinding data) => (data as Messaging)?.Other) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Messaging> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Other", _properties[0]}
			}, "Messaging",
		() => new Messaging(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Phone
/// </summary>
public partial class Phone (string Id="Phone") : Application (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Features</summary>
	public List<Option>? Features {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("ApplicationName",
			(IBinding data, string? value) => {(data as Application)!.ApplicationName = value; },
			(IBinding data) => (data as Application)?.ApplicationName) {
				},
		new FrameString ("Address",
			(IBinding data, string? value) => {(data as Application)!.Address = value; },
			(IBinding data) => (data as Application)?.Address) {
				Description = "The user identifier at the service"
				},
		new FrameRefList<Key> ("Keys","Key"){
			Get = (IBacked data) => (data as Application)?.Keys ,
			Set = (IBacked data, Object? value) => {(data as Application)!.Keys = value as List<Key>; }},
		new FrameInteger ("Preference",
			(IBinding data, int? value) => {(data as Application)!.Preference = value; },
			(IBinding data) => (data as Application)?.Preference) {
				},
		new FrameRefList<Option> ("Features","Option"){
			Get = (IBacked data) => (data as Phone)?.Features ,
			Set = (IBacked data, Object? value) => {(data as Phone)!.Features = value as List<Option>; }}
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
	static readonly new Binding<Phone> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "Phone",
		() => new Phone(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Service
/// </summary>
public partial class Service (string Id="Service") : Application (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field ServiceName</summary>
	public string? ServiceName {get; set;}

    /// <summary>Field Protocol</summary>
	public string? Protocol {get; set;}

    /// <summary>Field Type</summary>
	public Option? Type {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("ApplicationName",
			(IBinding data, string? value) => {(data as Application)!.ApplicationName = value; },
			(IBinding data) => (data as Application)?.ApplicationName) {
				},
		new FrameString ("Address",
			(IBinding data, string? value) => {(data as Application)!.Address = value; },
			(IBinding data) => (data as Application)?.Address) {
				Description = "The user identifier at the service"
				},
		new FrameRefList<Key> ("Keys","Key"){
			Get = (IBacked data) => (data as Application)?.Keys ,
			Set = (IBacked data, Object? value) => {(data as Application)!.Keys = value as List<Key>; }},
		new FrameInteger ("Preference",
			(IBinding data, int? value) => {(data as Application)!.Preference = value; },
			(IBinding data) => (data as Application)?.Preference) {
				},
		new FrameString ("ServiceName",
			(IBinding data, string? value) => {(data as Service)!.ServiceName = value; },
			(IBinding data) => (data as Service)?.ServiceName) {
				Description = "The service address"
				},
		new FrameString ("Protocol",
			(IBinding data, string? value) => {(data as Service)!.Protocol = value; },
			(IBinding data) => (data as Service)?.Protocol) {
				},
		new FrameRefClass<Option> ("Type","Option"){
			Get = (IBacked data) => (data as Service)?.Type ,
			Set = (IBacked data, IBacked? value) => {(data as Service)!.Type = value as Option; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("ServiceName",
			(IBinding data, string? value) => {(data as Service)!.ServiceName = value; },
			(IBinding data) => (data as Service)?.ServiceName) {
				Description = "The service address"
				},
		new FrameString ("Protocol",
			(IBinding data, string? value) => {(data as Service)!.Protocol = value; },
			(IBinding data) => (data as Service)?.Protocol) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Service> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"ServiceName", _properties[0]},
			{"Protocol", _properties[1]}
			}, "Service",
		() => new Service(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Key
/// </summary>
public partial class Key (string Id="Key") : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field KeyData</summary>
	public KeyData? KeyData {get; set;}

    /// <summary>Field Protocol</summary>
	public ServiceOption? Protocol {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefClass<KeyData> ("KeyData","KeyData"){
			Get = (IBacked data) => (data as Key)?.KeyData ,
			Set = (IBacked data, IBacked? value) => {(data as Key)!.KeyData = value as KeyData; }},
		new FrameRefClass<ServiceOption> ("Protocol","ServiceOption"){
			Get = (IBacked data) => (data as Key)?.Protocol ,
			Set = (IBacked data, IBacked? value) => {(data as Key)!.Protocol = value as ServiceOption; }}
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
	static readonly new Binding<Key> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "Key",
		() => new Key(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for KeyData
/// </summary>
public partial class KeyData (string Id="KeyData") : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field UID</summary>
	public string? UID {get; set;}

    /// <summary>Field Encryption</summary>
	public bool? Encryption {get; set;}

    /// <summary>Field Signature</summary>
	public bool? Signature {get; set;}

    /// <summary>Field Value</summary>
	public string? Value {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("UID",
			(IBinding data, string? value) => {(data as KeyData)!.UID = value; },
			(IBinding data) => (data as KeyData)?.UID) {
				},
		new FrameBoolean ("Encryption",
			(IBinding data, bool? value) => {(data as KeyData)!.Encryption = value; },
			(IBinding data) => (data as KeyData)?.Encryption) {
				},
		new FrameBoolean ("Signature",
			(IBinding data, bool? value) => {(data as KeyData)!.Signature = value; },
			(IBinding data) => (data as KeyData)?.Signature) {
				},
		new FrameString ("Value",
			(IBinding data, string? value) => {(data as KeyData)!.Value = value; },
			(IBinding data) => (data as KeyData)?.Value) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("UID",
			(IBinding data, string? value) => {(data as KeyData)!.UID = value; },
			(IBinding data) => (data as KeyData)?.UID) {
				},
		new FrameBoolean ("Encryption",
			(IBinding data, bool? value) => {(data as KeyData)!.Encryption = value; },
			(IBinding data) => (data as KeyData)?.Encryption) {
				},
		new FrameBoolean ("Signature",
			(IBinding data, bool? value) => {(data as KeyData)!.Signature = value; },
			(IBinding data) => (data as KeyData)?.Signature) {
				},
		new FrameString ("Value",
			(IBinding data, string? value) => {(data as KeyData)!.Value = value; },
			(IBinding data) => (data as KeyData)?.Value) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<KeyData> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"UID", _properties[0]},
			{"Encryption", _properties[1]},
			{"Signature", _properties[2]},
			{"Value", _properties[3]}
			}, "KeyData",
		() => new KeyData(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Media
/// </summary>
public partial class Media (string Id="Media") : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



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
		new FrameString ("MediaType",
			(IBinding data, string? value) => {(data as Media)!.MediaType = value; },
			(IBinding data) => (data as Media)?.MediaType) {
				Description = "The IANA Media Type"
				},
		new FrameInteger ("Width",
			(IBinding data, int? value) => {(data as Media)!.Width = value; },
			(IBinding data) => (data as Media)?.Width) {
				Description = "Width of image/video media in pixels"
				},
		new FrameInteger ("Height",
			(IBinding data, int? value) => {(data as Media)!.Height = value; },
			(IBinding data) => (data as Media)?.Height) {
				Description = "Height of image/video media in pixels"
				},
		new FrameInteger ("Length",
			(IBinding data, int? value) => {(data as Media)!.Length = value; },
			(IBinding data) => (data as Media)?.Length) {
				Description = "Length of audio/video media in seconds"
				},
		new FrameInteger ("Bytes",
			(IBinding data, int? value) => {(data as Media)!.Bytes = value; },
			(IBinding data) => (data as Media)?.Bytes) {
				Description = "Size of the resource in bytes"
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("MediaType",
			(IBinding data, string? value) => {(data as Media)!.MediaType = value; },
			(IBinding data) => (data as Media)?.MediaType) {
				Description = "The IANA Media Type"
				},
		new FrameInteger ("Width",
			(IBinding data, int? value) => {(data as Media)!.Width = value; },
			(IBinding data) => (data as Media)?.Width) {
				Description = "Width of image/video media in pixels"
				},
		new FrameInteger ("Height",
			(IBinding data, int? value) => {(data as Media)!.Height = value; },
			(IBinding data) => (data as Media)?.Height) {
				Description = "Height of image/video media in pixels"
				},
		new FrameInteger ("Length",
			(IBinding data, int? value) => {(data as Media)!.Length = value; },
			(IBinding data) => (data as Media)?.Length) {
				Description = "Length of audio/video media in seconds"
				},
		new FrameInteger ("Bytes",
			(IBinding data, int? value) => {(data as Media)!.Bytes = value; },
			(IBinding data) => (data as Media)?.Bytes) {
				Description = "Size of the resource in bytes"
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Media> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"MediaType", _properties[0]},
			{"Width", _properties[1]},
			{"Height", _properties[2]},
			{"Length", _properties[3]},
			{"Bytes", _properties[4]}
			}, "Media",
		() => new Media(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Option
/// </summary>
public partial class Option (string Id="Option") : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Id</summary>
	public string? Id {get; set;}

    /// <summary>Field Text</summary>
	public string? Text {get; set;}

    /// <summary>Field Icon</summary>
	public string? Icon {get; set;}

    /// <summary>Field Priority</summary>
	public int? Priority {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Id",
			(IBinding data, string? value) => {(data as Option)!.Id = value; },
			(IBinding data) => (data as Option)?.Id) {
				Hidden = true,
				Description = "Unique identifier"
				},
		new FrameString ("Text",
			(IBinding data, string? value) => {(data as Option)!.Text = value; },
			(IBinding data) => (data as Option)?.Text) {
				Description = "Text prompt for the option"
				},
		new FrameString ("Icon",
			(IBinding data, string? value) => {(data as Option)!.Icon = value; },
			(IBinding data) => (data as Option)?.Icon) {
				Description = "Icon prompt for the option"
				},
		new FrameInteger ("Priority",
			(IBinding data, int? value) => {(data as Option)!.Priority = value; },
			(IBinding data) => (data as Option)?.Priority) {
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Id",
			(IBinding data, string? value) => {(data as Option)!.Id = value; },
			(IBinding data) => (data as Option)?.Id) {
				Hidden = true,
				Description = "Unique identifier"
				},
		new FrameString ("Text",
			(IBinding data, string? value) => {(data as Option)!.Text = value; },
			(IBinding data) => (data as Option)?.Text) {
				Description = "Text prompt for the option"
				},
		new FrameString ("Icon",
			(IBinding data, string? value) => {(data as Option)!.Icon = value; },
			(IBinding data) => (data as Option)?.Icon) {
				Description = "Icon prompt for the option"
				},
		new FrameInteger ("Priority",
			(IBinding data, int? value) => {(data as Option)!.Priority = value; },
			(IBinding data) => (data as Option)?.Priority) {
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Option> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Id", _properties[0]},
			{"Text", _properties[1]},
			{"Icon", _properties[2]},
			{"Priority", _properties[3]}
			}, "Option",
		() => new Option(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for ServiceOption
/// </summary>
public partial class ServiceOption (string Id="ServiceOption") : Option (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Uri</summary>
	public string? Uri {get; set;}

    /// <summary>Field Template</summary>
	public string? Template {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Id",
			(IBinding data, string? value) => {(data as Option)!.Id = value; },
			(IBinding data) => (data as Option)?.Id) {
				Hidden = true,
				Description = "Unique identifier"
				},
		new FrameString ("Text",
			(IBinding data, string? value) => {(data as Option)!.Text = value; },
			(IBinding data) => (data as Option)?.Text) {
				Description = "Text prompt for the option"
				},
		new FrameString ("Icon",
			(IBinding data, string? value) => {(data as Option)!.Icon = value; },
			(IBinding data) => (data as Option)?.Icon) {
				Description = "Icon prompt for the option"
				},
		new FrameInteger ("Priority",
			(IBinding data, int? value) => {(data as Option)!.Priority = value; },
			(IBinding data) => (data as Option)?.Priority) {
				},
		new FrameString ("Uri",
			(IBinding data, string? value) => {(data as ServiceOption)!.Uri = value; },
			(IBinding data) => (data as ServiceOption)?.Uri) {
				Description = "The service address"
				},
		new FrameString ("Template",
			(IBinding data, string? value) => {(data as ServiceOption)!.Template = value; },
			(IBinding data) => (data as ServiceOption)?.Template) {
				Description = "Template that converts the user address to a URI"
				}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Uri",
			(IBinding data, string? value) => {(data as ServiceOption)!.Uri = value; },
			(IBinding data) => (data as ServiceOption)?.Uri) {
				Description = "The service address"
				},
		new FrameString ("Template",
			(IBinding data, string? value) => {(data as ServiceOption)!.Template = value; },
			(IBinding data) => (data as ServiceOption)?.Template) {
				Description = "Template that converts the user address to a URI"
				}		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<ServiceOption> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Uri", _properties[0]},
			{"Template", _properties[1]}
			}, "ServiceOption",
		() => new ServiceOption(), () => [], () => [], null, Generic: false);


	}


