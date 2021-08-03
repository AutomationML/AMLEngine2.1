# LookupService.AllClassReferences Method (CAEXObject)
AutomationML 2.1 API 

Gets all classes which have references to the provided CAEX object. Use this method to get all classes which have a class to class relation to the provided CAEX object.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<CAEXObject> AllClassReferences(
	CAEXObject caexObject
)
```

**VB**<br />
``` VB
Public Function AllClassReferences ( 
	caexObject As CAEXObject
) As IEnumerable(Of CAEXObject)
```

**C++**<br />
``` C++
public:
virtual IEnumerable<CAEXObject^>^ AllClassReferences(
	CAEXObject^ caexObject
) sealed
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXObject">Aml.Engine.CAEX.CAEXObject</a><br />The CAEX object.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>)<br />An enumeration of all classes which use the provided CAEX object as a base class.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IQuery_AllClassReferences_1">IQuery.AllClassReferences(CAEXObject)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_LookupService">LookupService Class</a><br /><a href="Overload_Aml_Engine_Services_LookupService_AllClassReferences">AllClassReferences Overload</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />