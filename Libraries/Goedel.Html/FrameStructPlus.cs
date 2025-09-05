using Goedel.Cryptography.Nist;
using Goedel.Registry;

using System.Reflection.Emit;

namespace Goedel.Html;

public partial class Namespace {



    public void Collect(FrameSet frameSet) {
        frameSet.Namespace = Id.Label;
        var dictionary = new Dictionary<string, FrameClass>();
        //foreach (var Name

        foreach (var entry in Entries) {
            switch (entry.Type) {
                case Page item: {
                    frameSet.Pages.Add(Collect(frameSet, entry.Id, item));
                    break;
                    }
                case Menu item: {
                    frameSet.Menus.Add(CollectMenu(frameSet, entry.Id.Label, item.Entries));
                    break;
                    }
                case Selector item: {
                    frameSet.Selectors.Add(Collect(frameSet, entry.Id, item));
                    break;
                    }
                case Class item: {
                    var newClass = Collect(frameSet, entry.Id, item);
                    dictionary.Add(newClass.Id, newClass);
                    frameSet.Classes.Add(newClass);
                    break;
                    }
                case SubClass item: {
                    var newClass = Collect(frameSet, entry.Id, item);
                    dictionary.Add(newClass.Id, newClass);
                    frameSet.Classes.Add(newClass);
                    break;
                    }
                }
            }


        foreach (var pair in dictionary) {
            if (pair.Value.ParentId is not null) {
                if (dictionary.TryGetValue(pair.Value.ParentId, out var parent)) {
                    pair.Value.Parent = parent;
                    }
                }

            }

        }

    public FramePage Collect(FrameSet frameSet, ID<_Choice> id, Page page) {
        var fields = CollectFields(frameSet, page.Entries);

        return new FramePage(id.Label, page.Title, fields);
        }

    public FrameMenu CollectMenu(FrameSet frameSet, string id, List<FieldItem> entries) {
        var fields = CollectFields(frameSet, entries);

        return new FrameMenu(id, fields);
        }

    public FrameSelector Collect(FrameSet frameSet, ID<_Choice> id, Selector page) {
        var fields = CollectFields(frameSet, page.Entries);
        return new FrameSelector(id.Label, fields);
        }

    public FrameClass Collect(FrameSet frameSet, ID<_Choice> id, Class baseclass) {
        var properties = CollectProperties(frameSet, baseclass.Entries);

        return new FrameClass(id.Label) {
            Fields = properties
            };
        }

    public FrameClass Collect(FrameSet frameSet, ID<_Choice> id, SubClass subclass) {
        var properties = CollectProperties(frameSet, subclass.Entries);

        return new FrameClass(id.Label) {
            ParentId = subclass.Parent.Label,
            Fields = properties
            };
        }

    public List<FrameField> CollectFields(FrameSet frameset, List<FieldItem> entries) {
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
                result.Add(GetFrameButton(frameset, label, button));
                break;
                }
            case SubMenu menu: {
                result.Add(GetSubmenu(frameset, label, menu));
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
            case Presentation presentation: {
                result.Add(GetPresentation(frameset, label, presentation));
                break;
                }
            default: {
                break;
                }
            }
        }

    public FrameButton GetFrameButton(FrameSet frameset, string label, Button button) {
        string active = null;
        string integer = null;
        string text = null;

        foreach (var entry in button.Entries) {
            switch (entry.Type) {
                case Boolean : {
                    active = entry.Id.Label;
                    break;
                    }
                case Integer : {
                    integer = entry.Id.Label;
                    break;
                    }
                case String : {
                    text = entry.Id.Label;
                    break;
                    }

                }
            
            }

        return new FrameButtonParsed(label, button.Title, button.Action.Label,
            active, integer, text);

        }


    public FrameSubmenu GetSubmenu(FrameSet frameset, string label, SubMenu submenu) {
        var fields = new List<FrameField>();
        foreach (var entry in submenu.Entries) {
            Collect(frameset, fields, entry);
            }

        return new FrameSubmenu(label, submenu.Title) { 
            Fields = fields 
            };
        }


    public FramePresentation GetPresentation(FrameSet frameset, string label, Presentation presentation) {

        var sections = new List<FrameSection> ();
        foreach (var section in presentation.Sections) {
            var fields = new List<FrameField>();
            foreach (var entry in section.Entries) {
                Collect(frameset, fields, entry);
                }

            sections.Add(new FrameSection(section.Id.Label) {
                Fields = fields
                });
            }

        var result = new FramePresentation(label) { 
                Sections = sections
                };

        return result;
        }


    string MakePath(_Choice item, string prefix="") => item switch {
        Field field => prefix + field.Id.Label,
        From from => MakePath (from.Type, prefix + from.Id.Label + "?."),
        _ => throw new Internal()
        };


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
            case SubClass: {
                return reference is List ? new FrameRefList(id, entry.Id.Label) :
                     new FrameRefClass(id, entry.Id.Label);
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

    public FrameField GetBackingFrame(string id, IIntrinsic field) => field switch {
        Boolean => new FrameBoolean(id),
        Integer => new FrameInteger(id),
        DateTime => new FrameDateTime(id),
        String => new FrameString(id),
        Text => new FrameText(id),
        Image => new FrameImage(id),
        Avatar => new FrameAvatar(id),
        Count => new FrameCount(id),
        _ => throw new Internal()
        };

    }

public interface IFieldEntry {
    public TOKEN<_Choice> Token { get; }
    public _Choice TypeH { get; }

    }

public partial class FieldItem : IFieldEntry {
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
public partial class Avatar : IIntrinsic {
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
