CAEXObject.AssignNewGuidAsID Method
===================================
Assigns the new unique identifier as a new ID to this CAEX object.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public void AssignNewGuidAsID(
	bool updateAllIdReferences = false
)
```

#### Parameters

##### *updateAllIdReferences* (Optional)
Type: [System.Boolean][2]  
 If set to `true`, all references, where the old assigned ID is used, are changed to reference the new assigned ID. The default value is `false`


See Also
--------

#### Reference
[CAEXObject Class][3]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.boolean
[3]: README.md
[4]: https://www.automationml.org
[5]: ../../icons/logoShade.png