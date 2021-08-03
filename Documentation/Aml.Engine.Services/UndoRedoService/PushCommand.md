UndoRedoService.PushCommand Method
==================================
A command is pushed on the undo stack of this service.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public void PushCommand(
	ICAEXCommand cmd
)
```

#### Parameters

##### *cmd*
Type: [Aml.Engine.CAEX.Commands.ICAEXCommand][2]  
the CAEX command.

#### Implements
[IUndoRedo.PushCommand(ICAEXCommand)][3]  


See Also
--------

#### Reference
[UndoRedoService Class][4]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX.Commands/ICAEXCommand/README.md
[3]: ../../Aml.Engine.Services.Interfaces/IUndoRedo/PushCommand.md
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png