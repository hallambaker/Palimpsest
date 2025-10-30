
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
//  This file was automatically generated at 10/30/2025 2:55:37 PM
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
	    {typeof(CatalogedPlace), CatalogedPlace._binding},
	    {typeof(CatalogedForumMember), CatalogedForumMember._binding}
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
					(data, value) => {(data as CatalogedPlace).ParentForum = value;}, 
					data => (data as CatalogedPlace).ParentForum ),
		new PropertyListString ("Aliases", 
					(data, value) => {(data as CatalogedPlace).Aliases = value;}, 
					data => (data as CatalogedPlace).Aliases ),
		new PropertyListString ("Owners", 
					(data, value) => {(data as CatalogedPlace).Owners = value;}, 
					data => (data as CatalogedPlace).Owners )
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
    ///The user's handle.
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

    ///<summary>Implement IBinding</summary> 
	public override Property[] _Properties => _properties;

	///<summary>Binding</summary> 
	static readonly Property[] _properties = [
		new PropertyString ("Did", 
					(data, value) => {(data as CatalogedForumMember).Did = value;}, 
					data => (data as CatalogedForumMember).Did ),
		new PropertyString ("Handle", 
					(data, value) => {(data as CatalogedForumMember).Handle = value;}, 
					data => (data as CatalogedForumMember).Handle ),
		new PropertyString ("Avatar", 
					(data, value) => {(data as CatalogedForumMember).Avatar = value;}, 
					data => (data as CatalogedForumMember).Avatar ),
		new PropertyString ("Banner", 
					(data, value) => {(data as CatalogedForumMember).Banner = value;}, 
					data => (data as CatalogedForumMember).Banner ),
		new PropertyString ("Status", 
					(data, value) => {(data as CatalogedForumMember).Status = value;}, 
					data => (data as CatalogedForumMember).Status ),
		new PropertyListString ("Privileges", 
					(data, value) => {(data as CatalogedForumMember).Privileges = value;}, 
					data => (data as CatalogedForumMember).Privileges )
		];

    ///<summary>Implement IBinding</summary> 
	public override Binding _Binding => _binding;

	///<summary>Binding</summary> 
	public static readonly new Binding<CatalogedForumMember> _binding = new (
			new() {
			{ "Did", _properties [0]},
			{ "Handle", _properties [1]},
			{ "Avatar", _properties [2]},
			{ "Banner", _properties [3]},
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



