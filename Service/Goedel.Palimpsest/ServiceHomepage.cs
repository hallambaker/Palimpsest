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

using Goedel.Mesh;

using Microsoft.Extensions.Hosting;



namespace Goedel.Palimpsest;




public partial class AnnotationService {

    /// <summary>
    /// Home page for an empty forum.
    /// login prompt.
    /// </summary>
    /// <param name="path">The parsed request context data.</param>
    /// <returns>Task return.</returns>
    public async Task HomePageForumEmpty(
                ParsedPath path) {
        var annotations = Annotations.Get(this, path);

        annotations.StartPage(Forum.Name);
        annotations.PageHomeForum(path.Uri.IdnHost);
        annotations.End();

        await Task.CompletedTask;
        }


    /// <summary>
    /// Home page for the forum when signed out. Consists of just the splash screen and a
    /// login prompt.
    /// </summary>
    /// <param name="path">The parsed request context data.</param>
    /// <returns>Task return.</returns>
    public async Task HomePageForumSignedOut (
                ParsedPath path) {
        var annotations = Annotations.Get(this, path);

        annotations.StartPage(Forum.Name);
        annotations.PageHomeForum();
        annotations.End();

        await Task.CompletedTask;
        }

    public async Task HomePageForumSignedIn(
                ParsedPath path) {
        // list of places, list of topics, list of documents, etc

        var annotations = Annotations.Get(this, path);
        await GetPlacePage(path, annotations, annotations.PagePlace);
        }

    public async Task HomePagePlace(
                ParsedPath path) {
        var annotations = Annotations.Get(this, path);
        await GetPlacePage(path, annotations, annotations.PagePlace);
        }








    }