# CaexCommand.OnCAEXElementChangedEvent Method 
AutomationML 2.1 API 

Raises the <a href="E_Aml_Engine_CAEX_Commands_CaexCommand_CAEXElementChangedEvent">CAEXElementChangedEvent</a> for the provided document.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Commands">Aml.Engine.CAEX.Commands</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static void OnCAEXElementChangedEvent(
	XDocument document,
	CAEXElementChangeEventArgs args
)
```

**VB**<br />
``` VB
Public Shared Sub OnCAEXElementChangedEvent ( 
	document As XDocument,
	args As CAEXElementChangeEventArgs
)
```

**C++**<br />
``` C++
public:
static void OnCAEXElementChangedEvent(
	XDocument^ document, 
	CAEXElementChangeEventArgs^ args
)
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xdocument" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XDocument</a><br />The document.</dd><dt>args</dt><dd>Type: <a href="T_Aml_Engine_CAEX_Commands_CAEXElementChangeEventArgs">Aml.Engine.CAEX.Commands.CAEXElementChangeEventArgs</a><br />The <a href="T_Aml_Engine_CAEX_Commands_CAEXElementChangeEventArgs">CAEXElementChangeEventArgs</a> instance containing the event data.</dd></dl>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Commands_CaexCommand">CaexCommand Class</a><br /><a href="N_Aml_Engine_CAEX_Commands">Aml.Engine.CAEX.Commands Namespace</a><br />