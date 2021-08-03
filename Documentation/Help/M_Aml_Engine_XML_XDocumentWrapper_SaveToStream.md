# XDocumentWrapper.SaveToStream Method 
AutomationML 2.1 API 

Saves the document to the specified file path.

**Namespace:**&nbsp;<a href="N_Aml_Engine_XML">Aml.Engine.XML</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public virtual Stream SaveToStream(
	bool prettyPrint
)
```

**VB**<br />
``` VB
Public Overridable Function SaveToStream ( 
	prettyPrint As Boolean
) As Stream
```

**C++**<br />
``` C++
public:
virtual Stream^ SaveToStream(
	bool prettyPrint
)
```


#### Parameters
&nbsp;<dl><dt>prettyPrint</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />Set to true, if pretty printing is desired</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.io.stream" target="_parent" rel="noopener noreferrer">Stream</a><br />The stream, containing the document content.

#### Implements
<a href="M_Aml_Engine_XML_IDocument_SaveToStream">IDocument.SaveToStream(Boolean)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_XML_XDocumentWrapper">XDocumentWrapper Class</a><br /><a href="N_Aml_Engine_XML">Aml.Engine.XML Namespace</a><br />