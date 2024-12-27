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


using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Goedel.Palimpsest;


/// <summary>
/// Service configuration
/// </summary>
public class Configuration : Disposable, IServiceConfiguration {
    ///<summary>Maps configuration entry to configuration.</summary> 
    public Dictionary<string, object> Dictionary { get; } = new();

    ///<summary>The host configuration.</summary> 
    public GenericHostConfiguration GenericHost { get; set; }


    }

/// <summary>
/// A Mesh service provider in a form suited for dependency injection.
/// </summary>
public class PalimpsestConfiguredService : Disposable, IConfguredService {


    ///<summary>The service configuration.</summary> 
    public PalimpsestServiceConfiguration MeshHostConfiguration { get; }

    ///<summary>The generic host configuration.</summary> 
    public GenericHostConfiguration GenericHostConfiguration { get; }

    IOptionsMonitor<PalimpsestServiceConfiguration> MeshHostConfigurationMonitor;
    //IMeshMachine MeshMachine { get; }

    ///<summary>The logger interface.</summary> 
    public ILogger<ManagedListener> Logger { get; }

    //PublicMeshService PublicMeshService { get; set; }

    ///<inheritdoc/>
    public JpcInterface JpcInterface => throw new NYI();

    ///<inheritdoc/>
    public List<Endpoint> Endpoints { get; }


    /// <summary>
    /// Mesh service provider instance configured with options specifie in 
    /// <paramref name="meshHostConfiguration"/> and <paramref name="genericHostConfiguration"/>.
    /// </summary>
    /// <param name="logger">The system logger service.</param>
    /// <param name="meshMachine">The Mesh machine instance.</param>
    /// <param name="hostMonitor">The host monitor for tracking host load and performance.</param>
    /// <param name="meshHostConfiguration">The Mesh service configuration.</param>
    /// <param name="genericHostConfiguration">The host configuration.</param>
    /// <param name="presenceServiceProvider">The presence service.</param>
    public PalimpsestConfiguredService(
                ILogger<ManagedListener> logger,
                IMeshMachine meshMachine,
                HostMonitor hostMonitor,
                IOptionsMonitor<PalimpsestServiceConfiguration> meshHostConfiguration,
                IOptionsMonitor<GenericHostConfiguration> genericHostConfiguration
                ) {
        //Console.WriteLine($"Start mesh");

        //MeshMachine = meshMachine;
        Logger = logger;

        MeshHostConfigurationMonitor = meshHostConfiguration;
        MeshHostConfigurationMonitor.OnChange(
            config => Register(config));


        MeshHostConfiguration = meshHostConfiguration.CurrentValue;
        GenericHostConfiguration = genericHostConfiguration.CurrentValue;

        if ((MeshHostConfiguration?.ServicePath).IsBlank()) {
            return;
            }


        var transactionLogger = new LogService
            (GenericHostConfiguration, MeshHostConfiguration, hostMonitor);

        //PublicMeshService = new PublicMeshService(MeshMachine,
        //    GenericHostConfiguration, MeshHostConfiguration, transactionLogger, presenceServiceProvider);
        //Endpoints = PublicMeshService.Endpoints;

        }

    void Register(PalimpsestServiceConfiguration meshHostConfiguration) {

        // the only thing we are going to be able to change with the service
        // running is the administrator list

        }


    }
