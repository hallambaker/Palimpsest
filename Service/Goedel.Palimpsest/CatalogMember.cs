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
/// Cached catalog of members
/// </summary>
public class CachedMembers : Cache<MemberHandle, CatalogedForumMember> {

    public Forum Forum { get; }

    public CachedMembers(
                Forum forum,
                string directory,
                bool create = false) : base(
                    directory, PalimpsestConstants.StoreTypeMembersTag, create) {
        Forum = forum;
        CreateHandle = Factory;
        }


    private MemberHandle Factory(CatalogedForumMember catalogedEntry)
                => new(catalogedEntry);


    //public bool TryGetByHandleUncached(string handle, out MemberHandle? catalogedForumMember) {
    //    if (TryGetByLocalName(handle, out var item)) {
    //        catalogedForumMember = item.CatalogedMember;
    //        return true;
    //        }
    //    catalogedForumMember = null;
    //    return false;
    //    }


    public bool TryGetByUidUncached(string id, out CatalogedForumMember? catalogedForumMember) {
        if (!Catalog.PersistenceStore.ObjectIndex.TryGetValue(id, out var indexEntry)) {
            catalogedForumMember = null;
            return false;
            }
        catalogedForumMember = indexEntry.JsonObject as CatalogedForumMember;
        return true;
        }
    }


