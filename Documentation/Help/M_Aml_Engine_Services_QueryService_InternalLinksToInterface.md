# QueryService.InternalLinksToInterface Method 
AutomationML 2.1 API 

Gets all InternalLinks that reference the specified ExternalInterface.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<InternalLinkType> InternalLinksToInterface(
	ExternalInterfaceType externalInterface
)
```

**VB**<br />
``` VB
Public Function InternalLinksToInterface ( 
	externalInterface As ExternalInterfaceType
) As IEnumerable(Of InternalLinkType)
```

**C++**<br />
``` C++
public:
virtual IEnumerable<InternalLinkType^>^ InternalLinksToInterface(
	ExternalInterfaceType^ externalInterface
) sealed
```


#### Parameters
&nbsp;<dl><dt>externalInterface</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">Aml.Engine.CAEX.ExternalInterfaceType</a><br />The ExternalInterface.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_InternalLinkType">InternalLinkType</a>)<br />a collection of InternalLinks.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IQuery_InternalLinksToInterface">IQuery.InternalLinksToInterface(ExternalInterfaceType)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_QueryService">QueryService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />