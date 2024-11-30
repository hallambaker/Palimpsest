namespace Goedel.Document.RFC;

public class Table : TextBlock {
    public override string SectionText => "Table " + NumericID;
    public override BlockType BlockType => BlockType.Table;
    public string Caption;

    public int MaxRow = 0;
    public List<int> Percent = new();
    public List<int> Width = new();
    public List<TableRow> Head = new();
    public List<List<TableRow>> Body = new();
    public List<TableRow> Foot = new();
    }
