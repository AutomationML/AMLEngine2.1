# CAEXDocument.LoadFromFile Method 
AutomationML 2.1 API 

Create a CAEX document with content, loaded from a file. The schema version of the CAEX document is set accordingly to the SchemaVersion-Attribute of the CAEXFile object.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static CAEXDocument LoadFromFile(
	string filePath
)
```

**VB**<br />
``` VB
Public Shared Function LoadFromFile ( 
	filePath As String
) As CAEXDocument
```

**C++**<br />
``` C++
public:
static CAEXDocument^ LoadFromFile(
	String^ filePath
)
```


#### Parameters
&nbsp;<dl><dt>filePath</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The file path.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument</a><br />The created CAEX document.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.io.filenotfoundexception" target="_parent" rel="noopener noreferrer">FileNotFoundException</a></td><td>filePath</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />