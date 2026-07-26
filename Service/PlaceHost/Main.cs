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

using System.Runtime.InteropServices;


using static System.Net.Mime.MediaTypeNames;

namespace Goedel.Places;

internal sealed class Program {


    static readonly Dictionary<string, int> DefaultLimits = new() {
        {  "RequestSize", 100000 },
        {"PostsPerHour", 100},
        { "PostSize", 10000},
        { "CommentSize", 300},
        { "UserStorage", 10000000}
        };

    // We can decorate this with stuff later.
    static void Main(string[] args) {

        //  https://learn.microsoft.com/en-us/dotnet/core/compatibility/core-libraries/10.0/sigterm-signal-handler

        // Terminate service on receiving SIGTERM
        using var termSignalRegistration =
            PosixSignalRegistration.Create(
                PosixSignal.SIGTERM,
                (_) => Environment.Exit(0));

        // Hack: Terminate service on receiving SIGHUP
        // ToDo: Implement code to terminate the 
        using var sigHupSignalRegistration =
            PosixSignalRegistration.Create(
                PosixSignal.SIGHUP,
                (_) => Environment.Exit(0));


        Screen.ToFile("servicelog.md");
        Screen.WriteLine("# MPlace2 log");
        Screen.Flush();

        var configFile = args.Length > 0 ? args[0] : "SiteConfig.json";
        var serviceConfig = configFile.ReadFileJson<PlaceConfiguration>() ?? throw new NYI();

        var siteDirectory = serviceConfig?.Site ?? ".";


        var frameset = new MyClass() {
            Resources = [
                new Stylesheet("/Resources/stylesheet.css", "text/css")],
            EndResources = [],
            Directory = siteDirectory,
            Members = serviceConfig?.Members ?? Path.Combine(siteDirectory, "Members"),
            Logs = serviceConfig?.Logs ?? Path.Combine(siteDirectory, "Logs"),
            RepositoryFiles = serviceConfig?.Repository ?? Path.Combine(siteDirectory, "Repository"),
            ResourceFiles = serviceConfig?.Resources ?? Path.Combine(siteDirectory, "Resource"),
            RandomSeed = serviceConfig?.TestSeed ?? "",
            PrivateKeys = serviceConfig?.PrivateKeys ?? Path.Combine(siteDirectory, "Private"),
            DefaultSite = serviceConfig?.DefaultSite ?? "example.com"
            };

        frameset.SetLimits(serviceConfig?.Limits?? DefaultLimits);


        var persistPlace = new PersistPlace(frameset, serviceConfig!);

        var annotationService = new AnnotationService(frameset, persistPlace);
        annotationService.Start();
        }


    }


