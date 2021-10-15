AttributeTypeLibType Class
==========================
This Class is a wrapper for the CAEX element 'AttributeTypeLib' which is a container for a hierarchy of AttributeType elements. CAEX supports multiple AttributeType libraries associated to a CAEXFile ([CAEXFileType][1]).


Inheritance Hierarchy
---------------------
[System.Object][2]  
  [Aml.Engine.CAEX.CAEXWrapper][3]  
    [Aml.Engine.CAEX.CAEXBasicObject][4]  
      [Aml.Engine.CAEX.CAEXObject][5]  
        [Aml.Engine.CAEX.CAEXLibrary][6]&lt;[AttributeFamilyType][7]>  
          **Aml.Engine.CAEX.AttributeTypeLibType**  

  **Namespace:**  [Aml.Engine.CAEX][8]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class AttributeTypeLibType : CAEXLibrary<AttributeFamilyType>
```

The **AttributeTypeLibType** type exposes the following members.


Constructors
------------

                 | Name                      | Description                                                       
---------------- | ------------------------- | ----------------------------------------------------------------- 
![Public method] | [AttributeTypeLibType][9] | Initializes a new instance of the **AttributeTypeLibType** class. 


Properties
----------

                   | Name                           | Description                                                                                                                                                                                                             
------------------ | ------------------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AdditionalInformation][10]    | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [CAEXBasicObject][4].)                                                                                                  
![Public property] | [AttributeType][11]            | Gets the collection of AttributeType objects contained in this AttributeTypeLib element.                                                                                                                                
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
![Public property] | [ID][22]                       | Gets and sets a unique identifier of the CAEX object (optional in CAEX). AutomationML requires IDs for some Elements. These IDs are automatically set when such elements are created. (Inherited from [CAEXObject][5].) 
![Public property] | [Name][23]                     | Gets and sets the name of the CAEX object (required in CAEX). (Inherited from [CAEXObject][5].)                                                                                                                         
![Public property] | [Node][24]                     | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][3].)                                                                                                                                                         
![Public property] | [Owner][25]                    | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][3].)                                                                                                                                                
![Public property] | [Revision][26]                 | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][4].)                                                                                                              
![Public property] | [SourceObjectInformation][27]  | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][4].)                                                                                               
![Public property] | [TagName][28]                  | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][3].)                                                                                                                                  
![Public property] | [Version][29]                  | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][4].)                                                                                                                                       
![Public property] | [VersionElement][30]           | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][4].)                                                                                                                                        


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                                                                                                                                                                                      
---------------- | ---------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public method] | [AssignNewGuidAsID][31]            | Assigns the new unique identifier as a new ID to this CAEX object. (Inherited from [CAEXObject][5].)                                                                                                                                                                                                                                                                                                                                             
![Public method] | [CAEXChild][32]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                                                                      
![Public method] | [CAEXChildren][33]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                                                                         
![Public method] | [CAEXPath][34]                     | Gets the CAEX path for this object. A path can be used to uniquely reference an object, for example in inheritances and instances. The path syntax for an object is defined differently in CAEX 2.15 and CAEX 3.0. The engine uses the [CAEXPathBuilder][35] to generate the CAEX path of an object according to the documents CAEX version. (Inherited from [CAEXObject][5].)                                                                   
![Public method] | [CAEXSequence][36]                 | Gets the CAEXSequence owned by this CAEX object, which contains the specified CAEX object. (Overrides [CAEXBasicObject.CAEXSequence(ICAEXWrapper)][37].)                                                                                                                                                                                                                                                                                         
![Public method] | [Container&lt;T>][38]              | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Inherited from [CAEXBasicObject][4].)                                                                                                                                                                                                                                                                                                                        
![Public method] | [Copy][39]                         | Creates a copy of this CAEX object, containing all child elements. The created copy will have replaced unique IDs and updated references, if the *assignNewIDs* is set to true (default). When a CAEX class is copied, the nested classes that can exist for AttributeType, RoleClass, SystemUnitClass, and InterfaceClass could be included in the created copy, if the *includeSubClasses* is set to `true`. (Inherited from [CAEXObject][5].) 
![Public method] | [CopyAndChangeReferences][40]      | Creates a copy of the library and assigns the provided name to the copy. Including references to objects in the original library are redirected to objects in the copied library. (Inherited from [CAEXLibrary&lt;TLibItem>][6].)                                                                                                                                                                                                                
![Public method] | [Equals][41]                       | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                                                    
![Public method] | [GetEnumerator][42]                | Gets the enumerator to iterate through the collection of library objects. (Inherited from [CAEXLibrary&lt;TLibItem>][6].)                                                                                                                                                                                                                                                                                                                        
![Public method] | [GetHashCode][43]                  | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                                                                          
![Public method] | [GetXAttributeValue][44]           | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                                             
![Public method] | [Insert(Int32, CAEXWrapper)][45]   | Inserts the specified CAEX object in it's associated sequence at the given index. (Overrides [CAEXBasicObject.Insert(Int32, CAEXWrapper)][46].)                                                                                                                                                                                                                                                                                                  
![Public method] | [Insert(CAEXWrapper, Boolean)][47] | Inserts the specified CAEX object in it's associated sequence. (Overrides [CAEXBasicObject.Insert(CAEXWrapper, Boolean)][48].)                                                                                                                                                                                                                                                                                                                   
![Public method] | [InsertAfter][49]                  | Inserts the provided CAEX object as a new sibling after this CAEX object. (Inherited from [CAEXLibrary&lt;TLibItem>][6].)                                                                                                                                                                                                                                                                                                                        
![Public method] | [InsertBefore][50]                 | Inserts the provided CAEX object as a new sibling before this CAEX object. (Inherited from [CAEXLibrary&lt;TLibItem>][6].)                                                                                                                                                                                                                                                                                                                       
![Public method] | [InsertNew][51]                    | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][25] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                 
![Public method] | [New_Revision][52]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][26] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][4].)                                                                                                                                          
![Public method] | [Remove][53]                       | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                                             
![Public method] | [SetXAttributeValue][54]           | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                                            
![Public method] | [ToString][55]                     | Returns the value of the 'Name' attribute of this CAEX object as the string representation of the object. (Inherited from [CAEXObject][5].)                                                                                                                                                                                                                                                                                                      


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][56] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][3].) 


Extension Methods
-----------------

                           | Name                                  | Description                                                                                                                                                                                                                                                       
-------------------------- | ------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [clone][57]                           | [Copy(Boolean, Boolean, Boolean)][58] (Defined by [AMLEngineAdapter][59].)                                                                                                                                                                                        
![Public Extension Method] | [CloneNode][60]                       | Clones the node. (Defined by [AMLEngineAdapter][59].)                                                                                                                                                                                                             
![Public Extension Method] | [ConsistencyCheck_ClassReference][61] | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][59].)                                                                                                                                           
![Public Extension Method] | [Copy][62]                            | Copies the CAEX object and assigns the name to the created copy. (Defined by [CAEXObjectExtensions][63].)                                                                                                                                                         
![Public Extension Method] | [Descendants(Type)][64]               | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][65].)                                                                                                                          
![Public Extension Method] | [Descendants&lt;T>()][66]             | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][65].)                                                                                                                          
![Public Extension Method] | [findInternalElement][67]             | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][59].)                                                                                                                                        
![Public Extension Method] | [getReferencedClass][68]              | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][59].)                                                                                                                                                                                       
![Public Extension Method] | [getReferencedGUID][69]               | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][59].)                                                                                                                                                               
![Public Extension Method] | [getReferencedInterfaceClass][70]     | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][59].)                                                                                                                                             
![Public Extension Method] | [getReferencedInterfaceName][71]      | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][59].)                                                                                                                                                                                
![Public Extension Method] | [Insert_Element][72]                  | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][59].)                                       
![Public Extension Method] | [Insert_NewInstance][73]              | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][59].) 
![Public Extension Method] | [Insert_TypeBaseElement][74]          | [Insert(CAEXWrapper, Boolean)][48] (Defined by [AMLEngineAdapter][59].)                                                                                                                                                                                           
![Public Extension Method] | [Name()][75]                          | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][59].)                                                                                                                                                                            
![Public Extension Method] | [Name()][76]                          | Overloaded. Gets a names for the specified CAEX wrapper object. If the specified object is a [CAEXObject][5], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][65].)                                         
![Public Extension Method] | [New_Description][77]                 | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][65].)                                                                                                                                                   


Explicit Interface Implementations
----------------------------------

                                                      | Name                            | Description                                                                                                               
----------------------------------------------------- | ------------------------------- | ------------------------------------------------------------------------------------------------------------------------- 
![Explicit interface implementation]![Private method] | [IEnumerable.GetEnumerator][78] | Gets the enumerator to iterate through the collection of library objects. (Inherited from [CAEXLibrary&lt;TLibItem>][6].) 


Remarks
-------
 This class was introduced with CAEX Version 3.0 and can only be used with CAEX documents, based on Version 3.0. 

See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][8]  
[Aml.Engine.CAEX.CAEXLibrary&lt;TLibItem>][6]  

[1]: ../CAEXFileType/README.md
[2]: https://docs.microsoft.com/dotnet/api/system.object
[3]: ../CAEXWrapper/README.md
[4]: ../CAEXBasicObject/README.md
[5]: ../CAEXObject/README.md
[6]: ../CAEXLibrary_1/README.md
[7]: ../AttributeFamilyType/README.md
[8]: ../README.md
[9]: _ctor.md
[10]: ../CAEXBasicObject/AdditionalInformation.md
[11]: AttributeType.md
[12]: ../CAEXWrapper/CAEXDocument.md
[13]: ../CAEXWrapper/CAEXParent.md
[14]: ../CAEXWrapper/CAEXSequenceOfCAEXObject.md
[15]: ../CAEXBasicObject/ChangeMode.md
[16]: ../CAEXBasicObject/Copyright.md
[17]: ../CAEXBasicObject/CopyrightElement.md
[18]: ../CAEXBasicObject/Description.md
[19]: ../CAEXBasicObject/DescriptionElement.md
[20]: ../CAEXWrapper/Document.md
[21]: ../CAEXWrapper/Exists.md
[22]: ../CAEXObject/ID.md
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
[40]: ../CAEXLibrary_1/CopyAndChangeReferences.md
[41]: ../CAEXWrapper/Equals.md
[42]: ../CAEXLibrary_1/GetEnumerator.md
[43]: ../CAEXWrapper/GetHashCode.md
[44]: ../CAEXWrapper/GetXAttributeValue.md
[45]: Insert_1.md
[46]: ../CAEXBasicObject/Insert_1.md
[47]: Insert.md
[48]: ../CAEXBasicObject/Insert.md
[49]: ../CAEXLibrary_1/InsertAfter.md
[50]: ../CAEXLibrary_1/InsertBefore.md
[51]: ../CAEXWrapper/InsertNew.md
[52]: ../CAEXBasicObject/New_Revision.md
[53]: ../CAEXWrapper/Remove.md
[54]: ../CAEXWrapper/SetXAttributeValue.md
[55]: ../CAEXObject/ToString.md
[56]: ../CAEXWrapper/PropertyChanged.md
[57]: ../../Aml.Engine.Adapter/AMLEngineAdapter/clone.md
[58]: ../CAEXWrapper/Copy.md
[59]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[60]: ../../Aml.Engine.Adapter/AMLEngineAdapter/CloneNode.md
[61]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ConsistencyCheck_ClassReference.md
[62]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/Copy.md
[63]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/README.md
[64]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[65]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[66]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[67]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[68]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedClass.md
[69]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedGUID.md
[70]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceClass.md
[71]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceName.md
[72]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_Element.md
[73]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_NewInstance.md
[74]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_TypeBaseElement.md
[75]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Name.md
[76]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[77]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[78]: ../CAEXLibrary_1/System_Collections_IEnumerable_GetEnumerator.md
[79]: https://www.automationml.org
[80]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"
[Explicit interface implementation]: ../../icons/pubinterface.gif "Explicit interface implementation"
[Private method]: ../../icons/privmethod.gif "Private method"