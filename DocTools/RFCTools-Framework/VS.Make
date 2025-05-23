
# Supplemental Makefile for Visual Studios Projects
#
# Visual Studio is responsible for managing rules for production of
# code but does not provide support for pre and post build actions.
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
    Goedel.Tool.Library.dll

ToolTargets = 


prebuildRecurse : 
	cd ..\..\DocTools\Goedel.Document.RFCConvert && nmake /c /f VS.make prebuild 
	cd ..\..\DocTools\Goedel.Document.RFC && nmake /c /f VS.make prebuild 
	cd ..\Goedel.Document.Markdown && nmake /c /f VS.make prebuild 
	cd ..\..\..\mmm\Libraries\Goedel.IO && nmake /c /f VS.make prebuild 


postbuildRecurse :
	cd ..\..\DocTools\Goedel.Document.RFCConvert && nmake /c /f VS.make postbuild 
	cd ..\..\DocTools\Goedel.Document.RFC && nmake /c /f VS.make postbuild 
	cd ..\Goedel.Document.Markdown && nmake /c /f VS.make postbuild 
	cd ..\..\..\mmm\Libraries\Goedel.IO && nmake /c /f VS.make postbuild 


prebuild : prebuildRecurse $(ToolTargets)

postbuild : postbuildRecurse


postbuildwindows : 
	powershell publishtarget RFCTools-Framework.dll

