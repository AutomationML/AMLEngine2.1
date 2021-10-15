ObjectWithAMLAttributes Class
=============================
This class defines specific AutomationML defined attributes to be associated to any AutomationML object, which is allowed to contain attributes. Instances of this class can be constructed with an implicit type conversion operator, defined in the wrapper classes, which implement the [IObjectWithAttributes][1] interface.


Inheritance Hierarchy
---------------------
[System.Object][2]  
  [Aml.Engine.CAEX.CAEXWrapper][3]  
    [Aml.Engine.CAEX.CAEXBasicObject][4]  
      [Aml.Engine.CAEX.CAEXObject][5]  
        **Aml.Engine.AmlObjects.ObjectWithAMLAttributes**  

  **Namespace:**  [Aml.Engine.AmlObjects][6]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class ObjectWithAMLAttributes : CAEXObject, 
	IObjectWithAttributes, ICAEXWrapper, IXMLWrapper
```

The **ObjectWithAMLAttributes** type exposes the following members.


Constructors
------------

                 | Name                         | Description                                                                                 
---------------- | ---------------------------- | ------------------------------------------------------------------------------------------- 
![Public method] | [ObjectWithAMLAttributes][7] | Creates a wrapper to access specific AML Attributes for the provides object with attributes 


Properties
----------

                   | Name                           | Description                                                                                                                                                                                                             
------------------ | ------------------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AdditionalInformation][8]     | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [CAEXBasicObject][4].)                                                                                                  
![Public property] | [Attribute][9]                 | Get the collection of all attributes of this object. Inherited Attributes are not included.                                                                                                                             
![Public property] | [AttributeAndDescendants][10]  | Gets the attributes and all nested attributes.                                                                                                                                                                          
![Public property] | [CAEXBase][11]                 | The CAEXWrapper of the base CAEXObject which contains the here defined AML attributes                                                                                                                                   
![Public property] | [CAEXDocument][12]             | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][3].)                     
![Public property] | [CAEXParent][13]               | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][3].)                                                                                                                                   
![Public property] | [CAEXSequenceOfCAEXObject][14] | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][3].)                                                                                                                                    
![Public property] | [ChangeMode][15]               | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [CAEXBasicObject][4].)                                                                                                             
![Public property] | [Copyright][16]                | Gets and sets the Copyright for this object. (Inherited from [CAEXBasicObject][4].)                                                                                                                                     
![Public property] | [CopyrightElement][17]         | Gets the wrapper for the Copyright element. (Inherited from [CAEXBasicObject][4].)                                                                                                                                      
![Public property] | [Description][18]              | Gets and sets the Description for this object. (Inherited from [CAEXBasicObject][4].)                                                                                                                                   
![Public property] | [DescriptionElement][19]       | Gets the wrapper for the Description element. (Inherited from [CAEXBasicObject][4].)                                                                                                                                    
![Public property] | [Document][20]                 | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][3].)                                                                                                                                        
![Public property] | [Exists][21]                   | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][3].)                                                                                                                       
![Public property] | [FrameAttribute][22]           | Gets a defined FrameAttribute from the [Attribute][23] collection of the [CAEXBase][11]. If no such attribute exists, `null` is returned.                                                                               
![Public property] | [ID][24]                       | Gets and sets a unique identifier of the CAEX object (optional in CAEX). AutomationML requires IDs for some Elements. These IDs are automatically set when such elements are created. (Inherited from [CAEXObject][5].) 
![Public property] | [Name][25]                     | Gets and sets the name of the CAEX object (required in CAEX). (Inherited from [CAEXObject][5].)                                                                                                                         
![Public property] | [Node][26]                     | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][3].)                                                                                                                                                         
![Public property] | [Owner][27]                    | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][3].)                                                                                                                                                
![Public property] | [RefTypeAttribute][28]         | Gets a defined RefTypeAttribute from the [Attribute][23] collection of the [CAEXBase][11]. If no such attribute exists, `null` is returned.                                                                             
![Public property] | [RefURIAttribute][29]          | Gets a defined RefURIAttribute from the [Attribute][23] collection of the [CAEXBase][11]. If no such attribute exists, `null` is returned.                                                                              
![Public property] | [Revision][30]                 | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][4].)                                                                                                              
![Public property] | [SourceObjectInformation][31]  | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][4].)                                                                                               
![Public property] | [TagName][32]                  | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][3].)                                                                                                                                  
![Public property] | [Version][33]                  | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][4].)                                                                                                                                       
![Public property] | [VersionElement][34]           | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][4].)                                                                                                                                        


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                                                                                                                                                                                      
---------------- | ---------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public method] | [AssignNewGuidAsID][35]            | Assigns the new unique identifier as a new ID to this CAEX object. (Inherited from [CAEXObject][5].)                                                                                                                                                                                                                                                                                                                                             
![Public method] | [CAEXChild][36]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                                                                      
![Public method] | [CAEXChildren][37]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                                                                         
![Public method] | [CAEXPath][38]                     | Gets the CAEX path for this object. A path can be used to uniquely reference an object, for example in inheritances and instances. The path syntax for an object is defined differently in CAEX 2.15 and CAEX 3.0. The engine uses the [CAEXPathBuilder][39] to generate the CAEX path of an object according to the documents CAEX version. (Inherited from [CAEXObject][5].)                                                                   
![Public method] | [CAEXSequence][40]                 | Gets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects [Revision][30] is returned. (Inherited from [CAEXBasicObject][4].)                                                                                                                                                                                       
![Public method] | [Container&lt;T>][41]              | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Inherited from [CAEXBasicObject][4].)                                                                                                                                                                                                                                                                                                                        
![Public method] | [Copy][42]                         | Creates a copy of this CAEX object, containing all child elements. The created copy will have replaced unique IDs and updated references, if the *assignNewIDs* is set to true (default). When a CAEX class is copied, the nested classes that can exist for AttributeType, RoleClass, SystemUnitClass, and InterfaceClass could be included in the created copy, if the *includeSubClasses* is set to `true`. (Inherited from [CAEXObject][5].) 
![Public method] | [Equals][43]                       | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                                                    
![Public method] | [GetHashCode][44]                  | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                                                                          
![Public method] | [GetXAttributeValue][45]           | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                                             
![Public method] | [Insert(Int32, CAEXWrapper)][46]   | Inserts the specified CAEX object in it's associated sequence at the defined position. The CAEXBasicObject defines the [Revision][30] and [SourceObjectInformation][31] sequences. (Inherited from [CAEXBasicObject][4].)                                                                                                                                                                                                                        
![Public method] | [Insert(CAEXWrapper, Boolean)][47] | Inserts the specified CAEX object in it's associated sequence. The CAEXBasicObject defines the [Revision][30] and [SourceObjectInformation][31] sequences. (Inherited from [CAEXBasicObject][4].)                                                                                                                                                                                                                                                
![Public method] | [InsertNew][48]                    | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][27] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                 
![Public method] | [New_FrameAttribute][49]           | Creates a new Frame attribute for the [CAEXBase][11] if no Frame attribute exists. The provided values are used to initialize the Frame attribute values.                                                                                                                                                                                                                                                                                        
![Public method] | [New_RefUriAttribute][50]          | Creates a new RefURI attribute for the [CAEXBase][11] object if none exists. The RefURI attribute value is set to the provided Uri.                                                                                                                                                                                                                                                                                                              
![Public method] | [New_Revision][51]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][30] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][4].)                                                                                                                                          
![Public method] | [Remove][52]                       | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                                             
![Public method] | [SetXAttributeValue][53]           | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                                            
![Public method] | [ToString][54]                     | Returns the value of the 'Name' attribute of this CAEX object as the string representation of the object. (Inherited from [CAEXObject][5].)                                                                                                                                                                                                                                                                                                      


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][55] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][3].) 


Extension Methods
-----------------

                                          | Name                                                                           | Description                                                                                                                                                                                                                                                                                                                                                                              
----------------------------------------- | ------------------------------------------------------------------------------ | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method]![Code example] | [AddAttributeTypeReference(String, Boolean, Boolean, String)][56]              | Overloaded. Adds an AttributeType reference to this ObjectWithAttribute using the provided CAEX path, referencing an AttributeType object. The AttributeType reference is added as a [AttributeType][57] object. (Defined by [ObjectWithAttributes][58].)                                                                                                                                
![Public Extension Method]![Code example] | [AddAttributeTypeReference(AttributeFamilyType, Boolean, Boolean, String)][59] | Overloaded. Adds an AttributeType reference to this ObjectWithAttribute using the provided AttributeType object. The AttributeType reference is added as a [AttributeType][57] object. (Defined by [ObjectWithAttributes][58].)                                                                                                                                                          
![Public Extension Method]                | [AMLAttributes][60]                                                            | Conversion of any object which has an attribute collection to get access to specific AutomationML defined attributes. (Defined by [AmlObjectsExtensions][61].)                                                                                                                                                                                                                           
![Public Extension Method]                | [AMLSchemaManager][62]                                                         | Gets the associated CAEX schema manager of the CAEX object. (Defined by [CAEXBasicObjectExtensions][63].)                                                                                                                                                                                                                                                                                
![Public Extension Method]                | [Ancestors&lt;T>][64]                                                          | Finds the ancestors of the provided CAEX object which have the given type. (Defined by [CAEXBasicObjectExtensions][63].)                                                                                                                                                                                                                                                                 
![Public Extension Method]                | [Attributes][65]                                                               | Enumeration Method for direct Children of Type [AttributeType][57] (Defined by [AMLEngineAdapter][66].)                                                                                                                                                                                                                                                                                  
![Public Extension Method]                | [CAEXDocument][67]                                                             | Gets the CAEX document which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][63].)                                                                                                                                                                                                                                                                                    
![Public Extension Method]                | [CAEXFile][68]                                                                 | Gets the CAEX file which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][63].)                                                                                                                                                                                                                                                                                        
![Public Extension Method]                | [CAEXSchema][69]                                                               | Gets the associated CAEX schema of the CAEX object. (Defined by [CAEXBasicObjectExtensions][63].)                                                                                                                                                                                                                                                                                        
![Public Extension Method]                | [clone][70]                                                                    | [Copy(Boolean, Boolean, Boolean)][71] (Defined by [AMLEngineAdapter][66].)                                                                                                                                                                                                                                                                                                               
![Public Extension Method]                | [CloneNode][72]                                                                | Clones the node. (Defined by [AMLEngineAdapter][66].)                                                                                                                                                                                                                                                                                                                                    
![Public Extension Method]                | [ConsistencyCheck_ClassReference][73]                                          | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][66].)                                                                                                                                                                                                                                                                  
![Public Extension Method]                | [Copy][74]                                                                     | Copies the CAEX object and assigns the name to the created copy. (Defined by [CAEXObjectExtensions][75].)                                                                                                                                                                                                                                                                                
![Public Extension Method]                | [CopyAttributesFrom][76]                                                       | Copies all attribute of the source object with attributes to the target object including children (Defined by [ObjectWithAttributes][58].)                                                                                                                                                                                                                                               
![Public Extension Method]                | [CreateListAttribute][77]                                                      | Creates a new list attribute for an element which can have attributes. (Defined by [ListAttribute][78].)                                                                                                                                                                                                                                                                                 
![Public Extension Method]                | [Descendants(Type)][79]                                                        | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][63].)                                                                                                                                                                                                                                                 
![Public Extension Method]                | [Descendants&lt;T>()][80]                                                      | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][63].)                                                                                                                                                                                                                                                 
![Public Extension Method]                | [Descendants&lt;T>(Boolean)][81]                                               | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][63].)                                                                                                                                                                                                                                                 
![Public Extension Method]                | [FindCaexObjectFromId&lt;T>][82]                                               | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][63].)                                                                                                                                                                                                                                                                        
![Public Extension Method]                | [findInternalElement][83]                                                      | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][66].)                                                                                                                                                                                                                                                               
![Public Extension Method]                | [FindReferencedClass&lt;T>][84]                                                | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][63].)                                                                                                                                                                                                                                                                 
![Public Extension Method]                | [FirstAncestor(String)][85]                                                    | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][63].)                                                                                                                                                                                                                                                  
![Public Extension Method]                | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][86]                                | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][63].)                                                                                                                                                                                                                                    
![Public Extension Method]                | [FirstAncestor&lt;T>()][87]                                                    | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][63].)                                                                                                                                                                                                                                                       
![Public Extension Method]                | [FrameAttribute][88]                                                           | Gets a defined FrameAttribute from the [Attribute][23] collection of the [IObjectWithAttributes][1]. If no such attribute exists, `null` is returned. (Defined by [AmlObjectsExtensions][61].)                                                                                                                                                                                           
![Public Extension Method]                | [GetAttribute][89]                                                             | Gets the first attribute with the specified name from the attribute collection of the CAEX object. (Defined by [ObjectWithAttributes][58].)                                                                                                                                                                                                                                              
![Public Extension Method]                | [getAttributeField][90]                                                        | Get the whole attribute field containing a collection of all attributes of this object. (Defined by [AMLEngineAdapter][66].)                                                                                                                                                                                                                                                             
![Public Extension Method]                | [GetAttributeValue][91]                                                        | Returns an attribute value of a given attribute name. (Defined by [AMLEngineAdapter][66].)                                                                                                                                                                                                                                                                                               
![Public Extension Method]                | [GetParent&lt;T>][92]                                                          | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][63].)                                                                                                                                                                                 
![Public Extension Method]                | [getReferencedClass][93]                                                       | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][66].)                                                                                                                                                                                                                                                                                                              
![Public Extension Method]                | [getReferencedGUID][94]                                                        | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][66].)                                                                                                                                                                                                                                                                                      
![Public Extension Method]                | [getReferencedInterfaceClass][95]                                              | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][66].)                                                                                                                                                                                                                                                                    
![Public Extension Method]                | [getReferencedInterfaceName][96]                                               | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][66].)                                                                                                                                                                                                                                                                                                       
![Public Extension Method]                | [Insert_Attribute][97]                                                         | Inserts an Attribute object in the Attribute collection of the *objectWithAttributes*. (Defined by [SystemUnitClassTypeExtensions][98].)                                                                                                                                                                                                                                                 
![Public Extension Method]                | [Insert_Element][99]                                                           | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][66].)                                                                                                                                                              
![Public Extension Method]                | [Insert_NewInstance][100]                                                      | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][66].)                                                                                                                        
![Public Extension Method]                | [Insert_TypeBaseElement][101]                                                  | [Insert(CAEXWrapper, Boolean)][47] (Defined by [AMLEngineAdapter][66].)                                                                                                                                                                                                                                                                                                                  
![Public Extension Method]                | [IsAMLObject][102]                                                             | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][61].) 
![Public Extension Method]                | [Library][103]                                                                 | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][63].)                                                                                                                                                                                                                                                                                          
![Public Extension Method]                | [Name()][104]                                                                  | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][66].)                                                                                                                                                                                                                                                                                                   
![Public Extension Method]                | [Name()][105]                                                                  | Overloaded. Gets a names for the specified CAEX wrapper object. If the specified object is a [CAEXObject][5], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][63].)                                                                                                                                                                
![Public Extension Method]                | [New_Attribute][106]                                                           | Appends a new Attribute object with the defined name to the specified CAEX object. (Defined by [ObjectWithAttributes][58].)                                                                                                                                                                                                                                                              
![Public Extension Method]                | [New_Description][107]                                                         | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][63].)                                                                                                                                                                                                                                                                          
![Public Extension Method]                | [New_FrameAttribute][108]                                                      | Creates a new Frame attribute for the [IObjectWithAttributes][1] if no Frame attribute exists. The provided values are used to initialize the Frame attribute values. (Defined by [AmlObjectsExtensions][61].)                                                                                                                                                                           
![Public Extension Method]                | [RefTypeAttribute][109]                                                        | Gets the RefTypeAttribute from the *objectWithAttributes* if one exists. (Defined by [AmlObjectsExtensions][61].)                                                                                                                                                                                                                                                                        
![Public Extension Method]                | [RefURIAttribute][110]                                                         | Gets the RefURIAttribute from the *objectWithAttributes* if one exists. (Defined by [AmlObjectsExtensions][61].)                                                                                                                                                                                                                                                                         
![Public Extension Method]                | [SetAttributeValue(String, String)][111]                                       | Overloaded. Sets the value for the attribute with the specified name from the attribute collection of the CAEX object. If no attribute with that name exists, it is created. (Defined by [ObjectWithAttributes][58].)                                                                                                                                                                    
![Public Extension Method]                | [SetAttributeValue(String, Double)][112]                                       | Overloaded. Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created. Sets the AttributeDataType to xs:double (Defined by [ObjectWithAttributes][58].)                                                                                                           
![Public Extension Method]                | [SetAttributeValue(String, String, String, String)][113]                       | Overloaded. Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created. (Defined by [ObjectWithAttributes][58].)                                                                                                                                                   
![Public Extension Method]                | [SetAttributeValue(String, Double, Double, String, String)][114]               | Overloaded. Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created. Sets the AttributeDataType to xs:double (Defined by [ObjectWithAttributes][58].)                                                                                                           
![Public Extension Method]                | [SetAttributeValue(String, String, String, String, String, String)][115]       | Overloaded. Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created. (Defined by [ObjectWithAttributes][58].)                                                                                                                                                   


See Also
--------

#### Reference
[Aml.Engine.AmlObjects Namespace][6]  
[Aml.Engine.CAEX.CAEXObject][5]  
[Aml.Engine.CAEX.IObjectWithAttributes][1]  

[1]: ../../Aml.Engine.CAEX/IObjectWithAttributes/README.md
[2]: https://docs.microsoft.com/dotnet/api/system.object
[3]: ../../Aml.Engine.CAEX/CAEXWrapper/README.md
[4]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[5]: ../../Aml.Engine.CAEX/CAEXObject/README.md
[6]: ../README.md
[7]: _ctor.md
[8]: ../../Aml.Engine.CAEX/CAEXBasicObject/AdditionalInformation.md
[9]: Attribute.md
[10]: AttributeAndDescendants.md
[11]: CAEXBase.md
[12]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXDocument.md
[13]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXParent.md
[14]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXSequenceOfCAEXObject.md
[15]: ../../Aml.Engine.CAEX/CAEXBasicObject/ChangeMode.md
[16]: ../../Aml.Engine.CAEX/CAEXBasicObject/Copyright.md
[17]: ../../Aml.Engine.CAEX/CAEXBasicObject/CopyrightElement.md
[18]: ../../Aml.Engine.CAEX/CAEXBasicObject/Description.md
[19]: ../../Aml.Engine.CAEX/CAEXBasicObject/DescriptionElement.md
[20]: ../../Aml.Engine.CAEX/CAEXWrapper/Document.md
[21]: ../../Aml.Engine.CAEX/CAEXWrapper/Exists.md
[22]: FrameAttribute.md
[23]: ../../Aml.Engine.CAEX/IObjectWithAttributes/Attribute.md
[24]: ../../Aml.Engine.CAEX/CAEXObject/ID.md
[25]: ../../Aml.Engine.CAEX/CAEXObject/Name.md
[26]: ../../Aml.Engine.CAEX/CAEXWrapper/Node.md
[27]: ../../Aml.Engine.CAEX/CAEXWrapper/Owner.md
[28]: RefTypeAttribute.md
[29]: RefURIAttribute.md
[30]: ../../Aml.Engine.CAEX/CAEXBasicObject/Revision.md
[31]: ../../Aml.Engine.CAEX/CAEXBasicObject/SourceObjectInformation.md
[32]: ../../Aml.Engine.CAEX/CAEXWrapper/TagName.md
[33]: ../../Aml.Engine.CAEX/CAEXBasicObject/Version.md
[34]: ../../Aml.Engine.CAEX/CAEXBasicObject/VersionElement.md
[35]: ../../Aml.Engine.CAEX/CAEXObject/AssignNewGuidAsID.md
[36]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXChild.md
[37]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXChildren.md
[38]: ../../Aml.Engine.CAEX/CAEXObject/CAEXPath.md
[39]: ../../Aml.Engine.CAEX.Extensions/CAEXPathBuilder/README.md
[40]: ../../Aml.Engine.CAEX/CAEXBasicObject/CAEXSequence.md
[41]: ../../Aml.Engine.CAEX/CAEXBasicObject/Container__1.md
[42]: ../../Aml.Engine.CAEX/CAEXObject/Copy.md
[43]: ../../Aml.Engine.CAEX/CAEXWrapper/Equals.md
[44]: ../../Aml.Engine.CAEX/CAEXWrapper/GetHashCode.md
[45]: ../../Aml.Engine.CAEX/CAEXWrapper/GetXAttributeValue.md
[46]: ../../Aml.Engine.CAEX/CAEXBasicObject/Insert_1.md
[47]: ../../Aml.Engine.CAEX/CAEXBasicObject/Insert.md
[48]: ../../Aml.Engine.CAEX/CAEXWrapper/InsertNew.md
[49]: New_FrameAttribute.md
[50]: New_RefUriAttribute.md
[51]: ../../Aml.Engine.CAEX/CAEXBasicObject/New_Revision.md
[52]: ../../Aml.Engine.CAEX/CAEXWrapper/Remove.md
[53]: ../../Aml.Engine.CAEX/CAEXWrapper/SetXAttributeValue.md
[54]: ../../Aml.Engine.CAEX/CAEXObject/ToString.md
[55]: ../../Aml.Engine.CAEX/CAEXWrapper/PropertyChanged.md
[56]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/AddAttributeTypeReference_1.md
[57]: ../../Aml.Engine.CAEX/AttributeType/README.md
[58]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/README.md
[59]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/AddAttributeTypeReference.md
[60]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/AMLAttributes.md
[61]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[62]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/AMLSchemaManager.md
[63]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[64]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Ancestors__1.md
[65]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Attributes.md
[66]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[67]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXDocument.md
[68]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXFile.md
[69]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXSchema.md
[70]: ../../Aml.Engine.Adapter/AMLEngineAdapter/clone.md
[71]: ../../Aml.Engine.CAEX/CAEXWrapper/Copy.md
[72]: ../../Aml.Engine.Adapter/AMLEngineAdapter/CloneNode.md
[73]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ConsistencyCheck_ClassReference.md
[74]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/Copy.md
[75]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/README.md
[76]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/CopyAttributesFrom.md
[77]: ../ListAttribute/CreateListAttribute.md
[78]: ../ListAttribute/README.md
[79]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[80]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[81]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[82]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[83]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[84]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[85]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[86]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[87]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[88]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/FrameAttribute.md
[89]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/GetAttribute.md
[90]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getAttributeField.md
[91]: ../../Aml.Engine.Adapter/AMLEngineAdapter/GetAttributeValue.md
[92]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/GetParent__1.md
[93]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedClass.md
[94]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedGUID.md
[95]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceClass.md
[96]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceName.md
[97]: ../../Aml.Engine.CAEX.Extensions/SystemUnitClassTypeExtensions/Insert_Attribute.md
[98]: ../../Aml.Engine.CAEX.Extensions/SystemUnitClassTypeExtensions/README.md
[99]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_Element.md
[100]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_NewInstance.md
[101]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_TypeBaseElement.md
[102]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsAMLObject.md
[103]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Library.md
[104]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Name.md
[105]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[106]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/New_Attribute.md
[107]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[108]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/New_FrameAttribute.md
[109]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/RefTypeAttribute.md
[110]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/RefURIAttribute.md
[111]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/SetAttributeValue_2.md
[112]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/SetAttributeValue.md
[113]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/SetAttributeValue_3.md
[114]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/SetAttributeValue_1.md
[115]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/SetAttributeValue_4.md
[116]: https://www.automationml.org
[117]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"
[Code example]: ../../icons/CodeExample.png "Code example"