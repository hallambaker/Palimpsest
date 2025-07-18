﻿
//  This file was automatically generated at 7/14/2025 5:27:00 PM
//   
//  Changes to this file may be overwritten without warning
//  
//  Generator:  commandparse version 3.0.0.978
//      Goedel Script Version : 0.1   Generated 
//      Goedel Schema Version : 0.1   Generated
//  
//      Copyright : © 2015-2021
//  
//  Build Platform: Win32NT 10.0.26100.0
//  
//  
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Goedel.Command;
using Goedel.Utilities;
#pragma warning disable IDE0079
#pragma warning disable IDE1006
#pragma warning disable CS1591

namespace phostadmin;



public partial class CommandLineInterpreter : CommandLineInterpreterBase {
        



	/// <summary>The command entries</summary>
    public static SortedDictionary<string, DescribeCommand> Entries { get; set; }
	/// <summary>The default command.</summary>
	public static DescribeCommandEntry DefaultCommand { get; set; }
	/// <summary>Description of the comman</summary>
	public static string Description { get; set; } = "<Not specified>";

	static readonly char UnixFlag = '-';
	static readonly char WindowsFlag = '/';

    /// <summary>
    /// Default help dispatch
    /// </summary>
    /// <param name="Dispatch">The command description.</param>
    /// <param name="args">The set of arguments.</param>
    /// <param name="index">The first unparsed argument.</param>
    public static void Help (DispatchShell Dispatch, string[] args, int index) =>
        Brief(Description, DefaultCommand, Entries);

    public readonly static DescribeCommandEntry DescribeHelp = new () {
        Identifier = "help",
        HandleDelegate = Help,
        Entries = new () { }
        };





    static CommandLineInterpreter () {
        System.OperatingSystem OperatingSystem = System.Environment.OSVersion;

        if (OperatingSystem.Platform == PlatformID.Unix |
                OperatingSystem.Platform == PlatformID.MacOSX) {
            FlagIndicator = UnixFlag;
            }
        else {
            FlagIndicator = WindowsFlag;
            }

			Description = "Palimpsest Service Administration tool";

		Entries = new   () {
			{"about", _About._DescribeCommand },
			{"create", _Create._DescribeCommand },
			{"dns", _DNS._DescribeCommand },
			{"netsh", _Netsh._DescribeCommand },
			{"help", DescribeHelp }
			}; // End Entries



        }



    public void MainMethod(string[] Args) {
		Shell Dispatch = new ();

		try {
			MainMethod (Dispatch, Args);
			}
        catch (Goedel.Command.ParserException) {
			Brief(Description, DefaultCommand, Entries);
			}
        catch (System.Exception Exception) {
            Console.WriteLine("Application: {0}", Exception.Message);
            }
		}


    public void MainMethod(Shell Dispatch, string[] Args) =>
		Dispatcher (Entries, DefaultCommand, Dispatch, Args, 0);




	public static void Handle_About (
				DispatchShell  DispatchIn, string[] Args, int Index) {
		Shell Dispatch =	DispatchIn as Shell;
		About		Options = new ();
		ProcessOptions (Args, Index, Options);
		Dispatch._PreProcess (Options);
		var result = Dispatch.About (Options);
		Dispatch._PostProcess (result);
		}

	public static void Handle_Create (
				DispatchShell  DispatchIn, string[] Args, int Index) {
		Shell Dispatch =	DispatchIn as Shell;
		Create		Options = new ();
		ProcessOptions (Args, Index, Options);
		Dispatch._PreProcess (Options);
		var result = Dispatch.Create (Options);
		Dispatch._PostProcess (result);
		}

	public static void Handle_DNS (
				DispatchShell  DispatchIn, string[] Args, int Index) {
		Shell Dispatch =	DispatchIn as Shell;
		DNS		Options = new ();
		ProcessOptions (Args, Index, Options);
		Dispatch._PreProcess (Options);
		var result = Dispatch.DNS (Options);
		Dispatch._PostProcess (result);
		}

	public static void Handle_Netsh (
				DispatchShell  DispatchIn, string[] Args, int Index) {
		Shell Dispatch =	DispatchIn as Shell;
		Netsh		Options = new ();
		ProcessOptions (Args, Index, Options);
		Dispatch._PreProcess (Options);
		var result = Dispatch.Netsh (Options);
		Dispatch._PostProcess (result);
		}


} // class Main


// The stub class for carrying optional parameters for each command type
// As with the main class each consists of an abstract main class 
// with partial virtual that can be extended as required.

// All subclasses inherit from the abstract classes Goedel.Regisrty.Dispatch 
// and Goedel.Command.Type

public interface IReporting {
	Flag			Verbose{get; set;}
	Flag			Report{get; set;}
	Flag			Json{get; set;}
	}


public class _About : Goedel.Command.Dispatch ,
						IReporting{

	public override Goedel.Command.Type[] _Data {get; set;} = new Goedel.Command.Type[] {
		new Flag (),
		new Flag (),
		new Flag (),
		new Flag ()		} ;





	/// <summary>Field accessor for option [verbose]</summary>
	public virtual Flag Verbose {
		get => _Data[0] as Flag;
		set => _Data[0]  = value;
		}

	public virtual string _Verbose {
		set => _Data[0].Parameter (value);
		}
	/// <summary>Field accessor for option [report]</summary>
	public virtual Flag Report {
		get => _Data[1] as Flag;
		set => _Data[1]  = value;
		}

	public virtual string _Report {
		set => _Data[1].Parameter (value);
		}
	/// <summary>Field accessor for option [json]</summary>
	public virtual Flag Json {
		get => _Data[2] as Flag;
		set => _Data[2]  = value;
		}

	public virtual string _Json {
		set => _Data[2].Parameter (value);
		}
	/// <summary>Field accessor for option [where]</summary>
	public virtual Flag Where {
		get => _Data[3] as Flag;
		set => _Data[3]  = value;
		}

	public virtual string _Where {
		set => _Data[3].Parameter (value);
		}
	public override DescribeCommandEntry DescribeCommand {get; set;} = _DescribeCommand;

	public readonly static DescribeCommandEntry _DescribeCommand = new   () {
		Identifier = "about",
		Brief =  "Report version and compilation date.",
		HandleDelegate =  CommandLineInterpreter.Handle_About,
		Lazy =  false,
		Entries = new List<DescribeEntry> () {
			new DescribeEntryOption () {
				Identifier = "Verbose", 
				Default = "false", // null if null
				Brief = "Verbose reports (default)",
				Index = 0,
				Key = "verbose"
				},
			new DescribeEntryOption () {
				Identifier = "Report", 
				Default = "true", // null if null
				Brief = "Report output (default)",
				Index = 1,
				Key = "report"
				},
			new DescribeEntryOption () {
				Identifier = "Json", 
				Default = "false", // null if null
				Brief = "Report output in JSON format",
				Index = 2,
				Key = "json"
				},
			new DescribeEntryOption () {
				Identifier = "Where", 
				Default = "false", // null if null
				Brief = "Report location of configuration files.",
				Index = 3,
				Key = "where"
				}
			}
		};

	}

public partial class About : _About {
    } // class About

public class _Create : Goedel.Command.Dispatch ,
						IReporting{

	public override Goedel.Command.Type[] _Data {get; set;} = new Goedel.Command.Type[] {
		new Flag (),
		new Flag (),
		new Flag (),
		new String (),
		new String (),
		new String (),
		new String (),
		new String (),
		new ExistingFile (),
		new String ()		} ;





	/// <summary>Field accessor for option [verbose]</summary>
	public virtual Flag Verbose {
		get => _Data[0] as Flag;
		set => _Data[0]  = value;
		}

	public virtual string _Verbose {
		set => _Data[0].Parameter (value);
		}
	/// <summary>Field accessor for option [report]</summary>
	public virtual Flag Report {
		get => _Data[1] as Flag;
		set => _Data[1]  = value;
		}

	public virtual string _Report {
		set => _Data[1].Parameter (value);
		}
	/// <summary>Field accessor for option [json]</summary>
	public virtual Flag Json {
		get => _Data[2] as Flag;
		set => _Data[2]  = value;
		}

	public virtual string _Json {
		set => _Data[2].Parameter (value);
		}
	/// <summary>Field accessor for parameter []</summary>
	public virtual String ServiceDns {
		get => _Data[3] as String;
		set => _Data[3]  = value;
		}

	public virtual string _ServiceDns {
		set => _Data[3].Parameter (value);
		}
	/// <summary>Field accessor for option [hostconfig]</summary>
	public virtual String HostConfig {
		get => _Data[4] as String;
		set => _Data[4]  = value;
		}

	public virtual string _HostConfig {
		set => _Data[4].Parameter (value);
		}
	/// <summary>Field accessor for option [ip]</summary>
	public virtual String HostIp {
		get => _Data[5] as String;
		set => _Data[5]  = value;
		}

	public virtual string _HostIp {
		set => _Data[5].Parameter (value);
		}
	/// <summary>Field accessor for option [host]</summary>
	public virtual String HostDns {
		get => _Data[6] as String;
		set => _Data[6]  = value;
		}

	public virtual string _HostDns {
		set => _Data[6].Parameter (value);
		}
	/// <summary>Field accessor for option [admin]</summary>
	public virtual String Admin {
		get => _Data[7] as String;
		set => _Data[7]  = value;
		}

	public virtual string _Admin {
		set => _Data[7].Parameter (value);
		}
	/// <summary>Field accessor for option [config]</summary>
	public virtual ExistingFile MultiConfig {
		get => _Data[8] as ExistingFile;
		set => _Data[8]  = value;
		}

	public virtual string _MultiConfig {
		set => _Data[8].Parameter (value);
		}
	/// <summary>Field accessor for option [account]</summary>
	public virtual String Account {
		get => _Data[9] as String;
		set => _Data[9]  = value;
		}

	public virtual string _Account {
		set => _Data[9].Parameter (value);
		}
	public override DescribeCommandEntry DescribeCommand {get; set;} = _DescribeCommand;

	public readonly static DescribeCommandEntry _DescribeCommand = new   () {
		Identifier = "create",
		Brief =  "Initialize a new Mesh service and administration account",
		HandleDelegate =  CommandLineInterpreter.Handle_Create,
		Lazy =  false,
		Entries = new List<DescribeEntry> () {
			new DescribeEntryOption () {
				Identifier = "Verbose", 
				Default = "false", // null if null
				Brief = "Verbose reports (default)",
				Index = 0,
				Key = "verbose"
				},
			new DescribeEntryOption () {
				Identifier = "Report", 
				Default = "true", // null if null
				Brief = "Report output (default)",
				Index = 1,
				Key = "report"
				},
			new DescribeEntryOption () {
				Identifier = "Json", 
				Default = "false", // null if null
				Brief = "Report output in JSON format",
				Index = 2,
				Key = "json"
				},
			new DescribeEntryParameter () {
				Identifier = "ServiceDns", 
				Default = null, // null if null
				Brief = "The DNS address of the service",
				Index = 3,
				Key = ""
				},
			new DescribeEntryOption () {
				Identifier = "HostConfig", 
				Default = null, // null if null
				Brief = "The host configuration name (defaults to mmmsettings.json)",
				Index = 4,
				Key = "hostconfig"
				},
			new DescribeEntryOption () {
				Identifier = "HostIp", 
				Default = null, // null if null
				Brief = "The external IP address of the host.",
				Index = 5,
				Key = "ip"
				},
			new DescribeEntryOption () {
				Identifier = "HostDns", 
				Default = null, // null if null
				Brief = "The DNS address of the host for service configuration",
				Index = 6,
				Key = "host"
				},
			new DescribeEntryOption () {
				Identifier = "Admin", 
				Default = null, // null if null
				Brief = "The administrator account address, also default for the host domain.",
				Index = 7,
				Key = "admin"
				},
			new DescribeEntryOption () {
				Identifier = "MultiConfig", 
				Default = "HostsAndServices", // null if null
				Brief = "The configuration file, is created if necessary",
				Index = 8,
				Key = "config"
				},
			new DescribeEntryOption () {
				Identifier = "Account", 
				Default = null, // null if null
				Brief = "The account under which the service is to run (defaults to account executing command).",
				Index = 9,
				Key = "account"
				}
			}
		};

	}

public partial class Create : _Create {
    } // class Create

public class _DNS : Goedel.Command.Dispatch ,
						IReporting{

	public override Goedel.Command.Type[] _Data {get; set;} = new Goedel.Command.Type[] {
		new Flag (),
		new Flag (),
		new Flag (),
		new NewFile (),
		new String (),
		new ExistingFile ()		} ;





	/// <summary>Field accessor for option [verbose]</summary>
	public virtual Flag Verbose {
		get => _Data[0] as Flag;
		set => _Data[0]  = value;
		}

	public virtual string _Verbose {
		set => _Data[0].Parameter (value);
		}
	/// <summary>Field accessor for option [report]</summary>
	public virtual Flag Report {
		get => _Data[1] as Flag;
		set => _Data[1]  = value;
		}

	public virtual string _Report {
		set => _Data[1].Parameter (value);
		}
	/// <summary>Field accessor for option [json]</summary>
	public virtual Flag Json {
		get => _Data[2] as Flag;
		set => _Data[2]  = value;
		}

	public virtual string _Json {
		set => _Data[2].Parameter (value);
		}
	/// <summary>Field accessor for parameter []</summary>
	public virtual NewFile DnsConfig {
		get => _Data[3] as NewFile;
		set => _Data[3]  = value;
		}

	public virtual string _DnsConfig {
		set => _Data[3].Parameter (value);
		}
	/// <summary>Field accessor for parameter []</summary>
	public virtual String HostConfig {
		get => _Data[4] as String;
		set => _Data[4]  = value;
		}

	public virtual string _HostConfig {
		set => _Data[4].Parameter (value);
		}
	/// <summary>Field accessor for option [config]</summary>
	public virtual ExistingFile MultiConfig {
		get => _Data[5] as ExistingFile;
		set => _Data[5]  = value;
		}

	public virtual string _MultiConfig {
		set => _Data[5].Parameter (value);
		}
	public override DescribeCommandEntry DescribeCommand {get; set;} = _DescribeCommand;

	public readonly static DescribeCommandEntry _DescribeCommand = new   () {
		Identifier = "dns",
		Brief =  "Compute the DNS configuration from the service config.",
		HandleDelegate =  CommandLineInterpreter.Handle_DNS,
		Lazy =  false,
		Entries = new List<DescribeEntry> () {
			new DescribeEntryOption () {
				Identifier = "Verbose", 
				Default = "false", // null if null
				Brief = "Verbose reports (default)",
				Index = 0,
				Key = "verbose"
				},
			new DescribeEntryOption () {
				Identifier = "Report", 
				Default = "true", // null if null
				Brief = "Report output (default)",
				Index = 1,
				Key = "report"
				},
			new DescribeEntryOption () {
				Identifier = "Json", 
				Default = "false", // null if null
				Brief = "Report output in JSON format",
				Index = 2,
				Key = "json"
				},
			new DescribeEntryParameter () {
				Identifier = "DnsConfig", 
				Default = null, // null if null
				Brief = "The file to write the DNS configuration to",
				Index = 3,
				Key = ""
				},
			new DescribeEntryParameter () {
				Identifier = "HostConfig", 
				Default = null, // null if null
				Brief = "The host configuration name",
				Index = 4,
				Key = ""
				},
			new DescribeEntryOption () {
				Identifier = "MultiConfig", 
				Default = "HostsAndServices", // null if null
				Brief = "The configuration file, is created if necessary",
				Index = 5,
				Key = "config"
				}
			}
		};

	}

public partial class DNS : _DNS {
    } // class DNS

public class _Netsh : Goedel.Command.Dispatch ,
						IReporting{

	public override Goedel.Command.Type[] _Data {get; set;} = new Goedel.Command.Type[] {
		new Flag (),
		new Flag (),
		new Flag (),
		new NewFile (),
		new String (),
		new ExistingFile ()		} ;





	/// <summary>Field accessor for option [verbose]</summary>
	public virtual Flag Verbose {
		get => _Data[0] as Flag;
		set => _Data[0]  = value;
		}

	public virtual string _Verbose {
		set => _Data[0].Parameter (value);
		}
	/// <summary>Field accessor for option [report]</summary>
	public virtual Flag Report {
		get => _Data[1] as Flag;
		set => _Data[1]  = value;
		}

	public virtual string _Report {
		set => _Data[1].Parameter (value);
		}
	/// <summary>Field accessor for option [json]</summary>
	public virtual Flag Json {
		get => _Data[2] as Flag;
		set => _Data[2]  = value;
		}

	public virtual string _Json {
		set => _Data[2].Parameter (value);
		}
	/// <summary>Field accessor for parameter []</summary>
	public virtual NewFile DnsConfig {
		get => _Data[3] as NewFile;
		set => _Data[3]  = value;
		}

	public virtual string _DnsConfig {
		set => _Data[3].Parameter (value);
		}
	/// <summary>Field accessor for parameter []</summary>
	public virtual String HostConfig {
		get => _Data[4] as String;
		set => _Data[4]  = value;
		}

	public virtual string _HostConfig {
		set => _Data[4].Parameter (value);
		}
	/// <summary>Field accessor for option [config]</summary>
	public virtual ExistingFile MultiConfig {
		get => _Data[5] as ExistingFile;
		set => _Data[5]  = value;
		}

	public virtual string _MultiConfig {
		set => _Data[5].Parameter (value);
		}
	public override DescribeCommandEntry DescribeCommand {get; set;} = _DescribeCommand;

	public readonly static DescribeCommandEntry _DescribeCommand = new   () {
		Identifier = "netsh",
		Brief =  "Compute the netsh configuration from the service config.",
		HandleDelegate =  CommandLineInterpreter.Handle_Netsh,
		Lazy =  false,
		Entries = new List<DescribeEntry> () {
			new DescribeEntryOption () {
				Identifier = "Verbose", 
				Default = "false", // null if null
				Brief = "Verbose reports (default)",
				Index = 0,
				Key = "verbose"
				},
			new DescribeEntryOption () {
				Identifier = "Report", 
				Default = "true", // null if null
				Brief = "Report output (default)",
				Index = 1,
				Key = "report"
				},
			new DescribeEntryOption () {
				Identifier = "Json", 
				Default = "false", // null if null
				Brief = "Report output in JSON format",
				Index = 2,
				Key = "json"
				},
			new DescribeEntryParameter () {
				Identifier = "DnsConfig", 
				Default = null, // null if null
				Brief = "The file to write the netsh configuration to",
				Index = 3,
				Key = ""
				},
			new DescribeEntryParameter () {
				Identifier = "HostConfig", 
				Default = null, // null if null
				Brief = "The host configuration name",
				Index = 4,
				Key = ""
				},
			new DescribeEntryOption () {
				Identifier = "MultiConfig", 
				Default = "HostsAndServices", // null if null
				Brief = "The configuration file, is created if necessary",
				Index = 5,
				Key = "config"
				}
			}
		};

	}

public partial class Netsh : _Netsh {
    } // class Netsh


public partial class  Flag : Goedel.Command._Flag {
    public Flag(string value=null) : base (value) {}
    } // Flag

public partial class  File : Goedel.Command._File {
	public File(string value=null) : base (value) {}
    } // File

public partial class  NewFile : Goedel.Command._NewFile {
	public NewFile(string value=null) : base (value) {}
    } // NewFile

public partial class  ExistingFile : Goedel.Command._ExistingFile {
	public ExistingFile(string value=null) : base (value) {}
    } // ExistingFile

public partial class  Integer : Goedel.Command._Integer {
	public Integer(string value=null) : base (value) {}
    } // Integer

public partial class  String : Goedel.Command._String {
	public String(string value=null) : base (value) {}
    } // String



public partial class  Enumeration<T> : _Enumeration<T> {
    public Enumeration(DescribeEntryEnumerate description) : base(description){
        }
    } // _Enumeration<T>

// The stub class just contains routines that echo their arguments and
// write 'not yet implemented'

// Eventually there will be a compiler option to suppress the debugging
// to eliminate the redundant code
public class _Shell : global::Goedel.Command.DispatchShell {

	public virtual ShellResult About ( About Options) {
		CommandLineInterpreter.DescribeValues (Options);
		return null;
		}

	public virtual ShellResult Create ( Create Options) {
		CommandLineInterpreter.DescribeValues (Options);
		return null;
		}

	public virtual ShellResult DNS ( DNS Options) {
		CommandLineInterpreter.DescribeValues (Options);
		return null;
		}

	public virtual ShellResult Netsh ( Netsh Options) {
		CommandLineInterpreter.DescribeValues (Options);
		return null;
		}


    } // class _Shell

public partial class Shell : _Shell {
    } // class Shell



