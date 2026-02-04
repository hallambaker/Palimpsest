
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
//  This file was automatically generated at 2/3/2026 1:22:31 PM
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

#pragma warning disable IDE0028 // Don't warn collection initialization can be simplified.
#pragma warning disable IDE0079
#pragma warning disable IDE1006
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

	    {typeof(CatalogedForumEntry), CatalogedForumEntry._binding},
	    {typeof(CatalogedForumOwned), CatalogedForumOwned._binding},
	    {typeof(CatalogedPlace), CatalogedPlace._binding},
	    {typeof(CatalogedForumVisitor), CatalogedForumVisitor._binding},
	    {typeof(CatalogedFeed), CatalogedFeed._binding},
	    {typeof(CatalogedPost), CatalogedPost._binding},
	    {typeof(CatalogedComment), CatalogedComment._binding},
	    {typeof(CatalogedResource), CatalogedResource._binding}
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
    ///Avatar representing the entry
    /// </summary>

	[JsonPropertyName("Avatar")]
	public virtual string?					Avatar  {get; set;} //

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
		new PropertyString ("Avatar", 
					(data, value) => {(data as CatalogedForumOwned).Avatar = value;}, 
					data => (data as CatalogedForumOwned).Avatar ),
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
			{ "Avatar", _properties [1]},
			{ "Owners", _properties [2]}}, __Tag,
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
	///
	/// A cataloged project.
	/// </summary>
public partial class CatalogedPlace : CatalogedForumOwned {
    /// <summary>
    ///Alternative DNS names
    /// </summary>

	[JsonPropertyName("Aliases")]
	public virtual List<string>?					Aliases  {get; set;}
    /// <summary>
    ///Splash screen for the place
    /// </summary>

	[JsonPropertyName("Banner")]
	public virtual string?					Banner  {get; set;} //

    /// <summary>
    ///The conversation streams
    /// </summary>

	[JsonPropertyName("Stream")]
	public virtual List<CatalogedFeed>?					Stream  {get; set;}

    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyListString ("Aliases", 
					(data, value) => {(data as CatalogedPlace).Aliases = value;}, 
					data => (data as CatalogedPlace).Aliases ),
		new PropertyString ("Banner", 
					(data, value) => {(data as CatalogedPlace).Banner = value;}, 
					data => (data as CatalogedPlace).Banner ),
		new PropertyListStruct ("Stream", typeof (CatalogedFeed),
					(data, value) => {(data as CatalogedPlace).Stream = value as List<CatalogedFeed>;}, 
					data => (data as CatalogedPlace).Stream,
					false, ()=>new  List<CatalogedFeed>(), ()=>new CatalogedFeed())
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedPlace> _binding = new (
			new() {
			{ "Aliases", _properties [0]},
			{ "Banner", _properties [1]},
			{ "Stream", _properties [2]}}, __Tag,
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
public partial class CatalogedForumVisitor : CatalogedForumEntry {
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
    ///Assigned privileges (Admin / Moderator)
    /// </summary>

	[JsonPropertyName("Privileges")]
	public virtual List<string>?					Privileges  {get; set;}
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
					(data, value) => {(data as CatalogedForumVisitor).Did = value;}, 
					data => (data as CatalogedForumVisitor).Did ),
		new PropertyString ("Handle", 
					(data, value) => {(data as CatalogedForumVisitor).Handle = value;}, 
					data => (data as CatalogedForumVisitor).Handle ),
		new PropertyString ("Avatar", 
					(data, value) => {(data as CatalogedForumVisitor).Avatar = value;}, 
					data => (data as CatalogedForumVisitor).Avatar ),
		new PropertyString ("Banner", 
					(data, value) => {(data as CatalogedForumVisitor).Banner = value;}, 
					data => (data as CatalogedForumVisitor).Banner ),
		new PropertyString ("Status", 
					(data, value) => {(data as CatalogedForumVisitor).Status = value;}, 
					data => (data as CatalogedForumVisitor).Status ),
		new PropertyListString ("Privileges", 
					(data, value) => {(data as CatalogedForumVisitor).Privileges = value;}, 
					data => (data as CatalogedForumVisitor).Privileges ),
		new PropertyListString ("Places", 
					(data, value) => {(data as CatalogedForumVisitor).Places = value;}, 
					data => (data as CatalogedForumVisitor).Places )
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedForumVisitor> _binding = new (
			new() {
			{ "Did", _properties [0]},
			{ "Handle", _properties [1]},
			{ "Avatar", _properties [2]},
			{ "Banner", _properties [3]},
			{ "Status", _properties [4]},
			{ "Privileges", _properties [5]},
			{ "Places", _properties [6]}}, __Tag,
		() => new CatalogedForumVisitor(), () => [], () => [], CatalogedForumEntry._binding, Generic: false);


	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag => __Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "CatalogedForumVisitor";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new CatalogedForumVisitor();

	}


	/// <summary>
	///
	/// 
	/// </summary>
public partial class CatalogedFeed : CatalogedForumOwned {
    /// <summary>
    ///Posts to the stream
    /// </summary>

	[JsonPropertyName("Posts")]
	public virtual List<CatalogedPost>?					Posts  {get; set;}

    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyListStruct ("Posts", typeof (CatalogedPost),
					(data, value) => {(data as CatalogedFeed).Posts = value as List<CatalogedPost>;}, 
					data => (data as CatalogedFeed).Posts,
					false, ()=>new  List<CatalogedPost>(), ()=>new CatalogedPost())
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedFeed> _binding = new (
			new() {
			{ "Posts", _properties [0]}}, __Tag,
		() => new CatalogedFeed(), () => [], () => [], CatalogedForumOwned._binding, Generic: false);


	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag => __Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "CatalogedStream";

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
    ///The post title in UTF8
    /// </summary>

	[JsonPropertyName("Title")]
	public virtual string?					Title  {get; set;} //

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
		new PropertyString ("Title", 
					(data, value) => {(data as CatalogedPost).Title = value;}, 
					data => (data as CatalogedPost).Title ),
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
			{ "Title", _properties [0]},
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
    ///The comment text in UTF8 format.
    /// </summary>

	[JsonPropertyName("Text")]
	public virtual string?					Text  {get; set;} //


    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyString ("Text", 
					(data, value) => {(data as CatalogedComment).Text = value;}, 
					data => (data as CatalogedComment).Text )
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedComment> _binding = new (
			new() {
			{ "Text", _properties [0]}}, __Tag,
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



