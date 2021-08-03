# UndoRedoService.EndTransaction Method 
AutomationML 2.1 API 

Ends the current transaction from the specified document.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool EndTransaction(
	CAEXDocument document
)
```

**VB**<br />
``` VB
Public Function EndTransaction ( 
	document As CAEXDocument
) As Boolean
```

**C++**<br />
``` C++
public:
virtual bool EndTransaction(
	CAEXDocument^ document
) sealed
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />If the transaction ended

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IUndoRedo_EndTransaction">IUndoRedo.EndTransaction(CAEXDocument)</a><br />

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.invalidoperationexception" target="_parent" rel="noopener noreferrer">InvalidOperationException</a></td><td>No matching Transaction Begin</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_UndoRedoService">UndoRedoService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />