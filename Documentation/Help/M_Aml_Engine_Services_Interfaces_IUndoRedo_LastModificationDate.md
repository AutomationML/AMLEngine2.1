# IUndoRedo.LastModificationDate Method 
AutomationML 2.1 API 

Gets the date of the most recently executed command for the specified document.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
DateTime LastModificationDate(
	CAEXDocument document,
	bool undo = true
)
```

**VB**<br />
``` VB
Function LastModificationDate ( 
	document As CAEXDocument,
	Optional undo As Boolean = true
) As DateTime
```

**C++**<br />
``` C++
DateTime LastModificationDate(
	CAEXDocument^ document, 
	bool undo = true
)
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd><dt>undo (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` the date of the last undo operation is returned; otherwise the date of the last redo operation.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.datetime" target="_parent" rel="noopener noreferrer">DateTime</a><br />\[Missing <returns> documentation for "M:Aml.Engine.Services.Interfaces.IUndoRedo.LastModificationDate(Aml.Engine.CAEX.CAEXDocument,System.Boolean)"\]

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IUndoRedo">IUndoRedo Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />