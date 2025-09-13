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
		_Output.Write ("/// <summary>\n{0}", _Indent);
		_Output.Write ("/// Annotated backing classes for data driven GUI.\n{0}", _Indent);
		_Output.Write ("/// </summary>\n{0}", _Indent);
		_Output.Write ("public partial class {1} : FrameSet{{\n{0}", _Indent, className);
		foreach  (var backer in frameset.Pages)  {
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("	///<summary>{1}</summary>\n{0}", _Indent, backer.Tag);
			_Output.Write ("	public {1} {2} {{get;}} = new();\n{0}", _Indent, backer.Tag, backer.Tag);
			}
		_Output.Write ("\n{0}", _Indent);
		foreach  (var backer in frameset.Menus)  {
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("	///<summary>{1}</summary>\n{0}", _Indent, backer.Tag);
			_Output.Write ("	public {1} {2} {{get;}} = new();\n{0}", _Indent, backer.Tag, backer.Tag);
			}
		_Output.Write ("\n{0}", _Indent);
		foreach  (var backer in frameset.Selectors)  {
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("	 ///<summary>{1}</summary>\n{0}", _Indent, backer.Tag);
			_Output.Write ("	 public {1} {2} {{get;}} = new();\n{0}", _Indent, backer.Tag, backer.Tag);
			}
		_Output.Write ("\n{0}", _Indent);
		foreach  (var backer in frameset.Classes)  {
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("	 ///<summary>{1}</summary>\n{0}", _Indent, backer.Tag);
			_Output.Write ("	 public {1} {2} {{get;}} = new();\n{0}", _Indent, backer.Tag, backer.Tag);
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
			_Output.Write ("			{1}", _Indent, backer.Tag);
			}
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("			];\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		 comma.Reset();
		_Output.Write ("		Menus = [ ", _Indent);
		foreach  (var backer in frameset.Menus)  {
			_Output.Write ("{1}\n{0}", _Indent, comma);
			_Output.Write ("			{1}", _Indent, backer.Tag);
			}
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("			];\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		 comma.Reset();
		_Output.Write ("		Selectors = [ ", _Indent);
		foreach  (var backer in frameset.Selectors)  {
			_Output.Write ("{1}\n{0}", _Indent, comma);
			_Output.Write ("			{1}", _Indent, backer.Tag);
			}
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("			];\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		 comma.Reset();
		_Output.Write ("		Classes = [ ", _Indent);
		foreach  (var backer in frameset.Classes)  {
			_Output.Write ("{1}\n{0}", _Indent, comma);
			_Output.Write ("			{1}", _Indent, backer.Tag);
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
			_Output.Write ("/// Backing class for {1}\n{0}", _Indent, backer.Tag);
			_Output.Write ("/// </summary>\n{0}", _Indent);
			_Output.Write ("public {1} {2} : {3} {{\n{0}", _Indent, structure, backer.Tag, backer.Type);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("	/// <summary>\n{0}", _Indent);
			_Output.Write ("	/// Constructor, returns a new instance\n{0}", _Indent);
			_Output.Write ("	/// </summary>\n{0}", _Indent);
			_Output.Write ("	public {1} () : base (\"{2}\", \"{3}\", _Fields) {{\n{0}", _Indent, backer.Tag, backer.Tag, backer.Title);
			_Output.Write ("		}}\n{0}", _Indent);
			 MakeBacking (backer);
			_Output.Write ("	}}\n{0}", _Indent);
			}
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("// Menus \n{0}", _Indent);
		foreach  (var backer in frameset.Menus)  {
			_Output.Write ("/// <summary>\n{0}", _Indent);
			_Output.Write ("/// Backing class for {1}\n{0}", _Indent, backer.Tag);
			_Output.Write ("/// </summary>\n{0}", _Indent);
			_Output.Write ("public {1} {2} : {3} {{\n{0}", _Indent, structure, backer.Tag, backer.Type);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("	/// <summary>\n{0}", _Indent);
			_Output.Write ("	/// Constructor, returns a new instance\n{0}", _Indent);
			_Output.Write ("	/// </summary>\n{0}", _Indent);
			_Output.Write ("	public {1} () : base (\"{2}\", _Fields) {{\n{0}", _Indent, backer.Tag, backer.Tag);
			_Output.Write ("		}}\n{0}", _Indent);
			 MakeBacking (backer);
			_Output.Write ("	}}\n{0}", _Indent);
			}
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("// Classes \n{0}", _Indent);
		foreach  (var backer in frameset.Selectors)  {
			_Output.Write ("/// <summary>\n{0}", _Indent);
			_Output.Write ("/// Backing class for {1}\n{0}", _Indent, backer.Tag);
			_Output.Write ("/// </summary>\n{0}", _Indent);
			_Output.Write ("public {1} {2} : {3} {{\n{0}", _Indent, structure, backer.Tag, backer.Type);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("	/// <summary>\n{0}", _Indent);
			_Output.Write ("	/// Constructor, returns a new instance\n{0}", _Indent);
			_Output.Write ("	/// </summary>\n{0}", _Indent);
			_Output.Write ("	public {1} () : base (\"{2}\", _Fields) {{\n{0}", _Indent, backer.Tag, backer.Tag);
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
			_Output.Write ("/// Backing class for {1}\n{0}", _Indent, backer.Tag);
			_Output.Write ("/// </summary>\n{0}", _Indent);
			_Output.Write ("public {1} {2} (string Tag=\"{3}\") : {4} (Tag) {{\n{0}", _Indent, structure, backer.Tag, backer.Tag, backer.ParentId ?? backer.Type);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("    /// <inheritdoc/>\n{0}", _Indent);
			_Output.Write ("    public override List<IFrameField> Fields {{ get; set; }} = _Fields;\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			 var defaultPresentation = GetDefaultPresentation(backer.Fields);
			if (  (defaultPresentation is not null) ) {
				_Output.Write ("    /// <inheritdoc/>\n{0}", _Indent);
				_Output.Write ("    public override FramePresentation Presentation => {1};\n{0}", _Indent, defaultPresentation.Tag);
				}
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
				_Output.Write ("    /// <summary>Field {1}</summary>\n{0}", _Indent, entry.Tag);
				_Output.Write ("	public {1}? {2} {{get; set;}}\n{0}", _Indent, entry.Backing, entry.Tag);
				} else if (  (entry is FrameAvatar avatar) ) {
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("	///<summary>Avatar {1}</summary>\n{0}", _Indent, avatar.Tag);
				_Output.Write ("	public string? {1} => GetAvatar;\n{0}", _Indent, avatar.Tag);
				} else if (  (entry is FrameRefClass refClass) ) {
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("	///<summary>class {1}, {2}</summary>\n{0}", _Indent, refClass.Backing, refClass.Tag);
				_Output.Write ("	public {1}? {2} {{get; set;}}\n{0}", _Indent, refClass.Backing, refClass.Tag);
				} else if (  (entry is FrameRefList refList) ) {
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("	///<summary>List {1}</summary>\n{0}", _Indent, refList.Tag);
				_Output.Write ("	public {1}? {2} {{get; set;}}\n{0}", _Indent, refList.Backing, refList.Tag);
				}
			}
		_Output.Write ("\n{0}", _Indent);
		foreach  (var entry in backed.Fields)  {
			if (  (entry is FramePresentation presentation)  ) {
				 var storeId = presentation.Tag.Uniqueify();
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("	/// <summary>\n{0}", _Indent);
				_Output.Write ("	/// Presentation style {1}\n{0}", _Indent, presentation.Tag);
				_Output.Write ("	/// </summary>\n{0}", _Indent);
				_Output.Write ("	public static FramePresentation {1} => {2} ?? new FramePresentation (\"{3}\") {{\n{0}", _Indent, presentation.Tag, storeId, presentation.Tag);
				_Output.Write ("		GetUid = (IBacked data) => (data as {1})?.{2},\n{0}", _Indent, backed.Tag, presentation.UidField);
				_Output.Write ("		Sections = [", _Indent);
				 comma.Reset();
				foreach  (var section in presentation.Sections) {
					_Output.Write ("{1}\n{0}", _Indent, comma);
					_Output.Write ("			new FrameSection (\"{1}\") {{\n{0}", _Indent, section.Tag);
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
				_Output.Write ("		}}.CacheValue(out {1})!;\n{0}", _Indent, storeId);
				_Output.Write ("	public static FramePresentation? {1};\n{0}", _Indent, storeId);
				}
			}
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("	static readonly List<IFrameField> _Fields = [", _Indent);
		 RenderFields(backed, backed.Fields, true);
		_Output.Write ("\n{0}", _Indent);
		_Output.Write ("		];\n{0}", _Indent);
		_Output.Write ("\n{0}", _Indent);
		}
	
	/// <summary>	
	/// RenderFields
	/// </summary>
	/// <param name="backed"></param>
	/// <param name="fields"></param>
	/// <param name="parent=false"></param>
	public void RenderFields (IBacked backed, List<IFrameField> fields, bool parent=false) {
		 var comma = new Registry.Separator (",");
		if (  (parent && backed.Parent is not null)  ) {
			_Output.Write ("{1}", _Indent, comma);
			 RenderFields(backed.Parent, backed.Parent.Fields);
			}
		foreach  (var entry in fields)  {
			 var id = entry.Tag.Replace (".", "?.");
			 var sid = entry.Tag.Replace (".", "!.");
			 switch (entry) {
			 case FrameButtonParsed button: {
			 var comma2 = new Registry.Separator (",");
			_Output.Write ("{1}\n{0}", _Indent, comma);
			_Output.Write ("		new FrameButton (\"{1}\", \"{2}\", \"{3}\") {{", _Indent, entry.Tag, button.Label, button.Action);
			if (  (button.Active is not null)  ) {
				 var bid = button.Active.Replace (".", "?.");
				_Output.Write ("{1}\n{0}", _Indent, comma2);
				_Output.Write ("			GetActive = (IBinding data) => (data as {1})?.{2}", _Indent, backed.Tag, bid);
				}
			if (  (button.Integer is not null)  ) {
				 var bid = button.Integer.Replace (".", "?.");
				_Output.Write ("{1}\n{0}", _Indent, comma2);
				_Output.Write ("			GetInteger = (IBinding data) => (data as {1})?.{2}", _Indent, backed.Tag, bid);
				}
			if (  (button.Text is not null)  ) {
				 var bid = button.Text.Replace (".", "?.");
				_Output.Write ("{1}\n{0}", _Indent, comma2);
				_Output.Write ("			GetText = (IBinding data) => (data as {1})?.{2}", _Indent, backed.Tag, bid);
				}
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("			}}", _Indent);
			 break; }
			 case FrameRefMenu reference: {
			_Output.Write ("{1}\n{0}", _Indent, comma);
			_Output.Write ("		new FrameRefMenu (\"{1}\",\"{2}\")", _Indent, entry.Tag, reference.Reference);
			 break; }
			 case FrameAvatar avatar: {
			_Output.Write ("{1}\n{0}", _Indent, comma);
			_Output.Write ("		new FrameAvatar (\"{1}\"){{\n{0}", _Indent, entry.Tag);
			_Output.Write ("			Get = (IBinding data) => (data as {1})?.{2} }}", _Indent, backed.Tag, id);
			 break; }
			 case FrameRefClass reference: {
			_Output.Write ("{1}\n{0}", _Indent, comma);
			_Output.Write ("		new FrameRefClass<{1}> (\"{2}\",\"{3}\"){{\n{0}", _Indent, reference.Backing, entry.Tag, reference.Reference);
			if (  reference.PresentationId is not null ) {
				_Output.Write ("			Presentation = {1}.{2},\n{0}", _Indent, backed.Tag, reference.PresentationId);
				}
			_Output.Write ("			Get = (IBacked data) => (data as {1})?.{2} ,\n{0}", _Indent, backed.Tag, id);
			_Output.Write ("			Set = (IBacked data, IBacked? value) => {{(data as {1})!.{2} = value as {3}; }}}}", _Indent, backed.Tag, sid, reference.Reference);
			 break; }
			 case FrameRefList reference: {
			_Output.Write ("{1}\n{0}", _Indent, comma);
			_Output.Write ("		new FrameRefList<{1}> (\"{2}\",\"{3}\"){{\n{0}", _Indent, reference.Reference, entry.Tag, reference.Reference);
			_Output.Write ("			Get = (IBacked data) => (data as {1})?.{2} ,\n{0}", _Indent, backed.Tag, id);
			_Output.Write ("			Set = (IBacked data, Object? value) => {{(data as {1})!.{2} = value as List<{3}>; }}}}", _Indent, backed.Tag, sid, reference.Reference);
			 break; }
			 case FrameRef : {
			_Output.Write ("{1}\n{0}", _Indent, comma);
			_Output.Write ("		new FrameRef (\"{1}\")", _Indent, entry.Tag);
			 break; }
			 case FrameSeparator : {
			_Output.Write ("{1}\n{0}", _Indent, comma);
			_Output.Write ("		new FrameSeparator (\"{1}\")", _Indent, entry.Tag);
			 break; }
			 case FrameIcon : {
			_Output.Write ("{1}\n{0}", _Indent, comma);
			_Output.Write ("		new FrameIcon (\"{1}\")", _Indent, entry.Tag);
			 break; }
			 case FramePresentation presentation: {
			_Output.Write ("{1}\n{0}", _Indent, comma);
			_Output.Write ("		{1}", _Indent, presentation.Tag);
			 break; }
			 case FrameSubmenu submenu: {
			_Output.Write ("{1}\n{0}", _Indent, comma);
			_Output.Write ("		new FrameSubmenu (\"{1}\", \"{2}\") {{\n{0}", _Indent, submenu.Tag, submenu.Label);
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
				_Output.Write ("		new {1} (\"{2}\",\n{0}", _Indent, entry.Type, entry.Tag);
				_Output.Write ("			(IBinding data, {1}? value) => {{(data as {2})!.{3} = value; }},\n{0}", _Indent, entry.Backing, backed.Tag, sid);
				_Output.Write ("			(IBinding data) => (data as {1})?.{2})", _Indent, backed.Tag, id);
				}
			 break; }
			 }
			}
		}

	}
