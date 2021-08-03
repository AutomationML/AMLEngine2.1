ExternalReferenceResolver.ResolvedDocuments Method
==================================================
AutomationML 2.1 APIGets all already resolved externals for the provided CAEXDocument containing ExternalReference objects

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public IEnumerable<CAEXDocument> ResolvedDocuments(
	CAEXDocument documentWithExternals
)
```

#### Parameters

##### *documentWithExternals*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
The CAEX document, containing ExternalReference objects.

#### Return Value
Type: [IEnumerable][3]&lt;[CAEXDocument][2]>  
 An enumeration of all CAEX documents, which have been loaded from the ExternalReferences. 
#### Implements
[IExternalReferenceResolver.ResolvedDocuments(CAEXDocument)][4]  


See Also
--------

#### Reference
[ExternalReferenceResolver Class][5]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: ../../Aml.Engine.Services.Interfaces/IExternalReferenceResolver/ResolvedDocuments.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png