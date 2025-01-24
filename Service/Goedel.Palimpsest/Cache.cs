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


public partial class CatalogedForumEntry {

    ///<inheritdoc/>
    public override string _PrimaryKey => Uid;

    }



public partial class CatalogedPlace {

    ///<inheritdoc/>
    public override string _PrimaryKey => LocalName;

    public string HomeUri => $"https://{LocalName}/";

    }

/// <summary>
/// Cache containing CachedHandle of type <typeparamref name="H"/> with
/// underlying catalog entry <typeparamref name="T"/>.
/// </summary>
/// <remarks>This class defines the underlying catalog store. It might
/// be desirable to define this in the subclass</remarks>
public abstract class Cache<H, T> : Disposable
            where H : CachedHandle<T>
            where T : CatalogedEntry {

    protected CatalogClass Catalog { get; }

    public Func<T, H> CreateHandle { get; protected set; }


    protected class CatalogClass : Catalog<T> {

        public CatalogClass(
                    string directory,
                    string label,
                    bool create = false) : base(directory, label, create: create) {
            }
        }



    public Cache(string directory, string label, bool create =false) {
        Catalog = new(directory, label, create: create);

        }


    SortedDictionary<string, H> Index { get; } = [];

    #region // Cache Management methods
    /// <summary>
    /// Add the item <paramref name="value"/> to the cache.
    /// </summary>
    /// <param name="value">The value to add.</param>
    public virtual void Add(H value) {
        Index.Add(value.CatalogedEntry.Uid, value);
        }

    /// <summary>
    /// Mark the item <paramref name="value"/> for removal from the 
    /// cache. Note that this is only advisory, the cache may keep
    /// the item in memory until it determines memory usage needs to be reduced.
    /// </summary>
    /// <param name="value">The value to mark for removal.</param>
    /// <exception cref="ItemDoesNotExist">The item does not exist in the cache</exception>
    public virtual void Remove(H value) {

        Index.ContainsKey(value.Key).AssertTrue(ItemDoesNotExist.Throw, value.Key);

        }
    #endregion

    #region // Catalog Management Methods

    //[Should probably be pushed to Catalog]
    public bool ValidateCreation(T entry) {
        if (Catalog.PersistenceStore.ObjectIndex.TryGetValue(entry.Uid, out _)) {
            return false;
            }
        if (Catalog.DictionaryByLocalName.TryGetValue(entry.LocalName, out _)) {
            return false;
            }
        return true;
        }

    public bool ValidateUpdate(H handle) {
        if (!Catalog.DictionaryByLocalName.TryGetValue(handle.CatalogedEntry.LocalName, 
                        out var entry)) {
            // local name not in use so it is clear
            return true;
            }
        if (handle.CatalogedEntry.Uid == entry.Uid) {
            // The local name is already assigned to this item.
            return true;
            }
        return false;
        }


    /// <summary>
    /// Add the catalog entry <paramref name="project"/> to the catalog and cache.
    /// </summary>
    /// <param name="entry">The entry data.</param>
    /// <returns>The entry handle.</returns>
    public virtual H Create(T entry) {

        // Check that the Uid and localname are unique.
        ValidateCreation(entry).AssertTrue(ItemAlreadyExists.Throw, entry.LocalName);

        var handle = CreateHandle(entry);
        // Add to the catalog and the cache.
        Catalog.New(entry);
        Add(handle);
        return handle;

        }

    /// <summary>
    /// Update the entry corresponding to <paramref name="handle"/> in the catalog
    /// if the changes are valid.
    /// </summary>
    /// <param name="handle"></param>
    /// <exception cref="ItemAlreadyExists">An item with the proposed 
    /// <see cref="CatalogedEntry.LocalName"/> already exists in the catalog under 
    /// a different object identifier.</exception>
    public void Update(H handle) {
        ValidateUpdate(handle).AssertTrue(ItemAlreadyExists.Throw, handle.LocalName);
        handle.Touch();

        // stuff
        Catalog.Update(handle.CatalogedEntry);
        }


    /// <summary>
    /// Attempt to locate the cataloged item with  <see cref="CatalogedEntry.LocalName"/>
    /// <paramref name="localName"/>
    /// and if found return the handle for that item in <paramref name="handle"/> and
    /// the value true, otherwise false and nulll.
    /// </summary>
    /// <param name="localName">The key to search for.</param>
    /// <param name="handle">Handle to the cataloged item (if found).</param>
    /// <returns>True if an entry with the specified  <see cref="CatalogedEntry.LocalName"/> 
    /// is found in the catalog, otherwise false.</returns>
    public virtual bool TryGetByLocalName(string localName, out H? handle) {
        if (!Catalog.DictionaryByLocalName.TryGetValue(localName, out var entry)) {
            handle = null;
            return false;
            }
        if (TryGetByUid(entry.Uid, out var uidHandle)) {
            handle = uidHandle;
            }
        else {
            handle = CreateHandle(entry);
            }

        return true;
        }

    /// <summary>
    /// Attempt to locate the cataloged item with <see cref="CatalogedEntry.Uid"/> 
    /// <paramref name="uid"/> and if found return the handle for that item in 
    /// <paramref name="handle"/> and the value true, otherwise false and nulll.
    /// </summary>
    /// <param name="uid">The key to search for.</param>
    /// <param name="handle">Handle to the cataloged item (if found).</param>
    /// <returns>True if an entry with the specified  <see cref="CatalogedEntry.Uid"/> is 
    /// found in the catalog, otherwise false.</returns>
    public virtual bool TryGetByUid(string uid, out H handle) {

        // we have the handle already cached.
        if (Index.TryGetValue(uid, out var indexHandle)) {
            handle = indexHandle;
            return true;
            }


        if (!Catalog.PersistenceStore.ObjectIndex.TryGetValue(uid, out var indexEntry)) {
            handle = null;
            return false;
            }

        var entry = indexEntry.JsonObject as T;
        handle = CreateHandle(entry);

        return true;
        }

    #endregion
    }
