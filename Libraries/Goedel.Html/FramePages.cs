// Script Syntax Version:  1.0

//  © 2015-2021 by Threshold Secrets LLC.
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
//  
//  
using System;
using System.IO;
using System.Collections.Generic;
using Goedel.Registry;
namespace Goedel.Html;
public partial class GenerateBacking : global::Goedel.Registry.Script {

	 string structure = "partial class";
	
	/// <summary>	
	/// CreateFrame
	/// </summary>
	/// <param name="frameset"></param>
	public void CreateFrame (FrameSet frameset) {
		 var comma = new Registry.Separator (",");
		 var className = "MyClass";
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("namespace {1};\n{0}", _Indent, frameset.Namespace);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("public partial class {1} : FrameSet{{\n{0}", _Indent, className);
		foreach  (var backer in frameset.Pages)  {
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("	///<summary>{1}</summary>\n{0}", _Indent, backer.Id);
			_Output.Write ("	public {1} {2} {{get;}} = new();\n{0}", _Indent, backer.Id, backer.Id);
			}
		_Output.Write ("\n{0}", _Indent);
		foreach  (var backer in frameset.Menus)  {
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("	///<summary>{1}</summary>\n{0}", _Indent, backer.Id);
			_Output.Write ("	public {1} {2} {{get;}} = new();\n{0}", _Indent, backer.Id, backer.Id);
			}
		_Output.Write ("\n{0}", _Indent);
		foreach  (var backer in frameset.Selectors)  {
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("	 ///<summary>{1}</summary>\n{0}", _Indent, backer.Id);
			_Output.Write ("	 public {1} {2} {{get;}} = new();\n{0}", _Indent, backer.Id, backer.Id);
			}
		_Output.Write ("\n{0}", _Indent);
		foreach  (var backer in frameset.Classes)  {
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("	 ///<summary>{1}</summary>\n{0}", _Indent, backer.Id);
			_Output.Write ("	 public {1} {2} {{get;}} = new();\n{0}", _Indent, backer.Id, backer.Id);
			}
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("	/// <summary>\n{0}", _Indent);
		_Output.Write ("	/// Constructor, return a new instance.\n{0}", _Indent);
		_Output.Write ("	/// </summary>\n{0}", _Indent);
		_Output.Write ("	public {1} () {{\n{0}", _Indent, className);
		_Output.Write ("\n{0}", _Indent);
		 comma.Reset();
		_Output.Write ("		Pages = [ ", _Indent);
		foreach  (var backer in frameset.Pages)  {
			_Output.Write ("{1}\n{0}", _Indent, comma);
			_Output.Write ("			{1}", _Indent, backer.Id);
			}
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("			];\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		 comma.Reset();
		_Output.Write ("		Menus = [ ", _Indent);
		foreach  (var backer in frameset.Menus)  {
			_Output.Write ("{1}\n{0}", _Indent, comma);
			_Output.Write ("			{1}", _Indent, backer.Id);
			}
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("			];\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		 comma.Reset();
		_Output.Write ("		Selectors = [ ", _Indent);
		foreach  (var backer in frameset.Selectors)  {
			_Output.Write ("{1}\n{0}", _Indent, comma);
			_Output.Write ("			{1}", _Indent, backer.Id);
			}
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("			];\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		 comma.Reset();
		_Output.Write ("		Classes = [ ", _Indent);
		foreach  (var backer in frameset.Classes)  {
			_Output.Write ("{1}\n{0}", _Indent, comma);
			_Output.Write ("			{1}", _Indent, backer.Id);
			}
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("			];\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("			\n{0}", _Indent);
		_Output.Write ("		foreach (var backed in Pages) {{\n{0}", _Indent);
		_Output.Write ("			ResolveReferences (backed); \n{0}", _Indent);
		_Output.Write ("			}}\n{0}", _Indent);
		_Output.Write ("		foreach (var backed in Menus) {{\n{0}", _Indent);
		_Output.Write ("			ResolveReferences (backed); \n{0}", _Indent);
		_Output.Write ("			}}\n{0}", _Indent);
		_Output.Write ("		foreach (var backed in Selectors) {{\n{0}", _Indent);
		_Output.Write ("			ResolveReferences (backed); \n{0}", _Indent);
		_Output.Write ("			}}\n{0}", _Indent);
		_Output.Write ("		foreach (var backed in Classes) {{\n{0}", _Indent);
		_Output.Write ("			ResolveReferences (backed); \n{0}", _Indent);
		_Output.Write ("			}}\n{0}", _Indent);
		_Output.Write ("		}}\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("	}}\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("// Pages\n{0}", _Indent);
		foreach  (var backer in frameset.Pages)  {
			_Output.Write ("/// <summary>\n{0}", _Indent);
			_Output.Write ("/// Backing class for {1}\n{0}", _Indent, backer.Id);
			_Output.Write ("/// </summary>\n{0}", _Indent);
			_Output.Write ("public {1} {2} : {3} {{\n{0}", _Indent, structure, backer.Id, backer.Type);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("	/// <summary>\n{0}", _Indent);
			_Output.Write ("	/// Constructor, returns a new instance\n{0}", _Indent);
			_Output.Write ("	/// </summary>\n{0}", _Indent);
			_Output.Write ("	public {1} () : base (\"{2}\", \"{3}\", _Fields) {{\n{0}", _Indent, backer.Id, backer.Id, backer.Title);
			_Output.Write ("		}}\n{0}", _Indent);
			 MakeBacking (backer);
			_Output.Write ("	}}\n{0}", _Indent);
			}
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("// Menus \n{0}", _Indent);
		foreach  (var backer in frameset.Menus)  {
			_Output.Write ("/// <summary>\n{0}", _Indent);
			_Output.Write ("/// Backing class for {1}\n{0}", _Indent, backer.Id);
			_Output.Write ("/// </summary>\n{0}", _Indent);
			_Output.Write ("public {1} {2} : {3} {{\n{0}", _Indent, structure, backer.Id, backer.Type);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("	/// <summary>\n{0}", _Indent);
			_Output.Write ("	/// Constructor, returns a new instance\n{0}", _Indent);
			_Output.Write ("	/// </summary>\n{0}", _Indent);
			_Output.Write ("	public {1} () : base (\"{2}\", _Fields) {{\n{0}", _Indent, backer.Id, backer.Id);
			_Output.Write ("		}}\n{0}", _Indent);
			 MakeBacking (backer);
			_Output.Write ("	}}\n{0}", _Indent);
			}
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("// Classes \n{0}", _Indent);
		foreach  (var backer in frameset.Selectors)  {
			_Output.Write ("/// <summary>\n{0}", _Indent);
			_Output.Write ("/// Backing class for {1}\n{0}", _Indent, backer.Id);
			_Output.Write ("/// </summary>\n{0}", _Indent);
			_Output.Write ("public {1} {2} : {3} {{\n{0}", _Indent, structure, backer.Id, backer.Type);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("	/// <summary>\n{0}", _Indent);
			_Output.Write ("	/// Constructor, returns a new instance\n{0}", _Indent);
			_Output.Write ("	/// </summary>\n{0}", _Indent);
			_Output.Write ("	public {1} () : base (\"{2}\", _Fields) {{\n{0}", _Indent, backer.Id, backer.Id);
			_Output.Write ("		}}\n{0}", _Indent);
			 MakeBacking (backer);
			_Output.Write ("	}}\n{0}", _Indent);
			}
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("// Classes \n{0}", _Indent);
		foreach  (var backer in frameset.Classes)  {
			_Output.Write ("/// <summary>\n{0}", _Indent);
			_Output.Write ("/// Backing class for {1}\n{0}", _Indent, backer.Id);
			_Output.Write ("/// </summary>\n{0}", _Indent);
			_Output.Write ("public {1} {2} : {3} {{\n{0}", _Indent, structure, backer.Id, backer.ParentId ?? backer.Type);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("	/// <summary>\n{0}", _Indent);
			_Output.Write ("	/// Constructor, returns a new instance\n{0}", _Indent);
			_Output.Write ("	/// </summary>\n{0}", _Indent);
			_Output.Write ("	public {1} (string id=\"{2}\") : base (\"{3}\") {{\n{0}", _Indent, backer.Id, backer.Id, backer.Id);
			_Output.Write ("		}}\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			//    public  #{backer.Id} (string id, List<FrameField> fields=null) : base(id) {
			//		foreach (var field in fields) {
			//			//Fields.Add (field);
			//			}
			//		}
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("    public override List<FrameField> Fields {{ get; set; }} = _Fields;\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			 MakeBacking (backer);
			_Output.Write ("	}}\n{0}", _Indent);
			}
		_Output.Write ("\n{0}", _Indent);
		foreach  (var fclass in frameset.Classes)  {
			}
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		}
	
	/// <summary>	
	/// MakeBacking
	/// </summary>
	/// <param name="backed"></param>
	public void MakeBacking (IBacked backed) {
		 var comma = new Registry.Separator (",");
		foreach  (var entry in backed.Fields)  {
			if (  (entry.Backing != null)  ) {
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("    /// <summary>Field {1}</summary>\n{0}", _Indent, entry.Id);
				_Output.Write ("	public {1}? {2} {{get; set;}}\n{0}", _Indent, entry.Backing, entry.Id);
				} else if (  (entry is FrameAvatar avatar) ) {
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("	// Avatar {1}\n{0}", _Indent, avatar.Id);
				_Output.Write ("	public string {1} => GetAvatar;\n{0}", _Indent, avatar.Id);
				} else if (  (entry is FrameRefClass refClass) ) {
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("	// ref class {1}, {2}\n{0}", _Indent, refClass.Backing, refClass.Id);
				_Output.Write ("	public {1}? {2} {{get; set;}}\n{0}", _Indent, refClass.Backing, refClass.Id);
				} else if (  (entry is FrameRefList refList) ) {
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("	// ref class {1}, {2}\n{0}", _Indent, refList.Backing, refList.Id);
				_Output.Write ("	public {1}? {2} {{get; set;}}\n{0}", _Indent, refList.Backing, refList.Id);
				}
			}
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("	static List<FrameField> _Fields = [", _Indent);
		 RenderFields(backed, backed.Fields, true);
		_Output.Write ("		];\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		foreach  (var entry in backed.Fields)  {
			if (  (entry is FramePresentation presentation)  ) {
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("	/// <summary>\n{0}", _Indent);
				_Output.Write ("	/// Presentation style {1}\n{0}", _Indent, presentation.Id);
				_Output.Write ("	/// </summary>\n{0}", _Indent);
				_Output.Write ("	public static FramePresentation {1} {{get;}} = new (\"{2}\") {{\n{0}", _Indent, presentation.Id, presentation.Id);
				_Output.Write ("		Sections = [", _Indent);
				 comma.Reset();
				foreach  (var section in presentation.Sections) {
					_Output.Write ("{1}\n{0}", _Indent, comma);
					_Output.Write ("			new FrameSection (\"{1}\") {{\n{0}", _Indent, section.Id);
					_Output.Write ("				Fields = [", _Indent);
					 var save = Indent (12);
					 RenderFields (backed, section.Fields);
					 RestoreIndent (save);
					_Output.Write ("\n{0}", _Indent);
					_Output.Write ("					]\n{0}", _Indent);
					_Output.Write ("				}}", _Indent);
					}
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("			]\n{0}", _Indent);
				_Output.Write ("		}};\n{0}", _Indent);
				}
			}
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		}
	
	/// <summary>	
	/// RenderFields
	/// </summary>
	/// <param name="backed"></param>
	/// <param name="fields"></param>
	/// <param name="parent=false"></param>
	public void RenderFields (IBacked backed, List<FrameField> fields, bool parent=false) {
		 var comma = new Registry.Separator (",");
		if (  (parent && backed.Parent is not null)  ) {
			_Output.Write ("{1}", _Indent, comma);
			 RenderFields(backed.Parent, backed.Parent.Fields);
			}
		foreach  (var entry in fields)  {
			 var id = entry.Id.Replace (".", "?.");
			 var sid = entry.Id.Replace (".", "!.");
			 switch (entry) {
			 case FrameButtonParsed button: {
			 var comma2 = new Registry.Separator (",");
			_Output.Write ("{1}\n{0}", _Indent, comma);
			_Output.Write ("		new FrameButton (\"{1}\", \"{2}\", \"{3}\") {{", _Indent, entry.Id, button.Label, button.Action);
			if (  (button.Active is not null)  ) {
				 var bid = button.Active.Replace (".", "?.");
				_Output.Write ("{1}\n{0}", _Indent, comma2);
				_Output.Write ("			GetActive = (IBacked data) => (data as {1})?.{2}", _Indent, backed.Id, bid);
				}
			if (  (button.Integer is not null)  ) {
				 var bid = button.Integer.Replace (".", "?.");
				_Output.Write ("{1}\n{0}", _Indent, comma2);
				_Output.Write ("			GetInteger = (IBacked data) => (data as {1})?.{2}", _Indent, backed.Id, bid);
				}
			if (  (button.Text is not null)  ) {
				 var bid = button.Text.Replace (".", "?.");
				_Output.Write ("{1}\n{0}", _Indent, comma2);
				_Output.Write ("			GetText = (IBacked data) => (data as {1})?.{2}", _Indent, backed.Id, bid);
				}
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("			}}", _Indent);
			 break; }
			 case FrameRefMenu reference: {
			_Output.Write ("{1}\n{0}", _Indent, comma);
			_Output.Write ("		new FrameRefMenu (\"{1}\",\"{2}\")", _Indent, entry.Id, reference.Reference);
			 break; }
			 case FrameAvatar avatar: {
			_Output.Write ("{1}\n{0}", _Indent, comma);
			_Output.Write ("		new FrameAvatar (\"{1}\"){{\n{0}", _Indent, entry.Id);
			_Output.Write ("			Get = (IBacked data) => (data as {1})?.{2} }}", _Indent, backed.Id, id);
			 break; }
			 case FrameRefClass reference: {
			_Output.Write ("{1}\n{0}", _Indent, comma);
			_Output.Write ("		new FrameRefClass<{1}> (\"{2}\",\"{3}\"){{\n{0}", _Indent, reference.Backing, entry.Id, reference.Reference);
			_Output.Write ("			Get = (IBacked data) => (data as {1})?.{2} ,\n{0}", _Indent, backed.Id, id);
			_Output.Write ("			Set = (IBacked data, IBacked? value) => {{(data as {1})!.{2} = value as {3}; }}}}", _Indent, backed.Id, sid, reference.Reference);
			 break; }
			 case FrameRefList reference: {
			_Output.Write ("{1}\n{0}", _Indent, comma);
			_Output.Write ("		new FrameRefList<{1}> (\"{2}\",\"{3}\"){{\n{0}", _Indent, reference.Reference, entry.Id, reference.Reference);
			_Output.Write ("			Get = (IBacked data) => (data as {1})?.{2} ,\n{0}", _Indent, backed.Id, id);
			_Output.Write ("			Set = (IBacked data, Object? value) => {{(data as {1})!.{2} = value as List<{3}>; }}}}", _Indent, backed.Id, sid, reference.Reference);
			 break; }
			 case FrameRef : {
			_Output.Write ("{1}\n{0}", _Indent, comma);
			_Output.Write ("		new FrameRef (\"{1}\")", _Indent, entry.Id);
			 break; }
			 case FrameSeparator : {
			_Output.Write ("{1}\n{0}", _Indent, comma);
			_Output.Write ("		new FrameSeparator (\"{1}\")", _Indent, entry.Id);
			 break; }
			 case FramePresentation presentation: {
			_Output.Write ("{1}\n{0}", _Indent, comma);
			_Output.Write ("		{1}", _Indent, presentation.Id);
			 break; }
			 case FrameSubmenu submenu: {
			_Output.Write ("{1}\n{0}", _Indent, comma);
			_Output.Write ("		new FrameSubmenu (\"{1}\", \"{2}\") {{\n{0}", _Indent, submenu.Id, submenu.Label);
			_Output.Write ("			Fields = [", _Indent);
			 var save = Indent (8);
			 RenderFields (backed, submenu.Fields);
			 RestoreIndent (save);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("				]\n{0}", _Indent);
			_Output.Write ("			}}", _Indent);
			 break; }
			 default: {
			if (  entry.Backing != null ) {
				_Output.Write ("{1}\n{0}", _Indent, comma);
				_Output.Write ("		new {1} (\"{2}\") {{\n{0}", _Indent, entry.Type, entry.Id);
				_Output.Write ("			Get = (IBacked data) => (data as {1})?.{2} ,\n{0}", _Indent, backed.Id, id);
				_Output.Write ("			Set = (IBacked data, {1}? value) => {{(data as {2})!.{3} = value; }}}}", _Indent, entry.Backing, backed.Id, sid);
				}
			 break; }
			 }
			}
		}

	}
