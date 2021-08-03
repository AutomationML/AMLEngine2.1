# MergeService.Merge Method (CAEXDocument, ExternalReferenceType, Stream, String[], Boolean)
AutomationML 2.1 API 

Merges the defined ExternalReference into the provided CAEXDocument. The source is loaded from the provided external source stream.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool Merge(
	CAEXDocument document,
	ExternalReferenceType externalReference,
	Stream externalSource,
	out string[] mergeProtocol,
	bool autoTransform = false
)
```

**VB**<br />
``` VB
Public Function Merge ( 
	document As CAEXDocument,
	externalReference As ExternalReferenceType,
	externalSource As Stream,
	<OutAttribute> ByRef mergeProtocol As String(),
	Optional autoTransform As Boolean = false
) As Boolean
```

**C++**<br />
``` C++
public:
virtual bool Merge(
	CAEXDocument^ document, 
	ExternalReferenceType^ externalReference, 
	Stream^ externalSource, 
	[OutAttribute] array<String^>^% mergeProtocol, 
	bool autoTransform = false
) sealed
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd><dt>externalReference</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ExternalReferenceType">Aml.Engine.CAEX.ExternalReferenceType</a><br />The external reference.</dd><dt>externalSource</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.io.stream" target="_parent" rel="noopener noreferrer">System.IO.Stream</a><br />The external source stream.</dd><dt>mergeProtocol</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a>[]<br />The merge protocol.</dd><dt>autoTransform (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` the service performs a schema transformation if necessary.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true`, if merge was successful

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IMerge_Merge">IMerge.Merge(CAEXDocument, ExternalReferenceType, Stream, String[], Boolean)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_MergeService">MergeService Class</a><br /><a href="Overload_Aml_Engine_Services_MergeService_Merge">Merge Overload</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />