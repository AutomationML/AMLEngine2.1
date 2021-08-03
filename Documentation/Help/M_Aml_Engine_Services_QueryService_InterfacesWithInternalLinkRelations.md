# QueryService.InterfacesWithInternalLinkRelations Method 
AutomationML 2.1 API 

Returns all ExternalInterface objects which are descendants of the provided CAEX object and are used in relations (InternalLinks).

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<ExternalInterfaceType> InterfacesWithInternalLinkRelations(
	CAEXBasicObject caexObject
)
```

**VB**<br />
``` VB
Public Function InterfacesWithInternalLinkRelations ( 
	caexObject As CAEXBasicObject
) As IEnumerable(Of ExternalInterfaceType)
```

**C++**<br />
``` C++
public:
virtual IEnumerable<ExternalInterfaceType^>^ InterfacesWithInternalLinkRelations(
	CAEXBasicObject^ caexObject
) sealed
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />The CAEX object.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a>)<br />A collection of related ExternalInterface objects

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IQuery_InterfacesWithInternalLinkRelations">IQuery.InterfacesWithInternalLinkRelations(CAEXBasicObject)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_QueryService">QueryService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />