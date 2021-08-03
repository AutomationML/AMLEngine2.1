# LookupService.AllElementsWithNameReference Method 
AutomationML 2.1 API 

Gets all the elements which are descendants of the provided CAEX object and use a name reference. Elements referencing the same name are grouped together. Use this method to validate the existence of referenced elements.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public ILookup<string, ICAEXReference> AllElementsWithNameReference(
	CAEXBasicObject caexObject,
	string elementName = ""
)
```

**VB**<br />
``` VB
Public Function AllElementsWithNameReference ( 
	caexObject As CAEXBasicObject,
	Optional elementName As String = ""
) As ILookup(Of String, ICAEXReference)
```

**C++**<br />
``` C++
public:
virtual ILookup<String^, ICAEXReference^>^ AllElementsWithNameReference(
	CAEXBasicObject^ caexObject, 
	String^ elementName = L""
) sealed
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />The CAEX object.</dd><dt>elementName (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />\[Missing <param name="elementName"/> documentation for "M:Aml.Engine.Services.LookupService.AllElementsWithNameReference(Aml.Engine.CAEX.CAEXBasicObject,System.String)"\]</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.linq.ilookup-2" target="_parent" rel="noopener noreferrer">ILookup</a>(<a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>, <a href="T_Aml_Engine_Services_Interfaces_ICAEXReference">ICAEXReference</a>)<br />Lookup table of elements with name references. The name is used as a grouping key.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IQuery_AllElementsWithNameReference">IQuery.AllElementsWithNameReference(CAEXBasicObject, String)</a><br />

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>caexObject</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_LookupService">LookupService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />