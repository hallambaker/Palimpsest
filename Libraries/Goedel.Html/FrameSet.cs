using Goedel.Registry;

namespace Goedel.Html;



public class FrameSet {

    public List<Resource> Resources { get; set; } = null;


    public virtual string Namespace { get; set; }
    public virtual List<FramePage> Pages { get; init; } = [];
    public virtual List<FrameMenu> Menus { get; init; } = [];
    public virtual List<FrameSelector> Selectors { get; init; } = [];
    public virtual List<FrameClass> Classes { get; init; } = [];

    //public Dictionary<string, FrameField> Dictionary { get; } = [];

    public void ResolveReferences(IBacked entry) {
        entry.FrameSet = this;
        foreach (var field in entry.Fields) {
            switch (field) {
                case FrameRefMenu item: {
                    item.Menu = GetField(Menus, item.Reference);
                    break;
                    }
                case FrameRefClass item: {
                    item.Class = GetField(Classes, item.Reference);
                    break;
                    }
                }
            }


        }

    T? GetField<T>(List<T> list, string id) where T: IBacked {
        foreach (var field in list) {
            if (field.Id == id) {
                return field;
                }
            }

        return default;
        }



    public virtual string IconPath(string id) => $"Resources/Icons/{id}";

    }


public interface IBacked {
    FrameSet FrameSet { get; set; }
    ///<summary>The identifier</summary>
    string Id { get; }

    ///<summary>The fields</summary>
    List<FrameField> Fields { get; }

    string Type { get; }
    }


public class FrameBacker {

    public string Id { get; init; }
    public FrameBacker(string id) {
        Id = id;
        }


    }


public class FramePage: FrameBacker, IBacked {

    public List<Resource> Resources { get; set; } = null;

    public Resource FaviCon { get; set; } = null;
    public string PageTitle { get; set; } = null;

    public FrameSet FrameSet { get; set; }
    public string Title { get; init; }

    public virtual List<FrameField> Fields {get; init;}

    public string Type => "FramePage";

    public FramePage(string id, string title, List<FrameField> fields) : base(id) {
        Fields = fields;
        Title = title;
        }
    }

public class FrameMenu : FrameBacker, IBacked {
    public FrameSet FrameSet { get; set; }
    public virtual List<FrameField> Fields { get; init; }

    public string Type => "FrameMenu";

    public FrameMenu(string id, List<FrameField> fields) : base(id) {
        Fields = fields;
        }
    }

public class FrameSelector : FrameBacker, IBacked {
    public FrameSet FrameSet { get; set; }
    /// <inheritdoc/>
    public virtual List<FrameField> Fields { get; init; }
    public string Type => "FrameSelector";

    public FrameSelector(string id, List<FrameField> fields) : base(id) {
        Fields = fields;
        }
    }


public class FrameClass : FrameBacker, IBacked {
    public FrameSet FrameSet { get; set; }
    public string Type => "FrameClass";
    public virtual List<FrameField> Fields { get; init; }
    public FrameClass? Parent { get; init; } = null;

    public string? ParentId { get; init; } = null;

    public FrameClass(string id, List<FrameField> fields) : base(id) {
        Fields = fields;
        }
    }


// Fields
public abstract record FrameField {
    public string Id { get; init; }
    public virtual string Backing => null;

    public abstract string Type {get;}

    public FrameField(string id) {
        Id = id;
        }
    }



public record FieldButton(
                string Id,
                string Label,
                string Action) : FrameField (Id) {

    public override string Type => "FrameButton";
    }


public record FrameRef(
                    string Id) : FrameField(Id) {
    public override string Type => "FrameRef";
    }

public record FrameRefMenu(
                    string Id,
                    string Reference) : FrameRef(Id) {
    public override string Type => "FrameRefMenu";

    public FrameMenu Menu { get; set; }
    }


public record FrameRefClass(
                    string Id,
                    string Reference) : FrameRef(Id) {
    public string Backing => IsList ? $"List<{Reference}>" : Reference;

    public string Base { get; set; }

    public bool IsList { get; set; }
    public override string Type => "FrameRefClass";

    public FrameClass Class { get; set; }

    public Action<FrameBacker, Object?> Set { get; init; }
    public Func<FrameBacker, Object?> Get { get; init; }

    }




public record FrameChooser(
                string Id,
                List<FrameChooserOption> Options) : FrameField(Id) {
    public override string Type => "FrameButton";
    }
public record FrameChooserOption(
            string Id,
            string Label) {
    }

public record FrameBoolean(string Id) : FrameField(Id) {
    public override string Backing => "bool";
    public override string Type => "FrameBoolean";

    public Action<FrameBacker, bool?> Set { get; init; }
    public Func<FrameBacker, bool?> Get { get; init; }
    }
public record FrameInteger(string Id) : FrameField(Id) {
    public override string Backing => "int";
    public override string Type => "FrameInteger";

    public Action<FrameBacker, int?> Set { get; init; }
    public Func<FrameBacker, int?> Get { get; init; }
    }
public record FrameDateTime(string Id) : FrameField(Id) {
    public override string Backing => "System.DateTime";
    public override string Type => "FrameDateTime";

    public Action<FrameBacker, System.DateTime?> Set { get; init; }
    public Func<FrameBacker, System.DateTime?> Get { get; init; }
    }
public record FrameString(string Id) : FrameField(Id) {
    public override string Backing => "string";
    public override string Type => "FrameString";

    public Action<FrameBacker,string?> Set { get; init; }
    public Func<FrameBacker,string?> Get { get; init; }


    }
public record FrameText(string Id) : FrameField(Id) {
    public override string Backing => "string";
    public override string Type => "FrameText";

    public Action<FrameBacker, string?> Set { get; init; }
    public Func<FrameBacker, string?> Get { get; init; }
    }
public record FrameImage(string Id) : FrameField(Id) {
    public override string Backing => "string";
    public override string Type => "FrameImage";

    public Action<FrameBacker, string?> Set { get; init; }
    public Func<FrameBacker, string?> Get { get; init; }
    }
public record FrameCount(string Id) : FrameField(Id) {
    public override string Backing => "int";
    public override string Type => "FrameCount";

    public Action<FrameBacker, int?> Set { get; init; }
    public Func<FrameBacker, int?> Get { get; init; }
    }
public record FrameSeparator(string Id) : FrameField(Id) {
    public override string Type => "FrameSeparator";
    }