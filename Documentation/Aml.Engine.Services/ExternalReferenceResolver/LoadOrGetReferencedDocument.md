ExternalReferenceResolver.LoadOrGetReferencedDocument Method (CAEXDocument, String)
===================================================================================
Determines, if the provided path contains an alias and gets the resolved document for that alias.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public CAEXDocument LoadOrGetReferencedDocument(
	CAEXDocument document,
	string path
)
```

#### Parameters

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
The CAEX document, which provides the ExternalReference to resolve the 'Alias'.

##### *path*
Type: [System.String][3]  
The CAEX path which contains an 'Alias'.

#### Return Value
Type: [CAEXDocument][2]  
 The resolved document for the alias, extracted from the path. 
#### Implements
[IExternalReferenceResolver.LoadOrGetReferencedDocument(CAEXDocument, String)][4]  


See Also
--------

#### Reference
[ExternalReferenceResolver Class][5]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: ../../Aml.Engine.Services.Interfaces/IExternalReferenceResolver/LoadOrGetReferencedDocument.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png