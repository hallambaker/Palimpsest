
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
//  This file was automatically generated at 10/14/2025 3:42:02 PM
//   
//  Changes to this file may be overwritten without warning
//  
//  Generator:  protogen version 3.0.0.1141
//      Goedel Script Version : 0.1   Generated 
//      Goedel Schema Version : 0.1   Generated
//  
//      Copyright : © 2015-2021
//  
//  Build Platform: Win32NT 10.0.26100.0
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

#pragma warning disable IDE0079
#pragma warning disable IDE1006
#pragma warning disable CA2255 // The 'ModuleInitializer' attribute should not be used in libraries



namespace Goedel.Palimpsest;


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
	    {typeof(EntryAttibutes), EntryAttibutes._binding},
	    {typeof(CatalogedPlace), CatalogedPlace._binding},
	    {typeof(CatalogedForumMember), CatalogedForumMember._binding},
	    {typeof(CatalogedForum), CatalogedForum._binding},
	    {typeof(CatalogedTopic), CatalogedTopic._binding},
	    {typeof(CatalogedResource), CatalogedResource._binding},
	    {typeof(CatalogedFile), CatalogedFile._binding},
	    {typeof(CatalogedSeries), CatalogedSeries._binding},
	    {typeof(CatalogedEvent), CatalogedEvent._binding},
	    {typeof(CatalogedReaction), CatalogedReaction._binding},
	    {typeof(CatalogedReactionSummary), CatalogedReactionSummary._binding},
	    {typeof(ResponseSummary), ResponseSummary._binding},
	    {typeof(CatalogedPost), CatalogedPost._binding},
	    {typeof(CatalogedComment), CatalogedComment._binding},
	    {typeof(CatalogedAnnotation), CatalogedAnnotation._binding},
	    {typeof(AnnotatedResource), AnnotatedResource._binding},
	    {typeof(Terms), Terms._binding}
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
    /// </summary>

	[JsonPropertyName("Added")]
	public virtual DateTime?					Added  {get; set;} //

    /// <summary>
    ///Tag value attributes allowing entry description to be extended.
    /// </summary>

	[JsonPropertyName("Entries")]
	public virtual List<EntryAttibutes>?					Entries  {get; set;}

    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyDateTime ("Added", 
					(IBinding data, DateTime? value) => {(data as CatalogedForumEntry).Added = value;}, 
					(IBinding data) => (data as CatalogedForumEntry).Added ),
		new PropertyListStruct ("Entries", typeof (EntryAttibutes),
					(IBinding data, object? value) => {(data as CatalogedForumEntry).Entries = value as List<EntryAttibutes>;}, 
					(IBinding data) => (data as CatalogedForumEntry).Entries,
					false, ()=>new  List<EntryAttibutes>(), ()=>new EntryAttibutes())
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedForumEntry> _binding = new (
			new() {
			{ "Added", _properties [0]},
			{ "Entries", _properties [1]}}, __Tag,
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
	///
	/// Tag value attributes allowing entry description to be extended.
	/// </summary>
public partial class EntryAttibutes : ForumItem {
    /// <summary>
    ///The attribute type
    /// </summary>

	[JsonPropertyName("Tag")]
	public virtual string?					Tag  {get; set;} //

    /// <summary>
    ///The attribute value
    /// </summary>

	[JsonPropertyName("Value")]
	public virtual string?					Value  {get; set;} //


    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyString ("Tag", 
					(IBinding data, string? value) => {(data as EntryAttibutes).Tag = value;}, 
					(IBinding data) => (data as EntryAttibutes).Tag ),
		new PropertyString ("Value", 
					(IBinding data, string? value) => {(data as EntryAttibutes).Value = value;}, 
					(IBinding data) => (data as EntryAttibutes).Value )
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<EntryAttibutes> _binding = new (
			new() {
			{ "Tag", _properties [0]},
			{ "Value", _properties [1]}}, __Tag,
		() => new EntryAttibutes(), () => [], () => [], null, Generic: false);


	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag => __Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "EntryAttibutes";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new EntryAttibutes();

	}


	/// <summary>
	///
	/// A cataloged project.
	/// </summary>
public partial class CatalogedPlace : CatalogedForumEntry {
    /// <summary>
    ///The forum to which the place belongs.
    /// </summary>

	[JsonPropertyName("ParentForum")]
	public virtual string?					ParentForum  {get; set;} //

    /// <summary>
    /// </summary>

	[JsonPropertyName("Aliases")]
	public virtual List<string>?					Aliases  {get; set;}
    /// <summary>
    ///The members owwning the peoject
    /// </summary>

	[JsonPropertyName("Owners")]
	public virtual List<string>?					Owners  {get; set;}

    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyString ("ParentForum", 
					(IBinding data, string? value) => {(data as CatalogedPlace).ParentForum = value;}, 
					(IBinding data) => (data as CatalogedPlace).ParentForum ),
		new PropertyListString ("Aliases", 
					(IBinding data, List<string>? value) => {(data as CatalogedPlace).Aliases = value;}, 
					(IBinding data) => (data as CatalogedPlace).Aliases ),
		new PropertyListString ("Owners", 
					(IBinding data, List<string>? value) => {(data as CatalogedPlace).Owners = value;}, 
					(IBinding data) => (data as CatalogedPlace).Owners )
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedPlace> _binding = new (
			new() {
			{ "ParentForum", _properties [0]},
			{ "Aliases", _properties [1]},
			{ "Owners", _properties [2]}}, __Tag,
		() => new CatalogedPlace(), () => [], () => [], CatalogedForumEntry._binding, Generic: false);


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
public partial class CatalogedForumMember : CatalogedForumEntry {
    /// <summary>
    ///The user's Did (if used).
    /// </summary>

	[JsonPropertyName("Did")]
	public virtual string?					Did  {get; set;} //

    /// <summary>
    ///The user's fingerprint profile (if known).
    /// </summary>

	[JsonPropertyName("ProfileUdf")]
	public virtual string?					ProfileUdf  {get; set;} //

    /// <summary>
    ///The digest of the user's password
    /// </summary>

	[JsonPropertyName("PasswordDigest")]
	public virtual byte[]?					PasswordDigest  {get; set;} //

    /// <summary>
    ///The user's Mesh contact (if provided). 
    /// </summary>

	[JsonPropertyName("Contact")]
	public virtual byte[]?					Contact  {get; set;} //

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

    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyString ("Did", 
					(IBinding data, string? value) => {(data as CatalogedForumMember).Did = value;}, 
					(IBinding data) => (data as CatalogedForumMember).Did ),
		new PropertyString ("ProfileUdf", 
					(IBinding data, string? value) => {(data as CatalogedForumMember).ProfileUdf = value;}, 
					(IBinding data) => (data as CatalogedForumMember).ProfileUdf ),
		new PropertyBinary ("PasswordDigest", 
					(IBinding data, byte[]? value) => {(data as CatalogedForumMember).PasswordDigest = value;}, 
					(IBinding data) => (data as CatalogedForumMember).PasswordDigest ),
		new PropertyBinary ("Contact", 
					(IBinding data, byte[]? value) => {(data as CatalogedForumMember).Contact = value;}, 
					(IBinding data) => (data as CatalogedForumMember).Contact ),
		new PropertyString ("Status", 
					(IBinding data, string? value) => {(data as CatalogedForumMember).Status = value;}, 
					(IBinding data) => (data as CatalogedForumMember).Status ),
		new PropertyListString ("Privileges", 
					(IBinding data, List<string>? value) => {(data as CatalogedForumMember).Privileges = value;}, 
					(IBinding data) => (data as CatalogedForumMember).Privileges )
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedForumMember> _binding = new (
			new() {
			{ "Did", _properties [0]},
			{ "ProfileUdf", _properties [1]},
			{ "PasswordDigest", _properties [2]},
			{ "Contact", _properties [3]},
			{ "Status", _properties [4]},
			{ "Privileges", _properties [5]}}, __Tag,
		() => new CatalogedForumMember(), () => [], () => [], CatalogedForumEntry._binding, Generic: false);


	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag => __Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "CatalogedForumMember";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new CatalogedForumMember();

	}


	/// <summary>
	/// </summary>
public partial class CatalogedForum : CatalogedForumEntry {

    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedForum> _binding = new (
			new() {}, __Tag,
		() => new CatalogedForum(), () => [], () => [], CatalogedForumEntry._binding, Generic: false);


	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag => __Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "CatalogedForum";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new CatalogedForum();

	}


	/// <summary>
	///
	/// A cataloged topic.
	/// </summary>
public partial class CatalogedTopic : CatalogedForum {

    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedTopic> _binding = new (
			new() {}, __Tag,
		() => new CatalogedTopic(), () => [], () => [], CatalogedForum._binding, Generic: false);


	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag => __Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "CatalogedTopic";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new CatalogedTopic();

	}


	/// <summary>
	///
	/// A cataloged resource.
	/// </summary>
public partial class CatalogedResource : CatalogedForum {
    /// <summary>
    ///The IANA content type
    /// </summary>

	[JsonPropertyName("ContentType")]
	public virtual string?					ContentType  {get; set;} //

    /// <summary>
    ///The series identifier, if this item is a part of a versioned series.
    /// </summary>

	[JsonPropertyName("SeriesId")]
	public virtual string?					SeriesId  {get; set;} //

    /// <summary>
    ///The version indicator. This SHOULD be unique among resources with the
    ///same series identifier.
    /// </summary>

	[JsonPropertyName("Version")]
	public virtual string?					Version  {get; set;} //

    /// <summary>
    ///If not false, the resource may be annotated.
    /// </summary>

	[JsonPropertyName("Annotatable")]
	public virtual bool?					Annotatable  {get; set;} //


    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyString ("ContentType", 
					(IBinding data, string? value) => {(data as CatalogedResource).ContentType = value;}, 
					(IBinding data) => (data as CatalogedResource).ContentType ),
		new PropertyString ("SeriesId", 
					(IBinding data, string? value) => {(data as CatalogedResource).SeriesId = value;}, 
					(IBinding data) => (data as CatalogedResource).SeriesId ),
		new PropertyString ("Version", 
					(IBinding data, string? value) => {(data as CatalogedResource).Version = value;}, 
					(IBinding data) => (data as CatalogedResource).Version ),
		new PropertyBoolean ("Annotatable", 
					(IBinding data, bool? value) => {(data as CatalogedResource).Annotatable = value;}, 
					(IBinding data) => (data as CatalogedResource).Annotatable )
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedResource> _binding = new (
			new() {
			{ "ContentType", _properties [0]},
			{ "SeriesId", _properties [1]},
			{ "Version", _properties [2]},
			{ "Annotatable", _properties [3]}}, __Tag,
		() => new CatalogedResource(), () => [], () => [], CatalogedForum._binding, Generic: false);


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
	///
	/// A cataloged resource represented by a file with associated data.
	/// This may be a document, an image, etc.
	/// </summary>
public partial class CatalogedFile : CatalogedResource {

    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedFile> _binding = new (
			new() {}, __Tag,
		() => new CatalogedFile(), () => [], () => [], CatalogedResource._binding, Generic: false);


	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag => __Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "CatalogedFile";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new CatalogedFile();

	}


	/// <summary>
	///
	/// Collects a group of related resources together into a series.
	/// </summary>
public partial class CatalogedSeries : CatalogedResource {

    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedSeries> _binding = new (
			new() {}, __Tag,
		() => new CatalogedSeries(), () => [], () => [], CatalogedResource._binding, Generic: false);


	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag => __Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "CatalogedSeries";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new CatalogedSeries();

	}


	/// <summary>
	///
	/// A cataloged event. This may be an online event, an inperson
	/// meetup or both.
	/// </summary>
public partial class CatalogedEvent : CatalogedResource {
    /// <summary>
    ///Event venue: Online/Meetup/Hybrid
    /// </summary>

	[JsonPropertyName("Venue")]
	public virtual string?					Venue  {get; set;} //

    /// <summary>
    ///Start date for the event
    /// </summary>

	[JsonPropertyName("Start")]
	public virtual DateTime?					Start  {get; set;} //

    /// <summary>
    ///End date for the event
    /// </summary>

	[JsonPropertyName("Finish")]
	public virtual DateTime?					Finish  {get; set;} //

    /// <summary>
    ///Physical location for the event
    /// </summary>

	[JsonPropertyName("PhysicalLocation")]
	public virtual string?					PhysicalLocation  {get; set;} //

    /// <summary>
    ///Online resource for the event
    /// </summary>

	[JsonPropertyName("Online")]
	public virtual string?					Online  {get; set;} //

    /// <summary>
    ///The members organizing the event
    /// </summary>

	[JsonPropertyName("Organizers")]
	public virtual List<string>?					Organizers  {get; set;}

    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyString ("Venue", 
					(IBinding data, string? value) => {(data as CatalogedEvent).Venue = value;}, 
					(IBinding data) => (data as CatalogedEvent).Venue ),
		new PropertyDateTime ("Start", 
					(IBinding data, DateTime? value) => {(data as CatalogedEvent).Start = value;}, 
					(IBinding data) => (data as CatalogedEvent).Start ),
		new PropertyDateTime ("Finish", 
					(IBinding data, DateTime? value) => {(data as CatalogedEvent).Finish = value;}, 
					(IBinding data) => (data as CatalogedEvent).Finish ),
		new PropertyString ("PhysicalLocation", 
					(IBinding data, string? value) => {(data as CatalogedEvent).PhysicalLocation = value;}, 
					(IBinding data) => (data as CatalogedEvent).PhysicalLocation ),
		new PropertyString ("Online", 
					(IBinding data, string? value) => {(data as CatalogedEvent).Online = value;}, 
					(IBinding data) => (data as CatalogedEvent).Online ),
		new PropertyListString ("Organizers", 
					(IBinding data, List<string>? value) => {(data as CatalogedEvent).Organizers = value;}, 
					(IBinding data) => (data as CatalogedEvent).Organizers )
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedEvent> _binding = new (
			new() {
			{ "Venue", _properties [0]},
			{ "Start", _properties [1]},
			{ "Finish", _properties [2]},
			{ "PhysicalLocation", _properties [3]},
			{ "Online", _properties [4]},
			{ "Organizers", _properties [5]}}, __Tag,
		() => new CatalogedEvent(), () => [], () => [], CatalogedResource._binding, Generic: false);


	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag => __Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "CatalogedEvent";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new CatalogedEvent();

	}


	/// <summary>
	///
	/// User response to a Forum Entry, minimally consisting of a 
	/// User identifier and a semantic.
	/// </summary>
public partial class CatalogedReaction : CatalogedForumEntry {
    /// <summary>
    ///The identifier of the member responding.
    /// </summary>

	[JsonPropertyName("MemberId")]
	public virtual string?					MemberId  {get; set;} //

    /// <summary>
    ///The response semantic.
    /// </summary>

	[JsonPropertyName("Semantic")]
	public virtual string?					Semantic  {get; set;} //


    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyString ("MemberId", 
					(IBinding data, string? value) => {(data as CatalogedReaction).MemberId = value;}, 
					(IBinding data) => (data as CatalogedReaction).MemberId ),
		new PropertyString ("Semantic", 
					(IBinding data, string? value) => {(data as CatalogedReaction).Semantic = value;}, 
					(IBinding data) => (data as CatalogedReaction).Semantic )
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedReaction> _binding = new (
			new() {
			{ "MemberId", _properties [0]},
			{ "Semantic", _properties [1]}}, __Tag,
		() => new CatalogedReaction(), () => [], () => [], CatalogedForumEntry._binding, Generic: false);


	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag => __Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "CatalogedReaction";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new CatalogedReaction();

	}


	/// <summary>
	///
	/// A collection of responses compiled into a summary for fast indexing.
	/// </summary>
public partial class CatalogedReactionSummary : CatalogedReaction {
    /// <summary>
    ///A Bloom filter which MAY be used to quickly determine that a member
    ///has NOT made a response.
    /// </summary>

	[JsonPropertyName("Filter")]
	public virtual byte[]?					Filter  {get; set;} //

    /// <summary>
    ///
    /// </summary>

	[JsonPropertyName("Summaries")]
	public virtual ResponseSummary?					Summaries  {get; set;} //


    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyBinary ("Filter", 
					(IBinding data, byte[]? value) => {(data as CatalogedReactionSummary).Filter = value;}, 
					(IBinding data) => (data as CatalogedReactionSummary).Filter ),
		new PropertyStruct ("Summaries", typeof (ResponseSummary),
					(IBinding data, object? value) => {(data as CatalogedReactionSummary).Summaries = value as ResponseSummary;}, 
					(IBinding data) => (data as CatalogedReactionSummary).Summaries,
					false, ()=>new  ResponseSummary(), ()=>new ResponseSummary())
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedReactionSummary> _binding = new (
			new() {
			{ "Filter", _properties [0]},
			{ "Summaries", _properties [1]}}, __Tag,
		() => new CatalogedReactionSummary(), () => [], () => [], CatalogedReaction._binding, Generic: false);


	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag => __Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "CatalogedReactionSummary";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new CatalogedReactionSummary();

	}


	/// <summary>
	/// </summary>
public partial class ResponseSummary : ForumItem {
    /// <summary>
    ///The response semantic.
    /// </summary>

	[JsonPropertyName("Semantic")]
	public virtual string?					Semantic  {get; set;} //

    /// <summary>
    ///The count of the response summary
    /// </summary>

	[JsonPropertyName("Count")]
	public virtual int?					Count  {get; set;} //

    /// <summary>
    ///The members who made this response
    /// </summary>

	[JsonPropertyName("MemberIds")]
	public virtual List<string>?					MemberIds  {get; set;}

    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyString ("Semantic", 
					(IBinding data, string? value) => {(data as ResponseSummary).Semantic = value;}, 
					(IBinding data) => (data as ResponseSummary).Semantic ),
		new PropertyInteger32 ("Count", 
					(IBinding data, int? value) => {(data as ResponseSummary).Count = value;}, 
					(IBinding data) => (data as ResponseSummary).Count ),
		new PropertyListString ("MemberIds", 
					(IBinding data, List<string>? value) => {(data as ResponseSummary).MemberIds = value;}, 
					(IBinding data) => (data as ResponseSummary).MemberIds )
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<ResponseSummary> _binding = new (
			new() {
			{ "Semantic", _properties [0]},
			{ "Count", _properties [1]},
			{ "MemberIds", _properties [2]}}, __Tag,
		() => new ResponseSummary(), () => [], () => [], null, Generic: false);


	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag => __Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "ResponseSummary";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new ResponseSummary();

	}


	/// <summary>
	///
	/// Post on a topic
	/// </summary>
public partial class CatalogedPost : CatalogedReaction {
    /// <summary>
    ///One line subject decribing the topic
    /// </summary>

	[JsonPropertyName("Subject")]
	public virtual string?					Subject  {get; set;} //

    /// <summary>
    ///The topic introduction. May span multiple lines
    /// </summary>

	[JsonPropertyName("Text")]
	public virtual string?					Text  {get; set;} //


    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyString ("Subject", 
					(IBinding data, string? value) => {(data as CatalogedPost).Subject = value;}, 
					(IBinding data) => (data as CatalogedPost).Subject ),
		new PropertyString ("Text", 
					(IBinding data, string? value) => {(data as CatalogedPost).Text = value;}, 
					(IBinding data) => (data as CatalogedPost).Text )
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedPost> _binding = new (
			new() {
			{ "Subject", _properties [0]},
			{ "Text", _properties [1]}}, __Tag,
		() => new CatalogedPost(), () => [], () => [], CatalogedReaction._binding, Generic: false);


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
	/// Post on a topic
	/// </summary>
public partial class CatalogedComment : CatalogedReaction {
    /// <summary>
    ///The topic introduction. May span multiple lines
    /// </summary>

	[JsonPropertyName("Text")]
	public virtual string?					Text  {get; set;} //


    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyString ("Text", 
					(IBinding data, string? value) => {(data as CatalogedComment).Text = value;}, 
					(IBinding data) => (data as CatalogedComment).Text )
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedComment> _binding = new (
			new() {
			{ "Text", _properties [0]}}, __Tag,
		() => new CatalogedComment(), () => [], () => [], CatalogedReaction._binding, Generic: false);


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
	/// Extended response to a Forum Entry with text and optional anchor
	/// and references.
	/// </summary>
public partial class CatalogedAnnotation : CatalogedReaction {
    /// <summary>
    ///
    /// </summary>

	[JsonPropertyName("Anchor")]
	public virtual string?					Anchor  {get; set;} //

    /// <summary>
    ///
    /// </summary>

	[JsonPropertyName("Text")]
	public virtual string?					Text  {get; set;} //

    /// <summary>
    /// </summary>

	[JsonPropertyName("References")]
	public virtual List<string>?					References  {get; set;}

    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyString ("Anchor", 
					(IBinding data, string? value) => {(data as CatalogedAnnotation).Anchor = value;}, 
					(IBinding data) => (data as CatalogedAnnotation).Anchor ),
		new PropertyString ("Text", 
					(IBinding data, string? value) => {(data as CatalogedAnnotation).Text = value;}, 
					(IBinding data) => (data as CatalogedAnnotation).Text ),
		new PropertyListString ("References", 
					(IBinding data, List<string>? value) => {(data as CatalogedAnnotation).References = value;}, 
					(IBinding data) => (data as CatalogedAnnotation).References )
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedAnnotation> _binding = new (
			new() {
			{ "Anchor", _properties [0]},
			{ "Text", _properties [1]},
			{ "References", _properties [2]}}, __Tag,
		() => new CatalogedAnnotation(), () => [], () => [], CatalogedReaction._binding, Generic: false);


	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag => __Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "CatalogedAnnotation";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new CatalogedAnnotation();

	}


	/// <summary>
	///
	/// An anotated resource 
	/// </summary>
public partial class AnnotatedResource : ForumItem {
    /// <summary>
    ///
    /// </summary>

	[JsonPropertyName("Resource")]
	public virtual CatalogedResource?					Resource  {get; set;} //

    /// <summary>
    ///
    /// </summary>

	[JsonPropertyName("Responses")]
	public virtual List<CatalogedReaction>?					Responses  {get; set;}

    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyStruct ("Resource", typeof (CatalogedResource),
					(IBinding data, object? value) => {(data as AnnotatedResource).Resource = value as CatalogedResource;}, 
					(IBinding data) => (data as AnnotatedResource).Resource,
					false, ()=>new  CatalogedResource(), ()=>new CatalogedResource()),
		new PropertyListStruct ("Responses", typeof (CatalogedReaction),
					(IBinding data, object? value) => {(data as AnnotatedResource).Responses = value as List<CatalogedReaction>;}, 
					(IBinding data) => (data as AnnotatedResource).Responses,
					false, ()=>new  List<CatalogedReaction>(), ()=>new CatalogedReaction())
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<AnnotatedResource> _binding = new (
			new() {
			{ "Resource", _properties [0]},
			{ "Responses", _properties [1]}}, __Tag,
		() => new AnnotatedResource(), () => [], () => [], null, Generic: false);


	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag => __Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "AnnotatedResource";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new AnnotatedResource();

	}


	/// <summary>
	/// </summary>
public partial class Terms : ForumItem {

    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<Terms> _binding = new (
			new() {}, __Tag,
		() => new Terms(), () => [], () => [], null, Generic: false);


	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public override string _Tag => __Tag;

	/// <summary>
    /// Tag identifying this class
    /// </summary>
	public new const string __Tag = "Terms";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new Terms();

	}



