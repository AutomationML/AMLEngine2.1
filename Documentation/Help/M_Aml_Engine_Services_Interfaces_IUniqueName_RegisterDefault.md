# IUniqueName.RegisterDefault Method 
AutomationML 2.1 API 

Registers a new default name for the generation of unique names for the specified element.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
void RegisterDefault(
	string elementTagName,
	string defaultName
)
```

**VB**<br />
``` VB
Sub RegisterDefault ( 
	elementTagName As String,
	defaultName As String
)
```

**C++**<br />
``` C++
void RegisterDefault(
	String^ elementTagName, 
	String^ defaultName
)
```


#### Parameters
&nbsp;<dl><dt>elementTagName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The CAEX Tag name defining the elements which should get the default.</dd><dt>defaultName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The default name</dd></dl>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IUniqueName">IUniqueName Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />