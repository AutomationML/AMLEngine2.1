# XDocumentWrapper.Document Method (IXMLWrapper)
AutomationML 2.1 API 

Gets the XDocument wrapper which contains the specified object. If the object has not been inserted into a document, no document is returned.

**Namespace:**&nbsp;<a href="N_Aml_Engine_XML">Aml.Engine.XML</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static IDocument Document(
	IXMLWrapper xObject
)
```

**VB**<br />
``` VB
Public Shared Function Document ( 
	xObject As IXMLWrapper
) As IDocument
```

**C++**<br />
``` C++
public:
static IDocument^ Document(
	IXMLWrapper^ xObject
)
```


#### Parameters
&nbsp;<dl><dt>xObject</dt><dd>Type: <a href="T_Aml_Engine_XML_IXMLWrapper">Aml.Engine.XML.IXMLWrapper</a><br />The XNodeWrapper object.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_XML_IDocument">IDocument</a><br />The XDocument wrapper .

## See Also


#### Reference
<a href="T_Aml_Engine_XML_XDocumentWrapper">XDocumentWrapper Class</a><br /><a href="Overload_Aml_Engine_XML_XDocumentWrapper_Document">Document Overload</a><br /><a href="N_Aml_Engine_XML">Aml.Engine.XML Namespace</a><br />