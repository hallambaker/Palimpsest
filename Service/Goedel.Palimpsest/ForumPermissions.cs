#region // Copyright - MIT License
//  © 2021 by Phill Hallam-Baker
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
#endregion


namespace Goedel.Palimpsest;

/// <summary>
/// Forum permissions
/// </summary>
[Flags]
public enum ForumPermissions {
    ///<summary>User has no permissions.</summary> 
    None = 0,

    ///<summary>Read a post.</summary> 
    Read = 0x1,

    ///<summary>Create a post.</summary> 
    Post = 0x2,

    ///<summary>Start a topic.</summary> 
    CreateTopic = 0x4,

    ///<summary>Create a group.</summary> 
    CreateGroup = 0x8,

    ///<summary>Upload a document, image or video (if quota is sufficient)</summary> 
    UploadResource = 0x10,



    ///<summary>Delete a post created by any user.</summary> 
    DeletePost = 0x20,

    ///<summary>Delete a topic created by any user.</summary> 
    DeleteTopic = 0x40,

    ///<summary>Delete a group.</summary> 
    DeleteGroup = 0x80,

    ///<summary>Delete an uploaded resource.</summary> 
    DeleteResource = 0x100,


    ///<summary>Suspend user temporarily.</summary> 
    SuspendUser = 0x200,

    ///<summary>Block user permanently.</summary> 
    BootUser = 0x400,


    ///<summary>Host administrator, can view current server status.</summary> 
    Host = 0x1000,




    ///<summary>Default user, can read and post and start topics.</summary> 
    User = Read | Post | CreateTopic,


    ///<summary>Moderator has user permissions and can delete other users 
    ///posts or suspend users.</summary> 
    Moderator = User | DeletePost | DeleteTopic| SuspendUser,


    ///<summary>Administrator can create and delete groups, ban users</summary> 
    Administrator = Moderator | CreateGroup | DeleteGroup | BootUser,


    ///<summary>System adfmin has all privileges</summary> 
    System = 0xFFFF,


    ///<summary>Blocked user has no privileges.</summary> 
    Blocked = None

    }



