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
public partial class CatalogedForumMember {
    public string Anchor => $"/{PalimpsestConstants.User}/{LocalName}";



    ///<inheritdoc/>
    public override string _PrimaryKey => Did;
    public void SetPasswordDigest(
                string password,
                string username,
                string realm) {

        PasswordDigest = GetPasswordDigest(password, username, realm);


        }


    public bool VerifyPassword(
                string password,
                string username,
                string realm) {

        var digest = GetPasswordDigest(password, username, realm);

        return digest.IsEqualTo(PasswordDigest);
        }

    public static byte[] GetPasswordDigest(
            string password,
            string username,
            string realm) {

        var writer = new MemoryStream();
        Write(password);
        Write(username);
        Write(realm);
        var buffer = writer.GetBuffer();

        return SHA256.HashData(buffer);

        // write a chunk of data to the stream
        void Write (string text) {
            var bytes = text.ToBytes();
            writer.WriteByte ((byte)bytes.Length);
            writer.Write(bytes);
            }
        }



    }