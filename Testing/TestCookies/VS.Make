
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
    Goedel.Cryptography.dll\
    Goedel.Debug.dll\
    Goedel.Protocol.Service.dll\
    Goedel.Protocol.Web.dll\
    Goedel.Test.Core.dll\
    Goedel.Test.dll\
    Goedel.Mesh.Client.dll\
    Goedel.Mesh.Core.dll\
    Goedel.Mesh.Server.dll\
    Test.Cryptography.Oauth.dll\
    Goedel.Tool.Core.dll\
    Goedel.Palimpsest.dll

ToolTargets = 


prebuildRecurse : 


postbuildRecurse :

# Non shared project, nothing to do
prebuild : prebuildRecurse $(ToolTargets)
	

postbuild : postbuildRecurse


postbuildwindows : 
	powershell publishtarget TestCookies.dll

