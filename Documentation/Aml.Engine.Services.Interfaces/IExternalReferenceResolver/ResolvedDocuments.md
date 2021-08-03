IExternalReferenceResolver.ResolvedDocuments Method
===================================================
AutomationML 2.1 APIGets all already resolved externals for the provided CAEXDocument containing ExternalReference objects

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
IEnumerable<CAEXDocument> ResolvedDocuments(
	CAEXDocument documentWithExternals
)
```

#### Parameters

##### *documentWithExternals*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
The CAEX document containing ExternalRefrence objects.

#### Return Value
Type: [IEnumerable][3]&lt;[CAEXDocument][2]>  
 An enumeration of all resolved documents. 

See Also
--------

#### Reference
[IExternalReferenceResolver Interface][4]  
[Aml.Engine.Services.Interfaces Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png