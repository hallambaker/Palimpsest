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


using System.Collections;

namespace Goedel.Palimpsest;

/// <summary>
/// Cached handle for a forum resource
/// </summary>
/// <param name="resource">The resource catalog entry</param>
public class TopicHandle : ForumHandle {

    #region // Properties


    public string TopicDirectory { get; }

    #region // CatalogReaction Reactions
    CatalogPosts Posts => posts ?? new CatalogPosts(
            ProjectHandle.ProjectDirectory, CatalogedEntry.Uid).CacheValue(out posts);

    CatalogPosts posts;

    private class CatalogPosts : Catalog<CatalogedReaction> {

        public CatalogPosts(
            string directory,
            string label) : base(directory, label, create: true) {
            }
        }
    #endregion




    public CatalogedTopic CatalogedResource => CatalogedEntry as CatalogedTopic;
    public ProjectHandle ProjectHandle { get; }

    #endregion
    #region // Constructor
    public TopicHandle(
            CatalogedTopic resource,
            ProjectHandle project) : base(resource) {

        ProjectHandle = project;
        TopicDirectory = Path.Combine (project.ProjectDirectory, resource.Uid);
        }


    #endregion
    #region // Methods

    public void AddReaction(
                     CatalogedPost reaction) {
        //Reactions.New(reaction);
        //if (reaction is CatalogedPost annotation) {
        //    Annotations.Add(annotation);
        //    }
        }


    public bool TryGetPost(string PostId, out PostHandle posthandle) {
        posthandle = null;
        return false;
        }

    public IEnumerable<PostHandle> GetPosts(int max = 20, int last = -1)=>
            new Enumerator(Posts, max, last);

    private class Enumerator : IEnumerator<PostHandle>, IEnumerable<PostHandle> {

        public PostHandle Current { get; set; }

        object IEnumerator.Current => Current;

        public Enumerator(CatalogPosts catalog, int max = 20, int last = -1) {
            Current = null;
            }


        public void Dispose() {
            }

        public bool MoveNext() {
            return false;
            }

        public void Reset() {

            }

        public IEnumerator<PostHandle> GetEnumerator() => this;

        IEnumerator IEnumerable.GetEnumerator() => this;
        }


    #endregion
    }

public class PostHandle : CachedHandle<CatalogedPost> {

    TopicHandle TopicHandle { get; }

    CatalogReactions Reactions => reactions ?? new CatalogReactions(
        TopicHandle.TopicDirectory, CatalogedEntry.Uid).CacheValue(out reactions);

    CatalogReactions reactions;

    private class CatalogReactions : Catalog<CatalogedReaction> {

        public CatalogReactions(
            string directory,
            string label) : base(directory, label, create: true) {
            }
        }



    public PostHandle(CatalogedPost catalogedEntry) : base(catalogedEntry) {
        }

    public void AddReaction(
                string postId,
                CatalogedReaction reaction) {
        //Reactions.New(reaction);
        //if (reaction is CatalogedAnnotation annotation) {
        //    Annotations.Add(annotation);
        //    }
        }



    public IEnumerable<CatalogedPost> GetComments(int max = 20, int last = -1) =>
        new Enumerator(Reactions, max, last);

    private class Enumerator :IEnumerator<CatalogedPost>, IEnumerable<CatalogedPost> {

        public CatalogedPost Current { get; set; }

        object IEnumerator.Current => Current;

        public Enumerator(CatalogReactions catalog, int max = 20, int last = -1) {

            }


        public void Dispose() {
            }

        public bool MoveNext() {
            return false;
            }

        public void Reset() {

            }

        public IEnumerator<CatalogedPost> GetEnumerator() => this;

        IEnumerator IEnumerable.GetEnumerator() => this;
        }


    }