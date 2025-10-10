using Goedel.Registry;

namespace Goedel.Html;

/// <summary>
/// Pagewriter adds in methods to emit FramePages and components.
/// </summary>
public partial class PageWriter : HtmlWriter {


    public void Render(
            IBacked backer,
            FrameRefForm item) {

        // create the form 
        OpenClass("form", item.Tag, "action", "https://httpbin.org/post", "method", "post");

        var value = item.Get(backer);
        foreach (var field in item.Class.Fields) {
            RenderFormField(value, field);
            }

        Element("input", "type", "submit", "value", PageText.Submit);
        Element("input", "type", "reset", "value", PageText.Reset);

        Close();

        }


    public void RenderFormField(

            IBacked? backer,
            IFrameField field) {



        //OpenClass("div", id);
        switch (field) {
            case FrameString item: {
                RenderForm(backer, item);
                break;
                }


            default: {
                break;
                }

            }
        //Close();
        }


    public void RenderForm(
                    IBacked? backer,
            FrameString item) {

        string? value=null;
        if (backer is not null) {
            value = item.Get(backer);
            }

        OpenClass("div", item.Tag);

        if (!item.Hidden) {
            Text(item.Prompt, "label");
            }

        var id = NormalizeId(item.Tag);
        switch (item) {
            case FrameText: {
                if (item.Hidden) {
                    Element("input", "type", "hidden", "id", id, "name", item.Tag, "value", value!);
                    }
                else {
                    Text("", "textarea", "type", "text", "id", id, "name", item.Tag, "value", value!);
                    }
                break;
                }
            case FrameRichText: {
                if (item.Hidden) {
                    Element("input", "type", "hidden", "id", id, "name", item.Tag, "value", value!);
                    }
                else {
                    Text("", "div", "id", "richtext");
                    }
                break;
                }
            default: {
                if (item.Hidden) {
                    Element("input", "type", "hidden", "id", id, "name", item.Tag, "value", value!);
                    }
                else {
                    Element("input", "type", "text", "id", item.Tag, "name", item.Tag, "value", value!);
                    }

                break;
                }
            }

        Close();

        }



    }