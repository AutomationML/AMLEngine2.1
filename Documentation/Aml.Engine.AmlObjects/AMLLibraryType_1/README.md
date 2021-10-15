AMLLibraryType&lt;T> Class
==========================
This class is a generic type definition for CAEX libraries, which are defined by AutomationML and contain standardized classes.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.CAEXWrapper][2]  
    [Aml.Engine.CAEX.CAEXBasicObject][3]  
      [Aml.Engine.CAEX.CAEXObject][4]  
        [Aml.Engine.CAEX.CAEXLibrary][5]&lt;**T**>  
          **Aml.Engine.AmlObjects.AMLLibraryType&lt;T>**  
            [Aml.Engine.AmlObjects.AutomationMLBaseAttributeTypeLibType][6]  
            [Aml.Engine.AmlObjects.AutomationMLBaseRoleClassLibType][7]  
            [Aml.Engine.AmlObjects.AutomationMLInterfaceClassLibType][8]  

  **Namespace:**  [Aml.Engine.AmlObjects][9]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class AMLLibraryType<T> : CAEXLibrary<T>
where T : CAEXObject

```

#### Type Parameters

##### *T*
Type of the library items.

The **AMLLibraryType&lt;T>** type exposes the following members.


Properties
----------

                   | Name                           | Description                                                                                                                                                                                                             
------------------ | ------------------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AdditionalInformation][10]    | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                                  
![Public property] | [CAEXDocument][11]             | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][2].)                     
![Public property] | [CAEXParent][12]               | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][2].)                                                                                                                                   
![Public property] | [CAEXSequenceOfCAEXObject][13] | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                    
![Public property] | [ChangeMode][14]               | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [CAEXBasicObject][3].)                                                                                                             
![Public property] | [Copyright][15]                | Gets and sets the Copyright for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                     
![Public property] | [CopyrightElement][16]         | Gets the wrapper for the Copyright element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                      
![Public property] | [Description][17]              | Gets and sets the Description for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                   
![Public property] | [DescriptionElement][18]       | Gets the wrapper for the Description element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                    
![Public property] | [Document][19]                 | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                        
![Public property] | [Exists][20]                   | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                       
![Public property] | [ID][21]                       | Gets and sets a unique identifier of the CAEX object (optional in CAEX). AutomationML requires IDs for some Elements. These IDs are automatically set when such elements are created. (Inherited from [CAEXObject][4].) 
![Public property] | [Name][22]                     | Gets and sets the name of the CAEX object (required in CAEX). (Inherited from [CAEXObject][4].)                                                                                                                         
![Public property] | [Node][23]                     | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                                         
![Public property] | [Owner][24]                    | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][2].)                                                                                                                                                
![Public property] | [Revision][25]                 | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                                              
![Public property] | [SourceObjectInformation][26]  | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                               
![Public property] | [TagName][27]                  | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][2].)                                                                                                                                  
![Public property] | [Version][28]                  | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                       
![Public property] | [VersionElement][29]           | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                        


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                                                                                                                                                                                      
---------------- | ---------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public method] | [AssignNewGuidAsID][30]            | Assigns the new unique identifier as a new ID to this CAEX object. (Inherited from [CAEXObject][4].)                                                                                                                                                                                                                                                                                                                                             
![Public method] | [AutomationMLClass][31]            | Gets the AutomationML class from this library, which can be identified by the provided CAEX path.                                                                                                                                                                                                                                                                                                                                                
![Public method] | [CAEXChild][32]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                      
![Public method] | [CAEXChildren][33]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                         
![Public method] | [CAEXPath][34]                     | Gets the CAEX path for this object. A path can be used to uniquely reference an object, for example in inheritances and instances. The path syntax for an object is defined differently in CAEX 2.15 and CAEX 3.0. The engine uses the [CAEXPathBuilder][35] to generate the CAEX path of an object according to the documents CAEX version. (Inherited from [CAEXObject][4].)                                                                   
![Public method] | [CAEXSequence][36]                 | Gets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects [Revision][25] is returned. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                       
![Public method] | [Container&lt;T>][37]              | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                                                                                                        
![Public method] | [Copy][38]                         | Creates a copy of this CAEX object, containing all child elements. The created copy will have replaced unique IDs and updated references, if the *assignNewIDs* is set to true (default). When a CAEX class is copied, the nested classes that can exist for AttributeType, RoleClass, SystemUnitClass, and InterfaceClass could be included in the created copy, if the *includeSubClasses* is set to `true`. (Inherited from [CAEXObject][4].) 
![Public method] | [CopyAndChangeReferences][39]      | Creates a copy of the library and assigns the provided name to the copy. Including references to objects in the original library are redirected to objects in the copied library. (Inherited from [CAEXLibrary&lt;TLibItem>][5].)                                                                                                                                                                                                                
![Public method] | [Equals][40]                       | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                    
![Public method] | [GetEnumerator][41]                | Gets the enumerator to iterate through the collection of library objects. (Inherited from [CAEXLibrary&lt;TLibItem>][5].)                                                                                                                                                                                                                                                                                                                        
![Public method] | [GetHashCode][42]                  | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                          
![Public method] | [GetXAttributeValue][43]           | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                             
![Public method] | [Insert(Int32, CAEXWrapper)][44]   | Inserts the specified CAEX object in it's associated sequence at the defined position. The CAEXBasicObject defines the [Revision][25] and [SourceObjectInformation][26] sequences. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                        
![Public method] | [Insert(CAEXWrapper, Boolean)][45] | Inserts the specified CAEX object in it's associated sequence. The CAEXBasicObject defines the [Revision][25] and [SourceObjectInformation][26] sequences. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                                
![Public method] | [InsertAfter][46]                  | Inserts the provided CAEX object as a new sibling after this CAEX object. (Inherited from [CAEXLibrary&lt;TLibItem>][5].)                                                                                                                                                                                                                                                                                                                        
![Public method] | [InsertBefore][47]                 | Inserts the provided CAEX object as a new sibling before this CAEX object. (Inherited from [CAEXLibrary&lt;TLibItem>][5].)                                                                                                                                                                                                                                                                                                                       
![Public method] | [InsertNew][48]                    | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][24] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                 
![Public method] | [New_Revision][49]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][25] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][3].)                                                                                                                                          
![Public method] | [Remove][50]                       | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                             
![Public method] | [SetXAttributeValue][51]           | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                            
![Public method] | [ToString][52]                     | Returns the value of the 'Name' attribute of this CAEX object as the string representation of the object. (Inherited from [CAEXObject][4].)                                                                                                                                                                                                                                                                                                      


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][53] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][2].) 


Extension Methods
-----------------

                           | Name                                  | Description                                                                                                                                                                                                                                                       
-------------------------- | ------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [clone][54]                           | [Copy(Boolean, Boolean, Boolean)][55] (Defined by [AMLEngineAdapter][56].)                                                                                                                                                                                        
![Public Extension Method] | [CloneNode][57]                       | Clones the node. (Defined by [AMLEngineAdapter][56].)                                                                                                                                                                                                             
![Public Extension Method] | [ConsistencyCheck_ClassReference][58] | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][56].)                                                                                                                                           
![Public Extension Method] | [Copy][59]                            | Copies the CAEX object and assigns the name to the created copy. (Defined by [CAEXObjectExtensions][60].)                                                                                                                                                         
![Public Extension Method] | [Descendants(Type)][61]               | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][62].)                                                                                                                          
![Public Extension Method] | [Descendants&lt;T>()][63]             | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][62].)                                                                                                                          
![Public Extension Method] | [findInternalElement][64]             | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][56].)                                                                                                                                        
![Public Extension Method] | [getReferencedClass][65]              | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][56].)                                                                                                                                                                                       
![Public Extension Method] | [getReferencedGUID][66]               | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][56].)                                                                                                                                                               
![Public Extension Method] | [getReferencedInterfaceClass][67]     | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][56].)                                                                                                                                             
![Public Extension Method] | [getReferencedInterfaceName][68]      | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][56].)                                                                                                                                                                                
![Public Extension Method] | [Insert_Element][69]                  | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][56].)                                       
![Public Extension Method] | [Insert_NewInstance][70]              | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][56].) 
![Public Extension Method] | [Insert_TypeBaseElement][71]          | [Insert(CAEXWrapper, Boolean)][45] (Defined by [AMLEngineAdapter][56].)                                                                                                                                                                                           
![Public Extension Method] | [Name()][72]                          | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][56].)                                                                                                                                                                            
![Public Extension Method] | [Name()][73]                          | Overloaded. Gets a names for the specified CAEX wrapper object. If the specified object is a [CAEXObject][4], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][62].)                                         
![Public Extension Method] | [New_Description][74]                 | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][62].)                                                                                                                                                   


Explicit Interface Implementations
----------------------------------

                                                      | Name                            | Description                                                                                                               
----------------------------------------------------- | ------------------------------- | ------------------------------------------------------------------------------------------------------------------------- 
![Explicit interface implementation]![Private method] | [IEnumerable.GetEnumerator][75] | Gets the enumerator to iterate through the collection of library objects. (Inherited from [CAEXLibrary&lt;TLibItem>][5].) 


See Also
--------

#### Reference
[Aml.Engine.AmlObjects Namespace][9]  
[Aml.Engine.CAEX.CAEXLibrary&lt;TLibItem>][5]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../../Aml.Engine.CAEX/CAEXWrapper/README.md
[3]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[4]: ../../Aml.Engine.CAEX/CAEXObject/README.md
[5]: ../../Aml.Engine.CAEX/CAEXLibrary_1/README.md
[6]: ../AutomationMLBaseAttributeTypeLibType/README.md
[7]: ../AutomationMLBaseRoleClassLibType/README.md
[8]: ../AutomationMLInterfaceClassLibType/README.md
[9]: ../README.md
[10]: ../../Aml.Engine.CAEX/CAEXBasicObject/AdditionalInformation.md
[11]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXDocument.md
[12]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXParent.md
[13]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXSequenceOfCAEXObject.md
[14]: ../../Aml.Engine.CAEX/CAEXBasicObject/ChangeMode.md
[15]: ../../Aml.Engine.CAEX/CAEXBasicObject/Copyright.md
[16]: ../../Aml.Engine.CAEX/CAEXBasicObject/CopyrightElement.md
[17]: ../../Aml.Engine.CAEX/CAEXBasicObject/Description.md
[18]: ../../Aml.Engine.CAEX/CAEXBasicObject/DescriptionElement.md
[19]: ../../Aml.Engine.CAEX/CAEXWrapper/Document.md
[20]: ../../Aml.Engine.CAEX/CAEXWrapper/Exists.md
[21]: ../../Aml.Engine.CAEX/CAEXObject/ID.md
[22]: ../../Aml.Engine.CAEX/CAEXObject/Name.md
[23]: ../../Aml.Engine.CAEX/CAEXWrapper/Node.md
[24]: ../../Aml.Engine.CAEX/CAEXWrapper/Owner.md
[25]: ../../Aml.Engine.CAEX/CAEXBasicObject/Revision.md
[26]: ../../Aml.Engine.CAEX/CAEXBasicObject/SourceObjectInformation.md
[27]: ../../Aml.Engine.CAEX/CAEXWrapper/TagName.md
[28]: ../../Aml.Engine.CAEX/CAEXBasicObject/Version.md
[29]: ../../Aml.Engine.CAEX/CAEXBasicObject/VersionElement.md
[30]: ../../Aml.Engine.CAEX/CAEXObject/AssignNewGuidAsID.md
[31]: AutomationMLClass.md
[32]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXChild.md
[33]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXChildren.md
[34]: ../../Aml.Engine.CAEX/CAEXObject/CAEXPath.md
[35]: ../../Aml.Engine.CAEX.Extensions/CAEXPathBuilder/README.md
[36]: ../../Aml.Engine.CAEX/CAEXBasicObject/CAEXSequence.md
[37]: ../../Aml.Engine.CAEX/CAEXBasicObject/Container__1.md
[38]: ../../Aml.Engine.CAEX/CAEXObject/Copy.md
[39]: ../../Aml.Engine.CAEX/CAEXLibrary_1/CopyAndChangeReferences.md
[40]: ../../Aml.Engine.CAEX/CAEXWrapper/Equals.md
[41]: ../../Aml.Engine.CAEX/CAEXLibrary_1/GetEnumerator.md
[42]: ../../Aml.Engine.CAEX/CAEXWrapper/GetHashCode.md
[43]: ../../Aml.Engine.CAEX/CAEXWrapper/GetXAttributeValue.md
[44]: ../../Aml.Engine.CAEX/CAEXBasicObject/Insert_1.md
[45]: ../../Aml.Engine.CAEX/CAEXBasicObject/Insert.md
[46]: ../../Aml.Engine.CAEX/CAEXLibrary_1/InsertAfter.md
[47]: ../../Aml.Engine.CAEX/CAEXLibrary_1/InsertBefore.md
[48]: ../../Aml.Engine.CAEX/CAEXWrapper/InsertNew.md
[49]: ../../Aml.Engine.CAEX/CAEXBasicObject/New_Revision.md
[50]: ../../Aml.Engine.CAEX/CAEXWrapper/Remove.md
[51]: ../../Aml.Engine.CAEX/CAEXWrapper/SetXAttributeValue.md
[52]: ../../Aml.Engine.CAEX/CAEXObject/ToString.md
[53]: ../../Aml.Engine.CAEX/CAEXWrapper/PropertyChanged.md
[54]: ../../Aml.Engine.Adapter/AMLEngineAdapter/clone.md
[55]: ../../Aml.Engine.CAEX/CAEXWrapper/Copy.md
[56]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[57]: ../../Aml.Engine.Adapter/AMLEngineAdapter/CloneNode.md
[58]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ConsistencyCheck_ClassReference.md
[59]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/Copy.md
[60]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/README.md
[61]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[62]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[63]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[64]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[65]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedClass.md
[66]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedGUID.md
[67]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceClass.md
[68]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceName.md
[69]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_Element.md
[70]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_NewInstance.md
[71]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_TypeBaseElement.md
[72]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Name.md
[73]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[74]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[75]: ../../Aml.Engine.CAEX/CAEXLibrary_1/System_Collections_IEnumerable_GetEnumerator.md
[76]: https://www.automationml.org
[77]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"
[Explicit interface implementation]: ../../icons/pubinterface.gif "Explicit interface implementation"
[Private method]: ../../icons/privmethod.gif "Private method"