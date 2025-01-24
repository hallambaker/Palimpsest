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

    public override string Anchor => $"/{PalimpsestConstants.Topic}/{ProjectHandle.Uid}/{CatalogedResource.Uid}";

    public string NewPost => "/" + PalimpsestConstants.CreatePost + "/" + ProjectHandle.Uid +
        "/" + CatalogedEntry.Uid;
    public string TopicDirectory { get; }

    #region // CatalogReaction Reactions
    public CatalogPosts Posts => posts ?? new CatalogPosts(
            ProjectHandle.ProjectDirectory, CatalogedEntry.Uid).CacheValue(out posts);

    CatalogPosts posts;

    public class CatalogPosts : Catalog<CatalogedPost> {

        public CatalogPosts(
            string directory,
            string label) : base(directory, label, create: true) {
            }
        }
    #endregion




    public CatalogedTopic CatalogedResource => CatalogedEntry as CatalogedTopic;
    public PlaceHandle ProjectHandle { get; }

    #endregion
    #region // Constructor
    public TopicHandle(
            CatalogedTopic resource,
            PlaceHandle project) : base(resource) {

        ProjectHandle = project;
        TopicDirectory = Path.Combine (project.ProjectDirectory, resource.Uid);
        Directory.CreateDirectory (TopicDirectory);
        }


    #endregion
    #region // Methods

    public string GetPostAnchor(CatalogedPost post) =>
        $"/{PalimpsestConstants.Post}/{ProjectHandle.Uid}/{CatalogedResource.Uid}/{post.Uid}";

    public void AddReaction(
                     CatalogedPost reaction) {
        Posts.New(reaction);
        }


    public bool TryGetPost(string postId, out PostHandle posthandle) {
        posthandle = null;
        if (Posts.TryLocate(postId, out var post)) {

            posthandle = new PostHandle(this,post);

            return true;
            }


        return false;
        }

 


    //public IEnumerable<PostHandle> GetPosts(int max = 20, int last = -1)=>
    //        new Enumerator(Posts, max, last);

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
    PlaceHandle ProjectHandle=> TopicHandle.ProjectHandle;


    public  string Anchor => $"/{PalimpsestConstants.Post}/{ProjectHandle.Uid}/{TopicHandle.Uid}/{CatalogedEntry.Uid}";

    public string NewComment => "/" + PalimpsestConstants.CreatePostComment + "/" + ProjectHandle.Uid +
        "/" + TopicHandle.Uid + "/" + CatalogedEntry.Uid;


    CatalogReactions Reactions => reactions ?? new CatalogReactions(
        TopicHandle.TopicDirectory, CatalogedEntry.Uid).CacheValue(out reactions);

    CatalogReactions reactions;




    public SortedDictionary<string, CatalogedComment> Comments => Reactions?.Comments;




    public PostHandle(
                TopicHandle topicHandle,
                CatalogedPost catalogedEntry) : base(catalogedEntry) {
        TopicHandle = topicHandle;
        }

    public void AddReaction(
                CatalogedComment reaction) {
        Reactions.New(reaction);
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