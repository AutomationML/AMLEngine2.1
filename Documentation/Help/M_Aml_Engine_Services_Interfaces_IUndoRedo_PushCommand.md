# IUndoRedo.PushCommand Method 
AutomationML 2.1 API 

A new command is pushed on the undo stack of this service.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
void PushCommand(
	ICAEXCommand cmd
)
```

**VB**<br />
``` VB
Sub PushCommand ( 
	cmd As ICAEXCommand
)
```

**C++**<br />
``` C++
void PushCommand(
	ICAEXCommand^ cmd
)
```


#### Parameters
&nbsp;<dl><dt>cmd</dt><dd>Type: <a href="T_Aml_Engine_CAEX_Commands_ICAEXCommand">Aml.Engine.CAEX.Commands.ICAEXCommand</a><br />The command.</dd></dl>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IUndoRedo">IUndoRedo Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />