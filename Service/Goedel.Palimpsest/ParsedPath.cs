﻿#region // Copyright - MIT License
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

public record ParsedPath {



    public string Command { get; }



    public MemberHandle? Member { get; }

    ///<summary>Holds the project ID or the static resource name</summary> 
    public string FirstId { get; }

    ///<summary>Holds the document ID.</summary> 
    public string ResourceId { get; }

    ///<summary>Holds the fragment ID.</summary> 
    public string FragmentId { get; } 

    public ParsedPath(HttpListenerRequest request, Forum forum) {

        // If signed in, set the member handle
        forum.TryGetVerifiedMemberHandle(request, out var member);
        Member = member;

        // parse the command path
        var url = request.Url.LocalPath;
        if (url == null) {
            Command = null;
            return;
            }
        var split = url.Split('/');
        if (split.Length < 2) { // must have at least initial /
            Command = null;
            return;
            }

        var extension = Path.GetExtension(split[1]);
        if (extension.Length > 0) {
            Command = "resources";
            FirstId = split[1];
            }
        else {
            Command = split[1];
            }


        if (split.Length > 2) {
            FirstId = split[2];
            }
        if (split.Length > 3) {
            ResourceId = split[3];
            }
        if (split.Length > 4) {
            FragmentId = split[4];
            }
        }

    }