RoleClassLibType Class
======================
AutomationML 2.1 APIThis Class is a wrapper for the CAEXElement 'RoleClassLib' which is a Container element for a hierarchy of Role class definitions wrapped into [RoleFamilyType][1]. CAEX supports multiple role class libraries.


Inheritance Hierarchy
---------------------
[System.Object][2]  
  [Aml.Engine.CAEX.CAEXWrapper][3]  
    [Aml.Engine.CAEX.CAEXBasicObject][4]  
      [Aml.Engine.CAEX.CAEXObject][5]  
        [Aml.Engine.CAEX.CAEXLibrary][6]&lt;[RoleFamilyType][1]>  
          **Aml.Engine.CAEX.RoleClassLibType**  

  **Namespace:**  [Aml.Engine.CAEX][7]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class RoleClassLibType : CAEXLibrary<RoleFamilyType>
```

The **RoleClassLibType** type exposes the following members.


Constructors
------------

                 | Name                  | Description                                                   
---------------- | --------------------- | ------------------------------------------------------------- 
![Public method] | [RoleClassLibType][8] | Initializes a new instance of the **RoleClassLibType** class. 


Properties
----------

                   | Name                           | Description                                                                                                                                                                                                             
------------------ | ------------------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AdditionalInformation][9]     | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [CAEXBasicObject][4].)                                                                                                  
![Public property] | [CAEXDocument][10]             | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][3].)                     
![Public property] | [CAEXParent][11]               | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][3].)                                                                                                                                   
![Public property] | [CAEXSequenceOfCAEXObject][12] | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][3].)                                                                                                                                    
![Public property] | [ChangeMode][13]               | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [CAEXBasicObject][4].)                                                                                                             
![Public property] | [Copyright][14]                | Gets and sets the Copyright for this object. (Inherited from [CAEXBasicObject][4].)                                                                                                                                     
![Public property] | [CopyrightElement][15]         | Gets the wrapper for the Copyright element. (Inherited from [CAEXBasicObject][4].)                                                                                                                                      
![Public property] | [Description][16]              | Gets and sets the Description for this object. (Inherited from [CAEXBasicObject][4].)                                                                                                                                   
![Public property] | [DescriptionElement][17]       | Gets the wrapper for the Description element. (Inherited from [CAEXBasicObject][4].)                                                                                                                                    
![Public property] | [Document][18]                 | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][3].)                                                                                                                                        
![Public property] | [Exists][19]                   | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][3].)                                                                                                                       
![Public property] | [ID][20]                       | Gets and sets a unique identifier of the CAEX object (optional in CAEX). AutomationML requires IDs for some Elements. These IDs are automatically set when such elements are created. (Inherited from [CAEXObject][5].) 
![Public property] | [Name][21]                     | Gets and sets the name of the CAEX object (required in CAEX). (Inherited from [CAEXObject][5].)                                                                                                                         
![Public property] | [Node][22]                     | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][3].)                                                                                                                                                         
![Public property] | [Owner][23]                    | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][3].)                                                                                                                                                
![Public property] | [Revision][24]                 | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][4].)                                                                                                              
![Public property] | [RoleClass][25]                | Gets the collection of RoleClass objects contained in this library.                                                                                                                                                     
![Public property] | [SourceObjectInformation][26]  | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][4].)                                                                                               
![Public property] | [TagName][27]                  | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][3].)                                                                                                                                  
![Public property] | [Version][28]                  | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][4].)                                                                                                                                       
![Public property] | [VersionElement][29]           | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][4].)                                                                                                                                        


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                                                                                                                                             
---------------- | ---------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [AssignNewGuidAsID][30]            | Assigns the new unique identifier as a new ID to this CAEX object. (Inherited from [CAEXObject][5].)                                                                                                                                                                                                                                                                                                    
![Public method] | [CAEXChild][31]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                             
![Public method] | [CAEXChildren][32]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                                
![Public method] | [CAEXPath][33]                     | Gets the CAEX path for this object. A path can be used to uniquely reference an object, for example in inheritances and instances. The path syntax for an object is defined differently in CAEX 2.15 and CAEX 3.0. The engine uses the [CAEXPathBuilder][34] to generate the CAEX path of an object according to the documents CAEX version. (Inherited from [CAEXObject][5].)                          
![Public method] | [CAEXSequence][35]                 | Gets the CAEXSequence owned by this CAEX object, which contains the specified CAEX object. (Overrides [CAEXBasicObject.CAEXSequence(ICAEXWrapper)][36].)                                                                                                                                                                                                                                                
![Public method] | [Container&lt;T>][37]              | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Inherited from [CAEXBasicObject][4].)                                                                                                                                                                                                                                                                               
![Public method] | [Copy][38]                         | Creates a deep copy of this CAEX object, containing all child elements. The created copy will have replaced unique IDs and updated references, if the *assignNewIDs* is set to true (default). When a CAEX class is copied, the nested classes that can exist for AttributeType, RoleClass, SystemUnitClass, and InterfaceClass are not included in the created copy. (Inherited from [CAEXObject][5].) 
![Public method] | [Equals][39]                       | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                           
![Public method] | [GetEnumerator][40]                | Gets the enumerator to iterate through the collection of library objects. (Inherited from [CAEXLibrary&lt;TLibItem>][6].)                                                                                                                                                                                                                                                                               
![Public method] | [GetHashCode][41]                  | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                                 
![Public method] | [GetXAttributeValue][42]           | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                    
![Public method] | [Insert(Int32, CAEXWrapper)][43]   | Inserts the specified CAEX object in it's associated sequence at the given position. The RoleClassLibType defines the [RoleClass][25] sequence. (Overrides [CAEXBasicObject.Insert(Int32, CAEXWrapper)][44].)                                                                                                                                                                                           
![Public method] | [Insert(CAEXWrapper, Boolean)][45] | Inserts the specified CAEX object in it's associated sequence. The RoleClassLibType defines the [RoleClass][25] sequence. (Overrides [CAEXBasicObject.Insert(CAEXWrapper, Boolean)][46].)                                                                                                                                                                                                               
![Public method] | [InsertAfter][47]                  | Inserts the provided CAEX object as a new sibling after this CAEX object. (Inherited from [CAEXLibrary&lt;TLibItem>][6].)                                                                                                                                                                                                                                                                               
![Public method] | [InsertBefore][48]                 | Inserts the provided CAEX object as a new sibling before this CAEX object. (Inherited from [CAEXLibrary&lt;TLibItem>][6].)                                                                                                                                                                                                                                                                              
![Public method] | [InsertNew][49]                    | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][23] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][3].)                                                                                                                        
![Public method] | [New_Revision][50]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][24] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][4].)                                                                                                 
![Public method] | [Remove][51]                       | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                    
![Public method] | [SetXAttributeValue][52]           | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                   
![Public method] | [ToString][53]                     | Returns the value of the 'Name' attribute of this CAEX object as the string representation of the object. (Inherited from [CAEXObject][5].)                                                                                                                                                                                                                                                             


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][54] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][3].) 


Extension Methods
-----------------

                           | Name                                  | Description                                                                                                                                                                                                                                                       
-------------------------- | ------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [clone][55]                           | [Copy(Boolean, Boolean, Boolean)][56] (Defined by [AMLEngineAdapter][57].)                                                                                                                                                                                        
![Public Extension Method] | [CloneNode][58]                       | Clones the node. (Defined by [AMLEngineAdapter][57].)                                                                                                                                                                                                             
![Public Extension Method] | [ConsistencyCheck_ClassReference][59] | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][57].)                                                                                                                                           
![Public Extension Method] | [Descendants(Type)][60]               | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][61].)                                                                                                                          
![Public Extension Method] | [Descendants&lt;T>()][62]             | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][61].)                                                                                                                          
![Public Extension Method] | [ExternalDataRoleClass][63]           | Gets the 'ExternalData' RoleClass from the AutomationMLBPRRoleClassLib. (Defined by [ExternalDataReference][64].)                                                                                                                                                 
![Public Extension Method] | [findInternalElement][65]             | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][57].)                                                                                                                                        
![Public Extension Method] | [getReferencedClass][66]              | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][57].)                                                                                                                                                                                       
![Public Extension Method] | [getReferencedGUID][67]               | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][57].)                                                                                                                                                               
![Public Extension Method] | [getReferencedInterfaceClass][68]     | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][57].)                                                                                                                                             
![Public Extension Method] | [getReferencedInterfaceName][69]      | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][57].)                                                                                                                                                                                
![Public Extension Method] | [Insert_Element][70]                  | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][57].)                                       
![Public Extension Method] | [Insert_NewInstance][71]              | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][57].) 
![Public Extension Method] | [Insert_RoleClass][72]                | Inserts the provided RoleClass into this RoleClass library. (Defined by [RoleClassLibTypeExtensions][73].)                                                                                                                                                        
![Public Extension Method] | [Insert_TypeBaseElement][74]          | [Insert(CAEXWrapper, Boolean)][46] (Defined by [AMLEngineAdapter][57].)                                                                                                                                                                                           
![Public Extension Method] | [Name()][75]                          | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][57].)                                                                                                                                                                            
![Public Extension Method] | [Name()][76]                          | Overloaded. Gets a names for the specified caex wrapper object. If the specified object is a [CAEXObject][5], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][61].)                                         
![Public Extension Method] | [New_Description][77]                 | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][61].)                                                                                                                                                   
![Public Extension Method] | [New_RoleClass][78]                   | Adding a new RoleClass to this RoleClassLib. (Defined by [RoleClassLibTypeExtensions][73].)                                                                                                                                                                       
![Public Extension Method] | [RoleClassDescendants][79]            | Gets all descendant [RoleFamilyType][1] Objects in the RoleClassLib. RoleClasss on all levels are returned. (Defined by [RoleClassLibTypeExtensions][73].)                                                                                                        


Explicit Interface Implementations
----------------------------------

                                                      | Name                            | Description                                                                                                               
----------------------------------------------------- | ------------------------------- | ------------------------------------------------------------------------------------------------------------------------- 
![Explicit interface implementation]![Private method] | [IEnumerable.GetEnumerator][80] | Gets the enumerator to iterate through the collection of library objects. (Inherited from [CAEXLibrary&lt;TLibItem>][6].) 


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][7]  
[Aml.Engine.CAEX.CAEXLibrary&lt;TLibItem>][6]  

[1]: ../RoleFamilyType/README.md
[2]: https://docs.microsoft.com/dotnet/api/system.object
[3]: ../CAEXWrapper/README.md
[4]: ../CAEXBasicObject/README.md
[5]: ../CAEXObject/README.md
[6]: ../CAEXLibrary_1/README.md
[7]: ../README.md
[8]: _ctor.md
[9]: ../CAEXBasicObject/AdditionalInformation.md
[10]: ../CAEXWrapper/CAEXDocument.md
[11]: ../CAEXWrapper/CAEXParent.md
[12]: ../CAEXWrapper/CAEXSequenceOfCAEXObject.md
[13]: ../CAEXBasicObject/ChangeMode.md
[14]: ../CAEXBasicObject/Copyright.md
[15]: ../CAEXBasicObject/CopyrightElement.md
[16]: ../CAEXBasicObject/Description.md
[17]: ../CAEXBasicObject/DescriptionElement.md
[18]: ../CAEXWrapper/Document.md
[19]: ../CAEXWrapper/Exists.md
[20]: ../CAEXObject/ID.md
[21]: ../CAEXObject/Name.md
[22]: ../CAEXWrapper/Node.md
[23]: ../CAEXWrapper/Owner.md
[24]: ../CAEXBasicObject/Revision.md
[25]: RoleClass.md
[26]: ../CAEXBasicObject/SourceObjectInformation.md
[27]: ../CAEXWrapper/TagName.md
[28]: ../CAEXBasicObject/Version.md
[29]: ../CAEXBasicObject/VersionElement.md
[30]: ../CAEXObject/AssignNewGuidAsID.md
[31]: ../CAEXWrapper/CAEXChild.md
[32]: ../CAEXWrapper/CAEXChildren.md
[33]: ../CAEXObject/CAEXPath.md
[34]: ../../Aml.Engine.CAEX.Extensions/CAEXPathBuilder/README.md
[35]: CAEXSequence.md
[36]: ../CAEXBasicObject/CAEXSequence.md
[37]: ../CAEXBasicObject/Container__1.md
[38]: ../CAEXObject/Copy.md
[39]: ../CAEXWrapper/Equals.md
[40]: ../CAEXLibrary_1/GetEnumerator.md
[41]: ../CAEXWrapper/GetHashCode.md
[42]: ../CAEXWrapper/GetXAttributeValue.md
[43]: Insert_1.md
[44]: ../CAEXBasicObject/Insert_1.md
[45]: Insert.md
[46]: ../CAEXBasicObject/Insert.md
[47]: ../CAEXLibrary_1/InsertAfter.md
[48]: ../CAEXLibrary_1/InsertBefore.md
[49]: ../CAEXWrapper/InsertNew.md
[50]: ../CAEXBasicObject/New_Revision.md
[51]: ../CAEXWrapper/Remove.md
[52]: ../CAEXWrapper/SetXAttributeValue.md
[53]: ../CAEXObject/ToString.md
[54]: ../CAEXWrapper/PropertyChanged.md
[55]: ../../Aml.Engine.Adapter/AMLEngineAdapter/clone.md
[56]: ../CAEXWrapper/Copy.md
[57]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[58]: ../../Aml.Engine.Adapter/AMLEngineAdapter/CloneNode.md
[59]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ConsistencyCheck_ClassReference.md
[60]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[61]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[62]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[63]: ../../Aml.Engine.AmlObjects/ExternalDataReference/ExternalDataRoleClass_1.md
[64]: ../../Aml.Engine.AmlObjects/ExternalDataReference/README.md
[65]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[66]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedClass.md
[67]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedGUID.md
[68]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceClass.md
[69]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceName.md
[70]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_Element.md
[71]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_NewInstance.md
[72]: ../../Aml.Engine.CAEX.Extensions/RoleClassLibTypeExtensions/Insert_RoleClass.md
[73]: ../../Aml.Engine.CAEX.Extensions/RoleClassLibTypeExtensions/README.md
[74]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_TypeBaseElement.md
[75]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Name.md
[76]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[77]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[78]: ../../Aml.Engine.CAEX.Extensions/RoleClassLibTypeExtensions/New_RoleClass.md
[79]: ../../Aml.Engine.CAEX.Extensions/RoleClassLibTypeExtensions/RoleClassDescendants.md
[80]: ../CAEXLibrary_1/System_Collections_IEnumerable_GetEnumerator.md
[81]: https://www.automationml.org
[82]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"
[Explicit interface implementation]: ../../icons/pubinterface.gif "Explicit interface implementation"
[Private method]: ../../icons/privmethod.gif "Private method"