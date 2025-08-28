using Goedel.IO;

namespace Goedel.Html;



class MainClass {
    static void Main(string[] args) {

        var parse = new FrameStruct();

        var inputfile = args[0];
        var schema = new Lexer(inputfile);


        using (var infile = inputfile.OpenFileRead()) {
            schema.Process(infile, parse);
            }

        var frameSet = new FrameSet();
        foreach (var entry in parse.Top) {
            var nameSpace = entry as Namespace;
            nameSpace?.Collect(frameSet);
            }

        using (var outfile = "NewBacking.cs".OpenTextWriterNew()) {
            var backing = new GenerateBacking() {
                _Output = outfile
                };
            backing.CreateFrame(frameSet);
            }

        var frameset = new MyClass();
        }
    }
