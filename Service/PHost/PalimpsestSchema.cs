﻿
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
//  This file was automatically generated at 10/22/2024 2:59:48 PM
//   
//  Changes to this file may be overwritten without warning
//  
//  Generator:  protogen version 3.0.0.1141
//      Goedel Script Version : 0.1   Generated 
//      Goedel Schema Version : 0.1   Generated
//  
//      Copyright : © 2015-2021
//  
//  Build Platform: Win32NT 10.0.22631.0
//  
//  
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
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
	    {"CatalogedProject", CatalogedProject._Factory},
	    {"CatalogedMember", CatalogedMember._Factory},
	    {"CatalogedResource", CatalogedResource._Factory},
	    {"CatalogedSeries", CatalogedSeries._Factory},
	    {"CatalogedEvent", CatalogedEvent._Factory},
	    {"CatalogedResponse", CatalogedResponse._Factory},
	    {"CatalogedAnnotation", CatalogedAnnotation._Factory}
		};

    [ModuleInitializer]

    internal static void _Initialize() => AddDictionary(ref _tagDictionary);


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

	public virtual DateTime?						Added  {get; set;}

        /// <summary>
        ///Tag value attributes allowing entry description to be extended.
        /// </summary>

	public virtual List<EntryAttibutes>?					Entries  {get; set;}


    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static protected new Binding _binding = new (
			_StaticProperties, __Tag,() => new CatalogedForumEntry(), CatalogedEntry._binding);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = new() {

			{ "Added", new PropertyDateTime ("Added", 
					(IBinding data, DateTime? value) => {(data as CatalogedForumEntry).Added = value;}, (IBinding data) => (data as CatalogedForumEntry).Added )},
			{ "Entries", new PropertyListStruct ("Entries", 
					(IBinding data, object? value) => {(data as CatalogedForumEntry).Entries = value as List<EntryAttibutes>;}, (IBinding data) => (data as CatalogedForumEntry).Entries,
					false, ()=>new  List<EntryAttibutes>(), ()=>new EntryAttibutes())} 
        };

	///<summary>Dictionary describing the serializable properties.</summary> 
	public readonly static new Dictionary<string, Property> _StaticAllProperties =
			Combine(_StaticProperties, CatalogedEntry._StaticAllProperties);


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

	public virtual string?						Tag  {get; set;}

        /// <summary>
        ///The attribute value
        /// </summary>

	public virtual string?						Value  {get; set;}



    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static protected new Binding _binding = new (
			_StaticProperties, __Tag,() => new EntryAttibutes(), null);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = new() {

			{ "Tag", new PropertyString ("Tag", 
					(IBinding data, string? value) => {(data as EntryAttibutes).Tag = value;}, (IBinding data) => (data as EntryAttibutes).Tag )},
			{ "Value", new PropertyString ("Value", 
					(IBinding data, string? value) => {(data as EntryAttibutes).Value = value;}, (IBinding data) => (data as EntryAttibutes).Value )}
        };

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
public partial class CatalogedProject : CatalogedForumEntry {
        /// <summary>
        ///The members owwning the peoject
        /// </summary>

	public virtual List<string>?					Owners  {get; set;}


    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static protected new Binding _binding = new (
			_StaticProperties, __Tag,() => new CatalogedProject(), CatalogedForumEntry._binding);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = new() {

			{ "Owners", new PropertyListString ("Owners", 
					(IBinding data, List<string>? value) => {(data as CatalogedProject).Owners = value;}, (IBinding data) => (data as CatalogedProject).Owners )}
        };

	///<summary>Dictionary describing the serializable properties.</summary> 
	public readonly static new Dictionary<string, Property> _StaticAllProperties =
			Combine(_StaticProperties, CatalogedForumEntry._StaticAllProperties);


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
	public new const string __Tag = "CatalogedProject";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new CatalogedProject();


    /// <summary>
    /// Deserialize a tagged stream
    /// </summary>
    /// <param name="jsonReader">The input stream</param>
	/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
    /// <returns>The created object.</returns>		
    public static new CatalogedProject FromJson (JsonReader jsonReader, bool tagged=true) {
		if (jsonReader == null) {
			return null;
			}
		if (tagged) {
			var Out = jsonReader.ReadTaggedObject (_TagDictionary);
			return Out as CatalogedProject;
			}
		var Result = new CatalogedProject ();
		Result.Deserialize (jsonReader);
		Result.PostDecode();
		return Result;
		}


	}

	/// <summary>
	///
	/// 
	/// </summary>
public partial class CatalogedMember : CatalogedForumEntry {
        /// <summary>
        ///The user's fingerprint profile (if known).
        /// </summary>

	public virtual string?						ProfileUdf  {get; set;}

        /// <summary>
        ///The user's Mesh contact (if provided). 
        /// </summary>

	public virtual byte[]?						Contact  {get; set;}

        /// <summary>
        ///The member's status: Active / Inactive / Blocked
        /// </summary>

	public virtual string?						Status  {get; set;}

        /// <summary>
        ///Assigned privileges (Admin / Moderator)
        /// </summary>

	public virtual List<string>?					Privileges  {get; set;}


    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static protected new Binding _binding = new (
			_StaticProperties, __Tag,() => new CatalogedMember(), CatalogedForumEntry._binding);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = new() {

			{ "ProfileUdf", new PropertyString ("ProfileUdf", 
					(IBinding data, string? value) => {(data as CatalogedMember).ProfileUdf = value;}, (IBinding data) => (data as CatalogedMember).ProfileUdf )},
			{ "Contact", new PropertyBinary ("Contact", 
					(IBinding data, byte[]? value) => {(data as CatalogedMember).Contact = value;}, (IBinding data) => (data as CatalogedMember).Contact )},
			{ "Status", new PropertyString ("Status", 
					(IBinding data, string? value) => {(data as CatalogedMember).Status = value;}, (IBinding data) => (data as CatalogedMember).Status )},
			{ "Privileges", new PropertyListString ("Privileges", 
					(IBinding data, List<string>? value) => {(data as CatalogedMember).Privileges = value;}, (IBinding data) => (data as CatalogedMember).Privileges )}
        };

	///<summary>Dictionary describing the serializable properties.</summary> 
	public readonly static new Dictionary<string, Property> _StaticAllProperties =
			Combine(_StaticProperties, CatalogedForumEntry._StaticAllProperties);


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
	public new const string __Tag = "CatalogedMember";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new CatalogedMember();


    /// <summary>
    /// Deserialize a tagged stream
    /// </summary>
    /// <param name="jsonReader">The input stream</param>
	/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
    /// <returns>The created object.</returns>		
    public static new CatalogedMember FromJson (JsonReader jsonReader, bool tagged=true) {
		if (jsonReader == null) {
			return null;
			}
		if (tagged) {
			var Out = jsonReader.ReadTaggedObject (_TagDictionary);
			return Out as CatalogedMember;
			}
		var Result = new CatalogedMember ();
		Result.Deserialize (jsonReader);
		Result.PostDecode();
		return Result;
		}


	}

	/// <summary>
	///
	/// A cataloged resource. This may be a document, an image, etc.
	/// </summary>
public partial class CatalogedResource : CatalogedForumEntry {
        /// <summary>
        ///The series identifier, if this item is a part of a versioned series.
        /// </summary>

	public virtual string?						SeriesId  {get; set;}

        /// <summary>
        ///The version indicator. This SHOULD be unique among resources with the
        ///same series identifier.
        /// </summary>

	public virtual string?						Version  {get; set;}



    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static protected new Binding _binding = new (
			_StaticProperties, __Tag,() => new CatalogedResource(), CatalogedForumEntry._binding);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = new() {

			{ "SeriesId", new PropertyString ("SeriesId", 
					(IBinding data, string? value) => {(data as CatalogedResource).SeriesId = value;}, (IBinding data) => (data as CatalogedResource).SeriesId )},
			{ "Version", new PropertyString ("Version", 
					(IBinding data, string? value) => {(data as CatalogedResource).Version = value;}, (IBinding data) => (data as CatalogedResource).Version )}
        };

	///<summary>Dictionary describing the serializable properties.</summary> 
	public readonly static new Dictionary<string, Property> _StaticAllProperties =
			Combine(_StaticProperties, CatalogedForumEntry._StaticAllProperties);


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
	/// Collects a group of related resources together into a series.
	/// </summary>
public partial class CatalogedSeries : CatalogedResource {


    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static protected new Binding _binding = new (
			_StaticProperties, __Tag,() => new CatalogedSeries(), CatalogedResource._binding);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = new() {

        };

	///<summary>Dictionary describing the serializable properties.</summary> 
	public readonly static new Dictionary<string, Property> _StaticAllProperties =
			Combine(_StaticProperties, CatalogedResource._StaticAllProperties);


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

	public virtual string?						Venue  {get; set;}

        /// <summary>
        ///Start date for the event
        /// </summary>

	public virtual DateTime?						Start  {get; set;}

        /// <summary>
        ///End date for the event
        /// </summary>

	public virtual DateTime?						Finish  {get; set;}

        /// <summary>
        ///Physical location for the event
        /// </summary>

	public virtual string?						PhysicalLocation  {get; set;}

        /// <summary>
        ///Online resource for the event
        /// </summary>

	public virtual string?						Online  {get; set;}

        /// <summary>
        ///The members organizing the event
        /// </summary>

	public virtual List<string>?					Organizers  {get; set;}


    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static protected new Binding _binding = new (
			_StaticProperties, __Tag,() => new CatalogedEvent(), CatalogedResource._binding);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = new() {

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
        };

	///<summary>Dictionary describing the serializable properties.</summary> 
	public readonly static new Dictionary<string, Property> _StaticAllProperties =
			Combine(_StaticProperties, CatalogedResource._StaticAllProperties);


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
public partial class CatalogedResponse : CatalogedForumEntry {
        /// <summary>
        ///The forum entry being responded to.
        /// </summary>

	public virtual string?						ForumEntryId  {get; set;}

        /// <summary>
        ///The identifier of the member responding.
        /// </summary>

	public virtual string?						MemberId  {get; set;}

        /// <summary>
        ///The response semantic.
        /// </summary>

	public virtual string?						Semantic  {get; set;}



    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static protected new Binding _binding = new (
			_StaticProperties, __Tag,() => new CatalogedResponse(), CatalogedForumEntry._binding);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = new() {

			{ "ForumEntryId", new PropertyString ("ForumEntryId", 
					(IBinding data, string? value) => {(data as CatalogedResponse).ForumEntryId = value;}, (IBinding data) => (data as CatalogedResponse).ForumEntryId )},
			{ "MemberId", new PropertyString ("MemberId", 
					(IBinding data, string? value) => {(data as CatalogedResponse).MemberId = value;}, (IBinding data) => (data as CatalogedResponse).MemberId )},
			{ "Semantic", new PropertyString ("Semantic", 
					(IBinding data, string? value) => {(data as CatalogedResponse).Semantic = value;}, (IBinding data) => (data as CatalogedResponse).Semantic )}
        };

	///<summary>Dictionary describing the serializable properties.</summary> 
	public readonly static new Dictionary<string, Property> _StaticAllProperties =
			Combine(_StaticProperties, CatalogedForumEntry._StaticAllProperties);


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
	public new const string __Tag = "CatalogedResponse";

	/// <summary>
    /// Factory method
    /// </summary>
    /// <returns>Object of this type</returns>
	public static new JsonObject _Factory () => new CatalogedResponse();


    /// <summary>
    /// Deserialize a tagged stream
    /// </summary>
    /// <param name="jsonReader">The input stream</param>
	/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
    /// <returns>The created object.</returns>		
    public static new CatalogedResponse FromJson (JsonReader jsonReader, bool tagged=true) {
		if (jsonReader == null) {
			return null;
			}
		if (tagged) {
			var Out = jsonReader.ReadTaggedObject (_TagDictionary);
			return Out as CatalogedResponse;
			}
		var Result = new CatalogedResponse ();
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
public partial class CatalogedAnnotation : CatalogedResponse {
        /// <summary>
        ///
        /// </summary>

	public virtual string?						Anchor  {get; set;}

        /// <summary>
        ///
        /// </summary>

	public virtual string?						Text  {get; set;}

        /// <summary>
        /// </summary>

	public virtual List<string>?					References  {get; set;}


    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	static protected new Binding _binding = new (
			_StaticProperties, __Tag,() => new CatalogedAnnotation(), CatalogedResponse._binding);

    ///<summary>Dictionary describing the serializable properties.</summary> 
    public readonly static new Dictionary<string, Property> _StaticProperties = new() {

			{ "Anchor", new PropertyString ("Anchor", 
					(IBinding data, string? value) => {(data as CatalogedAnnotation).Anchor = value;}, (IBinding data) => (data as CatalogedAnnotation).Anchor )},
			{ "Text", new PropertyString ("Text", 
					(IBinding data, string? value) => {(data as CatalogedAnnotation).Text = value;}, (IBinding data) => (data as CatalogedAnnotation).Text )},
			{ "References", new PropertyListString ("References", 
					(IBinding data, List<string>? value) => {(data as CatalogedAnnotation).References = value;}, (IBinding data) => (data as CatalogedAnnotation).References )}
        };

	///<summary>Dictionary describing the serializable properties.</summary> 
	public readonly static new Dictionary<string, Property> _StaticAllProperties =
			Combine(_StaticProperties, CatalogedResponse._StaticAllProperties);


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


