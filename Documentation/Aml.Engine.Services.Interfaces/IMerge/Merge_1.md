IMerge.Merge Method (CAEXDocument, ExternalReferenceType, String[], Boolean)
============================================================================
Merges the defined ExternalReference into the provided CAEXDocument. The source is loaded from the file path in the external reference.

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
bool Merge(
	CAEXDocument document,
	ExternalReferenceType externalReference,
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

##### *mergeProtocol*
Type: [System.String][4][]  
The merge protocol.

##### *autoTransform* (Optional)
Type: [System.Boolean][5]  
if set to `true` the service performs a schema transformation if necessary.

#### Return Value
Type: [Boolean][5]  
`true`, if merge was successful 

See Also
--------

#### Reference
[IMerge Interface][6]  
[Aml.Engine.Services.Interfaces Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: ../../Aml.Engine.CAEX/ExternalReferenceType/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png