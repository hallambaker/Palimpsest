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
	/// HeaderNavigation
	/// </summary>
	/// <param name="navigation"></param>
	/// <param name="index"></param>
	public void HeaderNavigation (Navigation navigation, int index) {
		_Output.Write ("<header>\n{0}", _Indent);
		_Output.Write ("<div class=\"text-end\">\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("<ul class=\"nav nav-pills\">\n{0}", _Indent);
		for  (var i =0; i< navigation.Items.Length; i++) {
			 var item = navigation.Items[i];
			_Output.Write ("        <li class=\"nav-item\"><a href=\"/{1}\" ", _Indent, item.Uri);
			if (  i == index ) {
				_Output.Write ("class=\"nav-link active\" aria-current=\"page\"", _Indent);
				} else {
				_Output.Write ("class=\"nav-link\"", _Indent);
				}
			_Output.Write (">{1}</a></li>\n{0}", _Indent, item.Label);
			}
		if (  navigation.Login ) {
			if (  SignedIn ) {
				_Output.Write ("    <li>{1} Sign Out</li>\n{0}", _Indent, VerifiedAccount.LocalName);
				} else {
				_Output.Write ("    <form action=\"/SignIn\" method=\"post\" enctype=\"multipart/form-data\">\n{0}", _Indent);
				_Output.Write ("    <li class=\"login-big\">Sign In @<input class=\"login-box\" type=\"text\" id=\"handle\", name=\"handle\" rel=\"dns-handle\"/>\n{0}", _Indent);
				_Output.Write ("    <input type=\"submit\" value=\"Sign In\" />\n{0}", _Indent);
				_Output.Write ("    </li>\n{0}", _Indent);
				}
			}
		_Output.Write ("</ul>\n{0}", _Indent);
		_Output.Write ("</div>\n{0}", _Indent);
		_Output.Write ("</header>\n{0}", _Indent);
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
	///  Trailer
	/// </summary>
	public void  Trailer () {
		_Output.Write ("<footer class=\"annotation-footer\"><a href=\"/Terms\">Terms and Conditions</a></footer>\n{0}", _Indent);
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
	// ///// Result pages - Home / Place / User / Document
	
	/// <summary>	
	/// PageHomeForum
	/// </summary>
	/// <param name="empty=null"></param>
	public void PageHomeForum (string empty=null) {
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("<main>\n{0}", _Indent);
		 HeaderNavigation(Annotation.NavigationSplashpage, 0);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("<div class=\"container\">\n{0}", _Indent);
		_Output.Write ("<img src=\"/resources/splashscreen.png\" alt=\"Splashscreen\" class=\"img-fluid\"/>\n{0}", _Indent);
		if (  !SignedIn ) {
			_Output.Write ("    <p>No need to create an account! Sign in using your @nything handle, the same handle you use to visit Bluesky social:\n{0}", _Indent);
			_Output.Write ("    </p>\n{0}", _Indent);
			_Output.Write ("    <form action=\"{1}\" method=\"post\" enctype=\"multipart/form-data\">\n{0}", _Indent, Annotation.ForumTermsAndConditions);
			_Output.Write ("    <p class=\"login-big\">@<input class=\"login-box\" type=\"text\" id=\"handle\", name=\"handle\" rel=\"dns-handle\"/>\n{0}", _Indent);
			_Output.Write ("    <input type=\"submit\" value=\"Sign In\" />\n{0}", _Indent);
			_Output.Write ("    </p>\n{0}", _Indent);
			_Output.Write ("    </form>\n{0}", _Indent);
			} else {
			_Output.Write ("    <p><a href=\"SignOut\">Sign Out</a></p>\n{0}", _Indent);
			if (  PermissionCreatePlace ) {
				_Output.Write ("    <p><a href=\"CreatePlace\">Create Place</a></p>\n{0}", _Indent);
				}
			}
		if (  empty is not null ) {
			_Output.Write ("    <h2>Place {1} not found!</h2>\n{0}", _Indent, empty);
			_Output.Write ("    <p>Here are some places you can visit instead:</p>\n{0}", _Indent);
			 ListPlaces();
			}
		_Output.Write ("</div>\n{0}", _Indent);
		_Output.Write ("</main>\n{0}", _Indent);
		 Trailer();
		}
	
	/// <summary>	
	/// PageBoilerplate
	/// </summary>
	/// <param name="boilerplate"></param>
	/// <param name="prefill=null"></param>
	public void PageBoilerplate (BoilerplateHtml boilerplate, FormDataAcceptTerms? prefill=null) {
		 if (boilerplate.HTML is null) {
		  Forum.FetchBoilerplate(boilerplate);
		  }
		 HeaderNavigation (Annotation.NavigationSplashpage, boilerplate.Index);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("<div class=\"container\">\n{0}", _Indent);
		_Output.Write ("{1}\n{0}", _Indent, boilerplate.HTML);
		if (  prefill is not null ) {
			if (  prefill.Insist ) {
				_Output.Write ("    <p class=\"form-error\">You MUST accept the terms to continue.</p>\n{0}", _Indent);
				}
			_Output.Write ("    <form action=\"/AcceptTerms\" method=\"post\" enctype=\"multipart/form-data\">\n{0}", _Indent);
			if (  prefill.From is not null ) {
				_Output.Write ("        <input type=\"hidden\" id=\"from\" name=\"from\" value=\"{1}\" />    \n{0}", _Indent, prefill.From);
				}
			if (  prefill.Handle is not null ) {
				_Output.Write ("        <input type=\"hidden\" id=\"handle\" name=\"handle\" value=\"{1}\" />  \n{0}", _Indent, prefill.Handle);
				}
			_Output.Write ("        <input type=\"checkbox\", id=\"agree\", name=\"agree\", value=\"true\">  <label for=\"fname\">I agree to these terms and conditions.</label>\n{0}", _Indent);
			_Output.Write ("        <input type=\"submit\" value=\"I Accept\" />\n{0}", _Indent);
			_Output.Write ("        <input type=\"submit\" value=\"Cancel\" formaction=\"/\"/>\n{0}", _Indent);
			_Output.Write ("    </form>\n{0}", _Indent);
			}
		_Output.Write ("</div>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		 Trailer();
		}
	
	/// <summary>	
	///  ListPlaces
	/// </summary>
	public void  ListPlaces () {
		_Output.Write ("    <div class=\"h-feed\">\n{0}", _Indent);
		_Output.Write ("    <table class=\"documentsList\">\n{0}", _Indent);
		 // ToDo: The list of projects should become 'featured projects'
		foreach   (var place in Places)  {
			_Output.Write ("    <tr class=\"h-entry\"><td class=\"u-url\">\n{0}", _Indent);
			_Output.Write ("    <a href=\"{1}\">@{2}</a>\n{0}", _Indent, place.HomeUri, place.LocalName);
			_Output.Write ("    </td><td class=\"p-name\">\n{0}", _Indent);
			_Output.Write ("    {1}\n{0}", _Indent, place.Description);
			_Output.Write ("    </td></tr>\n{0}", _Indent);
			}
		_Output.Write ("    </table>\n{0}", _Indent);
		_Output.Write ("    </div>\n{0}", _Indent);
		}
	
	/// <summary>	
	/// PagePlace
	/// </summary>
	/// <param name="handle"></param>
	public void PagePlace (PlaceHandle handle) {
		 var project = handle.CatalogedPlace;
		_Output.Write ("<div class=\"container\">\n{0}", _Indent);
		_Output.Write ("  <h1>Place: {1}</h1>\n{0}", _Indent, project.LocalName);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("  <p>{1}</p>\n{0}", _Indent, project.Description);
		_Output.Write ("  <p><a href=\"/{1}\">Add Document</a>\n{0}", _Indent, PalimpsestConstants.AddDocument);
		_Output.Write ("    <a href=\"/{1}\">Add Topic</a>\n{0}", _Indent, PalimpsestConstants.AddTopic);
		_Output.Write ("\n{0}", _Indent);
		if (  handle.IsForum ) {
			_Output.Write ("    <a href=\"CreatePlace\">Create Place</p>\n{0}", _Indent);
			}
		_Output.Write ("    </p>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		if (  handle.IsForum ) {
			_Output.Write ("    <h2>Places</h2>\n{0}", _Indent);
			 ListPlaces();
			}
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
	public void PageAddDocument (PlaceHandle handle) {
		 var project = handle.CatalogedPlace;
		_Output.Write ("<div class=\"container\">\n{0}", _Indent);
		_Output.Write ("  <h1>Add Document: {1}</h1>\n{0}", _Indent, project.LocalName);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("  <p>{1}</p>\n{0}", _Indent, project.Description);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("  <form action=\"/{1}\" method=\"post\" enctype=\"multipart/form-data\">\n{0}", _Indent, PalimpsestConstants.DocumentUpload);
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
	public void PageAddTopic (PlaceHandle handle) {
		 var project = handle.CatalogedPlace;
		_Output.Write ("<div class=\"container\">\n{0}", _Indent);
		_Output.Write ("  <h1>Add Topic: {1}</h1>\n{0}", _Indent, project.LocalName);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("  <p>{1}</p>\n{0}", _Indent, project.Description);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("  <form action=\"/{1}\" method=\"post\" enctype=\"multipart/form-data\">\n{0}", _Indent, PalimpsestConstants.TopicCreate);
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
	///  CreatePlace
	/// </summary>
	public void  CreatePlace () {
		_Output.Write ("<div class=\"container\">\n{0}", _Indent);
		_Output.Write ("  <h1>Create Place</h1>\n{0}", _Indent);
		_Output.Write ("<form action=\"/{1}\" method=\"post\" enctype=\"multipart/form-data\">\n{0}", _Indent, PalimpsestConstants.CreatePlacePost);
		_Output.Write ("  <table>\n{0}", _Indent);
		_Output.Write ("    <tr><td>\n{0}", _Indent);
		_Output.Write ("    <label for=\"name\">Place Name:</label>\n{0}", _Indent);
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
	/// <param name="username"></param>
	public void SignIn (string from, string username) {
		// NoteWell();
		_Output.Write ("    <p>No need to create an account! Sign in using your @nything handle, the same username you use for Bluesky social:\n{0}", _Indent);
		_Output.Write ("    </p>\n{0}", _Indent);
		_Output.Write ("<form action=\"/{1}\" method=\"post\" enctype=\"multipart/form-data\">\n{0}", _Indent, PalimpsestConstants.SignInPost);
		_Output.Write ("    <input type=\"hidden\" value=\"{1}\" id=\"from\" name=\"from\", value=\"{2}\"/>\n{0}", _Indent, from, username??"");
		_Output.Write ("    <p class=\"login-big\">@<input class=\"login-box\" type=\"text\" id=\"handle\", name=\"handle\" rel=\"dns-handle\"/>\n{0}", _Indent);
		_Output.Write ("    <input type=\"submit\" value=\"Sign In\" />\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("    <td colspan=\"2\">\n{0}", _Indent);
		_Output.Write ("        <input type=\"checkbox\" id=\"terms\" name=\"terms\" >\n{0}", _Indent);
		_Output.Write ("<label for=\"fname\">I agree to these terms and conditions.</label>\n{0}", _Indent);
		_Output.Write ("        </td>\n{0}", _Indent);
		_Output.Write ("    </p>\n{0}", _Indent);
		_Output.Write ("</form>\n{0}", _Indent);
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
	
	/// <summary>	
	///  PageVisitors
	/// </summary>
	public void  PageVisitors () {
		_Output.Write ("<div class=\"container\">\n{0}", _Indent);
		_Output.Write ("  <h1>List of visitors</h1>\n{0}", _Indent);
		_Output.Write ("</div>\n{0}", _Indent);
		}
	}
