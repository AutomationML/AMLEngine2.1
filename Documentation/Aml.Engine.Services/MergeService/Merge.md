MergeService.Merge Method (CAEXDocument, ExternalReferenceType, Stream, String[], Boolean)
==========================================================================================
AutomationML 2.1 APIMerges the defined ExternalReference into the provided CAEXDocument. The source is loaded from the provided external source stream.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public bool Merge(
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
#### Implements
[IMerge.Merge(CAEXDocument, ExternalReferenceType, Stream, String[], Boolean)][7]  


See Also
--------

#### Reference
[MergeService Class][8]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: ../../Aml.Engine.CAEX/ExternalReferenceType/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.io.stream
[5]: https://docs.microsoft.com/dotnet/api/system.string
[6]: https://docs.microsoft.com/dotnet/api/system.boolean
[7]: ../../Aml.Engine.Services.Interfaces/IMerge/Merge.md
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png