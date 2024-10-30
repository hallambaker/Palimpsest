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
/// Backing class for the project entry form.
/// </summary>
public class FormDataProject : FormData {

    ///<inheritdoc/>
    protected override FormItem[] Items => items;
    static readonly FormItem[] items = [
        new ("name", FormEntryType.String, (form, s) => ((FormDataProject)form).Name = s as string),
        new ("description", FormEntryType.String, (form, s) => ((FormDataProject)form).Description = s as string)
        ];

    ///<summary>The username.</summary> 
    public string? Name { get; private set; }
    ///<summary>User description.</summary> 
    public string? Description { get; private set; }


    }


/// <summary>
/// Backing class for the sign-in/create account entry form.
/// </summary>
public class FormDataAccount : FormData {


    ///<inheritdoc/>
    protected override FormItem[] Items => items;
    static readonly FormItem[] items = [
        new ("username", FormEntryType.String, (form, s) => ((FormDataAccount)form).Username = s as string),
        new ("password", FormEntryType.String, (form, s) => ((FormDataAccount)form).Password = s as string),
        new ("password2", FormEntryType.String, (form, s) => ((FormDataAccount)form).Password2 = s as string),
        new ("terms", FormEntryType.String, (form, s) => ((FormDataAccount)form).Terms = s as string)
        ];


    ///<summary>The username.</summary> 
    public string? Username { get; private set; }

    ///<summary>User description.</summary> 
    public string? Password { get; private set; }

    ///<summary>User description.</summary> 
    public string? Password2 { get; private set; }

    ///<summary>User description.</summary> 
    public string? Terms { get; private set; }



    public bool ValidateCreate() {
        if (Password != Password2) {
            return false;
            }
        if (Terms != "on") {
            return false;
            }
        if (Username is null || Username.Length < 5) {
            return false;
            }

        return true;
        }

    public bool ValidateSignIn() {
        if (Username is null ) {
            return false;
            }
        if (Password is null) {
            return false;
            }

        return true;
        }


    }

/// <summary>
/// Backing class for the upload document entry form.
/// </summary>
public class FormDataDocument : FormData {

    ///<inheritdoc/>
    protected override FormItem[] Items => items;
    static readonly FormItem[] items = [
        new ("name", FormEntryType.String, (form, s) => ((FormDataDocument)form).Name = s as string),
        new ("description", FormEntryType.String, (form, s) => ((FormDataDocument)form).Description = s as string),
        new ("data", FormEntryType.File, (form, s) => ((FormDataDocument)form).Data = s as FileField),
        new ("format", FormEntryType.String, (form, s) => ((FormDataDocument)form).Format = s as string)
        ];

    ///<summary>The format of the document being submitted (default to auto)</summary> 
    public string? Format { get; private set; }

    ///<summary>The file data.</summary> 
    public FileField? Data { get; private set; }

    public string? Name { get; private set; }
    ///<summary>User description.</summary> 
    public string? Description { get; private set; }
    }

/// <summary>
/// Backing class for the Comment Reaction entry form.
/// </summary>
public class FormDataComment : FormData {

    ///<inheritdoc/>
    protected override FormItem[] Items => items;
    static readonly FormItem[] items = [
        //new ("user", FormEntryType.String, (form, s) => ((FormDataComment)form).User = s as string),
        new ("semantic", FormEntryType.String, (form, s) => ((FormDataComment)form).Semantic = s as string),
        new ("comment", FormEntryType.String, (form, s) => ((FormDataComment)form).Comment = s as string)
        ];



    ///<summary></summary> 
    public string? User { get; private set; }
    ///<summary></summary> 
    public string? Semantic { get; private set; }
    ///<summary></summary> 
    public string? Comment { get; private set; }

    }


