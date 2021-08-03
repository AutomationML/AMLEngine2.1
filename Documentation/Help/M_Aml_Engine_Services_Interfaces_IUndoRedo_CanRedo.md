# IUndoRedo.CanRedo Method 
AutomationML 2.1 API 

Determines, if the service can redo a command

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
bool CanRedo(
	CAEXDocument document
)
```

**VB**<br />
``` VB
Function CanRedo ( 
	document As CAEXDocument
) As Boolean
```

**C++**<br />
``` C++
bool CanRedo(
	CAEXDocument^ document
)
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if this instance can redo the specified document; otherwise, `false`.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IUndoRedo">IUndoRedo Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />