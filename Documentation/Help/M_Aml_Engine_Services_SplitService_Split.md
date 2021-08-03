# SplitService.Split Method (CAEXDocument, ISplitPoint, String, String)
AutomationML 2.1 API 

Splits the specified source document.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public CAEXDocument Split(
	CAEXDocument sourceDocument,
	ISplitPoint splitPoint,
	string alias,
	string filePath
)
```

**VB**<br />
``` VB
Public Function Split ( 
	sourceDocument As CAEXDocument,
	splitPoint As ISplitPoint,
	alias As String,
	filePath As String
) As CAEXDocument
```

**C++**<br />
``` C++
public:
virtual CAEXDocument^ Split(
	CAEXDocument^ sourceDocument, 
	ISplitPoint^ splitPoint, 
	String^ alias, 
	String^ filePath
) sealed
```


#### Parameters
&nbsp;<dl><dt>sourceDocument</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The source document.</dd><dt>splitPoint</dt><dd>Type: <a href="T_Aml_Engine_Services_Interfaces_ISplitPoint">Aml.Engine.Services.Interfaces.ISplitPoint</a><br />The split point.</dd><dt>alias</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The alias.</dd><dt>filePath</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The file path.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument</a><br />\[Missing <returns> documentation for "M:Aml.Engine.Services.SplitService.Split(Aml.Engine.CAEX.CAEXDocument,Aml.Engine.Services.Interfaces.ISplitPoint,System.String,System.String)"\]

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_ISplit_Split">ISplit.Split(CAEXDocument, ISplitPoint, String, String)</a><br />

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>sourceDocument or alias or filePath</td></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentexception" target="_parent" rel="noopener noreferrer">ArgumentException</a></td><td>File path is equal to source document</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_SplitService">SplitService Class</a><br /><a href="Overload_Aml_Engine_Services_SplitService_Split">Split Overload</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />