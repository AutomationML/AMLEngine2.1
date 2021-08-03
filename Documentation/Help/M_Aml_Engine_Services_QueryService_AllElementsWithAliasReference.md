# QueryService.AllElementsWithAliasReference Method 
AutomationML 2.1 API 

Gets all the elements which are descendants of the provided CAEX object and use an alias reference. Elements referencing the same Alias are grouped together. Use this method to validate the existence of referenced externals.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public ILookup<string, ICAEXReference> AllElementsWithAliasReference(
	CAEXBasicObject caexObject,
	string elementName = ""
)
```

**VB**<br />
``` VB
Public Function AllElementsWithAliasReference ( 
	caexObject As CAEXBasicObject,
	Optional elementName As String = ""
) As ILookup(Of String, ICAEXReference)
```

**C++**<br />
``` C++
public:
virtual ILookup<String^, ICAEXReference^>^ AllElementsWithAliasReference(
	CAEXBasicObject^ caexObject, 
	String^ elementName = L""
) sealed
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />The CAEX object.</dd><dt>elementName (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />If parameter is set, only elements with the given element Name are considered.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.linq.ilookup-2" target="_parent" rel="noopener noreferrer">ILookup</a>(<a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>, <a href="T_Aml_Engine_Services_Interfaces_ICAEXReference">ICAEXReference</a>)<br />group of elements with Alias references. The Alias part of the CAEXPath is used as a group key.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IQuery_AllElementsWithAliasReference">IQuery.AllElementsWithAliasReference(CAEXBasicObject, String)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_QueryService">QueryService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />