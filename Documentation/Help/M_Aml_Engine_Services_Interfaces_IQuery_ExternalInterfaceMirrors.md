# IQuery.ExternalInterfaceMirrors Method 
AutomationML 2.1 API 

Returns all Mirrors of the specified ExternalInterface

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
IEnumerable<ExternalInterfaceType> ExternalInterfaceMirrors(
	ExternalInterfaceType master
)
```

**VB**<br />
``` VB
Function ExternalInterfaceMirrors ( 
	master As ExternalInterfaceType
) As IEnumerable(Of ExternalInterfaceType)
```

**C++**<br />
``` C++
IEnumerable<ExternalInterfaceType^>^ ExternalInterfaceMirrors(
	ExternalInterfaceType^ master
)
```


#### Parameters
&nbsp;<dl><dt>master</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">Aml.Engine.CAEX.ExternalInterfaceType</a><br />The master.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a>)<br />An enumeration of mirror ExternalInterface objects

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IQuery">IQuery Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />