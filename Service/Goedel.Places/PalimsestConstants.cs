
//  This file was automatically generated at 3/18/2026 4:00:12 PM
//   
//  Changes to this file may be overwritten without warning
//  
//  Generator:  constant version 3.0.0.1173
//      Goedel Script Version : 0.1   Generated 
//      Goedel Schema Version : 0.1   Generated
//  
//      Copyright : © 2015-2021
//  
//  Build Platform: Win32NT 10.0.26200.0
//  
//  
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

using Goedel.Utilities;

namespace Goedel.Places ;


///<summary>Cookie labels</summary>
public enum CookieType {
    ///<summary>Undefined type</summary>
    Unknown = -1,
    ///<summary>Authentication session cookie</summary>
    Session,
    ///<summary>Temporary authentication session cookie</summary>
    Temporary
    }

///<summary>Store labels</summary>
public enum StoreType {
    ///<summary>Undefined type</summary>
    Unknown = -1,
    ///<summary>Places catalog</summary>
    Places,
    ///<summary>Members catalog</summary>
    Members
    }

///<summary>Limits</summary>
[Flags]
public enum Limit {
    ///<summary>Undefined type</summary>
    Unknown = -1,
    ///<summary>Request size in bytes</summary>
    RequestSize = 0x0001,
    ///<summary>Posts per hour</summary>
    PostsPerHour = 0x0002,
    ///<summary>Post size in bytes</summary>
    PostSize = 0x0004,
    ///<summary>Comment size in characters</summary>
    CommentSize = 0x0008,
    ///<summary>User storage in bytes</summary>
    UserStorage = 0x0010
    }

///<summary>Privileges</summary>
[Flags]
public enum Privilege {
    ///<summary>Undefined type</summary>
    Unknown = -1,
    ///<summary>Create new places</summary>
    CreatePlace = 0x0001,
    ///<summary>Create new feed</summary>
    CreateFeed = 0x0002,
    ///<summary>Create post</summary>
    CreatePost = 0x0004,
    ///<summary>Create comment</summary>
    CreateComment = 0x0008,
    ///<summary>Create new places</summary>
    ReadPlace = 0x0010,
    ///<summary>Create new feed</summary>
    ReadFeed = 0x0020,
    ///<summary>Create post</summary>
    ReadPost = 0x0040,
    ///<summary>Create comment</summary>
    ReadComment = 0x0080,
    ///<summary>Delete feed</summary>
    DeletePlace = 0x0100,
    ///<summary>Delete feed</summary>
    DeleteFeed = 0x0200,
    ///<summary>Delete post</summary>
    DeletePost = 0x0400,
    ///<summary>Delete comment</summary>
    DeleteComment = 0x0800,
    ///<summary>Create new places</summary>
    GrantAdministrator = 0x8000,
    ///<summary>Create new places</summary>
    GrantModerator = 0x10000,
    ///<summary>Create new places</summary>
    GrantAuthor = 0x20000,
    ///<summary>Create new places</summary>
    GrantCommentator = 0x40000,
    ///<summary>Suspend member</summary>
    Suspend = 0x80000,
    ///<summary>Ban member</summary>
    Ban = 0x100000,
    ///<summary>Read User page</summary>
    ReadSite = 0x200000,
    ///<summary>Read User page</summary>
    ReadUser = 0x400000,
    ///<summary>Read User page</summary>
    EditUser = 0x800000,

    ///<summary>Set member status</summary>
    Status = 0x40000000
    }


///<summary>
///Constants specified in hallambaker-mesh-schema
///</summary>
public static partial class PalimpsestConstants {

    // File: CatalogLabels


    ///<summary>Jose enumeration tag for CookieType.Session</summary>
    public const string  CookieTypeSessionTag = "Session";
    ///<summary>Jose enumeration tag for CookieType.Temporary</summary>
    public const string  CookieTypeTemporaryTag = "Temporary";

    /// <summary>
    /// Convert the string <paramref name="text"/> to the corresponding enumeration
    /// value.
    /// </summary>
    /// <param name="text">The string to convert.</param>
    /// <returns>The enumeration value.</returns>
    public static CookieType ToCookieType (this string text) =>
        text switch {
            CookieTypeSessionTag => CookieType.Session,
            CookieTypeTemporaryTag => CookieType.Temporary,
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
            CookieType.Temporary => CookieTypeTemporaryTag,
            _ => null
            };


    ///<summary>Jose enumeration tag for StoreType.Places</summary>
    public const string  StoreTypePlacesTag = "Places";
    ///<summary>Jose enumeration tag for StoreType.Members</summary>
    public const string  StoreTypeMembersTag = "Members";

    /// <summary>
    /// Convert the string <paramref name="text"/> to the corresponding enumeration
    /// value.
    /// </summary>
    /// <param name="text">The string to convert.</param>
    /// <returns>The enumeration value.</returns>
    public static StoreType ToStoreType (this string text) =>
        text switch {
            StoreTypePlacesTag => StoreType.Places,
            StoreTypeMembersTag => StoreType.Members,
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
            StoreType.Places => StoreTypePlacesTag,
            StoreType.Members => StoreTypeMembersTag,
            _ => null
            };

    // File: PagePrefixes

    ///<summary>
    ///</summary>
    public const string resources = "resources";

    ///<summary>
    ///</summary>
    public const string ForumTermsConditions = "ForumTermsConditions";

    ///<summary>
    ///</summary>
    public const string ForumPlaceSignIn = "ForumPlaceSignIn";

    ///<summary>
    ///</summary>
    public const string AcceptTerms = "AcceptTerms";

    ///<summary>
    ///</summary>
    public const string SignIn = "SignIn";

    ///<summary>
    ///</summary>
    public const string SignInComplete = "Complete";

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
    public const string Place = "Place";

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
    public const string User = "Visitor";

    ///<summary>
    ///</summary>
    public const string CreatePlace = "CreatePlace";

    ///<summary>
    ///</summary>
    public const string CreatePlacePost = "CreatePlacePost";

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

    ///<summary>
    ///</summary>
    public const string Terms = "Terms";

    // File: Directories

    ///<summary>
    ///</summary>
    public const string ContentRepository = "Repository";

    // File: ContentTypes

    ///<summary>
    ///</summary>
    public const string ImagePng = "image/png";

    ///<summary>
    ///</summary>
    public const string ImageGif = "image/gif";

    ///<summary>
    ///</summary>
    public const string ImageJpeg = "image/jpeg";

    ///<summary>
    ///</summary>
    public const string ExtensionPng = "png";

    ///<summary>
    ///</summary>
    public const string ExtensionGif = "gif";

    ///<summary>
    ///</summary>
    public const string ExtensionJpeg = "jpeg";

    ///<summary>
    ///</summary>
    public const string ClientMetadataType = "application/json";

    ///<summary>
    ///</summary>
    public const string DefaultBanner = "Mplace2Banner.png";

    ///<summary>
    ///</summary>
    public const string DefaultAvatar = "avatar.png";

    // File: Configuration


    ///<summary>Jose enumeration tag for Limit.RequestSize</summary>
    public const string  LimitRequestSizeTag = "RequestSize";
    ///<summary>Jose enumeration tag for Limit.PostsPerHour</summary>
    public const string  LimitPostsPerHourTag = "PostsPerHour";
    ///<summary>Jose enumeration tag for Limit.PostSize</summary>
    public const string  LimitPostSizeTag = "PostSize";
    ///<summary>Jose enumeration tag for Limit.CommentSize</summary>
    public const string  LimitCommentSizeTag = "CommentSize";
    ///<summary>Jose enumeration tag for Limit.UserStorage</summary>
    public const string  LimitUserStorageTag = "UserStorage";

    /// <summary>
    /// Convert the string <paramref name="text"/> to the corresponding enumeration
    /// value.
    /// </summary>
    /// <param name="text">The string to convert.</param>
    /// <returns>The enumeration value.</returns>
    public static Limit ToLimit (this string text) =>
        text switch {
            LimitRequestSizeTag => Limit.RequestSize,
            LimitPostsPerHourTag => Limit.PostsPerHour,
            LimitPostSizeTag => Limit.PostSize,
            LimitCommentSizeTag => Limit.CommentSize,
            LimitUserStorageTag => Limit.UserStorage,
            _ => Limit.Unknown
            };

    /// <summary>
    /// Convert the enumerated value <paramref name="data"/> to the corresponding string
    /// value.
    /// </summary>
    /// <param name="data">The enumerated value.</param>
    /// <returns>The text value.</returns>
    public static string ToLabel (this Limit data) =>
        data switch {
            Limit.RequestSize => LimitRequestSizeTag,
            Limit.PostsPerHour => LimitPostsPerHourTag,
            Limit.PostSize => LimitPostSizeTag,
            Limit.CommentSize => LimitCommentSizeTag,
            Limit.UserStorage => LimitUserStorageTag,
            _ => null
            };


    ///<summary>Jose enumeration tag for Privilege.CreatePlace</summary>
    public const string  PrivilegeCreatePlaceTag = "CreatePlace";
    ///<summary>Jose enumeration tag for Privilege.CreateFeed</summary>
    public const string  PrivilegeCreateFeedTag = "CreateFeed";
    ///<summary>Jose enumeration tag for Privilege.CreatePost</summary>
    public const string  PrivilegeCreatePostTag = "CreatePost";
    ///<summary>Jose enumeration tag for Privilege.CreateComment</summary>
    public const string  PrivilegeCreateCommentTag = "CreateComment";
    ///<summary>Jose enumeration tag for Privilege.ReadPlace</summary>
    public const string  PrivilegeReadPlaceTag = "ReadPlace";
    ///<summary>Jose enumeration tag for Privilege.ReedFeed</summary>
    public const string  PrivilegeReedFeedTag = "ReedFeed";
    ///<summary>Jose enumeration tag for Privilege.ReadPost</summary>
    public const string  PrivilegeReadPostTag = "ReadPost";
    ///<summary>Jose enumeration tag for Privilege.ReadComment</summary>
    public const string  PrivilegeReadCommentTag = "ReadComment";
    ///<summary>Jose enumeration tag for Privilege.DeletePlace</summary>
    public const string  PrivilegeDeletePlaceTag = "DeletePlace";
    ///<summary>Jose enumeration tag for Privilege.DeleteFeed</summary>
    public const string  PrivilegeDeleteFeedTag = "DeleteFeed";
    ///<summary>Jose enumeration tag for Privilege.DeletePost</summary>
    public const string  PrivilegeDeletePostTag = "DeletePost";
    ///<summary>Jose enumeration tag for Privilege.DeleteComment</summary>
    public const string  PrivilegeDeleteCommentTag = "DeleteComment";
    ///<summary>Jose enumeration tag for Privilege.GrantAdministrator</summary>
    public const string  PrivilegeGrantAdministratorTag = "GrantAdministrator";
    ///<summary>Jose enumeration tag for Privilege.GrantModerator</summary>
    public const string  PrivilegeGrantModeratorTag = "GrantModerator";
    ///<summary>Jose enumeration tag for Privilege.GrantAuthor</summary>
    public const string  PrivilegeGrantAuthorTag = "GrantAuthor";
    ///<summary>Jose enumeration tag for Privilege.GrantCommentator</summary>
    public const string  PrivilegeGrantCommentatorTag = "GrantCommentator";
    ///<summary>Jose enumeration tag for Privilege.Suspend</summary>
    public const string  PrivilegeSuspendTag = "Suspend";
    ///<summary>Jose enumeration tag for Privilege.Ban</summary>
    public const string  PrivilegeBanTag = "Ban";
    ///<summary>Jose enumeration tag for Privilege.Status</summary>
    public const string  PrivilegeStatusTag = "Status";

    /// <summary>
    /// Convert the string <paramref name="text"/> to the corresponding enumeration
    /// value.
    /// </summary>
    /// <param name="text">The string to convert.</param>
    /// <returns>The enumeration value.</returns>
    public static Privilege ToPrivilege (this string text) =>
        text switch {
            PrivilegeCreatePlaceTag => Privilege.CreatePlace,
            PrivilegeCreateFeedTag => Privilege.CreateFeed,
            PrivilegeCreatePostTag => Privilege.CreatePost,
            PrivilegeCreateCommentTag => Privilege.CreateComment,
            PrivilegeReadPlaceTag => Privilege.ReadPlace,
            PrivilegeReedFeedTag => Privilege.ReadFeed,
            PrivilegeReadPostTag => Privilege.ReadPost,
            PrivilegeReadCommentTag => Privilege.ReadComment,
            PrivilegeDeletePlaceTag => Privilege.DeletePlace,
            PrivilegeDeleteFeedTag => Privilege.DeleteFeed,
            PrivilegeDeletePostTag => Privilege.DeletePost,
            PrivilegeDeleteCommentTag => Privilege.DeleteComment,
            PrivilegeGrantAdministratorTag => Privilege.GrantAdministrator,
            PrivilegeGrantModeratorTag => Privilege.GrantModerator,
            PrivilegeGrantAuthorTag => Privilege.GrantAuthor,
            PrivilegeGrantCommentatorTag => Privilege.GrantCommentator,
            PrivilegeSuspendTag => Privilege.Suspend,
            PrivilegeBanTag => Privilege.Ban,
            PrivilegeStatusTag => Privilege.Status,
            _ => Privilege.Unknown
            };

    /// <summary>
    /// Convert the enumerated value <paramref name="data"/> to the corresponding string
    /// value.
    /// </summary>
    /// <param name="data">The enumerated value.</param>
    /// <returns>The text value.</returns>
    public static string ToLabel (this Privilege data) =>
        data switch {
            Privilege.CreatePlace => PrivilegeCreatePlaceTag,
            Privilege.CreateFeed => PrivilegeCreateFeedTag,
            Privilege.CreatePost => PrivilegeCreatePostTag,
            Privilege.CreateComment => PrivilegeCreateCommentTag,
            Privilege.ReadPlace => PrivilegeReadPlaceTag,
            Privilege.ReadFeed => PrivilegeReedFeedTag,
            Privilege.ReadPost => PrivilegeReadPostTag,
            Privilege.ReadComment => PrivilegeReadCommentTag,
            Privilege.DeletePlace => PrivilegeDeletePlaceTag,
            Privilege.DeleteFeed => PrivilegeDeleteFeedTag,
            Privilege.DeletePost => PrivilegeDeletePostTag,
            Privilege.DeleteComment => PrivilegeDeleteCommentTag,
            Privilege.GrantAdministrator => PrivilegeGrantAdministratorTag,
            Privilege.GrantModerator => PrivilegeGrantModeratorTag,
            Privilege.GrantAuthor => PrivilegeGrantAuthorTag,
            Privilege.GrantCommentator => PrivilegeGrantCommentatorTag,
            Privilege.Suspend => PrivilegeSuspendTag,
            Privilege.Ban => PrivilegeBanTag,
            Privilege.Status => PrivilegeStatusTag,
            _ => null
            };

    }

