IQuery Interface
================
AutomationML 2.1 APIThe Query service provides methods to query relations modeled in an AutomationML document. The AMLEngine provides a default query service based on Linq (System.Xml.Linq). To get a better performance for queries, users can register a Lookup service which also implements this query interface but uses dictionary based queries. If ExternalReferences should be queried too, a [IExternalReferenceResolver][1] service should be registered.

  **Namespace:**  [Aml.Engine.Services.Interfaces][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public interface IQuery : IAMLService
```

The **IQuery** type exposes the following members.


Methods
-------

                 | Name                                                      | Description                                                                                                                                                                                                                                                                                                                                                                                                      
---------------- | --------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [AllClassReferences(CAEXObject)][3]                       | Gets all classes which have references to the provided CAEX object. Use this method to get all classes which have a class to class relation to the provided CAEX object.                                                                                                                                                                                                                                         
![Public method] | [AllClassReferences(CAEXDocument, String, String)][4]     | Gets all classes which have references to the provided class path. Use this method to get all classes which have a class to class relation to the class, identified by the provided classPath. If the *elementName* is set, only classes with the defined element name are considered.                                                                                                                           
![Public method] | [AllClassReferencesDeep(CAEXObject)][5]                   | Gets all classes which have references to the provided CAEX object and their referencing classes (recursive). This method extends the [AllClassReferences(CAEXObject)][3] and gets not only the directly derived classes of a base class but also the derived classes of these classes and further on.                                                                                                           
![Public method] | [AllClassReferencesDeep(CAEXDocument, String, String)][6] | Gets all classes which have references to the provided CAEX object and their referencing classes (recursive). This method extends the [AllClassReferences(CAEXDocument, String, String)][4] and gets not only the directly derived classes of a base class but also the derived classes of these classes and further on. If the *elementName* is set, only classes with the defined element name are considered. 
![Public method] | [AllElementsIdentifiedByCAEXPath][7]                      | Gets all the elements which are descendants of the provided CAEX object and are identifiable by a CAEX path. Elements having the same path are grouped together. Use this method to validate the existence of ambiguous CAEXPaths.                                                                                                                                                                               
![Public method] | [AllElementsWithAliasReference][8]                        | Gets all the elements which are descendants of the provided CAEX object and use an alias reference. Elements referencing the same Alias are grouped together. Use this method to validate the existence of referenced externals. If the *elementName* is set, only elements with the defined element name are considered.                                                                                        
![Public method] | [AllElementsWithCAEXPathReference][9]                     | Gets all the elements which are descendants of the provided CAEX object and use a path reference. Elements referencing the same path are grouped together. Use this method to validate the existence of referenced classes. If the *elementName* is set, only elements with the defined element name are considered.                                                                                             
![Public method] | [AllElementsWithIDReference][10]                          | Gets all the elements which are descendants of the provided CAEX object which use identifier references. Elements referencing the same ID are grouped together. Use this method to validate the existence of referenced IDs. If the *elementName* is set, only elements with the defined element name are considered.                                                                                            
![Public method] | [AllElementsWithIDs][11]                                  | Gets all the elements which are descendants of the provided CAEX object with IDs. Elements using the same ID are grouped together. Use this method to validate the uniqueness of IDs.                                                                                                                                                                                                                            
![Public method] | [AllElementsWithInternalLinks][12]                        | Returns all Elements which are descendants of the provided CAEX object with InternalLinks. These elements are the owners of the InternalLink objects. The returned collection may contain InternalElements and SystemUnitClasses as well.                                                                                                                                                                        
![Public method] | [AllElementsWithNameReference][13]                        | Gets all the elements which are descendants of the provided CAEX object and use a name reference. Elements referencing the same name are grouped together. Use this method to validate the existence of referenced elements.                                                                                                                                                                                     
![Public method] | [AllExternalDataReferences][14]                           | Returns all ExternalInterfaces in the provided document or optionally in the caexObject and descendants, which are instances of the standard Interface class [ExternalDataConnector][15].                                                                                                                                                                                                                        
![Public method] | [AllExternalInterfacesOfType][16]                         | Returns all ExternalInterfaces in the provided document or optionally in the caexObject and descendants, which are instances of the Interface class defined by the provided *interfaceClassPath*.                                                                                                                                                                                                                
![Public method] | [AllInternalElementsWithInternalLinks][17]                | Returns all InternalElements which are descendants of the provided CAEX object with InternalLinks. These elements are the owners of the InternalLink objects.                                                                                                                                                                                                                                                    
![Public method] | [AttributeMirrors][18]                                    | Returns all Mirrors of the specified Attribute                                                                                                                                                                                                                                                                                                                                                                   
![Public method] | [ElementsWithAliasReference][19]                          | Gets alls the elements which are descendants of the provided CAEX object which use the provided Alias in a reference. The elements in the result collection are references, which define the CAEX object and the attribute, containing the reference . If the *elementName* is set, only elements with the defined element name are considered.                                                                  
![Public method] | [ElementsWithCAEXPathReference][20]                       | Gets alls the elements which are descendants of the provided CAEX object which have a reference to the provided CAEXPath. The elements in the result collection are references, which define the CAEX object and the attribute, containing the reference . If the *elementName* is set, only elements with the defined element name are considered.                                                              
![Public method] | [ElementsWithIDReference][21]                             | Gets alls the elements from the document which have a reference to the provided ID. The elements in the result collection are references, which define the CAEX object and the attribute, containing the reference . If the *elementName* is set, only elements with the defined element name are considered.                                                                                                    
![Public method] | [ElementsWithInternalLinkRelations][22]                   | Returns all InternalElements and SystemUnitClasses which are descendants of the provided CAEX object, which are related to others via InternalLinks.                                                                                                                                                                                                                                                             
![Public method] | [ExternalInterfaceMirrors][23]                            | Returns all Mirrors of the specified ExternalInterface                                                                                                                                                                                                                                                                                                                                                           
![Public method] | [FindByID][24]                                            | Tries to locate a CAEX object from the specified ID. If the ID uses an alias reference and an [IExternalReferenceResolver][1] can be located, it is tried to resolve the external reference and to get the object from the external source.                                                                                                                                                                      
![Public method] | [FindByPath][25]                                          | Tries to locates a CAEX object from the specified CAEX - Path. If the path uses an alias reference and an [IExternalReferenceResolver][1] can be located, it is tried to resolve the external reference and to get the object from the external source.                                                                                                                                                          
![Public method] | [InterfacesWithInternalLinkRelations][26]                 | Returns all ExternalInterface objects which are descendants of the provided CAEX object and are used in relations (InternalLinks).                                                                                                                                                                                                                                                                               
![Public method] | [InternalElementMirrors][27]                              | Returns all Mirrors of the specified InternalElement                                                                                                                                                                                                                                                                                                                                                             
![Public method] | [InternalLinksToElement][28]                              | Gets all InternalLinks that reference the specified InternalElement or SystemUnitClass.                                                                                                                                                                                                                                                                                                                          
![Public method] | [InternalLinksToInterface][29]                            | Gets all InternalLinks that reference the specified ExternalInterface.                                                                                                                                                                                                                                                                                                                                           
![Public method] | [IsMaster(AttributeType)][30]                             | Determines whether the specified AttributeType is referenced by other AttributeType objects called 'Mirrors'.                                                                                                                                                                                                                                                                                                    
![Public method] | [IsMaster(ExternalInterfaceType)][31]                     | Determines whether the specified ExternalInterface is referenced by other ExternalInterface objects called 'Mirrors'.                                                                                                                                                                                                                                                                                            
![Public method] | [IsMaster(InternalElementType)][32]                       | Determines whether the specified InternalElement is referenced by other InternalElement objects called 'Mirrors'.                                                                                                                                                                                                                                                                                                
![Public method] | [IsReferenced][33]                                        | Determines whether the specified CAEX object is referenced.                                                                                                                                                                                                                                                                                                                                                      


See Also
--------

#### Reference
[Aml.Engine.Services.Interfaces Namespace][2]  
[Aml.Engine.Services.Interfaces.IAMLService][34]  

[1]: ../IExternalReferenceResolver/README.md
[2]: ../README.md
[3]: AllClassReferences_1.md
[4]: AllClassReferences.md
[5]: AllClassReferencesDeep_1.md
[6]: AllClassReferencesDeep.md
[7]: AllElementsIdentifiedByCAEXPath.md
[8]: AllElementsWithAliasReference.md
[9]: AllElementsWithCAEXPathReference.md
[10]: AllElementsWithIDReference.md
[11]: AllElementsWithIDs.md
[12]: AllElementsWithInternalLinks.md
[13]: AllElementsWithNameReference.md
[14]: AllExternalDataReferences.md
[15]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/ExternalDataConnector.md
[16]: AllExternalInterfacesOfType.md
[17]: AllInternalElementsWithInternalLinks.md
[18]: AttributeMirrors.md
[19]: ElementsWithAliasReference.md
[20]: ElementsWithCAEXPathReference.md
[21]: ElementsWithIDReference.md
[22]: ElementsWithInternalLinkRelations.md
[23]: ExternalInterfaceMirrors.md
[24]: FindByID.md
[25]: FindByPath.md
[26]: InterfacesWithInternalLinkRelations.md
[27]: InternalElementMirrors.md
[28]: InternalLinksToElement.md
[29]: InternalLinksToInterface.md
[30]: IsMaster.md
[31]: IsMaster_1.md
[32]: IsMaster_2.md
[33]: IsReferenced.md
[34]: ../IAMLService/README.md
[35]: https://www.automationml.org
[36]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"