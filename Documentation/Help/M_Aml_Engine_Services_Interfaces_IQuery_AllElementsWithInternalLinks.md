# IQuery.AllElementsWithInternalLinks Method 
AutomationML 2.1 API 

Returns all Elements which are descendants of the provided CAEX object with InternalLinks. These elements are the owners of the InternalLink objects. The returned collection may contain InternalElements and SystemUnitClasses as well.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
IEnumerable<SystemUnitClassType> AllElementsWithInternalLinks(
	CAEXBasicObject caexObject
)
```

**VB**<br />
``` VB
Function AllElementsWithInternalLinks ( 
	caexObject As CAEXBasicObject
) As IEnumerable(Of SystemUnitClassType)
```

**C++**<br />
``` C++
IEnumerable<SystemUnitClassType^>^ AllElementsWithInternalLinks(
	CAEXBasicObject^ caexObject
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />The CAEX object.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>)<br />A collection of all objects with associated InternalLinks.

## Remarks
Note the difference to the method <a href="M_Aml_Engine_Services_Interfaces_IQuery_ElementsWithInternalLinkRelations">ElementsWithInternalLinkRelations(CAEXBasicObject)</a> which doesn't return the owners of an InternalLink but the related elements.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IQuery">IQuery Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />