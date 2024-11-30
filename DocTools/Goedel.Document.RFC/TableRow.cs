namespace Goedel.Document.RFC;

public class TableRow : TextBlock {
    public override string SectionText => null;
    public override BlockType BlockType => BlockType.TableRow;
    public List<TableData> Data = new();
    }
