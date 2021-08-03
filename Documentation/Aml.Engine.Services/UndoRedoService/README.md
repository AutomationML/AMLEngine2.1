UndoRedoService Class
=====================
This class implements an Undo and Redo service. When this service is registered, changes in an AutomationML document can be reversed. A sequence of actions can be grouped into transactions which than can be reversed within a single undo operation. The AMLEngine will locate a registered UndoRedoService and will notify the service of any changes, made to a document. The service manages individual stacks for each loaded CAEX document.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.Services.UndoRedoService**  

  **Namespace:**  [Aml.Engine.Services][2]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public class UndoRedoService : IUndoRedo, 
	IAMLService, INotifyPropertyChanged, IXMLDocumentRegistry
```

The **UndoRedoService** type exposes the following members.


Methods
-------

                                 | Name                      | Description                                                                                                                  
-------------------------------- | ------------------------- | ---------------------------------------------------------------------------------------------------------------------------- 
![Public method]                 | [BeginTransaction][3]     | Begins a new transaction. All changes, made to a CAEXDocument inside a transaction are treated as a single operation.        
![Public method]                 | [CanRedo][4]              | Determines, if the service can redo a command                                                                                
![Public method]                 | [CanUndo][5]              | Determines, if the service can undo a command.                                                                               
![Public method]                 | [ClearStacks][6]          | Clears the stacks, managed for the specified document.                                                                       
![Public method]                 | [EndTransaction][7]       | Ends the current transaction from the specified document.                                                                    
![Public method]                 | [LastModificationDate][8] | Gets the date of the most recently executed command for the specified document.                                              
![Public method]                 | [Pause][9]                | Request to not record changes of the specified document.                                                                     
![Public method]                 | [PushCommand][10]         | A command is pushed on the undo stack of this service.                                                                       
![Public method]                 | [Redo][11]                | Executes the last undone operation from the specified document again.                                                        
![Public method]                 | [RedoActions][12]         | Gets the command names of all redo actions for the defined document.                                                         
![Public method]![Static member] | [Register][13]            | Registers a new instance of a UndoRedoService with the [ServiceLocator][14] of the AMLEngine.                                
![Public method]                 | [RemoveDocument][15]      | Removes the XML document from the internal registry of the service. Undo- and Redo Stacks for this document will be deleted. 
![Public method]                 | [Resume][16]              | Request to resume recording changes of the specified document.                                                               
![Public method]                 | [Undo][17]                | Reverses the last action of the defined document.                                                                            
![Public method]                 | [UndoActions][18]         | Gets the command names of all undo actions of the defined document.                                                          
![Public method]![Static member] | [UnRegister][19]          | Unregisters this service                                                                                                     


Events
------

                | Name                  | Description                           
--------------- | --------------------- | ------------------------------------- 
![Public event] | [PropertyChanged][20] | Occurs when a property value changes. 


See Also
--------

#### Reference
[Aml.Engine.Services Namespace][2]  
[Aml.Engine.Services.Interfaces.IUndoRedo][21]  
[System.ComponentModel.INotifyPropertyChanged][22]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: BeginTransaction.md
[4]: CanRedo.md
[5]: CanUndo.md
[6]: ClearStacks.md
[7]: EndTransaction.md
[8]: LastModificationDate.md
[9]: Pause.md
[10]: PushCommand.md
[11]: Redo.md
[12]: RedoActions.md
[13]: Register.md
[14]: ../ServiceLocator/README.md
[15]: RemoveDocument.md
[16]: Resume.md
[17]: Undo.md
[18]: UndoActions.md
[19]: UnRegister.md
[20]: PropertyChanged.md
[21]: ../../Aml.Engine.Services.Interfaces/IUndoRedo/README.md
[22]: https://docs.microsoft.com/dotnet/api/system.componentmodel.inotifypropertychanged
[23]: https://www.automationml.org
[24]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"
[Public event]: ../../icons/pubevent.gif "Public event"