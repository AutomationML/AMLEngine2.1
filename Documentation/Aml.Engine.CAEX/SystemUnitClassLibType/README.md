SystemUnitClassLibType Class
============================
This Class is a wrapper for the CAEXElement 'SystemUnitClassLib'.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.CAEXWrapper][2]  
    [Aml.Engine.CAEX.CAEXBasicObject][3]  
      [Aml.Engine.CAEX.CAEXObject][4]  
        [Aml.Engine.CAEX.CAEXLibrary][5]&lt;[SystemUnitFamilyType][6]>  
          **Aml.Engine.CAEX.SystemUnitClassLibType**  

  **Namespace:**  [Aml.Engine.CAEX][7]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class SystemUnitClassLibType : CAEXLibrary<SystemUnitFamilyType>
```

The **SystemUnitClassLibType** type exposes the following members.


Constructors
------------

                 | Name                        | Description                                                         
---------------- | --------------------------- | ------------------------------------------------------------------- 
![Public method] | [SystemUnitClassLibType][8] | Initializes a new instance of the **SystemUnitClassLibType** class. 


Properties
----------

                   | Name                           | Description                                                                                                                                                                                                             
------------------ | ------------------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AdditionalInformation][9]     | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                                  
![Public property] | [CAEXDocument][10]             | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][2].)                     
![Public property] | [CAEXParent][11]               | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][2].)                                                                                                                                   
![Public property] | [CAEXSequenceOfCAEXObject][12] | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                    
![Public property] | [ChangeMode][13]               | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [CAEXBasicObject][3].)                                                                                                             
![Public property] | [Copyright][14]                | Gets and sets the Copyright for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                     
![Public property] | [CopyrightElement][15]         | Gets the wrapper for the Copyright element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                      
![Public property] | [Description][16]              | Gets and sets the Description for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                   
![Public property] | [DescriptionElement][17]       | Gets the wrapper for the Description element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                    
![Public property] | [Document][18]                 | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                        
![Public property] | [Exists][19]                   | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                       
![Public property] | [ID][20]                       | Gets and sets a unique identifier of the CAEX object (optional in CAEX). AutomationML requires IDs for some Elements. These IDs are automatically set when such elements are created. (Inherited from [CAEXObject][4].) 
![Public property] | [Name][21]                     | Gets and sets the name of the CAEX object (required in CAEX). (Inherited from [CAEXObject][4].)                                                                                                                         
![Public property] | [Node][22]                     | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                                         
![Public property] | [Owner][23]                    | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][2].)                                                                                                                                                
![Public property] | [Revision][24]                 | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                                              
![Public property] | [SourceObjectInformation][25]  | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                               
![Public property] | [SystemUnitClass][26]          | Gets a collection of SystemUnitClass objects contained in this instance.                                                                                                                                                
![Public property] | [TagName][27]                  | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][2].)                                                                                                                                  
![Public property] | [Version][28]                  | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                       
![Public property] | [VersionElement][29]           | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                        


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                                                                                                                                             
---------------- | ---------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [AssignNewGuidAsID][30]            | Assigns the new unique identifier as a new ID to this CAEX object. (Inherited from [CAEXObject][4].)                                                                                                                                                                                                                                                                                                    
![Public method] | [CAEXChild][31]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                             
![Public method] | [CAEXChildren][32]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                
![Public method] | [CAEXPath][33]                     | Gets the CAEX path for this object. A path can be used to uniquely reference an object, for example in inheritances and instances. The path syntax for an object is defined differently in CAEX 2.15 and CAEX 3.0. The engine uses the [CAEXPathBuilder][34] to generate the CAEX path of an object according to the documents CAEX version. (Inherited from [CAEXObject][4].)                          
![Public method] | [CAEXSequence][35]                 | Gets the CAEXSequence owned by this CAEX object, which contains the specified CAEX object. (Overrides [CAEXBasicObject.CAEXSequence(ICAEXWrapper)][36].)                                                                                                                                                                                                                                                
![Public method] | [Container&lt;T>][37]              | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                                                               
![Public method] | [Copy][38]                         | Creates a deep copy of this CAEX object, containing all child elements. The created copy will have replaced unique IDs and updated references, if the *assignNewIDs* is set to true (default). When a CAEX class is copied, the nested classes that can exist for AttributeType, RoleClass, SystemUnitClass, and InterfaceClass are not included in the created copy. (Inherited from [CAEXObject][4].) 
![Public method] | [Equals][39]                       | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                           
![Public method] | [GetEnumerator][40]                | Gets the enumerator to iterate through the collection of library objects. (Inherited from [CAEXLibrary&lt;TLibItem>][5].)                                                                                                                                                                                                                                                                               
![Public method] | [GetHashCode][41]                  | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                 
![Public method] | [GetXAttributeValue][42]           | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                    
![Public method] | [Insert(Int32, CAEXWrapper)][43]   | Inserts the specified CAEX object in it's associated sequence. The SystemUnitClassLibType defines the [SystemUnitClass][26] sequence. (Overrides [CAEXBasicObject.Insert(Int32, CAEXWrapper)][44].)                                                                                                                                                                                                     
![Public method] | [Insert(CAEXWrapper, Boolean)][45] | Inserts the specified CAEX object in it's associated sequence. The SystemUnitClassLibType defines the [SystemUnitClass][26] sequence. (Overrides [CAEXBasicObject.Insert(CAEXWrapper, Boolean)][46].)                                                                                                                                                                                                   
![Public method] | [InsertAfter][47]                  | Inserts the provided CAEX object as a new sibling after this CAEX object. (Inherited from [CAEXLibrary&lt;TLibItem>][5].)                                                                                                                                                                                                                                                                               
![Public method] | [InsertBefore][48]                 | Inserts the provided CAEX object as a new sibling before this CAEX object. (Inherited from [CAEXLibrary&lt;TLibItem>][5].)                                                                                                                                                                                                                                                                              
![Public method] | [InsertNew][49]                    | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][23] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][2].)                                                                                                                        
![Public method] | [New_Revision][50]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][24] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][3].)                                                                                                 
![Public method] | [Remove][51]                       | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                    
![Public method] | [SetXAttributeValue][52]           | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                   
![Public method] | [ToString][53]                     | Returns the value of the 'Name' attribute of this CAEX object as the string representation of the object. (Inherited from [CAEXObject][4].)                                                                                                                                                                                                                                                             


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][54] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][2].) 


Extension Methods
-----------------

                           | Name                                  | Description                                                                                                                                                                                                                                                       
-------------------------- | ------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [clone][55]                           | [Copy(Boolean, Boolean, Boolean)][56] (Defined by [AMLEngineAdapter][57].)                                                                                                                                                                                        
![Public Extension Method] | [CloneNode][58]                       | Clones the node. (Defined by [AMLEngineAdapter][57].)                                                                                                                                                                                                             
![Public Extension Method] | [ConsistencyCheck_ClassReference][59] | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][57].)                                                                                                                                           
![Public Extension Method] | [Descendants(Type)][60]               | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][61].)                                                                                                                          
![Public Extension Method] | [Descendants&lt;T>()][62]             | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][61].)                                                                                                                          
![Public Extension Method] | [findInternalElement][63]             | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][57].)                                                                                                                                        
![Public Extension Method] | [getReferencedClass][64]              | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][57].)                                                                                                                                                                                       
![Public Extension Method] | [getReferencedGUID][65]               | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][57].)                                                                                                                                                               
![Public Extension Method] | [getReferencedInterfaceClass][66]     | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][57].)                                                                                                                                             
![Public Extension Method] | [getReferencedInterfaceName][67]      | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][57].)                                                                                                                                                                                
![Public Extension Method] | [Insert_Element][68]                  | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][57].)                                       
![Public Extension Method] | [Insert_NewInstance][69]              | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][57].) 
![Public Extension Method] | [Insert_SystemUnitClass][70]          | Inserts the provided SystemUnitClass into this SystemUnitClass library. (Defined by [SystemUnitClassLibTypeExtensions][71].)                                                                                                                                      
![Public Extension Method] | [Insert_TypeBaseElement][72]          | [Insert(CAEXWrapper, Boolean)][46] (Defined by [AMLEngineAdapter][57].)                                                                                                                                                                                           
![Public Extension Method] | [Name()][73]                          | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][57].)                                                                                                                                                                            
![Public Extension Method] | [Name()][74]                          | Overloaded. Gets a names for the specified caex wrapper object. If the specified object is a [CAEXObject][4], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][61].)                                         
![Public Extension Method] | [New_Description][75]                 | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][61].)                                                                                                                                                   
![Public Extension Method] | [New_SystemUnitClass][76]             | Adding a new SystemUnitClass to this SystemUnitClassLib. (Defined by [SystemUnitClassLibTypeExtensions][71].)                                                                                                                                                     
![Public Extension Method] | [SystemUnitClassDescendants][77]      | Gets all descendant [SystemUnitFamilyType][6] Objects in the SystemUnitClassLib. SystemUnitClasss on all levels are returned. (Defined by [SystemUnitClassLibTypeExtensions][71].)                                                                                


Explicit Interface Implementations
----------------------------------

                                                      | Name                            | Description                                                                                                               
----------------------------------------------------- | ------------------------------- | ------------------------------------------------------------------------------------------------------------------------- 
![Explicit interface implementation]![Private method] | [IEnumerable.GetEnumerator][78] | Gets the enumerator to iterate through the collection of library objects. (Inherited from [CAEXLibrary&lt;TLibItem>][5].) 


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][7]  
[Aml.Engine.CAEX.CAEXLibrary&lt;TLibItem>][5]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../CAEXWrapper/README.md
[3]: ../CAEXBasicObject/README.md
[4]: ../CAEXObject/README.md
[5]: ../CAEXLibrary_1/README.md
[6]: ../SystemUnitFamilyType/README.md
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
[25]: ../CAEXBasicObject/SourceObjectInformation.md
[26]: SystemUnitClass.md
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
[63]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[64]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedClass.md
[65]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedGUID.md
[66]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceClass.md
[67]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceName.md
[68]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_Element.md
[69]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_NewInstance.md
[70]: ../../Aml.Engine.CAEX.Extensions/SystemUnitClassLibTypeExtensions/Insert_SystemUnitClass.md
[71]: ../../Aml.Engine.CAEX.Extensions/SystemUnitClassLibTypeExtensions/README.md
[72]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_TypeBaseElement.md
[73]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Name.md
[74]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[75]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[76]: ../../Aml.Engine.CAEX.Extensions/SystemUnitClassLibTypeExtensions/New_SystemUnitClass.md
[77]: ../../Aml.Engine.CAEX.Extensions/SystemUnitClassLibTypeExtensions/SystemUnitClassDescendants.md
[78]: ../CAEXLibrary_1/System_Collections_IEnumerable_GetEnumerator.md
[79]: https://www.automationml.org
[80]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"
[Explicit interface implementation]: ../../icons/pubinterface.gif "Explicit interface implementation"
[Private method]: ../../icons/privmethod.gif "Private method"