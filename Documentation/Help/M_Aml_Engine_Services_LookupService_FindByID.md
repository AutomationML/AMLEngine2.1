# LookupService.FindByID Method 
AutomationML 2.1 API 

Locates a CAEX object in the provided document using the specified ID - Attribute for identification.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public CAEXObject FindByID(
	CAEXDocument doc,
	string id,
	bool resolveAlias = false
)
```

**VB**<br />
``` VB
Public Function FindByID ( 
	doc As CAEXDocument,
	id As String,
	Optional resolveAlias As Boolean = false
) As CAEXObject
```

**C++**<br />
``` C++
public:
virtual CAEXObject^ FindByID(
	CAEXDocument^ doc, 
	String^ id, 
	bool resolveAlias = false
) sealed
```


#### Parameters
&nbsp;<dl><dt>doc</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd><dt>id</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The identifier.</dd><dt>resolveAlias (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` tries to resolve an alias reference with an ExternalReferenceResolver service.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a><br />The located object with the specified ID or `null`.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IQuery_FindByID">IQuery.FindByID(CAEXDocument, String, Boolean)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_LookupService">LookupService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />