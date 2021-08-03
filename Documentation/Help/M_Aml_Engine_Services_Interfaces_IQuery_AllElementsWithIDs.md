# IQuery.AllElementsWithIDs Method 
AutomationML 2.1 API 

Gets all the elements which are descendants of the provided CAEX object with IDs. Elements using the same ID are grouped together. Use this method to validate the uniqueness of IDs.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
ILookup<string, ICAEXReference> AllElementsWithIDs(
	CAEXBasicObject caexObject,
	string ID = ""
)
```

**VB**<br />
``` VB
Function AllElementsWithIDs ( 
	caexObject As CAEXBasicObject,
	Optional ID As String = ""
) As ILookup(Of String, ICAEXReference)
```

**C++**<br />
``` C++
ILookup<String^, ICAEXReference^>^ AllElementsWithIDs(
	CAEXBasicObject^ caexObject, 
	String^ ID = L""
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />The CAEX object.</dd><dt>ID (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />If an ID is specified, only elements with the defined ID are searched.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.linq.ilookup-2" target="_parent" rel="noopener noreferrer">ILookup</a>(<a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>, <a href="T_Aml_Engine_Services_Interfaces_ICAEXReference">ICAEXReference</a>)<br />Lookup table of elements with IDs. The ID is used as a dictionary key.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IQuery">IQuery Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />