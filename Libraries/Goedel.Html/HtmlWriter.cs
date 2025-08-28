using System.Globalization;
using System.IO;

namespace Goedel.Html;

public class HtmlWriter {
    TextWriter TextWriter { get; set; }

    public HtmlWriter(
            TextWriter textWriter
            ) {
        TextWriter = textWriter;
        }


    public void DivStart (
                string style) {

        TextWriter.Write ( $"<div class=\"{style}\">" );

        }

    public void DivEnd() {
        TextWriter.Write($"</div>");
        }


    }
