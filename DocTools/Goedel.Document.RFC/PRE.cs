using System.Text;

using GM = Goedel.Document.Markdown;

namespace Goedel.Document.RFC;

public class PRE : P {

    public string Element;

    public string Language;
    public string Filename;
    public string OutputFile;
    public string Alt;

    public override BlockType BlockType => BlockType.Verbatim;
    public PRE() : base() {

        }
    public PRE(string Text, string ID) : base(Text, ID) {

        }

    public string TextSegments => FromSegments(Segments);

    string FromSegments(List<GM.TextSegment> Segments) {
        var Builder = new StringBuilder();

        foreach (var Segment in Segments) {
            switch (Segment) {
                case GM.TextSegmentText TextSegmentText:
                    Builder.Append(TextSegmentText.Text);
                    break;
                }
            }

        return Builder.ToString();
        }

    }
