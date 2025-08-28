
# Supplemental Makefile for Visual Studios Projects
#
# Visual Studio runs tools for most projects but not for shared projects.
# 
# Prebuild items supported:
#   [None currently]
# 
# PostBuild items supported:
#   * Copy library to locations on disk
#   * Build ilMerge executables
#   * Postprocess VSIX projects
#   * Copy executables


.PHONY : all always clean install publish prebuild prebuildRecurse postbuild postbuildRecurse

MSBuildThisFileDirectory = 

LinkFiles = \
    Goedel.Command.Json.dll\
    Goedel.Command.dll\
    Goedel.Protocol.Service.dll\
    Goedel.Registry.dll\
    Goedel.Mesh.Client.dll\
    Goedel.Mesh.Core.dll\
    Goedel.Mesh.dll\
    Goedel.Palimpsest.dll

ToolTargets = \
	main.cs\
	Results.cs
main.cs : main.command 
	commandparse main.command  /cs  main.cs

Results.cs : Results.protogen 
	protogen Results.protogen  /cs  Results.cs



prebuildRecurse : 


postbuildRecurse :

# Non shared project, nothing to do
prebuild : prebuildRecurse $(ToolTargets)
	

postbuild : postbuildRecurse


postbuildwindows : 
	powershell publishtarget PHostadmin.dll

