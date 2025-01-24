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
public class PlaceHandle: CachedHandle<CatalogedPlace>, IPage{


    CachedPlaces CachedProjects { get; }


    public CatalogedPlace CatalogedPlace => CatalogedEntry;

    public CachedDocuments CatalogForums {
        get => catalogDocuments ?? 
            new CachedDocuments(this).CacheValue(out catalogDocuments);
        set => catalogDocuments = value; }
    CachedDocuments catalogDocuments;

    public string ProjectDirectory => Path.Combine(
                CachedProjects.Forum.DirectoryPath, LocalName);

    public IEnumerable<CatalogedForum> Resources =>  CatalogForums?.GetResourceEnumerator();

    public PlaceHandle(
            CachedPlaces cachedProjects,
            CatalogedPlace project) : base(project) {
        CachedProjects = cachedProjects;

        Console.WriteLine($"Create Project handle");
        }


    public bool TryGetForum<T>(string id,
          out T resource) where T : ForumHandle{
        if (CatalogForums.TryGetByUid(id, out var forum)) {
            resource = forum as T;
            return true;
            }
        else {
            resource = null;
            return false;
            }
        }

    public bool TryGetResource(string id,
              out ResourceHandle resource) => TryGetForum(id, out resource);

    public bool TryGetTopic(string id,
          out TopicHandle resource) => TryGetForum(id, out resource);



    public ResourceHandle AddResource(
                CatalogedResource resource,
                FileField data
                ) {
        var handle = CatalogForums.Create(resource) as ResourceHandle;

        handle.WriteContent(data);
        return handle;
        }

    public TopicHandle AddTopic(
            CatalogedTopic resource
            ) {
        var handle = CatalogForums.Create(resource) as TopicHandle;
        return handle;
        }
    }

