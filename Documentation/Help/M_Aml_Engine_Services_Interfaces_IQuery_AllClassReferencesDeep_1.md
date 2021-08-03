# IQuery.AllClassReferencesDeep Method (CAEXObject)
AutomationML 2.1 API 

Gets all classes which have references to the provided CAEX object and their referencing classes (recursive). This method extends the <a href="M_Aml_Engine_Services_Interfaces_IQuery_AllClassReferences_1">AllClassReferences(CAEXObject)</a> and gets not only the directly derived classes of a base class but also the derived classes of these classes and further on.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
IEnumerable<CAEXObject> AllClassReferencesDeep(
	CAEXObject caexObject
)
```

**VB**<br />
``` VB
Function AllClassReferencesDeep ( 
	caexObject As CAEXObject
) As IEnumerable(Of CAEXObject)
```

**C++**<br />
``` C++
IEnumerable<CAEXObject^>^ AllClassReferencesDeep(
	CAEXObject^ caexObject
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXObject">Aml.Engine.CAEX.CAEXObject</a><br />The CAEX object.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>)<br />The derived classes tree for the specified base class.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IQuery">IQuery Interface</a><br /><a href="Overload_Aml_Engine_Services_Interfaces_IQuery_AllClassReferencesDeep">AllClassReferencesDeep Overload</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />