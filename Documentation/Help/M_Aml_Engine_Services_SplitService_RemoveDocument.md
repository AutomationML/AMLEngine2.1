# SplitService.RemoveDocument Method 
AutomationML 2.1 API 

Removes the document from the internal registry of the split service. All registered split points for this document will be removed.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public void RemoveDocument(
	XDocumentWrapper doc
)
```

**VB**<br />
``` VB
Public Sub RemoveDocument ( 
	doc As XDocumentWrapper
)
```

**C++**<br />
``` C++
public:
virtual void RemoveDocument(
	XDocumentWrapper^ doc
) sealed
```


#### Parameters
&nbsp;<dl><dt>doc</dt><dd>Type: <a href="T_Aml_Engine_XML_XDocumentWrapper">Aml.Engine.XML.XDocumentWrapper</a><br />The document.</dd></dl>

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IXMLDocumentRegistry_RemoveDocument">IXMLDocumentRegistry.RemoveDocument(XDocumentWrapper)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_SplitService">SplitService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />