# AutomationMLContainer.RootDocumentPath Method 
AutomationML 2.1 API 

Gets the file path to the first root AML document when the container is already extracted. <a href="M_Aml_Engine_AmlObjects_AutomationMLContainer_Extract">Extract(DirectoryInfo)</a> If the container is created from a stream source or no root document is found, the return value is `string.Empty`.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public string RootDocumentPath(
	DirectoryInfo dirInfo
)
```

**VB**<br />
``` VB
Public Function RootDocumentPath ( 
	dirInfo As DirectoryInfo
) As String
```

**C++**<br />
``` C++
public:
String^ RootDocumentPath(
	DirectoryInfo^ dirInfo
)
```


#### Parameters
&nbsp;<dl><dt>dirInfo</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.io.directoryinfo" target="_parent" rel="noopener noreferrer">System.IO.DirectoryInfo</a><br />The directory which was used for extraction.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />System.String.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AutomationMLContainer">AutomationMLContainer Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />