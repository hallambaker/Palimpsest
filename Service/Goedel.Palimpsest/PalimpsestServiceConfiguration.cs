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


using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Goedel.Palimpsest;

public class PalimpsestServiceConfiguration : ServiceConfiguration {

    ///<summary>The site name, e.g. MPlace2.</summary> 
    public string? ForumName { get; set; }

    ///<summary>The content directory</summary> 
    public string? Content { get; set; }

    ///<summary>The resources directory</summary> 
    public string? Resources { get; set; }

    ///<summary>The disk block size (used to calculate quota use)</summary> 
    public int? BlockSize { get; set; }

    ///<summary>The default quota</summary> 
    public int? DefaultQuota { get; set; }




    ///<summary>The configuration entry.</summary> 
    public static readonly ConfigurationEntry ConfigurationEntry =
        new("Palimpsest", typeof(PalimpsestServiceConfiguration),
            MeshService.Discovery, MeshService.WellKnown);

    ///<inheritdoc/>
    public override ConfigurationEntry GetConfigurationEntry() => ConfigurationEntry;


    }


public  static partial class Extensions {


    /// <summary>
    /// Inject Mesh service and options to the builder <paramref name="host"/>
    /// </summary>
    /// <param name="host">The service to inject.</param>
    /// <returns>The value of <paramref name="host"/> for chaining.</returns>

    public static IHostBuilder AddMeshService(this IHostBuilder host) {

        host.ConfigureServices((hostContext, services) => {
            var serviceConfig = hostContext.Configuration.GetSection(PalimpsestServiceConfiguration.ConfigurationEntry.Name);
            services.AddSingleton<IConfguredService, PalimpsestConfiguredService>();
            var configurationService = services.Configure<PalimpsestServiceConfiguration>(serviceConfig);
        });

        return host;
        }

    }
