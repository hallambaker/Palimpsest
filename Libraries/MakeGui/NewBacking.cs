
namespace Frame;

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

	// ref class List<Post>, Items
	public List<Post>? Items {get; set;}

	static List<FrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRefList<Post> ("Items","Post"){
			Get = (IBacked data) => (data as HomePage)?.Items ,
			Set = (IBacked data, Object? value) => {(data as HomePage)!.Items = value as List<Post>; }},
		new FrameButton ("Settings", "Settings", "SettingsPage") {
			}		];



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

	// ref class List<Item>, Items
	public List<Item>? Items {get; set;}

	static List<FrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRefMenu ("Filter","HomeFilter"),
		new FrameRef ("x"),
		new FrameRefList<Item> ("Items","Item"){
			Get = (IBacked data) => (data as NotificationsPage)?.Items ,
			Set = (IBacked data, Object? value) => {(data as NotificationsPage)!.Items = value as List<Item>; }}		];



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

	// ref class List<Chat>, Items
	public List<Chat>? Items {get; set;}

	static List<FrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRef ("x"),
		new FrameRefList<Chat> ("Items","Chat"){
			Get = (IBacked data) => (data as ChatsPage)?.Items ,
			Set = (IBacked data, Object? value) => {(data as ChatsPage)!.Items = value as List<Chat>; }}		];



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

	// ref class User, With
	public User? With {get; set;}

	// ref class List<ChatText>, Items
	public List<ChatText>? Items {get; set;}

	static List<FrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRef ("x"),
		new FrameRefClass<User> ("With","User"){
			Get = (IBacked data) => (data as ChatingPage)?.With ,
			Set = (IBacked data, IBacked? value) => {(data as ChatingPage)!.With = value as User; }},
		new FrameRefList<ChatText> ("Items","ChatText"){
			Get = (IBacked data) => (data as ChatingPage)?.Items ,
			Set = (IBacked data, Object? value) => {(data as ChatingPage)!.Items = value as List<ChatText>; }}		];



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

	static List<FrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRef ("x")		];



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

	// ref class List<Post>, Items
	public List<Post>? Items {get; set;}

	static List<FrameField> _Fields = [
		new FrameRefMenu ("Navigation","MainNav"),
		new FrameRef ("x"),
		new FrameRefList<Post> ("Items","Post"){
			Get = (IBacked data) => (data as ProfilePage)?.Items ,
			Set = (IBacked data, Object? value) => {(data as ProfilePage)!.Items = value as List<Post>; }}		];



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

	static List<FrameField> _Fields = [
		new FrameButton ("SwitchAccount", "Switch account", "ProfileSelect") {
			},
		new FrameButton ("Appearance", "Appearance", "AppearancePage") {
			},
		new FrameSeparator ("x"),
		new FrameButton ("SignOut", "Sign out", "SignOutAction") {
			}		];



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

	static List<FrameField> _Fields = [		];



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

	static List<FrameField> _Fields = [
		new FrameButton ("Cancel", "Cancel", "Cancel") {
			},
		new FrameButton ("Post", "Post", "Post") {
			},
		new FrameImage ("Avatar") {
			Get = (IBacked data) => (data as NewPostPage)?.Avatar ,
			Set = (IBacked data, string? value) => {(data as NewPostPage)!.Avatar = value; }},
		new FrameText ("Text") {
			Get = (IBacked data) => (data as NewPostPage)?.Text ,
			Set = (IBacked data, string? value) => {(data as NewPostPage)!.Text = value; }},
		new FrameButton ("Image", "Image", "Image") {
			},
		new FrameButton ("Video", "Video", "Video") {
			},
		new FrameString ("Language") {
			Get = (IBacked data) => (data as NewPostPage)?.Language ,
			Set = (IBacked data, string? value) => {(data as NewPostPage)!.Language = value; }},
		new FrameCount ("Characters") {
			Get = (IBacked data) => (data as NewPostPage)?.Characters ,
			Set = (IBacked data, int? value) => {(data as NewPostPage)!.Characters = value; }}		];



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

	static List<FrameField> _Fields = [
		new FrameInteger ("NotificationCount") {
			Get = (IBacked data) => (data as MainNav)?.NotificationCount ,
			Set = (IBacked data, int? value) => {(data as MainNav)!.NotificationCount = value; }},
		new FrameRef ("Profiles"),
		new FrameButton ("Home", "Home", "HomePage") {
			},
		new FrameButton ("Notifications", "Notifications", "NotificationsPage") {
			GetInteger = (IBacked data) => (data as MainNav)?.NotificationCount
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
			}		];



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

	static List<FrameField> _Fields = [
		new FrameButton ("All", "All", "FilterAll") {
			},
		new FrameButton ("Mentions", "Mentions", "FilterMentions") {
			}		];



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

	static List<FrameField> _Fields = [
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
			}		];



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

	static List<FrameField> _Fields = [
		new FrameImage ("Avatar") {
			Get = (IBacked data) => (data as ProfileSelect)?.Avatar ,
			Set = (IBacked data, string? value) => {(data as ProfileSelect)!.Avatar = value; }},
		new FrameString ("DisplayName") {
			Get = (IBacked data) => (data as ProfileSelect)?.DisplayName ,
			Set = (IBacked data, string? value) => {(data as ProfileSelect)!.DisplayName = value; }},
		new FrameString ("DiaplayHandle") {
			Get = (IBacked data) => (data as ProfileSelect)?.DiaplayHandle ,
			Set = (IBacked data, string? value) => {(data as ProfileSelect)!.DiaplayHandle = value; }},
		new FrameButton ("AddAccount", "Add another account", "AddAccountAction") {
			},
		new FrameButton ("SignOut", "Sign out", "SignOutAction") {
			}		];



	}



// Classes 
/// <summary>
/// Backing class for User
/// </summary>
public partial class User : FrameClass {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public User (string id="User") : base ("User") {
		}


    public override List<FrameField> Fields { get; set; } = _Fields;



    /// <summary>Field DID</summary>
	public string? DID {get; set;}

	// Avatar Avatar
	public string Avatar => GetAvatar;

    /// <summary>Field DisplayName</summary>
	public string? DisplayName {get; set;}

    /// <summary>Field DisplayHandle</summary>
	public string? DisplayHandle {get; set;}

	static List<FrameField> _Fields = [
		new FrameString ("DID") {
			Get = (IBacked data) => (data as User)?.DID ,
			Set = (IBacked data, string? value) => {(data as User)!.DID = value; }},
		new FrameAvatar ("Avatar"){
			Get = (IBacked data) => (data as User)?.Avatar },
		new FrameString ("DisplayName") {
			Get = (IBacked data) => (data as User)?.DisplayName ,
			Set = (IBacked data, string? value) => {(data as User)!.DisplayName = value; }},
		new FrameString ("DisplayHandle") {
			Get = (IBacked data) => (data as User)?.DisplayHandle ,
			Set = (IBacked data, string? value) => {(data as User)!.DisplayHandle = value; }}		];



	}
/// <summary>
/// Backing class for Item
/// </summary>
public partial class Item : FrameClass {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public Item (string id="Item") : base ("Item") {
		}


    public override List<FrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Id</summary>
	public string? Id {get; set;}

    /// <summary>Field Created</summary>
	public System.DateTime? Created {get; set;}

	static List<FrameField> _Fields = [
		new FrameString ("Id") {
			Get = (IBacked data) => (data as Item)?.Id ,
			Set = (IBacked data, string? value) => {(data as Item)!.Id = value; }},
		new FrameDateTime ("Created") {
			Get = (IBacked data) => (data as Item)?.Created ,
			Set = (IBacked data, System.DateTime? value) => {(data as Item)!.Created = value; }}		];



	}
/// <summary>
/// Backing class for Chat
/// </summary>
public partial class Chat : Item {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public Chat (string id="Chat") : base ("Chat") {
		}


    public override List<FrameField> Fields { get; set; } = _Fields;



	// ref class User, User
	public User? User {get; set;}

	// ref class List<ChatText>, Messages
	public List<ChatText>? Messages {get; set;}

	static List<FrameField> _Fields = [
		new FrameString ("Id") {
			Get = (IBacked data) => (data as Item)?.Id ,
			Set = (IBacked data, string? value) => {(data as Item)!.Id = value; }},
		new FrameDateTime ("Created") {
			Get = (IBacked data) => (data as Item)?.Created ,
			Set = (IBacked data, System.DateTime? value) => {(data as Item)!.Created = value; }},
		new FrameRefClass<User> ("User","User"){
			Get = (IBacked data) => (data as Chat)?.User ,
			Set = (IBacked data, IBacked? value) => {(data as Chat)!.User = value as User; }},
		new FrameRefList<ChatText> ("Messages","ChatText"){
			Get = (IBacked data) => (data as Chat)?.Messages ,
			Set = (IBacked data, Object? value) => {(data as Chat)!.Messages = value as List<ChatText>; }}		];



	}
/// <summary>
/// Backing class for ChatText
/// </summary>
public partial class ChatText : FrameClass {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public ChatText (string id="ChatText") : base ("ChatText") {
		}


    public override List<FrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Created</summary>
	public System.DateTime? Created {get; set;}

    /// <summary>Field Self</summary>
	public bool? Self {get; set;}

    /// <summary>Field Text</summary>
	public string? Text {get; set;}

	static List<FrameField> _Fields = [
		new FrameDateTime ("Created") {
			Get = (IBacked data) => (data as ChatText)?.Created ,
			Set = (IBacked data, System.DateTime? value) => {(data as ChatText)!.Created = value; }},
		new FrameBoolean ("Self") {
			Get = (IBacked data) => (data as ChatText)?.Self ,
			Set = (IBacked data, bool? value) => {(data as ChatText)!.Self = value; }},
		new FrameText ("Text") {
			Get = (IBacked data) => (data as ChatText)?.Text ,
			Set = (IBacked data, string? value) => {(data as ChatText)!.Text = value; }}		];



	}
/// <summary>
/// Backing class for Reaction
/// </summary>
public partial class Reaction : Item {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public Reaction (string id="Reaction") : base ("Reaction") {
		}


    public override List<FrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Type</summary>
	public string? Type {get; set;}

	// ref class List<User>, Users
	public List<User>? Users {get; set;}

	static List<FrameField> _Fields = [
		new FrameString ("Id") {
			Get = (IBacked data) => (data as Item)?.Id ,
			Set = (IBacked data, string? value) => {(data as Item)!.Id = value; }},
		new FrameDateTime ("Created") {
			Get = (IBacked data) => (data as Item)?.Created ,
			Set = (IBacked data, System.DateTime? value) => {(data as Item)!.Created = value; }},
		new FrameString ("Type") {
			Get = (IBacked data) => (data as Reaction)?.Type ,
			Set = (IBacked data, string? value) => {(data as Reaction)!.Type = value; }},
		new FrameRefList<User> ("Users","User"){
			Get = (IBacked data) => (data as Reaction)?.Users ,
			Set = (IBacked data, Object? value) => {(data as Reaction)!.Users = value as List<User>; }}		];



	}
/// <summary>
/// Backing class for Post
/// </summary>
public partial class Post : Item {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public Post (string id="Post") : base ("Post") {
		}


    public override List<FrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Text</summary>
	public string? Text {get; set;}

	// ref class User, User
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

	static List<FrameField> _Fields = [
		new FrameString ("Id") {
			Get = (IBacked data) => (data as Item)?.Id ,
			Set = (IBacked data, string? value) => {(data as Item)!.Id = value; }},
		new FrameDateTime ("Created") {
			Get = (IBacked data) => (data as Item)?.Created ,
			Set = (IBacked data, System.DateTime? value) => {(data as Item)!.Created = value; }},
		new FrameText ("Text") {
			Get = (IBacked data) => (data as Post)?.Text ,
			Set = (IBacked data, string? value) => {(data as Post)!.Text = value; }},
		new FrameRefClass<User> ("User","User"){
			Get = (IBacked data) => (data as Post)?.User ,
			Set = (IBacked data, IBacked? value) => {(data as Post)!.User = value as User; }},
		new FrameInteger ("Comments") {
			Get = (IBacked data) => (data as Post)?.Comments ,
			Set = (IBacked data, int? value) => {(data as Post)!.Comments = value; }},
		new FrameInteger ("Reposts") {
			Get = (IBacked data) => (data as Post)?.Reposts ,
			Set = (IBacked data, int? value) => {(data as Post)!.Reposts = value; }},
		new FrameInteger ("QuotePosts") {
			Get = (IBacked data) => (data as Post)?.QuotePosts ,
			Set = (IBacked data, int? value) => {(data as Post)!.QuotePosts = value; }},
		new FrameInteger ("AllReposts") {
			Get = (IBacked data) => (data as Post)?.AllReposts ,
			Set = (IBacked data, int? value) => {(data as Post)!.AllReposts = value; }},
		new FrameInteger ("Likes") {
			Get = (IBacked data) => (data as Post)?.Likes ,
			Set = (IBacked data, int? value) => {(data as Post)!.Likes = value; }},
		new FrameBoolean ("Liked") {
			Get = (IBacked data) => (data as Post)?.Liked ,
			Set = (IBacked data, bool? value) => {(data as Post)!.Liked = value; }},
		new FrameBoolean ("RequestedMore") {
			Get = (IBacked data) => (data as Post)?.RequestedMore ,
			Set = (IBacked data, bool? value) => {(data as Post)!.RequestedMore = value; }},
		new FrameBoolean ("RequestedLess") {
			Get = (IBacked data) => (data as Post)?.RequestedLess ,
			Set = (IBacked data, bool? value) => {(data as Post)!.RequestedLess = value; }},
		new FrameString ("Replies") {
			Get = (IBacked data) => (data as Post)?.Replies ,
			Set = (IBacked data, string? value) => {(data as Post)!.Replies = value; }},
		Main		];


	/// <summary>
	/// Presentation style Main
	/// </summary>
	public static FramePresentation Main {get;} = new ("Main") {
		Sections = [
			new FrameSection ("Avatar") {
				Fields = [
            		new FrameAvatar ("User.Avatar"){
            			Get = (IBacked data) => (data as Post)?.User?.Avatar }
					]
				},
			new FrameSection ("Author") {
				Fields = [
            		new FrameString ("User.DisplayName") {
            			Get = (IBacked data) => (data as Post)?.User?.DisplayName ,
            			Set = (IBacked data, string? value) => {(data as Post)!.User!.DisplayName = value; }},
            		new FrameDateTime ("Created") {
            			Get = (IBacked data) => (data as Post)?.Created ,
            			Set = (IBacked data, System.DateTime? value) => {(data as Post)!.Created = value; }}
					]
				},
			new FrameSection ("Body") {
				Fields = [
            		new FrameText ("Text") {
            			Get = (IBacked data) => (data as Post)?.Text ,
            			Set = (IBacked data, string? value) => {(data as Post)!.Text = value; }}
					]
				},
			new FrameSection ("Detail") {
				Fields = [
            		new FrameDateTime ("Created") {
            			Get = (IBacked data) => (data as Post)?.Created ,
            			Set = (IBacked data, System.DateTime? value) => {(data as Post)!.Created = value; }},
            		new FrameString ("Replies") {
            			Get = (IBacked data) => (data as Post)?.Replies ,
            			Set = (IBacked data, string? value) => {(data as Post)!.Replies = value; }}
					]
				},
			new FrameSection ("Responses") {
				Fields = [
            		new FrameButton ("Comment", "Home", "CommentAction") {
            			GetInteger = (IBacked data) => (data as Post)?.Comments
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
            			GetActive = (IBacked data) => (data as Post)?.Liked,
            			GetInteger = (IBacked data) => (data as Post)?.Likes
            			},
            		new FrameButton ("More", "More", "MoreAction") {
            			GetActive = (IBacked data) => (data as Post)?.RequestedMore
            			},
            		new FrameButton ("Less", "Less", "LessAction") {
            			GetActive = (IBacked data) => (data as Post)?.RequestedLess
            			},
            		new FrameSubmenu ("Share", "Share") {
            			Fields = [
                    		new FrameButton ("CopyLink", "Copy link to post", "HomePage") {
                    			},
                    		new FrameButton ("ShareDM", "Send via direct message", "HomePage") {
                    			},
                    		new FrameButton ("Embed", "Embed post", "HomePage") {
                    			}
            				]
            			},
            		new FrameSubmenu ("Ellipsis", "More") {
            			Fields = [
                    		new FrameButton ("Translate", "Translate", "TranslateAction") {
                    			},
                    		new FrameButton ("CopyPostText", "Copy post text", "CopyPostAction") {
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
		};


	}
/// <summary>
/// Backing class for QuotePost
/// </summary>
public partial class QuotePost : Post {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public QuotePost (string id="QuotePost") : base ("QuotePost") {
		}


    public override List<FrameField> Fields { get; set; } = _Fields;



	// ref class Post, Base
	public Post? Base {get; set;}

	static List<FrameField> _Fields = [
		new FrameText ("Text") {
			Get = (IBacked data) => (data as Post)?.Text ,
			Set = (IBacked data, string? value) => {(data as Post)!.Text = value; }},
		new FrameRefClass<User> ("User","User"){
			Get = (IBacked data) => (data as Post)?.User ,
			Set = (IBacked data, IBacked? value) => {(data as Post)!.User = value as User; }},
		new FrameInteger ("Comments") {
			Get = (IBacked data) => (data as Post)?.Comments ,
			Set = (IBacked data, int? value) => {(data as Post)!.Comments = value; }},
		new FrameInteger ("Reposts") {
			Get = (IBacked data) => (data as Post)?.Reposts ,
			Set = (IBacked data, int? value) => {(data as Post)!.Reposts = value; }},
		new FrameInteger ("QuotePosts") {
			Get = (IBacked data) => (data as Post)?.QuotePosts ,
			Set = (IBacked data, int? value) => {(data as Post)!.QuotePosts = value; }},
		new FrameInteger ("AllReposts") {
			Get = (IBacked data) => (data as Post)?.AllReposts ,
			Set = (IBacked data, int? value) => {(data as Post)!.AllReposts = value; }},
		new FrameInteger ("Likes") {
			Get = (IBacked data) => (data as Post)?.Likes ,
			Set = (IBacked data, int? value) => {(data as Post)!.Likes = value; }},
		new FrameBoolean ("Liked") {
			Get = (IBacked data) => (data as Post)?.Liked ,
			Set = (IBacked data, bool? value) => {(data as Post)!.Liked = value; }},
		new FrameBoolean ("RequestedMore") {
			Get = (IBacked data) => (data as Post)?.RequestedMore ,
			Set = (IBacked data, bool? value) => {(data as Post)!.RequestedMore = value; }},
		new FrameBoolean ("RequestedLess") {
			Get = (IBacked data) => (data as Post)?.RequestedLess ,
			Set = (IBacked data, bool? value) => {(data as Post)!.RequestedLess = value; }},
		new FrameString ("Replies") {
			Get = (IBacked data) => (data as Post)?.Replies ,
			Set = (IBacked data, string? value) => {(data as Post)!.Replies = value; }},
		Main,
		new FrameRefClass<Post> ("Base","Post"){
			Get = (IBacked data) => (data as QuotePost)?.Base ,
			Set = (IBacked data, IBacked? value) => {(data as QuotePost)!.Base = value as Post; }},
		QuoteMain		];


	/// <summary>
	/// Presentation style QuoteMain
	/// </summary>
	public static FramePresentation QuoteMain {get;} = new ("QuoteMain") {
		Sections = [
			new FrameSection ("Avatar") {
				Fields = [
            		new FrameAvatar ("User.Avatar"){
            			Get = (IBacked data) => (data as QuotePost)?.User?.Avatar }
					]
				},
			new FrameSection ("Author") {
				Fields = [
            		new FrameString ("User.DisplayName") {
            			Get = (IBacked data) => (data as QuotePost)?.User?.DisplayName ,
            			Set = (IBacked data, string? value) => {(data as QuotePost)!.User!.DisplayName = value; }},
            		new FrameString ("User.DisplayHandle") {
            			Get = (IBacked data) => (data as QuotePost)?.User?.DisplayHandle ,
            			Set = (IBacked data, string? value) => {(data as QuotePost)!.User!.DisplayHandle = value; }},
            		new FrameDateTime ("Created") {
            			Get = (IBacked data) => (data as QuotePost)?.Created ,
            			Set = (IBacked data, System.DateTime? value) => {(data as QuotePost)!.Created = value; }}
					]
				},
			new FrameSection ("Body") {
				Fields = [
            		new FrameText ("Text") {
            			Get = (IBacked data) => (data as QuotePost)?.Text ,
            			Set = (IBacked data, string? value) => {(data as QuotePost)!.Text = value; }}
					]
				},
			new FrameSection ("OriginalAuthor") {
				Fields = [
            		new FrameString ("Base.User.DisplayName") {
            			Get = (IBacked data) => (data as QuotePost)?.Base?.User?.DisplayName ,
            			Set = (IBacked data, string? value) => {(data as QuotePost)!.Base!.User!.DisplayName = value; }},
            		new FrameString ("Base.User.DisplayHandle") {
            			Get = (IBacked data) => (data as QuotePost)?.Base?.User?.DisplayHandle ,
            			Set = (IBacked data, string? value) => {(data as QuotePost)!.Base!.User!.DisplayHandle = value; }},
            		new FrameDateTime ("Base.Created") {
            			Get = (IBacked data) => (data as QuotePost)?.Base?.Created ,
            			Set = (IBacked data, System.DateTime? value) => {(data as QuotePost)!.Base!.Created = value; }}
					]
				},
			new FrameSection ("OriginalBody") {
				Fields = [
            		new FrameText ("Base.Text") {
            			Get = (IBacked data) => (data as QuotePost)?.Base?.Text ,
            			Set = (IBacked data, string? value) => {(data as QuotePost)!.Base!.Text = value; }}
					]
				}
			]
		};


	}
/// <summary>
/// Backing class for RePost
/// </summary>
public partial class RePost : Post {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public RePost (string id="RePost") : base ("RePost") {
		}


    public override List<FrameField> Fields { get; set; } = _Fields;



	// ref class Post, Base
	public Post? Base {get; set;}

	static List<FrameField> _Fields = [
		new FrameText ("Text") {
			Get = (IBacked data) => (data as Post)?.Text ,
			Set = (IBacked data, string? value) => {(data as Post)!.Text = value; }},
		new FrameRefClass<User> ("User","User"){
			Get = (IBacked data) => (data as Post)?.User ,
			Set = (IBacked data, IBacked? value) => {(data as Post)!.User = value as User; }},
		new FrameInteger ("Comments") {
			Get = (IBacked data) => (data as Post)?.Comments ,
			Set = (IBacked data, int? value) => {(data as Post)!.Comments = value; }},
		new FrameInteger ("Reposts") {
			Get = (IBacked data) => (data as Post)?.Reposts ,
			Set = (IBacked data, int? value) => {(data as Post)!.Reposts = value; }},
		new FrameInteger ("QuotePosts") {
			Get = (IBacked data) => (data as Post)?.QuotePosts ,
			Set = (IBacked data, int? value) => {(data as Post)!.QuotePosts = value; }},
		new FrameInteger ("AllReposts") {
			Get = (IBacked data) => (data as Post)?.AllReposts ,
			Set = (IBacked data, int? value) => {(data as Post)!.AllReposts = value; }},
		new FrameInteger ("Likes") {
			Get = (IBacked data) => (data as Post)?.Likes ,
			Set = (IBacked data, int? value) => {(data as Post)!.Likes = value; }},
		new FrameBoolean ("Liked") {
			Get = (IBacked data) => (data as Post)?.Liked ,
			Set = (IBacked data, bool? value) => {(data as Post)!.Liked = value; }},
		new FrameBoolean ("RequestedMore") {
			Get = (IBacked data) => (data as Post)?.RequestedMore ,
			Set = (IBacked data, bool? value) => {(data as Post)!.RequestedMore = value; }},
		new FrameBoolean ("RequestedLess") {
			Get = (IBacked data) => (data as Post)?.RequestedLess ,
			Set = (IBacked data, bool? value) => {(data as Post)!.RequestedLess = value; }},
		new FrameString ("Replies") {
			Get = (IBacked data) => (data as Post)?.Replies ,
			Set = (IBacked data, string? value) => {(data as Post)!.Replies = value; }},
		Main,
		new FrameRefClass<Post> ("Base","Post"){
			Get = (IBacked data) => (data as RePost)?.Base ,
			Set = (IBacked data, IBacked? value) => {(data as RePost)!.Base = value as Post; }},
		ReMain		];


	/// <summary>
	/// Presentation style ReMain
	/// </summary>
	public static FramePresentation ReMain {get;} = new ("ReMain") {
		Sections = [
			new FrameSection ("Avatar") {
				Fields = [
            		new FrameAvatar ("User.Avatar"){
            			Get = (IBacked data) => (data as RePost)?.User?.Avatar }
					]
				},
			new FrameSection ("Author") {
				Fields = [
            		new FrameString ("User.DisplayName") {
            			Get = (IBacked data) => (data as RePost)?.User?.DisplayName ,
            			Set = (IBacked data, string? value) => {(data as RePost)!.User!.DisplayName = value; }},
            		new FrameString ("User.DisplayHandle") {
            			Get = (IBacked data) => (data as RePost)?.User?.DisplayHandle ,
            			Set = (IBacked data, string? value) => {(data as RePost)!.User!.DisplayHandle = value; }},
            		new FrameDateTime ("Created") {
            			Get = (IBacked data) => (data as RePost)?.Created ,
            			Set = (IBacked data, System.DateTime? value) => {(data as RePost)!.Created = value; }}
					]
				},
			new FrameSection ("OriginalAuthor") {
				Fields = [
            		new FrameString ("Base.User.DisplayName") {
            			Get = (IBacked data) => (data as RePost)?.Base?.User?.DisplayName ,
            			Set = (IBacked data, string? value) => {(data as RePost)!.Base!.User!.DisplayName = value; }},
            		new FrameString ("Base.User.DisplayHandle") {
            			Get = (IBacked data) => (data as RePost)?.Base?.User?.DisplayHandle ,
            			Set = (IBacked data, string? value) => {(data as RePost)!.Base!.User!.DisplayHandle = value; }},
            		new FrameDateTime ("Base.Created") {
            			Get = (IBacked data) => (data as RePost)?.Base?.Created ,
            			Set = (IBacked data, System.DateTime? value) => {(data as RePost)!.Base!.Created = value; }}
					]
				},
			new FrameSection ("OriginalBody") {
				Fields = [
            		new FrameText ("Base.Text") {
            			Get = (IBacked data) => (data as RePost)?.Base?.Text ,
            			Set = (IBacked data, string? value) => {(data as RePost)!.Base!.Text = value; }}
					]
				}
			]
		};


	}
/// <summary>
/// Backing class for ProfileData
/// </summary>
public partial class ProfileData : FrameClass {

	/// <summary>
	/// Constructor, returns a new instance
	/// </summary>
	public ProfileData (string id="ProfileData") : base ("ProfileData") {
		}


    public override List<FrameField> Fields { get; set; } = _Fields;



	// ref class User, User
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

	static List<FrameField> _Fields = [
		new FrameRefClass<User> ("User","User"){
			Get = (IBacked data) => (data as ProfileData)?.User ,
			Set = (IBacked data, IBacked? value) => {(data as ProfileData)!.User = value as User; }},
		new FrameImage ("Avatar") {
			Get = (IBacked data) => (data as ProfileData)?.Avatar ,
			Set = (IBacked data, string? value) => {(data as ProfileData)!.Avatar = value; }},
		new FrameImage ("Banner") {
			Get = (IBacked data) => (data as ProfileData)?.Banner ,
			Set = (IBacked data, string? value) => {(data as ProfileData)!.Banner = value; }},
		new FrameText ("Description") {
			Get = (IBacked data) => (data as ProfileData)?.Description ,
			Set = (IBacked data, string? value) => {(data as ProfileData)!.Description = value; }},
		new FrameInteger ("Followers") {
			Get = (IBacked data) => (data as ProfileData)?.Followers ,
			Set = (IBacked data, int? value) => {(data as ProfileData)!.Followers = value; }},
		new FrameInteger ("Following") {
			Get = (IBacked data) => (data as ProfileData)?.Following ,
			Set = (IBacked data, int? value) => {(data as ProfileData)!.Following = value; }},
		new FrameInteger ("Posts") {
			Get = (IBacked data) => (data as ProfileData)?.Posts ,
			Set = (IBacked data, int? value) => {(data as ProfileData)!.Posts = value; }}		];



	}



