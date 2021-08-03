# IQuery.AllElementsWithNameReference Method 
AutomationML 2.1 API 

Gets all the elements which are descendants of the provided CAEX object and use a name reference. Elements referencing the same name are grouped together. Use this method to validate the existence of referenced elements.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
ILookup<string, ICAEXReference> AllElementsWithNameReference(
	CAEXBasicObject caexObject,
	string elementName = ""
)
```

**VB**<br />
``` VB
Function AllElementsWithNameReference ( 
	caexObject As CAEXBasicObject,
	Optional elementName As String = ""
) As ILookup(Of String, ICAEXReference)
```

**C++**<br />
``` C++
ILookup<String^, ICAEXReference^>^ AllElementsWithNameReference(
	CAEXBasicObject^ caexObject, 
	String^ elementName = L""
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />The CAEX object.</dd><dt>elementName (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br /></dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.linq.ilookup-2" target="_parent" rel="noopener noreferrer">ILookup</a>(<a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>, <a href="T_Aml_Engine_Services_Interfaces_ICAEXReference">ICAEXReference</a>)<br />Lookup table of elements with name references. The name is used as a grouping key.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IQuery">IQuery Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />