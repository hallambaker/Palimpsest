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


using System.ComponentModel;

namespace Goedel.Places;
public partial class CatalogedMember {

    //public string DidRaw { 
    //    get => Did.Replace('_', ':'); 
    //    set=> Did = value.Replace(':', '_'); }


    public static string DidToPrimaryKey(string did) => Udf.ContentDigestOfUDF(did, 120);


   // Hack: Should store the actual userId not recalculate it each time from the DID.

    public override string _PrimaryKey => DidToPrimaryKey(Did);

    /// <inheritdoc/>
    public override List<string>? _SecondaryKeys => new List<string>() { LocalName };


    public bool IsAdministrator { get; set; } = false;


    public bool HasPersonal => false;


    public string Display => DisplayName;

    public string DisplayHandle => LocalName ?? "Anonymous";


    }