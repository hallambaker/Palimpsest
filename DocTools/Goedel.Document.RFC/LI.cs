namespace Goedel.Document.RFC;

public class LI : P {
    public BlockType Type;
    public int Level;
    public int Index;

    public string Format;
    public string Group;
    public string Spacing;

    public string EnclosingAnchorID;
    public List<TextBlock> Content;

    public string Empty => Format == "empty" ? "true" : null;

    public override BlockType BlockType => Type;

    public LI(string Text, string ID, BlockType Type, int Level) :
                base(Text, ID) {
        this.Type = Type; this.Level = Level;
        }

    public LI() {
        }


    public LI(string Text, string ID, BlockType Type, int Level, int Index) :
                this(Text, ID, Type, Level) => this.Index = Index;
    }
