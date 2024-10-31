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




using System.Reflection.Metadata;

namespace Goedel.Palimpsest;

/// <summary>
/// Cached handle for a project
/// </summary>
/// <param name="project">The project catalog entry</param>
public class ProjectHandle: CachedHandle<CatalogedProject> {


    CachedProjects CachedProjects { get; }


    public CatalogedProject CatalogedProject => CatalogedEntry;

    public CachedDocuments CatalogDocuments {
        get => catalogDocuments ?? 
            new CachedDocuments(this).CacheValue(out catalogDocuments);
        set => catalogDocuments = value; }
    CachedDocuments catalogDocuments;

    public string ProjectDirectory => Path.Combine(
                CachedProjects.Forum.DirectoryPath, Uid);

    public IEnumerable<CatalogedResource> Resources =>  CatalogDocuments?.GetResourceEnumerator();

    public ProjectHandle(
            CachedProjects cachedProjects,
            CatalogedProject project) : base(project) {
        CachedProjects = cachedProjects;

        Console.WriteLine($"Create Project handle");
        }


    public bool TryGetResource(string id,
              out ResourceHandle project) => CatalogDocuments.TryGetByUid(id, out project);

    public ResourceHandle AddResource(
                CatalogedResource resource,
                FileField data
                ) {
        var handle = CatalogDocuments.Create(resource);

        handle.WriteContent(data);
        return handle;
        }
        

    }

