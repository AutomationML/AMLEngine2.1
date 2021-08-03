Aml.Engine.XML Namespace
========================
AutomationML 2.1 API 


Classes
-------

                | Class                 | Description                                                                                                                                                                                                                                                                                                   
--------------- | --------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public class] | [XDocumentWrapper][1] | This class is an abstract base class for the wrapping of an XDocument, to provide additional schema specific document processing utilities. This class is used by the AMLEngine to provide a CAEXDocument. Other XML Engines, supporting different schemas (PLCopen, COLLADA) could also use this base class. 


Interfaces
----------

                    | Interface        | Description                                  
------------------- | ---------------- | -------------------------------------------- 
![Public interface] | [IDocument][2]   | Interface for a XDocument Wrapper            
![Public interface] | [IXMLWrapper][3] | XML related properties of a wrapped instance 

[1]: XDocumentWrapper/README.md
[2]: IDocument/README.md
[3]: IXMLWrapper/README.md
[4]: https://www.automationml.org
[5]: ../icons/logoShade.png
[Public class]: ../icons/pubclass.gif "Public class"
[Public interface]: ../icons/pubinterface.gif "Public interface"