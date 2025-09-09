using Goedel.Registry;

namespace Goedel.Html;

/// <summary>
/// Pagewriter adds in methods to emit FramePages and components.
/// </summary>
public class PageWriter : HtmlWriter {

    FrameSet FrameSet { get; }

    public PageWriter(
            FrameSet frameset,
            TextWriter textWriter
            ) : base(textWriter) {
        FrameSet = frameset;
        }

    public void Render(FramePage page) {

        page.StartRender = System.DateTime.Now;
        // Basics, title and favicon
        Head(page.PageTitle ?? page.Title, page.FaviCon);

        // Stylesheets and scripts with usual defaults
        Reources(page.FrameSet.Resources);
        Reources(page.Resources);

        Body();

        Open("div", "class", page.Id);
        RenderFields(page);
        Close();

        Finish();
        }


    public void RenderFields(IBacked backer) {

        if (backer.Presentation != null) {
            Render(backer, backer.Presentation);
            }
        else {
            Render(backer, backer.Fields);
            }
        }

    public void Render(IBacked backer, List<FrameField> fields) {

        if (fields != backer.Fields) {
            //throw new NYI();
            }

        backer.StartRender = System.DateTime.Now;

        foreach (var field in fields) {
            RenderField(backer, field);
            }

        }

    public void Render(IBacked backer, FramePresentation presentation) {
        OpenClass("form", presentation.Id);
        if (presentation.GetUid != null) {
            var id = presentation.GetUid(backer);
            if (id != null) {
                Element("input", "type", "hidden", "name", "UID", "value", id);
                }
            }


        foreach (var section in presentation.Sections) {

            Open("section", "class", section.Id);
            OpenClass("div", section.Id);
            Render(backer, section.Fields);
            Close();
            Close();
            }

        Close();
        }


    public void RenderField(
            IBacked backer,
            FrameField field) {

        var id = NormalizeId(field.Id);
        //OpenClass("div", id);
        switch (field) {
            case FrameButton item: {
                Render(item);
                break;
                }
            case FrameRefMenu item: {
                Render(item);
                break;
                }
            case FrameRefClass item: {
                Render(backer,item);
                break;
                }
            case FrameRefList item: {
                Render(backer,item);
                break;
                }
            case FrameChooser item: {
                Render(backer, item);
                break;
                }
            case FrameBoolean item: {
                Render(backer,item);
                break;
                }
            case FrameInteger item: {
                Render(backer, item);
                break;
                }
            case FrameDateTime item: {
                Render(backer, item);
                break;
                }
            case FrameString item: {
                Render(backer, item);
                break;
                }
            case FrameText item: {
                Render(backer, item);
                break;
                }
            case FrameImage item: {
                Render(backer, item);
                break;
                }
            case FrameAvatar item: {
                Render(backer, item);
                break;
                }
            case FrameCount item: {
                Render(backer, item);
                break;
                }
            case FrameSeparator item: {
                Render(backer, item);
                break;
                }
            }
        //Close();
        }


    public void Render(FrameRefMenu fieldRefMenu) {
        var menu = fieldRefMenu.Menu;
        var start = OpenClass("div", fieldRefMenu.Id);

        foreach (var field in menu.Fields) {

            switch (field) {
                case FrameButton item: {
                    Render(item);
                    break;
                    }
                }

            }


        Close(start);
        }


    public void Render(FrameButton button) {

        var start = OpenClass("button",  button.Id, "type", "button");
        ElementClass("img", "ButtonIcon ", "src", FrameSet.IconPath(button.Id), "alt", button.Label);
        TextClass(button.Label, "ButtonText ", "div");
        Close(start);
        }



    public void Render(
                IBacked backer,
                FrameRefList item, 
                int max= -1, 
                int first=0) {


        var value = item.Get(backer);
        if (value is null) {
            return;
            }

        var count = item.Count(value);
        var id = item.Id + "Item";

        var last = max < 0 ? count : count.Minimum(max - first);
        for (var i = first; i < last; i++) {
            Open("div", "class", id);
            RenderFields(item.Item(value,i));
            Close();
            }

        }


    public void Render(
                IBacked backer,
                FrameRefClass item) {
        var value = item.Get(backer) as IBacked;
        if (value is not null) {
            RenderFields(value);
            }
        }


    public void Render(
                IBacked backer,
                FrameChooser item) {
        }
    public void Render(
                IBacked backer,
                FrameBoolean item) {
        var value = item.Get(backer);
        if (value is not null) {
            OpenClass("div", item.Id);
            Text(value.ToString());
            Close();
            }
        }
    public void Render(
                IBacked backer,
                FrameInteger item) {
        var value = item.Get(backer);
        if (value is not null) {
            OpenClass("div", item.Id);
            Text(value.ToString());
            Close();
            }
        }
    public void Render(
                IBacked backer,
                FrameDateTime item) {
        var value = item.Get(backer);
        if (value is not null ) {
            var interval = (backer.StartRender - (System.DateTime)value);

            string result = "?";
            if (interval.Days > 365) {
                result = (interval.Days / 365).ToString() + "yr";
                }
            else if (interval.Days > 30) {
                result = (interval.Days / 30).ToString() + "mo";
                }
            else if (interval.Days > 7) {
                result = (interval.Days / 7).ToString() + "w";
                }
            else if (interval.Days > 0) {
                result = (interval.Days).ToString() + "d";
                }
            else if (interval.Minutes > 0) {
                result = (interval.Minutes).ToString() + "m";
                }
            else {
                result = (interval.Minutes).ToString() + "s";
                }

            OpenClass("div", item.Id);
            Text(result);
            Close();
            }
        }
    public void Render(
                IBacked backer,
                FrameString item) {
        var value = item.Get(backer);
        if (value is not null) {

            OpenClass("div", item.Id);
            Text(value.ToString());
            Close();
            }
        }
    public void Render(
                IBacked backer,
                FrameText item) {
        var value = item.Get(backer) ;
        if (value is not null) {

            OpenClass("div", item.Id);
            Text(value.ToString());
            Close();
            }
        }
    public void Render(
                IBacked backer,
                FrameImage item) {
        var value = item.Get(backer);
        if (value is not null) {

            //OpenClass("div", item.Id);
            ElementClass("img", item.Id, "src", value);
            //Close();
            }
        }

    public void Render(
                IBacked backer,
                FrameAvatar item) {
        var value = item.Get(backer);
        if (value is not null) {

            //OpenClass("div", item.Id);
            ElementClass("img", item.Id, "src", value);
            //Close();
            }
        }
    public void Render(
            IBacked backer,
            FrameCount item) {
        var value = item.Get(backer);

        if (value is not null) {

            OpenClass("div", item.Id);
            Text(value.ToString());
            Close();
            }
        }

    public void Render(
            IBacked backer,
            FrameSeparator item) {
        ElementClass("hr", item.Id);
        }

    string NormalizeId(string id) => id.Replace(".", "");
    }