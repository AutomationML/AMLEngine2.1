# IUndoRedo.Pause Method 
AutomationML 2.1 API 

Request to not record changes of the specified document. If the recording of document changes is paused the <a href="M_Aml_Engine_Services_Interfaces_IUndoRedo_Undo">Undo(CAEXDocument)</a> and <a href="M_Aml_Engine_Services_Interfaces_IUndoRedo_Redo">Redo(CAEXDocument)</a> methods can not be applied.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
void Pause(
	CAEXDocument document
)
```

**VB**<br />
``` VB
Sub Pause ( 
	document As CAEXDocument
)
```

**C++**<br />
``` C++
void Pause(
	CAEXDocument^ document
)
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd></dl>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IUndoRedo">IUndoRedo Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />