using GM = Goedel.Document.Markdown;
using Goedel.Document.RFCSVG;

namespace Goedel.Document.RFC;

/// <summary>
/// Text block containing a figure.
/// </summary>
public class Figure : TextBlock {

    ///<inheritdoc/>
    public override BlockType BlockType => BlockType.Figure;
    public override string SectionText => "Figure " + NumericID;
    public string FigureID => "f-" + NumericID;

    public List<GM.TextSegment> Preamble;
    public List<GM.TextSegment> Postamble;

    public string Caption;

    public string Width;
    public string Height;

    public string Filename;

    public List<PRE> Content = new();
    public string Type;

    public SvgDocument SvgDocument = null;

    public Figure(string filename, string id, string type = "svg") {
        AnchorID = id;
        Filename = filename;
        Type = type;

        if (filename != null) {
            SvgDocument = new SvgDocument(filename);
            }

        }

    public void SaveContent(TextWriter output) {
        SvgDocument?.Save(output);
        }

    }
