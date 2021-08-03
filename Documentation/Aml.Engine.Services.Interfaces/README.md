Aml.Engine.Services.Interfaces Namespace
========================================
The Aml.Engine.Services.Interfaces Namespace defines interfaces implemented by services. A Service provides advanced processing methods for AutomationML documents.


Classes
-------

                | Class                              | Description                                                                         
--------------- | ---------------------------------- | ----------------------------------------------------------------------------------- 
![Public class] | [SchemaTransformationEventArgs][1] | Event arguments for schema transformation events                                    
![Public class] | [UpdateEventArgs][2]               | Event arguments used to inform about update events in the [IAutoUpdate][3] service. 


Interfaces
----------

                    | Interface                       | Description                                                                                                                                                                                                                                                                                                                                                                                                                                        
------------------- | ------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public interface] | [IAMLService][4]                | This is the basic interface for an AML service. This interface has to be implemented by any AML service                                                                                                                                                                                                                                                                                                                                            
![Public interface] | [IAutoUpdate][3]                | Interface defined for services, which support automatic updates of cross references between AutomationML objects. Updates are executed, when a referenced object changes its identification (its Name or its ID).                                                                                                                                                                                                                                  
![Public interface] | [ICAEXReference][5]             | This interface is used to query references to CAEXObjects like references using the ID of objects or references using the CAEXPath of objects like RoleClass or InterfaceClass objects.                                                                                                                                                                                                                                                            
![Public interface] | [IExternalReferenceResolver][6] | This service interface defines methods to resolve external references of an AutomationML document. If references are resolved, queries will be able to find referenced objects. Be aware, that the resolved documents will not be merged and the references, containing an alias will not be changed.                                                                                                                                              
![Public interface] | [IMerge][7]                     | This interface defines methods for a merge service. A merge service can merge ExternalReferences into an AML document.                                                                                                                                                                                                                                                                                                                             
![Public interface] | [IQuery][8]                     | The Query service provides methods to query relations modeled in an AutomationML document. The AMLEngine provides a default query service based on Linq (System.Xml.Linq). To get a better performance for queries, users can register a Lookup service which also implements this query interface but uses dictionary based queries. If ExternalReferences should be queried too, a [IExternalReferenceResolver][6] service should be registered. 
![Public interface] | [ISchemaTransform][9]           | This interface class defines a service interface for a schema transformation service                                                                                                                                                                                                                                                                                                                                                               
![Public interface] | [ISplit][10]                    | This interface defines the service interface for a split service. A split service is able to split one [CAEXDocument][11] into multiple files using split points.                                                                                                                                                                                                                                                                                  
![Public interface] | [ISplitPoint][12]               | This interface is defined for all CAEXObjects to which a split point can be assigned. SplitPoints are allowed on [InternalElementType][13] and [CAEXLibrary&lt;TLibItem>][14].                                                                                                                                                                                                                                                                     
![Public interface] | [IStatistic][15]                | This service interface is used to get statistic data from a CAEX document.                                                                                                                                                                                                                                                                                                                                                                         
![Public interface] | [IUndoRedo][16]                 | The UndoRedo service supports undo and redo of all changes made to a CAEXDocument.                                                                                                                                                                                                                                                                                                                                                                 
![Public interface] | [IUniqueName][17]               | This interface defines methods for a unique name service. The names of CAEX objects in a sequence of elements should all be unique. If a unique name service is registered, the AML Engine will automatically call this service for a unique name generation whenever a new element is added to the sequence which requires a unique name for its members.                                                                                         
![Public interface] | [IValidationResult][18]         | This interface defines properties for a validation result, generated for a single XML element. The validation results for XML elements of a CAEX document are generated by the [IValidator&lt;RESULTTYPE>][19] service.                                                                                                                                                                                                                            
![Public interface] | [IValidator][20]                | This service interface is defined for the validation of an AML document. Additionally the service can also be used to repair specific invalid properties in a document and to automatically updated references to objects if the source changes.                                                                                                                                                                                                   
![Public interface] | [IValidator&lt;RESULTTYPE>][19] | This service interface is defined for the validation of an AML document. The type parameter of this generic interface defined the validation result type.                                                                                                                                                                                                                                                                                          
![Public interface] | [IXMLDocumentRegistry][21]      | This is a special interface for an AML service, which uses a registry to store data about an XML Document.                                                                                                                                                                                                                                                                                                                                         

[1]: SchemaTransformationEventArgs/README.md
[2]: UpdateEventArgs/README.md
[3]: IAutoUpdate/README.md
[4]: IAMLService/README.md
[5]: ICAEXReference/README.md
[6]: IExternalReferenceResolver/README.md
[7]: IMerge/README.md
[8]: IQuery/README.md
[9]: ISchemaTransform/README.md
[10]: ISplit/README.md
[11]: ../Aml.Engine.CAEX/CAEXDocument/README.md
[12]: ISplitPoint/README.md
[13]: ../Aml.Engine.CAEX/InternalElementType/README.md
[14]: ../Aml.Engine.CAEX/CAEXLibrary_1/README.md
[15]: IStatistic/README.md
[16]: IUndoRedo/README.md
[17]: IUniqueName/README.md
[18]: IValidationResult/README.md
[19]: IValidator_1/README.md
[20]: IValidator/README.md
[21]: IXMLDocumentRegistry/README.md
[22]: https://www.automationml.org
[23]: ../icons/logoShade.png
[Public class]: ../icons/pubclass.gif "Public class"
[Public interface]: ../icons/pubinterface.gif "Public interface"