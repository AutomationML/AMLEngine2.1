# IQuery.ElementsWithInternalLinkRelations Method 
AutomationML 2.1 API 

Returns all InternalElements and SystemUnitClasses which are descendants of the provided CAEX object, which are related to others via InternalLinks.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
IEnumerable<SystemUnitClassType> ElementsWithInternalLinkRelations(
	CAEXBasicObject caexObject
)
```

**VB**<br />
``` VB
Function ElementsWithInternalLinkRelations ( 
	caexObject As CAEXBasicObject
) As IEnumerable(Of SystemUnitClassType)
```

**C++**<br />
``` C++
IEnumerable<SystemUnitClassType^>^ ElementsWithInternalLinkRelations(
	CAEXBasicObject^ caexObject
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />The CAEX object.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>)<br />A collection of related SystemUnitClass objects

## Remarks
Note the difference to the method <a href="M_Aml_Engine_Services_Interfaces_IQuery_AllElementsWithInternalLinks">AllElementsWithInternalLinks(CAEXBasicObject)</a> which doesn't return the related elements but the InternalLink owners.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IQuery">IQuery Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />