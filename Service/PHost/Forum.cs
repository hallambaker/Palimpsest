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
/// The class tracking the status of a forum, all interactions with the forum 
/// take place through this lens
/// </summary>
public class Forum {
    #region // Properties


    #endregion
    #region // Constructors and factory methods.

    /// <summary>
    /// Hidden private constructor.
    /// </summary>
    /// <param name="directory"></param>
    Forum(
                string directory) {
        }

    /// <summary>
    /// Factory method returning a newly created forum instance
    /// </summary>
    /// <returns></returns>

    public static Forum Create(
                    string directory) {
        var result =  new Forum(directory);
        throw new NYI();
        }

    /// <summary>
    /// Factory method returning a forum instance for the specified directory.
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NYI"></exception>
    public static Forum Load(
                    string directory) {
        var result = new Forum(directory);
        throw new NYI();
        }


    #endregion
    #region // Methods

    #region // Project Methods

    /// <summary>
    /// Create a project within the forum
    /// </summary>
    /// <param name="project">The project to be created.</param>
    /// <exception cref="ItemAlreadyExists">The project could not be created 
    /// because it already exists</exception>
    public void CreateProject(
                    ProjectHandle project) {


        throw new ItemAlreadyExists();
        }

    /// <summary>
    /// Gets the project associated with the specified key.
    /// </summary>
    /// <param name="id">The key of the value to get.</param>
    /// <param name="project">When this method returns, contains the project identified by
    /// the specified key, if the key is found; otherwise, null. 
    /// This parameter is passed uninitialized.</param>
    /// <returns>true if there is a project identified by
    /// specified key; otherwise, false.</returns>
    public bool TryGetProject(
                    string id,
                    out ProjectHandle project) {
        throw new NYI();
        }
    #endregion
    #region // Member Methods

    /// <summary>
    /// Create a member with authorizations related to the forum
    /// </summary>
    /// <param name="member">The member to be created.</param>
    /// <exception cref="ItemAlreadyExists">The member could not be created 
    /// because it already exists</exception>
    public void CreateMember(
                    MemberHandle member) {
        }

    /// <summary>
    /// Gets the member associated with the specified key.
    /// </summary>
    /// <param name="id">The key of the value to get.</param>
    /// <param name="project">When this method returns, contains the member identified by
    /// the specified key, if the key is found; otherwise, null. 
    /// This parameter is passed uninitialized.</param>
    /// <returns>true if there is a member identified by
    /// specified key; otherwise, false.</returns>
    public bool TryGetMember(
                    string id,
                    out MemberHandle project) {
        throw new NYI();
        }
    #endregion
    #region // Resource Methods


    /// <summary>
    /// Gets the resource associated with the specified key.
    /// </summary>
    /// <param name="id">The key of the value to get.</param>
    /// <param name="project">When this method returns, contains the resource identified by
    /// the specified key, if the key is found; otherwise, null. 
    /// This parameter is passed uninitialized.</param>
    /// <returns>true if there is a resource identified by
    /// specified key; otherwise, false.</returns>
    public bool TryGetReource(
                    string id,
                    out ResourceHandle project) {
        throw new NYI();
        }


    #endregion
    #region // Response Methods

    /// <summary>
    /// Gets the reaction associated with the specified key.
    /// </summary>
    /// <param name="id">The key of the value to get.</param>
    /// <param name="project">When this method returns, contains the reaction identified by
    /// the specified key, if the key is found; otherwise, null. 
    /// This parameter is passed uninitialized.</param>
    /// <returns>true if there is a reaction identified by
    /// specified key; otherwise, false.</returns>
    public bool TryGetReaction(
                    string id,
                    out ReactionHandle project) {
        throw new NYI();
        }



    #endregion
    #endregion
    }

/// <summary>
/// Cache containing CachedHandle of type <typeparamref name="T"/>.
/// </summary>
public class Cache<T> where T : CachedHandle {


    SortedDictionary<string, T> Index { get; }  = [];

    /// <summary>
    /// Add the item <paramref name="value"/> to the cache.
    /// </summary>
    /// <param name="value">The value to add.</param>
    public void Add(T value) {
        Index.Add(value.Key, value);
        }

    /// <summary>
    /// Mark the item <paramref name="value"/> for removal from the 
    /// cache. Note that this is only advisory, the cache may keep
    /// the item in memory until it determines memory usage needs to be reduced.
    /// </summary>
    /// <param name="value">The value to mark for removal.</param>
    /// <exception cref="ItemDoesNotExist">The item does not exist in the cache</exception>
    public void Remove(T value) {

        Index.ContainsKey(value.Key).AssertTrue(ItemDoesNotExist.Throw, value.Key);

        }
    }

/// <summary>
/// Root class for all cachable forum items.
/// </summary>
public class CachedHandle : IComparable{
    public DateTime Accessed = DateTime.Now;
    public string Key { get; private set; } = null;

    public virtual void Touch() {
        Accessed = DateTime.Now;
        }

    ///<inheritdoc/>
    public int CompareTo(object? obj) {
        return ((IComparable)Accessed).CompareTo(obj);
        }

    /// <summary>
    /// Release resources associated with the resource allowing them to
    /// be reused.
    /// </summary>
    public void Release () { 
        }
    }

public class ProjectHandle(
            CatalogedProject project) {
    public CatalogedProject CatalogedProject { get; } = project;
    }

public class MemberHandle(
            CatalogedMember member) {
    public CatalogedMember CatalogedMember { get; } = member;
    }

public class ResourceHandle(
            CatalogedResource resource,
            ProjectHandle project) {
    public CatalogedResource CatalogedResource { get; } = resource;
    public ProjectHandle ProjectHandle { get; } = project;


    public void AddReaction(
            CatalogedReaction reaction) {
        }

    }

public class ReactionHandle(

            CatalogedReaction reaction,
            ResourceHandle resource,
            ReactionHandle? parent = null) {
    public CatalogedReaction CatalogedReaction { get; } = reaction;
    public ResourceHandle Resource { get; } = resource;
    public ReactionHandle Parent { get; } = parent;
    ProjectHandle ProjectHandle => Resource.ProjectHandle;


    public void AddReaction(
            CatalogedReaction reaction) {
        }
    }
