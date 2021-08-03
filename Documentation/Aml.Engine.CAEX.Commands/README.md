Aml.Engine.CAEX.Commands Namespace
==================================
The Aml.Engine.CAEX.Commands Namespace contains different commands that are provided to add, delete or change elements in a CAEX document. The classes support the implementation of Undo Redo using the command pattern with methods for command execution and reverse execution. If an Undo Redo service is registered, it will be located by the commands and used to push commands on the Undo Redo stack.


Classes
-------

                | Class                               | Description                                                                            
--------------- | ----------------------------------- | -------------------------------------------------------------------------------------- 
![Public class] | [CaexCommand][1]                    | This is the abstract base class for all CAEX commands, applicable to CAEX elements     
![Public class] | [CAEXElementChangeEventArgs][2]     | Event arguments for a [CAEXElementChangingEvent][3] and a [CAEXElementChangedEvent][4] 
![Public class] | [WeakEventSource&lt;TEventArgs>][5] | This Class defines a WeakEventSource, used to define Events, raised in the AML Engine. 


Interfaces
----------

                    | Interface         | Description                                                                                                              
------------------- | ----------------- | ------------------------------------------------------------------------------------------------------------------------ 
![Public interface] | [ICAEXCommand][6] | Interface for CAEXCommands. If Commands implement this interface, they can use a [IUndoRedo][7] to enable undo and redo. 


Enumerations
------------

                      | Enumeration                | Description                                                                                                                   
--------------------- | -------------------------- | ----------------------------------------------------------------------------------------------------------------------------- 
![Public enumeration] | [CAEXElementChangeMode][8] | This enum defines possible changes of a CAEX object. The changes are notified in a [ChangedEvent][8] or a [ChangingEvent][8]. 


See Also
--------

#### Reference
[Aml.Engine.CAEX.Commands.ICAEXCommand][6]  

[1]: CaexCommand/README.md
[2]: CAEXElementChangeEventArgs/README.md
[3]: CaexCommand/CAEXElementChangingEvent.md
[4]: CaexCommand/CAEXElementChangedEvent.md
[5]: WeakEventSource_1/README.md
[6]: ICAEXCommand/README.md
[7]: ../Aml.Engine.Services.Interfaces/IUndoRedo/README.md
[8]: CAEXElementChangeMode/README.md
[9]: https://www.automationml.org
[10]: ../icons/logoShade.png
[Public class]: ../icons/pubclass.gif "Public class"
[Public interface]: ../icons/pubinterface.gif "Public interface"
[Public enumeration]: ../icons/pubenumeration.gif "Public enumeration"