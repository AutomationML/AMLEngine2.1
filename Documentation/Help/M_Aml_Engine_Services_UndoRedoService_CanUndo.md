# UndoRedoService.CanUndo Method 
AutomationML 2.1 API 

Determines, if the service can undo a command.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool CanUndo(
	CAEXDocument document
)
```

**VB**<br />
``` VB
Public Function CanUndo ( 
	document As CAEXDocument
) As Boolean
```

**C++**<br />
``` C++
public:
virtual bool CanUndo(
	CAEXDocument^ document
) sealed
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if this instance can undo any command from the specified document; otherwise, `false`.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IUndoRedo_CanUndo">IUndoRedo.CanUndo(CAEXDocument)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_UndoRedoService">UndoRedoService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />