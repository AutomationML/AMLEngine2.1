# ICAEXCommand Interface
AutomationML 2.1 API 

Interface for CAEXCommands. If Commands implement this interface, they can use a <a href="T_Aml_Engine_Services_Interfaces_IUndoRedo">IUndoRedo</a> to enable undo and redo.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Commands">Aml.Engine.CAEX.Commands</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public interface ICAEXCommand
```

**VB**<br />
``` VB
Public Interface ICAEXCommand
```

**C++**<br />
``` C++
public interface class ICAEXCommand
```

The ICAEXCommand type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_Commands_ICAEXCommand_CAEXDocument">CAEXDocument</a></td><td>
Gets the CAEX document.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_Commands_ICAEXCommand_DisplayName">DisplayName</a></td><td>
Gets the display name.</td></tr></table>&nbsp;
<a href="#icaexcommand-interface">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_Commands_ICAEXCommand_Execute">Execute</a></td><td>
Command Execution Method (enables redo)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_Commands_ICAEXCommand_UnExecute">UnExecute</a></td><td>
Command reverse execution Method (enables undo)</td></tr></table>&nbsp;
<a href="#icaexcommand-interface">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_CAEX_Commands">Aml.Engine.CAEX.Commands Namespace</a><br />