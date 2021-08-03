# AMLGroup.Create Method 
AutomationML 2.1 API 

Creates an AMLGroup AML object with this name, using the provided document.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static AMLGroup Create(
	CAEXDocument document,
	string name
)
```

**VB**<br />
``` VB
Public Shared Function Create ( 
	document As CAEXDocument,
	name As String
) As AMLGroup
```

**C++**<br />
``` C++
public:
static AMLGroup^ Create(
	CAEXDocument^ document, 
	String^ name
)
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The CAEX document.</dd><dt>name</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The name of the new AMLGroup object.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_AmlObjects_AMLGroup">AMLGroup</a><br />The new AMLGroup object.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AMLGroup">AMLGroup Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />