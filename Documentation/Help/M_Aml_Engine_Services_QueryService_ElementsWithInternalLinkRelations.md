# QueryService.ElementsWithInternalLinkRelations Method 
AutomationML 2.1 API 

Returns all InternalElements and SystemUnitClasses which are descendants of the provided CAEX object, which are related to others via InternalLinks.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<SystemUnitClassType> ElementsWithInternalLinkRelations(
	CAEXBasicObject caexObject
)
```

**VB**<br />
``` VB
Public Function ElementsWithInternalLinkRelations ( 
	caexObject As CAEXBasicObject
) As IEnumerable(Of SystemUnitClassType)
```

**C++**<br />
``` C++
public:
virtual IEnumerable<SystemUnitClassType^>^ ElementsWithInternalLinkRelations(
	CAEXBasicObject^ caexObject
) sealed
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />The CAEX object.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>)<br />A collection of related SystemUnitClass objects

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IQuery_ElementsWithInternalLinkRelations">IQuery.ElementsWithInternalLinkRelations(CAEXBasicObject)</a><br />

## Remarks
Note the difference to the method <a href="M_Aml_Engine_Services_QueryService_AllElementsWithInternalLinks">AllElementsWithInternalLinks(CAEXBasicObject)</a> which doesn't return the related elements but the InternalLink owners.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_QueryService">QueryService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />