QueryService Class
==================
This class defines the default query service for a [CAEXDocument][1]. The query methods of this service are based on System.Xml.Linq and System.Xml.XPath.


Inheritance Hierarchy
---------------------
[System.Object][2]  
  **Aml.Engine.Services.QueryService**  

  **Namespace:**  [Aml.Engine.Services][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class QueryService : IQuery, 
	IAMLService
```

The **QueryService** type exposes the following members.


Constructors
------------

                 | Name              | Description                                              
---------------- | ----------------- | -------------------------------------------------------- 
![Public method] | [QueryService][4] | Initializes a new instance of the **QueryService** class 


Methods
-------

                 | Name                                                      | Description                                                                                                                                                                                                                                                                                                                                                                                                      
---------------- | --------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [AllClassReferences(CAEXObject)][5]                       | Gets all classes which have references to the provided CAEX object.                                                                                                                                                                                                                                                                                                                                              
![Public method] | [AllClassReferences(CAEXDocument, String, String)][6]     | Gets all classes which have references to the provided class path. Use this method to get all classes which have a class to class relation to the class, identified by the provided classPath. If the *elementName* is set, only classes with the defined element name are considered.                                                                                                                           
![Public method] | [AllClassReferencesDeep(CAEXObject)][7]                   | Gets all classes which have references to the provided CAEX object and their referencing classes (recursive)                                                                                                                                                                                                                                                                                                     
![Public method] | [AllClassReferencesDeep(CAEXDocument, String, String)][8] | Gets all classes which have references to the provided CAEX object and their referencing classes (recursive). This method extends the [AllClassReferences(CAEXDocument, String, String)][6] and gets not only the directly derived classes of a base class but also the derived classes of these classes and further on. If the *elementName* is set, only classes with the defined element name are considered. 
![Public method] | [AllElementsIdentifiedByCAEXPath][9]                      | Gets all the elements which are descendants of the provided CAEX object and are identifiable by a CAEX path. Elements having the same path are grouped together. Use this method to validate the existence of ambiguous CAEXPaths.                                                                                                                                                                               
![Public method] | [AllElementsWithAliasReference][10]                       | Gets all the elements which are descendants of the provided CAEX object and use an alias reference. Elements referencing the same Alias are grouped together. Use this method to validate the existence of referenced externals.                                                                                                                                                                                 
![Public method] | [AllElementsWithCAEXPathReference][11]                    | Gets all the elements which are descendants of the provided CAEX object and use a path reference. Elements referencing the same path are grouped together. Use this method to validate the existence of referenced classes. If the *elementName* is set, only elements with the defined element name are considered.                                                                                             
![Public method] | [AllElementsWithIDReference][12]                          | Gets all the elements which are descendants of the provided CAEX object which use identifier references. Elements referencing the same ID are grouped together. Use this method to validate the existence of referenced IDs. If the *elementName* is set, only elements with the defined element name are considered.                                                                                            
![Public method] | [AllElementsWithIDs][13]                                  | Gets all the elements which are descendants of the provided CAEX object with IDs. Elements using the same ID are grouped together. Use this method to validate the uniqueness of IDs.                                                                                                                                                                                                                            
![Public method] | [AllElementsWithInternalLinks][14]                        | Returns all Elements which are descendants of the provided CAEX object with InternalLinks. These elements are the owners of the InternalLink objects. The returned collection may contain InternalElements and SystemUnitClasses as well.                                                                                                                                                                        
![Public method] | [AllElementsWithNameReference][15]                        | Gets all the elements which are descendants of the provided CAEX object and use a name reference. Elements referencing the same name are grouped together. Use this method to validate the existence of referenced elements.                                                                                                                                                                                     
![Public method] | [AllExternalDataReferences][16]                           | Returns all ExternalInterfaces in the provided document or optionally in the caexObject and descendants, which are instances of the standard Interface class [ExternalDataConnector][17].                                                                                                                                                                                                                        
![Public method] | [AllExternalInterfacesOfType][18]                         | Returns all ExternalInterfaces which are instances of the Interface class defined by the provided *interfaceClassPath*.                                                                                                                                                                                                                                                                                          
![Public method] | [AllInternalElementsWithInternalLinks][19]                | Returns all InternalElements which are descendants of the provided CAEX object with InternalLinks. These elements are the owners of the InternalLink objects.                                                                                                                                                                                                                                                    
![Public method] | [AttributeMirrors][20]                                    | Returns all Mirrors of the specified Attribute                                                                                                                                                                                                                                                                                                                                                                   
![Public method] | [ElementsWithAliasReference][21]                          | Gets alls the elements which are descendants of the provided CAEX object which use the provided Alias in a reference. The elements in the result collection are references, which define the CAEX object and the attribute, containing the reference . If the *elementName* is set, only elements with the defined element name are considered.                                                                  
![Public method] | [ElementsWithCAEXPathReference][22]                       | Gets alls the elements which are descendants of the provided CAEX object which have a reference to the provided CAEXPath.                                                                                                                                                                                                                                                                                        
![Public method] | [ElementsWithIDReference][23]                             | Gets alls the elements from the document which have a reference to the provided ID. The elements in the result collection are references, which define the CAEX object and the attribute, containing the reference . If the *elementName* is set, only elements with the defined element name are considered.                                                                                                    
![Public method] | [ElementsWithInternalLinkRelations][24]                   | Returns all InternalElements and SystemUnitClasses which are descendants of the provided CAEX object, which are related to others via InternalLinks.                                                                                                                                                                                                                                                             
![Public method] | [ExternalInterfaceMirrors][25]                            | Returns all Mirrors of the specified ExternalInterface                                                                                                                                                                                                                                                                                                                                                           
![Public method] | [FindByID][26]                                            | Finds the first element in the defined document, which ID is equal to the provided ID.                                                                                                                                                                                                                                                                                                                           
![Public method] | [FindByPath][27]                                          | This method tries to find the first element in the defined document, which CAEXPath is equal to the provided path. If the path uses an alias to reference an object in a external document it is tried to locate an [IExternalReferenceResolver][28] service. If such a service is registered, the CAEXObject is tried to be found in the resolved document.                                                     
![Public method] | [InterfacesWithInternalLinkRelations][29]                 | Returns all ExternalInterface objects which are descendants of the provided CAEX object and are used in relations (InternalLinks).                                                                                                                                                                                                                                                                               
![Public method] | [InternalElementMirrors][30]                              | Returns all Mirrors of the specified InternalElement                                                                                                                                                                                                                                                                                                                                                             
![Public method] | [InternalLinksToElement][31]                              | Gets all InternalLink objects referencing the provided SystemUnitClass object via an external interface attached to the SystemUnitClass.                                                                                                                                                                                                                                                                         
![Public method] | [InternalLinksToInterface][32]                            | Gets all InternalLinks that reference the specified ExternalInterface.                                                                                                                                                                                                                                                                                                                                           
![Public method] | [IsMaster(AttributeType)][33]                             | Determines whether the specified attribute is a master attribute.                                                                                                                                                                                                                                                                                                                                                
![Public method] | [IsMaster(ExternalInterfaceType)][34]                     | Determines whether the specified ExternalInterface is referenced by other ExternalInterface objects called 'Mirrors'.                                                                                                                                                                                                                                                                                            
![Public method] | [IsMaster(InternalElementType)][35]                       | Determines whether the specified InternalElement is referenced by other InternalElement objects called 'Mirrors'.                                                                                                                                                                                                                                                                                                
![Public method] | [IsReferenced][36]                                        | Determines whether the specified CAEX object is referenced.                                                                                                                                                                                                                                                                                                                                                      


See Also
--------

#### Reference
[Aml.Engine.Services Namespace][3]  
[Aml.Engine.Services.Interfaces.IQuery][37]  

[1]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[2]: https://docs.microsoft.com/dotnet/api/system.object
[3]: ../README.md
[4]: _ctor.md
[5]: AllClassReferences_1.md
[6]: AllClassReferences.md
[7]: AllClassReferencesDeep_1.md
[8]: AllClassReferencesDeep.md
[9]: AllElementsIdentifiedByCAEXPath.md
[10]: AllElementsWithAliasReference.md
[11]: AllElementsWithCAEXPathReference.md
[12]: AllElementsWithIDReference.md
[13]: AllElementsWithIDs.md
[14]: AllElementsWithInternalLinks.md
[15]: AllElementsWithNameReference.md
[16]: AllExternalDataReferences.md
[17]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/ExternalDataConnector.md
[18]: AllExternalInterfacesOfType.md
[19]: AllInternalElementsWithInternalLinks.md
[20]: AttributeMirrors.md
[21]: ElementsWithAliasReference.md
[22]: ElementsWithCAEXPathReference.md
[23]: ElementsWithIDReference.md
[24]: ElementsWithInternalLinkRelations.md
[25]: ExternalInterfaceMirrors.md
[26]: FindByID.md
[27]: FindByPath.md
[28]: ../../Aml.Engine.Services.Interfaces/IExternalReferenceResolver/README.md
[29]: InterfacesWithInternalLinkRelations.md
[30]: InternalElementMirrors.md
[31]: InternalLinksToElement.md
[32]: InternalLinksToInterface.md
[33]: IsMaster.md
[34]: IsMaster_1.md
[35]: IsMaster_2.md
[36]: IsReferenced.md
[37]: ../../Aml.Engine.Services.Interfaces/IQuery/README.md
[38]: https://www.automationml.org
[39]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"