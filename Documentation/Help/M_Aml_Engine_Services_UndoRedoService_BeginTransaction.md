# UndoRedoService.BeginTransaction Method 
AutomationML 2.1 API 

Begins a new transaction. All changes, made to a CAEXDocument inside a transaction are treated as a single operation.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool BeginTransaction(
	CAEXDocument document,
	string name = ""
)
```

**VB**<br />
``` VB
Public Function BeginTransaction ( 
	document As CAEXDocument,
	Optional name As String = ""
) As Boolean
```

**C++**<br />
``` C++
public:
virtual bool BeginTransaction(
	CAEXDocument^ document, 
	String^ name = L""
) sealed
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The CAEX document to which the transaction should be associated.</dd><dt>name (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />A friendly name for this transaction.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />If the transaction started.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IUndoRedo_BeginTransaction">IUndoRedo.BeginTransaction(CAEXDocument, String)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_UndoRedoService">UndoRedoService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />