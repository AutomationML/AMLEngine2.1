# UndoRedoService.CanRedo Method 
AutomationML 2.1 API 

Determines, if the service can redo a command

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool CanRedo(
	CAEXDocument document
)
```

**VB**<br />
``` VB
Public Function CanRedo ( 
	document As CAEXDocument
) As Boolean
```

**C++**<br />
``` C++
public:
virtual bool CanRedo(
	CAEXDocument^ document
) sealed
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if this instance can redo any undone command from the specified document; otherwise, `false`.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IUndoRedo_CanRedo">IUndoRedo.CanRedo(CAEXDocument)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_UndoRedoService">UndoRedoService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />