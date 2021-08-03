# QueryService.AllInternalElementsWithInternalLinks Method 
AutomationML 2.1 API 

Returns all InternalElements which are descendants of the provided CAEX object with InternalLinks. These elements are the owners of the InternalLink objects.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<InternalElementType> AllInternalElementsWithInternalLinks(
	CAEXBasicObject caexObject
)
```

**VB**<br />
``` VB
Public Function AllInternalElementsWithInternalLinks ( 
	caexObject As CAEXBasicObject
) As IEnumerable(Of InternalElementType)
```

**C++**<br />
``` C++
public:
virtual IEnumerable<InternalElementType^>^ AllInternalElementsWithInternalLinks(
	CAEXBasicObject^ caexObject
) sealed
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />The CAEX object.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a>)<br />A collection of all objects with associated InternalLinks.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IQuery_AllInternalElementsWithInternalLinks">IQuery.AllInternalElementsWithInternalLinks(CAEXBasicObject)</a><br />

## Remarks
Note the difference to the method <a href="M_Aml_Engine_Services_QueryService_ElementsWithInternalLinkRelations">ElementsWithInternalLinkRelations(CAEXBasicObject)</a> which doesn't return the owners of an InternalLink but the related elements.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_QueryService">QueryService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />