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

using Goedel.Mesh;

using System.IO;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Text;

namespace Goedel.Palimpsest;


/// <summary>
/// The class tracking the status of a forum, all interactions with the forum 
/// take place through this lens
/// </summary>
public class Forum : Disposable {

    // crib https://infisical.com/blog/guide-to-implementing-oauth2


    #region // Properties

    public string Name { get; set; }




    public string DirectoryPath { get; }
    public string Resources { get; }


    public ServerCookieManager ServerCookieManager { get; } = new();

    CachedPlaces CatalogProjects { get; }
    CachedMembers CatalogMembers { get; }


    //public NavigationItem[] ForumNavigation = [
    //    new ("Home", ""),
    //    new ("Technology", "Technology", "technology.md"),
    //    new ("FAQ", "FAQ", "faq.md"),
    //    new ("About", "About", "about.md")
    //    ];

    //public NavigationItem[] ForumAdditional = [
    //    new ("Terms", "Terms", "terms.md"),
    //    ];




    ////public Navigation NavigationMisc => new(ForumNavigation, -1);

    //public BoilerplateHtml TermsAndConditions { get; set; }
    //        = new BoilerplateHtml() {

    //            };

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

        CatalogProjects = new(this, directory);
        CatalogMembers = new(this, directory);

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
        var catalogProjects = new CachedPlaces(null, directory, create: true);
        var catalogMembers = new CachedMembers(null, directory, create: true);
        catalogProjects.Dispose();
        catalogMembers.Dispose();

        var result = new Forum(directory, resources, name);
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




    /// <summary>
    /// Attempt to resolve user by their handle, this is recorded as the localname 
    /// of the member.
    /// </summary>
    /// <param name="handle">The member handle, e.g. alice.example.com</param>
    /// <param name="member">The member handle.</param>
    /// <returns></returns>
    public bool TryGetByHandle(string handle, out MemberHandle? member) =>
            CatalogMembers.TryGetByLocalName(handle, out member);



    public bool TryGetByDid(string did, out MemberHandle? handle) =>
                    CatalogMembers.TryGetByUid(did, out handle);


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

    public IEnumerable<CatalogedPlace> GetProjectEnumerator() => CatalogProjects.GetProjectEnumerator();


    public IEnumerable<CatalogedForumMember> GetMemberEnumerator() {
        throw new NYI();
        }


    #endregion
    #region // Member Methods

    public MemberHandle? GetMember(
                string handle) {
        CatalogMembers.TryGetByLocalName(handle, out var memberHandle);
        return memberHandle;
        }


    public MemberHandle GetOrCreateMember(
                    string handle,
                    string did,
                    string? profileUdf = null) {
        if (CatalogMembers.TryGetByLocalName(handle, out var memberHandle)) {
            return memberHandle;
            }
        var cataloged = new CatalogedForumMember() {
            LocalName = handle,
            Did = did,
            ProfileUdf = profileUdf
            };
        return AddMember(cataloged, null);
        }



    public MemberHandle AddMember(
                CatalogedForumMember template,
                string? password
                ) {
        if (password is not null) {
            template.SetPasswordDigest(password, template.LocalName, Name);
            }
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




    public string GetMemberAnchor(
                string memberId) {
        if (!CatalogMembers.TryGetByUid(memberId, out var member)) {
            return "Deleted";
            }
        return $"<a href=\"/{PalimpsestConstants.User}/{member.LocalName}\">{member.LocalName}</a>";


        //< a href =#{GetMemberAnchor(post.MemberId)}>#{GetMemberLabel(post.MemberId)}</a>
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
    public PlaceHandle CreatePlace(
                    CatalogedPlace project) {

        var handle = CatalogProjects.Create(project);
        Directory.CreateDirectory(handle.ProjectDirectory);
        handle.CatalogForums = new CachedDocuments(handle, create: true);

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
    public bool TryGetPlace(
                    string id,
                    out PlaceHandle project) => CatalogProjects.TryGetByLocalName(id, out project);
    public bool TryGetMemberRecord(
            ParsedPath path,
              out CatalogedForumMember member) {
        if (CatalogMembers.TryGetByLocalName(path.FirstId, out var handle)) {
            member = handle.CatalogedMember;
            return true;
            }
        member = null;
        return false;
        }

    public bool TryGetTopic(
                ParsedPath path,
                out TopicHandle topic) {


        topic = null;
        if (!path.PlaceHandle.TryGetTopic(path.TopicId, out topic)) {
            return false;
            }
        return true;
        }




    #endregion

    #region // Resource Methods

    public bool FetchBoilerplate(BoilerplateHtml boilerplate, string language="en") {

        try {
            var path = Path.Combine(Resources, language, boilerplate.Filename);

            var document = new MarkdownDocument(path);
            boilerplate.HTML = GetHTML(document);

            return true;
            }

        catch {
            boilerplate.HTML = "Document not found";
            return false;
            }
        }



    public string GetHTML(MarkdownDocument document) {
        var builder = new StringBuilder();

        var block = Document.Markdown.BlockType.Paragraph;
        foreach (var paragraph in document.Paragraphs) {
            OpenCloseList (builder, block, paragraph.BlockType);
            block = paragraph.BlockType;
            switch (paragraph.BlockType) {

                case Document.Markdown.BlockType.Heading: {
                    builder.AppendLine($"<h{paragraph.Level}>{paragraph.Text}</h{paragraph.Level}>");
                    break;
                    }
                case Document.Markdown.BlockType.Paragraph: {
                    builder.AppendLine($"<p>{paragraph.Text}</p>");
                    break;
                    }
                case Document.Markdown.BlockType.DefinedTerm: {

                    builder.AppendLine($"<dt>{paragraph.Text}</dt>");
                    break;
                    }
                case Document.Markdown.BlockType.DefinedData: {
                    builder.AppendLine($"<dd>{paragraph.Text}</dd>");

                    break;
                    }
                }

            }
        OpenCloseList(builder, block, Document.Markdown.BlockType.Paragraph);
        return builder.ToString();
        }


    void OpenCloseList(StringBuilder builder, 
                    Document.Markdown.BlockType last,
                     Document.Markdown.BlockType next) {
        switch (last) {
            case Document.Markdown.BlockType.DefinedTerm:
            case Document.Markdown.BlockType.DefinedData: {
                switch (next) {
                    case Document.Markdown.BlockType.DefinedTerm:
                    case Document.Markdown.BlockType.DefinedData: {
                        break;
                        }
                    default : {
                        builder.AppendLine("</dl>");
                        break; 
                        }
                    }
                break;
                }
            default : {
                switch (next) {
                    case Document.Markdown.BlockType.DefinedTerm:
                    case Document.Markdown.BlockType.DefinedData: {
                        builder.AppendLine("<dl>");
                        break;
                        }
                    default: {
                        break;
                        }
                    }
                break;
                }
            }

        }

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
