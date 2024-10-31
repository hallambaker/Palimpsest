
namespace Goedel.Document.RFC;

public interface IAnnotation {

    string User { get; }
    string MemberId { get; }

    
    string Anchor { get; }
    List<string> References { get;  }
    string Semantic { get;   }
    string Text { get;}

    bool Written { get; set; }

    }