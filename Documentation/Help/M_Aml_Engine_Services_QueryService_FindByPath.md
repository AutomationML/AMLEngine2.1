# QueryService.FindByPath Method 
AutomationML 2.1 API 

This method tries to find the first element in the defined document, which CAEXPath is equal to the provided path. If the path uses an alias to reference an object in a external document it is tried to locate an <a href="T_Aml_Engine_Services_Interfaces_IExternalReferenceResolver">IExternalReferenceResolver</a> service. If such a service is registered, the CAEXObject is tried to be found in the resolved document.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public CAEXObject FindByPath(
	CAEXDocument caexDocument,
	string path,
	bool resolveAlias = false
)
```

**VB**<br />
``` VB
Public Function FindByPath ( 
	caexDocument As CAEXDocument,
	path As String,
	Optional resolveAlias As Boolean = false
) As CAEXObject
```

**C++**<br />
``` C++
public:
virtual CAEXObject^ FindByPath(
	CAEXDocument^ caexDocument, 
	String^ path, 
	bool resolveAlias = false
) sealed
```


#### Parameters
&nbsp;<dl><dt>caexDocument</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The XDocument</dd><dt>path</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The CAEXPath to look at</dd><dt>resolveAlias (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` [resolve alias].</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a><br />the CAEXObject or `null`, if no element with the specified path could be found.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IQuery_FindByPath">IQuery.FindByPath(CAEXDocument, String, Boolean)</a><br />

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>caexDocument</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_QueryService">QueryService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />