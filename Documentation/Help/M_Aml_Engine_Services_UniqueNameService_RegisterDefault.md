# UniqueNameService.RegisterDefault Method 
AutomationML 2.1 API 

Registers the default name for all CAEX objects with the provided element name.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public void RegisterDefault(
	string elementName,
	string defaultName
)
```

**VB**<br />
``` VB
Public Sub RegisterDefault ( 
	elementName As String,
	defaultName As String
)
```

**C++**<br />
``` C++
public:
virtual void RegisterDefault(
	String^ elementName, 
	String^ defaultName
) sealed
```


#### Parameters
&nbsp;<dl><dt>elementName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Name of the element.</dd><dt>defaultName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The default name.</dd></dl>

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IUniqueName_RegisterDefault">IUniqueName.RegisterDefault(String, String)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_UniqueNameService">UniqueNameService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />