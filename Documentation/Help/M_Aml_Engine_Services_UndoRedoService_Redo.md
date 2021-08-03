# UndoRedoService.Redo Method 
AutomationML 2.1 API 

Executes the last undone operation from the specified document again.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public void Redo(
	CAEXDocument document
)
```

**VB**<br />
``` VB
Public Sub Redo ( 
	document As CAEXDocument
)
```

**C++**<br />
``` C++
public:
virtual void Redo(
	CAEXDocument^ document
) sealed
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd></dl>

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IUndoRedo_Redo">IUndoRedo.Redo(CAEXDocument)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_UndoRedoService">UndoRedoService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />