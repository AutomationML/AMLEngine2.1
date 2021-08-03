# IMerge.Merge Method (CAEXDocument, ExternalReferenceType, String[], Boolean)
AutomationML 2.1 API 

Merges the defined ExternalReference into the provided CAEXDocument. The source is loaded from the file path in the external reference.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
bool Merge(
	CAEXDocument document,
	ExternalReferenceType externalReference,
	out string[] mergeProtocol,
	bool autoTransform = false
)
```

**VB**<br />
``` VB
Function Merge ( 
	document As CAEXDocument,
	externalReference As ExternalReferenceType,
	<OutAttribute> ByRef mergeProtocol As String(),
	Optional autoTransform As Boolean = false
) As Boolean
```

**C++**<br />
``` C++
bool Merge(
	CAEXDocument^ document, 
	ExternalReferenceType^ externalReference, 
	[OutAttribute] array<String^>^% mergeProtocol, 
	bool autoTransform = false
)
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd><dt>externalReference</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ExternalReferenceType">Aml.Engine.CAEX.ExternalReferenceType</a><br />The external reference.</dd><dt>mergeProtocol</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a>[]<br />The merge protocol.</dd><dt>autoTransform (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` the service performs a schema transformation if necessary.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true`, if merge was successful

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IMerge">IMerge Interface</a><br /><a href="Overload_Aml_Engine_Services_Interfaces_IMerge_Merge">Merge Overload</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />