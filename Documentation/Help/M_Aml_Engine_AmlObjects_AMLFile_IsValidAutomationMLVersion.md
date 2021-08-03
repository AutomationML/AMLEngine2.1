# AMLFile.IsValidAutomationMLVersion Method 
AutomationML 2.1 API 

Determines whether the specified AML version is a valid version string for this AMLFile

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool IsValidAutomationMLVersion(
	string amlVersion
)
```

**VB**<br />
``` VB
Public Function IsValidAutomationMLVersion ( 
	amlVersion As String
) As Boolean
```

**C++**<br />
``` C++
public:
bool IsValidAutomationMLVersion(
	String^ amlVersion
)
```


#### Parameters
&nbsp;<dl><dt>amlVersion</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The version string.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if specified AML version is a valid version string for this AMLFile; otherwise, `false`.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AMLFile">AMLFile Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />