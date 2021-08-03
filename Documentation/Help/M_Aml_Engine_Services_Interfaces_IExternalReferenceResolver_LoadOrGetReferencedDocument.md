# IExternalReferenceResolver.LoadOrGetReferencedDocument Method (CAEXDocument, String)
AutomationML 2.1 API 

Determines, if the provided path contains an alias and gets the resolved document for that alias if it is already resolved. If the reference has not been resolved it is resolved.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
CAEXDocument LoadOrGetReferencedDocument(
	CAEXDocument document,
	string path
)
```

**VB**<br />
``` VB
Function LoadOrGetReferencedDocument ( 
	document As CAEXDocument,
	path As String
) As CAEXDocument
```

**C++**<br />
``` C++
CAEXDocument^ LoadOrGetReferencedDocument(
	CAEXDocument^ document, 
	String^ path
)
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The CAEX document.</dd><dt>path</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The path.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument</a><br />the resolved document for the alias, extracted from the path.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IExternalReferenceResolver">IExternalReferenceResolver Interface</a><br /><a href="Overload_Aml_Engine_Services_Interfaces_IExternalReferenceResolver_LoadOrGetReferencedDocument">LoadOrGetReferencedDocument Overload</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />