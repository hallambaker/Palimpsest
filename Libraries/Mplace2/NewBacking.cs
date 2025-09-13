
namespace Frame;

/// <summary>
/// Annotated backing classes for data driven GUI.
/// </summary>
public partial class MyClass : FrameSet{




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

	 ///<summary>Place</summary>
	 public Place Place {get;} = new();

	 ///<summary>Entry</summary>
	 public Entry Entry {get;} = new();

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

	/// <summary>
	/// Constructor, return a new instance.
	/// </summary>
	public MyClass () {

		Pages = [ 
			];

		Menus = [ 
			];

		Selectors = [ 
			];

		Classes = [ 
			User,
			Group,
			Rights,
			Access,
			Privileges,
			Place,
			Entry,
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
			Media
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

// Menus 

// Classes 



// Classes 
/// <summary>
/// Backing class for User
/// </summary>
public partial class User (string Tag="User") : FrameClass (Tag) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Uid</summary>
	public string? Uid {get; set;}

	///<summary>Avatar Avatar</summary>
	public string? Avatar => GetAvatar;

    /// <summary>Field DisplayName</summary>
	public string? DisplayName {get; set;}

    /// <summary>Field DisplayHandle</summary>
	public string? DisplayHandle {get; set;}

    /// <summary>Field Banned</summary>
	public bool? Banned {get; set;}

    /// <summary>Field Suspended</summary>
	public System.DateTime? Suspended {get; set;}

	///<summary>List Groups</summary>
	public List<Group>? Groups {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as User)!.Uid = value; },
			(IBinding data) => (data as User)?.Uid),
		new FrameAvatar ("Avatar"){
			Get = (IBinding data) => (data as User)?.Avatar },
		new FrameString ("DisplayName",
			(IBinding data, string? value) => {(data as User)!.DisplayName = value; },
			(IBinding data) => (data as User)?.DisplayName),
		new FrameString ("DisplayHandle",
			(IBinding data, string? value) => {(data as User)!.DisplayHandle = value; },
			(IBinding data) => (data as User)?.DisplayHandle),
		new FrameBoolean ("Banned",
			(IBinding data, bool? value) => {(data as User)!.Banned = value; },
			(IBinding data) => (data as User)?.Banned),
		new FrameDateTime ("Suspended",
			(IBinding data, System.DateTime? value) => {(data as User)!.Suspended = value; },
			(IBinding data) => (data as User)?.Suspended),
		new FrameRefList<Group> ("Groups","Group"){
			Get = (IBacked data) => (data as User)?.Groups ,
			Set = (IBacked data, Object? value) => {(data as User)!.Groups = value as List<Group>; }}
		];

	}
/// <summary>
/// Backing class for Group
/// </summary>
public partial class Group (string Tag="Group") : FrameClass (Tag) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Uid</summary>
	public string? Uid {get; set;}

    /// <summary>Field Name</summary>
	public string? Name {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as Group)!.Uid = value; },
			(IBinding data) => (data as Group)?.Uid),
		new FrameString ("Name",
			(IBinding data, string? value) => {(data as Group)!.Name = value; },
			(IBinding data) => (data as Group)?.Name),
		new FrameIcon ("Icon")
		];

	}
/// <summary>
/// Backing class for Rights
/// </summary>
public partial class Rights (string Tag="Rights") : FrameClass (Tag) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field GroupUid</summary>
	public string? GroupUid {get; set;}

	///<summary>class Privileges, Grant</summary>
	public Privileges? Grant {get; set;}

	///<summary>class Privileges, Deny</summary>
	public Privileges? Deny {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("GroupUid",
			(IBinding data, string? value) => {(data as Rights)!.GroupUid = value; },
			(IBinding data) => (data as Rights)?.GroupUid),
		new FrameRefClass<Privileges> ("Grant","Privileges"){
			Get = (IBacked data) => (data as Rights)?.Grant ,
			Set = (IBacked data, IBacked? value) => {(data as Rights)!.Grant = value as Privileges; }},
		new FrameRefClass<Privileges> ("Deny","Privileges"){
			Get = (IBacked data) => (data as Rights)?.Deny ,
			Set = (IBacked data, IBacked? value) => {(data as Rights)!.Deny = value as Privileges; }}
		];

	}
/// <summary>
/// Backing class for Access
/// </summary>
public partial class Access (string Tag="Access") : FrameClass (Tag) {

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
			(IBinding data) => (data as Access)?.Create),
		new FrameBoolean ("Read",
			(IBinding data, bool? value) => {(data as Access)!.Read = value; },
			(IBinding data) => (data as Access)?.Read),
		new FrameBoolean ("Edit",
			(IBinding data, bool? value) => {(data as Access)!.Edit = value; },
			(IBinding data) => (data as Access)?.Edit),
		new FrameBoolean ("Delete",
			(IBinding data, bool? value) => {(data as Access)!.Delete = value; },
			(IBinding data) => (data as Access)?.Delete),
		new FrameBoolean ("Owner",
			(IBinding data, bool? value) => {(data as Access)!.Owner = value; },
			(IBinding data) => (data as Access)?.Owner)
		];

	}
/// <summary>
/// Backing class for Privileges
/// </summary>
public partial class Privileges (string Tag="Privileges") : FrameClass (Tag) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



	///<summary>class Access, Places</summary>
	public Access? Places {get; set;}

	///<summary>class Access, Topics</summary>
	public Access? Topics {get; set;}

	///<summary>class Access, Threads</summary>
	public Access? Threads {get; set;}

	///<summary>class Access, Others</summary>
	public Access? Others {get; set;}

	///<summary>class Access, Self</summary>
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

	}
/// <summary>
/// Backing class for Place
/// </summary>
public partial class Place (string Tag="Place") : FrameClass (Tag) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field DNS</summary>
	public string? DNS {get; set;}

    /// <summary>Field Title</summary>
	public string? Title {get; set;}

    /// <summary>Field Text</summary>
	public string? Text {get; set;}

	///<summary>Avatar Avatar</summary>
	public string? Avatar => GetAvatar;

    /// <summary>Field Banner</summary>
	public string? Banner {get; set;}

	///<summary>List RightsPlace</summary>
	public List<Rights>? RightsPlace {get; set;}

	///<summary>List RightsTopics</summary>
	public List<Rights>? RightsTopics {get; set;}

	///<summary>List RightsThreads</summary>
	public List<Rights>? RightsThreads {get; set;}

	///<summary>List RightsComments</summary>
	public List<Rights>? RightsComments {get; set;}

	///<summary>List Topics</summary>
	public List<Topic>? Topics {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("DNS",
			(IBinding data, string? value) => {(data as Place)!.DNS = value; },
			(IBinding data) => (data as Place)?.DNS),
		new FrameString ("Title",
			(IBinding data, string? value) => {(data as Place)!.Title = value; },
			(IBinding data) => (data as Place)?.Title),
		new FrameString ("Text",
			(IBinding data, string? value) => {(data as Place)!.Text = value; },
			(IBinding data) => (data as Place)?.Text),
		new FrameAvatar ("Avatar"){
			Get = (IBinding data) => (data as Place)?.Avatar },
		new FrameImage ("Banner",
			(IBinding data, string? value) => {(data as Place)!.Banner = value; },
			(IBinding data) => (data as Place)?.Banner),
		new FrameRefList<Rights> ("RightsPlace","Rights"){
			Get = (IBacked data) => (data as Place)?.RightsPlace ,
			Set = (IBacked data, Object? value) => {(data as Place)!.RightsPlace = value as List<Rights>; }},
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
			Set = (IBacked data, Object? value) => {(data as Place)!.Topics = value as List<Topic>; }}
		];

	}
/// <summary>
/// Backing class for Entry
/// </summary>
public partial class Entry (string Tag="Entry") : FrameClass (Tag) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Uid</summary>
	public string? Uid {get; set;}

	///<summary>class User, Owner</summary>
	public User? Owner {get; set;}

    /// <summary>Field Semantic</summary>
	public string? Semantic {get; set;}

	///<summary>List Rights</summary>
	public List<Rights>? Rights {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as Entry)!.Uid = value; },
			(IBinding data) => (data as Entry)?.Uid),
		new FrameRefClass<User> ("Owner","User"){
			Get = (IBacked data) => (data as Entry)?.Owner ,
			Set = (IBacked data, IBacked? value) => {(data as Entry)!.Owner = value as User; }},
		new FrameString ("Semantic",
			(IBinding data, string? value) => {(data as Entry)!.Semantic = value; },
			(IBinding data) => (data as Entry)?.Semantic),
		new FrameRefList<Rights> ("Rights","Rights"){
			Get = (IBacked data) => (data as Entry)?.Rights ,
			Set = (IBacked data, Object? value) => {(data as Entry)!.Rights = value as List<Rights>; }}
		];

	}
/// <summary>
/// Backing class for Topic
/// </summary>
public partial class Topic (string Tag="Topic") : Entry (Tag) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Title</summary>
	public string? Title {get; set;}

	///<summary>List Posts</summary>
	public List<Post>? Posts {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as Entry)!.Uid = value; },
			(IBinding data) => (data as Entry)?.Uid),
		new FrameRefClass<User> ("Owner","User"){
			Get = (IBacked data) => (data as Entry)?.Owner ,
			Set = (IBacked data, IBacked? value) => {(data as Entry)!.Owner = value as User; }},
		new FrameString ("Semantic",
			(IBinding data, string? value) => {(data as Entry)!.Semantic = value; },
			(IBinding data) => (data as Entry)?.Semantic),
		new FrameRefList<Rights> ("Rights","Rights"){
			Get = (IBacked data) => (data as Entry)?.Rights ,
			Set = (IBacked data, Object? value) => {(data as Entry)!.Rights = value as List<Rights>; }},
		new FrameString ("Title",
			(IBinding data, string? value) => {(data as Topic)!.Title = value; },
			(IBinding data) => (data as Topic)?.Title),
		new FrameRefList<Post> ("Posts","Post"){
			Get = (IBacked data) => (data as Topic)?.Posts ,
			Set = (IBacked data, Object? value) => {(data as Topic)!.Posts = value as List<Post>; }}
		];

	}
/// <summary>
/// Backing class for Post
/// </summary>
public partial class Post (string Tag="Post") : Entry (Tag) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Title</summary>
	public string? Title {get; set;}

    /// <summary>Field Text</summary>
	public string? Text {get; set;}

	///<summary>List Resources</summary>
	public List<Resource>? Resources {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as Entry)!.Uid = value; },
			(IBinding data) => (data as Entry)?.Uid),
		new FrameRefClass<User> ("Owner","User"){
			Get = (IBacked data) => (data as Entry)?.Owner ,
			Set = (IBacked data, IBacked? value) => {(data as Entry)!.Owner = value as User; }},
		new FrameString ("Semantic",
			(IBinding data, string? value) => {(data as Entry)!.Semantic = value; },
			(IBinding data) => (data as Entry)?.Semantic),
		new FrameRefList<Rights> ("Rights","Rights"){
			Get = (IBacked data) => (data as Entry)?.Rights ,
			Set = (IBacked data, Object? value) => {(data as Entry)!.Rights = value as List<Rights>; }},
		new FrameString ("Title",
			(IBinding data, string? value) => {(data as Post)!.Title = value; },
			(IBinding data) => (data as Post)?.Title),
		new FrameString ("Text",
			(IBinding data, string? value) => {(data as Post)!.Text = value; },
			(IBinding data) => (data as Post)?.Text),
		new FrameRefList<Resource> ("Resources","Resource"){
			Get = (IBacked data) => (data as Post)?.Resources ,
			Set = (IBacked data, Object? value) => {(data as Post)!.Resources = value as List<Resource>; }}
		];

	}
/// <summary>
/// Backing class for Comment
/// </summary>
public partial class Comment (string Tag="Comment") : Entry (Tag) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Text</summary>
	public string? Text {get; set;}

	///<summary>class Resource, Resources</summary>
	public Resource? Resources {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as Entry)!.Uid = value; },
			(IBinding data) => (data as Entry)?.Uid),
		new FrameRefClass<User> ("Owner","User"){
			Get = (IBacked data) => (data as Entry)?.Owner ,
			Set = (IBacked data, IBacked? value) => {(data as Entry)!.Owner = value as User; }},
		new FrameString ("Semantic",
			(IBinding data, string? value) => {(data as Entry)!.Semantic = value; },
			(IBinding data) => (data as Entry)?.Semantic),
		new FrameRefList<Rights> ("Rights","Rights"){
			Get = (IBacked data) => (data as Entry)?.Rights ,
			Set = (IBacked data, Object? value) => {(data as Entry)!.Rights = value as List<Rights>; }},
		new FrameString ("Text",
			(IBinding data, string? value) => {(data as Comment)!.Text = value; },
			(IBinding data) => (data as Comment)?.Text),
		new FrameRefClass<Resource> ("Resources","Resource"){
			Get = (IBacked data) => (data as Comment)?.Resources ,
			Set = (IBacked data, IBacked? value) => {(data as Comment)!.Resources = value as Resource; }}
		];

	}
/// <summary>
/// Backing class for Resource
/// </summary>
public partial class Resource (string Tag="Resource") : Entry (Tag) {

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
			(IBinding data) => (data as Entry)?.Uid),
		new FrameRefClass<User> ("Owner","User"){
			Get = (IBacked data) => (data as Entry)?.Owner ,
			Set = (IBacked data, IBacked? value) => {(data as Entry)!.Owner = value as User; }},
		new FrameString ("Semantic",
			(IBinding data, string? value) => {(data as Entry)!.Semantic = value; },
			(IBinding data) => (data as Entry)?.Semantic),
		new FrameRefList<Rights> ("Rights","Rights"){
			Get = (IBacked data) => (data as Entry)?.Rights ,
			Set = (IBacked data, Object? value) => {(data as Entry)!.Rights = value as List<Rights>; }},
		new FrameString ("Title",
			(IBinding data, string? value) => {(data as Resource)!.Title = value; },
			(IBinding data) => (data as Resource)?.Title),
		new FrameInteger ("Size",
			(IBinding data, int? value) => {(data as Resource)!.Size = value; },
			(IBinding data) => (data as Resource)?.Size),
		new FrameString ("Type",
			(IBinding data, string? value) => {(data as Resource)!.Type = value; },
			(IBinding data) => (data as Resource)?.Type)
		];

	}
/// <summary>
/// Backing class for Contact
/// </summary>
public partial class Contact (string Tag="Contact") : Entry (Tag) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Updated</summary>
	public System.DateTime? Updated {get; set;}

	///<summary>class User, User</summary>
	public User? User {get; set;}

	///<summary>class Name, Name</summary>
	public Name? Name {get; set;}

	///<summary>List AltNames</summary>
	public List<Name>? AltNames {get; set;}

	///<summary>List NickNames</summary>
	public List<Name>? NickNames {get; set;}

	///<summary>List Organization</summary>
	public List<Organization>? Organization {get; set;}

	///<summary>class Pronouns, Pronouns</summary>
	public Pronouns? Pronouns {get; set;}

	///<summary>class RelatedTo, RelatedTo</summary>
	public RelatedTo? RelatedTo {get; set;}

	///<summary>List Applications</summary>
	public List<Application>? Applications {get; set;}

	///<summary>List Media</summary>
	public List<Media>? Media {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as Entry)!.Uid = value; },
			(IBinding data) => (data as Entry)?.Uid),
		new FrameRefClass<User> ("Owner","User"){
			Get = (IBacked data) => (data as Entry)?.Owner ,
			Set = (IBacked data, IBacked? value) => {(data as Entry)!.Owner = value as User; }},
		new FrameString ("Semantic",
			(IBinding data, string? value) => {(data as Entry)!.Semantic = value; },
			(IBinding data) => (data as Entry)?.Semantic),
		new FrameRefList<Rights> ("Rights","Rights"){
			Get = (IBacked data) => (data as Entry)?.Rights ,
			Set = (IBacked data, Object? value) => {(data as Entry)!.Rights = value as List<Rights>; }},
		new FrameDateTime ("Updated",
			(IBinding data, System.DateTime? value) => {(data as Contact)!.Updated = value; },
			(IBinding data) => (data as Contact)?.Updated),
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

	}
/// <summary>
/// Backing class for Name
/// </summary>
public partial class Name (string Tag="Name") : FrameClass (Tag) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Full</summary>
	public string? Full {get; set;}

	///<summary>List Components</summary>
	public List<TagValue>? Components {get; set;}

    /// <summary>Field PhoneticSystem</summary>
	public string? PhoneticSystem {get; set;}

    /// <summary>Field PhoneticScript</summary>
	public string? PhoneticScript {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Full",
			(IBinding data, string? value) => {(data as Name)!.Full = value; },
			(IBinding data) => (data as Name)?.Full),
		new FrameRefList<TagValue> ("Components","TagValue"){
			Get = (IBacked data) => (data as Name)?.Components ,
			Set = (IBacked data, Object? value) => {(data as Name)!.Components = value as List<TagValue>; }},
		new FrameString ("PhoneticSystem",
			(IBinding data, string? value) => {(data as Name)!.PhoneticSystem = value; },
			(IBinding data) => (data as Name)?.PhoneticSystem),
		new FrameString ("PhoneticScript",
			(IBinding data, string? value) => {(data as Name)!.PhoneticScript = value; },
			(IBinding data) => (data as Name)?.PhoneticScript)
		];

	}
/// <summary>
/// Backing class for TagValue
/// </summary>
public partial class TagValue (string Tag="TagValue") : FrameClass (Tag) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Tag</summary>
	public string? Tag {get; set;}

    /// <summary>Field Value</summary>
	public string? Value {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Tag",
			(IBinding data, string? value) => {(data as TagValue)!.Tag = value; },
			(IBinding data) => (data as TagValue)?.Tag),
		new FrameString ("Value",
			(IBinding data, string? value) => {(data as TagValue)!.Value = value; },
			(IBinding data) => (data as TagValue)?.Value)
		];

	}
/// <summary>
/// Backing class for Organization
/// </summary>
public partial class Organization (string Tag="Organization") : FrameClass (Tag) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Name</summary>
	public string? Name {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Name",
			(IBinding data, string? value) => {(data as Organization)!.Name = value; },
			(IBinding data) => (data as Organization)?.Name)
		];

	}
/// <summary>
/// Backing class for Pronouns
/// </summary>
public partial class Pronouns (string Tag="Pronouns") : FrameClass (Tag) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Subjective</summary>
	public string? Subjective {get; set;}

    /// <summary>Field Objective</summary>
	public string? Objective {get; set;}

    /// <summary>Field Posessive</summary>
	public string? Posessive {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Subjective",
			(IBinding data, string? value) => {(data as Pronouns)!.Subjective = value; },
			(IBinding data) => (data as Pronouns)?.Subjective),
		new FrameString ("Objective",
			(IBinding data, string? value) => {(data as Pronouns)!.Objective = value; },
			(IBinding data) => (data as Pronouns)?.Objective),
		new FrameString ("Posessive",
			(IBinding data, string? value) => {(data as Pronouns)!.Posessive = value; },
			(IBinding data) => (data as Pronouns)?.Posessive)
		];

	}
/// <summary>
/// Backing class for Title
/// </summary>
public partial class Title (string Tag="Title") : FrameClass (Tag) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Name</summary>
	public string? Name {get; set;}

	///<summary>class Organization, Organization</summary>
	public Organization? Organization {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Name",
			(IBinding data, string? value) => {(data as Title)!.Name = value; },
			(IBinding data) => (data as Title)?.Name),
		new FrameRefClass<Organization> ("Organization","Organization"){
			Get = (IBacked data) => (data as Title)?.Organization ,
			Set = (IBacked data, IBacked? value) => {(data as Title)!.Organization = value as Organization; }}
		];

	}
/// <summary>
/// Backing class for RelatedTo
/// </summary>
public partial class RelatedTo (string Tag="RelatedTo") : FrameClass (Tag) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Uid</summary>
	public string? Uid {get; set;}

    /// <summary>Field Other</summary>
	public string? Other {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("Uid",
			(IBinding data, string? value) => {(data as RelatedTo)!.Uid = value; },
			(IBinding data) => (data as RelatedTo)?.Uid),
		new FrameString ("Other",
			(IBinding data, string? value) => {(data as RelatedTo)!.Other = value; },
			(IBinding data) => (data as RelatedTo)?.Other)
		];

	}
/// <summary>
/// Backing class for Application
/// </summary>
public partial class Application (string Tag="Application") : FrameClass (Tag) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field ApplicationName</summary>
	public string? ApplicationName {get; set;}

    /// <summary>Field Address</summary>
	public string? Address {get; set;}

	///<summary>List Keys</summary>
	public List<Key>? Keys {get; set;}

    /// <summary>Field Preference</summary>
	public int? Preference {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("ApplicationName",
			(IBinding data, string? value) => {(data as Application)!.ApplicationName = value; },
			(IBinding data) => (data as Application)?.ApplicationName),
		new FrameString ("Address",
			(IBinding data, string? value) => {(data as Application)!.Address = value; },
			(IBinding data) => (data as Application)?.Address),
		new FrameRefList<Key> ("Keys","Key"){
			Get = (IBacked data) => (data as Application)?.Keys ,
			Set = (IBacked data, Object? value) => {(data as Application)!.Keys = value as List<Key>; }},
		new FrameInteger ("Preference",
			(IBinding data, int? value) => {(data as Application)!.Preference = value; },
			(IBinding data) => (data as Application)?.Preference)
		];

	}
/// <summary>
/// Backing class for Email
/// </summary>
public partial class Email (string Tag="Email") : Application (Tag) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;




	static readonly List<IFrameField> _Fields = [
		new FrameString ("ApplicationName",
			(IBinding data, string? value) => {(data as Application)!.ApplicationName = value; },
			(IBinding data) => (data as Application)?.ApplicationName),
		new FrameString ("Address",
			(IBinding data, string? value) => {(data as Application)!.Address = value; },
			(IBinding data) => (data as Application)?.Address),
		new FrameRefList<Key> ("Keys","Key"){
			Get = (IBacked data) => (data as Application)?.Keys ,
			Set = (IBacked data, Object? value) => {(data as Application)!.Keys = value as List<Key>; }},
		new FrameInteger ("Preference",
			(IBinding data, int? value) => {(data as Application)!.Preference = value; },
			(IBinding data) => (data as Application)?.Preference)
		];

	}
/// <summary>
/// Backing class for Messaging
/// </summary>
public partial class Messaging (string Tag="Messaging") : Application (Tag) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field Other</summary>
	public string? Other {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("ApplicationName",
			(IBinding data, string? value) => {(data as Application)!.ApplicationName = value; },
			(IBinding data) => (data as Application)?.ApplicationName),
		new FrameString ("Address",
			(IBinding data, string? value) => {(data as Application)!.Address = value; },
			(IBinding data) => (data as Application)?.Address),
		new FrameRefList<Key> ("Keys","Key"){
			Get = (IBacked data) => (data as Application)?.Keys ,
			Set = (IBacked data, Object? value) => {(data as Application)!.Keys = value as List<Key>; }},
		new FrameInteger ("Preference",
			(IBinding data, int? value) => {(data as Application)!.Preference = value; },
			(IBinding data) => (data as Application)?.Preference),
		new FrameString ("Other",
			(IBinding data, string? value) => {(data as Messaging)!.Other = value; },
			(IBinding data) => (data as Messaging)?.Other)
		];

	}
/// <summary>
/// Backing class for Phone
/// </summary>
public partial class Phone (string Tag="Phone") : Application (Tag) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;




	static readonly List<IFrameField> _Fields = [
		new FrameString ("ApplicationName",
			(IBinding data, string? value) => {(data as Application)!.ApplicationName = value; },
			(IBinding data) => (data as Application)?.ApplicationName),
		new FrameString ("Address",
			(IBinding data, string? value) => {(data as Application)!.Address = value; },
			(IBinding data) => (data as Application)?.Address),
		new FrameRefList<Key> ("Keys","Key"){
			Get = (IBacked data) => (data as Application)?.Keys ,
			Set = (IBacked data, Object? value) => {(data as Application)!.Keys = value as List<Key>; }},
		new FrameInteger ("Preference",
			(IBinding data, int? value) => {(data as Application)!.Preference = value; },
			(IBinding data) => (data as Application)?.Preference)
		];

	}
/// <summary>
/// Backing class for Service
/// </summary>
public partial class Service (string Tag="Service") : Application (Tag) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



    /// <summary>Field ServiceName</summary>
	public string? ServiceName {get; set;}

    /// <summary>Field Protocol</summary>
	public string? Protocol {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameString ("ApplicationName",
			(IBinding data, string? value) => {(data as Application)!.ApplicationName = value; },
			(IBinding data) => (data as Application)?.ApplicationName),
		new FrameString ("Address",
			(IBinding data, string? value) => {(data as Application)!.Address = value; },
			(IBinding data) => (data as Application)?.Address),
		new FrameRefList<Key> ("Keys","Key"){
			Get = (IBacked data) => (data as Application)?.Keys ,
			Set = (IBacked data, Object? value) => {(data as Application)!.Keys = value as List<Key>; }},
		new FrameInteger ("Preference",
			(IBinding data, int? value) => {(data as Application)!.Preference = value; },
			(IBinding data) => (data as Application)?.Preference),
		new FrameString ("ServiceName",
			(IBinding data, string? value) => {(data as Service)!.ServiceName = value; },
			(IBinding data) => (data as Service)?.ServiceName),
		new FrameString ("Protocol",
			(IBinding data, string? value) => {(data as Service)!.Protocol = value; },
			(IBinding data) => (data as Service)?.Protocol)
		];

	}
/// <summary>
/// Backing class for Key
/// </summary>
public partial class Key (string Tag="Key") : FrameClass (Tag) {

    /// <inheritdoc/>
    public override List<IFrameField> Fields { get; set; } = _Fields;



	///<summary>class KeyData, KeyData</summary>
	public KeyData? KeyData {get; set;}


	static readonly List<IFrameField> _Fields = [
		new FrameRefClass<KeyData> ("KeyData","KeyData"){
			Get = (IBacked data) => (data as Key)?.KeyData ,
			Set = (IBacked data, IBacked? value) => {(data as Key)!.KeyData = value as KeyData; }}
		];

	}
/// <summary>
/// Backing class for KeyData
/// </summary>
public partial class KeyData (string Tag="KeyData") : FrameClass (Tag) {

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
			(IBinding data) => (data as KeyData)?.UID),
		new FrameBoolean ("Encryption",
			(IBinding data, bool? value) => {(data as KeyData)!.Encryption = value; },
			(IBinding data) => (data as KeyData)?.Encryption),
		new FrameBoolean ("Signature",
			(IBinding data, bool? value) => {(data as KeyData)!.Signature = value; },
			(IBinding data) => (data as KeyData)?.Signature),
		new FrameString ("Value",
			(IBinding data, string? value) => {(data as KeyData)!.Value = value; },
			(IBinding data) => (data as KeyData)?.Value)
		];

	}
/// <summary>
/// Backing class for Media
/// </summary>
public partial class Media (string Tag="Media") : FrameClass (Tag) {

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
			(IBinding data) => (data as Media)?.MediaType),
		new FrameInteger ("Width",
			(IBinding data, int? value) => {(data as Media)!.Width = value; },
			(IBinding data) => (data as Media)?.Width),
		new FrameInteger ("Height",
			(IBinding data, int? value) => {(data as Media)!.Height = value; },
			(IBinding data) => (data as Media)?.Height),
		new FrameInteger ("Length",
			(IBinding data, int? value) => {(data as Media)!.Length = value; },
			(IBinding data) => (data as Media)?.Length),
		new FrameInteger ("Bytes",
			(IBinding data, int? value) => {(data as Media)!.Bytes = value; },
			(IBinding data) => (data as Media)?.Bytes)
		];

	}



