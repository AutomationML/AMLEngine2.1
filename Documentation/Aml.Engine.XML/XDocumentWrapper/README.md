XDocumentWrapper Class
======================
This class is an abstract base class for the wrapping of an XDocument, to provide additional schema specific document processing utilities. This class is used by the AMLEngine to provide a CAEXDocument. Other XML Engines, supporting different schemas (PLCopen, COLLADA) could also use this base class.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.XML.XDocumentWrapper**  
    [Aml.Engine.CAEX.CAEXDocument][2]  

  **Namespace:**  [Aml.Engine.XML][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public abstract class XDocumentWrapper : IDocument
```

The **XDocumentWrapper** type exposes the following members.


Properties
----------

                   | Name           | Description                   
------------------ | -------------- | ----------------------------- 
![Public property] | [XDocument][4] | Gets the underlying XDocument 


Methods
-------

                                 | Name                       | Description                                                                                                                                                                                                                                                                                                                           
-------------------------------- | -------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]![Static member] | [Document(XElement)][5]    | Gets the XDocument wrapper which contains the specified XML node. If the node is not contained in an XML document, no document is returned.                                                                                                                                                                                           
![Public method]![Static member] | [Document(IXMLWrapper)][6] | Gets the XDocument wrapper which contains the specified object. If the object has not been inserted into a document, no document is returned.                                                                                                                                                                                         
![Public method]                 | [SaveToFile][7]            | Saves the document to the specified file path.                                                                                                                                                                                                                                                                                        
![Public method]                 | [SaveToStream][8]          | Saves the document to the specified file path.                                                                                                                                                                                                                                                                                        
![Public method]                 | [Unload][9]                | Unloads this document instance.                                                                                                                                                                                                                                                                                                       
![Public method]                 | [XName][10]                | Gets the correct XName for the provided element name (Tag name).The XName contains a namespace, if the assigned schema requires a namespace. If no namespace is defined for the assigned schema, no namespace is added to the XName. The XName has to be used for all Xml.Linq queries, used to access objects with the element name. 


See Also
--------

#### Reference
[Aml.Engine.XML Namespace][3]  
[Aml.Engine.XML.IDocument][11]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: ../README.md
[4]: XDocument.md
[5]: Document_1.md
[6]: Document.md
[7]: SaveToFile.md
[8]: SaveToStream.md
[9]: Unload.md
[10]: XName.md
[11]: ../IDocument/README.md
[12]: https://www.automationml.org
[13]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"