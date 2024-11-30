using GM = Goedel.Document.Markdown;

namespace Goedel.Document.RFC;

/// <summary>
/// Text block class, parent for all text blocks
/// </summary>
public abstract class TextBlock {
    ///<summary>The block type</summary> 
    public abstract BlockType BlockType { get; }

    ///<summary>The anchor text.</summary> 
    public string AnchorText => GeneratedID;

    ///<summary>Generated identifier.</summary> 
    public string GeneratedID;  // The id used in <p>, <h2>, <h3>, etc.
    string anchorID;
    public string AnchorID {
        get => anchorID == "" ? null : anchorID;
        set => anchorID = value;
        }

    public string SectionId = "tbs";
    public string NumericID = "tbs";

    public string Align;

    // These are the identifiers to use in future.
    public string PnID = null; // probablyu collapse to GeneratedID

    public abstract string SectionText { get; }
    public int Line, Position;
    public int Page;



    public List<GM.TextSegment> Irefs;

    public List<GM.TextSegment> BlockName;
    }
