# CAEXDocument.SaveToStream Method 
AutomationML 2.1 API 

Saves the CAEX document to the specified file path.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public override Stream SaveToStream(
	bool prettyPrint
)
```

**VB**<br />
``` VB
Public Overrides Function SaveToStream ( 
	prettyPrint As Boolean
) As Stream
```

**C++**<br />
``` C++
public:
virtual Stream^ SaveToStream(
	bool prettyPrint
) override
```


#### Parameters
&nbsp;<dl><dt>prettyPrint</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />Set to true, if pretty printing is desired</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.io.stream" target="_parent" rel="noopener noreferrer">Stream</a><br />The stream, containing the CAEX document content.

#### Implements
<a href="M_Aml_Engine_XML_IDocument_SaveToStream">IDocument.SaveToStream(Boolean)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />