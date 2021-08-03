# Aml.Engine.CAEX.Commands Namespace
AutomationML 2.1 API 

The Aml.Engine.CAEX.Commands Namespace contains different commands that are provided to add, delete or change elements in a CAEX document. The classes support the implementation of Undo Redo using the command pattern with methods for command execution and reverse execution. If an Undo Redo service is registered, it will be located by the commands and used to push commands on the Undo Redo stack.


## Classes
&nbsp;<table><tr><th></th><th>Class</th><th>Description</th></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Aml_Engine_CAEX_Commands_CaexCommand">CaexCommand</a></td><td>
This is the abstract base class for all CAEX commands, applicable to CAEX elements</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Aml_Engine_CAEX_Commands_CAEXElementChangeEventArgs">CAEXElementChangeEventArgs</a></td><td>
Event arguments for a <a href="E_Aml_Engine_CAEX_Commands_CaexCommand_CAEXElementChangingEvent">CAEXElementChangingEvent</a> and a <a href="E_Aml_Engine_CAEX_Commands_CaexCommand_CAEXElementChangedEvent">CAEXElementChangedEvent</a></td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Aml_Engine_CAEX_Commands_WeakEventSource_1">WeakEventSource(TEventArgs)</a></td><td>
This Class defines a WeakEventSource, used to define Events, raised in the AML Engine.</td></tr></table>

## Interfaces
&nbsp;<table><tr><th></th><th>Interface</th><th>Description</th></tr><tr><td>![Public interface](media/pubinterface.gif "Public interface")</td><td><a href="T_Aml_Engine_CAEX_Commands_ICAEXCommand">ICAEXCommand</a></td><td>
Interface for CAEXCommands. If Commands implement this interface, they can use a <a href="T_Aml_Engine_Services_Interfaces_IUndoRedo">IUndoRedo</a> to enable undo and redo.</td></tr></table>

## Enumerations
&nbsp;<table><tr><th></th><th>Enumeration</th><th>Description</th></tr><tr><td>![Public enumeration](media/pubenumeration.gif "Public enumeration")</td><td><a href="T_Aml_Engine_CAEX_Commands_CAEXElementChangeMode">CAEXElementChangeMode</a></td><td>
This enum defines possible changes of a CAEX object. The changes are notified in a <a href="T_Aml_Engine_CAEX_Commands_CAEXElementChangeMode">ChangedEvent</a> or a <a href="T_Aml_Engine_CAEX_Commands_CAEXElementChangeMode">ChangingEvent</a>.</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Commands_ICAEXCommand">Aml.Engine.CAEX.Commands.ICAEXCommand</a><br />