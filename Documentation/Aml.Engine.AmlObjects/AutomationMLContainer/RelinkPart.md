AutomationMLContainer.RelinkPart Method
=======================================
Changes the uri of a package part. The part is removed and readded with the provided *newPartUri*. All relationships of the part are updated.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool RelinkPart(
	Uri oldPartUri,
	Uri newPartUri
)
```

#### Parameters

##### *oldPartUri*
Type: [System.Uri][2]  


##### *newPartUri*
Type: [System.Uri][2]  


#### Return Value
Type: [Boolean][3]  
`true` if a part with the provided *oldPartUri* exists; otherwise false

See Also
--------

#### Reference
[AutomationMLContainer Class][4]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.uri
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png