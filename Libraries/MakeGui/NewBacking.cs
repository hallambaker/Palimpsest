
namespace Frame;

/// <summary>
/// Annotated backing classes for data driven GUI.
/// </summary>
public partial class MyClass : FrameSet{

	///<summary>HomePage</summary>
	public HomePage HomePage {get;} = new();

	///<summary>NotificationsPage</summary>
	public NotificationsPage NotificationsPage {get;} = new();

	///<summary>ChatsPage</summary>
	public ChatsPage ChatsPage {get;} = new();

	///<summary>ChatingPage</summary>
	public ChatingPage ChatingPage {get;} = new();

	///<summary>FeedsPage</summary>
	public FeedsPage FeedsPage {get;} = new();

	///<summary>ProfilePage</summary>
	public ProfilePage ProfilePage {get;} = new();

	///<summary>SettingsPage</summary>
	public SettingsPage SettingsPage {get;} = new();

	///<summary>AppearancePage</summary>
	public AppearancePage AppearancePage {get;} = new();

	///<summary>NewPostPage</summary>
	public NewPostPage NewPostPage {get;} = new();


	///<summary>MainNav</summary>
	public MainNav MainNav {get;} = new();

	///<summary>TopSettings</summary>
	public TopSettings TopSettings {get;} = new();

	///<summary>HomeFilter</summary>
	public HomeFilter HomeFilter {get;} = new();

	///<summary>ProfileFilter</summary>
	public ProfileFilter ProfileFilter {get;} = new();


	 ///<summary>ProfileSelect</summary>
	 public ProfileSelect ProfileSelect {get;} = new();


	 ///<summary>User</summary>
	 public User User {get;} = new();

	 ///<summary>Item</summary>
	 public Item Item {get;} = new();

	 ///<summary>Chat</summary>
	 public Chat Chat {get;} = new();

	 ///<summary>ChatText</summary>
	 public ChatText ChatText {get;} = new();

	 ///<summary>Reaction</summary>
	 public Reaction Reaction {get;} = new();

	 ///<summary>Post</summary>
	 public Post Post {get;} = new();

	 ///<summary>Repost</summary>
	 public Repost Repost {get;} = new();

	 ///<summary>QuotePost</summary>
	 public QuotePost QuotePost {get;} = new();

	 ///<summary>RePost</summary>
	 public RePost RePost {get;} = new();

	 ///<summary>ProfileData</summary>
	 public ProfileData ProfileData {get;} = new();

	/// <summary>
	/// Constructor, return a new instance.
	/// </summary>
	public MyClass () {

		Pages = [ 
			HomePage,
			NotificationsPage,
			ChatsPage,
			ChatingPage,
			FeedsPage,
			ProfilePage,
			SettingsPage,
			AppearancePage,
			NewPostPage
			];

		Menus = [ 
			MainNav,
			TopSettings,
			HomeFilter,
			ProfileFilter
			];

		Selectors = [ 
			ProfileSelect
			];

		Classes = [ 
			User,
			Item,
			Chat,
			ChatText,
			Reaction,
			Post,
			Repost,
			QuotePost,
			RePost,
			ProfileData
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
	public HomePage () : base ("HomePage", "Home", _Fields) {
		}

	///<summary>List Items</summary>
	public List<Item>? Items {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRefMenu ("TopSettings","TopSettings"),
		new FrameRefList<Item> ("Items","Item"){
			Get = (IBacked data) => (data as HomePage)?.Items ,
			Set = (IBacked data, Object? value) => {(data as HomePage)!.Items = value as List<Item>; }}
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
		}

	///<summary>List Items</summary>
	public List<Item>? Items {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRefMenu ("Filter","HomeFilter"),
		new FrameRef ("x"),
		new FrameRefList<Item> ("Items","Item"){
			Get = (IBacked data) => (data as NotificationsPage)?.Items ,
			Set = (IBacked data, Object? value) => {(data as NotificationsPage)!.Items = value as List<Item>; }}
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
/// Backing class for ChatsPage
/// </summary>
public partial class ChatsPage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public ChatsPage () : base ("ChatsPage", "Chat", _Fields) {
		}

	///<summary>List Items</summary>
	public List<Chat>? Items {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRef ("x"),
		new FrameRefList<Chat> ("Items","Chat"){
			Get = (IBacked data) => (data as ChatsPage)?.Items ,
			Set = (IBacked data, Object? value) => {(data as ChatsPage)!.Items = value as List<Chat>; }}
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
	static readonly new Binding<ChatsPage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "ChatsPage",
		() => new ChatsPage(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for ChatingPage
/// </summary>
public partial class ChatingPage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public ChatingPage () : base ("ChatingPage", "Chatting", _Fields) {
		}

	///<summary>class User, With</summary>
	public User? With {get; set;}

	///<summary>List Items</summary>
	public List<ChatText>? Items {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRef ("x"),
		new FrameRefClass<User> ("With","User"){
			Get = (IBacked data) => (data as ChatingPage)?.With ,
			Set = (IBacked data, IBacked? value) => {(data as ChatingPage)!.With = value as User; }},
		new FrameRefList<ChatText> ("Items","ChatText"){
			Get = (IBacked data) => (data as ChatingPage)?.Items ,
			Set = (IBacked data, Object? value) => {(data as ChatingPage)!.Items = value as List<ChatText>; }}
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
	static readonly new Binding<ChatingPage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "ChatingPage",
		() => new ChatingPage(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for FeedsPage
/// </summary>
public partial class FeedsPage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public FeedsPage () : base ("FeedsPage", "Feeds", _Fields) {
		}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRef ("x")
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
	static readonly new Binding<FeedsPage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "FeedsPage",
		() => new FeedsPage(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for ProfilePage
/// </summary>
public partial class ProfilePage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public ProfilePage () : base ("ProfilePage", "Profile", _Fields) {
		}

	///<summary>List Items</summary>
	public List<Post>? Items {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRef ("x"),
		new FrameRefList<Post> ("Items","Post"){
			Get = (IBacked data) => (data as ProfilePage)?.Items ,
			Set = (IBacked data, Object? value) => {(data as ProfilePage)!.Items = value as List<Post>; }}
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
	static readonly new Binding<ProfilePage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "ProfilePage",
		() => new ProfilePage(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for SettingsPage
/// </summary>
public partial class SettingsPage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public SettingsPage () : base ("SettingsPage", "Settings", _Fields) {
		}


	static readonly List<IFrameField> _Fields = [
		new FrameButton ("SwitchAccount", "Switch account", "ProfileSelect") {
			},
		new FrameButton ("Appearance", "Appearance", "AppearancePage") {
			},
		new FrameSeparator ("x"),
		new FrameButton ("SignOut", "Sign out", "SignOutAction") {
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
	static readonly new Binding<SettingsPage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "SettingsPage",
		() => new SettingsPage(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for AppearancePage
/// </summary>
public partial class AppearancePage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public AppearancePage () : base ("AppearancePage", "Appearance", _Fields) {
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
	static readonly new Binding<AppearancePage> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "AppearancePage",
		() => new AppearancePage(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for NewPostPage
/// </summary>
public partial class NewPostPage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public NewPostPage () : base ("NewPostPage", "New Post", _Fields) {
		}

    /// <summary>Field Avatar</summary>
	public string? Avatar {get; set;}

    /// <summary>Field Text</summary>
	public string? Text {get; set;}

    /// <summary>Field Language</summary>
	public string? Language {get; set;}

    /// <summary>Field Characters</summary>
	public int? Characters {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameButton ("Cancel", "Cancel", "Cancel") {
			},
		new FrameButton ("Post", "Post", "Post") {
			},
		new FrameImage ("Avatar",
			(IBinding data, string? value) => {(data as NewPostPage)!.Avatar = value; },
			(IBinding data) => (data as NewPostPage)?.Avatar),
		new FrameText ("Text",
			(IBinding data, string? value) => {(data as NewPostPage)!.Text = value; },
			(IBinding data) => (data as NewPostPage)?.Text),
		new FrameButton ("Image", "Image", "Image") {
			},
		new FrameButton ("Video", "Video", "Video") {
			},
		new FrameString ("Language",
			(IBinding data, string? value) => {(data as NewPostPage)!.Language = value; },
			(IBinding data) => (data as NewPostPage)?.Language),
		new FrameCount ("Characters",
			(IBinding data, int? value) => {(data as NewPostPage)!.Characters = value; },
			(IBinding data) => (data as NewPostPage)?.Characters)
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameImage ("Avatar",
			(IBinding data, string? value) => {(data as NewPostPage)!.Avatar = value; },
			(IBinding data) => (data as NewPostPage)?.Avatar),
		new FrameText ("Text",
			(IBinding data, string? value) => {(data as NewPostPage)!.Text = value; },
			(IBinding data) => (data as NewPostPage)?.Text),
		new FrameString ("Language",
			(IBinding data, string? value) => {(data as NewPostPage)!.Language = value; },
			(IBinding data) => (data as NewPostPage)?.Language),
		new FrameCount ("Characters",
			(IBinding data, int? value) => {(data as NewPostPage)!.Characters = value; },
			(IBinding data) => (data as NewPostPage)?.Characters)		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<NewPostPage> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Avatar", _properties[0]},
			{"Text", _properties[1]},
			{"Language", _properties[2]},
			{"Characters", _properties[3]}
			}, "NewPostPage",
		() => new NewPostPage(), () => [], () => [], null, Generic: false);


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
			(IBinding data) => (data as MainNav)?.NotificationCount),
		new FrameRef ("Profiles"),
		new FrameButton ("Home", "Home", "HomePage") {
			},
		new FrameButton ("Notifications", "Notifications", "NotificationsPage") {
			GetInteger = (IBinding data) => (data as MainNav)?.NotificationCount
			},
		new FrameButton ("Chats", "Chats", "ChatsPage") {
			},
		new FrameButton ("Feeds", "Feeds", "FeedsPage") {
			},
		new FrameButton ("Profile", "Profile", "ProfilePage") {
			},
		new FrameButton ("Settings", "Settings", "SettingsPage") {
			},
		new FrameButton ("NewPost", "New Post", "NewPostPage") {
			}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameInteger ("NotificationCount",
			(IBinding data, int? value) => {(data as MainNav)!.NotificationCount = value; },
			(IBinding data) => (data as MainNav)?.NotificationCount)		];

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
/// Backing class for HomeFilter
/// </summary>
public partial class HomeFilter : FrameMenu {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public HomeFilter () : base ("HomeFilter", _Fields) {
		}


	static readonly List<IFrameField> _Fields = [
		new FrameButton ("All", "All", "FilterAll") {
			},
		new FrameButton ("Mentions", "Mentions", "FilterMentions") {
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
	static readonly new Binding<HomeFilter> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "HomeFilter",
		() => new HomeFilter(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for ProfileFilter
/// </summary>
public partial class ProfileFilter : FrameMenu {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public ProfileFilter () : base ("ProfileFilter", _Fields) {
		}


	static readonly List<IFrameField> _Fields = [
		new FrameButton ("Posts", "All", "FilterPosts") {
			},
		new FrameButton ("Replies", "Mentions", "FilterReplies") {
			},
		new FrameButton ("Media", "Mentions", "FilterMedia") {
			},
		new FrameButton ("Videos", "Mentions", "FilterVideos") {
			},
		new FrameButton ("Likes", "Mentions", "FilterLikes") {
			},
		new FrameButton ("Feeds", "Mentions", "FilterFeeds") {
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
	static readonly new Binding<ProfileFilter> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "ProfileFilter",
		() => new ProfileFilter(), () => [], () => [], null, Generic: false);


	}

// Classes 
/// <summary>
/// Backing class for ProfileSelect
/// </summary>
public partial class ProfileSelect : FrameSelector {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public ProfileSelect () : base ("ProfileSelect", _Fields) {
		}

    /// <summary>Field Avatar</summary>
	public string? Avatar {get; set;}

    /// <summary>Field DisplayName</summary>
	public string? DisplayName {get; set;}

    /// <summary>Field DiaplayHandle</summary>
	public string? DiaplayHandle {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameImage ("Avatar",
			(IBinding data, string? value) => {(data as ProfileSelect)!.Avatar = value; },
			(IBinding data) => (data as ProfileSelect)?.Avatar),
		new FrameString ("DisplayName",
			(IBinding data, string? value) => {(data as ProfileSelect)!.DisplayName = value; },
			(IBinding data) => (data as ProfileSelect)?.DisplayName),
		new FrameString ("DiaplayHandle",
			(IBinding data, string? value) => {(data as ProfileSelect)!.DiaplayHandle = value; },
			(IBinding data) => (data as ProfileSelect)?.DiaplayHandle),
		new FrameButton ("AddAccount", "Add another account", "AddAccountAction") {
			},
		new FrameButton ("SignOut", "Sign out", "SignOutAction") {
			}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameImage ("Avatar",
			(IBinding data, string? value) => {(data as ProfileSelect)!.Avatar = value; },
			(IBinding data) => (data as ProfileSelect)?.Avatar),
		new FrameString ("DisplayName",
			(IBinding data, string? value) => {(data as ProfileSelect)!.DisplayName = value; },
			(IBinding data) => (data as ProfileSelect)?.DisplayName),
		new FrameString ("DiaplayHandle",
			(IBinding data, string? value) => {(data as ProfileSelect)!.DiaplayHandle = value; },
			(IBinding data) => (data as ProfileSelect)?.DiaplayHandle)		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<ProfileSelect> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Avatar", _properties[0]},
			{"DisplayName", _properties[1]},
			{"DiaplayHandle", _properties[2]}
			}, "ProfileSelect",
		() => new ProfileSelect(), () => [], () => [], null, Generic: false);


	}



// Classes 
/// <summary>
/// Backing class for User
/// </summary>
public partial class User (string Id="User") : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field DID</summary>
	public string? DID {get; set;}

	///<summary>Avatar Avatar</summary>
	public string? Avatar => GetAvatar;

    /// <summary>Field DisplayName</summary>
	public string? DisplayName {get; set;}

    /// <summary>Field DisplayHandle</summary>
	public string? DisplayHandle {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("DID",
			(IBinding data, string? value) => {(data as User)!.DID = value; },
			(IBinding data) => (data as User)?.DID),
		new FrameAvatar ("Avatar"){
			Get = (IBinding data) => (data as User)?.Avatar },
		new FrameString ("DisplayName",
			(IBinding data, string? value) => {(data as User)!.DisplayName = value; },
			(IBinding data) => (data as User)?.DisplayName),
		new FrameString ("DisplayHandle",
			(IBinding data, string? value) => {(data as User)!.DisplayHandle = value; },
			(IBinding data) => (data as User)?.DisplayHandle)
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("DID",
			(IBinding data, string? value) => {(data as User)!.DID = value; },
			(IBinding data) => (data as User)?.DID),
		new FrameString ("DisplayName",
			(IBinding data, string? value) => {(data as User)!.DisplayName = value; },
			(IBinding data) => (data as User)?.DisplayName),
		new FrameString ("DisplayHandle",
			(IBinding data, string? value) => {(data as User)!.DisplayHandle = value; },
			(IBinding data) => (data as User)?.DisplayHandle)		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<User> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"DID", _properties[0]},
			{"DisplayName", _properties[1]},
			{"DisplayHandle", _properties[2]}
			}, "User",
		() => new User(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Item
/// </summary>
public partial class Item (string Id="Item") : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Uid</summary>
	public string? Uid {get; set;}

    /// <summary>Field Created</summary>
	public System.DateTime? Created {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as Item)!.Uid = value; },
			(IBinding data) => (data as Item)?.Uid),
		new FrameDateTime ("Created",
			(IBinding data, System.DateTime? value) => {(data as Item)!.Created = value; },
			(IBinding data) => (data as Item)?.Created)
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as Item)!.Uid = value; },
			(IBinding data) => (data as Item)?.Uid),
		new FrameDateTime ("Created",
			(IBinding data, System.DateTime? value) => {(data as Item)!.Created = value; },
			(IBinding data) => (data as Item)?.Created)		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Item> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Uid", _properties[0]},
			{"Created", _properties[1]}
			}, "Item",
		() => new Item(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Chat
/// </summary>
public partial class Chat (string Id="Chat") : Item (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



	///<summary>class User, User</summary>
	public User? User {get; set;}

	///<summary>List Messages</summary>
	public List<ChatText>? Messages {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as Item)!.Uid = value; },
			(IBinding data) => (data as Item)?.Uid),
		new FrameDateTime ("Created",
			(IBinding data, System.DateTime? value) => {(data as Item)!.Created = value; },
			(IBinding data) => (data as Item)?.Created),
		new FrameRefClass<User> ("User","User"){
			Get = (IBacked data) => (data as Chat)?.User ,
			Set = (IBacked data, IBacked? value) => {(data as Chat)!.User = value as User; }},
		new FrameRefList<ChatText> ("Messages","ChatText"){
			Get = (IBacked data) => (data as Chat)?.Messages ,
			Set = (IBacked data, Object? value) => {(data as Chat)!.Messages = value as List<ChatText>; }}
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
	static readonly new Binding<Chat> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "Chat",
		() => new Chat(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for ChatText
/// </summary>
public partial class ChatText (string Id="ChatText") : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Created</summary>
	public System.DateTime? Created {get; set;}

    /// <summary>Field Self</summary>
	public bool? Self {get; set;}

    /// <summary>Field Text</summary>
	public string? Text {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameDateTime ("Created",
			(IBinding data, System.DateTime? value) => {(data as ChatText)!.Created = value; },
			(IBinding data) => (data as ChatText)?.Created),
		new FrameBoolean ("Self",
			(IBinding data, bool? value) => {(data as ChatText)!.Self = value; },
			(IBinding data) => (data as ChatText)?.Self),
		new FrameText ("Text",
			(IBinding data, string? value) => {(data as ChatText)!.Text = value; },
			(IBinding data) => (data as ChatText)?.Text)
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameDateTime ("Created",
			(IBinding data, System.DateTime? value) => {(data as ChatText)!.Created = value; },
			(IBinding data) => (data as ChatText)?.Created),
		new FrameBoolean ("Self",
			(IBinding data, bool? value) => {(data as ChatText)!.Self = value; },
			(IBinding data) => (data as ChatText)?.Self),
		new FrameText ("Text",
			(IBinding data, string? value) => {(data as ChatText)!.Text = value; },
			(IBinding data) => (data as ChatText)?.Text)		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<ChatText> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Created", _properties[0]},
			{"Self", _properties[1]},
			{"Text", _properties[2]}
			}, "ChatText",
		() => new ChatText(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Reaction
/// </summary>
public partial class Reaction (string Id="Reaction") : Item (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Semantic</summary>
	public string? Semantic {get; set;}

	///<summary>List Users</summary>
	public List<User>? Users {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as Item)!.Uid = value; },
			(IBinding data) => (data as Item)?.Uid),
		new FrameDateTime ("Created",
			(IBinding data, System.DateTime? value) => {(data as Item)!.Created = value; },
			(IBinding data) => (data as Item)?.Created),
		new FrameString ("Semantic",
			(IBinding data, string? value) => {(data as Reaction)!.Semantic = value; },
			(IBinding data) => (data as Reaction)?.Semantic),
		new FrameRefList<User> ("Users","User"){
			Get = (IBacked data) => (data as Reaction)?.Users ,
			Set = (IBacked data, Object? value) => {(data as Reaction)!.Users = value as List<User>; }}
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameString ("Semantic",
			(IBinding data, string? value) => {(data as Reaction)!.Semantic = value; },
			(IBinding data) => (data as Reaction)?.Semantic)		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Reaction> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Semantic", _properties[0]}
			}, "Reaction",
		() => new Reaction(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Post
/// </summary>
public partial class Post (string Id="Post") : Item (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

    /// <inheritdoc/>
    public override FramePresentation Presentation => Main;


    /// <summary>Field Text</summary>
	public string? Text {get; set;}

	///<summary>class User, User</summary>
	public User? User {get; set;}

    /// <summary>Field Comments</summary>
	public int? Comments {get; set;}

    /// <summary>Field Reposts</summary>
	public int? Reposts {get; set;}

    /// <summary>Field QuotePosts</summary>
	public int? QuotePosts {get; set;}

    /// <summary>Field AllReposts</summary>
	public int? AllReposts {get; set;}

    /// <summary>Field Likes</summary>
	public int? Likes {get; set;}

    /// <summary>Field Liked</summary>
	public bool? Liked {get; set;}

    /// <summary>Field RequestedMore</summary>
	public bool? RequestedMore {get; set;}

    /// <summary>Field RequestedLess</summary>
	public bool? RequestedLess {get; set;}

    /// <summary>Field Replies</summary>
	public string? Replies {get; set;}

	///<summary>class Post, QuotedPost</summary>
	public Post? QuotedPost {get; set;}


	/// <summary>
	/// Presentation style Main
	/// </summary>
	public static FramePresentation Main => main ?? new FramePresentation ("Main") {
		GetUid = (IBacked data) => (data as Post)?.Uid,
		Sections = [
			new FrameSection ("Avatar") {
				Fields = [
            		new FrameAvatar ("User.Avatar"){
            			Get = (IBinding data) => (data as Post)?.User?.Avatar }
					]
				},
			new FrameSection ("Author") {
				Fields = [
            		new FrameString ("User.DisplayName",
            			(IBinding data, string? value) => {(data as Post)!.User!.DisplayName = value; },
            			(IBinding data) => (data as Post)?.User?.DisplayName),
            		new FrameString ("User.DisplayHandle",
            			(IBinding data, string? value) => {(data as Post)!.User!.DisplayHandle = value; },
            			(IBinding data) => (data as Post)?.User?.DisplayHandle),
            		new FrameDateTime ("Created",
            			(IBinding data, System.DateTime? value) => {(data as Post)!.Created = value; },
            			(IBinding data) => (data as Post)?.Created)
					]
				},
			new FrameSection ("Rule") {
				Fields = [
					]
				},
			new FrameSection ("Body") {
				Fields = [
            		new FrameText ("Text",
            			(IBinding data, string? value) => {(data as Post)!.Text = value; },
            			(IBinding data) => (data as Post)?.Text),
            		new FrameRefClass<Post> ("QuotedPost","Post"){
            			Presentation = Post.Quoted,
            			Get = (IBacked data) => (data as Post)?.QuotedPost ,
            			Set = (IBacked data, IBacked? value) => {(data as Post)!.QuotedPost = value as Post; }}
					]
				},
			new FrameSection ("Detail") {
				Fields = [
            		new FrameDateTime ("Created",
            			(IBinding data, System.DateTime? value) => {(data as Post)!.Created = value; },
            			(IBinding data) => (data as Post)?.Created),
            		new FrameString ("Replies",
            			(IBinding data, string? value) => {(data as Post)!.Replies = value; },
            			(IBinding data) => (data as Post)?.Replies)
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
		}.CacheValue(out main)!;
	public static FramePresentation? main;

	/// <summary>
	/// Presentation style Quoted
	/// </summary>
	public static FramePresentation Quoted => quoted ?? new FramePresentation ("Quoted") {
		GetUid = (IBacked data) => (data as Post)?.Uid,
		Sections = [
			new FrameSection ("Avatar") {
				Fields = [
            		new FrameAvatar ("User.Avatar"){
            			Get = (IBinding data) => (data as Post)?.User?.Avatar }
					]
				},
			new FrameSection ("Author") {
				Fields = [
            		new FrameString ("User.DisplayName",
            			(IBinding data, string? value) => {(data as Post)!.User!.DisplayName = value; },
            			(IBinding data) => (data as Post)?.User?.DisplayName),
            		new FrameString ("User.DisplayHandle",
            			(IBinding data, string? value) => {(data as Post)!.User!.DisplayHandle = value; },
            			(IBinding data) => (data as Post)?.User?.DisplayHandle),
            		new FrameDateTime ("Created",
            			(IBinding data, System.DateTime? value) => {(data as Post)!.Created = value; },
            			(IBinding data) => (data as Post)?.Created)
					]
				},
			new FrameSection ("Body") {
				Fields = [
            		new FrameText ("Text",
            			(IBinding data, string? value) => {(data as Post)!.Text = value; },
            			(IBinding data) => (data as Post)?.Text)
					]
				}
			]
		}.CacheValue(out quoted)!;
	public static FramePresentation? quoted;

	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as Item)!.Uid = value; },
			(IBinding data) => (data as Item)?.Uid),
		new FrameDateTime ("Created",
			(IBinding data, System.DateTime? value) => {(data as Item)!.Created = value; },
			(IBinding data) => (data as Item)?.Created),
		new FrameText ("Text",
			(IBinding data, string? value) => {(data as Post)!.Text = value; },
			(IBinding data) => (data as Post)?.Text),
		new FrameRefClass<User> ("User","User"){
			Get = (IBacked data) => (data as Post)?.User ,
			Set = (IBacked data, IBacked? value) => {(data as Post)!.User = value as User; }},
		new FrameInteger ("Comments",
			(IBinding data, int? value) => {(data as Post)!.Comments = value; },
			(IBinding data) => (data as Post)?.Comments),
		new FrameInteger ("Reposts",
			(IBinding data, int? value) => {(data as Post)!.Reposts = value; },
			(IBinding data) => (data as Post)?.Reposts),
		new FrameInteger ("QuotePosts",
			(IBinding data, int? value) => {(data as Post)!.QuotePosts = value; },
			(IBinding data) => (data as Post)?.QuotePosts),
		new FrameInteger ("AllReposts",
			(IBinding data, int? value) => {(data as Post)!.AllReposts = value; },
			(IBinding data) => (data as Post)?.AllReposts),
		new FrameInteger ("Likes",
			(IBinding data, int? value) => {(data as Post)!.Likes = value; },
			(IBinding data) => (data as Post)?.Likes),
		new FrameBoolean ("Liked",
			(IBinding data, bool? value) => {(data as Post)!.Liked = value; },
			(IBinding data) => (data as Post)?.Liked),
		new FrameBoolean ("RequestedMore",
			(IBinding data, bool? value) => {(data as Post)!.RequestedMore = value; },
			(IBinding data) => (data as Post)?.RequestedMore),
		new FrameBoolean ("RequestedLess",
			(IBinding data, bool? value) => {(data as Post)!.RequestedLess = value; },
			(IBinding data) => (data as Post)?.RequestedLess),
		new FrameString ("Replies",
			(IBinding data, string? value) => {(data as Post)!.Replies = value; },
			(IBinding data) => (data as Post)?.Replies),
		new FrameRefClass<Post> ("QuotedPost","Post"){
			Get = (IBacked data) => (data as Post)?.QuotedPost ,
			Set = (IBacked data, IBacked? value) => {(data as Post)!.QuotedPost = value as Post; }},
		Main,
		Quoted
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameText ("Text",
			(IBinding data, string? value) => {(data as Post)!.Text = value; },
			(IBinding data) => (data as Post)?.Text),
		new FrameInteger ("Comments",
			(IBinding data, int? value) => {(data as Post)!.Comments = value; },
			(IBinding data) => (data as Post)?.Comments),
		new FrameInteger ("Reposts",
			(IBinding data, int? value) => {(data as Post)!.Reposts = value; },
			(IBinding data) => (data as Post)?.Reposts),
		new FrameInteger ("QuotePosts",
			(IBinding data, int? value) => {(data as Post)!.QuotePosts = value; },
			(IBinding data) => (data as Post)?.QuotePosts),
		new FrameInteger ("AllReposts",
			(IBinding data, int? value) => {(data as Post)!.AllReposts = value; },
			(IBinding data) => (data as Post)?.AllReposts),
		new FrameInteger ("Likes",
			(IBinding data, int? value) => {(data as Post)!.Likes = value; },
			(IBinding data) => (data as Post)?.Likes),
		new FrameBoolean ("Liked",
			(IBinding data, bool? value) => {(data as Post)!.Liked = value; },
			(IBinding data) => (data as Post)?.Liked),
		new FrameBoolean ("RequestedMore",
			(IBinding data, bool? value) => {(data as Post)!.RequestedMore = value; },
			(IBinding data) => (data as Post)?.RequestedMore),
		new FrameBoolean ("RequestedLess",
			(IBinding data, bool? value) => {(data as Post)!.RequestedLess = value; },
			(IBinding data) => (data as Post)?.RequestedLess),
		new FrameString ("Replies",
			(IBinding data, string? value) => {(data as Post)!.Replies = value; },
			(IBinding data) => (data as Post)?.Replies)		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<Post> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Text", _properties[0]},
			{"Comments", _properties[1]},
			{"Reposts", _properties[2]},
			{"QuotePosts", _properties[3]},
			{"AllReposts", _properties[4]},
			{"Likes", _properties[5]},
			{"Liked", _properties[6]},
			{"RequestedMore", _properties[7]},
			{"RequestedLess", _properties[8]},
			{"Replies", _properties[9]}
			}, "Post",
		() => new Post(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for Repost
/// </summary>
public partial class Repost (string Id="Repost") : Item (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

    /// <inheritdoc/>
    public override FramePresentation Presentation => Main;


	///<summary>class User, Reposter</summary>
	public User? Reposter {get; set;}

	///<summary>class Post, QuotedPost</summary>
	public Post? QuotedPost {get; set;}


	/// <summary>
	/// Presentation style Main
	/// </summary>
	public static FramePresentation Main => main ?? new FramePresentation ("Main") {
		GetUid = (IBacked data) => (data as Repost)?.Uid,
		Sections = [
			new FrameSection ("RepostIndicator") {
				Fields = [
            		new FrameIcon ("Repost")
					]
				},
			new FrameSection ("Reposter") {
				Fields = [
            		new FrameString ("Reposter.DisplayName",
            			(IBinding data, string? value) => {(data as Repost)!.Reposter!.DisplayName = value; },
            			(IBinding data) => (data as Repost)?.Reposter?.DisplayName),
            		new FrameString ("Reposter.DisplayHandle",
            			(IBinding data, string? value) => {(data as Repost)!.Reposter!.DisplayHandle = value; },
            			(IBinding data) => (data as Repost)?.Reposter?.DisplayHandle)
					]
				},
			new FrameSection ("Avatar") {
				Fields = [
            		new FrameAvatar ("QuotedPost.User.Avatar"){
            			Get = (IBinding data) => (data as Repost)?.QuotedPost?.User?.Avatar }
					]
				},
			new FrameSection ("Author") {
				Fields = [
            		new FrameString ("QuotedPost.User.DisplayName",
            			(IBinding data, string? value) => {(data as Repost)!.QuotedPost!.User!.DisplayName = value; },
            			(IBinding data) => (data as Repost)?.QuotedPost?.User?.DisplayName),
            		new FrameString ("QuotedPost.User.DisplayHandle",
            			(IBinding data, string? value) => {(data as Repost)!.QuotedPost!.User!.DisplayHandle = value; },
            			(IBinding data) => (data as Repost)?.QuotedPost?.User?.DisplayHandle),
            		new FrameDateTime ("QuotedPost.Created",
            			(IBinding data, System.DateTime? value) => {(data as Repost)!.QuotedPost!.Created = value; },
            			(IBinding data) => (data as Repost)?.QuotedPost?.Created)
					]
				},
			new FrameSection ("Rule") {
				Fields = [
					]
				},
			new FrameSection ("Body") {
				Fields = [
            		new FrameText ("QuotedPost.Text",
            			(IBinding data, string? value) => {(data as Repost)!.QuotedPost!.Text = value; },
            			(IBinding data) => (data as Repost)?.QuotedPost?.Text)
					]
				},
			new FrameSection ("Detail") {
				Fields = [
            		new FrameDateTime ("QuotedPost.Created",
            			(IBinding data, System.DateTime? value) => {(data as Repost)!.QuotedPost!.Created = value; },
            			(IBinding data) => (data as Repost)?.QuotedPost?.Created),
            		new FrameString ("QuotedPost.Replies",
            			(IBinding data, string? value) => {(data as Repost)!.QuotedPost!.Replies = value; },
            			(IBinding data) => (data as Repost)?.QuotedPost?.Replies)
					]
				},
			new FrameSection ("Responses") {
				Fields = [
            		new FrameButton ("Comment", "Comment", "CommentAction") {
            			GetInteger = (IBinding data) => (data as Repost)?.QuotedPost?.Comments
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
            			GetActive = (IBinding data) => (data as Repost)?.QuotedPost?.Liked,
            			GetInteger = (IBinding data) => (data as Repost)?.QuotedPost?.Likes
            			},
            		new FrameButton ("SeeMore", "More", "MoreAction") {
            			GetActive = (IBinding data) => (data as Repost)?.QuotedPost?.RequestedMore
            			},
            		new FrameButton ("SeeLess", "Less", "LessAction") {
            			GetActive = (IBinding data) => (data as Repost)?.QuotedPost?.RequestedLess
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
                    		new FrameButton ("ReportPost", "Report post", "ReportPostAction") {
                    			}
            				]
            			}
					]
				}
			]
		}.CacheValue(out main)!;
	public static FramePresentation? main;

	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as Item)!.Uid = value; },
			(IBinding data) => (data as Item)?.Uid),
		new FrameDateTime ("Created",
			(IBinding data, System.DateTime? value) => {(data as Item)!.Created = value; },
			(IBinding data) => (data as Item)?.Created),
		new FrameRefClass<User> ("Reposter","User"){
			Get = (IBacked data) => (data as Repost)?.Reposter ,
			Set = (IBacked data, IBacked? value) => {(data as Repost)!.Reposter = value as User; }},
		new FrameRefClass<Post> ("QuotedPost","Post"){
			Get = (IBacked data) => (data as Repost)?.QuotedPost ,
			Set = (IBacked data, IBacked? value) => {(data as Repost)!.QuotedPost = value as Post; }},
		Main
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
	static readonly new Binding<Repost> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "Repost",
		() => new Repost(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for QuotePost
/// </summary>
public partial class QuotePost (string Id="QuotePost") : Post (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

    /// <inheritdoc/>
    public override FramePresentation Presentation => QuoteMain;


	///<summary>class Post, Base</summary>
	public Post? Base {get; set;}


	/// <summary>
	/// Presentation style QuoteMain
	/// </summary>
	public static FramePresentation QuoteMain => quotemain ?? new FramePresentation ("QuoteMain") {
		GetUid = (IBacked data) => (data as QuotePost)?.Uid,
		Sections = [
			new FrameSection ("Avatar") {
				Fields = [
            		new FrameAvatar ("User.Avatar"){
            			Get = (IBinding data) => (data as QuotePost)?.User?.Avatar }
					]
				},
			new FrameSection ("Author") {
				Fields = [
            		new FrameString ("User.DisplayName",
            			(IBinding data, string? value) => {(data as QuotePost)!.User!.DisplayName = value; },
            			(IBinding data) => (data as QuotePost)?.User?.DisplayName),
            		new FrameString ("User.DisplayHandle",
            			(IBinding data, string? value) => {(data as QuotePost)!.User!.DisplayHandle = value; },
            			(IBinding data) => (data as QuotePost)?.User?.DisplayHandle),
            		new FrameDateTime ("Created",
            			(IBinding data, System.DateTime? value) => {(data as QuotePost)!.Created = value; },
            			(IBinding data) => (data as QuotePost)?.Created)
					]
				},
			new FrameSection ("Body") {
				Fields = [
            		new FrameText ("Text",
            			(IBinding data, string? value) => {(data as QuotePost)!.Text = value; },
            			(IBinding data) => (data as QuotePost)?.Text)
					]
				},
			new FrameSection ("OriginalAuthor") {
				Fields = [
            		new FrameString ("Base.User.DisplayName",
            			(IBinding data, string? value) => {(data as QuotePost)!.Base!.User!.DisplayName = value; },
            			(IBinding data) => (data as QuotePost)?.Base?.User?.DisplayName),
            		new FrameString ("Base.User.DisplayHandle",
            			(IBinding data, string? value) => {(data as QuotePost)!.Base!.User!.DisplayHandle = value; },
            			(IBinding data) => (data as QuotePost)?.Base?.User?.DisplayHandle),
            		new FrameDateTime ("Base.Created",
            			(IBinding data, System.DateTime? value) => {(data as QuotePost)!.Base!.Created = value; },
            			(IBinding data) => (data as QuotePost)?.Base?.Created)
					]
				},
			new FrameSection ("OriginalBody") {
				Fields = [
            		new FrameText ("Base.Text",
            			(IBinding data, string? value) => {(data as QuotePost)!.Base!.Text = value; },
            			(IBinding data) => (data as QuotePost)?.Base?.Text)
					]
				}
			]
		}.CacheValue(out quotemain)!;
	public static FramePresentation? quotemain;

	static readonly List<IFrameField> _Fields = [
		new FrameText ("Text",
			(IBinding data, string? value) => {(data as Post)!.Text = value; },
			(IBinding data) => (data as Post)?.Text),
		new FrameRefClass<User> ("User","User"){
			Get = (IBacked data) => (data as Post)?.User ,
			Set = (IBacked data, IBacked? value) => {(data as Post)!.User = value as User; }},
		new FrameInteger ("Comments",
			(IBinding data, int? value) => {(data as Post)!.Comments = value; },
			(IBinding data) => (data as Post)?.Comments),
		new FrameInteger ("Reposts",
			(IBinding data, int? value) => {(data as Post)!.Reposts = value; },
			(IBinding data) => (data as Post)?.Reposts),
		new FrameInteger ("QuotePosts",
			(IBinding data, int? value) => {(data as Post)!.QuotePosts = value; },
			(IBinding data) => (data as Post)?.QuotePosts),
		new FrameInteger ("AllReposts",
			(IBinding data, int? value) => {(data as Post)!.AllReposts = value; },
			(IBinding data) => (data as Post)?.AllReposts),
		new FrameInteger ("Likes",
			(IBinding data, int? value) => {(data as Post)!.Likes = value; },
			(IBinding data) => (data as Post)?.Likes),
		new FrameBoolean ("Liked",
			(IBinding data, bool? value) => {(data as Post)!.Liked = value; },
			(IBinding data) => (data as Post)?.Liked),
		new FrameBoolean ("RequestedMore",
			(IBinding data, bool? value) => {(data as Post)!.RequestedMore = value; },
			(IBinding data) => (data as Post)?.RequestedMore),
		new FrameBoolean ("RequestedLess",
			(IBinding data, bool? value) => {(data as Post)!.RequestedLess = value; },
			(IBinding data) => (data as Post)?.RequestedLess),
		new FrameString ("Replies",
			(IBinding data, string? value) => {(data as Post)!.Replies = value; },
			(IBinding data) => (data as Post)?.Replies),
		new FrameRefClass<Post> ("QuotedPost","Post"){
			Get = (IBacked data) => (data as Post)?.QuotedPost ,
			Set = (IBacked data, IBacked? value) => {(data as Post)!.QuotedPost = value as Post; }},
		Main,
		Quoted,
		new FrameRefClass<Post> ("Base","Post"){
			Get = (IBacked data) => (data as QuotePost)?.Base ,
			Set = (IBacked data, IBacked? value) => {(data as QuotePost)!.Base = value as Post; }},
		QuoteMain
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
	static readonly new Binding<QuotePost> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "QuotePost",
		() => new QuotePost(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for RePost
/// </summary>
public partial class RePost (string Id="RePost") : Post (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;

    /// <inheritdoc/>
    public override FramePresentation Presentation => ReMain;


	///<summary>class Post, Base</summary>
	public Post? Base {get; set;}


	/// <summary>
	/// Presentation style ReMain
	/// </summary>
	public static FramePresentation ReMain => remain ?? new FramePresentation ("ReMain") {
		GetUid = (IBacked data) => (data as RePost)?.Uid,
		Sections = [
			new FrameSection ("Avatar") {
				Fields = [
            		new FrameAvatar ("User.Avatar"){
            			Get = (IBinding data) => (data as RePost)?.User?.Avatar }
					]
				},
			new FrameSection ("Author") {
				Fields = [
            		new FrameString ("User.DisplayName",
            			(IBinding data, string? value) => {(data as RePost)!.User!.DisplayName = value; },
            			(IBinding data) => (data as RePost)?.User?.DisplayName),
            		new FrameString ("User.DisplayHandle",
            			(IBinding data, string? value) => {(data as RePost)!.User!.DisplayHandle = value; },
            			(IBinding data) => (data as RePost)?.User?.DisplayHandle),
            		new FrameDateTime ("Created",
            			(IBinding data, System.DateTime? value) => {(data as RePost)!.Created = value; },
            			(IBinding data) => (data as RePost)?.Created)
					]
				},
			new FrameSection ("OriginalAuthor") {
				Fields = [
            		new FrameString ("Base.User.DisplayName",
            			(IBinding data, string? value) => {(data as RePost)!.Base!.User!.DisplayName = value; },
            			(IBinding data) => (data as RePost)?.Base?.User?.DisplayName),
            		new FrameString ("Base.User.DisplayHandle",
            			(IBinding data, string? value) => {(data as RePost)!.Base!.User!.DisplayHandle = value; },
            			(IBinding data) => (data as RePost)?.Base?.User?.DisplayHandle),
            		new FrameDateTime ("Base.Created",
            			(IBinding data, System.DateTime? value) => {(data as RePost)!.Base!.Created = value; },
            			(IBinding data) => (data as RePost)?.Base?.Created)
					]
				},
			new FrameSection ("OriginalBody") {
				Fields = [
            		new FrameText ("Base.Text",
            			(IBinding data, string? value) => {(data as RePost)!.Base!.Text = value; },
            			(IBinding data) => (data as RePost)?.Base?.Text)
					]
				}
			]
		}.CacheValue(out remain)!;
	public static FramePresentation? remain;

	static readonly List<IFrameField> _Fields = [
		new FrameText ("Text",
			(IBinding data, string? value) => {(data as Post)!.Text = value; },
			(IBinding data) => (data as Post)?.Text),
		new FrameRefClass<User> ("User","User"){
			Get = (IBacked data) => (data as Post)?.User ,
			Set = (IBacked data, IBacked? value) => {(data as Post)!.User = value as User; }},
		new FrameInteger ("Comments",
			(IBinding data, int? value) => {(data as Post)!.Comments = value; },
			(IBinding data) => (data as Post)?.Comments),
		new FrameInteger ("Reposts",
			(IBinding data, int? value) => {(data as Post)!.Reposts = value; },
			(IBinding data) => (data as Post)?.Reposts),
		new FrameInteger ("QuotePosts",
			(IBinding data, int? value) => {(data as Post)!.QuotePosts = value; },
			(IBinding data) => (data as Post)?.QuotePosts),
		new FrameInteger ("AllReposts",
			(IBinding data, int? value) => {(data as Post)!.AllReposts = value; },
			(IBinding data) => (data as Post)?.AllReposts),
		new FrameInteger ("Likes",
			(IBinding data, int? value) => {(data as Post)!.Likes = value; },
			(IBinding data) => (data as Post)?.Likes),
		new FrameBoolean ("Liked",
			(IBinding data, bool? value) => {(data as Post)!.Liked = value; },
			(IBinding data) => (data as Post)?.Liked),
		new FrameBoolean ("RequestedMore",
			(IBinding data, bool? value) => {(data as Post)!.RequestedMore = value; },
			(IBinding data) => (data as Post)?.RequestedMore),
		new FrameBoolean ("RequestedLess",
			(IBinding data, bool? value) => {(data as Post)!.RequestedLess = value; },
			(IBinding data) => (data as Post)?.RequestedLess),
		new FrameString ("Replies",
			(IBinding data, string? value) => {(data as Post)!.Replies = value; },
			(IBinding data) => (data as Post)?.Replies),
		new FrameRefClass<Post> ("QuotedPost","Post"){
			Get = (IBacked data) => (data as Post)?.QuotedPost ,
			Set = (IBacked data, IBacked? value) => {(data as Post)!.QuotedPost = value as Post; }},
		Main,
		Quoted,
		new FrameRefClass<Post> ("Base","Post"){
			Get = (IBacked data) => (data as RePost)?.Base ,
			Set = (IBacked data, IBacked? value) => {(data as RePost)!.Base = value as Post; }},
		ReMain
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
	static readonly new Binding<RePost> _binding = new (
			new() {

			// Only inclue the serialized items here
			}, "RePost",
		() => new RePost(), () => [], () => [], null, Generic: false);


	}
/// <summary>
/// Backing class for ProfileData
/// </summary>
public partial class ProfileData (string Id="ProfileData") : FrameClass (Id) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



	///<summary>class User, User</summary>
	public User? User {get; set;}

    /// <summary>Field Avatar</summary>
	public string? Avatar {get; set;}

    /// <summary>Field Banner</summary>
	public string? Banner {get; set;}

    /// <summary>Field Description</summary>
	public string? Description {get; set;}

    /// <summary>Field Followers</summary>
	public int? Followers {get; set;}

    /// <summary>Field Following</summary>
	public int? Following {get; set;}

    /// <summary>Field Posts</summary>
	public int? Posts {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefClass<User> ("User","User"){
			Get = (IBacked data) => (data as ProfileData)?.User ,
			Set = (IBacked data, IBacked? value) => {(data as ProfileData)!.User = value as User; }},
		new FrameImage ("Avatar",
			(IBinding data, string? value) => {(data as ProfileData)!.Avatar = value; },
			(IBinding data) => (data as ProfileData)?.Avatar),
		new FrameImage ("Banner",
			(IBinding data, string? value) => {(data as ProfileData)!.Banner = value; },
			(IBinding data) => (data as ProfileData)?.Banner),
		new FrameText ("Description",
			(IBinding data, string? value) => {(data as ProfileData)!.Description = value; },
			(IBinding data) => (data as ProfileData)?.Description),
		new FrameInteger ("Followers",
			(IBinding data, int? value) => {(data as ProfileData)!.Followers = value; },
			(IBinding data) => (data as ProfileData)?.Followers),
		new FrameInteger ("Following",
			(IBinding data, int? value) => {(data as ProfileData)!.Following = value; },
			(IBinding data) => (data as ProfileData)?.Following),
		new FrameInteger ("Posts",
			(IBinding data, int? value) => {(data as ProfileData)!.Posts = value; },
			(IBinding data) => (data as ProfileData)?.Posts)
		];



    /// <inheritdoc/>
	public override Goedel.Protocol.Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Goedel.Protocol.Property[] _properties = [
		// Only inclue the serialized items here

		new FrameImage ("Avatar",
			(IBinding data, string? value) => {(data as ProfileData)!.Avatar = value; },
			(IBinding data) => (data as ProfileData)?.Avatar),
		new FrameImage ("Banner",
			(IBinding data, string? value) => {(data as ProfileData)!.Banner = value; },
			(IBinding data) => (data as ProfileData)?.Banner),
		new FrameText ("Description",
			(IBinding data, string? value) => {(data as ProfileData)!.Description = value; },
			(IBinding data) => (data as ProfileData)?.Description),
		new FrameInteger ("Followers",
			(IBinding data, int? value) => {(data as ProfileData)!.Followers = value; },
			(IBinding data) => (data as ProfileData)?.Followers),
		new FrameInteger ("Following",
			(IBinding data, int? value) => {(data as ProfileData)!.Following = value; },
			(IBinding data) => (data as ProfileData)?.Following),
		new FrameInteger ("Posts",
			(IBinding data, int? value) => {(data as ProfileData)!.Posts = value; },
			(IBinding data) => (data as ProfileData)?.Posts)		];

    /// <inheritdoc/>
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static readonly new Binding<ProfileData> _binding = new (
			new() {

			// Only inclue the serialized items here
			{"Avatar", _properties[0]},
			{"Banner", _properties[1]},
			{"Description", _properties[2]},
			{"Followers", _properties[3]},
			{"Following", _properties[4]},
			{"Posts", _properties[5]}
			}, "ProfileData",
		() => new ProfileData(), () => [], () => [], null, Generic: false);


	}


