# QueryService.AllClassReferencesDeep Method (CAEXObject)
AutomationML 2.1 API 

Gets all classes which have references to the provided CAEX object and their referencing classes (recursive)

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<CAEXObject> AllClassReferencesDeep(
	CAEXObject caexObject
)
```

**VB**<br />
``` VB
Public Function AllClassReferencesDeep ( 
	caexObject As CAEXObject
) As IEnumerable(Of CAEXObject)
```

**C++**<br />
``` C++
public:
virtual IEnumerable<CAEXObject^>^ AllClassReferencesDeep(
	CAEXObject^ caexObject
) sealed
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXObject">Aml.Engine.CAEX.CAEXObject</a><br />The CAEX object.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>)<br />\[Missing <returns> documentation for "M:Aml.Engine.Services.QueryService.AllClassReferencesDeep(Aml.Engine.CAEX.CAEXObject)"\]

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IQuery_AllClassReferencesDeep_1">IQuery.AllClassReferencesDeep(CAEXObject)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_QueryService">QueryService Class</a><br /><a href="Overload_Aml_Engine_Services_QueryService_AllClassReferencesDeep">AllClassReferencesDeep Overload</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />