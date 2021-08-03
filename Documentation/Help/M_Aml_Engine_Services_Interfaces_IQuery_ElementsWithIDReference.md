# IQuery.ElementsWithIDReference Method 
AutomationML 2.1 API 

Gets alls the elements from the document which have a reference to the provided ID. The elements in the result collection are references, which define the CAEX object and the attribute, containing the reference . If the *elementName* is set, only elements with the defined element name are considered.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
IEnumerable<ICAEXReference> ElementsWithIDReference(
	CAEXBasicObject caexObject,
	string ID,
	string elementName = ""
)
```

**VB**<br />
``` VB
Function ElementsWithIDReference ( 
	caexObject As CAEXBasicObject,
	ID As String,
	Optional elementName As String = ""
) As IEnumerable(Of ICAEXReference)
```

**C++**<br />
``` C++
IEnumerable<ICAEXReference^>^ ElementsWithIDReference(
	CAEXBasicObject^ caexObject, 
	String^ ID, 
	String^ elementName = L""
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />The CAEX object.</dd><dt>ID</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The identifier.</dd><dt>elementName (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />If parameter is set, only elements with the given element Name are considered.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_Services_Interfaces_ICAEXReference">ICAEXReference</a>)<br />a collection of element references which have a reference to the provided ID

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IQuery">IQuery Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br /><a href="T_Aml_Engine_Services_Interfaces_ICAEXReference">Aml.Engine.Services.Interfaces.ICAEXReference</a><br />