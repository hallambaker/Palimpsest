﻿
//  This file was automatically generated at 10/24/2024 1:51:19 PM
//   
//  Changes to this file may be overwritten without warning
//  
//  Generator:  exceptional version 3.0.0.966
//      Goedel Script Version : 0.1   Generated 
//      Goedel Schema Version : 0.1   Generated
//  
//      Copyright : © 2015-2022
//  
//  Build Platform: Win32NT 10.0.22631.0
//  
//  

//using System;
//using Goedel.Utilities;



#pragma warning disable IDE0079
#pragma warning disable IDE1006 // Naming Styles
namespace Goedel.Palimpsest ;


/// <summary>
/// An internal assertion check failed.
/// </summary>
[global::System.Serializable]
public partial class Internal : global::Goedel.Utilities.GoedelException {

    ///<summary>The exception formatting delegate. May be overriden 
	///locally or globally to implement different exception formatting.</summary>
	public static new global::Goedel.Utilities.ExceptionFormatDelegate ExceptionFormatDelegate { get; set; } =
			global::Goedel.Utilities.GoedelException.ExceptionFormatDelegate;


	///<summary>Templates for formatting response messages.</summary>
	public static new System.Collections.Generic.List<string> Templates {get; set;} = 
			new () {

			"An internal error occurred"
			};

	/// <summary>
	/// Construct instance for exception
	/// </summary>		
	/// <param name="description">Description of the error, may be used to override the 
	/// generated message.</param>	
	/// <param name="inner">Inner Exception</param>	
	/// <param name="args">Optional list of parameterized arguments.</param>
	public Internal  (string description=null, System.Exception inner=null,
		params object[] args) : 
			base (ExceptionFormatDelegate(description, Templates,
				null, args), inner) {
		}





	/// <summary>
    /// The public fatory delegate
    /// </summary>
    /// public static global::Goedel.Utilities.ThrowNewDelegate ThrowNew = _Throw;

    static System.Exception _Throw(object reasons) => new Internal(args:reasons) ;
		
	/// <summary>
    /// The public fatory delegate
    /// </summary>
    public static global::Goedel.Utilities.ThrowDelegate Throw {get;} = _Throw;


    }


/// <summary>
/// The item already exists
/// </summary>
[global::System.Serializable]
public partial class ItemAlreadyExists : global::Goedel.Utilities.GoedelException {

    ///<summary>The exception formatting delegate. May be overriden 
	///locally or globally to implement different exception formatting.</summary>
	public static new global::Goedel.Utilities.ExceptionFormatDelegate ExceptionFormatDelegate { get; set; } =
			global::Goedel.Utilities.GoedelException.ExceptionFormatDelegate;


	///<summary>Templates for formatting response messages.</summary>
	public static new System.Collections.Generic.List<string> Templates {get; set;} = 
			new () {

			"The item {0} already exists"
			};

	/// <summary>
	/// Construct instance for exception
	/// </summary>		
	/// <param name="description">Description of the error, may be used to override the 
	/// generated message.</param>	
	/// <param name="inner">Inner Exception</param>	
	/// <param name="args">Optional list of parameterized arguments.</param>
	public ItemAlreadyExists  (string description=null, System.Exception inner=null,
		params object[] args) : 
			base (ExceptionFormatDelegate(description, Templates,
				null, args), inner) {
		}





	/// <summary>
    /// The public fatory delegate
    /// </summary>
    /// public static global::Goedel.Utilities.ThrowNewDelegate ThrowNew = _Throw;

    static System.Exception _Throw(object reasons) => new ItemAlreadyExists(args:reasons) ;
		
	/// <summary>
    /// The public fatory delegate
    /// </summary>
    public static global::Goedel.Utilities.ThrowDelegate Throw {get;} = _Throw;


    }


/// <summary>
/// The item does not exist
/// </summary>
[global::System.Serializable]
public partial class ItemDoesNotExist : global::Goedel.Utilities.GoedelException {

    ///<summary>The exception formatting delegate. May be overriden 
	///locally or globally to implement different exception formatting.</summary>
	public static new global::Goedel.Utilities.ExceptionFormatDelegate ExceptionFormatDelegate { get; set; } =
			global::Goedel.Utilities.GoedelException.ExceptionFormatDelegate;


	///<summary>Templates for formatting response messages.</summary>
	public static new System.Collections.Generic.List<string> Templates {get; set;} = 
			new () {

			"The item {0} does not exist"
			};

	/// <summary>
	/// Construct instance for exception
	/// </summary>		
	/// <param name="description">Description of the error, may be used to override the 
	/// generated message.</param>	
	/// <param name="inner">Inner Exception</param>	
	/// <param name="args">Optional list of parameterized arguments.</param>
	public ItemDoesNotExist  (string description=null, System.Exception inner=null,
		params object[] args) : 
			base (ExceptionFormatDelegate(description, Templates,
				null, args), inner) {
		}





	/// <summary>
    /// The public fatory delegate
    /// </summary>
    /// public static global::Goedel.Utilities.ThrowNewDelegate ThrowNew = _Throw;

    static System.Exception _Throw(object reasons) => new ItemDoesNotExist(args:reasons) ;
		
	/// <summary>
    /// The public fatory delegate
    /// </summary>
    public static global::Goedel.Utilities.ThrowDelegate Throw {get;} = _Throw;


    }


/// <summary>
/// Extensions class defining logging events and convenience methods.
/// </summary>
public  static partial class EventExtensions {

    /// <summary>
    /// Static initializer, is called once when the module loads.
    /// </summary>
    static EventExtensions() {
        }

	}



