AMLSystemUnitClass Class
========================
An AMLSystemUnitClass is a SystemUnitClass which can contain [AMLPort][1] AML objects.


Inheritance Hierarchy
---------------------
[System.Object][2]  
  [Aml.Engine.CAEX.CAEXWrapper][3]  
    [Aml.Engine.CAEX.CAEXBasicObject][4]  
      [Aml.Engine.CAEX.CAEXObject][5]  
        [Aml.Engine.CAEX.SystemUnitClassType][6]  
          **Aml.Engine.AmlObjects.AMLSystemUnitClass**  

  **Namespace:**  [Aml.Engine.AmlObjects][7]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class AMLSystemUnitClass : SystemUnitClassType
```

The **AMLSystemUnitClass** type exposes the following members.


Constructors
------------

                 | Name                                         | Description                                                     
---------------- | -------------------------------------------- | --------------------------------------------------------------- 
![Public method] | [AMLSystemUnitClass(XElement)][8]            | Initializes a new instance of the **AMLSystemUnitClass** class. 
![Public method] | [AMLSystemUnitClass(SystemUnitClassType)][9] | Initializes a new instance of the **AMLSystemUnitClass** class. 


Properties
----------

                   | Name                                  | Description                                                                                                                                                                                                             
------------------ | ------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AdditionalInformation][10]           | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [CAEXBasicObject][4].)                                                                                                  
![Public property] | [AMLFacets][11]                       | Gets the Collection of AMLFacet objects.                                                                                                                                                                                
![Public property] | [AMLGroups][12]                       | Gets the Collection of AMLGroup objects.                                                                                                                                                                                
![Public property] | [AMLPorts][13]                        | Gets the Collection of AMLPort objects.                                                                                                                                                                                 
![Public property] | [Attribute][14]                       | Gets the collection of Attribute objects for this instance. (Inherited from [SystemUnitClassType][6].)                                                                                                                  
![Public property] | [AttributeAndDescendants][15]         | Gets the attributes and all nested attributes. (Inherited from [SystemUnitClassType][6].)                                                                                                                               
![Public property] | [CAEXDocument][16]                    | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][3].)                     
![Public property] | [CAEXParent][17]                      | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][3].)                                                                                                                                   
![Public property] | [CAEXSequenceOfCAEXObject][18]        | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][3].)                                                                                                                                    
![Public property] | [ChangeMode][19]                      | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [CAEXBasicObject][4].)                                                                                                             
![Public property] | [Copyright][20]                       | Gets and sets the Copyright for this object. (Inherited from [CAEXBasicObject][4].)                                                                                                                                     
![Public property] | [CopyrightElement][21]                | Gets the wrapper for the Copyright element. (Inherited from [CAEXBasicObject][4].)                                                                                                                                      
![Public property] | [Description][22]                     | Gets and sets the Description for this object. (Inherited from [CAEXBasicObject][4].)                                                                                                                                   
![Public property] | [DescriptionElement][23]              | Gets the wrapper for the Description element. (Inherited from [CAEXBasicObject][4].)                                                                                                                                    
![Public property] | [Document][24]                        | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][3].)                                                                                                                                        
![Public property] | [Exists][25]                          | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][3].)                                                                                                                       
![Public property] | [ExternalInterface][26]               | Gets a collection of ExternalInterface objects contained in this instance. (Inherited from [SystemUnitClassType][6].)                                                                                                   
![Public property] | [ExternalInterfaceAndDescendants][27] | Gets the collection of ExternalInterface objects including all nested descendant interfaces (Inherited from [SystemUnitClassType][6].)                                                                                  
![Public property] | [ID][28]                              | Gets and sets a unique identifier of the CAEX object (optional in CAEX). AutomationML requires IDs for some Elements. These IDs are automatically set when such elements are created. (Inherited from [CAEXObject][5].) 
![Public property] | [InternalElement][29]                 | Gets the collection of InternalElement objects for this instance. (Inherited from [SystemUnitClassType][6].)                                                                                                            
![Public property] | [InternalLink][30]                    | Gets the collection of InternalLink objects contained in this instance. (Inherited from [SystemUnitClassType][6].)                                                                                                      
![Public property] | [Name][31]                            | Gets and sets the name of the CAEX object (required in CAEX). (Inherited from [CAEXObject][5].)                                                                                                                         
![Public property] | [Node][32]                            | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][3].)                                                                                                                                                         
![Public property] | [Owner][33]                           | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][3].)                                                                                                                                                
![Public property] | [Revision][34]                        | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][4].)                                                                                                              
![Public property] | [RoleReferences][35]                  | Gets all role references for the SystemUnitClass. The collection includes all RoleRequirement objects and SupportedRoleClass objects. (Inherited from [SystemUnitClassType][6].)                                        
![Public property] | [SourceObjectInformation][36]         | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][4].)                                                                                               
![Public property] | [SupportedRoleClass][37]              | Gets the collection of SupportedRoleClass objects contained in this instance. (Inherited from [SystemUnitClassType][6].)                                                                                                
![Public property] | [TagName][38]                         | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][3].)                                                                                                                                  
![Public property] | [Version][39]                         | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][4].)                                                                                                                                       
![Public property] | [VersionElement][40]                  | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][4].)                                                                                                                                        


Methods
-------

                                | Name                                                                            | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           
------------------------------- | ------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]                | [AddFacet][41]                                                                  | Adds an AMLFacet object to the AMLSystemUnitClass with the provided name.                                                                                                                                                                                                                                                                                                                                                                                                                                             
![Public method]                | [AddGroup][42]                                                                  | Adds an AMLGroup object to the AMLSystemUnitClass with the provided name.                                                                                                                                                                                                                                                                                                                                                                                                                                             
![Public method]![Code example] | [AddInterfaceClassReference(String, Boolean, Boolean, String)][43]              | Adds an InterfaceClass reference to this SystemUnitClass object using the provided CAEX path, referencing an InterfaceClass object. The InterfaceClass reference is added as a [ExternalInterfaceType][44] object. (Inherited from [SystemUnitClassType][6].)                                                                                                                                                                                                                                                         
![Public method]![Code example] | [AddInterfaceClassReference(InterfaceFamilyType, Boolean, Boolean, String)][45] | Adds an InterfaceClass reference to this SystemUnitClass object using the provided InterfaceClass object. The InterfaceClass reference is added as a [ExternalInterfaceType][44] object. (Inherited from [SystemUnitClassType][6].)                                                                                                                                                                                                                                                                                   
![Public method]                | [AddPort][46]                                                                   | Adds an AMLPort object to the AMLSystemUnitClass with the provided name.                                                                                                                                                                                                                                                                                                                                                                                                                                              
![Public method]                | [AssignNewGuidAsID][47]                                                         | Assigns the new unique identifier as a new ID to this CAEX object. (Inherited from [CAEXObject][5].)                                                                                                                                                                                                                                                                                                                                                                                                                  
![Public method]                | [CAEXChild][48]                                                                 | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                                                                                                                                           
![Public method]                | [CAEXChildren][49]                                                              | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                                                                                                                                              
![Public method]                | [CAEXPath][50]                                                                  | Gets the CAEX path for this object. A path can be used to uniquely reference an object, for example in inheritances and instances. The path syntax for an object is defined differently in CAEX 2.15 and CAEX 3.0. The engine uses the [CAEXPathBuilder][51] to generate the CAEX path of an object according to the documents CAEX version. (Inherited from [CAEXObject][5].)                                                                                                                                        
![Public method]                | [CAEXSequence][52]                                                              | Gets the CAEXSequence owned by this CAEX object, which contains the specified CAEX object. (Inherited from [SystemUnitClassType][6].)                                                                                                                                                                                                                                                                                                                                                                                 
![Public method]                | [Container&lt;T>][53]                                                           | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Inherited from [SystemUnitClassType][6].)                                                                                                                                                                                                                                                                                                                                                                                         
![Public method]                | [Copy][54]                                                                      | Creates a copy of this CAEX object, containing all child elements. The created copy will have replaced unique IDs and updated references, if the *assignNewIDs* is set to true (default). When a CAEX class is copied, the nested classes that can exist for AttributeType, RoleClass, SystemUnitClass, and InterfaceClass could be included in the created copy, if the *includeSubClasses* is set to `true`. (Inherited from [CAEXObject][5].)                                                                      
![Public method]                | [Equals][55]                                                                    | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                                                                                                                         
![Public method]                | [GetEnumerator][56]                                                             | Enumeration of contained InternalElement objects (Inherited from [SystemUnitClassType][6].)                                                                                                                                                                                                                                                                                                                                                                                                                           
![Public method]                | [GetHashCode][57]                                                               | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                                                                                                                                               
![Public method]                | [GetXAttributeValue][58]                                                        | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                                                                                                                  
![Public method]![Code example] | [HasInterfaceClassReference][59]                                                | Determines whether this CAEX Element has an associated reference to the specified InterfaceClass. If inheritance relations between InterfaceClasses should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified InterfaceClass is either identical to a referenced InterfaceClass or a referenced InterfaceClass is derived from the specified InterfaceClass. (Inherited from [SystemUnitClassType][6].)                                                                
![Public method]                | [Insert(Int32, CAEXWrapper)][60]                                                | Inserts the specified CAEX object in it's associated sequence. The SystemUnitClass defines the [Attribute][14], [ExternalInterface][26], [InternalElement][29], [InternalLink][30], and [SupportedRoleClass][37] sequence. (Inherited from [SystemUnitClassType][6].)                                                                                                                                                                                                                                                 
![Public method]                | [Insert(CAEXWrapper, Boolean)][61]                                              | Inserts the specified CAEX object in it's associated sequence. The SystemUnitClass defines the [Attribute][14], [ExternalInterface][26], [InternalElement][29], [InternalLink][30], and [SupportedRoleClass][37] sequence. (Inherited from [SystemUnitClassType][6].)                                                                                                                                                                                                                                                 
![Public method]                | [InsertAfter][62]                                                               | Inserts the provided CAEX object as a new sibling after this CAEX object. (Inherited from [SystemUnitClassType][6].)                                                                                                                                                                                                                                                                                                                                                                                                  
![Public method]                | [InsertBefore][63]                                                              | Inserts the provided CAEX object as a new sibling before this CAEX object. (Inherited from [SystemUnitClassType][6].)                                                                                                                                                                                                                                                                                                                                                                                                 
![Public method]                | [InsertNew][64]                                                                 | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][33] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                      
![Public method]                | [LowestCommonParent][65]                                                        | Gets the Lowest common parent to this SystemUnitClass and the provided SystemUnitClass. The common parent is used to store an InternalLink relating this two SystemUnitClass objects. An InternalLink is not allowed to leave the boundary of a SystemUnitClass which means, that no common parent is defined for two different SystemUnitClass objects. If one Element is a SystemUnitClass the other one should be an InternalElement descendant of the SystemUnitClass. (Inherited from [SystemUnitClassType][6].) 
![Public method]                | [New_Revision][66]                                                              | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][34] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][4].)                                                                                                                                                                                                               
![Public method]                | [Remove][67]                                                                    | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                                                                                                                  
![Public method]                | [SetXAttributeValue][68]                                                        | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                                                                                                                 
![Public method]                | [SupportedRoleClassWithName][69]                                                | Get the RoleClass from the sequence of [SupportedRoleClass][37] with the provided *roleClassName*. (Inherited from [SystemUnitClassType][6].)                                                                                                                                                                                                                                                                                                                                                                         
![Public method]                | [ToString][70]                                                                  | Returns the value of the 'Name' attribute of this CAEX object as the string representation of the object. (Inherited from [CAEXObject][5].)                                                                                                                                                                                                                                                                                                                                                                           


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][71] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][3].) 


Extension Methods
-----------------

                           | Name                                                                 | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
-------------------------- | -------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public Extension Method] | [AddDocumentElement][72]                                             | Adds a document element to the defined internalElement. A Document Element is semantically described with an attached role defined with the base role class [ExternalDataRoleClassPath][73] or a derived role class. If no role class path is given as a parameter the default is used. If the specified role class path can not be identified as a derived role from the [ExternalDataRoleClassPath][73] no document element is added (returns null). (Defined by [ExternalDataReference][74].) 
![Public Extension Method] | [AddInstance][75]                                                    | Inserts a new class instance to the InternalElement collection of the parentInternalElement. If there are existing instances of the same Type, the Element is inserted after the last Element of that Type. Before Insertion, the Uniqueness of the Name among the siblings of that Type is checked. (Defined by [SystemUnitClassTypeExtensions][76].)                                                                                                                                           
![Public Extension Method] | [AddNewInternalElement][77]                                          | Creates a new InternalElement and inserts it after the last InternalElement of the parent if the elementName is unique among the child's. The ChangeMode is set to the Value 'Create' (Defined by [SystemUnitClassTypeExtensions][76].)                                                                                                                                                                                                                                                          
![Public Extension Method] | [AMLSystemUnitClass][78]                                             | Converts an SystemUnitClassType to an AMLSystemUnitClass. (Defined by [AmlObjectsExtensions][79].)                                                                                                                                                                                                                                                                                                                                                                                               
![Public Extension Method] | [Ancestors][80]                                                      | Returns all SystemUnit Classes which are ancestors of this. This SystemUnit Class is included in the enumeration as the first Element, The farthest is the last Element in the enumeration. (Defined by [AMLEngineAdapter][81].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [Append_InternalElement][82]                                         | Inserts the InternalElement object after the defined Predecessor in the InternalElement collection of the SystemUnitClass. If the Predecessor is null, the InternalElement object is inserted at the first position of the InternalElement collection. (Defined by [SystemUnitClassTypeExtensions][76].)                                                                                                                                                                                         
![Public Extension Method] | [AssignNewGUIDsAndRedirectExistingInternalLinks][83]                 | Assigns the new GUIds and redirect existing internal links. (Defined by [AMLEngineAdapter][81].)                                                                                                                                                                                                                                                                                                                                                                                                 
![Public Extension Method] | [AssignNewGUIDsAndRedirectExistingInternalLinksAndMirrorObjects][84] | This Method assigns new GUIds to the SystemUnitClass and its subordinate Children, which have an ID. The References to the old IDs in Mirrors and InternalLinks are redirected to the new ID. If a Reference is not found in any of the subordinate Elements, the Reference will not be changed. (Defined by [AMLEngineAdapter][81].)                                                                                                                                                            
![Public Extension Method] | [clone][85]                                                          | [Copy(Boolean, Boolean, Boolean)][86] (Defined by [AMLEngineAdapter][81].)                                                                                                                                                                                                                                                                                                                                                                                                                       
![Public Extension Method] | [CloneNode][87]                                                      | Clones the node. (Defined by [AMLEngineAdapter][81].)                                                                                                                                                                                                                                                                                                                                                                                                                                            
![Public Extension Method] | [ConsistencyCheck_ClassReference][88]                                | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][81].)                                                                                                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [Copy][89]                                                           | Copies the CAEX object and assigns the name to the created copy. (Defined by [CAEXObjectExtensions][90].)                                                                                                                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [Descendants(Type)][91]                                              | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][92].)                                                                                                                                                                                                                                                                                                                                                         
![Public Extension Method] | [Descendants&lt;T>()][93]                                            | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][92].)                                                                                                                                                                                                                                                                                                                                                         
![Public Extension Method] | [DocumentElements][94]                                               | Gets all Internal Element Children from the specified internal element which are document elements. (Defined by [ExternalDataReference][74].)                                                                                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [findInternalElement][95]                                            | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][81].)                                                                                                                                                                                                                                                                                                                                                                       
![Public Extension Method] | [getLinkedObjects][96]                                               | Getting a List of LinkedObjects object of this SystemUnitClass containing references to the concrete referenced InternalElements via an InternalLink. (Defined by [AMLEngineAdapter][81].)                                                                                                                                                                                                                                                                                                       
![Public Extension Method] | [getReferencedClass][97]                                             | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][81].)                                                                                                                                                                                                                                                                                                                                                                                                                      
![Public Extension Method] | [getReferencedGUID][98]                                              | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][81].)                                                                                                                                                                                                                                                                                                                                                                                              
![Public Extension Method] | [getReferencedInterfaceClass][99]                                    | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][81].)                                                                                                                                                                                                                                                                                                                                                                            
![Public Extension Method] | [getReferencedInterfaceName][100]                                    | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][81].)                                                                                                                                                                                                                                                                                                                                                                                                               
![Public Extension Method] | [Insert_Element][101]                                                | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][81].)                                                                                                                                                                                                                                                                      
![Public Extension Method] | [Insert_InternalLink][102]                                           | Inserts the specified InternalLink as the first InternalLink if nothing else if explicit defined. (Defined by [SystemUnitClassTypeExtensions][76].)                                                                                                                                                                                                                                                                                                                                              
![Public Extension Method] | [Insert_NewInstance][103]                                            | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][81].)                                                                                                                                                                                                                                
![Public Extension Method] | [Insert_SupportedRoleClass][104]                                     | Inserts the SupportedRoleClass as the first SupportedRoleClass if nothing else if explicit defined. (Defined by [SystemUnitClassTypeExtensions][76].)                                                                                                                                                                                                                                                                                                                                            
![Public Extension Method] | [Insert_TypeBaseElement][105]                                        | [Insert(CAEXWrapper, Boolean)][106] (Defined by [AMLEngineAdapter][81].)                                                                                                                                                                                                                                                                                                                                                                                                                         
![Public Extension Method] | [InternalLinksToElement][107]                                        | Gets all InternalLink referencing the provided SystemUnitClass object. (Defined by [QueryResult][108].)                                                                                                                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [Name()][109]                                                        | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][81].)                                                                                                                                                                                                                                                                                                                                                                                                           
![Public Extension Method] | [Name()][110]                                                        | Overloaded. Gets a names for the specified CAEX wrapper object. If the specified object is a [CAEXObject][5], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][92].)                                                                                                                                                                                                                                                                        
![Public Extension Method] | [New_Description][111]                                               | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][92].)                                                                                                                                                                                                                                                                                                                                                                                  
![Public Extension Method] | [New_InternalLink][112]                                              | Inserts a new InternalLink as the first InternalLink if nothing else if explicit defined. (Defined by [SystemUnitClassTypeExtensions][76].)                                                                                                                                                                                                                                                                                                                                                      
![Public Extension Method] | [New_SupportedRoleClass][113]                                        | Inserts a new SupportedRoleClass as the first SupportedRoleClass if nothing else if explicit defined. (Defined by [SystemUnitClassTypeExtensions][76].)                                                                                                                                                                                                                                                                                                                                          


Explicit Interface Implementations
----------------------------------

                                                      | Name                             | Description                                                                                 
----------------------------------------------------- | -------------------------------- | ------------------------------------------------------------------------------------------- 
![Explicit interface implementation]![Private method] | [IEnumerable.GetEnumerator][114] | Enumeration of contained InternalElement objects (Inherited from [SystemUnitClassType][6].) 


See Also
--------

#### Reference
[Aml.Engine.AmlObjects Namespace][7]  
[Aml.Engine.CAEX.SystemUnitClassType][6]  

[1]: ../AMLPort/README.md
[2]: https://docs.microsoft.com/dotnet/api/system.object
[3]: ../../Aml.Engine.CAEX/CAEXWrapper/README.md
[4]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[5]: ../../Aml.Engine.CAEX/CAEXObject/README.md
[6]: ../../Aml.Engine.CAEX/SystemUnitClassType/README.md
[7]: ../README.md
[8]: _ctor_1.md
[9]: _ctor.md
[10]: ../../Aml.Engine.CAEX/CAEXBasicObject/AdditionalInformation.md
[11]: AMLFacets.md
[12]: AMLGroups.md
[13]: AMLPorts.md
[14]: ../../Aml.Engine.CAEX/SystemUnitClassType/Attribute.md
[15]: ../../Aml.Engine.CAEX/SystemUnitClassType/AttributeAndDescendants.md
[16]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXDocument.md
[17]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXParent.md
[18]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXSequenceOfCAEXObject.md
[19]: ../../Aml.Engine.CAEX/CAEXBasicObject/ChangeMode.md
[20]: ../../Aml.Engine.CAEX/CAEXBasicObject/Copyright.md
[21]: ../../Aml.Engine.CAEX/CAEXBasicObject/CopyrightElement.md
[22]: ../../Aml.Engine.CAEX/CAEXBasicObject/Description.md
[23]: ../../Aml.Engine.CAEX/CAEXBasicObject/DescriptionElement.md
[24]: ../../Aml.Engine.CAEX/CAEXWrapper/Document.md
[25]: ../../Aml.Engine.CAEX/CAEXWrapper/Exists.md
[26]: ../../Aml.Engine.CAEX/SystemUnitClassType/ExternalInterface.md
[27]: ../../Aml.Engine.CAEX/SystemUnitClassType/ExternalInterfaceAndDescendants.md
[28]: ../../Aml.Engine.CAEX/CAEXObject/ID.md
[29]: ../../Aml.Engine.CAEX/SystemUnitClassType/InternalElement.md
[30]: ../../Aml.Engine.CAEX/SystemUnitClassType/InternalLink.md
[31]: ../../Aml.Engine.CAEX/CAEXObject/Name.md
[32]: ../../Aml.Engine.CAEX/CAEXWrapper/Node.md
[33]: ../../Aml.Engine.CAEX/CAEXWrapper/Owner.md
[34]: ../../Aml.Engine.CAEX/CAEXBasicObject/Revision.md
[35]: ../../Aml.Engine.CAEX/SystemUnitClassType/RoleReferences.md
[36]: ../../Aml.Engine.CAEX/CAEXBasicObject/SourceObjectInformation.md
[37]: ../../Aml.Engine.CAEX/SystemUnitClassType/SupportedRoleClass.md
[38]: ../../Aml.Engine.CAEX/CAEXWrapper/TagName.md
[39]: ../../Aml.Engine.CAEX/CAEXBasicObject/Version.md
[40]: ../../Aml.Engine.CAEX/CAEXBasicObject/VersionElement.md
[41]: AddFacet.md
[42]: AddGroup.md
[43]: ../../Aml.Engine.CAEX/SystemUnitClassType/AddInterfaceClassReference_1.md
[44]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[45]: ../../Aml.Engine.CAEX/SystemUnitClassType/AddInterfaceClassReference.md
[46]: AddPort.md
[47]: ../../Aml.Engine.CAEX/CAEXObject/AssignNewGuidAsID.md
[48]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXChild.md
[49]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXChildren.md
[50]: ../../Aml.Engine.CAEX/CAEXObject/CAEXPath.md
[51]: ../../Aml.Engine.CAEX.Extensions/CAEXPathBuilder/README.md
[52]: ../../Aml.Engine.CAEX/SystemUnitClassType/CAEXSequence.md
[53]: ../../Aml.Engine.CAEX/SystemUnitClassType/Container__1.md
[54]: ../../Aml.Engine.CAEX/CAEXObject/Copy.md
[55]: ../../Aml.Engine.CAEX/CAEXWrapper/Equals.md
[56]: ../../Aml.Engine.CAEX/SystemUnitClassType/GetEnumerator.md
[57]: ../../Aml.Engine.CAEX/CAEXWrapper/GetHashCode.md
[58]: ../../Aml.Engine.CAEX/CAEXWrapper/GetXAttributeValue.md
[59]: ../../Aml.Engine.CAEX/SystemUnitClassType/HasInterfaceClassReference.md
[60]: ../../Aml.Engine.CAEX/SystemUnitClassType/Insert_1.md
[61]: ../../Aml.Engine.CAEX/SystemUnitClassType/Insert.md
[62]: ../../Aml.Engine.CAEX/SystemUnitClassType/InsertAfter.md
[63]: ../../Aml.Engine.CAEX/SystemUnitClassType/InsertBefore.md
[64]: ../../Aml.Engine.CAEX/CAEXWrapper/InsertNew.md
[65]: ../../Aml.Engine.CAEX/SystemUnitClassType/LowestCommonParent.md
[66]: ../../Aml.Engine.CAEX/CAEXBasicObject/New_Revision.md
[67]: ../../Aml.Engine.CAEX/CAEXWrapper/Remove.md
[68]: ../../Aml.Engine.CAEX/CAEXWrapper/SetXAttributeValue.md
[69]: ../../Aml.Engine.CAEX/SystemUnitClassType/SupportedRoleClassWithName.md
[70]: ../../Aml.Engine.CAEX/CAEXObject/ToString.md
[71]: ../../Aml.Engine.CAEX/CAEXWrapper/PropertyChanged.md
[72]: ../ExternalDataReference/AddDocumentElement.md
[73]: ../ExternalDataReference/ExternalDataRoleClassPath.md
[74]: ../ExternalDataReference/README.md
[75]: ../../Aml.Engine.CAEX.Extensions/SystemUnitClassTypeExtensions/AddInstance.md
[76]: ../../Aml.Engine.CAEX.Extensions/SystemUnitClassTypeExtensions/README.md
[77]: ../../Aml.Engine.CAEX.Extensions/SystemUnitClassTypeExtensions/AddNewInternalElement.md
[78]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/AMLSystemUnitClass.md
[79]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[80]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Ancestors.md
[81]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[82]: ../../Aml.Engine.CAEX.Extensions/SystemUnitClassTypeExtensions/Append_InternalElement.md
[83]: ../../Aml.Engine.Adapter/AMLEngineAdapter/AssignNewGUIDsAndRedirectExistingInternalLinks.md
[84]: ../../Aml.Engine.Adapter/AMLEngineAdapter/AssignNewGUIDsAndRedirectExistingInternalLinksAndMirrorObjects.md
[85]: ../../Aml.Engine.Adapter/AMLEngineAdapter/clone.md
[86]: ../../Aml.Engine.CAEX/CAEXWrapper/Copy.md
[87]: ../../Aml.Engine.Adapter/AMLEngineAdapter/CloneNode.md
[88]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ConsistencyCheck_ClassReference.md
[89]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/Copy.md
[90]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/README.md
[91]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[92]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[93]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[94]: ../ExternalDataReference/DocumentElements.md
[95]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[96]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getLinkedObjects.md
[97]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedClass.md
[98]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedGUID.md
[99]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceClass.md
[100]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceName.md
[101]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_Element.md
[102]: ../../Aml.Engine.CAEX.Extensions/SystemUnitClassTypeExtensions/Insert_InternalLink.md
[103]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_NewInstance.md
[104]: ../../Aml.Engine.CAEX.Extensions/SystemUnitClassTypeExtensions/Insert_SupportedRoleClass.md
[105]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_TypeBaseElement.md
[106]: ../../Aml.Engine.CAEX/CAEXBasicObject/Insert.md
[107]: ../../Aml.Engine.Services/QueryResult/InternalLinksToElement.md
[108]: ../../Aml.Engine.Services/QueryResult/README.md
[109]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Name.md
[110]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[111]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[112]: ../../Aml.Engine.CAEX.Extensions/SystemUnitClassTypeExtensions/New_InternalLink.md
[113]: ../../Aml.Engine.CAEX.Extensions/SystemUnitClassTypeExtensions/New_SupportedRoleClass.md
[114]: ../../Aml.Engine.CAEX/SystemUnitClassType/System_Collections_IEnumerable_GetEnumerator.md
[115]: https://www.automationml.org
[116]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Code example]: ../../icons/CodeExample.png "Code example"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"
[Explicit interface implementation]: ../../icons/pubinterface.gif "Explicit interface implementation"
[Private method]: ../../icons/privmethod.gif "Private method"