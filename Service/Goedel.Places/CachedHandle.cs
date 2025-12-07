#region // Copyright - MIT License
//  © 2024 by Phill Hallam-Baker
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

namespace Goedel.Places;





/// <summary>
/// Root class for all cachable forum items.
/// </summary>
public abstract class CachedHandle<T> : IComparable where T : CatalogedEntry{


    public T CatalogedEntry { get; }

    public string Uid => CatalogedEntry.Uid;
    public string LocalName => CatalogedEntry.LocalName;




    public CachedHandle(T catalogedEntry) {
        CatalogedEntry = catalogedEntry;
        }

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

