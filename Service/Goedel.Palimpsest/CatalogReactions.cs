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


public partial class CatalogedComment : IComparable {
    public int CompareTo(object? obj) {
        var compare = obj as CatalogedComment;

        if (compare is null) {
            return -1;
            }
        if (Added == compare.Added) {
            return 0;
            }
        return Added > compare.Added ? -1 : 1;

        }
    }


public class CatalogReactions : Catalog<CatalogedReaction> {

    public SortedDictionary<string,CatalogedComment> Comments { get; } = [];




    public CatalogReactions(
        string directory,
        string label) : base(directory, label, create: true) {




        }


    //public override void Intern(
    //        SequenceIndexEntry indexEntry) {
    //    base.Intern(indexEntry);
    //    if (indexEntry.JsonObject is CatalogedComment comment) {
    //        Comments.Add(comment.Uid, comment);
    //        }
    //    }

    protected override void UpdateEntry(CatalogedReaction catalogedEntry) {
        //base.UpdateEntry(catalogedEntry);

        if (catalogedEntry is CatalogedComment comment) {
            Comments.Add(comment.Uid, comment);
            }

        }
    }
