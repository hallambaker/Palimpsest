namespace Goedel.Places;

public partial class CatalogedPlace {

    /// <inheritdoc/>
    public override string _PrimaryKey => Uid;


    /// <inheritdoc/>
    public override List<string>? _SecondaryKeys => new List<string>() { LocalName};

    //public override bool _default => Default == true;


    }


public partial class CatalogedFeed {

    /// <inheritdoc/>
    public override string _PrimaryKey => Uid;

    public bool IsModerator (CatalogedMember member) => true;

    public bool CanPost(CatalogedMember member) => true;

    }

public partial class CatalogedPost {

    /// <inheritdoc/>
    public override string _PrimaryKey => Uid;



    }

public partial class CatalogedComment {

    /// <inheritdoc/>
    public override string _PrimaryKey => Uid;



    }