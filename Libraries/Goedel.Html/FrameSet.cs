using Goedel.Registry;

namespace Goedel.Html;

public class FrameSet {

    public virtual string Namespace { get; set; }
    public virtual List<FramePage> Pages { get; init; } = [];
    public virtual List<FrameMenu> Menus { get; init; } = [];
    public virtual List<FrameSelector> Selectors { get; init; } = [];
    public virtual List<FrameClass> Classes { get; init; } = [];

    //public Dictionary<string, FrameField> Dictionary { get; } = [];

    public void ResolveReferences(IBacked entry) {

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


    }


public interface IBacked {
    //public string Backing { get; }
    string Id { get; }
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

    public string Title { get; init; }

    public virtual List<FrameField> Fields {get; init;}

    public string Type => "FramePage";

    public FramePage(string id, string title, List<FrameField> fields) : base(id) {
        Fields = fields;
        Title = title;
        }
    }

public class FrameMenu : FrameBacker, IBacked {

    public virtual List<FrameField> Fields { get; init; }

    public string Type => "FrameMenu";

    public FrameMenu(string id, List<FrameField> fields) : base(id) {
        Fields = fields;
        }
    }

public class FrameSelector(string Id) : FrameBacker(Id) {
    public string Type => "FrameSelector";
    }


public class FrameClass : FrameBacker, IBacked {

    public string Type => "FrameClass";
    public virtual List<FrameField> Fields { get; init; }
    public FrameClass? Parent { get; init; } = null;

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



public record FrameButton(
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
    public override string Type => "FrameRefClass";

    public FrameClass Class { get; set; }
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