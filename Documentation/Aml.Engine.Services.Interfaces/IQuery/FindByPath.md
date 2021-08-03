IQuery.FindByPath Method
========================
Tries to locates a CAEX object from the specified CAEX - Path. If the path uses an alias reference and an [IExternalReferenceResolver][1] can be located, it is tried to resolve the external reference and to get the object from the external source.

  **Namespace:**  [Aml.Engine.Services.Interfaces][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
CAEXObject FindByPath(
	CAEXDocument caexDocument,
	string path,
	bool resolveAlias = false
)
```

#### Parameters

##### *caexDocument*
Type: [Aml.Engine.CAEX.CAEXDocument][3]  
The document.

##### *path*
Type: [System.String][4]  
The path.

##### *resolveAlias* (Optional)
Type: [System.Boolean][5]  
 if set to `true` tries to resolve an alias reference with an ExternalReferenceResolver service.

#### Return Value
Type: [CAEXObject][6]  
The CAEXObject if it is found; otherwise `null`.

See Also
--------

#### Reference
[IQuery Interface][7]  
[Aml.Engine.Services.Interfaces Namespace][2]  

[1]: ../IExternalReferenceResolver/README.md
[2]: ../README.md
[3]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: ../../Aml.Engine.CAEX/CAEXObject/README.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png