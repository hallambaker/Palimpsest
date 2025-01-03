﻿#region // Copyright - MIT License
//  © 2024 by Phill Hallam-Baker
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




using Microsoft.Extensions.Configuration;

namespace phostadmin;





/// <summary>
/// The command shell.
/// </summary>
public partial class Shell : _Shell {


    /// <summary>
    /// Dispatch command line instruction with arguments <paramref name="args"/> and
    /// error output <paramref name="console"/>.
    /// </summary>
    /// <param name="args">The command line arguments.</param>
    /// <param name="console">Error output stream.</param>
    public void Dispatch(string[] args, TextWriter console) {
        var commandLineInterpreter = new CommandLineInterpreter();
        Output = console;

        if (NoCatch) {
            commandLineInterpreter.MainMethod(this, args);
            }
        else {
            try {
                commandLineInterpreter.MainMethod(this, args);
                }
            catch (Goedel.Command.ParserException) {
                CommandLineInterpreterBase.Brief(
                CommandLineInterpreter.Description,
                CommandLineInterpreter.DefaultCommand,
                CommandLineInterpreter.Entries);
                }
            catch (System.Exception Exception) {
                console.WriteLine("Application: {0}", Exception.Message);
                if (Exception.InnerException != null) {
                    console.WriteLine(Exception.InnerException.Message);
                    }
                }
            }
        }
    ///<inheritdoc/>
    public override void _PreProcess(Goedel.Command.Dispatch dispatch) {
        base._PreProcess(dispatch);
        Verbosity = Verbosity.Standard;
        if (dispatch is IReporting reporting) {
            if (reporting.Json.Value) {
                Verbosity = Verbosity.Json;
                }
            else if (!reporting.Report.Value) {
                Verbosity = Verbosity.None;
                }
            else if (reporting.Verbose.Value) {
                Verbosity = Verbosity.Full;
                }
            }
        }

#pragma warning disable IDE1006 // Naming Styles
    /// <summary>
    /// Perform post processing of the result of the shell operation.
    /// </summary>
    /// <param name="shellResult">The result returned by the operation.</param>
    public virtual void _PostProcess(ShellResult shellResult) {

        switch (Verbosity) {
            case Goedel.Command.Verbosity.Json: {
                Output.Write(shellResult.GetJson(false));
                break;
                }
            default: {
                var builder = new StringBuilder();
                shellResult.ToBuilder(builder, Verbosity);
                Output.Write(builder.ToString());
                break;
                }
            }

        }
    /// <summary>
    /// Dispatch method
    /// </summary>
    /// <param name="options">The command line options.</param>
    /// <returns>Mesh result instance</returns>
    public override ShellResult About(About options) {

        if (options.Where.Value) {
            Verbosity = Verbosity.Full;
            }

        var compilationDate = Script.AssemblyBuildTime;

        return new ResultAbout() {
            Success = true,
            DirectoryKeys = MeshMachine?.DirectoryKeys,
            DirectoryMesh = MeshMachine?.DirectoryMesh,
            AssemblyTitle = Script.AssemblyTitle,
            AssemblyDescription = Script.AssemblyDescription,
            AssemblyCopyright = Script.AssemblyCopyright,
            AssemblyCompany = Script.AssemblyCompany,
            AssemblyVersion = Script.AssemblyVersion,
            Build = Script.LocalizeTime(compilationDate, false)
            };
        }

    ///<summary>The Mesh Machine (Must support client catalog)</summary> 
    public IMeshMachineClient? MeshMachine { get; init; }


    string? GetMultiConfig(_File file) =>
        MeshMachine?.GetService(PalimpsestConfiguredService.DefaultConfiguration, file.Value);



    ///<inheritdoc/>
    public override ShellResult Create(Create Options) {
        var multiConfig = GetMultiConfig(Options.MultiConfig);
        multiConfig.AssertNotNull(NYI.Throw);

        var serviceDns = Options.ServiceDns.Value ?? Dns.GetHostName();
        var hostIp = Options.HostIp.Value ?? "127.0.0.1:15099";
        var hostDns = Options.HostDns.Value ?? serviceDns;
        var admin = Options.Admin.Value;
        var runAs = Options.Account.Value;

        var configuration = new PalimpsestConfiguration();
        if (MeshMachine is not null) {
            //configuration.CreateConfig(MeshMachine, serviceDns, hostIp, hostDns, runAs);
            }

        //Console.WriteLine($" Description is {configuration.GenericHost.Description}");
        //if (true) {
        //    configuration.Add(
        //        MeshServiceConfiguration.Create(
        //                    MeshMachine,
        //                    configuration.GenericHost,
        //                    serviceDns));
        //    }

        //if (registry != null) {
        //    configuration.Add(
        //        CallsignRegistryConfiguration.Create(
        //                    MeshMachine,
        //                    registry));
        //    configuration.Add(
        //        CallsignResolverConfiguration.Create(
        //        MeshMachine,
        //        configuration.GenericHost,
        //        registry,
        //        resolver));
        //    }
        //if (carnet != null) {
        //    configuration.Add(
        //        CarnetServiceConfiguration.Create(
        //                    MeshMachine,
        //                    configuration.GenericHost,
        //                    carnet));
        //    }
        //if (persist != null) {
        //    configuration.Add(
        //        RepositoryServiceConfiguration.Create(
        //                    MeshMachine,
        //                    configuration.GenericHost,
        //                    persist));
        //    }
        //if (presence != null) {
        //    configuration.Add(
        //        PresenceServiceConfiguration.Create(
        //                    MeshMachine,
        //                    configuration.GenericHost,
        //                    presence));
        //    }

        // Perform the actual initialization of everything
        //MeshMachine.BuildConfiguration(configuration, admin);
        //Console.WriteLine($" DeviceUdf is {configuration.GenericHost.DeviceUdf}");

        multiConfig.MakePath();
        (configuration as IServiceConfiguration).ToFile(multiConfig);

        //// here populate a status response from configuration

        return new ResultServiceConfiguration() {
            Configuration = configuration
            };


        }


    ///<inheritdoc/>
    public override ShellResult DNS(DNS Options) {

        throw new NYI();
        //var multiConfig = GetMultiConfig(Options.MultiConfig);
        //var dnsConfig = Options.DnsConfig.Value;

        //var configuration = Configuration.FromFile(multiConfig);

        //DnsConfiguration.BindConfig(configuration, dnsConfig);
        //return new ResultServiceConfiguration() {
        //    Configuration = configuration
        //    };
        }

    ///<inheritdoc/>
    public override ShellResult Netsh(Netsh Options) {
        throw new NYI();
        //var multiConfig = GetMultiConfig(Options.MultiConfig);
        //var netshconfig = Options.NetshConfig.Value;

        //var configuration = Configuration.FromFile(multiConfig);

        //DnsConfiguration.NetshConfig(configuration, netshconfig);
        //return new ResultServiceConfiguration() {
        //    Configuration = configuration
        //    };
        }


    }
