IMerge.Merge Method (CAEXDocument, ExternalReferenceType, Stream, String[], Boolean)
====================================================================================
Merges the defined ExternalReference into the provided CAEXDocument. The source is loaded from the provided external source stream.

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
bool Merge(
	CAEXDocument document,
	ExternalReferenceType externalReference,
	Stream externalSource,
	out string[] mergeProtocol,
	bool autoTransform = false
)
```

#### Parameters

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
The document.

##### *externalReference*
Type: [Aml.Engine.CAEX.ExternalReferenceType][3]  
The external reference.

##### *externalSource*
Type: [System.IO.Stream][4]  
The external source stream.

##### *mergeProtocol*
Type: [System.String][5][]  
The merge protocol.

##### *autoTransform* (Optional)
Type: [System.Boolean][6]  
if set to `true` the service performs a schema transformation if necessary.

#### Return Value
Type: [Boolean][6]  
`true`, if merge was successful 

See Also
--------

#### Reference
[IMerge Interface][7]  
[Aml.Engine.Services.Interfaces Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: ../../Aml.Engine.CAEX/ExternalReferenceType/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.io.stream
[5]: https://docs.microsoft.com/dotnet/api/system.string
[6]: https://docs.microsoft.com/dotnet/api/system.boolean
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png