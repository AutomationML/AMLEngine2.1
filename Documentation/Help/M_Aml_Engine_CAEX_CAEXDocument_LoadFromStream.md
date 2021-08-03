# CAEXDocument.LoadFromStream Method 
AutomationML 2.1 API 

Create a CAEX document with content, loaded from a stream. The schema version of the CAEX document is set accordingly to the SchemaVersion-Attribute of the CAEXFile object.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static CAEXDocument LoadFromStream(
	Stream inStream
)
```

**VB**<br />
``` VB
Public Shared Function LoadFromStream ( 
	inStream As Stream
) As CAEXDocument
```

**C++**<br />
``` C++
public:
static CAEXDocument^ LoadFromStream(
	Stream^ inStream
)
```


#### Parameters
&nbsp;<dl><dt>inStream</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.io.stream" target="_parent" rel="noopener noreferrer">System.IO.Stream</a><br />The content stream.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument</a><br />The CAEX document.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>inStream</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />