# QueryService.InternalLinksToElement Method 
AutomationML 2.1 API 

Gets all InternalLink objects referencing the provided SystemUnitClass object via an external interface attached to the SystemUnitClass.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<InternalLinkType> InternalLinksToElement(
	SystemUnitClassType systemUnitClass
)
```

**VB**<br />
``` VB
Public Function InternalLinksToElement ( 
	systemUnitClass As SystemUnitClassType
) As IEnumerable(Of InternalLinkType)
```

**C++**<br />
``` C++
public:
virtual IEnumerable<InternalLinkType^>^ InternalLinksToElement(
	SystemUnitClassType^ systemUnitClass
) sealed
```


#### Parameters
&nbsp;<dl><dt>systemUnitClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SystemUnitClassType">Aml.Engine.CAEX.SystemUnitClassType</a><br />The SystemUnitClass object</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_InternalLinkType">InternalLinkType</a>)<br />An enumeration of InternalLinks.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IQuery_InternalLinksToElement">IQuery.InternalLinksToElement(SystemUnitClassType)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_QueryService">QueryService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />