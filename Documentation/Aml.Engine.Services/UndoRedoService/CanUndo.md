UndoRedoService.CanUndo Method
==============================
Determines, if the service can undo a command.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public bool CanUndo(
	CAEXDocument document
)
```

#### Parameters

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
The document.

#### Return Value
Type: [Boolean][3]  
`true` if this instance can undo any command from the specified document; otherwise, `false`. 
#### Implements
[IUndoRedo.CanUndo(CAEXDocument)][4]  


See Also
--------

#### Reference
[UndoRedoService Class][5]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: ../../Aml.Engine.Services.Interfaces/IUndoRedo/CanUndo.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png