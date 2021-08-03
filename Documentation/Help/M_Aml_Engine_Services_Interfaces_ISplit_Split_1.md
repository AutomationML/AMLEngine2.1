# ISplit.Split Method (CAEXDocument, String, String)
AutomationML 2.1 API 

Splits the specified document on all currently defined split points. The created libraries are saved in an AutomationML document and an ExternalReference is created, using the specified alias. All remaining references to the external source are renamed using the provided alias. After splitting, the document doesn't contain any SplitPoints any more.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
CAEXDocument Split(
	CAEXDocument document,
	string alias,
	string filePath
)
```

**VB**<br />
``` VB
Function Split ( 
	document As CAEXDocument,
	alias As String,
	filePath As String
) As CAEXDocument
```

**C++**<br />
``` C++
CAEXDocument^ Split(
	CAEXDocument^ document, 
	String^ alias, 
	String^ filePath
)
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd><dt>alias</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The alias name used to define the ExternalReference.</dd><dt>filePath</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The file path to the saved Split parts.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument</a><br />The CAEX document containing the split parts.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_ISplit">ISplit Interface</a><br /><a href="Overload_Aml_Engine_Services_Interfaces_ISplit_Split">Split Overload</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />