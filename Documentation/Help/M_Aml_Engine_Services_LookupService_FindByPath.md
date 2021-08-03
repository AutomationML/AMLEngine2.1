# LookupService.FindByPath Method 
AutomationML 2.1 API 

Locates a CAEX object in the provided document using the specified CAEX - Path for identification. If the path uses an alias reference and an <a href="T_Aml_Engine_Services_Interfaces_IExternalReferenceResolver">IExternalReferenceResolver</a> can be located, it is tried to resolve the external reference and to get the object from the external source.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public CAEXObject FindByPath(
	CAEXDocument doc,
	string caexPath,
	bool resolveAlias = false
)
```

**VB**<br />
``` VB
Public Function FindByPath ( 
	doc As CAEXDocument,
	caexPath As String,
	Optional resolveAlias As Boolean = false
) As CAEXObject
```

**C++**<br />
``` C++
public:
virtual CAEXObject^ FindByPath(
	CAEXDocument^ doc, 
	String^ caexPath, 
	bool resolveAlias = false
) sealed
```


#### Parameters
&nbsp;<dl><dt>doc</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd><dt>caexPath</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The path.</dd><dt>resolveAlias (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` tries to resolve an alias reference with an ExternalReferenceResolver service.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a><br />The first object which is found (if the path is not a unique identifier, than more than this object may exist).

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IQuery_FindByPath">IQuery.FindByPath(CAEXDocument, String, Boolean)</a><br />

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>doc</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_LookupService">LookupService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />