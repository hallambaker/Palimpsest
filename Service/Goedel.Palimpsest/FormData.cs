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
public class FormDataAcceptTerms : FormData {


    ///<inheritdoc/>
    protected override FormItem[] Items => items;
    static readonly FormItem[] items = [
        new ("from", FormEntryType.String, (form, s) => ((FormDataAcceptTerms)form).From = s as string),
        new ("handle", FormEntryType.String, (form, s) => ((FormDataAcceptTerms)form).Handle = s as string),
        new ("agree", FormEntryType.Boolean, (form, s) => ((FormDataAcceptTerms)form).Agree = s as string)
        ];


    public bool Insist { get; set; } = false;

    ///<summary>The URL to return to.</summary> 
    public string? From { get;  set; }

    ///<summary>The username.</summary> 
    public string? Handle { get;  set; }
    ///<summary>User description.</summary> 
    public string? Agree { get; private set; }


    }



/// <summary>
/// Backing class for the project entry form.
/// </summary>
public class FormDataPlace : FormData {

    ///<inheritdoc/>
    protected override FormItem[] Items => items;
    static readonly FormItem[] items = [
        new ("name", FormEntryType.String, (form, s) => ((FormDataPlace)form).Name = s as string),
        new ("description", FormEntryType.String, (form, s) => ((FormDataPlace)form).Description = s as string)
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
        new ("from", FormEntryType.String, (form, s) => ((FormDataAccount)form).From = s as string),
        new ("handle", FormEntryType.String, (form, s) => ((FormDataAccount)form).Handle = s as string),
        new ("terms", FormEntryType.String, (form, s) => ((FormDataAccount)form).Terms = s as string)
        ];


    ///<summary>The URL to return to.</summary> 
    public string? From { get; private set; }

    ///<summary>The username.</summary> 
    public string? Handle { get; private set; }

    ///<summary>User description.</summary> 
    public string? Terms { get; private set; }


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
        new ("subject", FormEntryType.String, (form, s) => ((FormDataComment)form).Subject = s as string),
        new ("semantic", FormEntryType.String, (form, s) => ((FormDataComment)form).Semantic = s as string),
        new ("comment", FormEntryType.String, (form, s) => ((FormDataComment)form).Comment = s as string),
        new ("fragment", FormEntryType.String, (form, s) => ((FormDataComment)form).FragmentId = s as string)
        ];


    ///<summary></summary> 
    public string? Subject { get; private set; }
    ///<summary></summary> 
    public string? FragmentId { get; private set; }
    ///<summary></summary> 
    public string? Semantic { get; private set; }
    ///<summary></summary> 
    public string? Comment { get; private set; }



    }


