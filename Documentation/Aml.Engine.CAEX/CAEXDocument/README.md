CAEXDocument Class
==================
This class is a wrapper for the XDocument defining a CAEXDocument. Each CAEXDocument is associated to a specific CAEX-Schema. The Default Schema for newly created documents is always the most recently defined CAEX-Schema (currently Version 3.0). The Schema for existing documents loaded from files or other sources is set to the schema version defined in the document source. Transformations of CAEXDocuments from lower schema versions to higher schema versions is possible. Transformations from higher to lower schema versions can also be done but may result in documents containing not all the information. Schema transformations can be done with a registered schema transformation service which implements the [ISchemaTransform][1] interface. Creation of new documents with lower schema versions is possible, but in this case, the schema version has to be defined explicitly.


Inheritance Hierarchy
---------------------
[System.Object][2]  
  [Aml.Engine.XML.XDocumentWrapper][3]  
    **Aml.Engine.CAEX.CAEXDocument**  

  **Namespace:**  [Aml.Engine.CAEX][4]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class CAEXDocument : XDocumentWrapper
```

The **CAEXDocument** type exposes the following members.


Properties
----------

                                   | Name                      | Description                                                                              
---------------------------------- | ------------------------- | ---------------------------------------------------------------------------------------- 
![Public property]                 | [CAEXFile][5]             | Gets the CAEXFile which is the wrapper for the root element in the CAEX document         
![Public property]                 | [Commands][6]             | Gets the command instance for this document, which enables registration of change events 
![Public property]![Static member] | [DefaultSchema][7]        | The Default schema for new CAEX documents                                                
![Public property]                 | [Schema][8]               | Gets the Schema of the CAEXDocument                                                      
![Public property]                 | [SchemaManager][9]        | Gets the schema manager for this document                                                
![Public property]                 | [SchemaVersionString][10] | Gets the schema version string for the assigned schema                                   
![Public property]                 | [XDocument][11]           | Gets the underlying XDocument (Inherited from [XDocumentWrapper][3].)                    


Methods
-------

                                 | Name                                            | Description                                                                                                                                                                                                                                                                                                                                                                                                         
-------------------------------- | ----------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]![Static member] | [AMLSchemaManager(XElement)][12]                | Gets the schema manager for the CAEX document which contains the provided XML node.                                                                                                                                                                                                                                                                                                                                 
![Public method]![Static member] | [AMLSchemaManager(CAEXWrapper)][13]             | Gets the schema manager for the CAEX document which contains the provided CAEX object.                                                                                                                                                                                                                                                                                                                              
![Public method]![Static member] | [Document(XElement)][14]                        | Gets the CAEX document which contains the specified XML node.                                                                                                                                                                                                                                                                                                                                                       
![Public method]![Static member] | [Document(CAEXWrapper)][15]                     | Gets the CAEX document which contains the specified CAEX object. If the CAEX object has not been inserted into a CAEX document, no CAEX document is returned.                                                                                                                                                                                                                                                       
![Public method]![Static member] | [LoadFromBinary][16]                            | Loading a CAEX file from the specified Byte-Array.                                                                                                                                                                                                                                                                                                                                                                  
![Public method]![Static member] | [LoadFromFile][17]                              | Create a CAEX document with content, loaded from a file. The schema version of the CAEX document is set accordingly to the SchemaVersion-Attribute of the CAEXFile object.                                                                                                                                                                                                                                          
![Public method]![Static member] | [LoadFromStream][18]                            | Create a CAEX document with content, loaded from a stream. The schema version of the CAEX document is set accordingly to the SchemaVersion-Attribute of the CAEXFile object.                                                                                                                                                                                                                                        
![Public method]![Static member] | [New_CAEXDocument()][19]                        | Creates a new empty CAEX document containing only the CAEXFile Element as the root element. The CAEX document is created, using the default schema version [DefaultSchema][7].                                                                                                                                                                                                                                      
![Public method]![Static member] | [New_CAEXDocument(CAEXDocument.CAEXSchema)][20] | Creates a new empty CAEX document containing only the CAEXFile element as the root element. The CAEX document is created using the specified schema version. The specified schema version defines the applicable editing methods.                                                                                                                                                                                   
![Public method]                 | [SaveToFile][21]                                | Saves the CAEX document to the specified file path. (Overrides [XDocumentWrapper.SaveToFile(String, Boolean)][22].)                                                                                                                                                                                                                                                                                                 
![Public method]                 | [SaveToStream][23]                              | Saves the CAEX document to the specified file path. (Overrides [XDocumentWrapper.SaveToStream(Boolean)][24].)                                                                                                                                                                                                                                                                                                       
![Public method]                 | [Unload][25]                                    | Unloads this document instance. (Inherited from [XDocumentWrapper][3].)                                                                                                                                                                                                                                                                                                                                             
![Public method]                 | [Validate][26]                                  | Checks if the document is schema compliant.                                                                                                                                                                                                                                                                                                                                                                         
![Public method]                 | [XName][27]                                     | Gets the correct XName for the provided CAEX element name (Tag name).The XName contains a namespace, if the assigned schema requires a namespace. If no namespace is defined for the assigned schema (as in CAEX 2.15), no namespace is added to the XName. The XName has to be used for all Xml.Linq queries, used to access objects with the CAEX element name. (Overrides [XDocumentWrapper.XName(String)][28].) 


Extension Methods
-----------------

                           | Name                                    | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                  
-------------------------- | --------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public Extension Method] | [AllElementsIdentifiedByCAEXPath][29]   | Gets all the elements which are identifiable by a CAEX path. Elements having the same path are grouped together. Use this method to validate the existence of not unique CAEXPaths. (Defined by [QueryResult][30].)                                                                                                                                                                                                                                          
![Public Extension Method] | [AllElementsWithAliasReference][31]     | Gets all the elements with an alias reference. Elements referencing the same Alias are grouped together. Use this method to validate the existence of referenced externals. (Defined by [QueryResult][30].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [AllElementsWithCAEXPathReference][32]  | Gets all the elements with a path reference. Elements referencing the same path are grouped together. Use this method to validate the existence of referenced classes. (Defined by [QueryResult][30].)                                                                                                                                                                                                                                                       
![Public Extension Method] | [AllElementsWithIDReference][33]        | Gets all the elements with identifier references. Elements referencing the same ID are grouped together. Use this method to validate the existence of referenced IDs. (Defined by [QueryResult][30].)                                                                                                                                                                                                                                                        
![Public Extension Method] | [AllElementsWithIDs][34]                | Gets all the elements with IDs. Elements using the same ID are grouped together. Use this method to validate the uniqueness of IDs. (Defined by [QueryResult][30].)                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [AllElementsWithNameReference][35]      | Gets all the elements with a name reference. Elements referencing the same name are grouped together. Use this method to validate the existence of referenced elements. (Defined by [QueryResult][30].)                                                                                                                                                                                                                                                      
![Public Extension Method] | [AllInternalElementMasters][36]         | Gets all InternalElement objects from the document which are masters. (Defined by [QueryResult][30].)                                                                                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [AllInternalElementMirrors][37]         | Gets all InternalElement objects from the document which are mirrors. (Defined by [QueryResult][30].)                                                                                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [ClassIsDerivedFrom&lt;T>][38]          | Determines, if the class, specified with the given class path is directly or indirectly (across multiple generations) a descendant of the class or identical to it, which is uniquely identified with the specified baseClass path. The base class path or the referenced class path may contain alias identifiers. If alias identifiers are present, the method tries to load the externally referenced document. (Defined by [InheritanceExtensions][39].) 
![Public Extension Method] | [Create(String)][40]                    | Overloaded. Factory method to create a new CAEX object in the provided CAEX document. The CAEX element is derived from the specified CAEX object Type. To insert the new CAEX object into the document an appropriate insertion method has to be used. (Defined by [CAEXElementFactory][41].)                                                                                                                                                                
![Public Extension Method] | [Create&lt;T>()][42]                    | Overloaded. Factory method to create a new CAEX object in the provided CAEX document. The CAEX element is derived from the specified CAEX object Type. To insert the new CAEX object into the document an appropriate insertion method has to be used. (Defined by [CAEXElementFactory][41].)                                                                                                                                                                
![Public Extension Method] | [ElementsWithAliasReference][43]        | Gets alls the elements from the document which use the provided Alias in a reference (Defined by [QueryResult][30].)                                                                                                                                                                                                                                                                                                                                         
![Public Extension Method] | [ElementsWithCAEXPathReference][44]     | Gets alls the elements from the document which have a reference to the provided Path. (Defined by [QueryResult][30].)                                                                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [ElementsWithIDReference][45]           | Gets alls the elements from the document which have a reference to the provided ID. (Defined by [QueryResult][30].)                                                                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [ElementsWithInternalLinkRelations][46] | Returns all InternalElements and SystemUnitClasses in the defined Document, which are related to others via InternalLinks. (Defined by [QueryResult][30].)                                                                                                                                                                                                                                                                                                   
![Public Extension Method] | [ExternalReferenceFromAlias][47]        | Gets the ExternalReferenceType form the CAEXDocument which defines the defined alias. (Defined by [CAEXDocumentExtensions][48].)                                                                                                                                                                                                                                                                                                                             
![Public Extension Method] | [FindByID][49]                          | Tries to locate a CAEX object from the specified ID. If the ID uses an alias reference and an [IExternalReferenceResolver][50] can be located, it is tried to resolve the external reference and to get the object from the external source. (Defined by [CAEXDocumentExtensions][48].)                                                                                                                                                                      
![Public Extension Method] | [FindByPath][51]                        | Tries to locates a CAEX object from the specified CAEX path. If the path uses an alias reference and an [IExternalReferenceResolver][50] can be located, it is tried to resolve the external reference and to get the object from the external source. (Defined by [CAEXDocumentExtensions][48].)                                                                                                                                                            


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][4]  

[1]: ../../Aml.Engine.Services.Interfaces/ISchemaTransform/README.md
[2]: https://docs.microsoft.com/dotnet/api/system.object
[3]: ../../Aml.Engine.XML/XDocumentWrapper/README.md
[4]: ../README.md
[5]: CAEXFile.md
[6]: Commands.md
[7]: DefaultSchema.md
[8]: Schema.md
[9]: SchemaManager.md
[10]: SchemaVersionString.md
[11]: ../../Aml.Engine.XML/XDocumentWrapper/XDocument.md
[12]: AMLSchemaManager_1.md
[13]: AMLSchemaManager.md
[14]: Document_1.md
[15]: Document.md
[16]: LoadFromBinary.md
[17]: LoadFromFile.md
[18]: LoadFromStream.md
[19]: New_CAEXDocument.md
[20]: New_CAEXDocument_1.md
[21]: SaveToFile.md
[22]: ../../Aml.Engine.XML/XDocumentWrapper/SaveToFile.md
[23]: SaveToStream.md
[24]: ../../Aml.Engine.XML/XDocumentWrapper/SaveToStream.md
[25]: ../../Aml.Engine.XML/XDocumentWrapper/Unload.md
[26]: Validate.md
[27]: XName.md
[28]: ../../Aml.Engine.XML/XDocumentWrapper/XName.md
[29]: ../../Aml.Engine.Services/QueryResult/AllElementsIdentifiedByCAEXPath.md
[30]: ../../Aml.Engine.Services/QueryResult/README.md
[31]: ../../Aml.Engine.Services/QueryResult/AllElementsWithAliasReference.md
[32]: ../../Aml.Engine.Services/QueryResult/AllElementsWithCAEXPathReference.md
[33]: ../../Aml.Engine.Services/QueryResult/AllElementsWithIDReference.md
[34]: ../../Aml.Engine.Services/QueryResult/AllElementsWithIDs.md
[35]: ../../Aml.Engine.Services/QueryResult/AllElementsWithNameReference.md
[36]: ../../Aml.Engine.Services/QueryResult/AllInternalElementMasters.md
[37]: ../../Aml.Engine.Services/QueryResult/AllInternalElementMirrors.md
[38]: ../../Aml.Engine.CAEX.Extensions/InheritanceExtensions/ClassIsDerivedFrom__1.md
[39]: ../../Aml.Engine.CAEX.Extensions/InheritanceExtensions/README.md
[40]: ../../Aml.Engine.CAEX.Extensions/CAEXElementFactory/Create.md
[41]: ../../Aml.Engine.CAEX.Extensions/CAEXElementFactory/README.md
[42]: ../../Aml.Engine.CAEX.Extensions/CAEXElementFactory/Create__1.md
[43]: ../../Aml.Engine.Services/QueryResult/ElementsWithAliasReference.md
[44]: ../../Aml.Engine.Services/QueryResult/ElementsWithCAEXPathReference.md
[45]: ../../Aml.Engine.Services/QueryResult/ElementsWithIDReference.md
[46]: ../../Aml.Engine.Services/QueryResult/ElementsWithInternalLinkRelations.md
[47]: ../../Aml.Engine.CAEX.Extensions/CAEXDocumentExtensions/ExternalReferenceFromAlias.md
[48]: ../../Aml.Engine.CAEX.Extensions/CAEXDocumentExtensions/README.md
[49]: ../../Aml.Engine.CAEX.Extensions/CAEXDocumentExtensions/FindByID.md
[50]: ../../Aml.Engine.Services.Interfaces/IExternalReferenceResolver/README.md
[51]: ../../Aml.Engine.CAEX.Extensions/CAEXDocumentExtensions/FindByPath.md
[52]: https://www.automationml.org
[53]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Static member]: ../../icons/static.gif "Static member"
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"