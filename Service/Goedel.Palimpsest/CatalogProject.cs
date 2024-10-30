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
/// Cached catalog of projects.
/// </summary>
public class CachedProjects : Cache<ProjectHandle, CatalogedProject> {

    public Forum Forum { get; }

    /// <summary>
    /// Constructor, return an instance of the projects catalog writing persistent
    /// data to <paramref name="directory"/>.
    /// </summary>
    /// <param name="directory">The directory of the peristence store.</param>
    public CachedProjects(
                Forum forum,
                string directory,
                bool create=false) : base(
                    directory, PalimpsestConstants.StoreTypeProjectsTag, create) {
        Forum = forum;
        CreateHandle = Factory;

        Console.WriteLine($"Create Catalog Projects");

        }

    private ProjectHandle Factory(CatalogedProject catalogedEntry)
            => new(this, catalogedEntry);



    public IEnumerable<CatalogedProject> GetProjectEnumerator() {
        var projects = new List<CatalogedProject>();

        foreach (var project in Catalog) {
            projects.Add(project);
            }


        return projects;
        }


    }