namespace Goedel.Places;

public partial class CatalogedPlace {

    /// <inheritdoc/>
    public override string _PrimaryKey => Uid;


    /// <inheritdoc/>
    public override IEnumerable<string>? _SecondaryKeys => new List<string>() { LocalName};


    }


public partial class CatalogedFeed {

    /// <inheritdoc/>
    public override string _PrimaryKey => Uid;



    }

public partial class CatalogedPost {

    /// <inheritdoc/>
    public override string _PrimaryKey => Uid;



    }

public partial class CatalogedComment {

    /// <inheritdoc/>
    public override string _PrimaryKey => Uid;



    }