# AutomationMLContainer Constructor (String, FileMode, FileAccess, FileShare)
AutomationML 2.1 API 

Initializes a new instance of the <a href="T_Aml_Engine_AmlObjects_AutomationMLContainer">AutomationMLContainer</a> class using the specified container file to load or save the package.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public AutomationMLContainer(
	string containerFilePath,
	FileMode packageMode,
	FileAccess packageAccess,
	FileShare packageShare
)
```

**VB**<br />
``` VB
Public Sub New ( 
	containerFilePath As String,
	packageMode As FileMode,
	packageAccess As FileAccess,
	packageShare As FileShare
)
```

**C++**<br />
``` C++
public:
AutomationMLContainer(
	String^ containerFilePath, 
	FileMode packageMode, 
	FileAccess packageAccess, 
	FileShare packageShare
)
```


#### Parameters
&nbsp;<dl><dt>containerFilePath</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The file path of the container file.</dd><dt>packageMode</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.io.filemode" target="_parent" rel="noopener noreferrer">System.IO.FileMode</a><br />The file mode for the package file.</dd><dt>packageAccess</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.io.fileaccess" target="_parent" rel="noopener noreferrer">System.IO.FileAccess</a><br />The file access mode for the package file.</dd><dt>packageShare</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.io.fileshare" target="_parent" rel="noopener noreferrer">System.IO.FileShare</a><br />The file share access mode for the package file, which controls access of other file streams to the same file.</dd></dl>

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AutomationMLContainer">AutomationMLContainer Class</a><br /><a href="Overload_Aml_Engine_AmlObjects_AutomationMLContainer__ctor">AutomationMLContainer Overload</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />