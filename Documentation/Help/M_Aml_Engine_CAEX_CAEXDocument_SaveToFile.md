# CAEXDocument.SaveToFile Method 
AutomationML 2.1 API 

Saves the CAEX document to the specified file path.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public override void SaveToFile(
	string filename,
	bool prettyPrint
)
```

**VB**<br />
``` VB
Public Overrides Sub SaveToFile ( 
	filename As String,
	prettyPrint As Boolean
)
```

**C++**<br />
``` C++
public:
virtual void SaveToFile(
	String^ filename, 
	bool prettyPrint
) override
```


#### Parameters
&nbsp;<dl><dt>filename</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The file path to save the document to.</dd><dt>prettyPrint</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />Set to true, if pretty printing is desired.</dd></dl>

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>filename</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />