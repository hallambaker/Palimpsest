using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Goedel.Html;


/// <summary>
/// 
/// </summary>
/// <param name="Uri">The resource locator.</param>
/// <param name="Type">The icon type</param>
public record Resource(
            string Uri,
            string Type,
            string? Integrity = null) {
    }

public record Script(
            string Uri,
            string Type,
            string? Integrity = null) : Resource(Uri, Type, Integrity) {
    }

public record Stylesheet(
            string Uri,
            string Type,
            string? Integrity = null) : Resource(Uri, Type, Integrity) {
    }


public record Element(string Tag) {
    }


public enum DocumentType {
    XHTML=0
    }



public class HtmlWriter {
    
    public bool Indent { get; set; } = true;
    
    protected TextWriter TextWriter { get; set; }


    Stack<Element> Elements = [];


    public string[] DocumentTypes = [
        "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\">"
        ];

    public HtmlWriter(
            TextWriter textWriter
            ) {
        TextWriter = textWriter;
        }

    void StartElement(string tag) {
        if (Indent) {
            for (var i = 0; i < Elements.Count; i++) {
                TextWriter.Write("  ");
                }
            }
        TextWriter.Write($"<{tag}");
        }

    void WriteAttributes(string[] attributes) {
        for (var i= 0; i+1 < attributes.Length; i+=2) {
            if (attributes[i + 1] is not null) {
                TextWriter.Write(" ");
                TextWriter.Write(attributes[i]);
                TextWriter.Write("=\"");
                TextWriter.Write(attributes[i + 1]);
                TextWriter.Write("\"");
                }
            }
        }
    public int Element(string tag, params string[] attributes) {
        StartElement(tag);
        WriteAttributes(attributes);
        TextWriter.WriteLine("/>");
        return Elements.Count-1;
        }

    /// <summary>
    /// Start an element <paramref name="tag"/> with attribute value pairs from
    /// <paramref name="attributes"/>.
    /// </summary>
    /// <param name="tag">The tag.</param>
    /// <param name="attributes">The attributes.</param>
    /// <returns>The stack position.</returns>
    public int Open(string tag, params string[] attributes) {
        StartElement(tag);
        Elements.Push(new(tag));
        WriteAttributes(attributes);
        TextWriter.WriteLine(">");
        return Elements.Count-1;
        }

    public void Text(string text) {
        TextWriter.Write(text);
        }

    public void Text(string tag, string text, params string[] attributes) {
        Open(tag, attributes);
        TextWriter.Write(text);

        Close();
        }


    /// <summary>
    /// Close the immediately preceding 
    /// </summary>
    public void Close(int position = -1) {
        (position < 0 | position == Elements.Count-1).AssertTrue(Internal.Throw,"XML nesting incorrect.");

        var tag = Elements.Pop();
        TextWriter.WriteLine($"</{tag.Tag}>");
        }


    int positionMain;
    public void Head(
                string title,
                Resource faviCon,
                DocumentType docType = DocumentType.XHTML, 
                string language = "en") {
        TextWriter.WriteLine(DocumentTypes[(int)docType]);
        Open("html", "lang", language);
        positionMain = Open("head");
        Element("meta", "charset", "utf-8");
        Text("title", title);
        if (faviCon is not null) {
            Element("link", "rel", "icon", "type", faviCon.Type, "href", faviCon.Uri);
            }
        }
    public void Body() {
        Close(positionMain);
        positionMain = Open("body");
        }
    public void Finish() {
        Close(positionMain);
        Close(0);
        }


    public void Reources(List<Resource>? resources) {
        foreach (var resource in resources.IfEnumerable()) {
            switch (resource) {
                case Stylesheet stylesheet: {
                    Element("link", "rel", "stylesheet", "type", resource.Type, "href", resource.Uri);
                    break;
                    }
                case Script script: {
                    Element("script", "type", resource.Type, "href", resource.Uri, "integrity", resource.Integrity);
                    break;
                    }
                }

            }
        }

    }



/// <summary>
/// Pagewriter adds in methods to emit FramePages and components.
/// </summary>
public class PageWriter : HtmlWriter {

    FrameSet FrameSet { get; }

    public PageWriter(
            FrameSet frameset,
            TextWriter textWriter
            ) : base(textWriter) {
        FrameSet = frameset;
        }

    public void Render(FramePage page) {

        // Basics, title and favicon
        Head(page.PageTitle ?? page.Title, page.FaviCon);

        // Stylesheets and scripts with usual defaults
        Reources(page.FrameSet.Resources);
        Reources(page.Resources);

        Body();

        Render(page, page.Fields);

        Finish();
        }


    public void Render(IBacked backer, List<FrameField> fields) {
        foreach (var field in fields) {
            RenderField(backer, field);
            }
        }

    public void RenderField(
            IBacked backer,
            FrameField field) {
        Open("div", "class", field.Id);
        switch (field) {
            case FrameRefMenu item: {
                Render(item);
                break;
                }
            case FrameRefClass item: {
                Render(backer,item);
                break;
                }
            case FrameRefList item: {
                RenderField(backer,item);
                break;
                }
            case FrameChooser item: {
                Render(backer, item);
                break;
                }
            case FrameBoolean item: {
                Render(backer,item);
                break;
                }
            case FrameInteger item: {
                Render(backer, item);
                break;
                }
            case FrameDateTime item: {
                Render(backer, item);
                break;
                }
            case FrameString item: {
                Render(backer, item);
                break;
                }
            case FrameText item: {
                Render(backer, item);
                break;
                }
            case FrameImage item: {
                Render(backer, item);
                break;
                }
            case FrameCount item: {
                Render(backer, item);
                break;
                }
            case FrameSeparator item: {
                Render(backer, item);
                break;
                }
            }
        Close();
        }


    public void Render(FrameRefMenu fieldRefMenu) {
        var menu = fieldRefMenu.Menu;
        var start = Open("div", "class", fieldRefMenu.Id);

        foreach (var field in menu.Fields) {

            switch (field) {
                case FrameButton item: {
                    Render(item);
                    break;
                    }
                }

            }


        Close(start);
        }


    public void Render(FrameButton button) {
        var start = Open("div", "class", "Button " + button.Id);
        Open("p");
        Element("img", "src", FrameSet.IconPath(button.Id), "class", "ButtonIcon");
        Close();
        Open("div");
        Text(button.Label, "class", "ButtonText");
        Close();
        Close(start);
        }

    public void Render(
            IBacked backer) {
        Render(backer, backer.Fields);
        }

    public void Render(
                IBacked backer,
                FrameRefList item, 
                int max= -1, 
                int first=0) {


        var value = item.Get(backer);
        var count = item.Count(value);

        var last = max < 0 ? count : count.Minimum(max - first);
        for (var i = first; i < last; i++) {
            Render(item.Item(value,i));
            }
        }


    public void Render(
                IBacked backer,
                FrameRefClass item) {
        }
    public void Render(
                IBacked backer,
                FrameChooser item) {
        }
    public void Render(
                IBacked backer,
                FrameBoolean item) {
        }
    public void Render(
                IBacked backer,
                FrameInteger item) {
        }
    public void Render(
                IBacked backer,
                FrameDateTime item) {
        }
    public void Render(
                IBacked backer,
                FrameString item) {
        }
    public void Render(
                IBacked backer,
                FrameText item) {
        }
    public void Render(
                IBacked backer,
                FrameImage item) {
        }

    public void Render(
            IBacked backer,
            FrameCount item) {
        }

    public void Render(
            IBacked backer,
            FrameSeparator item) {
        }

    }