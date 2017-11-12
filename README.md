ClassLibrary1Tests is an existing UnitTest project file I cloned. 

UnitTestProject1 is a new Unit Test project. FWIW, I had to Repair VS just to be able to choose this template type. It had been available within the last few weeks, but `devenv /installvstemplates` didnt reinstall any templates.

UnitTestProject2 is also a new Unit Test project. This has had the references modified as described in [the thread](https://github.com/Microsoft/testfx/issues/241#issuecomment-331974210). Visual Studio finds this unit test and can execute it.




If I Clean then Build the solution, the Test Explorer window remains is empty.
The Test output window shows only 0 found
```
[11/12/2017 9:07:23 AM Informational] ------ Discover test started ------
[11/12/2017 9:07:23 AM Informational] ========== Discover test finished: 0 found (0:00:00.1060044) ==========

```

Unloading and reloading the UnitTest1 project has more info, but none of it is useful.
```
[11/12/2017 9:07:23 AM Informational] ------ Discover test started ------
[11/12/2017 9:07:23 AM Informational] ========== Discover test finished: 0 found (0:00:00.1060044) ==========
[11/12/2017 9:08:31 AM Informational] PowerShellTestContainerDiscoverer:OnSolutionProjectChanged
[11/12/2017 9:08:31 AM Informational] PowerShellTestContainerDiscoverer:OnTestContainersChanged - FindPs1Files
[11/12/2017 9:08:31 AM Informational] PowerShellTestContainerDiscoverer:OnTestContainersChanged - Change reason is unload
[11/12/2017 9:08:31 AM Informational] PowerShellTestContainerDiscoverer:IsTestFile - c:\users\astanton\source\repos\classlibrary1\unittestproject1\properties\
[11/12/2017 9:08:31 AM Informational] PowerShellTestContainerDiscoverer:IsTestFile - c:\users\astanton\source\repos\classlibrary1\unittestproject1\properties\assemblyinfo.cs
[11/12/2017 9:08:31 AM Informational] PowerShellTestContainerDiscoverer:IsTestFile - 
[11/12/2017 9:08:31 AM Informational] PowerShellTestContainerDiscoverer:IsTestFile - 
[11/12/2017 9:08:31 AM Informational] PowerShellTestContainerDiscoverer:IsTestFile - 
[11/12/2017 9:08:31 AM Informational] PowerShellTestContainerDiscoverer:IsTestFile - 
[11/12/2017 9:08:31 AM Informational] PowerShellTestContainerDiscoverer:IsTestFile - 
[11/12/2017 9:08:31 AM Informational] PowerShellTestContainerDiscoverer:IsTestFile - 
[11/12/2017 9:08:31 AM Informational] PowerShellTestContainerDiscoverer:IsTestFile - c:\users\astanton\source\repos\classlibrary1\classlibrary1tests\class1tests.cs
[11/12/2017 9:08:31 AM Informational] PowerShellTestContainerDiscoverer:IsTestFile - c:\users\astanton\source\repos\classlibrary1\unittestproject1\packages.config
[11/12/2017 9:08:31 AM Informational] PowerShellTestContainerDiscoverer:IsTestFile - c:\users\astanton\source\repos\classlibrary1\unittestproject1\unittest1.cs
[11/12/2017 9:08:37 AM Informational] PowerShellTestContainerDiscoverer:OnSolutionProjectChanged
[11/12/2017 9:08:37 AM Informational] PowerShellTestContainerDiscoverer:OnTestContainersChanged - FindPs1Files
[11/12/2017 9:08:37 AM Informational] PowerShellTestContainerDiscoverer:OnTestContainersChanged - Change reason is load
[11/12/2017 9:08:37 AM Informational] PowerShellTestContainerDiscoverer:IsTestFile - c:\users\astanton\source\repos\classlibrary1\unittestproject1\properties\
[11/12/2017 9:08:37 AM Informational] PowerShellTestContainerDiscoverer:IsTestFile - c:\users\astanton\source\repos\classlibrary1\unittestproject1\properties\assemblyinfo.cs
[11/12/2017 9:08:37 AM Informational] PowerShellTestContainerDiscoverer:IsTestFile - 
[11/12/2017 9:08:37 AM Informational] PowerShellTestContainerDiscoverer:IsTestFile - 
[11/12/2017 9:08:37 AM Informational] PowerShellTestContainerDiscoverer:IsTestFile - 
[11/12/2017 9:08:37 AM Informational] PowerShellTestContainerDiscoverer:IsTestFile - 
[11/12/2017 9:08:37 AM Informational] PowerShellTestContainerDiscoverer:IsTestFile - 
[11/12/2017 9:08:37 AM Informational] PowerShellTestContainerDiscoverer:IsTestFile - 
[11/12/2017 9:08:37 AM Informational] PowerShellTestContainerDiscoverer:IsTestFile - c:\users\astanton\source\repos\classlibrary1\classlibrary1tests\class1tests.cs
[11/12/2017 9:08:37 AM Informational] PowerShellTestContainerDiscoverer:IsTestFile - c:\users\astanton\source\repos\classlibrary1\unittestproject1\packages.config
[11/12/2017 9:08:37 AM Informational] PowerShellTestContainerDiscoverer:IsTestFile - c:\users\astanton\source\repos\classlibrary1\unittestproject1\unittest1.cs

```



These are the logs from when I tried to add the MSTest packages to ClassLibrary1Tests. It says it added them, but they showed up with the yellow "broken reference" icon until after the VS repair.

```
Attempting to gather dependency information for package 'MSTest.TestAdapter.1.1.18' with respect to project 'ClassLibrary1Tests', targeting '.NETFramework,Version=v4.6.2'
  GET https://api.nuget.org/v3/registration3-gz-semver2/mstest.testadapter/index.json
  OK https://api.nuget.org/v3/registration3-gz-semver2/mstest.testadapter/index.json 136ms
Total number of results gathered : 1
Gathering dependency information took 3.03 sec
Summary of time taken to gather dependencies per source :
https://api.nuget.org/v3/index.json	-	159.73 ms
Attempting to resolve dependencies for package 'MSTest.TestAdapter.1.1.18' with DependencyBehavior 'Lowest'
Resolving dependency information took 0 ms
Resolving actions to install package 'MSTest.TestAdapter.1.1.18'
Resolved actions to install package 'MSTest.TestAdapter.1.1.18'
Retrieving package 'MSTest.TestAdapter 1.1.18' from 'nuget.org'.
For adding package 'MSTest.TestAdapter.1.1.18' to project 'ClassLibrary1Tests' that targets 'net462'.
For adding package 'MSTest.TestAdapter.1.1.18' to project 'ClassLibrary1Tests' that targets 'net462'.
Adding package 'MSTest.TestAdapter.1.1.18' to folder 'C:\Users\astanton\source\repos\ClassLibrary1\packages'
Added package 'MSTest.TestAdapter.1.1.18' to folder 'C:\Users\astanton\source\repos\ClassLibrary1\packages'
Added package 'MSTest.TestAdapter.1.1.18' to folder 'C:\Users\astanton\source\repos\ClassLibrary1\packages' from source 'https://api.nuget.org/v3/index.json'
Added package 'MSTest.TestAdapter.1.1.18' to 'packages.config'
Successfully installed 'MSTest.TestAdapter 1.1.18' to ClassLibrary1Tests
Executing nuget actions took 291.37 ms
Time Elapsed: 00:00:03.4172738
========== Finished ==========

Attempting to gather dependency information for package 'MSTest.TestFramework.1.1.18' with respect to project 'ClassLibrary1Tests', targeting '.NETFramework,Version=v4.6.2'
  GET https://api.nuget.org/v3/registration3-gz-semver2/mstest.testframework/index.json
  OK https://api.nuget.org/v3/registration3-gz-semver2/mstest.testframework/index.json 363ms
Total number of results gathered : 2
Gathering dependency information took 367.51 ms
Summary of time taken to gather dependencies per source :
https://api.nuget.org/v3/index.json	-	366.01 ms
Attempting to resolve dependencies for package 'MSTest.TestFramework.1.1.18' with DependencyBehavior 'Lowest'
Resolving dependency information took 0 ms
Resolving actions to install package 'MSTest.TestFramework.1.1.18'
Resolved actions to install package 'MSTest.TestFramework.1.1.18'
Retrieving package 'MSTest.TestFramework 1.1.18' from 'nuget.org'.
For adding package 'MSTest.TestFramework.1.1.18' to project 'ClassLibrary1Tests' that targets 'net462'.
For adding package 'MSTest.TestFramework.1.1.18' to project 'ClassLibrary1Tests' that targets 'net462'.
Adding package 'MSTest.TestFramework.1.1.18' to folder 'C:\Users\astanton\source\repos\ClassLibrary1\packages'
Added package 'MSTest.TestFramework.1.1.18' to folder 'C:\Users\astanton\source\repos\ClassLibrary1\packages'
Added package 'MSTest.TestFramework.1.1.18' to folder 'C:\Users\astanton\source\repos\ClassLibrary1\packages' from source 'https://api.nuget.org/v3/index.json'
Added reference 'Microsoft.VisualStudio.TestPlatform.TestFramework' to project:'ClassLibrary1Tests'. The Reference was Resolved To Package (resolvedToPackage):'True', where Reference Path from DTE(dteOriginalPath):'C:\Users\astanton\source\repos\ClassLibrary1\packages\MSTest.TestFramework.1.1.18\lib\net45\Microsoft.VisualStudio.TestPlatform.TestFramework.dll' and Reference Path from package reference(assemblyFullPath):'C:\Users\astanton\source\repos\ClassLibrary1\packages\MSTest.TestFramework.1.1.18\lib\net45\Microsoft.VisualStudio.TestPlatform.TestFramework.dll'.
Added reference 'Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions' to project:'ClassLibrary1Tests'. The Reference was Resolved To Package (resolvedToPackage):'True', where Reference Path from DTE(dteOriginalPath):'C:\Users\astanton\source\repos\ClassLibrary1\packages\MSTest.TestFramework.1.1.18\lib\net45\Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.dll' and Reference Path from package reference(assemblyFullPath):'C:\Users\astanton\source\repos\ClassLibrary1\packages\MSTest.TestFramework.1.1.18\lib\net45\Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.dll'.
Added package 'MSTest.TestFramework.1.1.18' to 'packages.config'
Successfully installed 'MSTest.TestFramework 1.1.18' to ClassLibrary1Tests
Executing nuget actions took 1.09 sec
Time Elapsed: 00:00:01.4906913
========== Finished ==========
```