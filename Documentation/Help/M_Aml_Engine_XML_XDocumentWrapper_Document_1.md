# XDocumentWrapper.Document Method (XElement)
AutomationML 2.1 API 

Gets the XDocument wrapper which contains the specified XML node. If the node is not contained in an XML document, no document is returned.

**Namespace:**&nbsp;<a href="N_Aml_Engine_XML">Aml.Engine.XML</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static IDocument Document(
	XElement node
)
```

**VB**<br />
``` VB
Public Shared Function Document ( 
	node As XElement
) As IDocument
```

**C++**<br />
``` C++
public:
static IDocument^ Document(
	XElement^ node
)
```


#### Parameters
&nbsp;<dl><dt>node</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The XML node.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_XML_IDocument">IDocument</a><br />The XDocument wrapper, containing the XML node.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>XML node is null.</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_XML_XDocumentWrapper">XDocumentWrapper Class</a><br /><a href="Overload_Aml_Engine_XML_XDocumentWrapper_Document">Document Overload</a><br /><a href="N_Aml_Engine_XML">Aml.Engine.XML Namespace</a><br />