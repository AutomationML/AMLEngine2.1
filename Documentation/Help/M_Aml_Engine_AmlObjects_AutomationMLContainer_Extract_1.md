# AutomationMLContainer.Extract Method (DirectoryInfo, PackagePart)
AutomationML 2.1 API 

Extracts the specified part in the package to the specified directory.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public void Extract(
	DirectoryInfo dirInfo,
	PackagePart part
)
```

**VB**<br />
``` VB
Public Sub Extract ( 
	dirInfo As DirectoryInfo,
	part As PackagePart
)
```

**C++**<br />
``` C++
public:
void Extract(
	DirectoryInfo^ dirInfo, 
	PackagePart^ part
)
```


#### Parameters
&nbsp;<dl><dt>dirInfo</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.io.directoryinfo" target="_parent" rel="noopener noreferrer">System.IO.DirectoryInfo</a><br />directory info defining the target directory for extraction.</dd><dt>part</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.io.packaging.packagepart" target="_parent" rel="noopener noreferrer">System.IO.Packaging.PackagePart</a><br />The part to extract to the specified folder.</dd></dl>

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AutomationMLContainer">AutomationMLContainer Class</a><br /><a href="Overload_Aml_Engine_AmlObjects_AutomationMLContainer_Extract">Extract Overload</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />