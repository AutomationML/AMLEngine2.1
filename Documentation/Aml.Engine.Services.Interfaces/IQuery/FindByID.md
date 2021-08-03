IQuery.FindByID Method
======================
Tries to locate a CAEX object from the specified ID. If the ID uses an alias reference and an [IExternalReferenceResolver][1] can be located, it is tried to resolve the external reference and to get the object from the external source.

  **Namespace:**  [Aml.Engine.Services.Interfaces][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
CAEXObject FindByID(
	CAEXDocument doc,
	string id,
	bool resolveAlias = false
)
```

#### Parameters

##### *doc*
Type: [Aml.Engine.CAEX.CAEXDocument][3]  
The document.

##### *id*
Type: [System.String][4]  
The identifier.

##### *resolveAlias* (Optional)
Type: [System.Boolean][5]  
 if set to `true` tries to resolve an alias reference with an ExternalReferenceResolver service.

#### Return Value
Type: [CAEXObject][6]  
 The CAEX object if it is found; otherwise `null`. 

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