
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
    Goedel.Cryptography.Dare.dll\
    Goedel.Cryptography.Identifiers.dll\
    Goedel.Cryptography.Jose.dll\
    Goedel.Cryptography.Oauth.dll\
    Goedel.Cryptography.dll\
    Goedel.FSR.dll\
    Goedel.Protocol.GenericHost.dll\
    Goedel.Protocol.Service.dll\
    Goedel.Protocol.Web.dll\
    Goedel.Registry.dll\
    Goedel.Serialization.dll\
    Goedel.Utilities.dll\
    Goedel.Protocol.dll\
    Goedel.Mesh.dll\
    Goedel.Document.Markdown.dll\
    Goedel.Document.OpenXML.dll\
    Goedel.Document.RFC.dll

ToolTargets = \
	Exceptions.cs\
	PalimpsestSchema.cs\
	PalimsestConstants.cs\
	ServerPages.cs
Exceptions.cs : Exceptions.exceptional 
	exceptional Exceptions.exceptional  /cs  Exceptions.cs

PalimpsestSchema.cs : PalimpsestSchema.protocol 
	protogen PalimpsestSchema.protocol  /cs  PalimpsestSchema.cs

PalimsestConstants.cs : PalimsestConstants.constant 
	constant PalimsestConstants.constant  /cs  PalimsestConstants.cs

ServerPages.cs : ServerPages.script 
	gscript ServerPages.script  ServerPages.cs



prebuildRecurse : 


postbuildRecurse :

# Non shared project, nothing to do
prebuild : prebuildRecurse $(ToolTargets)
	

postbuild : postbuildRecurse


postbuildwindows : 
	powershell publishtarget Goedel.Palimpsest.dll

