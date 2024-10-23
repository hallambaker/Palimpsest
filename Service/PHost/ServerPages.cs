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
namespace Annotate;
public partial class Annotations : global::Goedel.Registry.Script {

	
	/// <summary>	
	/// StartPage
	/// </summary>
	/// <param name="options"></param>
	public void StartPage (string? script=null) {
		_Output.Write ("<!DOCTYPE html>\n{0}", _Indent);
		_Output.Write ("<html lang=\"en\">\n{0}", _Indent);
		_Output.Write ("  <head>\n{0}", _Indent);
		_Output.Write ("    <meta charset=\"utf-8\">\n{0}", _Indent);
		_Output.Write ("    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\n{0}", _Indent);
		_Output.Write ("    <link rel=\"icon\" type=\"image/x-icon\" href=\"/resources/favicon.ico\">\n{0}", _Indent);
		_Output.Write ("    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css\">\n{0}", _Indent);
		_Output.Write ("    <link rel=\"stylesheet\" type=\"text/css\" href=\"/resources/stylesheet.css\">\n{0}", _Indent);
		if (  script != null ) {
			_Output.Write ("    <script src=\"/resources/{1}\"></script>\n{0}", _Indent, script);
			}
		_Output.Write ("    <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js\"></script>\n{0}", _Indent);
		_Output.Write ("    <script src=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js\"></script>\n{0}", _Indent);
		_Output.Write ("  </head>\n{0}", _Indent);
		_Output.Write ("  <body>\n{0}", _Indent);
		}
	
	/// <summary>	
	///  EndPage 
	/// </summary>
	public void  EndPage  () {
		_Output.Write ("  </body>\n{0}", _Indent);
		_Output.Write ("</html>\n{0}", _Indent);
		}
	
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
			_Output.Write ("    <P>List of active projects here</p>\n{0}", _Indent);
			}
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("</div>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		}
	
	/// <summary>	
	///  CreateProject
	/// </summary>
	public void  CreateProject () {
		_Output.Write ("<div class=\"container\">\n{0}", _Indent);
		_Output.Write ("  <h1>Create Project</h1>\n{0}", _Indent);
		_Output.Write ("  <form>\n{0}", _Indent);
		_Output.Write ("  <table>\n{0}", _Indent);
		_Output.Write ("    <tr><td>\n{0}", _Indent);
		_Output.Write ("    <label for=\"Project Name\">Username:</label>\n{0}", _Indent);
		_Output.Write ("    </td><td>\n{0}", _Indent);
		_Output.Write ("    <input type=\"text\", id=\"name\", name=\"name\">\n{0}", _Indent);
		_Output.Write ("    <tr><td>\n{0}", _Indent);
		_Output.Write ("    <label for=\"Project Name\">Description:</label>\n{0}", _Indent);
		_Output.Write ("    </td><td>\n{0}", _Indent);
		_Output.Write ("    <textarea type=\"text\", id=\"description\", name=\"description\">\n{0}", _Indent);
		_Output.Write ("    <tr><td>\n{0}", _Indent);
		_Output.Write ("  </table>\n{0}", _Indent);
		_Output.Write ("  </form>\n{0}", _Indent);
		_Output.Write ("</div>\n{0}", _Indent);
		}
	
	/// <summary>	
	///  SignIn 
	/// </summary>
	public void  SignIn  () {
		 NoteWell();
		 SignInForm(false);
		}
	
	/// <summary>	
	///  CreateAccount 
	/// </summary>
	public void  CreateAccount  () {
		 NoteWell();
		 SignInForm(true);
		}
	
	/// <summary>	
	/// SignInForm
	/// </summary>
	/// <param name="options"></param>
	public void SignInForm (bool terms) {
		_Output.Write ("<form>\n{0}", _Indent);
		_Output.Write ("<table>\n{0}", _Indent);
		_Output.Write ("<tr><td>\n{0}", _Indent);
		_Output.Write ("<label for=\"username\">Username:</label>\n{0}", _Indent);
		_Output.Write ("</td><td>\n{0}", _Indent);
		_Output.Write ("<input type=\"text\", id=\"username\", name=\"username\">\n{0}", _Indent);
		_Output.Write ("<tr><td>\n{0}", _Indent);
		_Output.Write ("<label for=\"password\">Password:</label>\n{0}", _Indent);
		_Output.Write ("</td><td>\n{0}", _Indent);
		_Output.Write ("<input type=\"password\", id=\"password\", name=\"password\">\n{0}", _Indent);
		_Output.Write ("<tr><td colspan=\"2\">\n{0}", _Indent);
		_Output.Write ("<input type=\"checkbox\" id=\"terms\" name=\"password\" >\n{0}", _Indent);
		_Output.Write ("<label for=\"terms\">I agree to  follow IETF processes and policies</label>\n{0}", _Indent);
		_Output.Write ("</td></tr>\n{0}", _Indent);
		_Output.Write ("<table>\n{0}", _Indent);
		_Output.Write ("</form>\n{0}", _Indent);
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
	///  PageEnterComment
	/// </summary>
	public void  PageEnterComment () {
		_Output.Write ("<div class=\"whatever\">\n{0}", _Indent);
		_Output.Write ("  <h1>Enter a comment</h1>\n{0}", _Indent);
		_Output.Write ("  \n{0}", _Indent);
		_Output.Write ("  <form id=\"myForm\">\n{0}", _Indent);
		_Output.Write ("    <table>\n{0}", _Indent);
		_Output.Write ("  \n{0}", _Indent);
		_Output.Write ("    <tr><td><label for=\"user\">User</label></td><td><input type=\"text\" id=\"user\" name=\"User\" /></td></tr>\n{0}", _Indent);
		_Output.Write ("    <tr><td><label for=\"anchor\">Anchor</label></td><td><input type=\"text\" id=\"anchor\" name=\"Anchor\" /></td></tr>\n{0}", _Indent);
		_Output.Write ("    <tr><td><label for=\"semantic\">Semantic</label></td><td><select name=\"Semantic\" id=\"semantic\">\n{0}", _Indent);
		_Output.Write ("  <option value=\"discuss\">Discuss</option>\n{0}", _Indent);
		_Output.Write ("  <option value=\"suggest\">Suggest</option>\n{0}", _Indent);
		_Output.Write ("  <option value=\"query\">Query</option>\n{0}", _Indent);
		_Output.Write ("  <option value=\"issue\">Issue</option>\n{0}", _Indent);
		_Output.Write ("  <option value=\"info\">Information</option>\n{0}", _Indent);
		_Output.Write ("</select></td></tr>\n{0}", _Indent);
		_Output.Write ("    <tr><td><label for=\"text\">Text</label></td><td><textarea type=\"text\" id=\"text\" name=\"Text\" ></textarea></td></tr>\n{0}", _Indent);
		_Output.Write ("    <tr><td><button onclick=\"showAlert()\" type=\"button\">Click Me!!</button></td></tr>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("    </table>\n{0}", _Indent);
		_Output.Write (" </form>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("  <p>Here will be an form</p>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("      <script>\n{0}", _Indent);
		_Output.Write ("        function showAlert() {{\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("            const url = 'Comment'\n{0}", _Indent);
		_Output.Write ("            const comment = {{\n{0}", _Indent);
		_Output.Write ("                id: 1017,\n{0}", _Indent);
		_Output.Write ("                }}\n{0}", _Indent);
		_Output.Write ("            comment.User = document.getElementById('user').value;\n{0}", _Indent);
		_Output.Write ("            comment.Anchor = document.getElementById('anchor').value;\n{0}", _Indent);
		_Output.Write ("            comment.Semantic = document.getElementById('semantic').value;\n{0}", _Indent);
		_Output.Write ("            comment.Text = document.getElementById('text').value;\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("            // a POST request\n{0}", _Indent);
		_Output.Write ("            const response =  fetch('Comment', {{\n{0}", _Indent);
		_Output.Write ("                method: 'POST',\n{0}", _Indent);
		_Output.Write ("                headers: {{\n{0}", _Indent);
		_Output.Write ("                    'Content-Type': 'application/json; charset=utf-8'\n{0}", _Indent);
		_Output.Write ("                    }},\n{0}", _Indent);
		_Output.Write ("                body: JSON.stringify(comment)\n{0}", _Indent);
		_Output.Write ("                }})\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("            }}\n{0}", _Indent);
		_Output.Write ("    </script>\n{0}", _Indent);
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
	///  PageSelect 
	/// </summary>
	public void  PageSelect  () {
		_Output.Write ("<div class=\"container\">\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("    <form method0=\"post\" action=\"Append\" enctype=\"multipart/form-data\">\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("        <label>Select the file:</label>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("        <input type=\"file\" id=\"fileUpload\" name=\"data\" />\n{0}", _Indent);
		_Output.Write ("        <br/>\n{0}", _Indent);
		_Output.Write ("        <input type=\"radio\" id=\"auto\" name=\"format\" value=\"auto\"><label>Auto detect</label>\n{0}", _Indent);
		_Output.Write ("        <input type=\"radio\" id=\"md\" name=\"format\" value=\"md\"><label>Markdown</label>\n{0}", _Indent);
		_Output.Write ("        <input type=\"radio\" id=\"word\" name=\"format\" value=\"word\"><label>Word</label>\n{0}", _Indent);
		_Output.Write ("        <input type=\"radio\" id=\"html\" name=\"format\" value=\"html\"><label>HTML</label>\n{0}", _Indent);
		_Output.Write ("        <input type=\"radio\" id=\"xml2rfc\" name=\"format\" value=\"xml2rfc\" checked=\"checked\"><label>XML2RFC</label>\n{0}", _Indent);
		_Output.Write ("        <br/>\n{0}", _Indent);
		_Output.Write ("        <input type=\"submit\" value=\"Upload\">\n{0}", _Indent);
		_Output.Write ("    </form>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("</div>\n{0}", _Indent);
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
	///  PageDocuments 
	/// </summary>
	public void  PageDocuments  () {
		_Output.Write ("<div class=\"container\">\n{0}", _Indent);
		_Output.Write ("  <h1>List of managed documents</h1>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("</div>\n{0}", _Indent);
		}
	
	/// <summary>	
	///  PageDocument 
	/// </summary>
	public void  PageDocument  () {
		_Output.Write ("<div class=\"container\">\n{0}", _Indent);
		_Output.Write ("  <h1>A particular managed documents</h1>\n{0}", _Indent);
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
	///  PageError 
	/// </summary>
	public void  PageError  () {
		_Output.Write ("<div class=\"container\">\n{0}", _Indent);
		_Output.Write ("  <h1>An error occurred</h1>\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("</div>\n{0}", _Indent);
		}
	}
