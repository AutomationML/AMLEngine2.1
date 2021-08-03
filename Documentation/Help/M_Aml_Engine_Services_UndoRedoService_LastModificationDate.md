# UndoRedoService.LastModificationDate Method 
AutomationML 2.1 API 

Gets the date of the most recently executed command for the specified document.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public DateTime LastModificationDate(
	CAEXDocument document,
	bool undo = true
)
```

**VB**<br />
``` VB
Public Function LastModificationDate ( 
	document As CAEXDocument,
	Optional undo As Boolean = true
) As DateTime
```

**C++**<br />
``` C++
public:
virtual DateTime LastModificationDate(
	CAEXDocument^ document, 
	bool undo = true
) sealed
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd><dt>undo (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` the last undo operation is considered; otherwise the last redo operation.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.datetime" target="_parent" rel="noopener noreferrer">DateTime</a><br />\[Missing <returns> documentation for "M:Aml.Engine.Services.UndoRedoService.LastModificationDate(Aml.Engine.CAEX.CAEXDocument,System.Boolean)"\]

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IUndoRedo_LastModificationDate">IUndoRedo.LastModificationDate(CAEXDocument, Boolean)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_UndoRedoService">UndoRedoService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />