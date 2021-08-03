# IQuery.FindByPath Method 
AutomationML 2.1 API 

Tries to locates a CAEX object from the specified CAEX - Path. If the path uses an alias reference and an <a href="T_Aml_Engine_Services_Interfaces_IExternalReferenceResolver">IExternalReferenceResolver</a> can be located, it is tried to resolve the external reference and to get the object from the external source.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
CAEXObject FindByPath(
	CAEXDocument caexDocument,
	string path,
	bool resolveAlias = false
)
```

**VB**<br />
``` VB
Function FindByPath ( 
	caexDocument As CAEXDocument,
	path As String,
	Optional resolveAlias As Boolean = false
) As CAEXObject
```

**C++**<br />
``` C++
CAEXObject^ FindByPath(
	CAEXDocument^ caexDocument, 
	String^ path, 
	bool resolveAlias = false
)
```


#### Parameters
&nbsp;<dl><dt>caexDocument</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd><dt>path</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The path.</dd><dt>resolveAlias (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` tries to resolve an alias reference with an ExternalReferenceResolver service.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a><br />The CAEXObject if it is found; otherwise `null`.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IQuery">IQuery Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />