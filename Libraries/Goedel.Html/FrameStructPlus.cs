using Goedel.Cryptography.Nist;
using Goedel.Registry;

namespace Goedel.Html;

public partial class Namespace {



    public void Collect(FrameSet frameSet) {
        frameSet.Namespace = Id.Label;
        //foreach (var Name

        foreach (var item in Entries) {
            switch (item.Type) {
                case Page page: {
                    frameSet.Pages.Add(Collect(frameSet, item.Id, page));
                    break;
                    }
                case Menu page: {
                    frameSet.Menus.Add(CollectMenu(frameSet, item.Id.Label, page.Entries));
                    break;
                    }
                case Selector page: {
                    frameSet.Selectors.Add(Collect(frameSet, item.Id, page));
                    break;
                    }
                case Class page: {
                    frameSet.Classes.Add(Collect(frameSet, item.Id, page));
                    break;
                    }
                case SubClass page: {
                    frameSet.Classes.Add(Collect(frameSet, item.Id, page));
                    break;
                    }

                }


            }

        }

    public FramePage Collect(FrameSet frameSet, ID<_Choice> id, Page page) {
        var fields = CollectFields(frameSet, page.Entries);

        return new FramePage(id.Label, page.Title, fields);
        }

    public FrameMenu CollectMenu(FrameSet frameSet, string id, List<Field> entries) {
        var fields = CollectFields(frameSet, entries);

        return new FrameMenu(id, fields);
        }

    public FrameSelector Collect(FrameSet frameSet, ID<_Choice> id, Selector page) {
        return new FrameSelector(id.Label);
        }

    public FrameClass Collect(FrameSet frameSet, ID<_Choice> id, Class baseclass) {
        var properties = CollectProperties(frameSet, baseclass.Entries);

        return new FrameClass(id.Label, properties);
        }

    public FrameClass Collect(FrameSet frameSet, ID<_Choice> id, SubClass subclass) {
        var properties = CollectProperties(frameSet, subclass.Entries);

        return new FrameClass(id.Label, properties);
        }

    public List<FrameField> CollectFields(FrameSet frameset, List<Field> entries) {
        var result = new List<FrameField>();
        foreach (var entry in entries) {
            Collect(frameset, result, entry);
            }

        return result;
        }

    public List<FrameField> CollectProperties (FrameSet frameset, List<Property> entries) {
        var result = new List<FrameField>();
        foreach (var entry in entries) {
            Collect(frameset, result, entry);
            }
        return result;
        }

    private void Collect(FrameSet frameset, List<FrameField> result, IFieldEntry entry) {

        var label = entry.Token.Label;

        switch (entry.TypeH) {
            case Button button: {
                result.Add(new FrameButton(label, button.Title,
                    button.Action.Label));
                break;
                }
            case SubMenu menu: {
                // hack: punt on this for now
                // result.Add(CollectMenu(frameset, label, menu.Entries));
                break;
                }
            case IReference reference: {
                result.Add(GetRef(frameset, label, reference));
                break;
                }
            case Separator separator: {
                result.Add(new FrameSeparator(label));
                break;
                }
            case Chooser chooser: {
                result.Add(GetChooser(frameset, label, chooser));
                break;
                }
            case IIntrinsic field: {
                result.Add(GetIntrinsic(frameset, label, field));
                break;
                }
            default: {
                break;
                }
            }
        }

    public FrameRef? GetRef(
                FrameSet frameset, 
                string id,
                IReference reference) {

        var entry = reference.Reference.Definition as Entry;
        if (entry is null) {
            return new FrameRef(id);
            }

        switch (entry.Type) {
            case Menu menu: {
                return new FrameRefMenu(id, entry.Id.Label);
                }
            case Class: 
            case SubClass : {
                return new FrameRefClass(id, entry.Id.Label);
                }
            }
        return new FrameRef(id);


        }
    public FrameChooser GetChooser(
                FrameSet frameset,
                string id,
                Chooser chooser) {

        var options = new List<FrameChooserOption>();
        foreach (var entry in chooser.Entries) {
            options.Add(new FrameChooserOption(entry.Action.Label, entry.Title));
            }

        return new FrameChooser(id, options);
        }

    public FrameField GetIntrinsic(
            FrameSet frameset,
            string id,
            IIntrinsic field) => GetBackingFrame (id, field);

    //public string GetBackingType(IIntrinsic field) => field switch {
    //    Boolean => "bool",
    //    Integer => "int",
    //    DateTime => "DateTime",
    //    String => "string",
    //    Text => "string",
    //    Image => "string",
    //    Count => "int",
    //    _ => throw new Internal()
    //    };

    public FrameField GetBackingFrame(string id, IIntrinsic field) => field switch {
        Boolean => new FrameBoolean(id),
        Integer => new FrameInteger(id),
        DateTime => new FrameDateTime(id),
        String => new FrameString(id),
        Text => new FrameText(id),
        Image => new FrameImage(id),
        Count => new FrameCount(id),
        _ => throw new Internal()
        };



    }

public interface IFieldEntry {
    public TOKEN<_Choice> Token { get; }
    public _Choice TypeH { get; }

    }

public partial class Field : IFieldEntry {
    public TOKEN<_Choice> Token => Id;
    public _Choice TypeH => Type;
    }

public partial class Property : IFieldEntry {
    public TOKEN<_Choice> Token => Id;
    public _Choice TypeH => Type;
    }


public interface IIntrinsic {
    }

public partial class Boolean : IIntrinsic {
    }
public partial class Integer : IIntrinsic {
    }
public partial class DateTime : IIntrinsic {
    }
public partial class String : IIntrinsic {
    }
public partial class Text : IIntrinsic {
    }
public partial class Image : IIntrinsic {
    }
public partial class Count : IIntrinsic {
    }

public interface IReference {
    public REF<_Choice> Reference { get; }
    }

public partial class Is : IReference {
    public REF<_Choice> Reference => Parent;
    }

public partial class List : IReference {
    public REF<_Choice> Reference => Of;
    }

public partial class Return : IReference {
    public REF<_Choice> Reference => To;
    }
