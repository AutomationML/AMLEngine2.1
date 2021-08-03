LookupService.FindByID Method
=============================
Locates a CAEX object in the provided document using the specified ID - Attribute for identification.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public CAEXObject FindByID(
	CAEXDocument doc,
	string id,
	bool resolveAlias = false
)
```

#### Parameters

##### *doc*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
The document.

##### *id*
Type: [System.String][3]  
The identifier.

##### *resolveAlias* (Optional)
Type: [System.Boolean][4]  
 if set to `true` tries to resolve an alias reference with an ExternalReferenceResolver service.

#### Return Value
Type: [CAEXObject][5]  
 The located object with the specified ID or `null`. 
#### Implements
[IQuery.FindByID(CAEXDocument, String, Boolean)][6]  


See Also
--------

#### Reference
[LookupService Class][7]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: ../../Aml.Engine.CAEX/CAEXObject/README.md
[6]: ../../Aml.Engine.Services.Interfaces/IQuery/FindByID.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png