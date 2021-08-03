ICAEXContainer.Insert Method
============================
Inserts the specified CAEX object in its associated container.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
bool Insert(
	CAEXWrapper caexObject,
	bool asFirst = true
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXWrapper][2]  
The CAEX object.

##### *asFirst* (Optional)
Type: [System.Boolean][3]  
if set to `true` insert it at the first position.

#### Return Value
Type: [Boolean][3]  
`true`, if inserted; otherwise `false`.

See Also
--------

#### Reference
[ICAEXContainer Interface][4]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../CAEXWrapper/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png