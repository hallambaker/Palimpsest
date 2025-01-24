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
/// Cached handle for a forum member
/// </summary>
/// <param name="member">The member catalog entry</param>
public class MemberHandle : CachedHandle<CatalogedForumMember> {

    public string PrimaryKey => CatalogedMember._PrimaryKey;

    public CatalogedForumMember CatalogedMember => CatalogedEntry;


    public ForumPermissions Permissions { get; set; }

    public string PermissionLabel =>
        Permissions switch {
            ForumPermissions.User => "User",
            ForumPermissions.Moderator => "Moderator",
            ForumPermissions.Administrator => "Administrator",
            ForumPermissions.System => "System",
            ForumPermissions.Blocked => "Blocked",
            _ => Permissions.ToString()
            };


    public MemberHandle(
            CatalogedForumMember member) : base(member) {

        if (member.LocalName == "phill.hallambaker.com") {
            Permissions = ForumPermissions.System;
            }
        else {
            Permissions = ForumPermissions.User;
            }
        }


    }

