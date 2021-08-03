# IQuery.InternalLinksToInterface Method 
AutomationML 2.1 API 

Gets all InternalLinks that reference the specified ExternalInterface.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
IEnumerable<InternalLinkType> InternalLinksToInterface(
	ExternalInterfaceType externalInterface
)
```

**VB**<br />
``` VB
Function InternalLinksToInterface ( 
	externalInterface As ExternalInterfaceType
) As IEnumerable(Of InternalLinkType)
```

**C++**<br />
``` C++
IEnumerable<InternalLinkType^>^ InternalLinksToInterface(
	ExternalInterfaceType^ externalInterface
)
```


#### Parameters
&nbsp;<dl><dt>externalInterface</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">Aml.Engine.CAEX.ExternalInterfaceType</a><br />The ExternalInterface.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_InternalLinkType">InternalLinkType</a>)<br />a collection of InternalLinks.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IQuery">IQuery Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />