# UndoRedoService.RedoActions Method 
AutomationML 2.1 API 

Gets the command names of all redo actions for the defined document.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<string> RedoActions(
	CAEXDocument document
)
```

**VB**<br />
``` VB
Public Function RedoActions ( 
	document As CAEXDocument
) As IEnumerable(Of String)
```

**C++**<br />
``` C++
public:
virtual IEnumerable<String^>^ RedoActions(
	CAEXDocument^ document
) sealed
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>)<br />List of command names

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IUndoRedo_RedoActions">IUndoRedo.RedoActions(CAEXDocument)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_UndoRedoService">UndoRedoService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />