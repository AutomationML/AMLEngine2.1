ServiceLocator.UndoRedoService Property
=======================================
AutomationML 2.1 APIGets the registered UndoRedo-Service. The actual registered UndoRedo-Service is located by the engine and used to push executed commands on the undo stack. If no UndoRedo-Service is registered executed commands are not pushed and cannot be undone.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IUndoRedo UndoRedoService { get; }
```

#### Property Value
Type: [IUndoRedo][2]

See Also
--------

#### Reference
[ServiceLocator Class][3]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.Services.Interfaces/IUndoRedo/README.md
[3]: README.md
[4]: https://www.automationml.org
[5]: ../../icons/logoShade.png