AutomationMLBaseAttributeTypeLibType Class
==========================================
This Class is a wrapper for the AutomationML standard 'AutomationMLBaseAttributeTypeLib' which is the container for a hierarchy of standard AttributeType definitions.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.CAEXWrapper][2]  
    [Aml.Engine.CAEX.CAEXBasicObject][3]  
      [Aml.Engine.CAEX.CAEXObject][4]  
        [Aml.Engine.CAEX.CAEXLibrary][5]&lt;[AttributeFamilyType][6]>  
          [Aml.Engine.AmlObjects.AMLLibraryType][7]&lt;[AttributeFamilyType][6]>  
            **Aml.Engine.AmlObjects.AutomationMLBaseAttributeTypeLibType**  

  **Namespace:**  [Aml.Engine.AmlObjects][8]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class AutomationMLBaseAttributeTypeLibType : AMLLibraryType<AttributeFamilyType>
```

The **AutomationMLBaseAttributeTypeLibType** type exposes the following members.


Properties
----------

                   | Name                           | Description                                                                                                                                                                                                             
------------------ | ------------------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AdditionalInformation][9]     | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                                  
![Public property] | [AssociatedExternalValue][10]  | **Obsolete.**The standard attribute type AssociatedExternalValue has been renamed to AssociatedValue                                                                                                                    
![Public property] | [AssociatedFacet][11]          | Gets the AssociatedFacet.                                                                                                                                                                                               
![Public property] | [AssociatedValue][12]          | Gets the AssociatedValue Attribute Type.                                                                                                                                                                                
![Public property] | [CAEXDocument][13]             | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][2].)                     
![Public property] | [CAEXParent][14]               | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][2].)                                                                                                                                   
![Public property] | [CAEXSequenceOfCAEXObject][15] | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                    
![Public property] | [Cardinality][16]              | Gets the Cardinality attribute type.                                                                                                                                                                                    
![Public property] | [Category][17]                 | Gets the Category Attribute Type                                                                                                                                                                                        
![Public property] | [ChangeMode][18]               | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [CAEXBasicObject][3].)                                                                                                             
![Public property] | [Copyright][19]                | Gets and sets the Copyright for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                     
![Public property] | [CopyrightElement][20]         | Gets the wrapper for the Copyright element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                      
![Public property] | [Description][21]              | Gets and sets the Description for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                   
![Public property] | [DescriptionElement][22]       | Gets the wrapper for the Description element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                    
![Public property] | [Direction][23]                | Gets the Direction Attribute Type.                                                                                                                                                                                      
![Public property] | [Document][24]                 | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                        
![Public property] | [Exists][25]                   | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                       
![Public property] | [ID][26]                       | Gets and sets a unique identifier of the CAEX object (optional in CAEX). AutomationML requires IDs for some Elements. These IDs are automatically set when such elements are created. (Inherited from [CAEXObject][4].) 
![Public property] | [ListType][27]                 | Gets the ListType Attribute type                                                                                                                                                                                        
![Public property] | [LocalizedAttribute][28]       | Gets the LocalizedAttribute attribute type.                                                                                                                                                                             
![Public property] | [MIMEType][29]                 | Gets the MIMEType attribute type.                                                                                                                                                                                       
![Public property] | [Name][30]                     | Gets and sets the name of the CAEX object (required in CAEX). (Inherited from [CAEXObject][4].)                                                                                                                         
![Public property] | [Node][31]                     | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                                         
![Public property] | [OrderedListType][32]          | Gets the OrderedListType attribute type.                                                                                                                                                                                
![Public property] | [Owner][33]                    | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][2].)                                                                                                                                                
![Public property] | [RefURI][34]                   | Gets the RefURI attribute Type.                                                                                                                                                                                         
![Public property] | [Revision][35]                 | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                                              
![Public property] | [SourceObjectInformation][36]  | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                               
![Public property] | [TagName][37]                  | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][2].)                                                                                                                                  
![Public property] | [Version][38]                  | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                       
![Public property] | [VersionElement][39]           | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                        


Methods
-------

                                 | Name                               | Description                                                                                                                                                                                                                                                                                                                                                                                                                                      
-------------------------------- | ---------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public method]                 | [AssignNewGuidAsID][40]            | Assigns the new unique identifier as a new ID to this CAEX object. (Inherited from [CAEXObject][4].)                                                                                                                                                                                                                                                                                                                                             
![Public method]![Static member] | [AttributeTypeLib][41]             | Gets the AutomationMLBaseAttributeTypeLib from the provided document. If the document doesn't contain the required library it will be automatically imported from an external resource.                                                                                                                                                                                                                                                          
![Public method]                 | [AutomationMLClass][42]            | Gets the AutomationML class from this library, which can be identified by the provided CAEX path. (Inherited from [AMLLibraryType&lt;T>][7].)                                                                                                                                                                                                                                                                                                    
![Public method]                 | [CAEXChild][43]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                      
![Public method]                 | [CAEXChildren][44]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                         
![Public method]                 | [CAEXPath][45]                     | Gets the CAEX path for this object. A path can be used to uniquely reference an object, for example in inheritances and instances. The path syntax for an object is defined differently in CAEX 2.15 and CAEX 3.0. The engine uses the [CAEXPathBuilder][46] to generate the CAEX path of an object according to the documents CAEX version. (Inherited from [CAEXObject][4].)                                                                   
![Public method]                 | [CAEXSequence][47]                 | Gets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects [Revision][35] is returned. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                       
![Public method]                 | [Container&lt;T>][48]              | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                                                                                                        
![Public method]                 | [Copy][49]                         | Creates a copy of this CAEX object, containing all child elements. The created copy will have replaced unique IDs and updated references, if the *assignNewIDs* is set to true (default). When a CAEX class is copied, the nested classes that can exist for AttributeType, RoleClass, SystemUnitClass, and InterfaceClass could be included in the created copy, if the *includeSubClasses* is set to `true`. (Inherited from [CAEXObject][4].) 
![Public method]                 | [CopyAndChangeReferences][50]      | Creates a copy of the library and assigns the provided name to the copy. Including references to objects in the original library are redirected to objects in the copied library. (Inherited from [CAEXLibrary&lt;TLibItem>][5].)                                                                                                                                                                                                                
![Public method]                 | [Equals][51]                       | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                    
![Public method]                 | [GetEnumerator][52]                | Gets the enumerator to iterate through the collection of library objects. (Inherited from [CAEXLibrary&lt;TLibItem>][5].)                                                                                                                                                                                                                                                                                                                        
![Public method]                 | [GetHashCode][53]                  | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                          
![Public method]                 | [GetXAttributeValue][54]           | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                             
![Public method]                 | [Insert(Int32, CAEXWrapper)][55]   | Inserts the specified CAEX object in it's associated sequence at the defined position. The CAEXBasicObject defines the [Revision][35] and [SourceObjectInformation][36] sequences. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                        
![Public method]                 | [Insert(CAEXWrapper, Boolean)][56] | Inserts the specified CAEX object in it's associated sequence. The CAEXBasicObject defines the [Revision][35] and [SourceObjectInformation][36] sequences. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                                
![Public method]                 | [InsertAfter][57]                  | Inserts the provided CAEX object as a new sibling after this CAEX object. (Inherited from [CAEXLibrary&lt;TLibItem>][5].)                                                                                                                                                                                                                                                                                                                        
![Public method]                 | [InsertBefore][58]                 | Inserts the provided CAEX object as a new sibling before this CAEX object. (Inherited from [CAEXLibrary&lt;TLibItem>][5].)                                                                                                                                                                                                                                                                                                                       
![Public method]                 | [InsertNew][59]                    | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][33] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                 
![Public method]![Static member] | [IsLoaded][60]                     | Determines if the AutomationMLBaseAttributeTypeLib exists in the document.                                                                                                                                                                                                                                                                                                                                                                       
![Public method]                 | [New_Revision][61]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][35] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][3].)                                                                                                                                          
![Public method]                 | [Remove][62]                       | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                             
![Public method]                 | [SetXAttributeValue][63]           | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                            
![Public method]                 | [ToString][64]                     | Returns the value of the 'Name' attribute of this CAEX object as the string representation of the object. (Inherited from [CAEXObject][4].)                                                                                                                                                                                                                                                                                                      


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][65] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][2].) 


Extension Methods
-----------------

                           | Name                                  | Description                                                                                                                                                                                                                                                       
-------------------------- | ------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [clone][66]                           | [Copy(Boolean, Boolean, Boolean)][67] (Defined by [AMLEngineAdapter][68].)                                                                                                                                                                                        
![Public Extension Method] | [CloneNode][69]                       | Clones the node. (Defined by [AMLEngineAdapter][68].)                                                                                                                                                                                                             
![Public Extension Method] | [ConsistencyCheck_ClassReference][70] | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][68].)                                                                                                                                           
![Public Extension Method] | [Copy][71]                            | Copies the CAEX object and assigns the name to the created copy. (Defined by [CAEXObjectExtensions][72].)                                                                                                                                                         
![Public Extension Method] | [Descendants(Type)][73]               | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][74].)                                                                                                                          
![Public Extension Method] | [Descendants&lt;T>()][75]             | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][74].)                                                                                                                          
![Public Extension Method] | [findInternalElement][76]             | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][68].)                                                                                                                                        
![Public Extension Method] | [getReferencedClass][77]              | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][68].)                                                                                                                                                                                       
![Public Extension Method] | [getReferencedGUID][78]               | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][68].)                                                                                                                                                               
![Public Extension Method] | [getReferencedInterfaceClass][79]     | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][68].)                                                                                                                                             
![Public Extension Method] | [getReferencedInterfaceName][80]      | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][68].)                                                                                                                                                                                
![Public Extension Method] | [Insert_Element][81]                  | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][68].)                                       
![Public Extension Method] | [Insert_NewInstance][82]              | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][68].) 
![Public Extension Method] | [Insert_TypeBaseElement][83]          | [Insert(CAEXWrapper, Boolean)][56] (Defined by [AMLEngineAdapter][68].)                                                                                                                                                                                           
![Public Extension Method] | [Name()][84]                          | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][68].)                                                                                                                                                                            
![Public Extension Method] | [Name()][85]                          | Overloaded. Gets a names for the specified CAEX wrapper object. If the specified object is a [CAEXObject][4], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][74].)                                         
![Public Extension Method] | [New_Description][86]                 | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][74].)                                                                                                                                                   


Explicit Interface Implementations
----------------------------------

                                                      | Name                            | Description                                                                                                               
----------------------------------------------------- | ------------------------------- | ------------------------------------------------------------------------------------------------------------------------- 
![Explicit interface implementation]![Private method] | [IEnumerable.GetEnumerator][87] | Gets the enumerator to iterate through the collection of library objects. (Inherited from [CAEXLibrary&lt;TLibItem>][5].) 


Remarks
-------
Not available for CAEX version 2.15

See Also
--------

#### Reference
[Aml.Engine.AmlObjects Namespace][8]  
[Aml.Engine.AmlObjects.AMLLibraryType&lt;T>][7]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../../Aml.Engine.CAEX/CAEXWrapper/README.md
[3]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[4]: ../../Aml.Engine.CAEX/CAEXObject/README.md
[5]: ../../Aml.Engine.CAEX/CAEXLibrary_1/README.md
[6]: ../../Aml.Engine.CAEX/AttributeFamilyType/README.md
[7]: ../AMLLibraryType_1/README.md
[8]: ../README.md
[9]: ../../Aml.Engine.CAEX/CAEXBasicObject/AdditionalInformation.md
[10]: AssociatedExternalValue.md
[11]: AssociatedFacet.md
[12]: AssociatedValue.md
[13]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXDocument.md
[14]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXParent.md
[15]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXSequenceOfCAEXObject.md
[16]: Cardinality.md
[17]: Category.md
[18]: ../../Aml.Engine.CAEX/CAEXBasicObject/ChangeMode.md
[19]: ../../Aml.Engine.CAEX/CAEXBasicObject/Copyright.md
[20]: ../../Aml.Engine.CAEX/CAEXBasicObject/CopyrightElement.md
[21]: ../../Aml.Engine.CAEX/CAEXBasicObject/Description.md
[22]: ../../Aml.Engine.CAEX/CAEXBasicObject/DescriptionElement.md
[23]: Direction.md
[24]: ../../Aml.Engine.CAEX/CAEXWrapper/Document.md
[25]: ../../Aml.Engine.CAEX/CAEXWrapper/Exists.md
[26]: ../../Aml.Engine.CAEX/CAEXObject/ID.md
[27]: ListType.md
[28]: LocalizedAttribute.md
[29]: MIMEType.md
[30]: ../../Aml.Engine.CAEX/CAEXObject/Name.md
[31]: ../../Aml.Engine.CAEX/CAEXWrapper/Node.md
[32]: OrderedListType.md
[33]: ../../Aml.Engine.CAEX/CAEXWrapper/Owner.md
[34]: RefURI.md
[35]: ../../Aml.Engine.CAEX/CAEXBasicObject/Revision.md
[36]: ../../Aml.Engine.CAEX/CAEXBasicObject/SourceObjectInformation.md
[37]: ../../Aml.Engine.CAEX/CAEXWrapper/TagName.md
[38]: ../../Aml.Engine.CAEX/CAEXBasicObject/Version.md
[39]: ../../Aml.Engine.CAEX/CAEXBasicObject/VersionElement.md
[40]: ../../Aml.Engine.CAEX/CAEXObject/AssignNewGuidAsID.md
[41]: AttributeTypeLib.md
[42]: ../AMLLibraryType_1/AutomationMLClass.md
[43]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXChild.md
[44]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXChildren.md
[45]: ../../Aml.Engine.CAEX/CAEXObject/CAEXPath.md
[46]: ../../Aml.Engine.CAEX.Extensions/CAEXPathBuilder/README.md
[47]: ../../Aml.Engine.CAEX/CAEXBasicObject/CAEXSequence.md
[48]: ../../Aml.Engine.CAEX/CAEXBasicObject/Container__1.md
[49]: ../../Aml.Engine.CAEX/CAEXObject/Copy.md
[50]: ../../Aml.Engine.CAEX/CAEXLibrary_1/CopyAndChangeReferences.md
[51]: ../../Aml.Engine.CAEX/CAEXWrapper/Equals.md
[52]: ../../Aml.Engine.CAEX/CAEXLibrary_1/GetEnumerator.md
[53]: ../../Aml.Engine.CAEX/CAEXWrapper/GetHashCode.md
[54]: ../../Aml.Engine.CAEX/CAEXWrapper/GetXAttributeValue.md
[55]: ../../Aml.Engine.CAEX/CAEXBasicObject/Insert_1.md
[56]: ../../Aml.Engine.CAEX/CAEXBasicObject/Insert.md
[57]: ../../Aml.Engine.CAEX/CAEXLibrary_1/InsertAfter.md
[58]: ../../Aml.Engine.CAEX/CAEXLibrary_1/InsertBefore.md
[59]: ../../Aml.Engine.CAEX/CAEXWrapper/InsertNew.md
[60]: IsLoaded.md
[61]: ../../Aml.Engine.CAEX/CAEXBasicObject/New_Revision.md
[62]: ../../Aml.Engine.CAEX/CAEXWrapper/Remove.md
[63]: ../../Aml.Engine.CAEX/CAEXWrapper/SetXAttributeValue.md
[64]: ../../Aml.Engine.CAEX/CAEXObject/ToString.md
[65]: ../../Aml.Engine.CAEX/CAEXWrapper/PropertyChanged.md
[66]: ../../Aml.Engine.Adapter/AMLEngineAdapter/clone.md
[67]: ../../Aml.Engine.CAEX/CAEXWrapper/Copy.md
[68]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[69]: ../../Aml.Engine.Adapter/AMLEngineAdapter/CloneNode.md
[70]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ConsistencyCheck_ClassReference.md
[71]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/Copy.md
[72]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/README.md
[73]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[74]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[75]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[76]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[77]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedClass.md
[78]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedGUID.md
[79]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceClass.md
[80]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceName.md
[81]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_Element.md
[82]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_NewInstance.md
[83]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_TypeBaseElement.md
[84]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Name.md
[85]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[86]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[87]: ../../Aml.Engine.CAEX/CAEXLibrary_1/System_Collections_IEnumerable_GetEnumerator.md
[88]: https://www.automationml.org
[89]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"
[Explicit interface implementation]: ../../icons/pubinterface.gif "Explicit interface implementation"
[Private method]: ../../icons/privmethod.gif "Private method"