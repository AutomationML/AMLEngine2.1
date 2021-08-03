# UndoRedoService.PushCommand Method 
AutomationML 2.1 API 

A command is pushed on the undo stack of this service.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public void PushCommand(
	ICAEXCommand cmd
)
```

**VB**<br />
``` VB
Public Sub PushCommand ( 
	cmd As ICAEXCommand
)
```

**C++**<br />
``` C++
public:
virtual void PushCommand(
	ICAEXCommand^ cmd
) sealed
```


#### Parameters
&nbsp;<dl><dt>cmd</dt><dd>Type: <a href="T_Aml_Engine_CAEX_Commands_ICAEXCommand">Aml.Engine.CAEX.Commands.ICAEXCommand</a><br />the CAEX command.</dd></dl>

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IUndoRedo_PushCommand">IUndoRedo.PushCommand(ICAEXCommand)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_UndoRedoService">UndoRedoService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />