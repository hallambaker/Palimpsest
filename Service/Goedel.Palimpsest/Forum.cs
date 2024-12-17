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


using DocumentFormat.OpenXml.Spreadsheet;

using System.IO;
using System.Reflection.Metadata;

namespace Goedel.Palimpsest;


/// <summary>
/// The class tracking the status of a forum, all interactions with the forum 
/// take place through this lens
/// </summary>
public class Forum :Disposable {

    // crib https://infisical.com/blog/guide-to-implementing-oauth2


    #region // Properties

    public string Name { get; set; } 




    public string DirectoryPath { get; }
    public string Resources { get; }


    public ServerCookieManager ServerCookieManager { get; } = new();

    CachedProjects CatalogProjects { get; }
    CachedMembers CatalogMembers { get; }
    #endregion
    #region // Disposal

    ///<inheritdoc/>
    protected override void Disposing() {
        base.Disposing();

        CatalogProjects?.Dispose();
        CatalogMembers?.Dispose();

        }

    #endregion
    #region // Constructors and factory methods.

    /// <summary>
    /// Hidden private constructor.
    /// </summary>
    /// <param name="directory"></param>
    Forum(
                string directory, 
                string resources,
                string name) {
        DirectoryPath = directory;
        Resources = resources;
        Name = name;

        CatalogProjects = new (this, directory);
        CatalogMembers= new (this, directory);

        }

    /// <summary>
    /// Factory method returning a newly created forum instance
    /// </summary>
    /// <returns></returns>

    public static Forum Create(
                string directory,
                string resources,
                string name) {

        Directory.CreateDirectory(directory);

        // initialize the project and members catalogs
        var catalogProjects = new CachedProjects(null, directory, create: true);
        var catalogMembers = new CachedMembers(null, directory, create: true);
        catalogProjects.Dispose();
        catalogMembers.Dispose();

        var result =  new Forum(directory, resources, name);
        return result;
        }

    /// <summary>
    /// Factory method returning a forum instance for the specified directory.
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NYI"></exception>
    public static Forum Load(
                string directory,
                string resources,
                string name) {
        var result = new Forum(directory, resources, name);
        return result;
        }


    #endregion
    #region // Methods
    #region // Utility Methods

    public string? MemberIdToName(string userId) {

        if (CatalogMembers.TryGetByUid(userId, out var handle)) {
            return handle.LocalName;
            }
        return "";


        }

    public bool TryGetVerifiedMemberHandle(
                    HttpListenerRequest listenerRequest,
                    out MemberHandle? handle) {
        handle = null;
        if (!ServerCookieManager.TryGetCookie(
            listenerRequest, PalimpsestConstants.CookieTypeSessionTag, out var userID)) {
            return false;
            }

        return CatalogMembers.TryGetByUid(userID, out handle);
        }

    public bool TryGetVerifiedMemberHandle(
                string? userId,
                string? password,
                out MemberHandle? handle) {

        if (!CatalogMembers.TryGetByLocalName(userId, out handle)) {
            return false;
            }

        var verified = handle.CatalogedMember.VerifyPassword(password, userId, Name);

        if (!verified) {
            handle = null;
            return false;
            }


        return true;
        }

    public IEnumerable<CatalogedProject> GetProjectEnumerator() => CatalogProjects.GetProjectEnumerator();


    public IEnumerable<CatalogedForumMember> GetMemberEnumerator() {
        throw new NYI();
        }


    #endregion
    #region // Member Methods


    public MemberHandle GetOrCreateMember(
                    string handle,
                    string did,
                    string? profileUdf=null) {
        if (CatalogMembers.TryGetByLocalName(handle, out var memberHandle)) {
            return memberHandle;
            }
        var cataloged = new CatalogedForumMember() {
            LocalName = handle,
            Did = did,
            ProfileUdf = profileUdf
            };
        return AddMember (cataloged, null);
        }
                


    public MemberHandle AddMember(
                CatalogedForumMember template,
                string? password
                ) {
        template.SetPasswordDigest(password, template.LocalName, Name);

        return CreateMember(template);

        }


    /// <summary>
    /// Create a member with authorizations related to the forum
    /// </summary>
    /// <param name="member">The member to be created.</param>
    /// <exception cref="ItemAlreadyExists">The member could not be created 
    /// because it already exists</exception>
    public MemberHandle CreateMember(
                    CatalogedForumMember member) {
        member.Uid = Udf.Nonce();
        CatalogMembers.Create(member);

        var memberHandle = new MemberHandle(member);
        //memberHandle.AccessCookie = MakeAccessCookie(member);
        return memberHandle;
        }

    /// <summary>
    /// Gets the member associated with the specified key.
    /// </summary>
    /// <param name="id">The key of the value to get.</param>
    /// <param name="member">When this method returns, contains the member identified by
    /// the specified key, if the key is found; otherwise, null. 
    /// This parameter is passed uninitialized.</param>
    /// <returns>true if there is a member identified by
    /// specified key; otherwise, false.</returns>
    public bool TryGetMember(
                    string id,
                    out CatalogedForumMember member) => CatalogMembers.TryGetByUidUncached(id, out member);

    public bool TryGetMemberLocal(
                            string id,
                    out string localname) {
        var result = CatalogMembers.TryGetByUid(id, out var member);
        localname = member?.LocalName;
        return result;
        }


    #endregion

    #region // Project Methods

    /// <summary>
    /// Create a project within the forum
    /// </summary>
    /// <param name="project">The project to be created.</param>
    /// <exception cref="ItemAlreadyExists">The project could not be created 
    /// because it already exists</exception>
    public ProjectHandle CreateProject(
                    CatalogedProject project) {

        var handle = CatalogProjects.Create(project);
        Directory.CreateDirectory(handle.ProjectDirectory);
        handle.CatalogForums = new CachedDocuments(handle, create:true);

        return handle;
        }







    /// <summary>
    /// Gets the project associated with the specified key.
    /// </summary>
    /// <param name="id">The key of the value to get.</param>
    /// <param name="project">When this method returns, contains the project identified by
    /// the specified key, if the key is found; otherwise, null. 
    /// This parameter is passed uninitialized.</param>
    /// <returns>true if there is a project identified by
    /// specified key; otherwise, false.</returns>
    public bool TryGetProject(
                    string id,
                    out ProjectHandle project) => CatalogProjects.TryGetByUid(id, out project);
    public bool TryGetMemberRecord(
            ParsedPath path,
              out CatalogedForumMember member) => TryGetMember(path.FirstId, out member);

    public bool TryGetTopic(
                ParsedPath path,
                out ProjectHandle project,
                out TopicHandle topic) {
        project = null;
        topic = null;
        if (!TryGetProject(path.ProjectId, out project)) {
            return false;
            }
        if (!project.TryGetTopic(path.TopicId, out topic)) {
            return false;
            }
        return true;
        }

    public bool TryGetPost(
            ParsedPath path,
            out ProjectHandle project,
            out TopicHandle topic,
            out PostHandle post) {
        project = null;
        topic = null;
        post = null;
        if (!TryGetTopic(path, out project, out topic)) {
            return false;
            }
        if (!topic.TryGetPost(path.PostId, out post)) {
            return false;
            }
        return true;
        }



    #endregion

    #region // Resource Methods



    #endregion
    #region // Response Methods

    ///// <summary>
    ///// Gets the reaction associated with the specified key.
    ///// </summary>
    ///// <param name="id">The key of the value to get.</param>
    ///// <param name="project">When this method returns, contains the reaction identified by
    ///// the specified key, if the key is found; otherwise, null. 
    ///// This parameter is passed uninitialized.</param>
    ///// <returns>true if there is a reaction identified by
    ///// specified key; otherwise, false.</returns>
    //public bool TryGetReaction(
    //                string id,
    //                out ReactionHandle project) {
    //    throw new NYI();
    //    }



    #endregion
    #endregion
    }
