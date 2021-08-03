# IDocument.SaveToStream Method 
AutomationML 2.1 API 

Saves the document to stream.

**Namespace:**&nbsp;<a href="N_Aml_Engine_XML">Aml.Engine.XML</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
Stream SaveToStream(
	bool prettyPrint
)
```

**VB**<br />
``` VB
Function SaveToStream ( 
	prettyPrint As Boolean
) As Stream
```

**C++**<br />
``` C++
Stream^ SaveToStream(
	bool prettyPrint
)
```


#### Parameters
&nbsp;<dl><dt>prettyPrint</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` pretty print for the document is enabled.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.io.stream" target="_parent" rel="noopener noreferrer">Stream</a><br />The document stream.

## See Also


#### Reference
<a href="T_Aml_Engine_XML_IDocument">IDocument Interface</a><br /><a href="N_Aml_Engine_XML">Aml.Engine.XML Namespace</a><br />