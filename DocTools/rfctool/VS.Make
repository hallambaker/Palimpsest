
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
    Goedel.Document.Markdown.dll\
    Goedel.Document.OpenXML.dll\
    Goedel.Document.RFCConvert.dll\
    Goedel.Document.RFC.dll\
    Goedel.Tool.Core.dll\
    Goedel.Document.RFCSVG.dll

ToolTargets = \
	main.cs
main.cs : main.command 
	commandparse main.command  /cs  main.cs



prebuildRecurse : 


postbuildRecurse :

# Non shared project, nothing to do
prebuild : prebuildRecurse $(ToolTargets)
	

postbuild : postbuildRecurse


postbuildwindows : 
	powershell publishtarget rfctool.dll

