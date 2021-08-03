AttributeNameMappingType Class
==============================
This class is a wrapper for the CAEX element 'AttributeNameMapping' which defines mappings between attributes of an AML object and any associated role class.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.CAEXWrapper][2]  
    [Aml.Engine.CAEX.CAEXBasicObject][3]  
      [Aml.Engine.CAEX.MappingElementType][4]&lt;[AttributeType][5]>  
        **Aml.Engine.CAEX.AttributeNameMappingType**  

  **Namespace:**  [Aml.Engine.CAEX][6]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class AttributeNameMappingType : MappingElementType<AttributeType>
```

The **AttributeNameMappingType** type exposes the following members.


Constructors
------------

                 | Name                          | Description                                                                           
---------------- | ----------------------------- | ------------------------------------------------------------------------------------- 
![Public method] | [AttributeNameMappingType][7] | Creates a wrapper for the specified XElement which is an AttributeNameMapping Element 


Properties
----------

                   | Name                                   | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
------------------ | -------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AdditionalInformation][8]             | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                                                                                                                                                                                                 
![Public property] | [CAEXDocument][9]                      | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                    
![Public property] | [CAEXParent][10]                       | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                                                                                                                                  
![Public property] | [CAEXSequenceOfCAEXObject][11]         | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                                                                                                                                   
![Public property] | [ChangeMode][12]                       | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                                                                                                                                                                                                            
![Public property] | [Copyright][13]                        | Gets and sets the Copyright for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                                                                                                                                                                                                                                    
![Public property] | [CopyrightElement][14]                 | Gets the wrapper for the Copyright element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                                                                                                                                                                                                                                     
![Public property] | [Description][15]                      | Gets and sets the Description for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                                                                                                                                                                                                                                  
![Public property] | [DescriptionElement][16]               | Gets the wrapper for the Description element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                                                                                                                                                                                                                                   
![Public property] | [Document][17]                         | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                                                                                                                                       
![Public property] | [Exists][18]                           | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                                                                                                                      
![Public property] | [MappingObject][19]                    | Gets the mapping object which contains this Mapping Element. (Inherited from [MappingElementType&lt;T>][4].)                                                                                                                                                                                                                                                                                                                                                                                                                           
![Public property] | [MappingRoleClass][20]                 | Gets the RoleClass, which provides the [RoleClassMappingElements(Boolean)][21]. (Inherited from [MappingElementType&lt;T>][4].)                                                                                                                                                                                                                                                                                                                                                                                                        
![Public property] | [MappingRoleReference][22]             | Gets the Role reference, which can provide additional [RoleClassMappingElements(Boolean)][21]. (Inherited from [MappingElementType&lt;T>][4].)                                                                                                                                                                                                                                                                                                                                                                                         
![Public property] | [MappingSystemUnitClass][23]           | Gets the SystemUnitClass, which provides the [SystemUnitClassMappingElements][24]. (Inherited from [MappingElementType&lt;T>][4].)                                                                                                                                                                                                                                                                                                                                                                                                     
![Public property] | [Node][25]                             | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
![Public property] | [Owner][26]                            | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                                                                                                                                               
![Public property] | [Revision][27]                         | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                                                                                                                                                                                                             
![Public property] | [RoleAttribute][28]                    | Gets the RoleClass element which can be identified with the [RoleAttributeName][29] or sets the [RoleAttributeName][29] retrieved from the provided value.                                                                                                                                                                                                                                                                                                                                                                             
![Public property] | [RoleAttributeName][29]                | Gets and Sets the 'RoleAttributeName' for this instance                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
![Public property] | [RoleClassElement][30]                 | Gets the RoleClass element which can be identified with the [RoleClassElementIdentifier][31] or sets the [RoleClassElementIdentifier][31] extracted from the provided CAEXObject which shall be an AttributeType for an attribute mapping or an ExternalInterfaceType for an interface mapping. If the provided CAEXobject is not applicable for the Mapping, the [RoleClassElementIdentifier][31] is not changed. (Inherited from [MappingElementType&lt;T>][4].)                                                                     
![Public property] | [RoleClassElementIdentifier][32]       | Gets and sets the identifier for the mapped RoleClass element. (Overrides [MappingElementType&lt;T>.RoleClassElementIdentifier][31].)                                                                                                                                                                                                                                                                                                                                                                                                  
![Public property] | [SourceObjectInformation][33]          | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                                                                                                                                                                                              
![Public property] | [SystemUnitAttribute][34]              | Gets or sets the system unit attribute which is defined using the CAEX attribute [SystemUnitAttributeName][35].                                                                                                                                                                                                                                                                                                                                                                                                                        
![Public property] | [SystemUnitAttributeName][35]          | Gets and Sets the 'SystemUnitAttributeName' for this instance                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
![Public property] | [SystemUnitClassElement][36]           | Gets the SystemUnitClass element which can be identified with the [SystemUnitClassElementIdentifier][37] or sets the [SystemUnitClassElementIdentifier][37] defined by the provided value. (Inherited from [MappingElementType&lt;T>][4].)                                                                                                                                                                                                                                                                                             
![Public property] | [SystemUnitClassElementIdentifier][38] | Gets or sets the identifier for the mapped SystemUnitClass element. (Overrides [MappingElementType&lt;T>.SystemUnitClassElementIdentifier][37].)                                                                                                                                                                                                                                                                                                                                                                                       
![Public property] | [SystemUnitClassMappingElements][39]   | Gets the collection of possible mapping identifiers for this AttributeNameMappingType for elements of the mapped SystemUnitClass. The Collection contains all attributes (including inherited attributes) of the SystemUnitClass and also the attributes of the ExternalInterfaces (including inherited external interfaces) of the SystemUnitClass. The Attribute Identifiers are the unique CAEXPath's of the attributes relative to the SystemUnitClass. (Overrides [MappingElementType&lt;T>.SystemUnitClassMappingElements][24].) 
![Public property] | [TagName][40]                          | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                                                                                                                                 
![Public property] | [Version][41]                          | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                                                                                                                                                                                                                                      
![Public property] | [VersionElement][42]                   | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                                                                                                                                                                                                                                       


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
---------------- | ---------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [AddRoleClassElement][43]          | This method is an extension to the [RoleClassElement][30] setter in case of MultipleRole assignments in AutomationML 2.0 based on CAEX 2.15. The method can assign a qualified RoleClassElement as a mapping element and will eventually create a missing RoleRequirement element for the qualified element. For Documents, based on CAEX 3.0 the behaviour of this method is identical to the [RoleClassElement][30] setter. (Inherited from [MappingElementType&lt;T>][4].)                                     
![Public method] | [CAEXChild][44]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                                                                                       
![Public method] | [CAEXChildren][45]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                                                                                          
![Public method] | [CAEXSequence][46]                 | Gets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects [Revision][27] is returned. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                                        
![Public method] | [Container&lt;T>][47]              | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                                                                                                                                                                         
![Public method] | [Copy][48]                         | Creates a deep copy of this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                                                                                                                        
![Public method] | [Equals][49]                       | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                                                                     
![Public method] | [GetHashCode][50]                  | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                                                                                           
![Public method] | [GetXAttributeValue][51]           | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                                                              
![Public method] | [Insert(Int32, CAEXWrapper)][52]   | Inserts the specified CAEX object in it's associated sequence at the defined position. The CAEXBasicObject defines the [Revision][27] and [SourceObjectInformation][33] sequences. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                                                                         
![Public method] | [Insert(CAEXWrapper, Boolean)][53] | Inserts the specified CAEX object in it's associated sequence. The CAEXBasicObject defines the [Revision][27] and [SourceObjectInformation][33] sequences. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                                                                                                 
![Public method] | [InsertNew][54]                    | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][26] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                  
![Public method] | [New_Revision][55]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][27] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                           
![Public method] | [Remove][56]                       | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                                                              
![Public method] | [RoleClassMappingElements][57]     | Gets the collection of possible mapping identifiers for this AttributeNameMappingType for elements of the mapped RoleClass. The Collection contains all attributes (including inherited attributes) of the RoleClass and also the attributes of the ExternalInterfaces (including inherited external interfaces) of the RoleClass. The Attribute Identifiers are the unique CAEXPath's of the attributes relative to the RoleClass. (Overrides [MappingElementType&lt;T>.RoleClassMappingElements(Boolean)][21].) 
![Public method] | [SetXAttributeValue][58]           | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                                                             


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][59] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][2].) 


Extension Methods
-----------------

                           | Name                                  | Description                                                                                                                                                                                                                                                       
-------------------------- | ------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [clone][60]                           | [Copy(Boolean, Boolean, Boolean)][48] (Defined by [AMLEngineAdapter][61].)                                                                                                                                                                                        
![Public Extension Method] | [CloneNode][62]                       | Clones the node. (Defined by [AMLEngineAdapter][61].)                                                                                                                                                                                                             
![Public Extension Method] | [ConsistencyCheck_ClassReference][63] | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][61].)                                                                                                                                           
![Public Extension Method] | [Descendants(Type)][64]               | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][65].)                                                                                                                          
![Public Extension Method] | [Descendants&lt;T>()][66]             | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][65].)                                                                                                                          
![Public Extension Method] | [findInternalElement][67]             | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][61].)                                                                                                                                        
![Public Extension Method] | [getReferencedClass][68]              | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][61].)                                                                                                                                                                                       
![Public Extension Method] | [getReferencedGUID][69]               | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][61].)                                                                                                                                                               
![Public Extension Method] | [getReferencedInterfaceClass][70]     | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][61].)                                                                                                                                             
![Public Extension Method] | [getReferencedInterfaceName][71]      | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][61].)                                                                                                                                                                                
![Public Extension Method] | [Insert_Element][72]                  | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][61].)                                       
![Public Extension Method] | [Insert_NewInstance][73]              | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][61].) 
![Public Extension Method] | [Insert_TypeBaseElement][74]          | [Insert(CAEXWrapper, Boolean)][53] (Defined by [AMLEngineAdapter][61].)                                                                                                                                                                                           
![Public Extension Method] | [Name()][75]                          | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][61].)                                                                                                                                                                            
![Public Extension Method] | [Name()][76]                          | Overloaded. Gets a names for the specified caex wrapper object. If the specified object is a [CAEXObject][77], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][65].)                                        
![Public Extension Method] | [New_Description][78]                 | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][65].)                                                                                                                                                   


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][6]  
[Aml.Engine.CAEX.CAEXBasicObject][3]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../CAEXWrapper/README.md
[3]: ../CAEXBasicObject/README.md
[4]: ../MappingElementType_1/README.md
[5]: ../AttributeType/README.md
[6]: ../README.md
[7]: _ctor.md
[8]: ../CAEXBasicObject/AdditionalInformation.md
[9]: ../CAEXWrapper/CAEXDocument.md
[10]: ../CAEXWrapper/CAEXParent.md
[11]: ../CAEXWrapper/CAEXSequenceOfCAEXObject.md
[12]: ../CAEXBasicObject/ChangeMode.md
[13]: ../CAEXBasicObject/Copyright.md
[14]: ../CAEXBasicObject/CopyrightElement.md
[15]: ../CAEXBasicObject/Description.md
[16]: ../CAEXBasicObject/DescriptionElement.md
[17]: ../CAEXWrapper/Document.md
[18]: ../CAEXWrapper/Exists.md
[19]: ../MappingElementType_1/MappingObject.md
[20]: ../MappingElementType_1/MappingRoleClass.md
[21]: ../MappingElementType_1/RoleClassMappingElements.md
[22]: ../MappingElementType_1/MappingRoleReference.md
[23]: ../MappingElementType_1/MappingSystemUnitClass.md
[24]: ../MappingElementType_1/SystemUnitClassMappingElements.md
[25]: ../CAEXWrapper/Node.md
[26]: ../CAEXWrapper/Owner.md
[27]: ../CAEXBasicObject/Revision.md
[28]: RoleAttribute.md
[29]: RoleAttributeName.md
[30]: ../MappingElementType_1/RoleClassElement.md
[31]: ../MappingElementType_1/RoleClassElementIdentifier.md
[32]: RoleClassElementIdentifier.md
[33]: ../CAEXBasicObject/SourceObjectInformation.md
[34]: SystemUnitAttribute.md
[35]: SystemUnitAttributeName.md
[36]: ../MappingElementType_1/SystemUnitClassElement.md
[37]: ../MappingElementType_1/SystemUnitClassElementIdentifier.md
[38]: SystemUnitClassElementIdentifier.md
[39]: SystemUnitClassMappingElements.md
[40]: ../CAEXWrapper/TagName.md
[41]: ../CAEXBasicObject/Version.md
[42]: ../CAEXBasicObject/VersionElement.md
[43]: ../MappingElementType_1/AddRoleClassElement.md
[44]: ../CAEXWrapper/CAEXChild.md
[45]: ../CAEXWrapper/CAEXChildren.md
[46]: ../CAEXBasicObject/CAEXSequence.md
[47]: ../CAEXBasicObject/Container__1.md
[48]: ../CAEXWrapper/Copy.md
[49]: ../CAEXWrapper/Equals.md
[50]: ../CAEXWrapper/GetHashCode.md
[51]: ../CAEXWrapper/GetXAttributeValue.md
[52]: ../CAEXBasicObject/Insert_1.md
[53]: ../CAEXBasicObject/Insert.md
[54]: ../CAEXWrapper/InsertNew.md
[55]: ../CAEXBasicObject/New_Revision.md
[56]: ../CAEXWrapper/Remove.md
[57]: RoleClassMappingElements.md
[58]: ../CAEXWrapper/SetXAttributeValue.md
[59]: ../CAEXWrapper/PropertyChanged.md
[60]: ../../Aml.Engine.Adapter/AMLEngineAdapter/clone.md
[61]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[62]: ../../Aml.Engine.Adapter/AMLEngineAdapter/CloneNode.md
[63]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ConsistencyCheck_ClassReference.md
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
[77]: ../CAEXObject/README.md
[78]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[79]: https://www.automationml.org
[80]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"