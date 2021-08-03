MergeService.Merge Method (CAEXDocument, ExternalReferenceType, String[], Boolean)
==================================================================================
AutomationML 2.1 APIMerges the defined ExternalReference into the provided CAEXDocument.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public bool Merge(
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
#### Implements
[IMerge.Merge(CAEXDocument, ExternalReferenceType, String[], Boolean)][6]  


See Also
--------

#### Reference
[MergeService Class][7]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: ../../Aml.Engine.CAEX/ExternalReferenceType/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: ../../Aml.Engine.Services.Interfaces/IMerge/Merge_1.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png