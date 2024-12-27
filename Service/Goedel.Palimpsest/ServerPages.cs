using  System.Text;
using  Goedel.Protocol;
using  Goedel.Utilities;
 #pragma warning disable IDE0022
 #pragma warning disable IDE0060
 #pragma warning disable IDE1006
using System;
using System.IO;
using System.Collections.Generic;
using Goedel.Registry;
namespace Goedel.Palimpsest;
public partial class Annotations : global::Goedel.Registry.Script {

	// ///// Common fragments
	
	/// <summary>	
	/// StartPage
	/// </summary>
	/// <param name="title"></param>
	/// <param name="script=null"></param>
	public void StartPage (string title, string? script=null) {
		_Output.Write ("<!DOCTYPE html>\n{0}", _Indent);
		_Output.Write ("<html lang=\"en\">\n{0}", _Indent);
		_Output.Write ("  <head>\n{0}", _Indent);
		_Output.Write ("    <meta charset=\"utf-8\">\n{0}", _Indent);
		_Output.Write ("    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\n{0}", _Indent);
		_Output.Write ("    <title>{1}</title>\n{0}", _Indent, title);
		_Output.Write ("    <link rel=\"icon\" type=\"image/x-icon\" href=\"/resources/favicon.ico\">\n{0}", _Indent);
		_Output.Write ("    <link rel=\"stylesheet\" type=\"text/css\" href=\"/resources/stylesheet.css\">\n{0}", _Indent);
		if (  script != null ) {
			_Output.Write ("    <script src=\"/resources/{1}\"></script>\n{0}", _Indent, script);
			}
		_Output.Write ("    <link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css\" rel=\"stylesheet\" integrity=\"sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH\" crossorigin=\"anonymous\">\n{0}", _Indent);
		_Output.Write ("    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js\" integrity=\"sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz\" crossorigin=\"anonymous\"></script>\n{0}", _Indent);
		_Output.Write ("  </head>\n{0}", _Indent);
		_Output.Write ("  <body>\n{0}", _Indent);
		}
	
	/// <summary>	
	///  Header
	/// </summary>
	public void  Header () {
		_Output.Write ("<nav class=\"navbar bg-body-tertiary\">\n{0}", _Indent);
		_Output.Write ("  <div class=\"container-fluid\">\n{0}", _Indent);
		_Output.Write ("    <a class=\"navbar-brand\" href=\"\">Navbar</a>\n{0}", _Indent);
		_Output.Write ("  </div>\n{0}", _Indent);
		_Output.Write ("</nav>\n{0}", _Indent);
		}
	
	/// <summary>	
	///  FooterComment
	/// </summary>
	public void  FooterComment () {
		//     <footer class="annotation-footer">Someone 
		//     famous in <cite title="Source Title">Source Title</cite></footer>
		}
	
	/// <summary>	
	///  EndPage 
	/// </summary>
	public void  EndPage  () {
		_Output.Write ("  </body>\n{0}", _Indent);
		_Output.Write ("</html>\n{0}", _Indent);
		}
	
	/// <summary>	
	///  NoteWell 
	/// </summary>
	public void  NoteWell  () {
		_Output.Write ("<div class=\"container\">\n{0}", _Indent);
		_Output.Write ("  <h1>Note Well</h1>\n{0}", _Indent);
		_Output.Write ("  <p>\n{0}", _Indent);
		_Output.Write ("  This is a reminder of IETF policies in effect on various topics such as patents or code of conduct. It is only meant to point you in the right direction. Exceptions may apply. The IETF's patent policy and the definition of an IETF \"contribution\" and \"participation\" are set forth in BCP 79; please read it carefully.\n{0}", _Indent);
		_Output.Write ("  <p>\n{0}", _Indent);
		_Output.Write ("  <p>\n{0}", _Indent);
		_Output.Write ("As a reminder:\n{0}", _Indent);
		_Output.Write ("<p>\n{0}", _Indent);
		_Output.Write ("<ul>\n{0}", _Indent);
		_Output.Write ("<li>\n{0}", _Indent);
		_Output.Write ("By participating in the IETF, you agree to follow IETF processes and policies.</li>\n{0}", _Indent);
		_Output.Write ("<li>If you are aware that any IETF contribution is covered by patents or patent applications that are owned or controlled by you or your sponsor, you must disclose that fact, or not participate in the discussion.</li>\n{0}", _Indent);
		_Output.Write ("<li>As a participant in or attendee to any IETF activity you acknowledge that written, audio, video, and photographic records of meetings may be made public.</li>\n{0}", _Indent);
		_Output.Write ("<li>Personal information that you provide to IETF will be handled in accordance with the IETF Privacy Statement.</li>\n{0}", _Indent);
		_Output.Write ("<li>As a participant or attendee, you agree to work respectfully with other participants; please contact the ombudsteam \n{0}", _Indent);
		_Output.Write ("(<a href=\"https://www.ietf.org/contact/ombudsteam\">https://www.ietf.org/contact/ombudsteam</a>) if you have questions or concerns about this.</i>\n{0}", _Indent);
		_Output.Write ("</div>\n{0}", _Indent);
		}
	
	/// <summary>	
	///  PageError 
	/// </summary>
	public void  PageError  () {
		_Output.Write ("<div class=\"container\">\n{0}", _Indent);
		_Output.Write ("  <h1>An error occurred</h1>\n{0}", _Indent);
		_Output.Write ("</div>\n{0}", _Indent);
		}
	// ///// Result pages - Home / Project / User / Document
	
	/// <summary>	
	///  PageHome
	/// </summary>
	public void  PageHome () {
		_Output.Write ("<div class=\"container\">\n{0}", _Indent);
		_Output.Write ("<img class=\"header__logo\" src=\"/resources/ietf.svg\" alt=\"IETF logo\"/>\n{0}", _Indent);
		_Output.Write ("  <h1>Home {1}</h1>\n{0}", _Indent, Forum.Name);
		if (  !SignedIn ) {
			_Output.Write ("    <p><a href=\"SignIn\">Sign In</a></p>\n{0}", _Indent);
			_Output.Write ("    <p><a href=\"CreateAccount\">Create Account</a></p>\n{0}", _Indent);
			_Output.Write ("    <p class=\"disabled\">Create Project</p>\n{0}", _Indent);
			} else {
			_Output.Write ("    <p><a href=\"SignOut\">Sign Out</a></p>\n{0}", _Indent);
			if (  PermissionCreateProject ) {
				_Output.Write ("    <p><a href=\"CreateProject\">Create Project</a></p>\n{0}", _Indent);
				}
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("    <h2>Projects</h2>\n{0}", _Indent);
			_Output.Write ("    <table class=\"documentsList\">\n{0}", _Indent);
			foreach   (var project in Projects)  {
				_Output.Write ("    <tr><td>\n{0}", _Indent);
				_Output.Write ("    <a href=\"/Project/{1}\">{2}</a>\n{0}", _Indent, project.Uid, project.LocalName);
				_Output.Write ("    </td><td>\n{0}", _Indent);
				_Output.Write ("    {1}\n{0}", _Indent, project.Description);
				_Output.Write ("    </td></tr>\n{0}", _Indent);
				}
			_Output.Write ("    </table>\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			}
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("</div>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		}
	
	/// <summary>	
	/// PageProject
	/// </summary>
	/// <param name="handle"></param>
	public void PageProject (ProjectHandle handle) {
		 var project = handle.CatalogedProject;
		_Output.Write ("<div class=\"container\">\n{0}", _Indent);
		_Output.Write ("  <h1>Project: {1}</h1>\n{0}", _Indent, project.LocalName);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("  <p>{1}</p>\n{0}", _Indent, project.Description);
		_Output.Write ("  <p><a href=\"/AddDocument/{1}\">Add Document</a>\n{0}", _Indent, handle.Uid);
		_Output.Write ("    <a href=\"/AddTopic/{1}\">Add Topic</a>\n{0}", _Indent, handle.Uid);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("    <h2>Documents</h2>\n{0}", _Indent);
		_Output.Write ("    <table class=\"documentsList\">\n{0}", _Indent);
		if (  (handle.Resources is not null) ) {
			foreach  (var forum in handle.Resources)  {
				if (  (forum is CatalogedResource resource) ) {
					_Output.Write ("    <tr><td>\n{0}", _Indent);
					_Output.Write ("    <a href=\"/Document/{1}/{2}\">{3}</a>\n{0}", _Indent, handle.Uid, resource.Uid, resource.LocalName);
					_Output.Write ("    </td><td>\n{0}", _Indent);
					_Output.Write ("    {1}\n{0}", _Indent, resource.Description);
					_Output.Write ("    </td></tr>\n{0}", _Indent);
					}
				}
			}
		_Output.Write ("    </table>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("    <h2>Topics</h2>\n{0}", _Indent);
		_Output.Write ("    <table class=\"documentsList\">\n{0}", _Indent);
		if (  (handle.Resources is not null) ) {
			foreach  (var forum in handle.Resources)  {
				if (  (forum is CatalogedTopic topic) ) {
					_Output.Write ("    <tr><td>\n{0}", _Indent);
					_Output.Write ("    <a href=\"/Topic/{1}/{2}\">{3}</a>\n{0}", _Indent, handle.Uid, topic.Uid, topic.LocalName);
					_Output.Write ("    </td><td>\n{0}", _Indent);
					_Output.Write ("    {1}\n{0}", _Indent, topic.Description);
					_Output.Write ("    </td></tr>\n{0}", _Indent);
					}
				}
			}
		_Output.Write ("    </table>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("</div>\n{0}", _Indent);
		}
	
	/// <summary>	
	/// PageDocument
	/// </summary>
	/// <param name="document"></param>
	public void PageDocument (ResourceHandle document) {
		_Output.Write ("<div class=\"container\">\n{0}", _Indent);
		_Output.Write ("  <h1>Document: {1}</h1>\n{0}", _Indent, document.LocalName);
		_Output.Write ("</div>\n{0}", _Indent);
		}
	
	/// <summary>	
	/// PageMember
	/// </summary>
	/// <param name="member"></param>
	public void PageMember (CatalogedForumEntry member) {
		_Output.Write ("<div class=\"container\">\n{0}", _Indent);
		_Output.Write ("  <h1>Member: {1}</h1>\n{0}", _Indent, member.LocalName);
		_Output.Write ("</div>\n{0}", _Indent);
		}
	
	/// <summary>	
	/// PageTopic
	/// </summary>
	/// <param name="topic"></param>
	public void PageTopic (TopicHandle topic) {
		_Output.Write ("<div class=\"container\">\n{0}", _Indent);
		_Output.Write ("  <h1>Topic: {1}</h1>\n{0}", _Indent, topic.LocalName);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("<p><a href={1}>New Post</a>\n{0}", _Indent, topic.NewPost);
		_Output.Write ("</p>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("    <table class=\"documentsList\">\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		foreach  (var reaction in topic.Posts) {
			if (  (reaction is CatalogedPost post) ) {
				_Output.Write ("    <tr><td>\n{0}", _Indent);
				_Output.Write ("    <a href={1}>{2}</a>\n{0}", _Indent, GetMemberAnchor(post.MemberId), GetMemberLabel(post.MemberId));
				_Output.Write ("    </td><td>\n{0}", _Indent);
				_Output.Write ("        <a href={1}>{2}</a>\n{0}", _Indent, topic. GetPostAnchor(post), post.Subject);
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("    </td></tr>\n{0}", _Indent);
				}
			}
		_Output.Write ("    </table>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("</div>\n{0}", _Indent);
		}
	
	/// <summary>	
	/// PagePost
	/// </summary>
	/// <param name="post"></param>
	public void PagePost (PostHandle post) {
		_Output.Write ("<div class=\"container\">\n{0}", _Indent);
		_Output.Write ("  <p>{1} / {2}</p>\n{0}", _Indent, GetDateAdded(post.CatalogedEntry), GetMemberAnchor(post.CatalogedEntry));
		_Output.Write ("  <h1>{1}</h1>\n{0}", _Indent, post.CatalogedEntry.Subject);
		_Output.Write ("    <p>{1}</p>\n{0}", _Indent, post.CatalogedEntry.Text);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("  <p><a href={1}>New Comment</a>\n{0}", _Indent, post.NewComment);
		_Output.Write ("</p>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		if (  post.Comments is not null ) {
			_Output.Write ("<table>\n{0}", _Indent);
			foreach  (var entry in post.Comments) {
				 var comment = entry.Value;
				_Output.Write ("<tr>\n{0}", _Indent);
				_Output.Write ("<td>{1}</td>\n{0}", _Indent, GetDateAdded(comment));
				_Output.Write ("<td>{1}</td>\n{0}", _Indent, GetMemberAnchor(comment));
				_Output.Write ("<td>{1}</td>\n{0}", _Indent, comment.Text);
				_Output.Write ("</tr>\n{0}", _Indent);
				}
			_Output.Write ("</table>\n{0}", _Indent);
			}
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("</div>\n{0}", _Indent);
		}
	
	/// <summary>	
	/// PageAddDocument
	/// </summary>
	/// <param name="handle"></param>
	public void PageAddDocument (ProjectHandle handle) {
		 var project = handle.CatalogedProject;
		_Output.Write ("<div class=\"container\">\n{0}", _Indent);
		_Output.Write ("  <h1>Add Document: {1}</h1>\n{0}", _Indent, project.LocalName);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("  <p>{1}</p>\n{0}", _Indent, project.Description);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("  <form action=\"/DocumentUpload/{1}\" method=\"post\" enctype=\"multipart/form-data\">\n{0}", _Indent, handle.Uid);
		_Output.Write ("    <p>\n{0}", _Indent);
		_Output.Write ("      <table>\n{0}", _Indent);
		_Output.Write ("        <tr><td>\n{0}", _Indent);
		_Output.Write ("          <label for=\"data\">File:</label>\n{0}", _Indent);
		_Output.Write ("        </td><td>\n{0}", _Indent);
		_Output.Write ("          <input type=\"file\" id=\"data\" name=\"data\" />\n{0}", _Indent);
		_Output.Write ("        </td></tr>       \n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("        <tr><td>        \n{0}", _Indent);
		_Output.Write ("          <label for=\"format\">Format:</label>\n{0}", _Indent);
		_Output.Write ("        </td><td>\n{0}", _Indent);
		_Output.Write ("          <select name=\"format\" id=\"format\">\n{0}", _Indent);
		_Output.Write ("            <option value=\"auto\">Auto</option>\n{0}", _Indent);
		_Output.Write ("            <option value=\"xml2rfc\">XML2RFC</option>\n{0}", _Indent);
		_Output.Write ("            <option value=\"word\">Word</option>\n{0}", _Indent);
		_Output.Write ("            <option value=\"markdown\">Markdown</option>\n{0}", _Indent);
		_Output.Write ("            <option value=\"html\">HTML</option>\n{0}", _Indent);
		_Output.Write ("          </select>\n{0}", _Indent);
		_Output.Write ("        </td></tr> \n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("        <tr><td>\n{0}", _Indent);
		_Output.Write ("          <label for=\"name\">Document Name:</label>\n{0}", _Indent);
		_Output.Write ("        </td><td>\n{0}", _Indent);
		_Output.Write ("          <input type=\"text\", id=\"name\", name=\"name\">\n{0}", _Indent);
		_Output.Write ("        </td></tr>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("        <tr><td>\n{0}", _Indent);
		_Output.Write ("          <label for=\"description\">Description:</label>\n{0}", _Indent);
		_Output.Write ("        </td><td>\n{0}", _Indent);
		_Output.Write ("          <textarea type=\"text\", id=\"description\", name=\"description\"></textarea>\n{0}", _Indent);
		_Output.Write ("        </td></tr>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("        <tr><td colspan=\"2\">\n{0}", _Indent);
		_Output.Write ("          <input type=\"submit\" value=\"Upload\" />\n{0}", _Indent);
		_Output.Write ("        </td></tr>\n{0}", _Indent);
		_Output.Write ("    </p>\n{0}", _Indent);
		_Output.Write ("    </form>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("</div>\n{0}", _Indent);
		}
	
	/// <summary>	
	/// PageAddTopic
	/// </summary>
	/// <param name="handle"></param>
	public void PageAddTopic (ProjectHandle handle) {
		 var project = handle.CatalogedProject;
		_Output.Write ("<div class=\"container\">\n{0}", _Indent);
		_Output.Write ("  <h1>Add Topic: {1}</h1>\n{0}", _Indent, project.LocalName);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("  <p>{1}</p>\n{0}", _Indent, project.Description);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("  <form action=\"/TopicCreate/{1}\" method=\"post\" enctype=\"multipart/form-data\">\n{0}", _Indent, handle.Uid);
		_Output.Write ("    <p>\n{0}", _Indent);
		_Output.Write ("      <table>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("        <tr><td>\n{0}", _Indent);
		_Output.Write ("          <label for=\"name\">Topic Name:</label>\n{0}", _Indent);
		_Output.Write ("        </td><td>\n{0}", _Indent);
		_Output.Write ("          <input type=\"text\", id=\"name\", name=\"name\">\n{0}", _Indent);
		_Output.Write ("        </td></tr>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("        <tr><td>\n{0}", _Indent);
		_Output.Write ("          <label for=\"description\">Description:</label>\n{0}", _Indent);
		_Output.Write ("        </td><td>\n{0}", _Indent);
		_Output.Write ("          <textarea type=\"text\", id=\"description\", name=\"description\"></textarea>\n{0}", _Indent);
		_Output.Write ("        </td></tr>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("        <tr><td colspan=\"2\">\n{0}", _Indent);
		_Output.Write ("          <input type=\"submit\" value=\"Upload\" />\n{0}", _Indent);
		_Output.Write ("        </td></tr>\n{0}", _Indent);
		_Output.Write ("    </p>\n{0}", _Indent);
		_Output.Write ("    </form>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("</div>\n{0}", _Indent);
		}
	// ///////////////////////////
	
	/// <summary>	
	///  CreateProject
	/// </summary>
	public void  CreateProject () {
		_Output.Write ("<div class=\"container\">\n{0}", _Indent);
		_Output.Write ("  <h1>Create Project</h1>\n{0}", _Indent);
		_Output.Write ("<form action=\"/CreateProjectPost\" method=\"post\" enctype=\"multipart/form-data\">\n{0}", _Indent);
		_Output.Write ("  <table>\n{0}", _Indent);
		_Output.Write ("    <tr><td>\n{0}", _Indent);
		_Output.Write ("    <label for=\"name\">Project Name:</label>\n{0}", _Indent);
		_Output.Write ("    </td><td>\n{0}", _Indent);
		_Output.Write ("    <input type=\"text\", id=\"name\", name=\"name\">\n{0}", _Indent);
		_Output.Write ("    </td></tr>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("    <tr><td>\n{0}", _Indent);
		_Output.Write ("    <label for=\"description\">Description:</label>\n{0}", _Indent);
		_Output.Write ("    </td><td>\n{0}", _Indent);
		_Output.Write ("    <textarea type=\"text\", id=\"description\", name=\"description\"></textarea>\n{0}", _Indent);
		_Output.Write ("    </td></tr>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("    <tr><td colspan=\"2\">\n{0}", _Indent);
		_Output.Write ("    <input type=\"submit\" value=\"Submit\" />\n{0}", _Indent);
		_Output.Write ("    </td></tr>\n{0}", _Indent);
		_Output.Write ("  </table>\n{0}", _Indent);
		_Output.Write ("  </form>\n{0}", _Indent);
		_Output.Write ("</div>\n{0}", _Indent);
		}
	
	/// <summary>	
	/// SignIn
	/// </summary>
	/// <param name="from"></param>
	public void SignIn (string from) {
		 NoteWell();
		_Output.Write ("<form action=\"/SignInPost\" method=\"post\" enctype=\"multipart/form-data\">\n{0}", _Indent);
		_Output.Write ("<input type=\"hidden\" value=\"{1}\" id=\"from\" name=\"from\"/>\n{0}", _Indent, from);
		_Output.Write ("<table >\n{0}", _Indent);
		 SignInForm(false);
		_Output.Write ("<table>\n{0}", _Indent);
		_Output.Write ("</form>\n{0}", _Indent);
		}
	
	/// <summary>	
	///  CreateAccount 
	/// </summary>
	public void  CreateAccount  () {
		 NoteWell();
		_Output.Write ("<form  action=\"/CreateAccountPost\" method=\"post\" enctype=\"multipart/form-data\">\n{0}", _Indent);
		_Output.Write ("<table>\n{0}", _Indent);
		 SignInForm(true);
		_Output.Write ("<table>\n{0}", _Indent);
		_Output.Write ("</form>\n{0}", _Indent);
		}
	
	/// <summary>	
	/// SignInForm
	/// </summary>
	/// <param name="create"></param>
	public void SignInForm (bool create) {
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("<tr><td>\n{0}", _Indent);
		_Output.Write ("<label for=\"username\">Username:</label>\n{0}", _Indent);
		_Output.Write ("</td><td>\n{0}", _Indent);
		_Output.Write ("<input type=\"text\", id=\"username\", name=\"username\">\n{0}", _Indent);
		_Output.Write ("</td></tr>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("<tr><td>\n{0}", _Indent);
		_Output.Write ("<label for=\"password\">Password:</label>\n{0}", _Indent);
		_Output.Write ("</td><td>\n{0}", _Indent);
		_Output.Write ("<input type=\"password\", id=\"password\", name=\"password\">\n{0}", _Indent);
		_Output.Write ("</td></tr>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		if (  create ) {
			_Output.Write ("<tr><td>\n{0}", _Indent);
			_Output.Write ("<label for=\"password2\">Confirm Password:</label>\n{0}", _Indent);
			_Output.Write ("</td><td>\n{0}", _Indent);
			_Output.Write ("<input type=\"password\", id=\"password2\", name=\"password2\">\n{0}", _Indent);
			_Output.Write ("</td></tr>\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("<tr><td colspan=\"2\">\n{0}", _Indent);
			_Output.Write ("<input type=\"checkbox\" id=\"terms\" name=\"terms\" >\n{0}", _Indent);
			_Output.Write ("<label for=\"terms\">I agree to  follow IETF processes and policies</label>\n{0}", _Indent);
			_Output.Write ("</td></tr>\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			}
		_Output.Write ("<tr><td colspan=\"2\">\n{0}", _Indent);
		_Output.Write ("<input type=\"submit\" value=\"Submit\" />\n{0}", _Indent);
		_Output.Write ("</td></tr>\n{0}", _Indent);
		}
	
	/// <summary>	
	/// PageEnterComment
	/// </summary>
	/// <param name="path"></param>
	/// <param name="mode"></param>
	public void PageEnterComment (ParsedPath path, CommentMode mode) {
		_Output.Write ("<div class=\"whatever\">\n{0}", _Indent);
		_Output.Write ("<h1>Enter a comment</h1>\n{0}", _Indent);
		 var target = path.GetPostTarget();
		_Output.Write ("<form  action=\"{1}\" method=\"post\" enctype=\"multipart/form-data\">\n{0}", _Indent, target);
		_Output.Write ("    <input type=\"hidden\" id=\"fragment\" name=\"fragment\" value=\"{1}\">\n{0}", _Indent, path.FragmentId);
		_Output.Write ("    <table>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		if (  mode.HasFlag(CommentMode.Semantic) ) {
			_Output.Write ("        <tr><td><label for=\"semantic\">Semantic</label></td><td><select name=\"semantic\" id=\"semantic\">\n{0}", _Indent);
			_Output.Write ("            <option value=\"agree\">Agree</option>\n{0}", _Indent);
			_Output.Write ("            <option value=\"disagree\">Disagree</option>\n{0}", _Indent);
			_Output.Write ("            <option value=\"question\">Question</option>\n{0}", _Indent);
			_Output.Write ("            <option value=\"answer\">Answer</option>\n{0}", _Indent);
			_Output.Write ("            <option value=\"example\">Example</option>\n{0}", _Indent);
			_Output.Write ("            <option value=\"qualify\">Qualify</option>\n{0}", _Indent);
			_Output.Write ("            <option value=\"info\">Information</option>\n{0}", _Indent);
			_Output.Write ("            <option value=\"action\">Action</option>\n{0}", _Indent);
			_Output.Write ("            </select>\n{0}", _Indent);
			_Output.Write ("        </td></tr>\n{0}", _Indent);
			}
		if (  mode.HasFlag(CommentMode.Subject) ) {
			_Output.Write ("        <tr><td><label for=\"subject\">Subject</label></td><td><input type=\"text\" id=\"subject\" name=\"subject\" ></input>\n{0}", _Indent);
			_Output.Write ("        </td></tr>\n{0}", _Indent);
			}
		if (  mode.HasFlag(CommentMode.Text) ) {
			_Output.Write ("        <tr><td><label for=\"comment\">Text</label></td><td><textarea type=\"text\" id=\"comment\" name=\"comment\" ></textarea>\n{0}", _Indent);
			_Output.Write ("        </td></tr>\n{0}", _Indent);
			}
		_Output.Write ("        <tr><td colspan=\"2\">\n{0}", _Indent);
		_Output.Write ("            <input type=\"submit\" value=\"Submit\" />\n{0}", _Indent);
		_Output.Write ("        </td></tr>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("    </table>\n{0}", _Indent);
		_Output.Write ("</form>\n{0}", _Indent);
		_Output.Write ("</div>\n{0}", _Indent);
		}
	
	/// <summary>	
	///  PageComment
	/// </summary>
	public void  PageComment () {
		_Output.Write ("<div class=\"container\">\n{0}", _Indent);
		_Output.Write ("  <h1>Got a comment</h1>\n{0}", _Indent);
		_Output.Write ("  </div>\n{0}", _Indent);
		}
	
	/// <summary>	
	///  PageUpload 
	/// </summary>
	public void  PageUpload  () {
		_Output.Write ("<div class=\"container\">\n{0}", _Indent);
		_Output.Write ("  <h1>Upload Complete</h1>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("</div>\n{0}", _Indent);
		}
	
	/// <summary>	
	///  PageActions 
	/// </summary>
	public void  PageActions  () {
		_Output.Write ("<div class=\"container\">\n{0}", _Indent);
		_Output.Write ("  <h1>List of outstanding actions</h1>\n{0}", _Indent);
		_Output.Write ("</div>\n{0}", _Indent);
		}
	}
