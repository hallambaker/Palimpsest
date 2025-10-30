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


using Goedel.Palimpsest;
using Goedel.Sitebuilder;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//using Windows.ApplicationModel.DataTransfer;

using static System.Net.Mime.MediaTypeNames;

namespace Goedel.Places;

internal sealed class Program {

    // We can decorate this with stuff later.
    static void Main(string[] args) {

        //Goedel.Palimpsest.Initialization.Initialized.AssertTrue(NYI.Throw);

        var directory = args[0];
        var resources = args[1];

        //var forum = Forum.Create(directory, resources, "MPlace2");

        Screen.ToFile("servicelog.md");
        Screen.WriteLine("# MPlace2 log");
        Screen.Flush();

        var persistPlace = new PersistPlace();


        var frameset = new MyClass() {
            Resources = [
                new Stylesheet("Resources/stylesheet.css", "text/css")],
            EndResources = [],
            Directory = directory,
            ResourceFiles = resources
            };

        //    frameset.Resources = [
        //        new Stylesheet("Resources/stylesheet.css", "text/css"),
        //        new Stylesheet("Resources/quill.css", "text/css"),
        //        new Stylesheet("https://cdn.jsdelivr.net/npm/quill@2.0.3/dist/quill.snow.css", "text/css")
        //        ];
        //    frameset.EndResources = [
        //        new Script("https://cdn.jsdelivr.net/npm/quill@2.0.3/dist/quill.js","text/javascript"),
        //        new Script("Resources/quill.js","text/javascript")
        //];


        var annotationService = new AnnotationService(frameset, persistPlace);
        annotationService.Start();
        }

    }


