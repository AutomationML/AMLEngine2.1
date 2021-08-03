# LookupService.AllElementsWithInternalLinks Method 
AutomationML 2.1 API 

Returns all Elements which are descendants of the provided CAEX object with InternalLinks. These elements are the owners of the InternalLink objects. The returned collection may contain InternalElements and SystemUnitClasses as well.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<SystemUnitClassType> AllElementsWithInternalLinks(
	CAEXBasicObject caexObject
)
```

**VB**<br />
``` VB
Public Function AllElementsWithInternalLinks ( 
	caexObject As CAEXBasicObject
) As IEnumerable(Of SystemUnitClassType)
```

**C++**<br />
``` C++
public:
virtual IEnumerable<SystemUnitClassType^>^ AllElementsWithInternalLinks(
	CAEXBasicObject^ caexObject
) sealed
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />The CAEX object</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>)<br />A collection of all objects with associated InternalLinks.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IQuery_AllElementsWithInternalLinks">IQuery.AllElementsWithInternalLinks(CAEXBasicObject)</a><br />

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>caexObject</td></tr></table>

## Remarks
Note the difference to the method <a href="M_Aml_Engine_Services_Interfaces_IQuery_ElementsWithInternalLinkRelations">ElementsWithInternalLinkRelations(CAEXBasicObject)</a> which doesn't return the owners of an InternalLink but the related elements.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_LookupService">LookupService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />