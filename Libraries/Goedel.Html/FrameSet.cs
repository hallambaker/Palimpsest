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

    public virtual string IconPath(string id) => $"Resources/Icons/{id}.svg";

    }


public interface IBacked {
    FrameSet FrameSet { get; set; }
    ///<summary>The identifier</summary>
    string Id { get; }

    ///<summary>The fields</summary>
    List<FrameField> Fields { get; }

    string Type { get; }

    FrameClass? Parent { get;  }

    System.DateTime StartRender { get; set; }
    }


public class FrameBacker {
    public System.DateTime StartRender { get; set; }
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

    public FrameClass? Parent { get; init; } = null;

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

    public FrameClass? Parent { get; init; } = null;

    public FrameMenu(string id, List<FrameField> fields) : base(id) {
        Fields = fields;
        }
    }

public class FrameSelector : FrameBacker, IBacked {
    public FrameSet FrameSet { get; set; }
    /// <inheritdoc/>
    public virtual List<FrameField> Fields { get; init; }
    public string Type => "FrameSelector";

    public FrameClass? Parent { get; init; } = null;

    public FrameSelector(string id, List<FrameField> fields) : base(id) {
        Fields = fields;
        }
    }


public class FrameClass : FrameBacker, IBacked {

    public static string DefaultAvatar = "Resources/Icons/AvatarDefault.svg";

    public FrameSet FrameSet { get; set; }
    public string Type => "FrameClass";
    public virtual List<FrameField> Fields { get; set; }
    public FrameClass? Parent { get; set; } = null;

    public string? ParentId { get; init; } = null;

    public virtual string? GetAvatar => DefaultAvatar;


    public FrameClass(string id) : base(id) {
        //Fields = fields;
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

    public Func<IBacked, bool?> GetActive { get; init; }
    public Func<IBacked, int?> GetInteger { get; init; }
    public Func<IBacked, string?> GetText { get; init; }
    }

public record FrameButtonParsed(
                string Id,
                string Label,
                string Action,
                string? Active,
                string? Integer,
                string? Text) : FrameButton(Id, Label, Action) {


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
                    string Reference) : FrameRef(Id)  {
    public string Backing =>  Reference;

    public override string Type => "FrameRefClass";

    public FrameClass Class { get; set; }

    public Action<IBacked, IBacked?> Set { get; init; }
    public Func<IBacked, IBacked?> Get { get; init; }

    }

public record FrameRefClass<T>(
                    string Id,
                    string Reference) : FrameRefClass(Id, Reference) where T : FrameClass {

    public override string Type => "FrameRefClass";

    public FrameClass Class { get; set; }

    //public Action<IBacked, T?> Set { get; init; }
    //public Func<IBacked, T?> Get { get; init; }

    }

public record FrameRefList(
                    string Id,
                    string Reference) : FrameRef(Id) {


    public virtual FrameClass Item(Object? x, int index) => null;
    public virtual int Count(Object? x) => 0;

    public string Backing =>  $"List<{Reference}>" ;

    public override string Type => "FrameRefClass";

    public FrameClass Class { get; set; }

    public Action<IBacked, Object?> Set { get; init; }
    public Func<IBacked, Object?> Get { get; init; }
    }


public record FrameRefList<T>(
                    string Id,
                    string Reference) : FrameRefList(Id, Reference) where T : FrameClass {


    public override FrameClass Item(Object? x, int index) => (x as List<T>)![index];

    public override int Count(Object? x)=> (x as List<T>)!.Count;


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

    public Action<IBacked, bool?> Set { get; init; }
    public Func<IBacked, bool?> Get { get; init; }
    }
public record FrameInteger(string Id) : FrameField(Id) {
    public override string Backing => "int";
    public override string Type => "FrameInteger";

    public Action<IBacked, int?> Set { get; init; }
    public Func<IBacked, int?> Get { get; init; }
    }
public record FrameDateTime(string Id) : FrameField(Id) {
    public override string Backing => "System.DateTime";
    public override string Type => "FrameDateTime";

    public Action<IBacked, System.DateTime?> Set { get; init; }
    public Func<IBacked, System.DateTime?> Get { get; init; }
    }
public record FrameString(string Id) : FrameField(Id) {
    public override string Backing => "string";
    public override string Type => "FrameString";

    public Action<IBacked, string?> Set { get; init; }
    public Func<IBacked, string?> Get { get; init; }


    }
public record FrameText(string Id) : FrameField(Id) {
    public override string Backing => "string";
    public override string Type => "FrameText";

    public Action<IBacked, string?> Set { get; init; }
    public Func<IBacked, string?> Get { get; init; }
    }
public record FrameImage(string Id) : FrameField(Id) {
    public override string Backing => "string";
    public override string Type => "FrameImage";

    public Action<IBacked, string?> Set { get; init; }
    public Func<IBacked, string?> Get { get; init; }
    }

public record FrameAvatar(string Id) : FrameField(Id) {
    public override string Type => "FrameAvatar";

    public Func<IBacked, string?> Get { get; init; }
    }

public record FrameCount(string Id) : FrameField(Id) {
    public override string Backing => "int";
    public override string Type => "FrameCount";

    public Action<IBacked, int?> Set { get; init; }
    public Func<IBacked, int?> Get { get; init; }
    }
public record FrameSeparator(string Id) : FrameField(Id) {
    public override string Type => "FrameSeparator";
    }

public record FramePresentation(string Id) : FrameField(Id) {
    public override string Type => "FramePresentation";

    public virtual List<FrameSection> Sections { get; init; }
    }

public record FrameSection(string Id) {
    public virtual List<FrameField> Fields { get; init; }

    }

public record FrameSubmenu(
                string Id,
                string Label) : FrameField(Id) {
    public override string Type => "FrameSubmenu";
    public virtual List<FrameField> Fields { get; init; }

    }