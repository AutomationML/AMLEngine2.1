InstanceHierarchyType Class
===========================
AutomationML 2.1 APIThis Class is a wrapper for the CAEXElement 'InstanceHierarchy' which is a Container element for a hierarchy of InternalElements.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.CAEXWrapper][2]  
    [Aml.Engine.CAEX.CAEXBasicObject][3]  
      [Aml.Engine.CAEX.CAEXObject][4]  
        [Aml.Engine.CAEX.CAEXLibrary][5]&lt;[InternalElementType][6]>  
          **Aml.Engine.CAEX.InstanceHierarchyType**  

  **Namespace:**  [Aml.Engine.CAEX][7]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class InstanceHierarchyType : CAEXLibrary<InternalElementType>, 
	IInternalElementContainer, ICAEXObject, ICAEXBasicObject, ICAEXWrapper, IXMLWrapper, 
	IEnumerable<InternalElementType>, IEnumerable
```

The **InstanceHierarchyType** type exposes the following members.


Constructors
------------

                 | Name                       | Description                                                        
---------------- | -------------------------- | ------------------------------------------------------------------ 
![Public method] | [InstanceHierarchyType][8] | Initializes a new instance of the **InstanceHierarchyType** class. 


Properties
----------

                                   | Name                           | Description                                                                                                                                                                                                             
---------------------------------- | ------------------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property]                 | [AdditionalInformation][9]     | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                                  
![Public property]                 | [CAEXDocument][10]             | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][2].)                     
![Public property]                 | [CAEXParent][11]               | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][2].)                                                                                                                                   
![Public property]                 | [CAEXSequenceOfCAEXObject][12] | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                    
![Public property]                 | [ChangeMode][13]               | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [CAEXBasicObject][3].)                                                                                                             
![Public property]![Static member] | [Constructor][14]              | The constructor function for the **InstanceHierarchyType**.                                                                                                                                                             
![Public property]                 | [Copyright][15]                | Gets and sets the Copyright for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                     
![Public property]                 | [CopyrightElement][16]         | Gets the wrapper for the Copyright element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                      
![Public property]                 | [Description][17]              | Gets and sets the Description for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                   
![Public property]                 | [DescriptionElement][18]       | Gets the wrapper for the Description element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                    
![Public property]                 | [Document][19]                 | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                        
![Public property]                 | [Exists][20]                   | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                       
![Public property]                 | [ID][21]                       | Gets and sets a unique identifier of the CAEX object (optional in CAEX). AutomationML requires IDs for some Elements. These IDs are automatically set when such elements are created. (Inherited from [CAEXObject][4].) 
![Public property]                 | [InternalElement][22]          | Gets the List of wrappers for the InternalElements of the top level of the InstanceHierarchy.                                                                                                                           
![Public property]                 | [Name][23]                     | Gets and sets the name of the CAEX object (required in CAEX). (Inherited from [CAEXObject][4].)                                                                                                                         
![Public property]                 | [Node][24]                     | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                                         
![Public property]                 | [Owner][25]                    | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][2].)                                                                                                                                                
![Public property]                 | [Revision][26]                 | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                                              
![Public property]                 | [SourceObjectInformation][27]  | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                               
![Public property]                 | [TagName][28]                  | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][2].)                                                                                                                                  
![Public property]                 | [Version][29]                  | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                       
![Public property]                 | [VersionElement][30]           | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                        


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                                                                                                                                             
---------------- | ---------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [AssignNewGuidAsID][31]            | Assigns the new unique identifier as a new ID to this CAEX object. (Inherited from [CAEXObject][4].)                                                                                                                                                                                                                                                                                                    
![Public method] | [CAEXChild][32]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                             
![Public method] | [CAEXChildren][33]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                
![Public method] | [CAEXPath][34]                     | Gets the CAEX path for this object. A path can be used to uniquely reference an object, for example in inheritances and instances. The path syntax for an object is defined differently in CAEX 2.15 and CAEX 3.0. The engine uses the [CAEXPathBuilder][35] to generate the CAEX path of an object according to the documents CAEX version. (Inherited from [CAEXObject][4].)                          
![Public method] | [CAEXSequence][36]                 | Gets the CAEXSequence owned by this CAEX object, which contains the specified CAEX object. (Overrides [CAEXBasicObject.CAEXSequence(ICAEXWrapper)][37].)                                                                                                                                                                                                                                                
![Public method] | [Container&lt;T>][38]              | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                                                               
![Public method] | [Copy][39]                         | Creates a deep copy of this CAEX object, containing all child elements. The created copy will have replaced unique IDs and updated references, if the *assignNewIDs* is set to true (default). When a CAEX class is copied, the nested classes that can exist for AttributeType, RoleClass, SystemUnitClass, and InterfaceClass are not included in the created copy. (Inherited from [CAEXObject][4].) 
![Public method] | [Equals][40]                       | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                           
![Public method] | [GetEnumerator][41]                | Gets the enumerator to iterate through the collection of library objects. (Inherited from [CAEXLibrary&lt;TLibItem>][5].)                                                                                                                                                                                                                                                                               
![Public method] | [GetHashCode][42]                  | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                 
![Public method] | [GetXAttributeValue][43]           | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                    
![Public method] | [Insert(Int32, CAEXWrapper)][44]   | Inserts the specified CAEX object in it's associated sequence at the given position. The InstanceHierarchy defines the [InternalElement][22] sequence. (Overrides [CAEXBasicObject.Insert(Int32, CAEXWrapper)][45].)                                                                                                                                                                                    
![Public method] | [Insert(CAEXWrapper, Boolean)][46] | Inserts the specified CAEX object in it's associated sequence. The InstanceHierarchy defines the [InternalElement][22] sequence. (Overrides [CAEXBasicObject.Insert(CAEXWrapper, Boolean)][47].)                                                                                                                                                                                                        
![Public method] | [InsertAfter][48]                  | Inserts the provided CAEX object as a new sibling after this CAEX object. (Inherited from [CAEXLibrary&lt;TLibItem>][5].)                                                                                                                                                                                                                                                                               
![Public method] | [InsertBefore][49]                 | Inserts the provided CAEX object as a new sibling before this CAEX object. (Inherited from [CAEXLibrary&lt;TLibItem>][5].)                                                                                                                                                                                                                                                                              
![Public method] | [InsertNew][50]                    | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][25] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][2].)                                                                                                                        
![Public method] | [New_Revision][51]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][26] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][3].)                                                                                                 
![Public method] | [Remove][52]                       | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                    
![Public method] | [SetXAttributeValue][53]           | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                   
![Public method] | [ToString][54]                     | Returns the value of the 'Name' attribute of this CAEX object as the string representation of the object. (Inherited from [CAEXObject][4].)                                                                                                                                                                                                                                                             


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][55] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][2].) 


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
![Public Extension Method] | [Descendants(Type)][67]                         | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [Descendants&lt;T>()][68]                       | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [Descendants&lt;T>(Boolean)][69]                | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [FindCaexObjectFromId&lt;T>][70]                | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                                        
![Public Extension Method] | [findInternalElement][71]                       | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][64].)                                                                                                                                                                                                                                                               
![Public Extension Method] | [FindReferencedClass&lt;T>][72]                 | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [FirstAncestor(String)][73]                     | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][74] | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                    
![Public Extension Method] | [FirstAncestor&lt;T>()][75]                     | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                       
![Public Extension Method] | [GetFullNodePath][76]                           | Gets the full node path of the provided CAEX object, which includes the object names of all ancestor hierarchy levels and the name of the object itself. (Defined by [CAEXObjectExtensions][77].)                                                                                                                                                                                        
![Public Extension Method] | [GetParent&lt;T>][78]                           | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                 
![Public Extension Method] | [getReferencedClass][79]                        | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][64].)                                                                                                                                                                                                                                                                                                              
![Public Extension Method] | [getReferencedGUID][80]                         | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][64].)                                                                                                                                                                                                                                                                                      
![Public Extension Method] | [getReferencedInterfaceClass][81]               | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][64].)                                                                                                                                                                                                                                                                    
![Public Extension Method] | [getReferencedInterfaceName][82]                | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][64].)                                                                                                                                                                                                                                                                                                       
![Public Extension Method] | [Insert_Element][83]                            | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][64].)                                                                                                                                                              
![Public Extension Method] | [Insert_InternalElement][84]                    | Inserting an InternalElement to the InternalElement-Collection of the *objectWithInternalElements*. (Defined by [SystemUnitClassTypeExtensions][85].)                                                                                                                                                                                                                                    
![Public Extension Method] | [Insert_NewInstance][86]                        | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][64].)                                                                                                                        
![Public Extension Method] | [Insert_TypeBaseElement][87]                    | [Insert(CAEXWrapper, Boolean)][47] (Defined by [AMLEngineAdapter][64].)                                                                                                                                                                                                                                                                                                                  
![Public Extension Method] | [InternalElementChildren][88]                   | Enumeration Method for direct Children of Type [InternalElementType][6] (Defined by [AMLEngineAdapter][64].)                                                                                                                                                                                                                                                                             
![Public Extension Method] | [InternalElementDescendants][89]                | Gets all descendant [InternalElementType][6] Objects in the InstanceHierarchy. InternalElements on all levels are returned. (Defined by [InstanceHierarchyTypeExtensions][90].)                                                                                                                                                                                                          
![Public Extension Method] | [IsAMLObject][91]                               | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][92].) 
![Public Extension Method] | [Library][93]                                   | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [Name()][94]                                    | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][64].)                                                                                                                                                                                                                                                                                                   
![Public Extension Method] | [Name()][95]                                    | Overloaded. Gets a names for the specified caex wrapper object. If the specified object is a [CAEXObject][4], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                
![Public Extension Method] | [New_Copyright][96]                             | Adds an new Copyright node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                                            
![Public Extension Method] | [New_Description][97]                           | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                                          
![Public Extension Method] | [New_InternalElement][98]                       | Adding a new InternalElement instance to the InternalElement-Collection of the *elementWithInternalElements*. The New InternalElement is inserted as the first InternalElement of any existing InternalElement objects if nothing else is explicit defined. (Defined by [SystemUnitClassTypeExtensions][85].)                                                                            
![Public Extension Method] | [New_Version][99]                               | Adds an new Version node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][57].)                                                                                                                                                                                                                                                                              
![Public Extension Method] | [SetDescription][100]                           | This method sets a description. If no description exists, it is created. (Defined by [CAEXObjectExtensions][77].)                                                                                                                                                                                                                                                                        


Explicit Interface Implementations
----------------------------------

                                                      | Name                             | Description                                                                                                               
----------------------------------------------------- | -------------------------------- | ------------------------------------------------------------------------------------------------------------------------- 
![Explicit interface implementation]![Private method] | [IEnumerable.GetEnumerator][101] | Gets the enumerator to iterate through the collection of library objects. (Inherited from [CAEXLibrary&lt;TLibItem>][5].) 


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][7]  
[Aml.Engine.CAEX.CAEXLibrary&lt;TLibItem>][5]  
[Aml.Engine.CAEX.IInternalElementContainer][102]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../CAEXWrapper/README.md
[3]: ../CAEXBasicObject/README.md
[4]: ../CAEXObject/README.md
[5]: ../CAEXLibrary_1/README.md
[6]: ../InternalElementType/README.md
[7]: ../README.md
[8]: _ctor.md
[9]: ../CAEXBasicObject/AdditionalInformation.md
[10]: ../CAEXWrapper/CAEXDocument.md
[11]: ../CAEXWrapper/CAEXParent.md
[12]: ../CAEXWrapper/CAEXSequenceOfCAEXObject.md
[13]: ../CAEXBasicObject/ChangeMode.md
[14]: Constructor.md
[15]: ../CAEXBasicObject/Copyright.md
[16]: ../CAEXBasicObject/CopyrightElement.md
[17]: ../CAEXBasicObject/Description.md
[18]: ../CAEXBasicObject/DescriptionElement.md
[19]: ../CAEXWrapper/Document.md
[20]: ../CAEXWrapper/Exists.md
[21]: ../CAEXObject/ID.md
[22]: InternalElement.md
[23]: ../CAEXObject/Name.md
[24]: ../CAEXWrapper/Node.md
[25]: ../CAEXWrapper/Owner.md
[26]: ../CAEXBasicObject/Revision.md
[27]: ../CAEXBasicObject/SourceObjectInformation.md
[28]: ../CAEXWrapper/TagName.md
[29]: ../CAEXBasicObject/Version.md
[30]: ../CAEXBasicObject/VersionElement.md
[31]: ../CAEXObject/AssignNewGuidAsID.md
[32]: ../CAEXWrapper/CAEXChild.md
[33]: ../CAEXWrapper/CAEXChildren.md
[34]: ../CAEXObject/CAEXPath.md
[35]: ../../Aml.Engine.CAEX.Extensions/CAEXPathBuilder/README.md
[36]: CAEXSequence.md
[37]: ../CAEXBasicObject/CAEXSequence.md
[38]: ../CAEXBasicObject/Container__1.md
[39]: ../CAEXObject/Copy.md
[40]: ../CAEXWrapper/Equals.md
[41]: ../CAEXLibrary_1/GetEnumerator.md
[42]: ../CAEXWrapper/GetHashCode.md
[43]: ../CAEXWrapper/GetXAttributeValue.md
[44]: Insert_1.md
[45]: ../CAEXBasicObject/Insert_1.md
[46]: Insert.md
[47]: ../CAEXBasicObject/Insert.md
[48]: ../CAEXLibrary_1/InsertAfter.md
[49]: ../CAEXLibrary_1/InsertBefore.md
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
[67]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[68]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[69]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[70]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[71]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[72]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[73]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[74]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[75]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[76]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/GetFullNodePath.md
[77]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/README.md
[78]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/GetParent__1.md
[79]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedClass.md
[80]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedGUID.md
[81]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceClass.md
[82]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceName.md
[83]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_Element.md
[84]: ../../Aml.Engine.CAEX.Extensions/SystemUnitClassTypeExtensions/Insert_InternalElement.md
[85]: ../../Aml.Engine.CAEX.Extensions/SystemUnitClassTypeExtensions/README.md
[86]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_NewInstance.md
[87]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_TypeBaseElement.md
[88]: ../../Aml.Engine.Adapter/AMLEngineAdapter/InternalElementChildren.md
[89]: ../../Aml.Engine.CAEX.Extensions/InstanceHierarchyTypeExtensions/InternalElementDescendants.md
[90]: ../../Aml.Engine.CAEX.Extensions/InstanceHierarchyTypeExtensions/README.md
[91]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsAMLObject.md
[92]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[93]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Library.md
[94]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Name.md
[95]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[96]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Copyright.md
[97]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[98]: ../../Aml.Engine.CAEX.Extensions/SystemUnitClassTypeExtensions/New_InternalElement.md
[99]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Version.md
[100]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/SetDescription.md
[101]: ../CAEXLibrary_1/System_Collections_IEnumerable_GetEnumerator.md
[102]: ../IInternalElementContainer/README.md
[103]: https://www.automationml.org
[104]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Static member]: ../../icons/static.gif "Static member"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"
[Explicit interface implementation]: ../../icons/pubinterface.gif "Explicit interface implementation"
[Private method]: ../../icons/privmethod.gif "Private method"