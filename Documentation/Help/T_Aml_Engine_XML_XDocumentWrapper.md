# XDocumentWrapper Class
AutomationML 2.1 API 

This class is an abstract base class for the wrapping of an XDocument, to provide additional schema specific document processing utilities. This class is used by the AMLEngine to provide a CAEXDocument. Other XML Engines, supporting different schemas (PLCopen, COLLADA) could also use this base class.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.XML.XDocumentWrapper<br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_XML">Aml.Engine.XML</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public abstract class XDocumentWrapper : IDocument
```

**VB**<br />
``` VB
Public MustInherit Class XDocumentWrapper
	Implements IDocument
```

**C++**<br />
``` C++
public ref class XDocumentWrapper abstract : IDocument
```

The XDocumentWrapper type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_XML_XDocumentWrapper_XDocument">XDocument</a></td><td>
Gets the underlying XDocument</td></tr></table>&nbsp;
<a href="#xdocumentwrapper-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_XML_XDocumentWrapper_Document_1">Document(XElement)</a></td><td>
Gets the XDocument wrapper which contains the specified XML node. If the node is not contained in an XML document, no document is returned.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_XML_XDocumentWrapper_Document">Document(IXMLWrapper)</a></td><td>
Gets the XDocument wrapper which contains the specified object. If the object has not been inserted into a document, no document is returned.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_XML_XDocumentWrapper_SaveToFile">SaveToFile</a></td><td>
Saves the document to the specified file path.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_XML_XDocumentWrapper_SaveToStream">SaveToStream</a></td><td>
Saves the document to the specified file path.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_XML_XDocumentWrapper_Unload">Unload</a></td><td>
Unloads this document instance.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_XML_XDocumentWrapper_XName">XName</a></td><td>
Gets the correct XName for the provided element name (Tag name).The XName contains a namespace, if the assigned schema requires a namespace. If no namespace is defined for the assigned schema, no namespace is added to the XName. The XName has to be used for all Xml.Linq queries, used to access objects with the element name.</td></tr></table>&nbsp;
<a href="#xdocumentwrapper-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_XML">Aml.Engine.XML Namespace</a><br /><a href="T_Aml_Engine_XML_IDocument">Aml.Engine.XML.IDocument</a><br />