
//  Copyright (c) 2016 by .
//  
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//  
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//  
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
//  
//  
//  This file was automatically generated at 3/18/2026 4:00:12 PM
//   
//  Changes to this file may be overwritten without warning
//  
//  Generator:  protogen version 3.0.0.1141
//      Goedel Script Version : 0.1   Generated 
//      Goedel Schema Version : 0.1   Generated
//  
//      Copyright : © 2015-2021
//  
//  Build Platform: Win32NT 10.0.26200.0
//  
//  
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Goedel.Protocol;
using Goedel.Utilities;

#pragma warning disable IDE0079 // Don't warn about unnecessary suppressions
#pragma warning disable IDE0028 // Don't warn collection initialization can be simplified.
#pragma warning disable IDE1006 // Ignore naming rule violations
#pragma warning disable CA2255 // The 'ModuleInitializer' attribute should not be used in libraries



namespace Goedel.Places;


	/// <summary>
	///
	/// A Palimpsest forum
	/// </summary>
public abstract partial class ForumItem : global::Goedel.Protocol.JsonObject {

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag =>__Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "ForumItem";

	/// <summary>
    /// Dictionary mapping types to bindings
    /// </summary>
	public static Dictionary<System.Type, Binding> _BindingDictionary=> _bindingDictionary;
	static Dictionary<System.Type, Binding> _bindingDictionary = 
			new () {

	    {typeof(PlaceConfiguration), PlaceConfiguration._binding},
	    {typeof(CatalogedForumEntry), CatalogedForumEntry._binding},
	    {typeof(CatalogedForumOwned), CatalogedForumOwned._binding},
	    {typeof(CatalogedSite), CatalogedSite._binding},
	    {typeof(CatalogedPlace), CatalogedPlace._binding},
	    {typeof(CatalogedMember), CatalogedMember._binding},
	    {typeof(CatalogedFeed), CatalogedFeed._binding},
	    {typeof(CatalogedPost), CatalogedPost._binding},
	    {typeof(CatalogedComment), CatalogedComment._binding},
	    {typeof(CatalogedResource), CatalogedResource._binding},
	    {typeof(AccessControl), AccessControl._binding}
		};

	///<summary>Variable used to force static initialization</summary> 
	public static bool _Initialized => true;

	static ForumItem() {
		_Initialize();
		}

    internal static void _Initialize() {
		AddDictionary(ref _bindingDictionary);
		}

	}



// Service Dispatch Classes



	// Transaction Classes

	/// <summary>
	///
	/// Service configuration file
	/// </summary>
public partial class PlaceConfiguration : ForumItem {
    /// <summary>
    ///Canonical DNS name of the default site.
    /// </summary>

	[JsonPropertyName("DefaultSite")]
	public virtual string?					DefaultSite  {get; set;} //

    /// <summary>
    ///DNS handle of site administrators
    /// </summary>

	[JsonPropertyName("Administrators")]
	public virtual List<string>?					Administrators  {get; set;}
    /// <summary>
    ///Specify default limits on resource use
    /// </summary>

	[JsonPropertyName("Limits")]
	public virtual Dictionary<string,int>?					Limits  {get; set;} //

    /// <summary>
    ///Directory in which the site  catalogs are kept.
    /// </summary>

	[JsonPropertyName("Site")]
	public virtual string?					Site  {get; set;} //

    /// <summary>
    ///Directory in which the per member catalogs are kept.
    /// </summary>

	[JsonPropertyName("Members")]
	public virtual string?					Members  {get; set;} //

    /// <summary>
    ///Directory to write logs to
    /// </summary>

	[JsonPropertyName("Logs")]
	public virtual string?					Logs  {get; set;} //

    /// <summary>
    ///Directory to write created content to
    /// </summary>

	[JsonPropertyName("Repository")]
	public virtual string?					Repository  {get; set;} //

    /// <summary>
    ///Directory to fetch resources (style sheets, icons) from
    /// </summary>

	[JsonPropertyName("Resources")]
	public virtual string?					Resources  {get; set;} //

    /// <summary>
    ///Seed used for cookie validation TEST USE ONLY
    /// </summary>

	[JsonPropertyName("TestSeed")]
	public virtual string?					TestSeed  {get; set;} //


    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyString ("DefaultSite", 
					(data, value) => {(data as PlaceConfiguration).DefaultSite = value;}, 
					data => (data as PlaceConfiguration).DefaultSite ),
		new PropertyListString ("Administrators", 
					(data, value) => {(data as PlaceConfiguration).Administrators = value;}, 
					data => (data as PlaceConfiguration).Administrators ),
		new PropertyDictionaryInteger32 ("Limits", 
					(data, value) => {(data as PlaceConfiguration).Limits = value;}, 
					data => (data as PlaceConfiguration).Limits ),
		new PropertyString ("Site", 
					(data, value) => {(data as PlaceConfiguration).Site = value;}, 
					data => (data as PlaceConfiguration).Site ),
		new PropertyString ("Members", 
					(data, value) => {(data as PlaceConfiguration).Members = value;}, 
					data => (data as PlaceConfiguration).Members ),
		new PropertyString ("Logs", 
					(data, value) => {(data as PlaceConfiguration).Logs = value;}, 
					data => (data as PlaceConfiguration).Logs ),
		new PropertyString ("Repository", 
					(data, value) => {(data as PlaceConfiguration).Repository = value;}, 
					data => (data as PlaceConfiguration).Repository ),
		new PropertyString ("Resources", 
					(data, value) => {(data as PlaceConfiguration).Resources = value;}, 
					data => (data as PlaceConfiguration).Resources ),
		new PropertyString ("TestSeed", 
					(data, value) => {(data as PlaceConfiguration).TestSeed = value;}, 
					data => (data as PlaceConfiguration).TestSeed )
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<PlaceConfiguration> _binding = new (
			new() {
			{ "DefaultSite", _properties [0]},
			{ "Administrators", _properties [1]},
			{ "Limits", _properties [2]},
			{ "Site", _properties [3]},
			{ "Members", _properties [4]},
			{ "Logs", _properties [5]},
			{ "Repository", _properties [6]},
			{ "Resources", _properties [7]},
			{ "TestSeed", _properties [8]}}, __Tag,
		() => new PlaceConfiguration(), () => [], () => [], null, Generic: false);


	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag => __Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "PlaceConfiguration";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new PlaceConfiguration();

	}


	/// <summary>
	///
	/// 
	/// </summary>
public partial class CatalogedForumEntry : CatalogedEntry {
    /// <summary>
    ///Time the entry was added
    /// </summary>

	[JsonPropertyName("Added")]
	public virtual DateTime?					Added  {get; set;} //


    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyDateTime ("Added", 
					(data, value) => {(data as CatalogedForumEntry).Added = value;}, 
					data => (data as CatalogedForumEntry).Added )
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedForumEntry> _binding = new (
			new() {
			{ "Added", _properties [0]}}, __Tag,
		() => new CatalogedForumEntry(), () => [], () => [], CatalogedEntry._binding, Generic: false);


	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag => __Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "CatalogedForumEntry";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new CatalogedForumEntry();

	}


	/// <summary>
	/// </summary>
public partial class CatalogedForumOwned : CatalogedForumEntry {
    /// <summary>
    ///The title of the place
    /// </summary>

	[JsonPropertyName("Title")]
	public virtual string?					Title  {get; set;} //

    /// <summary>
    ///Designated owner(s) DIDs
    /// </summary>

	[JsonPropertyName("Owners")]
	public virtual List<string>?					Owners  {get; set;}

    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyString ("Title", 
					(data, value) => {(data as CatalogedForumOwned).Title = value;}, 
					data => (data as CatalogedForumOwned).Title ),
		new PropertyListString ("Owners", 
					(data, value) => {(data as CatalogedForumOwned).Owners = value;}, 
					data => (data as CatalogedForumOwned).Owners )
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedForumOwned> _binding = new (
			new() {
			{ "Title", _properties [0]},
			{ "Owners", _properties [1]}}, __Tag,
		() => new CatalogedForumOwned(), () => [], () => [], CatalogedForumEntry._binding, Generic: false);


	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag => __Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "CatalogedForumOwned";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new CatalogedForumOwned();

	}


	/// <summary>
	/// </summary>
public partial class CatalogedSite : ForumItem {
    /// <summary>
    /// </summary>

	[JsonPropertyName("AccessControl")]
	public virtual AccessControl?					AccessControl  {get; set;} //

    /// <summary>
    /// </summary>

	[JsonPropertyName("DefaultPlace")]
	public virtual string?					DefaultPlace  {get; set;} //


    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyStruct ("AccessControl", typeof (AccessControl),
					(data, value) => {(data as CatalogedSite).AccessControl = value as AccessControl;}, 
					data => (data as CatalogedSite).AccessControl,
					false, ()=>new  AccessControl(), ()=>new AccessControl()),
		new PropertyString ("DefaultPlace", 
					(data, value) => {(data as CatalogedSite).DefaultPlace = value;}, 
					data => (data as CatalogedSite).DefaultPlace )
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedSite> _binding = new (
			new() {
			{ "AccessControl", _properties [0]},
			{ "DefaultPlace", _properties [1]}}, __Tag,
		() => new CatalogedSite(), () => [], () => [], null, Generic: false);


	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag => __Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "CatalogedSite";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new CatalogedSite();

	}


	/// <summary>
	///
	/// A cataloged project.
	/// </summary>
public partial class CatalogedPlace : CatalogedForumOwned {
    /// <summary>
    ///If true, this overrides the previous default place definition in the feed.
    /// </summary>

	[JsonPropertyName("Default")]
	public virtual bool?					Default  {get; set;} //

    /// <summary>
    ///Alternative DNS names
    /// </summary>

	[JsonPropertyName("Aliases")]
	public virtual List<string>?					Aliases  {get; set;}
    /// <summary>
    ///Avatar representing the entry
    /// </summary>

	[JsonPropertyName("Avatar")]
	public virtual string?					Avatar  {get; set;} //

    /// <summary>
    ///Splash screen for the place
    /// </summary>

	[JsonPropertyName("Banner")]
	public virtual string?					Banner  {get; set;} //

    /// <summary>
    ///The default feed id.
    /// </summary>

	[JsonPropertyName("DefaultFeed")]
	public virtual string?					DefaultFeed  {get; set;} //

    /// <summary>
    /// </summary>

	[JsonPropertyName("AccessControl")]
	public virtual AccessControl?					AccessControl  {get; set;} //


    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyBoolean ("Default", 
					(data, value) => {(data as CatalogedPlace).Default = value;}, 
					data => (data as CatalogedPlace).Default ),
		new PropertyListString ("Aliases", 
					(data, value) => {(data as CatalogedPlace).Aliases = value;}, 
					data => (data as CatalogedPlace).Aliases ),
		new PropertyString ("Avatar", 
					(data, value) => {(data as CatalogedPlace).Avatar = value;}, 
					data => (data as CatalogedPlace).Avatar ),
		new PropertyString ("Banner", 
					(data, value) => {(data as CatalogedPlace).Banner = value;}, 
					data => (data as CatalogedPlace).Banner ),
		new PropertyString ("DefaultFeed", 
					(data, value) => {(data as CatalogedPlace).DefaultFeed = value;}, 
					data => (data as CatalogedPlace).DefaultFeed ),
		new PropertyStruct ("AccessControl", typeof (AccessControl),
					(data, value) => {(data as CatalogedPlace).AccessControl = value as AccessControl;}, 
					data => (data as CatalogedPlace).AccessControl,
					false, ()=>new  AccessControl(), ()=>new AccessControl())
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedPlace> _binding = new (
			new() {
			{ "Default", _properties [0]},
			{ "Aliases", _properties [1]},
			{ "Avatar", _properties [2]},
			{ "Banner", _properties [3]},
			{ "DefaultFeed", _properties [4]},
			{ "AccessControl", _properties [5]}}, __Tag,
		() => new CatalogedPlace(), () => [], () => [], CatalogedForumOwned._binding, Generic: false);


	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag => __Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "CatalogedPlace";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new CatalogedPlace();

	}


	/// <summary>
	///
	/// 
	/// </summary>
public partial class CatalogedMember : CatalogedForumEntry {
    /// <summary>
    ///The user's Did (if used).
    /// </summary>

	[JsonPropertyName("Did")]
	public virtual string?					Did  {get; set;} //

    /// <summary>
    ///The user's DNS handle.
    /// </summary>

	[JsonPropertyName("Handle")]
	public virtual string?					Handle  {get; set;} //

    /// <summary>
    ///The user's display name
    /// </summary>

	[JsonPropertyName("DisplayName")]
	public virtual string?					DisplayName  {get; set;} //

    /// <summary>
    ///Resource link to the user's avatar image
    /// </summary>

	[JsonPropertyName("Avatar")]
	public virtual string?					Avatar  {get; set;} //

    /// <summary>
    ///Resource link to the user's banner image
    /// </summary>

	[JsonPropertyName("Banner")]
	public virtual string?					Banner  {get; set;} //

    /// <summary>
    ///The member's status: Active / Inactive / Blocked
    /// </summary>

	[JsonPropertyName("Status")]
	public virtual string?					Status  {get; set;} //

    /// <summary>
    ///Places the visitor has created on this site
    /// </summary>

	[JsonPropertyName("Places")]
	public virtual List<string>?					Places  {get; set;}

    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyString ("Did", 
					(data, value) => {(data as CatalogedMember).Did = value;}, 
					data => (data as CatalogedMember).Did ),
		new PropertyString ("Handle", 
					(data, value) => {(data as CatalogedMember).Handle = value;}, 
					data => (data as CatalogedMember).Handle ),
		new PropertyString ("DisplayName", 
					(data, value) => {(data as CatalogedMember).DisplayName = value;}, 
					data => (data as CatalogedMember).DisplayName ),
		new PropertyString ("Avatar", 
					(data, value) => {(data as CatalogedMember).Avatar = value;}, 
					data => (data as CatalogedMember).Avatar ),
		new PropertyString ("Banner", 
					(data, value) => {(data as CatalogedMember).Banner = value;}, 
					data => (data as CatalogedMember).Banner ),
		new PropertyString ("Status", 
					(data, value) => {(data as CatalogedMember).Status = value;}, 
					data => (data as CatalogedMember).Status ),
		new PropertyListString ("Places", 
					(data, value) => {(data as CatalogedMember).Places = value;}, 
					data => (data as CatalogedMember).Places )
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedMember> _binding = new (
			new() {
			{ "Did", _properties [0]},
			{ "Handle", _properties [1]},
			{ "DisplayName", _properties [2]},
			{ "Avatar", _properties [3]},
			{ "Banner", _properties [4]},
			{ "Status", _properties [5]},
			{ "Places", _properties [6]}}, __Tag,
		() => new CatalogedMember(), () => [], () => [], CatalogedForumEntry._binding, Generic: false);


	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag => __Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "CatalogedMember";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new CatalogedMember();

	}


	/// <summary>
	///
	/// 
	/// </summary>
public partial class CatalogedFeed : CatalogedForumOwned {
    /// <summary>
    ///Avatar representing the entry
    /// </summary>

	[JsonPropertyName("Avatar")]
	public virtual string?					Avatar  {get; set;} //

    /// <summary>
    ///Posts to the stream
    /// </summary>

	[JsonPropertyName("Posts")]
	public virtual List<CatalogedPost>?					Posts  {get; set;}
    /// <summary>
    /// </summary>

	[JsonPropertyName("AccessControl")]
	public virtual AccessControl?					AccessControl  {get; set;} //


    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyString ("Avatar", 
					(data, value) => {(data as CatalogedFeed).Avatar = value;}, 
					data => (data as CatalogedFeed).Avatar ),
		new PropertyListStruct ("Posts", typeof (CatalogedPost),
					(data, value) => {(data as CatalogedFeed).Posts = value as List<CatalogedPost>;}, 
					data => (data as CatalogedFeed).Posts,
					false, ()=>new  List<CatalogedPost>(), ()=>new CatalogedPost()),
		new PropertyStruct ("AccessControl", typeof (AccessControl),
					(data, value) => {(data as CatalogedFeed).AccessControl = value as AccessControl;}, 
					data => (data as CatalogedFeed).AccessControl,
					false, ()=>new  AccessControl(), ()=>new AccessControl())
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedFeed> _binding = new (
			new() {
			{ "Avatar", _properties [0]},
			{ "Posts", _properties [1]},
			{ "AccessControl", _properties [2]}}, __Tag,
		() => new CatalogedFeed(), () => [], () => [], CatalogedForumOwned._binding, Generic: false);


	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag => __Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "CatalogedFeed";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new CatalogedFeed();

	}


	/// <summary>
	///
	/// 
	/// </summary>
public partial class CatalogedPost : CatalogedForumOwned {
    /// <summary>
    ///
    /// </summary>

	[JsonPropertyName("Author")]
	public virtual string?					Author  {get; set;} //

    /// <summary>
    ///The post summary in UTF8 format.
    /// </summary>

	[JsonPropertyName("Summary")]
	public virtual string?					Summary  {get; set;} //

    /// <summary>
    ///The post body in XML format.
    /// </summary>

	[JsonPropertyName("Body")]
	public virtual string?					Body  {get; set;} //

    /// <summary>
    ///The associated resources
    /// </summary>

	[JsonPropertyName("Resources")]
	public virtual List<CatalogedResource>?					Resources  {get; set;}

    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyString ("Author", 
					(data, value) => {(data as CatalogedPost).Author = value;}, 
					data => (data as CatalogedPost).Author ),
		new PropertyString ("Summary", 
					(data, value) => {(data as CatalogedPost).Summary = value;}, 
					data => (data as CatalogedPost).Summary ),
		new PropertyString ("Body", 
					(data, value) => {(data as CatalogedPost).Body = value;}, 
					data => (data as CatalogedPost).Body ),
		new PropertyListStruct ("Resources", typeof (CatalogedResource),
					(data, value) => {(data as CatalogedPost).Resources = value as List<CatalogedResource>;}, 
					data => (data as CatalogedPost).Resources,
					false, ()=>new  List<CatalogedResource>(), ()=>new CatalogedResource())
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedPost> _binding = new (
			new() {
			{ "Author", _properties [0]},
			{ "Summary", _properties [1]},
			{ "Body", _properties [2]},
			{ "Resources", _properties [3]}}, __Tag,
		() => new CatalogedPost(), () => [], () => [], CatalogedForumOwned._binding, Generic: false);


	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag => __Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "CatalogedPost";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new CatalogedPost();

	}


	/// <summary>
	///
	/// 
	/// </summary>
public partial class CatalogedComment : CatalogedForumEntry {
    /// <summary>
    ///
    /// </summary>

	[JsonPropertyName("Author")]
	public virtual string?					Author  {get; set;} //

    /// <summary>
    ///The comment text in UTF8 format.
    /// </summary>

	[JsonPropertyName("Text")]
	public virtual string?					Text  {get; set;} //

    /// <summary>
    ///Comment this is a reply to
    /// </summary>

	[JsonPropertyName("ReplyId")]
	public virtual string?					ReplyId  {get; set;} //


    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyString ("Author", 
					(data, value) => {(data as CatalogedComment).Author = value;}, 
					data => (data as CatalogedComment).Author ),
		new PropertyString ("Text", 
					(data, value) => {(data as CatalogedComment).Text = value;}, 
					data => (data as CatalogedComment).Text ),
		new PropertyString ("ReplyId", 
					(data, value) => {(data as CatalogedComment).ReplyId = value;}, 
					data => (data as CatalogedComment).ReplyId )
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedComment> _binding = new (
			new() {
			{ "Author", _properties [0]},
			{ "Text", _properties [1]},
			{ "ReplyId", _properties [2]}}, __Tag,
		() => new CatalogedComment(), () => [], () => [], CatalogedForumEntry._binding, Generic: false);


	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag => __Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "CatalogedComment";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new CatalogedComment();

	}


	/// <summary>
	///
	/// 
	/// </summary>
public partial class CatalogedResource : CatalogedForumEntry {
    /// <summary>
    ///Unique identifier.
    /// </summary>

	[JsonPropertyName("Id")]
	public virtual string?					Id  {get; set;} //

    /// <summary>
    ///The post title in UTF8
    /// </summary>

	[JsonPropertyName("Title")]
	public virtual string?					Title  {get; set;} //

    /// <summary>
    ///The post summary in UTF8 format.
    /// </summary>

	[JsonPropertyName("Summary")]
	public virtual string?					Summary  {get; set;} //


    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyString ("Id", 
					(data, value) => {(data as CatalogedResource).Id = value;}, 
					data => (data as CatalogedResource).Id ),
		new PropertyString ("Title", 
					(data, value) => {(data as CatalogedResource).Title = value;}, 
					data => (data as CatalogedResource).Title ),
		new PropertyString ("Summary", 
					(data, value) => {(data as CatalogedResource).Summary = value;}, 
					data => (data as CatalogedResource).Summary )
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedResource> _binding = new (
			new() {
			{ "Id", _properties [0]},
			{ "Title", _properties [1]},
			{ "Summary", _properties [2]}}, __Tag,
		() => new CatalogedResource(), () => [], () => [], CatalogedForumEntry._binding, Generic: false);


	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag => __Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "CatalogedResource";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new CatalogedResource();

	}


	/// <summary>
	/// </summary>
public partial class AccessControl : ForumItem {
    /// <summary>
    ///User identifiers of administrators
    /// </summary>

	[JsonPropertyName("Administrators")]
	public virtual List<string>?					Administrators  {get; set;}
    /// <summary>
    ///User identifiers of 
    /// </summary>

	[JsonPropertyName("Moderators")]
	public virtual string?					Moderators  {get; set;} //

    /// <summary>
    ///User identifiers of 
    /// </summary>

	[JsonPropertyName("Authors")]
	public virtual string?					Authors  {get; set;} //

    /// <summary>
    ///Bit string assigning privileges to moderators.
    /// </summary>

	[JsonPropertyName("ModeratorPrivileges")]
	public virtual int?					ModeratorPrivileges  {get; set;} //

    /// <summary>
    ///it string assigning privileges to authors
    /// </summary>

	[JsonPropertyName("AuthorPrivileges")]
	public virtual int?					AuthorPrivileges  {get; set;} //

    /// <summary>
    ///it string assigning privileges to visitors
    /// </summary>

	[JsonPropertyName("VisitorPrivileges")]
	public virtual int?					VisitorPrivileges  {get; set;} //


    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyListString ("Administrators", 
					(data, value) => {(data as AccessControl).Administrators = value;}, 
					data => (data as AccessControl).Administrators ),
		new PropertyString ("Moderators", 
					(data, value) => {(data as AccessControl).Moderators = value;}, 
					data => (data as AccessControl).Moderators ),
		new PropertyString ("Authors", 
					(data, value) => {(data as AccessControl).Authors = value;}, 
					data => (data as AccessControl).Authors ),
		new PropertyInteger32 ("ModeratorPrivileges", 
					(data, value) => {(data as AccessControl).ModeratorPrivileges = value;}, 
					data => (data as AccessControl).ModeratorPrivileges ),
		new PropertyInteger32 ("AuthorPrivileges", 
					(data, value) => {(data as AccessControl).AuthorPrivileges = value;}, 
					data => (data as AccessControl).AuthorPrivileges ),
		new PropertyInteger32 ("VisitorPrivileges", 
					(data, value) => {(data as AccessControl).VisitorPrivileges = value;}, 
					data => (data as AccessControl).VisitorPrivileges )
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<AccessControl> _binding = new (
			new() {
			{ "Administrators", _properties [0]},
			{ "Moderators", _properties [1]},
			{ "Authors", _properties [2]},
			{ "ModeratorPrivileges", _properties [3]},
			{ "AuthorPrivileges", _properties [4]},
			{ "VisitorPrivileges", _properties [5]}}, __Tag,
		() => new AccessControl(), () => [], () => [], null, Generic: false);


	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag => __Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "AccessControl";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new AccessControl();

	}



