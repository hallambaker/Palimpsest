namespace Goedel.Places;

public partial class CatalogedPlace {

    public override string _PrimaryKey => Uid;


    public override IEnumerable<string>? _SecondaryKeys => new List<string>() { LocalName};


    }
