IClassWithBaseClassReference Interface
======================================
AutomationML 2.1 APIInterface class that defines methods and properties that apply to all classes which can be part of a class to class relation. A class to class relation is also referred to as an inheritance relation.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public interface IClassWithBaseClassReference : IObjectWithAttributes, 
	ICAEXWrapper, IXMLWrapper, ICAEXObject, ICAEXBasicObject
```

The **IClassWithBaseClassReference** type exposes the following members.


Properties
----------

                   | Name                          | Description                                                                                                                                                                                                                                                
------------------ | ----------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AdditionalInformation][2]    | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                    
![Public property] | [Attribute][4]                | Get the collection of all attributes of this object. Inherited Attributes are not included. (Inherited from [IObjectWithAttributes][5].)                                                                                                                   
![Public property] | [AttributeAndDescendants][6]  | Gets the attributes and all nested attributes. (Inherited from [IObjectWithAttributes][5].)                                                                                                                                                                
![Public property] | [CAEXParent][7]               | Gets the CAEXParent of this CAEX object (Inherited from [ICAEXWrapper][8].)                                                                                                                                                                                
![Public property] | [ChangeMode][9]               | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [ICAEXBasicObject][3].)                                                                                                                                               
![Public property] | [Copyright][10]               | Gets and sets the Copyright for this object. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                                       
![Public property] | [CopyrightElement][11]        | Gets the wrapper for the Copyright element. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                                        
![Public property] | [Description][12]             | Gets and sets the Description for this object. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                                     
![Public property] | [DescriptionElement][13]      | Gets the wrapper for the Description element. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                                      
![Public property] | [Document][14]                | Gets the XDocument containing the XML node of this object. If the object has not been inserted into a document, the XDocument is `null`. Direct manipulations of the XML document are not monitored by the AML engine. (Inherited from [IXMLWrapper][15].) 
![Public property] | [Exists][16]                  | Determines, if this instance is wrapped around an existing XML node (Inherited from [IXMLWrapper][15].)                                                                                                                                                    
![Public property] | [ID][17]                      | Gets or sets the identifier. (Inherited from [ICAEXObject][18].)                                                                                                                                                                                           
![Public property] | [Name][19]                    | Gets or sets the name. (Inherited from [ICAEXObject][18].)                                                                                                                                                                                                 
![Public property] | [Node][20]                    | Get the XML node of this instance. Direct manipulations of the XML node are not monitored by the AML engine. (Inherited from [IXMLWrapper][15].)                                                                                                           
![Public property] | [Owner][21]                   | Gets the XML parent node of this instance. Direct manipulations of the XML node are not monitored by the AML engine. (Inherited from [IXMLWrapper][15].)                                                                                                   
![Public property] | [RefBaseClassPath][22]        | Gets the reference base class path.                                                                                                                                                                                                                        
![Public property] | [ReferencedClassName][23]     | Gets the name (not the full path) of the referenced base class.                                                                                                                                                                                            
![Public property] | [Revision][24]                | Gets the collection of Revision objects contained in this instance. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                
![Public property] | [SourceObjectInformation][25] | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                 
![Public property] | [TagName][26]                 | Gets the Schema Tag name of this instance. (Inherited from [IXMLWrapper][15].)                                                                                                                                                                             
![Public property] | [Version][27]                 | Gets and sets the Version for this object. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                                         
![Public property] | [VersionElement][28]          | Gets the wrapper for the Version element. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                                          


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                                                                                                                      
---------------- | ---------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [CAEXChild][29]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [ICAEXWrapper][8].)                                                                                                                                                                                                                                                                     
![Public method] | [CAEXChildren][30]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [ICAEXWrapper][8].)                                                                                                                                                                                                                                                                        
![Public method] | [CAEXPath][31]                     | Gets the CAEX path for this object. A path can be used to uniquely reference an object, for example in inheritances and instances. The path syntax for an object is defined differently in CAEX 2.15 and CAEX 3.0. The engine uses the [CAEXPathBuilder][32] to generate the CAEX path of an object according to the documents CAEX version. (Inherited from [ICAEXObject][18].) 
![Public method] | [CAEXSequence][33]                 | Gets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects [Revision][24] is returned. (Inherited from [ICAEXBasicObject][3].)                                                                                                                      
![Public method] | [Container&lt;T>][34]              | Gets the CAEXSequence for elements of type T, which is owned by this CAEX object. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                                                                                                                        
![Public method] | [GetReferenceHierarchy&lt;T>][35]  | Gets the reference (inheritance relations) hierarchy including the actual class as a queue.                                                                                                                                                                                                                                                                                      
![Public method] | [Insert(Int32, CAEXWrapper)][36]   | Inserts the specified CAEX object in it's associated sequence at the defined position. The CAEXBasicObject defines the [Revision][24] and [SourceObjectInformation][25] sequences. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                       
![Public method] | [Insert(CAEXWrapper, Boolean)][37] | Inserts the specified CAEX object in it's associated sequence. The CAEXBasicObject defines the [Revision][24] and [SourceObjectInformation][25] sequences. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                                               
![Public method] | [New_Revision][38]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][24] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [ICAEXBasicObject][3].)                                                                         
![Public method] | [Remove][39]                       | Removes this object (Inherited from [ICAEXWrapper][8].)                                                                                                                                                                                                                                                                                                                          


Extension Methods
-----------------

                                          | Name                                                                           | Description                                                                                                                                                                                                                                                                                                                                                                              
----------------------------------------- | ------------------------------------------------------------------------------ | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method]![Code example] | [AddAttributeTypeReference(String, Boolean, Boolean, String)][40]              | Overloaded. Adds an AttributeType reference to this ObjectWithAttribute using the provided CAEX path, referencing an AttributeType object. The AttributeType reference is added as a [AttributeType][41] object. (Defined by [ObjectWithAttributes][42].)                                                                                                                                
![Public Extension Method]![Code example] | [AddAttributeTypeReference(AttributeFamilyType, Boolean, Boolean, String)][43] | Overloaded. Adds an AttributeType reference to this ObjectWithAttribute using the provided AttributeType object. The AttributeType reference is added as a [AttributeType][41] object. (Defined by [ObjectWithAttributes][42].)                                                                                                                                                          
![Public Extension Method]                | [AMLAttributes][44]                                                            | Conversion of any object which has an attribute collection to get access to specific AutomationML defined attributes. (Defined by [AmlObjectsExtensions][45].)                                                                                                                                                                                                                           
![Public Extension Method]                | [AMLSchemaManager][46]                                                         | Gets the associated CAEX schema manager of the CAEX object. (Defined by [CAEXBasicObjectExtensions][47].)                                                                                                                                                                                                                                                                                
![Public Extension Method]                | [Ancestors&lt;T>][48]                                                          | Finds the ancestors of the provided CAEX object which have the given type. (Defined by [CAEXBasicObjectExtensions][47].)                                                                                                                                                                                                                                                                 
![Public Extension Method]                | [Attributes][49]                                                               | Enumeration Method for direct Children of Type [AttributeType][41] (Defined by [AMLEngineAdapter][50].)                                                                                                                                                                                                                                                                                  
![Public Extension Method]                | [CAEXDocument][51]                                                             | Gets the CAEX document which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][47].)                                                                                                                                                                                                                                                                                    
![Public Extension Method]                | [CAEXFile][52]                                                                 | Gets the CAEX file which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][47].)                                                                                                                                                                                                                                                                                        
![Public Extension Method]                | [CAEXSchema][53]                                                               | Gets the associated CAEX schema of the CAEX object. (Defined by [CAEXBasicObjectExtensions][47].)                                                                                                                                                                                                                                                                                        
![Public Extension Method]                | [CopyAttributesFrom][54]                                                       | Copies all attribute of the source object with attributes to the target object including children (Defined by [ObjectWithAttributes][42].)                                                                                                                                                                                                                                               
![Public Extension Method]                | [CreateListAttribute][55]                                                      | Creates a new list attribute for an element which can have attributes. (Defined by [ListAttribute][56].)                                                                                                                                                                                                                                                                                 
![Public Extension Method]                | [DeleteInheritedElement][57]                                                   | Deletes the inherited element. According to CAEX [DIN EN 62424:2008-08 A.2.4.1 (pp.48-49)], deleting of inherited properties is possible by redefinition of the corresponding data again in the child object with the ChangeMode attribute set to "deleted". (Defined by [ObjectWithBaseClass][58].)                                                                                     
![Public Extension Method]                | [Descendants&lt;T>][59]                                                        | Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][47].)                                                                                                                                                                                                                                                             
![Public Extension Method]                | [FindCaexObjectFromId&lt;T>][60]                                               | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][47].)                                                                                                                                                                                                                                                                        
![Public Extension Method]                | [FindReferencedClass&lt;T>][61]                                                | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][47].)                                                                                                                                                                                                                                                                 
![Public Extension Method]                | [FirstAncestor(String)][62]                                                    | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][47].)                                                                                                                                                                                                                                                  
![Public Extension Method]                | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][63]                                | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][47].)                                                                                                                                                                                                                                    
![Public Extension Method]                | [FirstAncestor&lt;T>()][64]                                                    | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][47].)                                                                                                                                                                                                                                                       
![Public Extension Method]                | [FrameAttribute][65]                                                           | Gets a defined FrameAttribute from the [Attribute][4] collection of the [IObjectWithAttributes][5]. If no such attribute exists, `null` is returned. (Defined by [AmlObjectsExtensions][45].)                                                                                                                                                                                            
![Public Extension Method]                | [GetAttribute][66]                                                             | Gets the first attribute with the specified name from the attribute collection of the CAEX object. (Defined by [ObjectWithAttributes][42].)                                                                                                                                                                                                                                              
![Public Extension Method]                | [getAttributeField][67]                                                        | Get the whole attribute field containing a collection of all attributes of this object. (Defined by [AMLEngineAdapter][50].)                                                                                                                                                                                                                                                             
![Public Extension Method]                | [GetAttributeValue][68]                                                        | Returns an attribute value of a given attribute name. (Defined by [AMLEngineAdapter][50].)                                                                                                                                                                                                                                                                                               
![Public Extension Method]                | [GetDerivedAttributes][69]                                                     | Gets a list of Attribute objects that are inherited from base classes. The List will also contain the elements own Attribute objects, if the parameter is set (default). If an Attribute is overwritten, only the last defined is contained. (Defined by [ObjectWithBaseClass][58].)                                                                                                     
![Public Extension Method]                | [GetFullNodePath][70]                                                          | Gets the full node path of the provided CAEX object, which includes the object names of all ancestor hierarchy levels and the name of the object itself. (Defined by [CAEXObjectExtensions][71].)                                                                                                                                                                                        
![Public Extension Method]                | [GetInheritedAttributes][72]                                                   | Gets a collection of Attribute objects that are inherited from base classes. The own attributes are included in the enumeration. (Defined by [ObjectWithBaseClass][58].)                                                                                                                                                                                                                 
![Public Extension Method]                | [GetInheritedAttributesAndDescendants][73]                                     | Gets a list of Attribute objects that are inherited from base classes. The List will also contain the elements own Attribute objects, if the parameter is set (default). If an Attribute is overwritten, only the last defined is contained. (Defined by [ObjectWithBaseClass][58].)                                                                                                     
![Public Extension Method]                | [GetParent&lt;T>][74]                                                          | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][47].)                                                                                                                                                                                 
![Public Extension Method]                | [InheritedElements&lt;TInheritedElement>][75]                                  | Gets a collection of objects of the defined InheritedElement-Type that are inherited from base classes. (Defined by [ObjectWithBaseClass][58].)                                                                                                                                                                                                                                          
![Public Extension Method]                | [Insert_Attribute][76]                                                         | Inserts an Attribute object in the Attribute collection of the *objectWithAttributes*. (Defined by [SystemUnitClassTypeExtensions][77].)                                                                                                                                                                                                                                                 
![Public Extension Method]                | [IsAMLObject][78]                                                              | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][45].) 
![Public Extension Method]                | [IsInherited][79]                                                              | Determines, if the specified element is an inherited element. To be an inherited element, it has to be an AttributeType, ExternalInterfaceType or InternalElementType element. (Defined by [ObjectWithBaseClass][58].)                                                                                                                                                                   
![Public Extension Method]                | [IsOverridden][80]                                                             | Determines, if an element of a class with an inheritance relation to a base class is an overridden element, what means a base class contains an element which is considered as equal to the provided element. In most cases, equality is defined by equality of the element names. (Defined by [ObjectWithBaseClass][58].)                                                               
![Public Extension Method]                | [Library][81]                                                                  | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][47].)                                                                                                                                                                                                                                                                                          
![Public Extension Method]                | [New_Attribute][82]                                                            | Appends a new Attribute object with the defined name to the specified CAEX object. (Defined by [ObjectWithAttributes][42].)                                                                                                                                                                                                                                                              
![Public Extension Method]                | [New_Copyright][83]                                                            | Adds an new Copyright node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][47].)                                                                                                                                                                                                                                                                            
![Public Extension Method]                | [New_FrameAttribute][84]                                                       | Creates a new Frame attribute for the [IObjectWithAttributes][5] if no Frame attribute exists. The provided values are used to initialize the Frame attribute values. (Defined by [AmlObjectsExtensions][45].)                                                                                                                                                                           
![Public Extension Method]                | [New_Version][85]                                                              | Adds an new Version node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][47].)                                                                                                                                                                                                                                                                              
![Public Extension Method]                | [OverriddenElement][86]                                                        | Determines, if an element of a class with an inheritance relation to a base class has an overridden element with the specified name and type, what means a base class contains an element which name is equal to the provided elementName. (Defined by [ObjectWithBaseClass][58].)                                                                                                       
![Public Extension Method]                | [ReferencedClassName][87]                                                      | Name of the referenced Class without path information. (Defined by [ObjectWithBaseClass][58].)                                                                                                                                                                                                                                                                                           
![Public Extension Method]                | [RefTypeAttribute][88]                                                         | Gets the RefTypeAttribute from the *objectWithAttributes* if one exists. (Defined by [AmlObjectsExtensions][45].)                                                                                                                                                                                                                                                                        
![Public Extension Method]                | [RefURIAttribute][89]                                                          | Gets the RefURIAttribute from the *objectWithAttributes* if one exists. (Defined by [AmlObjectsExtensions][45].)                                                                                                                                                                                                                                                                         
![Public Extension Method]                | [SetAttributeValue(String, String)][90]                                        | Overloaded. Sets the value for the attribute with the specified name from the attribute collection of the CAEX object. If no attribute with that name exists, it is created. (Defined by [ObjectWithAttributes][42].)                                                                                                                                                                    
![Public Extension Method]                | [SetAttributeValue(String, Double)][91]                                        | Overloaded. Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created. Sets the AttributeDataType to xs:double (Defined by [ObjectWithAttributes][42].)                                                                                                           
![Public Extension Method]                | [SetAttributeValue(String, String, String, String)][92]                        | Overloaded. Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created. (Defined by [ObjectWithAttributes][42].)                                                                                                                                                   
![Public Extension Method]                | [SetAttributeValue(String, Double, Double, String, String)][93]                | Overloaded. Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created. Sets the AttributeDataType to xs:double (Defined by [ObjectWithAttributes][42].)                                                                                                           
![Public Extension Method]                | [SetAttributeValue(String, String, String, String, String, String)][94]        | Overloaded. Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created. (Defined by [ObjectWithAttributes][42].)                                                                                                                                                   
![Public Extension Method]                | [SetDescription][95]                                                           | This method sets a description. If no description exists, it is created. (Defined by [CAEXObjectExtensions][71].)                                                                                                                                                                                                                                                                        


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][1]  
[Aml.Engine.CAEX.IObjectWithAttributes][5]  
[Aml.Engine.CAEX.ICAEXObject][18]  

[1]: ../README.md
[2]: ../ICAEXBasicObject/AdditionalInformation.md
[3]: ../ICAEXBasicObject/README.md
[4]: ../IObjectWithAttributes/Attribute.md
[5]: ../IObjectWithAttributes/README.md
[6]: ../IObjectWithAttributes/AttributeAndDescendants.md
[7]: ../ICAEXWrapper/CAEXParent.md
[8]: ../ICAEXWrapper/README.md
[9]: ../ICAEXBasicObject/ChangeMode.md
[10]: ../ICAEXBasicObject/Copyright.md
[11]: ../ICAEXBasicObject/CopyrightElement.md
[12]: ../ICAEXBasicObject/Description.md
[13]: ../ICAEXBasicObject/DescriptionElement.md
[14]: ../../Aml.Engine.XML/IXMLWrapper/Document.md
[15]: ../../Aml.Engine.XML/IXMLWrapper/README.md
[16]: ../../Aml.Engine.XML/IXMLWrapper/Exists.md
[17]: ../ICAEXObject/ID.md
[18]: ../ICAEXObject/README.md
[19]: ../ICAEXObject/Name.md
[20]: ../../Aml.Engine.XML/IXMLWrapper/Node.md
[21]: ../../Aml.Engine.XML/IXMLWrapper/Owner.md
[22]: RefBaseClassPath.md
[23]: ReferencedClassName.md
[24]: ../ICAEXBasicObject/Revision.md
[25]: ../ICAEXBasicObject/SourceObjectInformation.md
[26]: ../../Aml.Engine.XML/IXMLWrapper/TagName.md
[27]: ../ICAEXBasicObject/Version.md
[28]: ../ICAEXBasicObject/VersionElement.md
[29]: ../ICAEXWrapper/CAEXChild.md
[30]: ../ICAEXWrapper/CAEXChildren.md
[31]: ../ICAEXObject/CAEXPath.md
[32]: ../../Aml.Engine.CAEX.Extensions/CAEXPathBuilder/README.md
[33]: ../ICAEXBasicObject/CAEXSequence.md
[34]: ../ICAEXBasicObject/Container__1.md
[35]: GetReferenceHierarchy__1.md
[36]: ../ICAEXBasicObject/Insert_1.md
[37]: ../ICAEXBasicObject/Insert.md
[38]: ../ICAEXBasicObject/New_Revision.md
[39]: ../ICAEXWrapper/Remove.md
[40]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/AddAttributeTypeReference_1.md
[41]: ../AttributeType/README.md
[42]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/README.md
[43]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/AddAttributeTypeReference.md
[44]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/AMLAttributes.md
[45]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[46]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/AMLSchemaManager.md
[47]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[48]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Ancestors__1.md
[49]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Attributes.md
[50]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[51]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXDocument.md
[52]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXFile.md
[53]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXSchema.md
[54]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/CopyAttributesFrom.md
[55]: ../../Aml.Engine.AmlObjects/ListAttribute/CreateListAttribute.md
[56]: ../../Aml.Engine.AmlObjects/ListAttribute/README.md
[57]: ../../Aml.Engine.CAEX.Extensions/ObjectWithBaseClass/DeleteInheritedElement.md
[58]: ../../Aml.Engine.CAEX.Extensions/ObjectWithBaseClass/README.md
[59]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[60]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[61]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[62]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[63]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[64]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[65]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/FrameAttribute.md
[66]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/GetAttribute.md
[67]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getAttributeField.md
[68]: ../../Aml.Engine.Adapter/AMLEngineAdapter/GetAttributeValue.md
[69]: ../../Aml.Engine.CAEX.Extensions/ObjectWithBaseClass/GetDerivedAttributes.md
[70]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/GetFullNodePath.md
[71]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/README.md
[72]: ../../Aml.Engine.CAEX.Extensions/ObjectWithBaseClass/GetInheritedAttributes.md
[73]: ../../Aml.Engine.CAEX.Extensions/ObjectWithBaseClass/GetInheritedAttributesAndDescendants.md
[74]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/GetParent__1.md
[75]: ../../Aml.Engine.CAEX.Extensions/ObjectWithBaseClass/InheritedElements__1.md
[76]: ../../Aml.Engine.CAEX.Extensions/SystemUnitClassTypeExtensions/Insert_Attribute.md
[77]: ../../Aml.Engine.CAEX.Extensions/SystemUnitClassTypeExtensions/README.md
[78]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsAMLObject.md
[79]: ../../Aml.Engine.CAEX.Extensions/ObjectWithBaseClass/IsInherited.md
[80]: ../../Aml.Engine.CAEX.Extensions/ObjectWithBaseClass/IsOverridden.md
[81]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Library.md
[82]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/New_Attribute.md
[83]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Copyright.md
[84]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/New_FrameAttribute.md
[85]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Version.md
[86]: ../../Aml.Engine.CAEX.Extensions/ObjectWithBaseClass/OverriddenElement.md
[87]: ../../Aml.Engine.CAEX.Extensions/ObjectWithBaseClass/ReferencedClassName.md
[88]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/RefTypeAttribute.md
[89]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/RefURIAttribute.md
[90]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/SetAttributeValue_2.md
[91]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/SetAttributeValue.md
[92]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/SetAttributeValue_3.md
[93]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/SetAttributeValue_1.md
[94]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/SetAttributeValue_4.md
[95]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/SetDescription.md
[96]: https://www.automationml.org
[97]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"
[Code example]: ../../icons/CodeExample.png "Code example"