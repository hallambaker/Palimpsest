

namespace Goedel.Html;

public class MyClass : FrameSet{

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
	///<summary>HomeFilter</summary>
	public HomeFilter HomeFilter {get;} = new();
	///<summary>PostMenu</summary>
	public PostMenu PostMenu {get;} = new();
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
	 ///<summary>NewPost</summary>
	 public NewPost NewPost {get;} = new();
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
			HomeFilter,
			PostMenu,
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
			NewPost,
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
		foreach (var backed in Classes) {
			ResolveReferences (backed); 
			}
		}


	}



// Pages
/// <summary>
/// Backing class for HomePage
/// </summary>
public class HomePage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public HomePage () : base ("HomePage", "Home", _Fields) {
		}

	static List<FrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRefClass ("Items","Post"),
		new FrameButton ("Settings", "Settings", "SettingsPage"),
		new FrameRefMenu ("Filter","HomeFilter"),
		];

	}
/// <summary>
/// Backing class for NotificationsPage
/// </summary>
public class NotificationsPage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public NotificationsPage () : base ("NotificationsPage", "Notifications", _Fields) {
		}

	static List<FrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRef ("x"),
		new FrameRefClass ("Items","Item"),
		];

	}
/// <summary>
/// Backing class for ChatsPage
/// </summary>
public class ChatsPage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public ChatsPage () : base ("ChatsPage", "Chat", _Fields) {
		}

	static List<FrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRef ("x"),
		new FrameRefClass ("Items","Chat"),
		];

	}
/// <summary>
/// Backing class for ChatingPage
/// </summary>
public class ChatingPage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public ChatingPage () : base ("ChatingPage", "Chatting", _Fields) {
		}

	static List<FrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRef ("x"),
		new FrameRefClass ("With","User"),
		new FrameRefClass ("Items","ChatText"),
		];

	}
/// <summary>
/// Backing class for FeedsPage
/// </summary>
public class FeedsPage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public FeedsPage () : base ("FeedsPage", "Feeds", _Fields) {
		}

	static List<FrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRef ("x"),
		];

	}
/// <summary>
/// Backing class for ProfilePage
/// </summary>
public class ProfilePage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public ProfilePage () : base ("ProfilePage", "Profile", _Fields) {
		}

	static List<FrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRef ("x"),
		new FrameRefClass ("Items","Post"),
		];

	}
/// <summary>
/// Backing class for SettingsPage
/// </summary>
public class SettingsPage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public SettingsPage () : base ("SettingsPage", "Settings", _Fields) {
		}

	static List<FrameField> _Fields = [
		new FrameButton ("SwitchAccount", "Switch account", "ProfileSelect"),
		new FrameButton ("Appearance", "Appearance", "AppearancePage"),
		new FrameSeparator ("x"),
		new FrameButton ("SignOut", "Sign out", "SignOutAction"),
		];

	}
/// <summary>
/// Backing class for AppearancePage
/// </summary>
public class AppearancePage : FramePage {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public AppearancePage () : base ("AppearancePage", "Appearance", _Fields) {
		}

	static List<FrameField> _Fields = [
		];

	}
/// <summary>
/// Backing class for NewPostPage
/// </summary>
public class NewPostPage : FramePage {

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

	static List<FrameField> _Fields = [
		new FrameButton ("Cancel", "Cancel", "Cancel"),
		new FrameButton ("Post", "Post", "Post"),
		new FrameImage ("Avatar") {
			Get = (FrameBacker data) => (data as NewPostPage)?.Avatar ,
			Set = (FrameBacker data, string? value) => {(data as NewPostPage)!.Avatar = value; }},
		new FrameText ("Text") {
			Get = (FrameBacker data) => (data as NewPostPage)?.Text ,
			Set = (FrameBacker data, string? value) => {(data as NewPostPage)!.Text = value; }},
		new FrameButton ("Image", "Image", "Image"),
		new FrameButton ("Video", "Video", "Video"),
		new FrameString ("Language") {
			Get = (FrameBacker data) => (data as NewPostPage)?.Language ,
			Set = (FrameBacker data, string? value) => {(data as NewPostPage)!.Language = value; }},
		new FrameCount ("Characters") {
			Get = (FrameBacker data) => (data as NewPostPage)?.Characters ,
			Set = (FrameBacker data, int? value) => {(data as NewPostPage)!.Characters = value; }},
		];

	}

// Menus 
/// <summary>
/// Backing class for MainNav
/// </summary>
public class MainNav : FrameMenu {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public MainNav () : base ("MainNav", _Fields) {
		}

	static List<FrameField> _Fields = [
		new FrameRef ("Profiles"),
		new FrameButton ("Home", "Home", "HomePage"),
		new FrameButton ("Notifications", "Notifications", "NotificationsPage"),
		new FrameButton ("Chats", "Chats", "ChatsPage"),
		new FrameButton ("Feeds", "Feeds", "FeedsPage"),
		new FrameButton ("Profile", "Profile", "ProfilePage"),
		new FrameButton ("Settings", "Settings", "SettingsPage"),
		new FrameButton ("NewPost", "New Post", "NewPostPage"),
		];

	}
/// <summary>
/// Backing class for HomeFilter
/// </summary>
public class HomeFilter : FrameMenu {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public HomeFilter () : base ("HomeFilter", _Fields) {
		}

	static List<FrameField> _Fields = [
		new FrameButton ("All", "All", "FilterAll"),
		new FrameButton ("Mentions", "Mentions", "FilterMentions"),
		];

	}
/// <summary>
/// Backing class for PostMenu
/// </summary>
public class PostMenu : FrameMenu {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public PostMenu () : base ("PostMenu", _Fields) {
		}

	static List<FrameField> _Fields = [
		new FrameButton ("Comment", "Home", "CommentAction"),
		new FrameButton ("Like", "Like", "LikeAction"),
		new FrameButton ("More", "More", "MoreAction"),
		new FrameButton ("Less", "Less", "LessAction"),
		];

	}
/// <summary>
/// Backing class for ProfileFilter
/// </summary>
public class ProfileFilter : FrameMenu {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public ProfileFilter () : base ("ProfileFilter", _Fields) {
		}

	static List<FrameField> _Fields = [
		new FrameButton ("Posts", "All", "FilterPosts"),
		new FrameButton ("Replies", "Mentions", "FilterReplies"),
		new FrameButton ("Media", "Mentions", "FilterMedia"),
		new FrameButton ("Videos", "Mentions", "FilterVideos"),
		new FrameButton ("Likes", "Mentions", "FilterLikes"),
		new FrameButton ("Feeds", "Mentions", "FilterFeeds"),
		];

	}

// Classes 
/// <summary>
/// Backing class for ProfileSelect
/// </summary>
public class ProfileSelect : FrameSelector {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public ProfileSelect () : base ("ProfileSelect") {
		}

	}



// Classes 
/// <summary>
/// Backing class for User
/// </summary>
public class User : FrameClass {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public User () : base ("User", _Fields) {
		}

    /// <summary>Field DID</summary>
	public string? DID {get; set;}

    /// <summary>Field Avatar</summary>
	public string? Avatar {get; set;}

    /// <summary>Field DisplayName</summary>
	public string? DisplayName {get; set;}

    /// <summary>Field DiaplayHandle</summary>
	public string? DiaplayHandle {get; set;}

	static List<FrameField> _Fields = [
		new FrameString ("DID") {
			Get = (FrameBacker data) => (data as User)?.DID ,
			Set = (FrameBacker data, string? value) => {(data as User)!.DID = value; }},
		new FrameImage ("Avatar") {
			Get = (FrameBacker data) => (data as User)?.Avatar ,
			Set = (FrameBacker data, string? value) => {(data as User)!.Avatar = value; }},
		new FrameString ("DisplayName") {
			Get = (FrameBacker data) => (data as User)?.DisplayName ,
			Set = (FrameBacker data, string? value) => {(data as User)!.DisplayName = value; }},
		new FrameString ("DiaplayHandle") {
			Get = (FrameBacker data) => (data as User)?.DiaplayHandle ,
			Set = (FrameBacker data, string? value) => {(data as User)!.DiaplayHandle = value; }},
		];

	}
/// <summary>
/// Backing class for Item
/// </summary>
public class Item : FrameClass {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public Item () : base ("Item", _Fields) {
		}

    /// <summary>Field Id</summary>
	public string? Id {get; set;}

    /// <summary>Field Created</summary>
	public System.DateTime? Created {get; set;}

	static List<FrameField> _Fields = [
		new FrameString ("Id") {
			Get = (FrameBacker data) => (data as Item)?.Id ,
			Set = (FrameBacker data, string? value) => {(data as Item)!.Id = value; }},
		new FrameDateTime ("Created") {
			Get = (FrameBacker data) => (data as Item)?.Created ,
			Set = (FrameBacker data, System.DateTime? value) => {(data as Item)!.Created = value; }},
		];

	}
/// <summary>
/// Backing class for Chat
/// </summary>
public class Chat : FrameClass {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public Chat () : base ("Chat", _Fields) {
		}

	static List<FrameField> _Fields = [
		new FrameRefClass ("User","User"),
		new FrameRefClass ("Messages","ChatText"),
		];

	}
/// <summary>
/// Backing class for ChatText
/// </summary>
public class ChatText : FrameClass {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public ChatText () : base ("ChatText", _Fields) {
		}

    /// <summary>Field Created</summary>
	public System.DateTime? Created {get; set;}

    /// <summary>Field Self</summary>
	public bool? Self {get; set;}

    /// <summary>Field Text</summary>
	public string? Text {get; set;}

	static List<FrameField> _Fields = [
		new FrameDateTime ("Created") {
			Get = (FrameBacker data) => (data as ChatText)?.Created ,
			Set = (FrameBacker data, System.DateTime? value) => {(data as ChatText)!.Created = value; }},
		new FrameBoolean ("Self") {
			Get = (FrameBacker data) => (data as ChatText)?.Self ,
			Set = (FrameBacker data, bool? value) => {(data as ChatText)!.Self = value; }},
		new FrameText ("Text") {
			Get = (FrameBacker data) => (data as ChatText)?.Text ,
			Set = (FrameBacker data, string? value) => {(data as ChatText)!.Text = value; }},
		];

	}
/// <summary>
/// Backing class for Reaction
/// </summary>
public class Reaction : FrameClass {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public Reaction () : base ("Reaction", _Fields) {
		}

    /// <summary>Field Type</summary>
	public string? Type {get; set;}

	static List<FrameField> _Fields = [
		new FrameString ("Type") {
			Get = (FrameBacker data) => (data as Reaction)?.Type ,
			Set = (FrameBacker data, string? value) => {(data as Reaction)!.Type = value; }},
		new FrameRefClass ("Users","User"),
		];

	}
/// <summary>
/// Backing class for Post
/// </summary>
public class Post : FrameClass {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public Post () : base ("Post", _Fields) {
		}

	static List<FrameField> _Fields = [
		new FrameRefClass ("User","User"),
		];

	}
/// <summary>
/// Backing class for NewPost
/// </summary>
public class NewPost : FrameClass {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public NewPost () : base ("NewPost", _Fields) {
		}

    /// <summary>Field Text</summary>
	public string? Text {get; set;}

	static List<FrameField> _Fields = [
		new FrameText ("Text") {
			Get = (FrameBacker data) => (data as NewPost)?.Text ,
			Set = (FrameBacker data, string? value) => {(data as NewPost)!.Text = value; }},
		];

	}
/// <summary>
/// Backing class for QuotePost
/// </summary>
public class QuotePost : FrameClass {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public QuotePost () : base ("QuotePost", _Fields) {
		}

	static List<FrameField> _Fields = [
		new FrameRefClass ("Base","Post"),
		];

	}
/// <summary>
/// Backing class for RePost
/// </summary>
public class RePost : FrameClass {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public RePost () : base ("RePost", _Fields) {
		}

	static List<FrameField> _Fields = [
		new FrameRefClass ("Base","Post"),
		];

	}
/// <summary>
/// Backing class for ProfileData
/// </summary>
public class ProfileData : FrameClass {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public ProfileData () : base ("ProfileData", _Fields) {
		}

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

	static List<FrameField> _Fields = [
		new FrameRefClass ("User","User"),
		new FrameImage ("Avatar") {
			Get = (FrameBacker data) => (data as ProfileData)?.Avatar ,
			Set = (FrameBacker data, string? value) => {(data as ProfileData)!.Avatar = value; }},
		new FrameImage ("Banner") {
			Get = (FrameBacker data) => (data as ProfileData)?.Banner ,
			Set = (FrameBacker data, string? value) => {(data as ProfileData)!.Banner = value; }},
		new FrameText ("Description") {
			Get = (FrameBacker data) => (data as ProfileData)?.Description ,
			Set = (FrameBacker data, string? value) => {(data as ProfileData)!.Description = value; }},
		new FrameInteger ("Followers") {
			Get = (FrameBacker data) => (data as ProfileData)?.Followers ,
			Set = (FrameBacker data, int? value) => {(data as ProfileData)!.Followers = value; }},
		new FrameInteger ("Following") {
			Get = (FrameBacker data) => (data as ProfileData)?.Following ,
			Set = (FrameBacker data, int? value) => {(data as ProfileData)!.Following = value; }},
		new FrameInteger ("Posts") {
			Get = (FrameBacker data) => (data as ProfileData)?.Posts ,
			Set = (FrameBacker data, int? value) => {(data as ProfileData)!.Posts = value; }},
		];

	}

