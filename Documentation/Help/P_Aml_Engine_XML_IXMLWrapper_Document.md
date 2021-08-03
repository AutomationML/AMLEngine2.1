# IXMLWrapper.Document Property 
AutomationML 2.1 API 

Gets the XDocument containing the XML node of this object. If the object has not been inserted into a document, the XDocument is `null`. Direct manipulations of the XML document are not monitored by the AML engine.

**Namespace:**&nbsp;<a href="N_Aml_Engine_XML">Aml.Engine.XML</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
XDocument Document { get; }
```

**VB**<br />
``` VB
ReadOnly Property Document As XDocument
	Get
```

**C++**<br />
``` C++
property XDocument^ Document {
	XDocument^ get ();
}
```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xdocument" target="_parent" rel="noopener noreferrer">XDocument</a>

## See Also


#### Reference
<a href="T_Aml_Engine_XML_IXMLWrapper">IXMLWrapper Interface</a><br /><a href="N_Aml_Engine_XML">Aml.Engine.XML Namespace</a><br />