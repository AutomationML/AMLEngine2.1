ICAEXCommand Interface
======================
Interface for CAEXCommands. If Commands implement this interface, they can use a [IUndoRedo][1] to enable undo and redo.

  **Namespace:**  [Aml.Engine.CAEX.Commands][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public interface ICAEXCommand
```

The **ICAEXCommand** type exposes the following members.


Properties
----------

                   | Name              | Description             
------------------ | ----------------- | ----------------------- 
![Public property] | [CAEXDocument][3] | Gets the CAEX document. 
![Public property] | [DisplayName][4]  | Gets the display name.  


Methods
-------

                 | Name           | Description                                     
---------------- | -------------- | ----------------------------------------------- 
![Public method] | [Execute][5]   | Command Execution Method (enables redo)         
![Public method] | [UnExecute][6] | Command reverse execution Method (enables undo) 


See Also
--------

#### Reference
[Aml.Engine.CAEX.Commands Namespace][2]  

[1]: ../../Aml.Engine.Services.Interfaces/IUndoRedo/README.md
[2]: ../README.md
[3]: CAEXDocument.md
[4]: DisplayName.md
[5]: Execute.md
[6]: UnExecute.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"