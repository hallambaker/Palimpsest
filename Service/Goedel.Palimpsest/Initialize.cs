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

using System.Runtime.CompilerServices;

#pragma warning disable IDE0079
#pragma warning disable CA2255 // The 'ModuleInitializer' attribute should not be used in libraries

namespace Goedel.Palimpsest;

///<summary>Static class whose only function is to contain the initialization 
///routine.</summary>
public static class Initialization {

    ///<summary>Initialization witness flag. This may be used to force initialization
    ///of the module prior to other modules being initialized.</summary> 
    public static bool Initialized => true;


    /// <summary>
    /// Initialization routine for cryptographic functions on the dotNet Core platform.
    /// </summary>


    [ModuleInitializer]
    public static void Initialize() {

        //Goedel.Mesh.Initialization.Initialized.AssertTrue(NYI.Throw);
        ForumItem._Initialized.AssertTrue(NYI.Throw);
        Goedel.Cryptography.Dare.Initialization.Initialized.AssertTrue(NYI.Throw);
        Goedel.Cryptography.Oauth.Initialization.Initialized.AssertTrue(NYI.Throw);
        Goedel.Mesh.Core.Initialization.Initialized.AssertTrue(NYI.Throw);
        }

    }
