MappingType Class
=================
This Class is a wrapper for the CAEXElement 'MappingObject'


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.CAEXWrapper][2]  
    [Aml.Engine.CAEX.CAEXBasicObject][3]  
      **Aml.Engine.CAEX.MappingType**  

  **Namespace:**  [Aml.Engine.CAEX][4]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class MappingType : CAEXBasicObject
```

The **MappingType** type exposes the following members.


Constructors
------------

                 | Name             | Description                                              
---------------- | ---------------- | -------------------------------------------------------- 
![Public method] | [MappingType][5] | Initializes a new instance of the **MappingType** class. 


Properties
----------

                   | Name                           | Description                                                                                                                                                                                         
------------------ | ------------------------------ | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AdditionalInformation][6]     | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                              
![Public property] | [AttributeNameMapping][7]      | Gets the collection of AttributeNameMapping objects contained in this instance.                                                                                                                     
![Public property] | [CAEXDocument][8]              | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][2].) 
![Public property] | [CAEXParent][9]                | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][2].)                                                                                                               
![Public property] | [CAEXSequenceOfCAEXObject][10] | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                
![Public property] | [ChangeMode][11]               | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [CAEXBasicObject][3].)                                                                                         
![Public property] | [Copyright][12]                | Gets and sets the Copyright for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                 
![Public property] | [CopyrightElement][13]         | Gets the wrapper for the Copyright element. (Inherited from [CAEXBasicObject][3].)                                                                                                                  
![Public property] | [Description][14]              | Gets and sets the Description for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                               
![Public property] | [DescriptionElement][15]       | Gets the wrapper for the Description element. (Inherited from [CAEXBasicObject][3].)                                                                                                                
![Public property] | [Document][16]                 | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                    
![Public property] | [Exists][17]                   | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                   
![Public property] | [InterfaceIDMapping][18]       | Gets the collection of InterfaceIDMapping objects contained in this instance.                                                                                                                       
![Public property] | [InterfaceNameMapping][19]     | Gets the collection of InterfaceNameMapping objects contained in this instance.                                                                                                                     
![Public property] | [Node][20]                     | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                     
![Public property] | [Owner][21]                    | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][2].)                                                                                                                            
![Public property] | [Revision][22]                 | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                          
![Public property] | [SourceObjectInformation][23]  | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                           
![Public property] | [TagName][24]                  | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][2].)                                                                                                              
![Public property] | [Version][25]                  | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                   
![Public property] | [VersionElement][26]           | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][3].)                                                                                                                    


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                                             
---------------- | ---------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [CAEXChild][27]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                             
![Public method] | [CAEXChildren][28]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                
![Public method] | [CAEXSequence][29]                 | Gets the CAEXSequence owned by this CAEX object, which contains the specified CAEX object. (Overrides [CAEXBasicObject.CAEXSequence(ICAEXWrapper)][30].)                                                                                                                                                
![Public method] | [Container&lt;T>][31]              | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                               
![Public method] | [Copy][32]                         | Creates a deep copy of this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                              
![Public method] | [Equals][33]                       | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                           
![Public method] | [GetHashCode][34]                  | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                 
![Public method] | [GetXAttributeValue][35]           | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                    
![Public method] | [Insert(Int32, CAEXWrapper)][36]   | Inserts the specified CAEX object in it's associated sequence at the given position. The MappingType defines the [InterfaceIDMapping][18], [InterfaceNameMapping][19] and [AttributeNameMapping][7] sequence. (Overrides [CAEXBasicObject.Insert(Int32, CAEXWrapper)][37].)                             
![Public method] | [Insert(CAEXWrapper, Boolean)][38] | Inserts the specified CAEX object in it's associated sequence. The MappingType defines the [InterfaceIDMapping][18], [InterfaceNameMapping][19] and [AttributeNameMapping][7] sequence. (Overrides [CAEXBasicObject.Insert(CAEXWrapper, Boolean)][39].)                                                 
![Public method] | [InsertNew][40]                    | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][21] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][2].)                        
![Public method] | [New_Revision][41]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][22] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][3].) 
![Public method] | [Remove][42]                       | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                    
![Public method] | [SetXAttributeValue][43]           | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][2].)                                                                                                                                                                   


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][44] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][2].) 


Extension Methods
-----------------

                           | Name                                                                       | Description                                                                                                                                                                                                                                                       
-------------------------- | -------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [clone][45]                                                                | [Copy(Boolean, Boolean, Boolean)][32] (Defined by [AMLEngineAdapter][46].)                                                                                                                                                                                        
![Public Extension Method] | [CloneNode][47]                                                            | Clones the node. (Defined by [AMLEngineAdapter][46].)                                                                                                                                                                                                             
![Public Extension Method] | [ConsistencyCheck_ClassReference][48]                                      | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][46].)                                                                                                                                           
![Public Extension Method] | [Descendants(Type)][49]                                                    | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][50].)                                                                                                                          
![Public Extension Method] | [Descendants&lt;T>()][51]                                                  | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][50].)                                                                                                                          
![Public Extension Method] | [findInternalElement][52]                                                  | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][46].)                                                                                                                                        
![Public Extension Method] | [getReferencedClass][53]                                                   | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][46].)                                                                                                                                                                                       
![Public Extension Method] | [getReferencedGUID][54]                                                    | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][46].)                                                                                                                                                               
![Public Extension Method] | [getReferencedInterfaceClass][55]                                          | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][46].)                                                                                                                                             
![Public Extension Method] | [getReferencedInterfaceName][56]                                           | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][46].)                                                                                                                                                                                
![Public Extension Method] | [Insert_AttributeNameMapping][57]                                          | Appends the AttributeNameMapping object to the defined Mapping object (Defined by [MappingTypeExtensions][58].)                                                                                                                                                   
![Public Extension Method] | [Insert_Element][59]                                                       | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][46].)                                       
![Public Extension Method] | [Insert_InterfaceNameMapping][60]                                          | Appends the InterfaceNameMapping object to the defined Mapping object (Defined by [MappingTypeExtensions][58].)                                                                                                                                                   
![Public Extension Method] | [Insert_NewInstance][61]                                                   | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][46].) 
![Public Extension Method] | [Insert_TypeBaseElement][62]                                               | [Insert(CAEXWrapper, Boolean)][39] (Defined by [AMLEngineAdapter][46].)                                                                                                                                                                                           
![Public Extension Method] | [Name()][63]                                                               | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][46].)                                                                                                                                                                            
![Public Extension Method] | [Name()][64]                                                               | Overloaded. Gets a names for the specified CAEX wrapper object. If the specified object is a [CAEXObject][65], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][50].)                                        
![Public Extension Method] | [New_AttributeNameMapping][66]                                             | Adding a new AttributeNameMapping to the defined Mapping object. An AttributeNameMapping allows the definition of the mapping between attribute names of corresponding RoleClasses and SystemUnitClasses. (Defined by [MappingTypeExtensions][58].)               
![Public Extension Method] | [New_Description][67]                                                      | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][50].)                                                                                                                                                   
![Public Extension Method] | [New_InterfaceIDMapping(String, String)][68]                               | Overloaded. Adding a new InterfaceIDMapping to the defined Mapping object. An InterfaceIDMapping allows the definition of the mapping between Interfaces of corresponding RoleClasses and SystemUnitClasses. (Defined by [MappingTypeExtensions][58].)            
![Public Extension Method] | [New_InterfaceIDMapping(ExternalInterfaceType, ExternalInterfaceType)][69] | Overloaded. Adding a new InterfaceIDMapping to the defined Mapping object. An InterfaceIDMapping allows the definition of the mapping between Interfaces of corresponding RoleClasses and SystemUnitClasses. (Defined by [MappingTypeExtensions][58].)            
![Public Extension Method] | [New_InterfaceNameMapping][70]                                             | Adding a new InterfaceNameMapping to the defined Mapping object. An InterfaceNameMapping allows the definition of the mapping between Interface names of corresponding RoleClasses and SystemUnitClasses. (Defined by [MappingTypeExtensions][58].)               


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][4]  
[Aml.Engine.CAEX.CAEXBasicObject][3]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../CAEXWrapper/README.md
[3]: ../CAEXBasicObject/README.md
[4]: ../README.md
[5]: _ctor.md
[6]: ../CAEXBasicObject/AdditionalInformation.md
[7]: AttributeNameMapping.md
[8]: ../CAEXWrapper/CAEXDocument.md
[9]: ../CAEXWrapper/CAEXParent.md
[10]: ../CAEXWrapper/CAEXSequenceOfCAEXObject.md
[11]: ../CAEXBasicObject/ChangeMode.md
[12]: ../CAEXBasicObject/Copyright.md
[13]: ../CAEXBasicObject/CopyrightElement.md
[14]: ../CAEXBasicObject/Description.md
[15]: ../CAEXBasicObject/DescriptionElement.md
[16]: ../CAEXWrapper/Document.md
[17]: ../CAEXWrapper/Exists.md
[18]: InterfaceIDMapping.md
[19]: InterfaceNameMapping.md
[20]: ../CAEXWrapper/Node.md
[21]: ../CAEXWrapper/Owner.md
[22]: ../CAEXBasicObject/Revision.md
[23]: ../CAEXBasicObject/SourceObjectInformation.md
[24]: ../CAEXWrapper/TagName.md
[25]: ../CAEXBasicObject/Version.md
[26]: ../CAEXBasicObject/VersionElement.md
[27]: ../CAEXWrapper/CAEXChild.md
[28]: ../CAEXWrapper/CAEXChildren.md
[29]: CAEXSequence.md
[30]: ../CAEXBasicObject/CAEXSequence.md
[31]: ../CAEXBasicObject/Container__1.md
[32]: ../CAEXWrapper/Copy.md
[33]: ../CAEXWrapper/Equals.md
[34]: ../CAEXWrapper/GetHashCode.md
[35]: ../CAEXWrapper/GetXAttributeValue.md
[36]: Insert_1.md
[37]: ../CAEXBasicObject/Insert_1.md
[38]: Insert.md
[39]: ../CAEXBasicObject/Insert.md
[40]: ../CAEXWrapper/InsertNew.md
[41]: ../CAEXBasicObject/New_Revision.md
[42]: ../CAEXWrapper/Remove.md
[43]: ../CAEXWrapper/SetXAttributeValue.md
[44]: ../CAEXWrapper/PropertyChanged.md
[45]: ../../Aml.Engine.Adapter/AMLEngineAdapter/clone.md
[46]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[47]: ../../Aml.Engine.Adapter/AMLEngineAdapter/CloneNode.md
[48]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ConsistencyCheck_ClassReference.md
[49]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[50]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[51]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[52]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[53]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedClass.md
[54]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedGUID.md
[55]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceClass.md
[56]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceName.md
[57]: ../../Aml.Engine.CAEX.Extensions/MappingTypeExtensions/Insert_AttributeNameMapping.md
[58]: ../../Aml.Engine.CAEX.Extensions/MappingTypeExtensions/README.md
[59]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_Element.md
[60]: ../../Aml.Engine.CAEX.Extensions/MappingTypeExtensions/Insert_InterfaceNameMapping.md
[61]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_NewInstance.md
[62]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_TypeBaseElement.md
[63]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Name.md
[64]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[65]: ../CAEXObject/README.md
[66]: ../../Aml.Engine.CAEX.Extensions/MappingTypeExtensions/New_AttributeNameMapping.md
[67]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[68]: ../../Aml.Engine.CAEX.Extensions/MappingTypeExtensions/New_InterfaceIDMapping_1.md
[69]: ../../Aml.Engine.CAEX.Extensions/MappingTypeExtensions/New_InterfaceIDMapping.md
[70]: ../../Aml.Engine.CAEX.Extensions/MappingTypeExtensions/New_InterfaceNameMapping.md
[71]: https://www.automationml.org
[72]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"