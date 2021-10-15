CAEXFileType Class
==================
This class is a wrapper for the CAEX element 'CAEXFile' which is the root-element of any CAEX document.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.CAEXWrapper][2]  
    [Aml.Engine.CAEX.CAEXBasicObject][3]  
      **Aml.Engine.CAEX.CAEXFileType**  
        [Aml.Engine.AmlObjects.AMLFile][4]  

  **Namespace:**  [Aml.Engine.CAEX][5]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class CAEXFileType : CAEXBasicObject, 
	IEnumerable<CAEXObject>, IEnumerable
```

The **CAEXFileType** type exposes the following members.


Constructors
------------

                 | Name              | Description                                              
---------------- | ----------------- | -------------------------------------------------------- 
![Public method] | [CAEXFileType][6] | Initializes a new CAEXWrapper of the 'CAEXFile' element. 


Properties
----------

                   | Name                            | Description                                                                                                                                                                                         
------------------ | ------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AdditionalInformation][7]      | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                              
![Public property] | [AttributeTypeLib][8]           | Gets the collection of AttributeTypeLib objects contained in the CAEXFile.                                                                                                                          
![Public property] | [CAEXDocument][9]               | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][2].) 
![Public property] | [CAEXParent][10]                | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][2].)                                                                                                               
![Public property] | [CAEXSequenceOfCAEXObject][11]  | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                
![Public property] | [ChangeMode][12]                | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [CAEXBasicObject][3].)                                                                                         
![Public property] | [Copyright][13]                 | Gets and sets the Copyright for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                 
![Public property] | [CopyrightElement][14]          | Gets the wrapper for the Copyright element. (Inherited from [CAEXBasicObject][3].)                                                                                                                  
![Public property] | [Description][15]               | Gets and sets the Description for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                               
![Public property] | [DescriptionElement][16]        | Gets the wrapper for the Description element. (Inherited from [CAEXBasicObject][3].)                                                                                                                
![Public property] | [Document][17]                  | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                    
![Public property] | [Exists][18]                    | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                   
![Public property] | [ExternalReference][19]         | Gets the collection of ExternalReference objects contained in the CAEXFile.                                                                                                                         
![Public property] | [FileName][20]                  | Gets and sets the FileName attribute of the CAEXFile                                                                                                                                                
![Public property] | [InstanceHierarchy][21]         | Gets the collection of InstanceHierarchy objects contained in the CAEXFile.                                                                                                                         
![Public property] | [InterfaceClassLib][22]         | Gets the collection of InterfaceClassLib objects contained in the CAEXFile.                                                                                                                         
![Public property] | [IsEmpty][23]                   | Gets a value indicating whether this instance is empty.                                                                                                                                             
![Public property] | [Node][24]                      | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                     
![Public property] | [Owner][25]                     | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][2].)                                                                                                                            
![Public property] | [Revision][26]                  | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                          
![Public property] | [RoleClassLib][27]              | Gets the collection of RoleClassLib objects contained in the CAEXFile.                                                                                                                              
![Public property] | [SchemaLocation][28]            | Gets and sets the SchemaLocation attribute of the CAEXFile.                                                                                                                                         
![Public property] | [SchemaVersion][29]             | Gets and sets the SchemaVersion attribute of the CAEXFile.                                                                                                                                          
![Public property] | [SourceDocumentInformation][30] | Gets the collection of SourceDocumentInformation objects contained in the CAEXFile.                                                                                                                 
![Public property] | [SourceObjectInformation][31]   | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                           
![Public property] | [SuperiorStandardVersion][32]   | Gets the collection of SuperiorStandardVersion objects contained in the CAEXFile. The value of the SuperiorStandardVersion object is defined as a string.                                           
![Public property] | [SystemUnitClassLib][33]        | Gets the collection of SystemUnitClassLib objects contained in the CAEXFile.                                                                                                                        
![Public property] | [TagName][34]                   | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][2].)                                                                                                              
![Public property] | [Version][35]                   | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                   
![Public property] | [VersionElement][36]            | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][3].)                                                                                                                    


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                                                                              
---------------- | ---------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [CAEXChild][37]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                              
![Public method] | [CAEXChildren][38]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                 
![Public method] | [CAEXSequence][39]                 | Gets the CAEXSequence owned by this CAEX object, which contains the specified CAEX object. (Overrides [CAEXBasicObject.CAEXSequence(ICAEXWrapper)][40].)                                                                                                                                                                                 
![Public method] | [Container&lt;T>][41]              | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                
![Public method] | [Copy][42]                         | Creates a deep copy of this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                               
![Public method] | [Equals][43]                       | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                            
![Public method] | [GetEnumerator][44]                | Gets an enumerator that enables enumeration of all libraries in the CAEX file.                                                                                                                                                                                                                                                           
![Public method] | [GetFileNamePath][45]              | Retrieves the file name including full path out of the CAEX document.                                                                                                                                                                                                                                                                    
![Public method] | [GetHashCode][46]                  | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                  
![Public method] | [GetXAttributeValue][47]           | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                     
![Public method] | [Insert(Int32, CAEXWrapper)][48]   | Inserts the specified CAEX object in it's associated sequence at the given position. The CAEXFile defines the [ExternalReference][19], [InstanceHierarchy][21], [InterfaceClassLib][22], [RoleClassLib][27], [SystemUnitClassLib][33] and [AttributeTypeLib][8] sequences. (Overrides [CAEXBasicObject.Insert(Int32, CAEXWrapper)][49].) 
![Public method] | [Insert(CAEXWrapper, Boolean)][50] | Inserts the specified CAEX object in it's associated sequence. The CAEXFile defines the [ExternalReference][19], [InstanceHierarchy][21], [InterfaceClassLib][22], [RoleClassLib][27], [SystemUnitClassLib][33] and [AttributeTypeLib][8] sequences. (Overrides [CAEXBasicObject.Insert(CAEXWrapper, Boolean)][51].)                     
![Public method] | [InsertNew][52]                    | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][25] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][2].)                                                         
![Public method] | [New_Revision][53]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][26] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][3].)                                  
![Public method] | [Remove][54]                       | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                     
![Public method] | [SetXAttributeValue][55]           | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                    


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][56] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][2].) 


Extension Methods
-----------------

                           | Name                                                                                              | Description                                                                                                                                                                                                                                                                                                                                                            
-------------------------- | ------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [AddAutomationMLBPRInterfaceClassLib][57]                                                         | Adds the AutomationMLBPRInterfaceClassLib containing all interface classes used to model external document references to the AMLDocument. (Defined by [ExternalDataReference][58].)                                                                                                                                                                                    
![Public Extension Method] | [AddAutomationMLBPRRoleClassLib][59]                                                              | Adds the AutomationMLBPRRoleClassLib containing all role classes used to model external document references to the AMLDocument. (Defined by [ExternalDataReference][58].)                                                                                                                                                                                              
![Public Extension Method] | [AddExternalDataReferenceLibraries][60]                                                           | Adds the external data reference libraries used to model external document references. It is checked, if the needed role- and interface libraries are contained in the AMLDocument. If this libs are missing, they are imported from an embedded resource stream. The current Version of the embedded libs is version 1.0.0. (Defined by [ExternalDataReference][58].) 
![Public Extension Method] | [AllElementsWithInternalLinks][61]                                                                | Getting an enumerable of all Elements with InternalLinks of all InstanceHierarchies and SystemUnitClassLibraries in the CAEXFile. The enumeration may return InternalElements or SystemUnitClass elements. (Defined by [AMLEngineAdapter][62].)                                                                                                                        
![Public Extension Method] | [AllInternalElementsWithInternalLinks][63]                                                        | Getting an enumerable of InternalElements with InternalLinks of all InstanceHierarchies and SystemUnitClassLibraries in the CAEXFile. (Defined by [AMLEngineAdapter][62].)                                                                                                                                                                                             
![Public Extension Method] | [AMLFile][64]                                                                                     | Converts a CAEX file to an AML file. (Defined by [AmlObjectsExtensions][65].)                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [AppendDocumentVersionInformation(DocumentVersionInformation, String)][66]                        | Overloaded. Appends the provided document version information to the AutomationML document (Defined by [DocumentVersions][67].)                                                                                                                                                                                                                                        
![Public Extension Method] | [AppendDocumentVersionInformation(String, String, String)][68]                                    | Overloaded. This function sets the DocumentVersion information for a referenced document. If DocumentVersion information about the same document Identifier already exists, this DocumentVersion information is replaced. (Defined by [DocumentVersions][67].)                                                                                                         
![Public Extension Method] | [AutomationMLBPRInterfaceClassLib][69]                                                            | Gets the AutomationMLBPRInterfaceClassLib containing all interface classes used to model external document references to the AMLDocument. (Defined by [ExternalDataReference][58].)                                                                                                                                                                                    
![Public Extension Method] | [AutomationMLBPRRoleClassLib][70]                                                                 | Gets the AutomationMLBPRRoleClassLib containing all role classes used to model external document references to the AMLDocument. (Defined by [ExternalDataReference][58].)                                                                                                                                                                                              
![Public Extension Method] | [AutomationMLVersion][71]                                                                         | Gets the AutomationML version for this CAEXFile object. (Defined by [AmlObjectsExtensions][65].)                                                                                                                                                                                                                                                                       
![Public Extension Method] | [ClearMetaInformation][72]                                                                        | Removes all "Writer Header" specific meta information out of this CAEX file. (Defined by [AmlObjectsExtensions][65].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [clone][73]                                                                                       | [Copy(Boolean, Boolean, Boolean)][42] (Defined by [AMLEngineAdapter][62].)                                                                                                                                                                                                                                                                                             
![Public Extension Method] | [CloneNode][74]                                                                                   | Clones the node. (Defined by [AMLEngineAdapter][62].)                                                                                                                                                                                                                                                                                                                  
![Public Extension Method] | [ConsistencyCheck_ClassReference][75]                                                             | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][62].)                                                                                                                                                                                                                                                
![Public Extension Method] | [CreateDocumentVersionsHeader][76]                                                                | Creates the additional information representing a document versions header and appends it to the AutomationML document. (Defined by [DocumentVersions][67].)                                                                                                                                                                                                           
![Public Extension Method] | [DeleteDocumentVersionInformation][77]                                                            | This function deletes all existing DocumentVersion information from the AutomationML document corresponding to the documentID. (Defined by [DocumentVersions][67].)                                                                                                                                                                                                    
![Public Extension Method] | [DeleteMetaInformation][78]                                                                       | This function deletes any existing meta information corresponding to the writerID. (Defined by [AmlObjectsExtensions][65].)                                                                                                                                                                                                                                            
![Public Extension Method] | [Descendants(Type)][79]                                                                           | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][80].)                                                                                                                                                                                                                               
![Public Extension Method] | [Descendants&lt;T>()][81]                                                                         | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][80].)                                                                                                                                                                                                                               
![Public Extension Method] | [DocumentVersionsHeader][82]                                                                      | Get the Additional Information XML-Node from the CAEXFile, which represents the Document Versions node. (Defined by [DocumentVersions][67].)                                                                                                                                                                                                                           
![Public Extension Method] | [ExternalDataReferenceInterfaceClass][83]                                                         | Gets the 'ExternalDataReference' InterfaceClass from the AML document. (Defined by [ExternalDataReference][58].)                                                                                                                                                                                                                                                       
![Public Extension Method] | [ExternalDataRoleClass][84]                                                                       | Gets the ExternalData RoleClass from the AML document. (Defined by [ExternalDataReference][58].)                                                                                                                                                                                                                                                                       
![Public Extension Method] | [ExternalReferences][85]                                                                          | Enumeration Method for all ExternalReferences of the CAEXFile. (Defined by [AMLEngineAdapter][62].)                                                                                                                                                                                                                                                                    
![Public Extension Method] | [FindFastByID(String, Boolean)][86]                                                               | Overloaded. Performs a document wide fast search and returns a CAEXObject given by its ID. (Defined by [CAEXFileTypeExtensions][87].)                                                                                                                                                                                                                                  
![Public Extension Method] | [FindFastByID&lt;T>(String, Boolean)][88]                                                         | Overloaded. Performs a document wide fast search and returns an object of type 'T' given by its ID. (Defined by [CAEXFileTypeExtensions][87].)                                                                                                                                                                                                                         
![Public Extension Method] | [FindFastByPath(String, Boolean)][89]                                                             | Overloaded. Performs a document wide fast search and returns a CAEXObject given by its Path, e.g. "plant/unit" or -in case the document is based on CAEX 2.15 - "GUID:Interface". (Defined by [CAEXFileTypeExtensions][87].)                                                                                                                                           
![Public Extension Method] | [FindFastByPath&lt;T>(String, Boolean)][90]                                                       | Overloaded. Performs a document wide fast search and returns an object of type 'T' given by its Path, e.g. "plant/unit" or -in case the document is based on CAEX 2.15 - "GUID:Interface". (Defined by [CAEXFileTypeExtensions][87].)                                                                                                                                  
![Public Extension Method] | [findInternalElement][91]                                                                         | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][62].)                                                                                                                                                                                                                                             
![Public Extension Method] | [GetAllDocumentVersionInformation][92]                                                            | This methods returns an Enumeration of all Information related to document versions defined in the "DocumentVersions" information of an AutomationML document. (Defined by [DocumentVersions][67].)                                                                                                                                                                    
![Public Extension Method] | [GetAllElementsWithInternalLinks][93]                                                             | Getting a List of all Elements with InternalLinks of all InstanceHierarchies and SystemUnitClassLibraries in the CAEXFile. The List may contain InternalElements and SystemUnitClass elements. (Defined by [AMLEngineAdapter][62].)                                                                                                                                    
![Public Extension Method] | [GetDocumentVersionInformation][94]                                                               | This function returns the DocumentVersion Information from the AutomationML document with the specified document Identifier, otherwise null. (Defined by [DocumentVersions][67].)                                                                                                                                                                                      
![Public Extension Method] | [GetMetaInformation()][95]                                                                        | Overloaded. This methods returns an Enumeration of all "WriterHeader" meta information out of an existing AutomationML file. (Defined by [AmlObjectsExtensions][65].)                                                                                                                                                                                                  
![Public Extension Method] | [GetMetaInformation(String)][96]                                                                  | Overloaded. This function returns the MetaInformation corresponding to the writerID, otherwise null. (Defined by [AmlObjectsExtensions][65].)                                                                                                                                                                                                                          
![Public Extension Method] | [GetParent][97]                                                                                   | This method returns the parent CAEXBasicObject of the current CAEXBasicObject. (Defined by [AMLEngineAdapter][62].)                                                                                                                                                                                                                                                    
![Public Extension Method] | [getReferencedClass][98]                                                                          | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][62].)                                                                                                                                                                                                                                                                                            
![Public Extension Method] | [getReferencedGUID][99]                                                                           | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][62].)                                                                                                                                                                                                                                                                    
![Public Extension Method] | [getReferencedInterfaceClass][100]                                                                | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][62].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [getReferencedInterfaceName][101]                                                                 | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][62].)                                                                                                                                                                                                                                                                                     
![Public Extension Method] | [Import_AttributeTypeLib][102]                                                                    | Imports the provided library into the AttributeTypeLib collection of this CAEX file. (Defined by [CAEXFileTypeExtensions][87].)                                                                                                                                                                                                                                        
![Public Extension Method] | [Import_InstanceHierarchy][103]                                                                   | Imports the provided source instance hierarchy into the InstanceHierarchy collection of this CAEX file. (Defined by [CAEXFileTypeExtensions][87].)                                                                                                                                                                                                                     
![Public Extension Method] | [Import_InterfaceClassLibHierarchy][104]                                                          | Imports the provided library into the InterfaceClassLib collection of this CAEX file. (Defined by [CAEXFileTypeExtensions][87].)                                                                                                                                                                                                                                       
![Public Extension Method] | [Import_RoleClassLibHierarchy][105]                                                               | Imports the provided library into the RoleClassLib collection of this CAEX file. (Defined by [CAEXFileTypeExtensions][87].)                                                                                                                                                                                                                                            
![Public Extension Method] | [Import_SystemUnitClassLibHierarchy][106]                                                         | Imports the provided library into the SystemUnitClassLib collection of this CAEX file. (Defined by [CAEXFileTypeExtensions][87].)                                                                                                                                                                                                                                      
![Public Extension Method] | [ImportSystemUnitClassLib][107]                                                                   | Imports the provided library into the SystemUnitClassLib collection of this CAEX file. (Defined by [CAEXFileTypeExtensions][87].)                                                                                                                                                                                                                                      
![Public Extension Method] | [Insert_Element][108]                                                                             | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][62].)                                                                                                                                            
![Public Extension Method] | [Insert_ExternalReference][109]                                                                   | Inserts the ExternalReference into the CAEX file. (Defined by [CAEXFileTypeExtensions][87].)                                                                                                                                                                                                                                                                           
![Public Extension Method] | [Insert_InstanceHierarchy][110]                                                                   | Insert an existing InstanceHierarchy to this CAEX file as the last InstanceHierarchy. (Defined by [CAEXFileTypeExtensions][87].)                                                                                                                                                                                                                                       
![Public Extension Method] | [Insert_InterfaceClassLibHierarchy][111]                                                          | Insert an existing InterfaceClassLib to this CAEX file as the last InterfaceClassLib. (Defined by [CAEXFileTypeExtensions][87].)                                                                                                                                                                                                                                       
![Public Extension Method] | [Insert_NewInstance][112]                                                                         | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][62].)                                                                                                      
![Public Extension Method] | [Insert_RoleClassLibHierarchy][113]                                                               | Insert a RoleClassLib to this CAEX file as the last RoleClassLib. (Defined by [CAEXFileTypeExtensions][87].)                                                                                                                                                                                                                                                           
![Public Extension Method] | [Insert_SystemUnitClassLibHierarchy][114]                                                         | Append a SystemUnitClassLib to this CAEX file as the last SystemUnitClassLib. (Defined by [CAEXFileTypeExtensions][87].)                                                                                                                                                                                                                                               
![Public Extension Method] | [Insert_TypeBaseElement][115]                                                                     | [Insert(CAEXWrapper, Boolean)][51] (Defined by [AMLEngineAdapter][62].)                                                                                                                                                                                                                                                                                                
![Public Extension Method] | [InstanceHierarchies][116]                                                                        | Enumeration Method for all InstanceHierarchies of the CAEXFile. (Defined by [AMLEngineAdapter][62].)                                                                                                                                                                                                                                                                   
![Public Extension Method] | [InterfaceClassLibraries][117]                                                                    | Enumeration Method for all InterfaceClass Libraries of the CAEXFile. (Defined by [AMLEngineAdapter][62].)                                                                                                                                                                                                                                                              
![Public Extension Method] | [Name()][118]                                                                                     | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][62].)                                                                                                                                                                                                                                                                                 
![Public Extension Method] | [Name()][119]                                                                                     | Overloaded. Gets a names for the specified CAEX wrapper object. If the specified object is a [CAEXObject][120], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][80].)                                                                                                                                            
![Public Extension Method] | [New_Description][121]                                                                            | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][80].)                                                                                                                                                                                                                                                        
![Public Extension Method] | [New_ExternalReference][122]                                                                      | A new ExternalReference node is added to the CAEX file. (Defined by [CAEXFileTypeExtensions][87].)                                                                                                                                                                                                                                                                     
![Public Extension Method] | [New_InstanceHierarchy][123]                                                                      | Adding a new InstanceHierarchy with the given name to this CAEX file. The Instance Hierarchy is always added as the last Instance Hierarchy. (Defined by [CAEXFileTypeExtensions][87].)                                                                                                                                                                                
![Public Extension Method] | [New_InterfaceClassLibHierarchy][124]                                                             | Adding a new InterfaceClassLib to this CAEX file. (Defined by [CAEXFileTypeExtensions][87].)                                                                                                                                                                                                                                                                           
![Public Extension Method] | [New_RoleClassLibHierarchy][125]                                                                  | Adding a new RoleClassLib to this CAEX file. (Defined by [CAEXFileTypeExtensions][87].)                                                                                                                                                                                                                                                                                
![Public Extension Method] | [New_SystemUnitClassLibHierarchy][126]                                                            | Adding a new SystemUnitClassLib to this CAEX file. (Defined by [CAEXFileTypeExtensions][87].)                                                                                                                                                                                                                                                                          
![Public Extension Method] | [PreorderTraversal][127]                                                                          | Traversal method for a hierarchical tree, with identical childSelector for all tree nodes. The method uses a pre-order algorithm without recursion for the deep traversal of the complete tree. (Defined by [CAEXFileTypeExtensions][87].)                                                                                                                             
![Public Extension Method] | [ReplaceDocumentVersionInformation][128]                                                          | This function replaces any existing DocumentVersion information corresponding to the identical oldDocumentID with the provided new DocumentVersion information. (Defined by [DocumentVersions][67].)                                                                                                                                                                   
![Public Extension Method] | [ReplaceMetaInformation][129]                                                                     | This function replaces any existing meta information corresponding to the identical oldWriterID with the new meta information defined in the newMetainformation (Defined by [AmlObjectsExtensions][65].)                                                                                                                                                               
![Public Extension Method] | [RoleClassLibraries][130]                                                                         | Enumeration Method for all RoleClass Libraries of the CAEXFile. (Defined by [AMLEngineAdapter][62].)                                                                                                                                                                                                                                                                   
![Public Extension Method] | [SetMetaInformation(MetaInformation)][131]                                                        | Overloaded. This method is a short version of the setMetaInformation. Meta data with identical WriterID is replaced. (Defined by [AmlObjectsExtensions][65].)                                                                                                                                                                                                          
![Public Extension Method] | [SetMetaInformation(String, String, String, String, String, String, String, String, String)][132] | Overloaded. This function sets the meta information required from AutomationML standard. If meta information about the same writerID already exists, this meta information is replaced. These information comprise source information about the AutomationML file. (Defined by [AmlObjectsExtensions][65].)                                                            
![Public Extension Method] | [SetMetaInformationStandardAutomationMLLibrary][133]                                              | This method labels this CAEX file as a standard AutomationML library coming from the AutomationML e.V. It removes all other meta information and should only be used from authorized persons in agreement with the AutomationML e.V. (Defined by [AmlObjectsExtensions][65].)                                                                                          
![Public Extension Method] | [SetSourceDocumentInformation][134]                                                               | This function sets the meta information required from AutomationML standard. If meta information about the same writerID already exists, this meta information is replaced. These information comprise source information about the AutomationML file. (Defined by [AmlObjectsExtensions][65].)                                                                        
![Public Extension Method] | [SystemUnitClassLibraries][135]                                                                   | Enumeration Method for all SystemUnitClass Libraries of the CAEXFile. (Defined by [AMLEngineAdapter][62].)                                                                                                                                                                                                                                                             


Explicit Interface Implementations
----------------------------------

                                                      | Name                             | Description                                           
----------------------------------------------------- | -------------------------------- | ----------------------------------------------------- 
![Explicit interface implementation]![Private method] | [IEnumerable.GetEnumerator][136] | Returns an enumerator that runs through a collection. 


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][5]  
[Aml.Engine.CAEX.CAEXBasicObject][3]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../CAEXWrapper/README.md
[3]: ../CAEXBasicObject/README.md
[4]: ../../Aml.Engine.AmlObjects/AMLFile/README.md
[5]: ../README.md
[6]: _ctor.md
[7]: ../CAEXBasicObject/AdditionalInformation.md
[8]: AttributeTypeLib.md
[9]: ../CAEXWrapper/CAEXDocument.md
[10]: ../CAEXWrapper/CAEXParent.md
[11]: ../CAEXWrapper/CAEXSequenceOfCAEXObject.md
[12]: ../CAEXBasicObject/ChangeMode.md
[13]: ../CAEXBasicObject/Copyright.md
[14]: ../CAEXBasicObject/CopyrightElement.md
[15]: ../CAEXBasicObject/Description.md
[16]: ../CAEXBasicObject/DescriptionElement.md
[17]: ../CAEXWrapper/Document.md
[18]: ../CAEXWrapper/Exists.md
[19]: ExternalReference.md
[20]: FileName.md
[21]: InstanceHierarchy.md
[22]: InterfaceClassLib.md
[23]: IsEmpty.md
[24]: ../CAEXWrapper/Node.md
[25]: ../CAEXWrapper/Owner.md
[26]: ../CAEXBasicObject/Revision.md
[27]: RoleClassLib.md
[28]: SchemaLocation.md
[29]: SchemaVersion.md
[30]: SourceDocumentInformation.md
[31]: ../CAEXBasicObject/SourceObjectInformation.md
[32]: SuperiorStandardVersion.md
[33]: SystemUnitClassLib.md
[34]: ../CAEXWrapper/TagName.md
[35]: ../CAEXBasicObject/Version.md
[36]: ../CAEXBasicObject/VersionElement.md
[37]: ../CAEXWrapper/CAEXChild.md
[38]: ../CAEXWrapper/CAEXChildren.md
[39]: CAEXSequence.md
[40]: ../CAEXBasicObject/CAEXSequence.md
[41]: ../CAEXBasicObject/Container__1.md
[42]: ../CAEXWrapper/Copy.md
[43]: ../CAEXWrapper/Equals.md
[44]: GetEnumerator.md
[45]: GetFileNamePath.md
[46]: ../CAEXWrapper/GetHashCode.md
[47]: ../CAEXWrapper/GetXAttributeValue.md
[48]: Insert_1.md
[49]: ../CAEXBasicObject/Insert_1.md
[50]: Insert.md
[51]: ../CAEXBasicObject/Insert.md
[52]: ../CAEXWrapper/InsertNew.md
[53]: ../CAEXBasicObject/New_Revision.md
[54]: ../CAEXWrapper/Remove.md
[55]: ../CAEXWrapper/SetXAttributeValue.md
[56]: ../CAEXWrapper/PropertyChanged.md
[57]: ../../Aml.Engine.AmlObjects/ExternalDataReference/AddAutomationMLBPRInterfaceClassLib.md
[58]: ../../Aml.Engine.AmlObjects/ExternalDataReference/README.md
[59]: ../../Aml.Engine.AmlObjects/ExternalDataReference/AddAutomationMLBPRRoleClassLib.md
[60]: ../../Aml.Engine.AmlObjects/ExternalDataReference/AddExternalDataReferenceLibraries.md
[61]: ../../Aml.Engine.Adapter/AMLEngineAdapter/AllElementsWithInternalLinks.md
[62]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[63]: ../../Aml.Engine.Adapter/AMLEngineAdapter/AllInternalElementsWithInternalLinks.md
[64]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/AMLFile.md
[65]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[66]: ../../Aml.Engine.AmlObjects/DocumentVersions/AppendDocumentVersionInformation.md
[67]: ../../Aml.Engine.AmlObjects/DocumentVersions/README.md
[68]: ../../Aml.Engine.AmlObjects/DocumentVersions/AppendDocumentVersionInformation_1.md
[69]: ../../Aml.Engine.AmlObjects/ExternalDataReference/AutomationMLBPRInterfaceClassLib.md
[70]: ../../Aml.Engine.AmlObjects/ExternalDataReference/AutomationMLBPRRoleClassLib.md
[71]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/AutomationMLVersion.md
[72]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/ClearMetaInformation.md
[73]: ../../Aml.Engine.Adapter/AMLEngineAdapter/clone.md
[74]: ../../Aml.Engine.Adapter/AMLEngineAdapter/CloneNode.md
[75]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ConsistencyCheck_ClassReference.md
[76]: ../../Aml.Engine.AmlObjects/DocumentVersions/CreateDocumentVersionsHeader.md
[77]: ../../Aml.Engine.AmlObjects/DocumentVersions/DeleteDocumentVersionInformation.md
[78]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/DeleteMetaInformation.md
[79]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[80]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[81]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[82]: ../../Aml.Engine.AmlObjects/DocumentVersions/DocumentVersionsHeader.md
[83]: ../../Aml.Engine.AmlObjects/ExternalDataReference/ExternalDataReferenceInterfaceClass.md
[84]: ../../Aml.Engine.AmlObjects/ExternalDataReference/ExternalDataRoleClass.md
[85]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ExternalReferences.md
[86]: ../../Aml.Engine.CAEX.Extensions/CAEXFileTypeExtensions/FindFastByID.md
[87]: ../../Aml.Engine.CAEX.Extensions/CAEXFileTypeExtensions/README.md
[88]: ../../Aml.Engine.CAEX.Extensions/CAEXFileTypeExtensions/FindFastByID__1.md
[89]: ../../Aml.Engine.CAEX.Extensions/CAEXFileTypeExtensions/FindFastByPath.md
[90]: ../../Aml.Engine.CAEX.Extensions/CAEXFileTypeExtensions/FindFastByPath__1.md
[91]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[92]: ../../Aml.Engine.AmlObjects/DocumentVersions/GetAllDocumentVersionInformation.md
[93]: ../../Aml.Engine.Adapter/AMLEngineAdapter/GetAllElementsWithInternalLinks.md
[94]: ../../Aml.Engine.AmlObjects/DocumentVersions/GetDocumentVersionInformation.md
[95]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/GetMetaInformation.md
[96]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/GetMetaInformation_1.md
[97]: ../../Aml.Engine.Adapter/AMLEngineAdapter/GetParent.md
[98]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedClass.md
[99]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedGUID.md
[100]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceClass.md
[101]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceName.md
[102]: ../../Aml.Engine.CAEX.Extensions/CAEXFileTypeExtensions/Import_AttributeTypeLib.md
[103]: ../../Aml.Engine.CAEX.Extensions/CAEXFileTypeExtensions/Import_InstanceHierarchy.md
[104]: ../../Aml.Engine.CAEX.Extensions/CAEXFileTypeExtensions/Import_InterfaceClassLibHierarchy.md
[105]: ../../Aml.Engine.CAEX.Extensions/CAEXFileTypeExtensions/Import_RoleClassLibHierarchy.md
[106]: ../../Aml.Engine.CAEX.Extensions/CAEXFileTypeExtensions/Import_SystemUnitClassLibHierarchy.md
[107]: ../../Aml.Engine.CAEX.Extensions/CAEXFileTypeExtensions/ImportSystemUnitClassLib.md
[108]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_Element.md
[109]: ../../Aml.Engine.CAEX.Extensions/CAEXFileTypeExtensions/Insert_ExternalReference.md
[110]: ../../Aml.Engine.CAEX.Extensions/CAEXFileTypeExtensions/Insert_InstanceHierarchy.md
[111]: ../../Aml.Engine.CAEX.Extensions/CAEXFileTypeExtensions/Insert_InterfaceClassLibHierarchy.md
[112]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_NewInstance.md
[113]: ../../Aml.Engine.CAEX.Extensions/CAEXFileTypeExtensions/Insert_RoleClassLibHierarchy.md
[114]: ../../Aml.Engine.CAEX.Extensions/CAEXFileTypeExtensions/Insert_SystemUnitClassLibHierarchy.md
[115]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_TypeBaseElement.md
[116]: ../../Aml.Engine.Adapter/AMLEngineAdapter/InstanceHierarchies.md
[117]: ../../Aml.Engine.Adapter/AMLEngineAdapter/InterfaceClassLibraries.md
[118]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Name.md
[119]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[120]: ../CAEXObject/README.md
[121]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[122]: ../../Aml.Engine.CAEX.Extensions/CAEXFileTypeExtensions/New_ExternalReference.md
[123]: ../../Aml.Engine.CAEX.Extensions/CAEXFileTypeExtensions/New_InstanceHierarchy.md
[124]: ../../Aml.Engine.CAEX.Extensions/CAEXFileTypeExtensions/New_InterfaceClassLibHierarchy.md
[125]: ../../Aml.Engine.CAEX.Extensions/CAEXFileTypeExtensions/New_RoleClassLibHierarchy.md
[126]: ../../Aml.Engine.CAEX.Extensions/CAEXFileTypeExtensions/New_SystemUnitClassLibHierarchy.md
[127]: ../../Aml.Engine.CAEX.Extensions/CAEXFileTypeExtensions/PreorderTraversal.md
[128]: ../../Aml.Engine.AmlObjects/DocumentVersions/ReplaceDocumentVersionInformation.md
[129]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/ReplaceMetaInformation.md
[130]: ../../Aml.Engine.Adapter/AMLEngineAdapter/RoleClassLibraries.md
[131]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/SetMetaInformation.md
[132]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/SetMetaInformation_1.md
[133]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/SetMetaInformationStandardAutomationMLLibrary.md
[134]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/SetSourceDocumentInformation.md
[135]: ../../Aml.Engine.Adapter/AMLEngineAdapter/SystemUnitClassLibraries.md
[136]: System_Collections_IEnumerable_GetEnumerator.md
[137]: https://www.automationml.org
[138]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"
[Explicit interface implementation]: ../../icons/pubinterface.gif "Explicit interface implementation"
[Private method]: ../../icons/privmethod.gif "Private method"