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

        Render(page, page.Fields);

        Finish();
        }


    public void Render(IBacked backer, List<FrameField> fields) {
        backer.StartRender = System.DateTime.Now;
        Open("div", "class", backer.Id);
        foreach (var field in fields) {
            RenderField(backer, field);
            }
        Close();
        }

    public void RenderField(
            IBacked backer,
            FrameField field) {
        Open("div", "class", field.Id);
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
        Close();
        }


    public void Render(FrameRefMenu fieldRefMenu) {
        var menu = fieldRefMenu.Menu;
        //var start = Open("div", "class", fieldRefMenu.Id);

        foreach (var field in menu.Fields) {

            switch (field) {
                case FrameButton item: {
                    Render(item);
                    break;
                    }
                }

            }


        //Close(start);
        }


    public void Render(FrameButton button) {
        //var start = Open("a", "href", ".");
        var start = Open("div", "class", "ButtonBox " + button.Id);
        Open("button", "class", "Button");
        Element("img", "src", FrameSet.IconPath(button.Id), "class", "ButtonIcon");

        Text(button.Label, "div", "class", "ButtonText");
        Close();
        //Close();
        Close(start);
        }

    public void Render(
            IBacked backer) {
        Render(backer, backer.Fields);
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

        var last = max < 0 ? count : count.Minimum(max - first);
        for (var i = first; i < last; i++) {
            Open("div", "class", "ListItem");
            Render(item.Item(value,i));
            Close();
            }

        }


    public void Render(
                IBacked backer,
                FrameRefClass item) {
        var value = item.Get(backer) as IBacked;
        if (value is not null) {
            Render(value, value.Fields);
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
            Text(value.ToString(), "p", "class", "StringField");
            }
        }
    public void Render(
                IBacked backer,
                FrameInteger item) {
        var value = item.Get(backer);
        if (value is not null) {
            Text(value.ToString(), "p", "class", "StringField");
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


            Text(result, "p", "class", "StringField");
            }
        }
    public void Render(
                IBacked backer,
                FrameString item) {
        var value = item.Get(backer);
        if (value is not null) {
            Text(value, "p", "class", "StringField");
            }
        }
    public void Render(
                IBacked backer,
                FrameText item) {
        var value = item.Get(backer) ;
        if (value is not null) {
            Text(value, "p", "class", "TextField");
            }
        }
    public void Render(
                IBacked backer,
                FrameImage item) {
        var value = item.Get(backer);
        if (value is not null) {
            Element("img", "src", value, "class", item.Id);
            }
        }

    public void Render(
                IBacked backer,
                FrameAvatar item) {
        var value = item.Get(backer);
        if (value is not null) {
            Element("img", "src", value, "class", item.Id);
            }
        }
    public void Render(
            IBacked backer,
            FrameCount item) {
        var value = item.Get(backer);
        if (value is not null) {
            Text(value.ToString(), "p", "class", "StringField");
            }
        }

    public void Render(
            IBacked backer,
            FrameSeparator item) {
        Element("hr", "class", "Separator");
        }

    }