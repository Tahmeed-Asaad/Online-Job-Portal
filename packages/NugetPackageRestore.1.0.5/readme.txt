NugetPackageRestore README
==================================

Enhorabuena! NugetPackageRestore is now installed in your project.
An import to NugetPackageRestore.targets has been added to your project, modify that file for further customization.

This software uses Nuget.Core and Nuget.Commandline to install all packages downloaded to your packages folder
by NuGet Package Restore (http://docs.nuget.org/docs/reference/package-restore) and it should be enabled for this package to work.
This task will allow you to Install all content from your packages to your project, including .pp and .transform files,
also there's an option to enable adding Content references to your project file (refer to packages/NugetPackageRestore<ver.>/build/net40/NugetPackageRestore.targets for more details)

SolutionDir                   = "$(SolutionDir)"                 <- Full path to your solution
ProjectDir                    = "$(ProjectDir)"                  <- Full path to your project
PackagesDir                   = "$(SolutionDir)packages"         <- Full path to packages folder
AddContentReferencesToProject = "true"                           <- Enables to add content references of installed packages to your .csproj file, false by default
ConfigFileFullPath            = "$(ProjectDir)mypackages.config" <- Full path to packages config file, set to $(ProjectDir)packages.config by default
ProjectFileFullPath           = "$(ProjectDir)myproject.csproj"  <- Full path to project file, set to $(ProjectDir)*.csproj by default

Thank you for using this software!



This file will self destruct in 5... 4... 3... 2... 1...

not really... you may now delete this file.





This software is inspired by the works of panchilo[1], uluhonolulu[2] and romerod[3] and adapted for a more varied range of situations, thank you guys.

[1]https://github.com/panchilo/MSBuild.NugetContentRestore
[2]https://github.com/uluhonolulu/BlogSamples/tree/master/NuGetSample
[3]https://github.com/baseclass/Contrib.Nuget