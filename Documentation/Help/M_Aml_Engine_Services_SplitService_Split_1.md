# SplitService.Split Method (CAEXDocument, String, String)
AutomationML 2.1 API 

Splits the specified document on all currently defined split points. The created libraries are saved in an AutomationML document and an ExternalReference is created, using the specified alias. All remaining references to the external source are renamed using the provided alias. After splitting, the document doesn't contain any SplitPoints any more.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public CAEXDocument Split(
	CAEXDocument sourceDocument,
	string alias,
	string filePath
)
```

**VB**<br />
``` VB
Public Function Split ( 
	sourceDocument As CAEXDocument,
	alias As String,
	filePath As String
) As CAEXDocument
```

**C++**<br />
``` C++
public:
virtual CAEXDocument^ Split(
	CAEXDocument^ sourceDocument, 
	String^ alias, 
	String^ filePath
) sealed
```


#### Parameters
&nbsp;<dl><dt>sourceDocument</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd><dt>alias</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The alias.</dd><dt>filePath</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The file path.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument</a><br />The Split document

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_ISplit_Split_1">ISplit.Split(CAEXDocument, String, String)</a><br />

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>document or alias or filePath</td></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentexception" target="_parent" rel="noopener noreferrer">ArgumentException</a></td><td>File path is equal to source document</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_SplitService">SplitService Class</a><br /><a href="Overload_Aml_Engine_Services_SplitService_Split">Split Overload</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />