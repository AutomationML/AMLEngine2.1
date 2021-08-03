MappingElementType&lt;T> Class
==============================
AutomationML 2.1 APIThis class is the base class for Mapping element types which are [InterfaceNameMappingType][1], [InterfaceIDMappingType][2], and [AttributeNameMappingType][3].


Inheritance Hierarchy
---------------------
[System.Object][4]  
  [Aml.Engine.CAEX.CAEXWrapper][5]  
    [Aml.Engine.CAEX.CAEXBasicObject][6]  
      **Aml.Engine.CAEX.MappingElementType&lt;T>**  
        [Aml.Engine.CAEX.AttributeNameMappingType][3]  
        [Aml.Engine.CAEX.InterfaceIDMappingType][2]  
        [Aml.Engine.CAEX.InterfaceNameMappingType][1]  

  **Namespace:**  [Aml.Engine.CAEX][7]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public abstract class MappingElementType<T> : CAEXBasicObject, 
	IMappingElementType, IMapping, ICAEXBasicObject, ICAEXWrapper, IXMLWrapper
where T : CAEXObject

```

#### Type Parameters

##### *T*

[Missing &lt;typeparam name="T"/> documentation for "T:Aml.Engine.CAEX.MappingElementType`1"]


The **MappingElementType&lt;T>** type exposes the following members.


Properties
----------

                   | Name                                   | Description                                                                                                                                                                                                                                                                                                                                                                                                        
------------------ | -------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public property] | [AdditionalInformation][8]             | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [CAEXBasicObject][6].)                                                                                                                                                                                                                                                                                             
![Public property] | [CAEXDocument][9]                      | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][5].)                                                                                                                                                                                                                
![Public property] | [CAEXParent][10]                       | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][5].)                                                                                                                                                                                                                                                                                                                              
![Public property] | [CAEXSequenceOfCAEXObject][11]         | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][5].)                                                                                                                                                                                                                                                                                                                               
![Public property] | [ChangeMode][12]                       | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [CAEXBasicObject][6].)                                                                                                                                                                                                                                                                                                        
![Public property] | [Copyright][13]                        | Gets and sets the Copyright for this object. (Inherited from [CAEXBasicObject][6].)                                                                                                                                                                                                                                                                                                                                
![Public property] | [CopyrightElement][14]                 | Gets the wrapper for the Copyright element. (Inherited from [CAEXBasicObject][6].)                                                                                                                                                                                                                                                                                                                                 
![Public property] | [Description][15]                      | Gets and sets the Description for this object. (Inherited from [CAEXBasicObject][6].)                                                                                                                                                                                                                                                                                                                              
![Public property] | [DescriptionElement][16]               | Gets the wrapper for the Description element. (Inherited from [CAEXBasicObject][6].)                                                                                                                                                                                                                                                                                                                               
![Public property] | [Document][17]                         | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][5].)                                                                                                                                                                                                                                                                                                                                   
![Public property] | [Exists][18]                           | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][5].)                                                                                                                                                                                                                                                                                                                  
![Public property] | [MappingObject][19]                    | Gets the mapping object which contains this Mapping Element.                                                                                                                                                                                                                                                                                                                                                       
![Public property] | [MappingRoleClass][20]                 | Gets the RoleClass, which provides the [RoleClassMappingElements(Boolean)][21].                                                                                                                                                                                                                                                                                                                                    
![Public property] | [MappingRoleReference][22]             | Gets the Role reference, which can provide additional [RoleClassMappingElements(Boolean)][21].                                                                                                                                                                                                                                                                                                                     
![Public property] | [MappingSystemUnitClass][23]           | Gets the SystemUnitClass, which provides the [SystemUnitClassMappingElements][24].                                                                                                                                                                                                                                                                                                                                 
![Public property] | [Node][25]                             | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][5].)                                                                                                                                                                                                                                                                                                                                                    
![Public property] | [Owner][26]                            | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][5].)                                                                                                                                                                                                                                                                                                                                           
![Public property] | [Revision][27]                         | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][6].)                                                                                                                                                                                                                                                                                                         
![Public property] | [RoleClassElement][28]                 | Gets the RoleClass element which can be identified with the [RoleClassElementIdentifier][29] or sets the [RoleClassElementIdentifier][29] extracted from the provided CAEXObject which shall be an AttributeType for an attribute mapping or an ExternalInterfaceType for an interface mapping. If the provided CAEXobject is not applicable for the Mapping, the [RoleClassElementIdentifier][29] is not changed. 
![Public property] | [RoleClassElementIdentifier][29]       | Gets and sets the identifier for the mapped RoleClass element.                                                                                                                                                                                                                                                                                                                                                     
![Public property] | [SourceObjectInformation][30]          | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][6].)                                                                                                                                                                                                                                                                                          
![Public property] | [SystemUnitClassElement][31]           | Gets the SystemUnitClass element which can be identified with the [SystemUnitClassElementIdentifier][32] or sets the [SystemUnitClassElementIdentifier][32] defined by the provided value.                                                                                                                                                                                                                         
![Public property] | [SystemUnitClassElementIdentifier][32] | Gets or sets the identifier for the mapped SystemUnitClass element.                                                                                                                                                                                                                                                                                                                                                
![Public property] | [SystemUnitClassMappingElements][24]   | Gets the collection of all possible elements and their mapping identifiers of the mapped SystemUnitClass and its ancestors in the inheritance tree for this mapping element. The mapping identifier uniquely identifies the mapped CAEX object. The syntax of the identifier is defined by the derived mapping element types and is build from the CAEX path of the object.                                        
![Public property] | [TagName][33]                          | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][5].)                                                                                                                                                                                                                                                                                                                             
![Public property] | [Version][34]                          | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][6].)                                                                                                                                                                                                                                                                                                                                  
![Public property] | [VersionElement][35]                   | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][6].)                                                                                                                                                                                                                                                                                                                                   


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                                                                                                                                                                   
---------------- | ---------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [AddRoleClassElement][36]          | This method is an extension to the [RoleClassElement][28] setter in case of MultipleRole assignments in AutomationML 2.0 based on CAEX 2.15. The method can assign a qualified RoleClassElement as a mapping element and will eventually create a missing RoleRequirement element for the qualified element. For Documents, based on CAEX 3.0 the behaviour of this method is identical to the [RoleClassElement][28] setter. 
![Public method] | [CAEXChild][37]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][5].)                                                                                                                                                                                                                                                                                                                   
![Public method] | [CAEXChildren][38]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][5].)                                                                                                                                                                                                                                                                                                                      
![Public method] | [CAEXSequence][39]                 | Gets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects [Revision][27] is returned. (Inherited from [CAEXBasicObject][6].)                                                                                                                                                                    
![Public method] | [Container&lt;T>][40]              | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Inherited from [CAEXBasicObject][6].)                                                                                                                                                                                                                                                                                                     
![Public method] | [Copy][41]                         | Creates a deep copy of this CAEX object (Inherited from [CAEXWrapper][5].)                                                                                                                                                                                                                                                                                                                                                    
![Public method] | [Equals][42]                       | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][5].)                                                                                                                                                                                                                                                                                                 
![Public method] | [GetHashCode][43]                  | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][5].)                                                                                                                                                                                                                                                                                                                       
![Public method] | [GetXAttributeValue][44]           | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][5].)                                                                                                                                                                                                                                                                                          
![Public method] | [Insert(Int32, CAEXWrapper)][45]   | Inserts the specified CAEX object in it's associated sequence at the defined position. The CAEXBasicObject defines the [Revision][27] and [SourceObjectInformation][30] sequences. (Inherited from [CAEXBasicObject][6].)                                                                                                                                                                                                     
![Public method] | [Insert(CAEXWrapper, Boolean)][46] | Inserts the specified CAEX object in it's associated sequence. The CAEXBasicObject defines the [Revision][27] and [SourceObjectInformation][30] sequences. (Inherited from [CAEXBasicObject][6].)                                                                                                                                                                                                                             
![Public method] | [InsertNew][47]                    | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][26] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][5].)                                                                                                                                              
![Public method] | [New_Revision][48]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][27] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][6].)                                                                                                                       
![Public method] | [Remove][49]                       | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][5].)                                                                                                                                                                                                                                                                                          
![Public method] | [RoleClassMappingElements][21]     | Gets the collection of all possible elements and their mapping identifiers of the mapped RoleClass and its ancestors in the inheritance tree for this mapping element. The mapping identifier uniquely identifies the mapped CAEX object. The syntax of the identifier is defined by the derived mapping element types and is build from the CAEX path of the object.                                                         
![Public method] | [SetXAttributeValue][50]           | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][5].)                                                                                                                                                                                                                                                                                         


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][51] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][5].) 


Extension Methods
-----------------

                           | Name                                            | Description                                                                                                                                                                                                                                                                                                                                                                              
-------------------------- | ----------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [AMLSchemaManager][52]                          | Gets the associated CAEX schema manager of the CAEX object. (Defined by [CAEXBasicObjectExtensions][53].)                                                                                                                                                                                                                                                                                
![Public Extension Method] | [Ancestors&lt;T>][54]                           | Finds the ancestors of the provided CAEX object which have the given type. (Defined by [CAEXBasicObjectExtensions][53].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [CAEXDocument][55]                              | Gets the CAEX document which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][53].)                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [CAEXFile][56]                                  | Gets the CAEX file which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][53].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [CAEXSchema][57]                                | Gets the associated CAEX schema of the CAEX object. (Defined by [CAEXBasicObjectExtensions][53].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [clone][58]                                     | [Copy(Boolean, Boolean, Boolean)][41] (Defined by [AMLEngineAdapter][59].)                                                                                                                                                                                                                                                                                                               
![Public Extension Method] | [CloneNode][60]                                 | Clones the node. (Defined by [AMLEngineAdapter][59].)                                                                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [ConsistencyCheck_ClassReference][61]           | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][59].)                                                                                                                                                                                                                                                                  
![Public Extension Method] | [Descendants(Type)][62]                         | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][53].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [Descendants&lt;T>()][63]                       | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][53].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [Descendants&lt;T>(Boolean)][64]                | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][53].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [FindCaexObjectFromId&lt;T>][65]                | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][53].)                                                                                                                                                                                                                                                                        
![Public Extension Method] | [findInternalElement][66]                       | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][59].)                                                                                                                                                                                                                                                               
![Public Extension Method] | [FindReferencedClass&lt;T>][67]                 | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][53].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [FirstAncestor(String)][68]                     | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][53].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][69] | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][53].)                                                                                                                                                                                                                                    
![Public Extension Method] | [FirstAncestor&lt;T>()][70]                     | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][53].)                                                                                                                                                                                                                                                       
![Public Extension Method] | [GetParent&lt;T>][71]                           | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][53].)                                                                                                                                                                                 
![Public Extension Method] | [getReferencedClass][72]                        | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][59].)                                                                                                                                                                                                                                                                                                              
![Public Extension Method] | [getReferencedGUID][73]                         | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][59].)                                                                                                                                                                                                                                                                                      
![Public Extension Method] | [getReferencedInterfaceClass][74]               | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][59].)                                                                                                                                                                                                                                                                    
![Public Extension Method] | [getReferencedInterfaceName][75]                | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][59].)                                                                                                                                                                                                                                                                                                       
![Public Extension Method] | [Insert_Element][76]                            | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][59].)                                                                                                                                                              
![Public Extension Method] | [Insert_NewInstance][77]                        | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][59].)                                                                                                                        
![Public Extension Method] | [Insert_TypeBaseElement][78]                    | [Insert(CAEXWrapper, Boolean)][46] (Defined by [AMLEngineAdapter][59].)                                                                                                                                                                                                                                                                                                                  
![Public Extension Method] | [IsAMLObject][79]                               | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][80].) 
![Public Extension Method] | [Library][81]                                   | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][53].)                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [Name()][82]                                    | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][59].)                                                                                                                                                                                                                                                                                                   
![Public Extension Method] | [Name()][83]                                    | Overloaded. Gets a names for the specified caex wrapper object. If the specified object is a [CAEXObject][84], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][53].)                                                                                                                                                               
![Public Extension Method] | [New_Copyright][85]                             | Adds an new Copyright node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][53].)                                                                                                                                                                                                                                                                            
![Public Extension Method] | [New_Description][86]                           | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][53].)                                                                                                                                                                                                                                                                          
![Public Extension Method] | [New_Version][87]                               | Adds an new Version node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][53].)                                                                                                                                                                                                                                                                              


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][7]  
[Aml.Engine.CAEX.CAEXBasicObject][6]  
[Aml.Engine.CAEX.IMapping][88]  

[1]: ../InterfaceNameMappingType/README.md
[2]: ../InterfaceIDMappingType/README.md
[3]: ../AttributeNameMappingType/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.object
[5]: ../CAEXWrapper/README.md
[6]: ../CAEXBasicObject/README.md
[7]: ../README.md
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
[19]: MappingObject.md
[20]: MappingRoleClass.md
[21]: RoleClassMappingElements.md
[22]: MappingRoleReference.md
[23]: MappingSystemUnitClass.md
[24]: SystemUnitClassMappingElements.md
[25]: ../CAEXWrapper/Node.md
[26]: ../CAEXWrapper/Owner.md
[27]: ../CAEXBasicObject/Revision.md
[28]: RoleClassElement.md
[29]: RoleClassElementIdentifier.md
[30]: ../CAEXBasicObject/SourceObjectInformation.md
[31]: SystemUnitClassElement.md
[32]: SystemUnitClassElementIdentifier.md
[33]: ../CAEXWrapper/TagName.md
[34]: ../CAEXBasicObject/Version.md
[35]: ../CAEXBasicObject/VersionElement.md
[36]: AddRoleClassElement.md
[37]: ../CAEXWrapper/CAEXChild.md
[38]: ../CAEXWrapper/CAEXChildren.md
[39]: ../CAEXBasicObject/CAEXSequence.md
[40]: ../CAEXBasicObject/Container__1.md
[41]: ../CAEXWrapper/Copy.md
[42]: ../CAEXWrapper/Equals.md
[43]: ../CAEXWrapper/GetHashCode.md
[44]: ../CAEXWrapper/GetXAttributeValue.md
[45]: ../CAEXBasicObject/Insert_1.md
[46]: ../CAEXBasicObject/Insert.md
[47]: ../CAEXWrapper/InsertNew.md
[48]: ../CAEXBasicObject/New_Revision.md
[49]: ../CAEXWrapper/Remove.md
[50]: ../CAEXWrapper/SetXAttributeValue.md
[51]: ../CAEXWrapper/PropertyChanged.md
[52]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/AMLSchemaManager.md
[53]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[54]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Ancestors__1.md
[55]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXDocument.md
[56]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXFile.md
[57]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXSchema.md
[58]: ../../Aml.Engine.Adapter/AMLEngineAdapter/clone.md
[59]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[60]: ../../Aml.Engine.Adapter/AMLEngineAdapter/CloneNode.md
[61]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ConsistencyCheck_ClassReference.md
[62]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[63]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[64]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[65]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[66]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[67]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[68]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[69]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[70]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[71]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/GetParent__1.md
[72]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedClass.md
[73]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedGUID.md
[74]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceClass.md
[75]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceName.md
[76]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_Element.md
[77]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_NewInstance.md
[78]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_TypeBaseElement.md
[79]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsAMLObject.md
[80]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[81]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Library.md
[82]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Name.md
[83]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[84]: ../CAEXObject/README.md
[85]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Copyright.md
[86]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[87]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Version.md
[88]: ../IMapping/README.md
[89]: https://www.automationml.org
[90]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"