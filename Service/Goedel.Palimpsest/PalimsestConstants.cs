
//  This file was automatically generated at 12/14/2024 8:07:36 PM
//   
//  Changes to this file may be overwritten without warning
//  
//  Generator:  constant version 3.0.0.1053
//      Goedel Script Version : 0.1   Generated 
//      Goedel Schema Version : 0.1   Generated
//  
//      Copyright : © 2015-2021
//  
//  Build Platform: Win32NT 10.0.22631.0
//  
//  
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

using Goedel.Utilities;

namespace Goedel.Palimpsest ;


///<summary>Cookie labels</summary>
public enum CookieType {
    ///<summary>Undefined type</summary>
    Unknown = -1,
    ///<summary>Authentication session cookie</summary>
    Session    }

///<summary>Store labels</summary>
public enum StoreType {
    ///<summary>Undefined type</summary>
    Unknown = -1,
    ///<summary>Projects catalog</summary>
    Projects,
    ///<summary>Members catalog</summary>
    Members,
    ///<summary>Resources catalog</summary>
    Resources,
    ///<summary>Reaction catalog</summary>
    Reaction    }


///<summary>
///Constants specified in hallambaker-mesh-schema
///</summary>
public static partial class PalimpsestConstants {

    // File: CatalogLabels


    ///<summary>Jose enumeration tag for CookieType.Session</summary>
    public const string  CookieTypeSessionTag = "Session";

    /// <summary>
    /// Convert the string <paramref name="text"/> to the corresponding enumeration
    /// value.
    /// </summary>
    /// <param name="text">The string to convert.</param>
    /// <returns>The enumeration value.</returns>
    public static CookieType ToCookieType (this string text) =>
        text switch {
            CookieTypeSessionTag => CookieType.Session,
            _ => CookieType.Unknown
            };

    /// <summary>
    /// Convert the enumerated value <paramref name="data"/> to the corresponding string
    /// value.
    /// </summary>
    /// <param name="data">The enumerated value.</param>
    /// <returns>The text value.</returns>
    public static string ToLabel (this CookieType data) =>
        data switch {
            CookieType.Session => CookieTypeSessionTag,
            _ => null
            };


    ///<summary>Jose enumeration tag for StoreType.Projects</summary>
    public const string  StoreTypeProjectsTag = "Projects";
    ///<summary>Jose enumeration tag for StoreType.Members</summary>
    public const string  StoreTypeMembersTag = "Members";
    ///<summary>Jose enumeration tag for StoreType.Resources</summary>
    public const string  StoreTypeResourcesTag = "Resources";
    ///<summary>Jose enumeration tag for StoreType.Reaction</summary>
    public const string  StoreTypeReactionTag = "Reaction";

    /// <summary>
    /// Convert the string <paramref name="text"/> to the corresponding enumeration
    /// value.
    /// </summary>
    /// <param name="text">The string to convert.</param>
    /// <returns>The enumeration value.</returns>
    public static StoreType ToStoreType (this string text) =>
        text switch {
            StoreTypeProjectsTag => StoreType.Projects,
            StoreTypeMembersTag => StoreType.Members,
            StoreTypeResourcesTag => StoreType.Resources,
            StoreTypeReactionTag => StoreType.Reaction,
            _ => StoreType.Unknown
            };

    /// <summary>
    /// Convert the enumerated value <paramref name="data"/> to the corresponding string
    /// value.
    /// </summary>
    /// <param name="data">The enumerated value.</param>
    /// <returns>The text value.</returns>
    public static string ToLabel (this StoreType data) =>
        data switch {
            StoreType.Projects => StoreTypeProjectsTag,
            StoreType.Members => StoreTypeMembersTag,
            StoreType.Resources => StoreTypeResourcesTag,
            StoreType.Reaction => StoreTypeReactionTag,
            _ => null
            };

    // File: PagePrefixes

    ///<summary>
    ///</summary>
    public const string resources = "resources";

    ///<summary>
    ///</summary>
    public const string SignIn = "SignIn";

    ///<summary>
    ///</summary>
    public const string SignInPost = "SignInPost";

    ///<summary>
    ///</summary>
    public const string CreateAccount = "CreateAccount";

    ///<summary>
    ///</summary>
    public const string CreateAccountPost = "CreateAccountPost";

    ///<summary>
    ///</summary>
    public const string SignOut = "SignOut";

    ///<summary>
    ///</summary>
    public const string Project = "Project";

    ///<summary>
    ///</summary>
    public const string AddDocument = "AddDocument";

    ///<summary>
    ///</summary>
    public const string AddTopic = "AddTopic";

    ///<summary>
    ///</summary>
    public const string Document = "Document";

    ///<summary>
    ///</summary>
    public const string Topic = "Topic";

    ///<summary>
    ///</summary>
    public const string Post = "Post";

    ///<summary>
    ///</summary>
    public const string User = "User";

    ///<summary>
    ///</summary>
    public const string CreateProject = "CreateProject";

    ///<summary>
    ///</summary>
    public const string CreateProjectPost = "CreateProjectPost";

    ///<summary>
    ///</summary>
    public const string DocumentUpload = "DocumentUpload";

    ///<summary>
    ///</summary>
    public const string TopicCreate = "TopicCreate";

    ///<summary>
    ///</summary>
    public const string Actions = "Actions";

    ///<summary>
    ///</summary>
    public const string Comment = "Comment";

    ///<summary>
    ///</summary>
    public const string CommentPost = "CommentSubmit";

    ///<summary>
    ///</summary>
    public const string CreatePost = "NewPost";

    ///<summary>
    ///</summary>
    public const string PostPost = "NewPostSubmit";

    ///<summary>
    ///</summary>
    public const string CreatePostComment = "PostComment";

    ///<summary>
    ///</summary>
    public const string PostCommentPost = "PostCommentSubmit";

    ///<summary>
    ///</summary>
    public const string WellKnown = ".well-known";

    ///<summary>
    ///</summary>
    public const string ClientMetadata = "client-metadata.json";

    ///<summary>
    ///</summary>
    public const string Redirect = "Redirect";

    // File: ContentTypes

    ///<summary>
    ///</summary>
    public const string ClientMetadataType = "application/json";

    }

