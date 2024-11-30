using System.Text;
using GM = Goedel.Document.Markdown;
using Goedel.Utilities;

namespace Goedel.Document.RFC;

public class P : TextBlock {
    public override string SectionText => "Paragraph " + NumericID;
    public List<GM.TextSegment> Segments;


    public string Text => GetText();
    public override BlockType BlockType => BlockType.Paragraph;

    public P() {
        }


    public P(string Text, string ID) {
        AnchorID = ID;
        Segments ??= new List<GM.TextSegment>();
        Segments.Add(new GM.TextSegmentText(Text));
        }

    public string GetText() {
        var Buffer = new StringBuilder();

        foreach (var Segment in Segments) {
            switch (Segment) {
                case GM.TextSegmentText Text: {
                        Buffer.Append(Text.Text.XMLEscapeRFCBullies());
                        break;
                        }
                }
            }
        return Buffer.ToString();
        }

    }
