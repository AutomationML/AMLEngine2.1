LookupService Class
===================
This class is a query service based on dictionaries.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.Services.LookupService**  

  **Namespace:**  [Aml.Engine.Services][2]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public class LookupService : IQuery, 
	IAMLService, IAutoUpdate, IXMLDocumentRegistry
```

The **LookupService** type exposes the following members.


Properties
----------

                   | Name                     | Description                                                                                                                    
------------------ | ------------------------ | ------------------------------------------------------------------------------------------------------------------------------ 
![Public property] | [IsAutoUpdateEnabled][3] | Gets or sets a value indicating whether this instance will automatically update cross references between AutomationML objects. 


Methods
-------

                                 | Name                                                      | Description                                                                                                                                                                                                                                                                                                                                                                                                       
-------------------------------- | --------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]                 | [AddDocument][4]                                          | Adds the document to the query service. All tables for the document will be created.                                                                                                                                                                                                                                                                                                                              
![Public method]                 | [AllClassReferences(CAEXObject)][5]                       | Gets all classes which have references to the provided CAEX object. Use this method to get all classes which have a class to class relation to the provided CAEX object.                                                                                                                                                                                                                                          
![Public method]                 | [AllClassReferences(CAEXDocument, String, String)][6]     | Gets all classes which have references to the provided class path. Use this method to get all classes which have a class to class relation to the class, identified by the provided classPath. If the *elementName* is set, only classes with the defined element name are considered.                                                                                                                            
![Public method]                 | [AllClassReferencesDeep(CAEXObject)][7]                   | Gets all classes which have references to the provided CAEX object and their referencing classes (recursive). This method extends the [AllClassReferences(CAEXObject)][8] and gets not only the directly derived classes of a base class but also the derived classes of these classes and further on.                                                                                                            
![Public method]                 | [AllClassReferencesDeep(CAEXDocument, String, String)][9] | Gets all classes which have references to the provided CAEX object and their referencing classes (recursive). This method extends the [AllClassReferences(CAEXDocument, String, String)][10] and gets not only the directly derived classes of a base class but also the derived classes of these classes and further on. If the *elementName* is set, only classes with the defined element name are considered. 
![Public method]                 | [AllElementsIdentifiedByCAEXPath][11]                     | Gets all the elements which are descendants of the provided CAEX object and are identifiable by a CAEX path. Elements having the same path are grouped together. Use this method to validate the existence of ambiguous CAEXPaths.                                                                                                                                                                                
![Public method]                 | [AllElementsWithAliasReference][12]                       | Gets all the elements which are descendants of the provided CAEX object and use an alias reference. Elements referencing the same Alias are grouped together. Use this method to validate the existence of referenced externals. If the *elementName* is set, only elements with the defined element name are considered.                                                                                         
![Public method]                 | [AllElementsWithCAEXPathReference][13]                    | Gets all the elements which are descendants of the provided CAEX object and use a path reference. Elements referencing the same path are grouped together. Use this method to validate the existence of referenced classes. If the *elementName* is set, only elements with the defined element name are considered.                                                                                              
![Public method]                 | [AllElementsWithIDReference][14]                          | Gets all the elements which are descendants of the provided CAEX object and which use identifier references. Elements referencing the same ID are grouped together. Use this method to validate the existence of referenced IDs. If the *elementName* is set, only elements with the defined element name are considered.                                                                                         
![Public method]                 | [AllElementsWithIDs][15]                                  | Gets all the elements which are descendants of the provided CAEX object with IDs. Elements using the same ID are grouped together. Use this method to validate the uniqueness of IDs.                                                                                                                                                                                                                             
![Public method]                 | [AllElementsWithInternalLinks][16]                        | Returns all Elements which are descendants of the provided CAEX object with InternalLinks. These elements are the owners of the InternalLink objects. The returned collection may contain InternalElements and SystemUnitClasses as well.                                                                                                                                                                         
![Public method]                 | [AllElementsWithNameReference][17]                        | Gets all the elements which are descendants of the provided CAEX object and use a name reference. Elements referencing the same name are grouped together. Use this method to validate the existence of referenced elements.                                                                                                                                                                                      
![Public method]                 | [AllExternalDataReferences][18]                           | Returns all ExternalInterfaces in the provided document or optionally in the caexObject and descendants, which are instances of the standard Interface class [ExternalDataConnector][19].                                                                                                                                                                                                                         
![Public method]                 | [AllExternalInterfacesOfType][20]                         | Returns all ExternalInterfaces in the provided document or optionally in the caexObject and descendants, which are instances of the Interface class defined by the provided *interfaceClassPath*.                                                                                                                                                                                                                 
![Public method]                 | [AllInternalElementsWithInternalLinks][21]                | Returns all InternalElements which are descendants of the provided CAEX object with InternalLinks. These elements are the owners of the InternalLink objects.                                                                                                                                                                                                                                                     
![Public method]                 | [AttributeMirrors][22]                                    | Returns all Mirrors of the specified Attribute                                                                                                                                                                                                                                                                                                                                                                    
![Public method]                 | [ElementsWithAliasReference][23]                          | Gets alls the elements which are descendants of the provided CAEX object which use the provided Alias in a reference. The elements in the result collection are references, which define the CAEX object and the attribute, containing the reference . If the *elementName* is set, only elements with the defined element name are considered.                                                                   
![Public method]                 | [ElementsWithCAEXPathReference][24]                       | Gets alls the elements which are descendants of the provided CAEX object which have a reference to the provided CAEXPath. The elements in the result collection are references, which define the CAEX object and the attribute, containing the reference . If the *elementName* is set, only elements with the defined element name are considered.                                                               
![Public method]                 | [ElementsWithIDReference][25]                             | Gets alls the elements from the document which have a reference to the provided ID. The elements in the result collection are references, which define the CAEX object and the attribute, containing the reference . If the *elementName* is set, only elements with the defined element name are considered.                                                                                                     
![Public method]                 | [ElementsWithInternalLinkRelations][26]                   | Returns all InternalElements and SystemUnitClasses which are descendants of the provided CAEX object, which are related to others via InternalLinks.                                                                                                                                                                                                                                                              
![Public method]                 | [ExternalInterfaceMirrors][27]                            | Returns all Mirrors of the specified ExternalInterface                                                                                                                                                                                                                                                                                                                                                            
![Public method]                 | [FindByID][28]                                            | Locates a CAEX object in the provided document using the specified ID - Attribute for identification.                                                                                                                                                                                                                                                                                                             
![Public method]                 | [FindByPath][29]                                          | Locates a CAEX object in the provided document using the specified CAEX - Path for identification. If the path uses an alias reference and an [IExternalReferenceResolver][30] can be located, it is tried to resolve the external reference and to get the object from the external source.                                                                                                                      
![Public method]                 | [InterfacesWithInternalLinkRelations][31]                 | Returns all ExternalInterface objects which are descendants of the provided CAEX object and are used in relations (InternalLinks).                                                                                                                                                                                                                                                                                
![Public method]                 | [InternalElementMirrors][32]                              | Returns all Mirrors of the specified InternalElement                                                                                                                                                                                                                                                                                                                                                              
![Public method]                 | [InternalLinksToElement][33]                              | Gets all InternalLinks that reference the specified InternalElement or SystemUnitClass.                                                                                                                                                                                                                                                                                                                           
![Public method]                 | [InternalLinksToInterface][34]                            | Gets all InternalLinks that reference the specified ExternalInterface.                                                                                                                                                                                                                                                                                                                                            
![Public method]                 | [IsMaster(AttributeType)][35]                             | Determines whether the specified AttributeType is referenced by other AttributeType objects called 'Mirrors'.                                                                                                                                                                                                                                                                                                     
![Public method]                 | [IsMaster(ExternalInterfaceType)][36]                     | Determines whether the specified ExternalInterface is referenced by other ExternalInterface objects called 'Mirrors'.                                                                                                                                                                                                                                                                                             
![Public method]                 | [IsMaster(InternalElementType)][37]                       | Determines whether the specified InternalElement is referenced by other InternalElement objects called 'Mirrors'.                                                                                                                                                                                                                                                                                                 
![Public method]                 | [IsReferenced][38]                                        | Determines whether the specified CAEX object is referenced.                                                                                                                                                                                                                                                                                                                                                       
![Public method]![Static member] | [Register][39]                                            | Registers a new instance of a LookupService with the [ServiceLocator][40] of the AMLEngine.                                                                                                                                                                                                                                                                                                                       
![Public method]                 | [RemoveDocument][41]                                      | Removes the document from the internal registry of the service.                                                                                                                                                                                                                                                                                                                                                   
![Public method]![Static member] | [UnRegister][42]                                          | Unregisters this service                                                                                                                                                                                                                                                                                                                                                                                          


Events
------

                | Name                   | Description                                 
--------------- | ---------------------- | ------------------------------------------- 
![Public event] | [ReferenceUpdated][43] | Occurs when any reference has been updated. 


See Also
--------

#### Reference
[Aml.Engine.Services Namespace][2]  
[Aml.Engine.Services.Interfaces.IQuery][44]  
[Aml.Engine.Services.Interfaces.IAutoUpdate][45]  
[System.ComponentModel.INotifyPropertyChanged][46]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: IsAutoUpdateEnabled.md
[4]: AddDocument.md
[5]: AllClassReferences_1.md
[6]: AllClassReferences.md
[7]: AllClassReferencesDeep_1.md
[8]: ../../Aml.Engine.Services.Interfaces/IQuery/AllClassReferences_1.md
[9]: AllClassReferencesDeep.md
[10]: ../../Aml.Engine.Services.Interfaces/IQuery/AllClassReferences.md
[11]: AllElementsIdentifiedByCAEXPath.md
[12]: AllElementsWithAliasReference.md
[13]: AllElementsWithCAEXPathReference.md
[14]: AllElementsWithIDReference.md
[15]: AllElementsWithIDs.md
[16]: AllElementsWithInternalLinks.md
[17]: AllElementsWithNameReference.md
[18]: AllExternalDataReferences.md
[19]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/ExternalDataConnector.md
[20]: AllExternalInterfacesOfType.md
[21]: AllInternalElementsWithInternalLinks.md
[22]: AttributeMirrors.md
[23]: ElementsWithAliasReference.md
[24]: ElementsWithCAEXPathReference.md
[25]: ElementsWithIDReference.md
[26]: ElementsWithInternalLinkRelations.md
[27]: ExternalInterfaceMirrors.md
[28]: FindByID.md
[29]: FindByPath.md
[30]: ../../Aml.Engine.Services.Interfaces/IExternalReferenceResolver/README.md
[31]: InterfacesWithInternalLinkRelations.md
[32]: InternalElementMirrors.md
[33]: InternalLinksToElement.md
[34]: InternalLinksToInterface.md
[35]: IsMaster.md
[36]: IsMaster_1.md
[37]: IsMaster_2.md
[38]: IsReferenced.md
[39]: Register.md
[40]: ../ServiceLocator/README.md
[41]: RemoveDocument.md
[42]: UnRegister.md
[43]: ReferenceUpdated.md
[44]: ../../Aml.Engine.Services.Interfaces/IQuery/README.md
[45]: ../../Aml.Engine.Services.Interfaces/IAutoUpdate/README.md
[46]: https://docs.microsoft.com/dotnet/api/system.componentmodel.inotifypropertychanged
[47]: https://www.automationml.org
[48]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"
[Public event]: ../../icons/pubevent.gif "Public event"