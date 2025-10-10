using Goedel.Registry;

namespace Goedel.Html;



/// <summary>
/// Pagewriter adds in methods to emit FramePages and components.
/// </summary>
public partial class PageWriter : HtmlWriter {

    public PageText PageText { get; set;} = PageText.English;

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

        Open("div", "class", page.Tag);
        RenderFields(page);
        Close();

        Reources(page.FrameSet.EndResources);
        Reources(page.EndResources);
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

    public void Render(IBacked backer, List<IFrameField> fields) {

        if (fields != backer.Fields) {
            //throw new NYI();
            }

        backer.StartRender = System.DateTime.Now;

        foreach (var field in fields) {
            RenderField(backer, field);
            }

        }

    public void Render(IBacked backer, FramePresentation presentation) {
        OpenClass("form", presentation.Tag);
        if (presentation.GetUid != null) {
            var id = presentation.GetUid(backer);
            if (id != null) {
                Element("input", "type", "hidden", "name", "UID", "value", id);
                }
            }


        RenderSections(backer, presentation);

        Close();
        }


    public void RenderSections(IBacked backer, FramePresentation presentation) {

        foreach (var section in presentation.Sections) {

            Open("section", "class", section.Id);
            OpenClass("div", section.Id);
            Render(backer, section.Fields);
            Close();
            Close();
            }

        }


    public void RenderField(
            IBacked backer,
            IFrameField field) {

        var id = NormalizeId(field.Tag);
        //OpenClass("div", id);
        switch (field) {
            case FrameButton item: {
                Render(item, backer);
                break;
                }
            case FrameRefMenu item: {
                Render(backer, item);
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
            case FrameCount item: {
                Render(backer, item);
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
            case FrameText item: {
                Render(backer, item);
                break;
                }
            case FrameString item: {
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
            case FrameSeparator item: {
                Render(backer, item);
                break;
                }
            case FrameIcon item: {
                Render(backer, item);
                break;
                }
            case FrameSubmenu item: {
                Render(backer, item);
                break;
                }
            case FrameRefForm item: {
                Render(backer, item);
                break;
                }
            default : {
                break;
                }

            }
        //Close();
        }


    public void Render(IBacked backer, FrameRefMenu fieldRefMenu) {
        var menu = fieldRefMenu.Menu;
        var start = OpenClass("div", fieldRefMenu.Tag);

        foreach (var field in menu.Fields) {

            switch (field) {
                case FrameButton item: {
                    Render(item, backer);
                    break;
                    }
                }

            }


        Close(start);
        }


    public void Render(FrameButton button, IBacked backer) {

        var icon = button.Tag;
        if (button.GetActive is not null) {
            icon = button.GetActive(backer) == true ? icon + "Active" : icon;
            }

        var start = OpenClass("div", button.Tag);
        Open("p");
        Open ("a", "href", button.Action+".html");

        ElementClass("img", "ButtonIcon", "src", FrameSet.IconPath(icon), "alt", button.Label);
        TextClass(button.Label, "ButtonText", "div");

        if (button.GetText is not null) {
            var value = button?.GetText(backer);
            if (value is not null) {
                TextClass(value, "ButtonVar", "div");
                }
            }
        else if (button.GetInteger is not null) {
            var value = button?.GetInteger(backer).ToString();
            if (value is not null) {
                TextClass(value, "ButtonVar", "div");
                }
            }

        Close();
        Close();

        Close(start);






        //var start = OpenClass("button",  button.Tag, "type", "button");
        //ElementClass("img", "ButtonIcon", "src", FrameSet.IconPath(icon), "alt", button.Label);

        //TextClass(button.Label, "ButtonText ", "div");
        //if (button.GetText is not null) {
        //    var value = button?.GetText(backer);
        //    if (value is not null) {
        //        TextClass(value, "ButtonVar", "div");
        //        }
        //    }
        //else if (button.GetInteger is not null) {
        //    var value = button?.GetInteger(backer).ToString();
        //    if (value is not null) {
        //        TextClass(value, "ButtonVar", "div");
        //        }
        //    }
        //Close(start);
        }

    public void Render(IBacked backer, FrameSubmenu item) {


        var start = Open("div", "class", "dropdown");

        Open("button", "type", "button", "class", "dropdown-button");
        ElementClass("img", "ButtonIcon", "src", FrameSet.IconPath(item.Tag), "alt", item.Label);
        Close();

        Open("div", "class", "dropdown-content");
        foreach (var field in item.Fields) {
            if (field is FrameButton button) {
                Open("button", "type", "button", "class", "dropdown-subbutton");
                Element("img", "class", "ButtonIcon", "src", FrameSet.IconPath(button.Tag), "alt", button.Label);
                Text(button.Label, "div");
                Close();
                }
            }
        Close();

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
        Open("div", "class", item.Tag);


        var count = item.Count(value);
        var id = item.Tag + "Item";

        var last = max < 0 ? count : count.Minimum(max - first);
        for (var i = first; i < last; i++) {
            Open("div", "class", id);
            RenderFields(item.Item(value,i));
            Close();
            }

        Close();
        }


    public void Render(
                IBacked backer,
                FrameRefClass item) {
        var value = item.Get(backer);
        if (value is not null) {

            if (item.Presentation is not null) {
                OpenClassNew("section", item.Presentation.Tag );
                RenderSections(value, item.Presentation);
                Close();

                }
            else {
                RenderFields(value);
                }
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



            OpenClass("div", item.Tag);
            Text(value.ToString());
            Close();
            }
        }
    public void Render(
                IBacked backer,
                FrameInteger item) {
        var value = item.Get(backer);
        if (value is not null) {
            OpenClass("div", item.Tag);
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

            OpenClass("div", item.Tag);
            Text(result);
            Close();
            }
        }
    public void Render(
                IBacked backer,
                FrameString item) {
        var value = item.Get(backer);
        if (value is not null) {

            OpenClass("div", item.Tag);
            Text(value.ToString());
            Close();
            }
        }
    public void Render(
                IBacked backer,
                FrameText item) {
        var value = item.Get(backer) ;
        if (value is not null) {
            OpenClass("div", item.Tag);
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
            ElementClass("img", item.Tag, "src", value);
            //Close();
            }
        }

    public void Render(
                IBacked backer,
                FrameAvatar item) {
        var value = item.Get(backer);
        if (value is not null) {

            //OpenClass("div", item.Id);
            ElementClass("img", item.Tag, "src", value);
            //Close();
            }
        }
    public void Render(
            IBacked backer,
            FrameCount item) {
        var value = item.Get(backer);

        if (value is not null) {

            OpenClass("div", item.Tag);
            Text(value.ToString());
            Close();
            }
        }

    public void Render(
            IBacked backer,
            FrameIcon item) {
        var value = FrameSet.IconPath(item.Tag);
        ElementClass("img", item.Tag, "src", value);
        }


    public void Render(
            IBacked backer,
            FrameSeparator item) {
        ElementClass("hr", item.Tag);
        }

    string NormalizeId(string id) => id.Replace(".", "");
    }