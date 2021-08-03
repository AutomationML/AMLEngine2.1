UndoRedoService.UndoActions Method
==================================
AutomationML 2.1 APIGets the command names of all undo actions of the defined document.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public IEnumerable<string> UndoActions(
	CAEXDocument document
)
```

#### Parameters

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
The document.

#### Return Value
Type: [IEnumerable][3]&lt;[String][4]>  
 List of command names. 
#### Implements
[IUndoRedo.UndoActions(CAEXDocument)][5]  


See Also
--------

#### Reference
[UndoRedoService Class][6]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: ../../Aml.Engine.Services.Interfaces/IUndoRedo/UndoActions.md
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png