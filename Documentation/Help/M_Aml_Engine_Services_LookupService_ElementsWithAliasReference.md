# LookupService.ElementsWithAliasReference Method 
AutomationML 2.1 API 

Gets alls the elements which are descendants of the provided CAEX object which use the provided Alias in a reference. The elements in the result collection are references, which define the CAEX object and the attribute, containing the reference . If the *elementName* is set, only elements with the defined element name are considered.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<ICAEXReference> ElementsWithAliasReference(
	CAEXBasicObject caexObject,
	string alias,
	string elementName = ""
)
```

**VB**<br />
``` VB
Public Function ElementsWithAliasReference ( 
	caexObject As CAEXBasicObject,
	alias As String,
	Optional elementName As String = ""
) As IEnumerable(Of ICAEXReference)
```

**C++**<br />
``` C++
public:
virtual IEnumerable<ICAEXReference^>^ ElementsWithAliasReference(
	CAEXBasicObject^ caexObject, 
	String^ alias, 
	String^ elementName = L""
) sealed
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />The CAEX object.</dd><dt>alias</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The Alias.</dd><dt>elementName (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />If parameter is set, only elements with the given element Name are considered.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_Services_Interfaces_ICAEXReference">ICAEXReference</a>)<br />a collection of element references which use the provided Alias in a reference

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IQuery_ElementsWithAliasReference">IQuery.ElementsWithAliasReference(CAEXBasicObject, String, String)</a><br />

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>caexObject</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_LookupService">LookupService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br /><a href="T_Aml_Engine_Services_Interfaces_ICAEXReference">Aml.Engine.Services.Interfaces.ICAEXReference</a><br />