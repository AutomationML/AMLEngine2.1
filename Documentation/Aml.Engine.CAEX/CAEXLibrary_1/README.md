CAEXLibrary&lt;TLibItem> Class
==============================
Generic base class for all library objects of CAEX, which are: [InstanceHierarchyType][1],[RoleClassLibType][2],[SystemUnitClassLibType][3],[InterfaceClassLibType][4],[AttributeTypeLibType][5].


Inheritance Hierarchy
---------------------
[System.Object][6]  
  [Aml.Engine.CAEX.CAEXWrapper][7]  
    [Aml.Engine.CAEX.CAEXBasicObject][8]  
      [Aml.Engine.CAEX.CAEXObject][9]  
        **Aml.Engine.CAEX.CAEXLibrary&lt;TLibItem>**  
          [More...][10]

  **Namespace:**  [Aml.Engine.CAEX][11]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class CAEXLibrary<TLibItem> : CAEXObject, 
	ISplitPoint, ICAEXWrapper, IXMLWrapper, IMultipleOccurrences<CAEXLibrary<TLibItem>>, 
	ICAEXBasicObject, IEnumerable<TLibItem>, IEnumerable
where TLibItem : CAEXObject

```

#### Type Parameters

##### *TLibItem*


The **CAEXLibrary&lt;TLibItem>** type exposes the following members.


Constructors
------------

                 | Name                           | Description                                                           
---------------- | ------------------------------ | --------------------------------------------------------------------- 
![Public method] | [CAEXLibrary&lt;TLibItem>][12] | Initializes a new instance of the **CAEXLibrary&lt;TLibItem>** class. 


Properties
----------

                   | Name                           | Description                                                                                                                                                                                                             
------------------ | ------------------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AdditionalInformation][13]    | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [CAEXBasicObject][8].)                                                                                                  
![Public property] | [CAEXDocument][14]             | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][7].)                     
![Public property] | [CAEXParent][15]               | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][7].)                                                                                                                                   
![Public property] | [CAEXSequenceOfCAEXObject][16] | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][7].)                                                                                                                                    
![Public property] | [ChangeMode][17]               | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [CAEXBasicObject][8].)                                                                                                             
![Public property] | [Copyright][18]                | Gets and sets the Copyright for this object. (Inherited from [CAEXBasicObject][8].)                                                                                                                                     
![Public property] | [CopyrightElement][19]         | Gets the wrapper for the Copyright element. (Inherited from [CAEXBasicObject][8].)                                                                                                                                      
![Public property] | [Description][20]              | Gets and sets the Description for this object. (Inherited from [CAEXBasicObject][8].)                                                                                                                                   
![Public property] | [DescriptionElement][21]       | Gets the wrapper for the Description element. (Inherited from [CAEXBasicObject][8].)                                                                                                                                    
![Public property] | [Document][22]                 | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][7].)                                                                                                                                        
![Public property] | [Exists][23]                   | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][7].)                                                                                                                       
![Public property] | [ID][24]                       | Gets and sets a unique identifier of the CAEX object (optional in CAEX). AutomationML requires IDs for some Elements. These IDs are automatically set when such elements are created. (Inherited from [CAEXObject][9].) 
![Public property] | [Name][25]                     | Gets and sets the name of the CAEX object (required in CAEX). (Inherited from [CAEXObject][9].)                                                                                                                         
![Public property] | [Node][26]                     | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][7].)                                                                                                                                                         
![Public property] | [Owner][27]                    | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][7].)                                                                                                                                                
![Public property] | [Revision][28]                 | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][8].)                                                                                                              
![Public property] | [SourceObjectInformation][29]  | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][8].)                                                                                               
![Public property] | [TagName][30]                  | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][7].)                                                                                                                                  
![Public property] | [Version][31]                  | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][8].)                                                                                                                                       
![Public property] | [VersionElement][32]           | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][8].)                                                                                                                                        


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                                                                                                                                                                                      
---------------- | ---------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public method] | [AssignNewGuidAsID][33]            | Assigns the new unique identifier as a new ID to this CAEX object. (Inherited from [CAEXObject][9].)                                                                                                                                                                                                                                                                                                                                             
![Public method] | [CAEXChild][34]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][7].)                                                                                                                                                                                                                                                                                                                                      
![Public method] | [CAEXChildren][35]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][7].)                                                                                                                                                                                                                                                                                                                                         
![Public method] | [CAEXPath][36]                     | Gets the CAEX path for this object. A path can be used to uniquely reference an object, for example in inheritances and instances. The path syntax for an object is defined differently in CAEX 2.15 and CAEX 3.0. The engine uses the [CAEXPathBuilder][37] to generate the CAEX path of an object according to the documents CAEX version. (Inherited from [CAEXObject][9].)                                                                   
![Public method] | [CAEXSequence][38]                 | Gets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects [Revision][28] is returned. (Inherited from [CAEXBasicObject][8].)                                                                                                                                                                                       
![Public method] | [Container&lt;T>][39]              | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Inherited from [CAEXBasicObject][8].)                                                                                                                                                                                                                                                                                                                        
![Public method] | [Copy][40]                         | Creates a copy of this CAEX object, containing all child elements. The created copy will have replaced unique IDs and updated references, if the *assignNewIDs* is set to true (default). When a CAEX class is copied, the nested classes that can exist for AttributeType, RoleClass, SystemUnitClass, and InterfaceClass could be included in the created copy, if the *includeSubClasses* is set to `true`. (Inherited from [CAEXObject][9].) 
![Public method] | [CopyAndChangeReferences][41]      | Creates a copy of the library and assigns the provided name to the copy. Including references to objects in the original library are redirected to objects in the copied library.                                                                                                                                                                                                                                                                
![Public method] | [Equals][42]                       | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][7].)                                                                                                                                                                                                                                                                                                                    
![Public method] | [GetEnumerator][43]                | Gets the enumerator to iterate through the collection of library objects.                                                                                                                                                                                                                                                                                                                                                                        
![Public method] | [GetHashCode][44]                  | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][7].)                                                                                                                                                                                                                                                                                                                                          
![Public method] | [GetXAttributeValue][45]           | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][7].)                                                                                                                                                                                                                                                                                                             
![Public method] | [Insert(Int32, CAEXWrapper)][46]   | Inserts the specified CAEX object in it's associated sequence at the defined position. The CAEXBasicObject defines the [Revision][28] and [SourceObjectInformation][29] sequences. (Inherited from [CAEXBasicObject][8].)                                                                                                                                                                                                                        
![Public method] | [Insert(CAEXWrapper, Boolean)][47] | Inserts the specified CAEX object in it's associated sequence. The CAEXBasicObject defines the [Revision][28] and [SourceObjectInformation][29] sequences. (Inherited from [CAEXBasicObject][8].)                                                                                                                                                                                                                                                
![Public method] | [InsertAfter][48]                  | Inserts the provided CAEX object as a new sibling after this CAEX object.                                                                                                                                                                                                                                                                                                                                                                        
![Public method] | [InsertBefore][49]                 | Inserts the provided CAEX object as a new sibling before this CAEX object.                                                                                                                                                                                                                                                                                                                                                                       
![Public method] | [InsertNew][50]                    | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][27] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][7].)                                                                                                                                                                 
![Public method] | [New_Revision][51]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][28] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][8].)                                                                                                                                          
![Public method] | [Remove][52]                       | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][7].)                                                                                                                                                                                                                                                                                                             
![Public method] | [SetXAttributeValue][53]           | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][7].)                                                                                                                                                                                                                                                                                                            
![Public method] | [ToString][54]                     | Returns the value of the 'Name' attribute of this CAEX object as the string representation of the object. (Inherited from [CAEXObject][9].)                                                                                                                                                                                                                                                                                                      


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][55] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][7].) 


Extension Methods
-----------------

                           | Name                                            | Description                                                                                                                                                                                                                                                                                                                                                                              
-------------------------- | ----------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [AMLSchemaManager][56]                          | Gets the associated CAEX schema manager of the CAEX object. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                                                
![Public Extension Method] | [Ancestors&lt;T>][58]                           | Finds the ancestors of the provided CAEX object which have the given type. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [CAEXDocument][59]                              | Gets the CAEX document which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [CAEXFile][60]                                  | Gets the CAEX file which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [CAEXSchema][61]                                | Gets the associated CAEX schema of the CAEX object. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [clone][62]                                     | [Copy(Boolean, Boolean, Boolean)][63] (Defined by [AMLEngineAdapter][64].)                                                                                                                                                                                                                                                                                                               
![Public Extension Method] | [CloneNode][65]                                 | Clones the node. (Defined by [AMLEngineAdapter][64].)                                                                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [ConsistencyCheck_ClassReference][66]           | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][64].)                                                                                                                                                                                                                                                                  
![Public Extension Method] | [Copy][67]                                      | Copies the CAEX object and assigns the name to the created copy. (Defined by [CAEXObjectExtensions][68].)                                                                                                                                                                                                                                                                                
![Public Extension Method] | [Descendants(Type)][69]                         | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [Descendants&lt;T>()][70]                       | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [Descendants&lt;T>(Boolean)][71]                | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [FindCaexObjectFromId&lt;T>][72]                | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                                        
![Public Extension Method] | [findInternalElement][73]                       | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][64].)                                                                                                                                                                                                                                                               
![Public Extension Method] | [FindReferencedClass&lt;T>][74]                 | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [FirstAncestor(String)][75]                     | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][76] | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                    
![Public Extension Method] | [FirstAncestor&lt;T>()][77]                     | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                       
![Public Extension Method] | [GetParent&lt;T>][78]                           | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                 
![Public Extension Method] | [getReferencedClass][79]                        | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][64].)                                                                                                                                                                                                                                                                                                              
![Public Extension Method] | [getReferencedGUID][80]                         | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][64].)                                                                                                                                                                                                                                                                                      
![Public Extension Method] | [getReferencedInterfaceClass][81]               | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][64].)                                                                                                                                                                                                                                                                    
![Public Extension Method] | [getReferencedInterfaceName][82]                | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][64].)                                                                                                                                                                                                                                                                                                       
![Public Extension Method] | [Insert_Element][83]                            | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][64].)                                                                                                                                                              
![Public Extension Method] | [Insert_NewInstance][84]                        | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][64].)                                                                                                                        
![Public Extension Method] | [Insert_TypeBaseElement][85]                    | [Insert(CAEXWrapper, Boolean)][47] (Defined by [AMLEngineAdapter][64].)                                                                                                                                                                                                                                                                                                                  
![Public Extension Method] | [IsAMLObject][86]                               | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][87].) 
![Public Extension Method] | [Library][88]                                   | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [Name()][89]                                    | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][64].)                                                                                                                                                                                                                                                                                                   
![Public Extension Method] | [Name()][90]                                    | Overloaded. Gets a names for the specified CAEX wrapper object. If the specified object is a [CAEXObject][9], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                
![Public Extension Method] | [New_Copyright][91]                             | Adds an new Copyright node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                                            
![Public Extension Method] | [New_Description][92]                           | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                                          
![Public Extension Method] | [New_Version][93]                               | Adds an new Version node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                                              


Explicit Interface Implementations
----------------------------------

                                                      | Name                            | Description                                                               
----------------------------------------------------- | ------------------------------- | ------------------------------------------------------------------------- 
![Explicit interface implementation]![Private method] | [IEnumerable.GetEnumerator][94] | Gets the enumerator to iterate through the collection of library objects. 


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][11]  
[Aml.Engine.CAEX.CAEXObject][9]  
[Aml.Engine.Services.Interfaces.ISplitPoint][95]  
[Aml.Engine.CAEX.IMultipleOccurrences&lt;T>][96]  
[Aml.Engine.CAEX.CAEXObject][9]  
[System.Collections.Generic.IEnumerable&lt;T>][97]  


Inheritance Hierarchy (Continued)
---------------------------------
[System.Object][6]  
  [Aml.Engine.CAEX.CAEXWrapper][7]  
    [Aml.Engine.CAEX.CAEXBasicObject][8]  
      [Aml.Engine.CAEX.CAEXObject][9]  
        **Aml.Engine.CAEX.CAEXLibrary&lt;TLibItem>**  
          [Aml.Engine.AmlObjects.AMLLibraryType&lt;T>][98]  
          [Aml.Engine.CAEX.AttributeTypeLibType][5]  
          [Aml.Engine.CAEX.InstanceHierarchyType][1]  
          [Aml.Engine.CAEX.InterfaceClassLibType][4]  
          [Aml.Engine.CAEX.RoleClassLibType][2]  
          [Aml.Engine.CAEX.SystemUnitClassLibType][3]  

[1]: ../InstanceHierarchyType/README.md
[2]: ../RoleClassLibType/README.md
[3]: ../SystemUnitClassLibType/README.md
[4]: ../InterfaceClassLibType/README.md
[5]: ../AttributeTypeLibType/README.md
[6]: https://docs.microsoft.com/dotnet/api/system.object
[7]: ../CAEXWrapper/README.md
[8]: ../CAEXBasicObject/README.md
[9]: ../CAEXObject/README.md
[10]: #inheritance-hierarchy-continued
[11]: ../README.md
[12]: _ctor.md
[13]: ../CAEXBasicObject/AdditionalInformation.md
[14]: ../CAEXWrapper/CAEXDocument.md
[15]: ../CAEXWrapper/CAEXParent.md
[16]: ../CAEXWrapper/CAEXSequenceOfCAEXObject.md
[17]: ../CAEXBasicObject/ChangeMode.md
[18]: ../CAEXBasicObject/Copyright.md
[19]: ../CAEXBasicObject/CopyrightElement.md
[20]: ../CAEXBasicObject/Description.md
[21]: ../CAEXBasicObject/DescriptionElement.md
[22]: ../CAEXWrapper/Document.md
[23]: ../CAEXWrapper/Exists.md
[24]: ../CAEXObject/ID.md
[25]: ../CAEXObject/Name.md
[26]: ../CAEXWrapper/Node.md
[27]: ../CAEXWrapper/Owner.md
[28]: ../CAEXBasicObject/Revision.md
[29]: ../CAEXBasicObject/SourceObjectInformation.md
[30]: ../CAEXWrapper/TagName.md
[31]: ../CAEXBasicObject/Version.md
[32]: ../CAEXBasicObject/VersionElement.md
[33]: ../CAEXObject/AssignNewGuidAsID.md
[34]: ../CAEXWrapper/CAEXChild.md
[35]: ../CAEXWrapper/CAEXChildren.md
[36]: ../CAEXObject/CAEXPath.md
[37]: ../../Aml.Engine.CAEX.Extensions/CAEXPathBuilder/README.md
[38]: ../CAEXBasicObject/CAEXSequence.md
[39]: ../CAEXBasicObject/Container__1.md
[40]: ../CAEXObject/Copy.md
[41]: CopyAndChangeReferences.md
[42]: ../CAEXWrapper/Equals.md
[43]: GetEnumerator.md
[44]: ../CAEXWrapper/GetHashCode.md
[45]: ../CAEXWrapper/GetXAttributeValue.md
[46]: ../CAEXBasicObject/Insert_1.md
[47]: ../CAEXBasicObject/Insert.md
[48]: InsertAfter.md
[49]: InsertBefore.md
[50]: ../CAEXWrapper/InsertNew.md
[51]: ../CAEXBasicObject/New_Revision.md
[52]: ../CAEXWrapper/Remove.md
[53]: ../CAEXWrapper/SetXAttributeValue.md
[54]: ../CAEXObject/ToString.md
[55]: ../CAEXWrapper/PropertyChanged.md
[56]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/AMLSchemaManager.md
[57]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[58]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Ancestors__1.md
[59]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXDocument.md
[60]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXFile.md
[61]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXSchema.md
[62]: ../../Aml.Engine.Adapter/AMLEngineAdapter/clone.md
[63]: ../CAEXWrapper/Copy.md
[64]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[65]: ../../Aml.Engine.Adapter/AMLEngineAdapter/CloneNode.md
[66]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ConsistencyCheck_ClassReference.md
[67]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/Copy.md
[68]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/README.md
[69]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[70]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[71]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[72]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[73]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[74]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[75]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[76]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[77]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[78]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/GetParent__1.md
[79]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedClass.md
[80]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedGUID.md
[81]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceClass.md
[82]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceName.md
[83]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_Element.md
[84]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_NewInstance.md
[85]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_TypeBaseElement.md
[86]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsAMLObject.md
[87]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[88]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Library.md
[89]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Name.md
[90]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[91]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Copyright.md
[92]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[93]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Version.md
[94]: System_Collections_IEnumerable_GetEnumerator.md
[95]: ../../Aml.Engine.Services.Interfaces/ISplitPoint/README.md
[96]: ../IMultipleOccurrences_1/README.md
[97]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[98]: ../../Aml.Engine.AmlObjects/AMLLibraryType_1/README.md
[99]: https://www.automationml.org
[100]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"
[Explicit interface implementation]: ../../icons/pubinterface.gif "Explicit interface implementation"
[Private method]: ../../icons/privmethod.gif "Private method"