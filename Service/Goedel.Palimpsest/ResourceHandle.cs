#region // Copyright - MIT License
//  © 2021 by Phill Hallam-Baker
//  
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//  
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//  
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
#endregion


namespace Goedel.Palimpsest;

/// <summary>
/// Cached handle for a forum resource
/// </summary>
/// <param name="resource">The resource catalog entry</param>
public class ResourceHandle : CachedHandle<CatalogedResource> {


    #region // Properties

    public ParsedContent ParsedContent => parsedContent ?? ReadContent().
        CacheValue(out parsedContent);
    ParsedContent parsedContent;

    public string FilePath => Path.Combine(ProjectHandle.ProjectDirectory,
                CatalogedResource.Uid + ".xml");

    CatalogReaction Reactions => reactions ?? new CatalogReaction(
        ProjectHandle.ProjectDirectory, CatalogedResource.Uid).CacheValue(out reactions);

    #region // CatalogReaction Reactions
    CatalogReaction reactions;

    private class CatalogReaction : Catalog<CatalogedReaction> {

        public CatalogReaction(
            string directory,
            string label,
            bool create = false) : base(directory, label, create: create) {
            }
        }
    #endregion


    public CatalogedResource CatalogedResource => CatalogedEntry;
    public ProjectHandle ProjectHandle { get; }

    #endregion
    #region // Constructor
    public ResourceHandle(
            CatalogedResource resource,
            ProjectHandle project) : base(resource) {

        ProjectHandle = project;

        }

    public void WriteContent(FileField data) {

        // We can do these in parallel
        Parallel.Invoke(
            () => {
                ReadContent(data.Data);
            },
            () => {
                using (var filestream = FilePath.OpenFileWrite()) {
                    filestream.Write(data.Data);
                    }
            }
            );

        }

    public ParsedContent ReadContent(byte[]? data = null) {
        parsedContent = new ParsedContentDocument();
        if (data is null) {
            parsedContent.LoadContent(FilePath);
            }
        else {
            parsedContent.LoadContent(data);
            }
        return parsedContent;
        }


    #endregion

    #region // Methods
    public void AddReaction(
            CatalogedReaction reaction) {
        Reactions.New(reaction);    
        }




    #endregion
    }


public abstract class ParsedContent {



    public void LoadContent(string filename) {
        using var stream = filename.OpenFileRead();
        LoadContent (stream);
        }

    public void LoadContent(byte[] data) {
        using var stream = new MemoryStream(data);
        LoadContent(stream);
        }


    public virtual void LoadContent(Stream stream) {
        }



    public abstract void ToHTML(TextWriter output);

    }

public class ParsedContentDocument : ParsedContent {
    public BlockDocument Document { get; } = new() {
        EmbedStylesheet = false
        };


    public override void LoadContent(Stream stream) {
        using TextReader reader = new StreamReader(stream);
        Rfc7991Parse.Parse(reader, Document);
        }

    public override void ToHTML(TextWriter output) {
        Html2RFCOut Html2RFCOut = new(output) {
            Mainscript = null,
            MainStylesheet = null,
            Stylesheets = []
            };
        Html2RFCOut.Write(Document);

        }
    }