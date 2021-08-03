IUndoRedo Interface
===================
AutomationML 2.1 APIThe UndoRedo service supports undo and redo of all changes made to a CAEXDocument.

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public interface IUndoRedo : IAMLService
```

The **IUndoRedo** type exposes the following members.


Methods
-------

                 | Name                      | Description                                                                                                                                                                                  
---------------- | ------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [BeginTransaction][2]     | Begins a new transaction. All changes, made to a CAEXDocument inside a transaction are treated as a single operation.                                                                        
![Public method] | [CanRedo][3]              | Determines, if the service can redo a command                                                                                                                                                
![Public method] | [CanUndo][4]              | Determines, if the service can undo a command                                                                                                                                                
![Public method] | [ClearStacks][5]          | Clears the undo and redo stacks.                                                                                                                                                             
![Public method] | [EndTransaction][6]       | Ends the current transaction.                                                                                                                                                                
![Public method] | [LastModificationDate][7] | Gets the date of the most recently executed command for the specified document.                                                                                                              
![Public method] | [Pause][8]                | Request to not record changes of the specified document. If the recording of document changes is paused the [Undo(CAEXDocument)][9] and [Redo(CAEXDocument)][10] methods can not be applied. 
![Public method] | [PushCommand][11]         | A new command is pushed on the undo stack of this service.                                                                                                                                   
![Public method] | [Redo][10]                | Redo the most recently operation, which was undone                                                                                                                                           
![Public method] | [RedoActions][12]         | Gets all command names of the actions in the redo stack for the provided CAEX document.                                                                                                      
![Public method] | [Resume][13]              | Request to resume recording changes of the specified document.                                                                                                                               
![Public method] | [Undo][9]                 | Undo of the last operation                                                                                                                                                                   
![Public method] | [UndoActions][14]         | Gets all command names of the actions in the undo stack for the provided CAEX document.                                                                                                      


See Also
--------

#### Reference
[Aml.Engine.Services.Interfaces Namespace][1]  
[Aml.Engine.Services.Interfaces.IAMLService][15]  

[1]: ../README.md
[2]: BeginTransaction.md
[3]: CanRedo.md
[4]: CanUndo.md
[5]: ClearStacks.md
[6]: EndTransaction.md
[7]: LastModificationDate.md
[8]: Pause.md
[9]: Undo.md
[10]: Redo.md
[11]: PushCommand.md
[12]: RedoActions.md
[13]: Resume.md
[14]: UndoActions.md
[15]: ../IAMLService/README.md
[16]: https://www.automationml.org
[17]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"