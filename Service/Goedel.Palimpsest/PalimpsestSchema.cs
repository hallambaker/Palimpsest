
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
//  This file was automatically generated at 5/23/2025 12:34:36 AM
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
    /// Dictionary mapping tags to factory methods
    /// </summary>
	public static Dictionary<string, JsonFactoryDelegate> _TagDictionary=> _tagDictionary;
	static Dictionary<string, JsonFactoryDelegate> _tagDictionary = 
			new () {

	    {"CatalogedForumEntry", CatalogedForumEntry._Factory},
	    {"EntryAttibutes", EntryAttibutes._Factory},
	    {"CatalogedPlace", CatalogedPlace._Factory},
	    {"CatalogedForumMember", CatalogedForumMember._Factory},
	    {"CatalogedForum", CatalogedForum._Factory},
	    {"CatalogedTopic", CatalogedTopic._Factory},
	    {"CatalogedResource", CatalogedResource._Factory},
	    {"CatalogedFile", CatalogedFile._Factory},
	    {"CatalogedSeries", CatalogedSeries._Factory},
	    {"CatalogedEvent", CatalogedEvent._Factory},
	    {"CatalogedReaction", CatalogedReaction._Factory},
	    {"CatalogedReactionSummary", CatalogedReactionSummary._Factory},
	    {"ResponseSummary", ResponseSummary._Factory},
	    {"CatalogedPost", CatalogedPost._Factory},
	    {"CatalogedComment", CatalogedComment._Factory},
	    {"CatalogedAnnotation", CatalogedAnnotation._Factory},
	    {"AnnotatedResource", AnnotatedResource._Factory},
	    {"Terms", Terms._Factory}
		};


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
		AddDictionary(ref _tagDictionary);
		AddDictionary(ref _bindingDictionary);
		}


	/// <summary>
    /// Construct an instance from the specified tagged JsonReader stream.
    /// </summary>
    /// <param name="jsonReader">Input stream</param>
    /// <param name="result">The created object</param>
    public static void Deserialize(JsonReader jsonReader, out JsonObject result) => 
		result = jsonReader.ReadTaggedObject(_TagDictionary);

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
	public virtual DateTime?					Added  {get; set;}

        /// <summary>
        ///Tag value attributes allowing entry description to be extended.
        /// </summary>

	[JsonPropertyName("Entries")]
	public virtual List<EntryAttibutes>?					Entries  {get; set;}


    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedForumEntry> _binding = new (
			new() {

			{ "Added", new PropertyDateTime ("Added", 
					(IBinding data, DateTime? value) => {(data as CatalogedForumEntry).Added = value;}, (IBinding data) => (data as CatalogedForumEntry).Added )},
			{ "Entries", new PropertyListStruct ("Entries", typeof (EntryAttibutes),
					(IBinding data, object? value) => {(data as CatalogedForumEntry).Entries = value as List<EntryAttibutes>;}, (IBinding data) => (data as CatalogedForumEntry).Entries,
					false, ()=>new  List<EntryAttibutes>(), ()=>new EntryAttibutes())}
        }, __Tag,() => new CatalogedForumEntry(), () => new List<CatalogedForumEntry>(), () => new Dictionary<string,CatalogedForumEntry>(),CatalogedEntry._binding);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = _binding.Properties;

	///<summary>Dictionary describing the serializable properties.</summary> 
	public readonly static new Dictionary<string, Property> _StaticAllProperties =
			Combine(CatalogedEntry._binding, _binding);


    ///<inheritdoc/>
	public override Dictionary<string, Property> _AllProperties => _StaticAllProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _Properties => _StaticProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _ParentProperties => base._Properties;



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


    /// <summary>
    /// Deserialize a tagged stream
    /// </summary>
    /// <param name="jsonReader">The input stream</param>
	/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
    /// <returns>The created object.</returns>		
    public static new CatalogedForumEntry FromJson (JsonReader jsonReader, bool tagged=true) {
		if (jsonReader == null) {
			return null;
			}
		if (tagged) {
			var Out = jsonReader.ReadTaggedObject (_TagDictionary);
			return Out as CatalogedForumEntry;
			}
		var Result = new CatalogedForumEntry ();
		Result.Deserialize (jsonReader);
		Result.PostDecode();
		return Result;
		}


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
	public virtual string?					Tag  {get; set;}

        /// <summary>
        ///The attribute value
        /// </summary>

	[JsonPropertyName("Value")]
	public virtual string?					Value  {get; set;}



    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<EntryAttibutes> _binding = new (
			new() {

			{ "Tag", new PropertyString ("Tag", 
					(IBinding data, string? value) => {(data as EntryAttibutes).Tag = value;}, (IBinding data) => (data as EntryAttibutes).Tag )},
			{ "Value", new PropertyString ("Value", 
					(IBinding data, string? value) => {(data as EntryAttibutes).Value = value;}, (IBinding data) => (data as EntryAttibutes).Value )}
        }, __Tag,() => new EntryAttibutes(), () => new List<EntryAttibutes>(), () => new Dictionary<string,EntryAttibutes>(),null);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = _binding.Properties;

	///<summary>Dictionary describing the serializable properties.</summary> 
	public readonly static new Dictionary<string, Property> _StaticAllProperties = _StaticProperties;


    ///<inheritdoc/>
	public override Dictionary<string, Property> _AllProperties => _StaticAllProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _Properties => _StaticProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _ParentProperties => base._Properties;



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


    /// <summary>
    /// Deserialize a tagged stream
    /// </summary>
    /// <param name="jsonReader">The input stream</param>
	/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
    /// <returns>The created object.</returns>		
    public static new EntryAttibutes FromJson (JsonReader jsonReader, bool tagged=true) {
		if (jsonReader == null) {
			return null;
			}
		if (tagged) {
			var Out = jsonReader.ReadTaggedObject (_TagDictionary);
			return Out as EntryAttibutes;
			}
		var Result = new EntryAttibutes ();
		Result.Deserialize (jsonReader);
		Result.PostDecode();
		return Result;
		}


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
	public virtual string?					ParentForum  {get; set;}

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
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedPlace> _binding = new (
			new() {

			{ "ParentForum", new PropertyString ("ParentForum", 
					(IBinding data, string? value) => {(data as CatalogedPlace).ParentForum = value;}, (IBinding data) => (data as CatalogedPlace).ParentForum )},
			{ "Aliases", new PropertyListString ("Aliases", 
					(IBinding data, List<string>? value) => {(data as CatalogedPlace).Aliases = value;}, (IBinding data) => (data as CatalogedPlace).Aliases )},
			{ "Owners", new PropertyListString ("Owners", 
					(IBinding data, List<string>? value) => {(data as CatalogedPlace).Owners = value;}, (IBinding data) => (data as CatalogedPlace).Owners )}
        }, __Tag,() => new CatalogedPlace(), () => new List<CatalogedPlace>(), () => new Dictionary<string,CatalogedPlace>(),CatalogedForumEntry._binding);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = _binding.Properties;

	///<summary>Dictionary describing the serializable properties.</summary> 
	public readonly static new Dictionary<string, Property> _StaticAllProperties =
			Combine(CatalogedForumEntry._binding, _binding);


    ///<inheritdoc/>
	public override Dictionary<string, Property> _AllProperties => _StaticAllProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _Properties => _StaticProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _ParentProperties => base._Properties;



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


    /// <summary>
    /// Deserialize a tagged stream
    /// </summary>
    /// <param name="jsonReader">The input stream</param>
	/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
    /// <returns>The created object.</returns>		
    public static new CatalogedPlace FromJson (JsonReader jsonReader, bool tagged=true) {
		if (jsonReader == null) {
			return null;
			}
		if (tagged) {
			var Out = jsonReader.ReadTaggedObject (_TagDictionary);
			return Out as CatalogedPlace;
			}
		var Result = new CatalogedPlace ();
		Result.Deserialize (jsonReader);
		Result.PostDecode();
		return Result;
		}


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
	public virtual string?					Did  {get; set;}

        /// <summary>
        ///The user's fingerprint profile (if known).
        /// </summary>

	[JsonPropertyName("ProfileUdf")]
	public virtual string?					ProfileUdf  {get; set;}

        /// <summary>
        ///The digest of the user's password
        /// </summary>

	[JsonPropertyName("PasswordDigest")]
	public virtual byte[]?					PasswordDigest  {get; set;}

        /// <summary>
        ///The user's Mesh contact (if provided). 
        /// </summary>

	[JsonPropertyName("Contact")]
	public virtual byte[]?					Contact  {get; set;}

        /// <summary>
        ///The member's status: Active / Inactive / Blocked
        /// </summary>

	[JsonPropertyName("Status")]
	public virtual string?					Status  {get; set;}

        /// <summary>
        ///Assigned privileges (Admin / Moderator)
        /// </summary>

	[JsonPropertyName("Privileges")]
	public virtual List<string>?					Privileges  {get; set;}


    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedForumMember> _binding = new (
			new() {

			{ "Did", new PropertyString ("Did", 
					(IBinding data, string? value) => {(data as CatalogedForumMember).Did = value;}, (IBinding data) => (data as CatalogedForumMember).Did )},
			{ "ProfileUdf", new PropertyString ("ProfileUdf", 
					(IBinding data, string? value) => {(data as CatalogedForumMember).ProfileUdf = value;}, (IBinding data) => (data as CatalogedForumMember).ProfileUdf )},
			{ "PasswordDigest", new PropertyBinary ("PasswordDigest", 
					(IBinding data, byte[]? value) => {(data as CatalogedForumMember).PasswordDigest = value;}, (IBinding data) => (data as CatalogedForumMember).PasswordDigest )},
			{ "Contact", new PropertyBinary ("Contact", 
					(IBinding data, byte[]? value) => {(data as CatalogedForumMember).Contact = value;}, (IBinding data) => (data as CatalogedForumMember).Contact )},
			{ "Status", new PropertyString ("Status", 
					(IBinding data, string? value) => {(data as CatalogedForumMember).Status = value;}, (IBinding data) => (data as CatalogedForumMember).Status )},
			{ "Privileges", new PropertyListString ("Privileges", 
					(IBinding data, List<string>? value) => {(data as CatalogedForumMember).Privileges = value;}, (IBinding data) => (data as CatalogedForumMember).Privileges )}
        }, __Tag,() => new CatalogedForumMember(), () => new List<CatalogedForumMember>(), () => new Dictionary<string,CatalogedForumMember>(),CatalogedForumEntry._binding);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = _binding.Properties;

	///<summary>Dictionary describing the serializable properties.</summary> 
	public readonly static new Dictionary<string, Property> _StaticAllProperties =
			Combine(CatalogedForumEntry._binding, _binding);


    ///<inheritdoc/>
	public override Dictionary<string, Property> _AllProperties => _StaticAllProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _Properties => _StaticProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _ParentProperties => base._Properties;



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


    /// <summary>
    /// Deserialize a tagged stream
    /// </summary>
    /// <param name="jsonReader">The input stream</param>
	/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
    /// <returns>The created object.</returns>		
    public static new CatalogedForumMember FromJson (JsonReader jsonReader, bool tagged=true) {
		if (jsonReader == null) {
			return null;
			}
		if (tagged) {
			var Out = jsonReader.ReadTaggedObject (_TagDictionary);
			return Out as CatalogedForumMember;
			}
		var Result = new CatalogedForumMember ();
		Result.Deserialize (jsonReader);
		Result.PostDecode();
		return Result;
		}


	}


	/// <summary>
	/// </summary>
public partial class CatalogedForum : CatalogedForumEntry {


    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedForum> _binding = new (
			new() {

        }, __Tag,() => new CatalogedForum(), () => new List<CatalogedForum>(), () => new Dictionary<string,CatalogedForum>(),CatalogedForumEntry._binding);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = _binding.Properties;

	///<summary>Dictionary describing the serializable properties.</summary> 
	public readonly static new Dictionary<string, Property> _StaticAllProperties =
			Combine(CatalogedForumEntry._binding, _binding);


    ///<inheritdoc/>
	public override Dictionary<string, Property> _AllProperties => _StaticAllProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _Properties => _StaticProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _ParentProperties => base._Properties;



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


    /// <summary>
    /// Deserialize a tagged stream
    /// </summary>
    /// <param name="jsonReader">The input stream</param>
	/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
    /// <returns>The created object.</returns>		
    public static new CatalogedForum FromJson (JsonReader jsonReader, bool tagged=true) {
		if (jsonReader == null) {
			return null;
			}
		if (tagged) {
			var Out = jsonReader.ReadTaggedObject (_TagDictionary);
			return Out as CatalogedForum;
			}
		var Result = new CatalogedForum ();
		Result.Deserialize (jsonReader);
		Result.PostDecode();
		return Result;
		}


	}


	/// <summary>
	///
	/// A cataloged topic.
	/// </summary>
public partial class CatalogedTopic : CatalogedForum {


    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedTopic> _binding = new (
			new() {

        }, __Tag,() => new CatalogedTopic(), () => new List<CatalogedTopic>(), () => new Dictionary<string,CatalogedTopic>(),CatalogedForum._binding);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = _binding.Properties;

	///<summary>Dictionary describing the serializable properties.</summary> 
	public readonly static new Dictionary<string, Property> _StaticAllProperties =
			Combine(CatalogedForum._binding, _binding);


    ///<inheritdoc/>
	public override Dictionary<string, Property> _AllProperties => _StaticAllProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _Properties => _StaticProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _ParentProperties => base._Properties;



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


    /// <summary>
    /// Deserialize a tagged stream
    /// </summary>
    /// <param name="jsonReader">The input stream</param>
	/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
    /// <returns>The created object.</returns>		
    public static new CatalogedTopic FromJson (JsonReader jsonReader, bool tagged=true) {
		if (jsonReader == null) {
			return null;
			}
		if (tagged) {
			var Out = jsonReader.ReadTaggedObject (_TagDictionary);
			return Out as CatalogedTopic;
			}
		var Result = new CatalogedTopic ();
		Result.Deserialize (jsonReader);
		Result.PostDecode();
		return Result;
		}


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
	public virtual string?					ContentType  {get; set;}

        /// <summary>
        ///The series identifier, if this item is a part of a versioned series.
        /// </summary>

	[JsonPropertyName("SeriesId")]
	public virtual string?					SeriesId  {get; set;}

        /// <summary>
        ///The version indicator. This SHOULD be unique among resources with the
        ///same series identifier.
        /// </summary>

	[JsonPropertyName("Version")]
	public virtual string?					Version  {get; set;}

        /// <summary>
        ///If not false, the resource may be annotated.
        /// </summary>

	[JsonPropertyName("Annotatable")]
	public virtual bool?					Annotatable  {get; set;}



    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedResource> _binding = new (
			new() {

			{ "ContentType", new PropertyString ("ContentType", 
					(IBinding data, string? value) => {(data as CatalogedResource).ContentType = value;}, (IBinding data) => (data as CatalogedResource).ContentType )},
			{ "SeriesId", new PropertyString ("SeriesId", 
					(IBinding data, string? value) => {(data as CatalogedResource).SeriesId = value;}, (IBinding data) => (data as CatalogedResource).SeriesId )},
			{ "Version", new PropertyString ("Version", 
					(IBinding data, string? value) => {(data as CatalogedResource).Version = value;}, (IBinding data) => (data as CatalogedResource).Version )},
			{ "Annotatable", new PropertyBoolean ("Annotatable", 
					(IBinding data, bool? value) => {(data as CatalogedResource).Annotatable = value;}, (IBinding data) => (data as CatalogedResource).Annotatable )}
        }, __Tag,() => new CatalogedResource(), () => new List<CatalogedResource>(), () => new Dictionary<string,CatalogedResource>(),CatalogedForum._binding);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = _binding.Properties;

	///<summary>Dictionary describing the serializable properties.</summary> 
	public readonly static new Dictionary<string, Property> _StaticAllProperties =
			Combine(CatalogedForum._binding, _binding);


    ///<inheritdoc/>
	public override Dictionary<string, Property> _AllProperties => _StaticAllProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _Properties => _StaticProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _ParentProperties => base._Properties;



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


    /// <summary>
    /// Deserialize a tagged stream
    /// </summary>
    /// <param name="jsonReader">The input stream</param>
	/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
    /// <returns>The created object.</returns>		
    public static new CatalogedResource FromJson (JsonReader jsonReader, bool tagged=true) {
		if (jsonReader == null) {
			return null;
			}
		if (tagged) {
			var Out = jsonReader.ReadTaggedObject (_TagDictionary);
			return Out as CatalogedResource;
			}
		var Result = new CatalogedResource ();
		Result.Deserialize (jsonReader);
		Result.PostDecode();
		return Result;
		}


	}


	/// <summary>
	///
	/// A cataloged resource represented by a file with associated data.
	/// This may be a document, an image, etc.
	/// </summary>
public partial class CatalogedFile : CatalogedResource {


    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedFile> _binding = new (
			new() {

        }, __Tag,() => new CatalogedFile(), () => new List<CatalogedFile>(), () => new Dictionary<string,CatalogedFile>(),CatalogedResource._binding);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = _binding.Properties;

	///<summary>Dictionary describing the serializable properties.</summary> 
	public readonly static new Dictionary<string, Property> _StaticAllProperties =
			Combine(CatalogedResource._binding, _binding);


    ///<inheritdoc/>
	public override Dictionary<string, Property> _AllProperties => _StaticAllProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _Properties => _StaticProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _ParentProperties => base._Properties;



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


    /// <summary>
    /// Deserialize a tagged stream
    /// </summary>
    /// <param name="jsonReader">The input stream</param>
	/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
    /// <returns>The created object.</returns>		
    public static new CatalogedFile FromJson (JsonReader jsonReader, bool tagged=true) {
		if (jsonReader == null) {
			return null;
			}
		if (tagged) {
			var Out = jsonReader.ReadTaggedObject (_TagDictionary);
			return Out as CatalogedFile;
			}
		var Result = new CatalogedFile ();
		Result.Deserialize (jsonReader);
		Result.PostDecode();
		return Result;
		}


	}


	/// <summary>
	///
	/// Collects a group of related resources together into a series.
	/// </summary>
public partial class CatalogedSeries : CatalogedResource {


    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedSeries> _binding = new (
			new() {

        }, __Tag,() => new CatalogedSeries(), () => new List<CatalogedSeries>(), () => new Dictionary<string,CatalogedSeries>(),CatalogedResource._binding);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = _binding.Properties;

	///<summary>Dictionary describing the serializable properties.</summary> 
	public readonly static new Dictionary<string, Property> _StaticAllProperties =
			Combine(CatalogedResource._binding, _binding);


    ///<inheritdoc/>
	public override Dictionary<string, Property> _AllProperties => _StaticAllProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _Properties => _StaticProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _ParentProperties => base._Properties;



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


    /// <summary>
    /// Deserialize a tagged stream
    /// </summary>
    /// <param name="jsonReader">The input stream</param>
	/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
    /// <returns>The created object.</returns>		
    public static new CatalogedSeries FromJson (JsonReader jsonReader, bool tagged=true) {
		if (jsonReader == null) {
			return null;
			}
		if (tagged) {
			var Out = jsonReader.ReadTaggedObject (_TagDictionary);
			return Out as CatalogedSeries;
			}
		var Result = new CatalogedSeries ();
		Result.Deserialize (jsonReader);
		Result.PostDecode();
		return Result;
		}


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
	public virtual string?					Venue  {get; set;}

        /// <summary>
        ///Start date for the event
        /// </summary>

	[JsonPropertyName("Start")]
	public virtual DateTime?					Start  {get; set;}

        /// <summary>
        ///End date for the event
        /// </summary>

	[JsonPropertyName("Finish")]
	public virtual DateTime?					Finish  {get; set;}

        /// <summary>
        ///Physical location for the event
        /// </summary>

	[JsonPropertyName("PhysicalLocation")]
	public virtual string?					PhysicalLocation  {get; set;}

        /// <summary>
        ///Online resource for the event
        /// </summary>

	[JsonPropertyName("Online")]
	public virtual string?					Online  {get; set;}

        /// <summary>
        ///The members organizing the event
        /// </summary>

	[JsonPropertyName("Organizers")]
	public virtual List<string>?					Organizers  {get; set;}


    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedEvent> _binding = new (
			new() {

			{ "Venue", new PropertyString ("Venue", 
					(IBinding data, string? value) => {(data as CatalogedEvent).Venue = value;}, (IBinding data) => (data as CatalogedEvent).Venue )},
			{ "Start", new PropertyDateTime ("Start", 
					(IBinding data, DateTime? value) => {(data as CatalogedEvent).Start = value;}, (IBinding data) => (data as CatalogedEvent).Start )},
			{ "Finish", new PropertyDateTime ("Finish", 
					(IBinding data, DateTime? value) => {(data as CatalogedEvent).Finish = value;}, (IBinding data) => (data as CatalogedEvent).Finish )},
			{ "PhysicalLocation", new PropertyString ("PhysicalLocation", 
					(IBinding data, string? value) => {(data as CatalogedEvent).PhysicalLocation = value;}, (IBinding data) => (data as CatalogedEvent).PhysicalLocation )},
			{ "Online", new PropertyString ("Online", 
					(IBinding data, string? value) => {(data as CatalogedEvent).Online = value;}, (IBinding data) => (data as CatalogedEvent).Online )},
			{ "Organizers", new PropertyListString ("Organizers", 
					(IBinding data, List<string>? value) => {(data as CatalogedEvent).Organizers = value;}, (IBinding data) => (data as CatalogedEvent).Organizers )}
        }, __Tag,() => new CatalogedEvent(), () => new List<CatalogedEvent>(), () => new Dictionary<string,CatalogedEvent>(),CatalogedResource._binding);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = _binding.Properties;

	///<summary>Dictionary describing the serializable properties.</summary> 
	public readonly static new Dictionary<string, Property> _StaticAllProperties =
			Combine(CatalogedResource._binding, _binding);


    ///<inheritdoc/>
	public override Dictionary<string, Property> _AllProperties => _StaticAllProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _Properties => _StaticProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _ParentProperties => base._Properties;



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


    /// <summary>
    /// Deserialize a tagged stream
    /// </summary>
    /// <param name="jsonReader">The input stream</param>
	/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
    /// <returns>The created object.</returns>		
    public static new CatalogedEvent FromJson (JsonReader jsonReader, bool tagged=true) {
		if (jsonReader == null) {
			return null;
			}
		if (tagged) {
			var Out = jsonReader.ReadTaggedObject (_TagDictionary);
			return Out as CatalogedEvent;
			}
		var Result = new CatalogedEvent ();
		Result.Deserialize (jsonReader);
		Result.PostDecode();
		return Result;
		}


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
	public virtual string?					MemberId  {get; set;}

        /// <summary>
        ///The response semantic.
        /// </summary>

	[JsonPropertyName("Semantic")]
	public virtual string?					Semantic  {get; set;}



    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedReaction> _binding = new (
			new() {

			{ "MemberId", new PropertyString ("MemberId", 
					(IBinding data, string? value) => {(data as CatalogedReaction).MemberId = value;}, (IBinding data) => (data as CatalogedReaction).MemberId )},
			{ "Semantic", new PropertyString ("Semantic", 
					(IBinding data, string? value) => {(data as CatalogedReaction).Semantic = value;}, (IBinding data) => (data as CatalogedReaction).Semantic )}
        }, __Tag,() => new CatalogedReaction(), () => new List<CatalogedReaction>(), () => new Dictionary<string,CatalogedReaction>(),CatalogedForumEntry._binding);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = _binding.Properties;

	///<summary>Dictionary describing the serializable properties.</summary> 
	public readonly static new Dictionary<string, Property> _StaticAllProperties =
			Combine(CatalogedForumEntry._binding, _binding);


    ///<inheritdoc/>
	public override Dictionary<string, Property> _AllProperties => _StaticAllProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _Properties => _StaticProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _ParentProperties => base._Properties;



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


    /// <summary>
    /// Deserialize a tagged stream
    /// </summary>
    /// <param name="jsonReader">The input stream</param>
	/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
    /// <returns>The created object.</returns>		
    public static new CatalogedReaction FromJson (JsonReader jsonReader, bool tagged=true) {
		if (jsonReader == null) {
			return null;
			}
		if (tagged) {
			var Out = jsonReader.ReadTaggedObject (_TagDictionary);
			return Out as CatalogedReaction;
			}
		var Result = new CatalogedReaction ();
		Result.Deserialize (jsonReader);
		Result.PostDecode();
		return Result;
		}


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
	public virtual byte[]?					Filter  {get; set;}

        /// <summary>
        ///
        /// </summary>

	[JsonPropertyName("Summaries")]
	public virtual ResponseSummary?					Summaries  {get; set;}



    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedReactionSummary> _binding = new (
			new() {

			{ "Filter", new PropertyBinary ("Filter", 
					(IBinding data, byte[]? value) => {(data as CatalogedReactionSummary).Filter = value;}, (IBinding data) => (data as CatalogedReactionSummary).Filter )},
			{ "Summaries", new PropertyStruct ("Summaries", typeof (ResponseSummary),
					(IBinding data, object? value) => {(data as CatalogedReactionSummary).Summaries = value as ResponseSummary;}, (IBinding data) => (data as CatalogedReactionSummary).Summaries,
					false, ()=>new  ResponseSummary(), ()=>new ResponseSummary())}
        }, __Tag,() => new CatalogedReactionSummary(), () => new List<CatalogedReactionSummary>(), () => new Dictionary<string,CatalogedReactionSummary>(),CatalogedReaction._binding);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = _binding.Properties;

	///<summary>Dictionary describing the serializable properties.</summary> 
	public readonly static new Dictionary<string, Property> _StaticAllProperties =
			Combine(CatalogedReaction._binding, _binding);


    ///<inheritdoc/>
	public override Dictionary<string, Property> _AllProperties => _StaticAllProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _Properties => _StaticProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _ParentProperties => base._Properties;



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


    /// <summary>
    /// Deserialize a tagged stream
    /// </summary>
    /// <param name="jsonReader">The input stream</param>
	/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
    /// <returns>The created object.</returns>		
    public static new CatalogedReactionSummary FromJson (JsonReader jsonReader, bool tagged=true) {
		if (jsonReader == null) {
			return null;
			}
		if (tagged) {
			var Out = jsonReader.ReadTaggedObject (_TagDictionary);
			return Out as CatalogedReactionSummary;
			}
		var Result = new CatalogedReactionSummary ();
		Result.Deserialize (jsonReader);
		Result.PostDecode();
		return Result;
		}


	}


	/// <summary>
	/// </summary>
public partial class ResponseSummary : ForumItem {
        /// <summary>
        ///The response semantic.
        /// </summary>

	[JsonPropertyName("Semantic")]
	public virtual string?					Semantic  {get; set;}

        /// <summary>
        ///The count of the response summary
        /// </summary>

	[JsonPropertyName("Count")]
	public virtual int?					Count  {get; set;}

        /// <summary>
        ///The members who made this response
        /// </summary>

	[JsonPropertyName("MemberIds")]
	public virtual List<string>?					MemberIds  {get; set;}


    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<ResponseSummary> _binding = new (
			new() {

			{ "Semantic", new PropertyString ("Semantic", 
					(IBinding data, string? value) => {(data as ResponseSummary).Semantic = value;}, (IBinding data) => (data as ResponseSummary).Semantic )},
			{ "Count", new PropertyInteger32 ("Count", 
					(IBinding data, int? value) => {(data as ResponseSummary).Count = value;}, (IBinding data) => (data as ResponseSummary).Count )},
			{ "MemberIds", new PropertyListString ("MemberIds", 
					(IBinding data, List<string>? value) => {(data as ResponseSummary).MemberIds = value;}, (IBinding data) => (data as ResponseSummary).MemberIds )}
        }, __Tag,() => new ResponseSummary(), () => new List<ResponseSummary>(), () => new Dictionary<string,ResponseSummary>(),null);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = _binding.Properties;

	///<summary>Dictionary describing the serializable properties.</summary> 
	public readonly static new Dictionary<string, Property> _StaticAllProperties = _StaticProperties;


    ///<inheritdoc/>
	public override Dictionary<string, Property> _AllProperties => _StaticAllProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _Properties => _StaticProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _ParentProperties => base._Properties;



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


    /// <summary>
    /// Deserialize a tagged stream
    /// </summary>
    /// <param name="jsonReader">The input stream</param>
	/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
    /// <returns>The created object.</returns>		
    public static new ResponseSummary FromJson (JsonReader jsonReader, bool tagged=true) {
		if (jsonReader == null) {
			return null;
			}
		if (tagged) {
			var Out = jsonReader.ReadTaggedObject (_TagDictionary);
			return Out as ResponseSummary;
			}
		var Result = new ResponseSummary ();
		Result.Deserialize (jsonReader);
		Result.PostDecode();
		return Result;
		}


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
	public virtual string?					Subject  {get; set;}

        /// <summary>
        ///The topic introduction. May span multiple lines
        /// </summary>

	[JsonPropertyName("Text")]
	public virtual string?					Text  {get; set;}



    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedPost> _binding = new (
			new() {

			{ "Subject", new PropertyString ("Subject", 
					(IBinding data, string? value) => {(data as CatalogedPost).Subject = value;}, (IBinding data) => (data as CatalogedPost).Subject )},
			{ "Text", new PropertyString ("Text", 
					(IBinding data, string? value) => {(data as CatalogedPost).Text = value;}, (IBinding data) => (data as CatalogedPost).Text )}
        }, __Tag,() => new CatalogedPost(), () => new List<CatalogedPost>(), () => new Dictionary<string,CatalogedPost>(),CatalogedReaction._binding);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = _binding.Properties;

	///<summary>Dictionary describing the serializable properties.</summary> 
	public readonly static new Dictionary<string, Property> _StaticAllProperties =
			Combine(CatalogedReaction._binding, _binding);


    ///<inheritdoc/>
	public override Dictionary<string, Property> _AllProperties => _StaticAllProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _Properties => _StaticProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _ParentProperties => base._Properties;



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


    /// <summary>
    /// Deserialize a tagged stream
    /// </summary>
    /// <param name="jsonReader">The input stream</param>
	/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
    /// <returns>The created object.</returns>		
    public static new CatalogedPost FromJson (JsonReader jsonReader, bool tagged=true) {
		if (jsonReader == null) {
			return null;
			}
		if (tagged) {
			var Out = jsonReader.ReadTaggedObject (_TagDictionary);
			return Out as CatalogedPost;
			}
		var Result = new CatalogedPost ();
		Result.Deserialize (jsonReader);
		Result.PostDecode();
		return Result;
		}


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
	public virtual string?					Text  {get; set;}



    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedComment> _binding = new (
			new() {

			{ "Text", new PropertyString ("Text", 
					(IBinding data, string? value) => {(data as CatalogedComment).Text = value;}, (IBinding data) => (data as CatalogedComment).Text )}
        }, __Tag,() => new CatalogedComment(), () => new List<CatalogedComment>(), () => new Dictionary<string,CatalogedComment>(),CatalogedReaction._binding);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = _binding.Properties;

	///<summary>Dictionary describing the serializable properties.</summary> 
	public readonly static new Dictionary<string, Property> _StaticAllProperties =
			Combine(CatalogedReaction._binding, _binding);


    ///<inheritdoc/>
	public override Dictionary<string, Property> _AllProperties => _StaticAllProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _Properties => _StaticProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _ParentProperties => base._Properties;



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


    /// <summary>
    /// Deserialize a tagged stream
    /// </summary>
    /// <param name="jsonReader">The input stream</param>
	/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
    /// <returns>The created object.</returns>		
    public static new CatalogedComment FromJson (JsonReader jsonReader, bool tagged=true) {
		if (jsonReader == null) {
			return null;
			}
		if (tagged) {
			var Out = jsonReader.ReadTaggedObject (_TagDictionary);
			return Out as CatalogedComment;
			}
		var Result = new CatalogedComment ();
		Result.Deserialize (jsonReader);
		Result.PostDecode();
		return Result;
		}


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
	public virtual string?					Anchor  {get; set;}

        /// <summary>
        ///
        /// </summary>

	[JsonPropertyName("Text")]
	public virtual string?					Text  {get; set;}

        /// <summary>
        /// </summary>

	[JsonPropertyName("References")]
	public virtual List<string>?					References  {get; set;}


    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedAnnotation> _binding = new (
			new() {

			{ "Anchor", new PropertyString ("Anchor", 
					(IBinding data, string? value) => {(data as CatalogedAnnotation).Anchor = value;}, (IBinding data) => (data as CatalogedAnnotation).Anchor )},
			{ "Text", new PropertyString ("Text", 
					(IBinding data, string? value) => {(data as CatalogedAnnotation).Text = value;}, (IBinding data) => (data as CatalogedAnnotation).Text )},
			{ "References", new PropertyListString ("References", 
					(IBinding data, List<string>? value) => {(data as CatalogedAnnotation).References = value;}, (IBinding data) => (data as CatalogedAnnotation).References )}
        }, __Tag,() => new CatalogedAnnotation(), () => new List<CatalogedAnnotation>(), () => new Dictionary<string,CatalogedAnnotation>(),CatalogedReaction._binding);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = _binding.Properties;

	///<summary>Dictionary describing the serializable properties.</summary> 
	public readonly static new Dictionary<string, Property> _StaticAllProperties =
			Combine(CatalogedReaction._binding, _binding);


    ///<inheritdoc/>
	public override Dictionary<string, Property> _AllProperties => _StaticAllProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _Properties => _StaticProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _ParentProperties => base._Properties;



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


    /// <summary>
    /// Deserialize a tagged stream
    /// </summary>
    /// <param name="jsonReader">The input stream</param>
	/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
    /// <returns>The created object.</returns>		
    public static new CatalogedAnnotation FromJson (JsonReader jsonReader, bool tagged=true) {
		if (jsonReader == null) {
			return null;
			}
		if (tagged) {
			var Out = jsonReader.ReadTaggedObject (_TagDictionary);
			return Out as CatalogedAnnotation;
			}
		var Result = new CatalogedAnnotation ();
		Result.Deserialize (jsonReader);
		Result.PostDecode();
		return Result;
		}


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
	public virtual CatalogedResource?					Resource  {get; set;}

        /// <summary>
        ///
        /// </summary>

	[JsonPropertyName("Responses")]
	public virtual List<CatalogedReaction>?					Responses  {get; set;}


    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<AnnotatedResource> _binding = new (
			new() {

			{ "Resource", new PropertyStruct ("Resource", typeof (CatalogedResource),
					(IBinding data, object? value) => {(data as AnnotatedResource).Resource = value as CatalogedResource;}, (IBinding data) => (data as AnnotatedResource).Resource,
					false, ()=>new  CatalogedResource(), ()=>new CatalogedResource())},
			{ "Responses", new PropertyListStruct ("Responses", typeof (CatalogedReaction),
					(IBinding data, object? value) => {(data as AnnotatedResource).Responses = value as List<CatalogedReaction>;}, (IBinding data) => (data as AnnotatedResource).Responses,
					false, ()=>new  List<CatalogedReaction>(), ()=>new CatalogedReaction())}
        }, __Tag,() => new AnnotatedResource(), () => new List<AnnotatedResource>(), () => new Dictionary<string,AnnotatedResource>(),null);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = _binding.Properties;

	///<summary>Dictionary describing the serializable properties.</summary> 
	public readonly static new Dictionary<string, Property> _StaticAllProperties = _StaticProperties;


    ///<inheritdoc/>
	public override Dictionary<string, Property> _AllProperties => _StaticAllProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _Properties => _StaticProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _ParentProperties => base._Properties;



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


    /// <summary>
    /// Deserialize a tagged stream
    /// </summary>
    /// <param name="jsonReader">The input stream</param>
	/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
    /// <returns>The created object.</returns>		
    public static new AnnotatedResource FromJson (JsonReader jsonReader, bool tagged=true) {
		if (jsonReader == null) {
			return null;
			}
		if (tagged) {
			var Out = jsonReader.ReadTaggedObject (_TagDictionary);
			return Out as AnnotatedResource;
			}
		var Result = new AnnotatedResource ();
		Result.Deserialize (jsonReader);
		Result.PostDecode();
		return Result;
		}


	}


	/// <summary>
	/// </summary>
public partial class Terms : ForumItem {


    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<Terms> _binding = new (
			new() {

        }, __Tag,() => new Terms(), () => new List<Terms>(), () => new Dictionary<string,Terms>(),null);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = _binding.Properties;

	///<summary>Dictionary describing the serializable properties.</summary> 
	public readonly static new Dictionary<string, Property> _StaticAllProperties = _StaticProperties;


    ///<inheritdoc/>
	public override Dictionary<string, Property> _AllProperties => _StaticAllProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _Properties => _StaticProperties;

    ///<inheritdoc/>
    public override Dictionary<string, Property> _ParentProperties => base._Properties;



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


    /// <summary>
    /// Deserialize a tagged stream
    /// </summary>
    /// <param name="jsonReader">The input stream</param>
	/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
    /// <returns>The created object.</returns>		
    public static new Terms FromJson (JsonReader jsonReader, bool tagged=true) {
		if (jsonReader == null) {
			return null;
			}
		if (tagged) {
			var Out = jsonReader.ReadTaggedObject (_TagDictionary);
			return Out as Terms;
			}
		var Result = new Terms ();
		Result.Deserialize (jsonReader);
		Result.PostDecode();
		return Result;
		}


	}



