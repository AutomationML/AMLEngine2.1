# UndoRedoService.Pause Method 
AutomationML 2.1 API 

Request to not record changes of the specified document.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public void Pause(
	CAEXDocument document
)
```

**VB**<br />
``` VB
Public Sub Pause ( 
	document As CAEXDocument
)
```

**C++**<br />
``` C++
public:
virtual void Pause(
	CAEXDocument^ document
) sealed
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd></dl>

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IUndoRedo_Pause">IUndoRedo.Pause(CAEXDocument)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_UndoRedoService">UndoRedoService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />