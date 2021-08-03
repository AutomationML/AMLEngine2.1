IUndoRedo.UndoActions Method
============================
Gets all command names of the actions in the undo stack for the provided CAEX document.

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
IEnumerable<string> UndoActions(
	CAEXDocument document
)
```

#### Parameters

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
The document.

#### Return Value
Type: [IEnumerable][3]&lt;[String][4]>  
List of command names

See Also
--------

#### Reference
[IUndoRedo Interface][5]  
[Aml.Engine.Services.Interfaces Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png