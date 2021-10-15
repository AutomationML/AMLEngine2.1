AutomationMLBaseRoleClassLibType Class
======================================
This Class is a wrapper for the AutomationML standard 'AutomationMLBaseRoleClassLib' which is the container for a hierarchy of standard RoleClass definitions.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.CAEXWrapper][2]  
    [Aml.Engine.CAEX.CAEXBasicObject][3]  
      [Aml.Engine.CAEX.CAEXObject][4]  
        [Aml.Engine.CAEX.CAEXLibrary][5]&lt;[RoleFamilyType][6]>  
          [Aml.Engine.AmlObjects.AMLLibraryType][7]&lt;[RoleFamilyType][6]>  
            **Aml.Engine.AmlObjects.AutomationMLBaseRoleClassLibType**  

  **Namespace:**  [Aml.Engine.AmlObjects][8]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class AutomationMLBaseRoleClassLibType : AMLLibraryType<RoleFamilyType>
```

The **AutomationMLBaseRoleClassLibType** type exposes the following members.


Properties
----------

                   | Name                           | Description                                                                                                                                                                                                             
------------------ | ------------------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AdditionalInformation][9]     | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                                  
![Public property] | [AutomationMLBaseRole][10]     | Gets the automation ml base role.                                                                                                                                                                                       
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
![Public property] | [Facet][21]                    | Gets the facet.                                                                                                                                                                                                         
![Public property] | [Frame][22]                    | Gets the frame.                                                                                                                                                                                                         
![Public property] | [Group][23]                    | Gets the group.                                                                                                                                                                                                         
![Public property] | [ID][24]                       | Gets and sets a unique identifier of the CAEX object (optional in CAEX). AutomationML requires IDs for some Elements. These IDs are automatically set when such elements are created. (Inherited from [CAEXObject][4].) 
![Public property] | [InterlockingSourceGroup][25]  | Gets the interlocking source group.                                                                                                                                                                                     
![Public property] | [InterlockingTargetGroup][26]  | Gets the interlocking target group.                                                                                                                                                                                     
![Public property] | [LogicObject][27]              | Gets the logic object.                                                                                                                                                                                                  
![Public property] | [Name][28]                     | Gets and sets the name of the CAEX object (required in CAEX). (Inherited from [CAEXObject][4].)                                                                                                                         
![Public property] | [Node][29]                     | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                                         
![Public property] | [Owner][30]                    | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][2].)                                                                                                                                                
![Public property] | [Port][31]                     | Gets the port.                                                                                                                                                                                                          
![Public property] | [Process][32]                  | Gets the process.                                                                                                                                                                                                       
![Public property] | [ProcessStructure][33]         | Gets the process structure.                                                                                                                                                                                             
![Public property] | [Product][34]                  | Gets the product.                                                                                                                                                                                                       
![Public property] | [ProductStructure][35]         | Gets the product structure.                                                                                                                                                                                             
![Public property] | [PropertySet][36]              | Gets the property set.                                                                                                                                                                                                  
![Public property] | [Resource][37]                 | Gets the resource.                                                                                                                                                                                                      
![Public property] | [ResourceStructure][38]        | Gets the resource structure.                                                                                                                                                                                            
![Public property] | [Revision][39]                 | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                                              
![Public property] | [SourceObjectInformation][40]  | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                               
![Public property] | [Structure][41]                | Gets the structure.                                                                                                                                                                                                     
![Public property] | [TagName][42]                  | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][2].)                                                                                                                                  
![Public property] | [Version][43]                  | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                       
![Public property] | [VersionElement][44]           | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                        


Methods
-------

                                 | Name                               | Description                                                                                                                                                                                                                                                                                                                                                                                                                                      
-------------------------------- | ---------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public method]                 | [AssignNewGuidAsID][45]            | Assigns the new unique identifier as a new ID to this CAEX object. (Inherited from [CAEXObject][4].)                                                                                                                                                                                                                                                                                                                                             
![Public method]                 | [AutomationMLClass][46]            | Gets the AutomationML class from this library, which can be identified by the provided CAEX path. (Inherited from [AMLLibraryType&lt;T>][7].)                                                                                                                                                                                                                                                                                                    
![Public method]                 | [CAEXChild][47]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                      
![Public method]                 | [CAEXChildren][48]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                         
![Public method]                 | [CAEXPath][49]                     | Gets the CAEX path for this object. A path can be used to uniquely reference an object, for example in inheritances and instances. The path syntax for an object is defined differently in CAEX 2.15 and CAEX 3.0. The engine uses the [CAEXPathBuilder][50] to generate the CAEX path of an object according to the documents CAEX version. (Inherited from [CAEXObject][4].)                                                                   
![Public method]                 | [CAEXSequence][51]                 | Gets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects [Revision][39] is returned. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                       
![Public method]                 | [Container&lt;T>][52]              | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                                                                                                        
![Public method]                 | [Copy][53]                         | Creates a copy of this CAEX object, containing all child elements. The created copy will have replaced unique IDs and updated references, if the *assignNewIDs* is set to true (default). When a CAEX class is copied, the nested classes that can exist for AttributeType, RoleClass, SystemUnitClass, and InterfaceClass could be included in the created copy, if the *includeSubClasses* is set to `true`. (Inherited from [CAEXObject][4].) 
![Public method]                 | [CopyAndChangeReferences][54]      | Creates a copy of the library and assigns the provided name to the copy. Including references to objects in the original library are redirected to objects in the copied library. (Inherited from [CAEXLibrary&lt;TLibItem>][5].)                                                                                                                                                                                                                
![Public method]                 | [Equals][55]                       | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                    
![Public method]                 | [GetEnumerator][56]                | Gets the enumerator to iterate through the collection of library objects. (Inherited from [CAEXLibrary&lt;TLibItem>][5].)                                                                                                                                                                                                                                                                                                                        
![Public method]                 | [GetHashCode][57]                  | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                          
![Public method]                 | [GetXAttributeValue][58]           | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                             
![Public method]                 | [Insert(Int32, CAEXWrapper)][59]   | Inserts the specified CAEX object in it's associated sequence at the defined position. The CAEXBasicObject defines the [Revision][39] and [SourceObjectInformation][40] sequences. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                        
![Public method]                 | [Insert(CAEXWrapper, Boolean)][60] | Inserts the specified CAEX object in it's associated sequence. The CAEXBasicObject defines the [Revision][39] and [SourceObjectInformation][40] sequences. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                                
![Public method]                 | [InsertAfter][61]                  | Inserts the provided CAEX object as a new sibling after this CAEX object. (Inherited from [CAEXLibrary&lt;TLibItem>][5].)                                                                                                                                                                                                                                                                                                                        
![Public method]                 | [InsertBefore][62]                 | Inserts the provided CAEX object as a new sibling before this CAEX object. (Inherited from [CAEXLibrary&lt;TLibItem>][5].)                                                                                                                                                                                                                                                                                                                       
![Public method]                 | [InsertNew][63]                    | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][30] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                 
![Public method]![Static member] | [IsLoaded][64]                     | Determines if the AutomationMLBaseRoleClassLib exists in the document.                                                                                                                                                                                                                                                                                                                                                                           
![Public method]                 | [New_Revision][65]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][39] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][3].)                                                                                                                                          
![Public method]                 | [Remove][66]                       | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                             
![Public method]![Static member] | [RoleClassLib][67]                 | Gets the AutomationMLBaseRoleClassLib from the provided document. If the document doesn't contain the required library it will be automatically imported from an external resource.                                                                                                                                                                                                                                                              
![Public method]                 | [SetXAttributeValue][68]           | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                            
![Public method]                 | [ToString][69]                     | Returns the value of the 'Name' attribute of this CAEX object as the string representation of the object. (Inherited from [CAEXObject][4].)                                                                                                                                                                                                                                                                                                      


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][70] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][2].) 


Extension Methods
-----------------

                           | Name                                  | Description                                                                                                                                                                                                                                                       
-------------------------- | ------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [clone][71]                           | [Copy(Boolean, Boolean, Boolean)][72] (Defined by [AMLEngineAdapter][73].)                                                                                                                                                                                        
![Public Extension Method] | [CloneNode][74]                       | Clones the node. (Defined by [AMLEngineAdapter][73].)                                                                                                                                                                                                             
![Public Extension Method] | [ConsistencyCheck_ClassReference][75] | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][73].)                                                                                                                                           
![Public Extension Method] | [Copy][76]                            | Copies the CAEX object and assigns the name to the created copy. (Defined by [CAEXObjectExtensions][77].)                                                                                                                                                         
![Public Extension Method] | [Descendants(Type)][78]               | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][79].)                                                                                                                          
![Public Extension Method] | [Descendants&lt;T>()][80]             | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][79].)                                                                                                                          
![Public Extension Method] | [findInternalElement][81]             | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][73].)                                                                                                                                        
![Public Extension Method] | [getReferencedClass][82]              | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][73].)                                                                                                                                                                                       
![Public Extension Method] | [getReferencedGUID][83]               | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][73].)                                                                                                                                                               
![Public Extension Method] | [getReferencedInterfaceClass][84]     | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][73].)                                                                                                                                             
![Public Extension Method] | [getReferencedInterfaceName][85]      | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][73].)                                                                                                                                                                                
![Public Extension Method] | [Insert_Element][86]                  | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][73].)                                       
![Public Extension Method] | [Insert_NewInstance][87]              | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][73].) 
![Public Extension Method] | [Insert_TypeBaseElement][88]          | [Insert(CAEXWrapper, Boolean)][60] (Defined by [AMLEngineAdapter][73].)                                                                                                                                                                                           
![Public Extension Method] | [Name()][89]                          | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][73].)                                                                                                                                                                            
![Public Extension Method] | [Name()][90]                          | Overloaded. Gets a names for the specified CAEX wrapper object. If the specified object is a [CAEXObject][4], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][79].)                                         
![Public Extension Method] | [New_Description][91]                 | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][79].)                                                                                                                                                   


Explicit Interface Implementations
----------------------------------

                                                      | Name                            | Description                                                                                                               
----------------------------------------------------- | ------------------------------- | ------------------------------------------------------------------------------------------------------------------------- 
![Explicit interface implementation]![Private method] | [IEnumerable.GetEnumerator][92] | Gets the enumerator to iterate through the collection of library objects. (Inherited from [CAEXLibrary&lt;TLibItem>][5].) 


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
[6]: ../../Aml.Engine.CAEX/RoleFamilyType/README.md
[7]: ../AMLLibraryType_1/README.md
[8]: ../README.md
[9]: ../../Aml.Engine.CAEX/CAEXBasicObject/AdditionalInformation.md
[10]: AutomationMLBaseRole.md
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
[21]: Facet.md
[22]: Frame.md
[23]: Group.md
[24]: ../../Aml.Engine.CAEX/CAEXObject/ID.md
[25]: InterlockingSourceGroup.md
[26]: InterlockingTargetGroup.md
[27]: LogicObject.md
[28]: ../../Aml.Engine.CAEX/CAEXObject/Name.md
[29]: ../../Aml.Engine.CAEX/CAEXWrapper/Node.md
[30]: ../../Aml.Engine.CAEX/CAEXWrapper/Owner.md
[31]: Port.md
[32]: Process.md
[33]: ProcessStructure.md
[34]: Product.md
[35]: ProductStructure.md
[36]: PropertySet.md
[37]: Resource.md
[38]: ResourceStructure.md
[39]: ../../Aml.Engine.CAEX/CAEXBasicObject/Revision.md
[40]: ../../Aml.Engine.CAEX/CAEXBasicObject/SourceObjectInformation.md
[41]: Structure.md
[42]: ../../Aml.Engine.CAEX/CAEXWrapper/TagName.md
[43]: ../../Aml.Engine.CAEX/CAEXBasicObject/Version.md
[44]: ../../Aml.Engine.CAEX/CAEXBasicObject/VersionElement.md
[45]: ../../Aml.Engine.CAEX/CAEXObject/AssignNewGuidAsID.md
[46]: ../AMLLibraryType_1/AutomationMLClass.md
[47]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXChild.md
[48]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXChildren.md
[49]: ../../Aml.Engine.CAEX/CAEXObject/CAEXPath.md
[50]: ../../Aml.Engine.CAEX.Extensions/CAEXPathBuilder/README.md
[51]: ../../Aml.Engine.CAEX/CAEXBasicObject/CAEXSequence.md
[52]: ../../Aml.Engine.CAEX/CAEXBasicObject/Container__1.md
[53]: ../../Aml.Engine.CAEX/CAEXObject/Copy.md
[54]: ../../Aml.Engine.CAEX/CAEXLibrary_1/CopyAndChangeReferences.md
[55]: ../../Aml.Engine.CAEX/CAEXWrapper/Equals.md
[56]: ../../Aml.Engine.CAEX/CAEXLibrary_1/GetEnumerator.md
[57]: ../../Aml.Engine.CAEX/CAEXWrapper/GetHashCode.md
[58]: ../../Aml.Engine.CAEX/CAEXWrapper/GetXAttributeValue.md
[59]: ../../Aml.Engine.CAEX/CAEXBasicObject/Insert_1.md
[60]: ../../Aml.Engine.CAEX/CAEXBasicObject/Insert.md
[61]: ../../Aml.Engine.CAEX/CAEXLibrary_1/InsertAfter.md
[62]: ../../Aml.Engine.CAEX/CAEXLibrary_1/InsertBefore.md
[63]: ../../Aml.Engine.CAEX/CAEXWrapper/InsertNew.md
[64]: IsLoaded.md
[65]: ../../Aml.Engine.CAEX/CAEXBasicObject/New_Revision.md
[66]: ../../Aml.Engine.CAEX/CAEXWrapper/Remove.md
[67]: RoleClassLib.md
[68]: ../../Aml.Engine.CAEX/CAEXWrapper/SetXAttributeValue.md
[69]: ../../Aml.Engine.CAEX/CAEXObject/ToString.md
[70]: ../../Aml.Engine.CAEX/CAEXWrapper/PropertyChanged.md
[71]: ../../Aml.Engine.Adapter/AMLEngineAdapter/clone.md
[72]: ../../Aml.Engine.CAEX/CAEXWrapper/Copy.md
[73]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[74]: ../../Aml.Engine.Adapter/AMLEngineAdapter/CloneNode.md
[75]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ConsistencyCheck_ClassReference.md
[76]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/Copy.md
[77]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/README.md
[78]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[79]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[80]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[81]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[82]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedClass.md
[83]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedGUID.md
[84]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceClass.md
[85]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceName.md
[86]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_Element.md
[87]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_NewInstance.md
[88]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_TypeBaseElement.md
[89]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Name.md
[90]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[91]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[92]: ../../Aml.Engine.CAEX/CAEXLibrary_1/System_Collections_IEnumerable_GetEnumerator.md
[93]: https://www.automationml.org
[94]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"
[Explicit interface implementation]: ../../icons/pubinterface.gif "Explicit interface implementation"
[Private method]: ../../icons/privmethod.gif "Private method"