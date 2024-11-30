namespace Goedel.Document.RFC;

public class TableData : TextBlock {
    public override string SectionText => null;
    public override BlockType BlockType => BlockType.TableData;
    public bool IsHeading;
    public string Text;

    // the good stuff
    public int RowSpan;
    public int ColSpan;
    public List<TextBlock> Blocks;

    }
