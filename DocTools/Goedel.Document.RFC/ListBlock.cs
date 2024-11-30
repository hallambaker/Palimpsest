namespace Goedel.Document.RFC;

public class ListBlock : LI {

    public List<TextBlock> Items = new();


    public string ListType;
    public string ListStart;
    public string ListGroup;
    public string ListSpacing;

    public ListBlock() {
        }

    public ListBlock(string Text, string ID, BlockType Type, int Level) :
            base(null, ID, Type, Level) {
        }
    }
