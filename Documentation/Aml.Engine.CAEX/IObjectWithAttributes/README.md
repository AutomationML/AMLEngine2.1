IObjectWithAttributes Interface
===============================
Interface that defines methods and properties that apply to all classes that are able to contain attributes.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public interface IObjectWithAttributes : ICAEXWrapper, 
	IXMLWrapper
```

The **IObjectWithAttributes** type exposes the following members.


Properties
----------

                   | Name                         | Description                                                                                                                                                                                                                                               
------------------ | ---------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [Attribute][2]               | Get the collection of all attributes of this object. Inherited Attributes are not included.                                                                                                                                                               
![Public property] | [AttributeAndDescendants][3] | Gets the attributes and all nested attributes.                                                                                                                                                                                                            
![Public property] | [CAEXParent][4]              | Gets the CAEXParent of this CAEX object (Inherited from [ICAEXWrapper][5].)                                                                                                                                                                               
![Public property] | [Document][6]                | Gets the XDocument containing the XML node of this object. If the object has not been inserted into a document, the XDocument is `null`. Direct manipulations of the XML document are not monitored by the AML engine. (Inherited from [IXMLWrapper][7].) 
![Public property] | [Exists][8]                  | Determines, if this instance is wrapped around an existing XML node (Inherited from [IXMLWrapper][7].)                                                                                                                                                    
![Public property] | [Node][9]                    | Get the XML node of this instance. Direct manipulations of the XML node are not monitored by the AML engine. (Inherited from [IXMLWrapper][7].)                                                                                                           
![Public property] | [Owner][10]                  | Gets the XML parent node of this instance. Direct manipulations of the XML node are not monitored by the AML engine. (Inherited from [IXMLWrapper][7].)                                                                                                   
![Public property] | [TagName][11]                | Gets the Schema Tag name of this instance. (Inherited from [IXMLWrapper][7].)                                                                                                                                                                             


Methods
-------

                 | Name               | Description                                                                                                  
---------------- | ------------------ | ------------------------------------------------------------------------------------------------------------ 
![Public method] | [CAEXChild][12]    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [ICAEXWrapper][5].) 
![Public method] | [CAEXChildren][13] | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [ICAEXWrapper][5].)    
![Public method] | [Remove][14]       | Removes this object (Inherited from [ICAEXWrapper][5].)                                                      


Extension Methods
-----------------

                                          | Name                                                                           | Description                                                                                                                                                                                                                                                                                                                                                                              
----------------------------------------- | ------------------------------------------------------------------------------ | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method]![Code example] | [AddAttributeTypeReference(String, Boolean, Boolean, String)][15]              | Overloaded. Adds an AttributeType reference to this ObjectWithAttribute using the provided CAEX path, referencing an AttributeType object. The AttributeType reference is added as a [AttributeType][16] object. (Defined by [ObjectWithAttributes][17].)                                                                                                                                
![Public Extension Method]![Code example] | [AddAttributeTypeReference(AttributeFamilyType, Boolean, Boolean, String)][18] | Overloaded. Adds an AttributeType reference to this ObjectWithAttribute using the provided AttributeType object. The AttributeType reference is added as a [AttributeType][16] object. (Defined by [ObjectWithAttributes][17].)                                                                                                                                                          
![Public Extension Method]                | [AMLAttributes][19]                                                            | Conversion of any object which has an attribute collection to get access to specific AutomationML defined attributes. (Defined by [AmlObjectsExtensions][20].)                                                                                                                                                                                                                           
![Public Extension Method]                | [AMLSchemaManager][21]                                                         | Gets the associated CAEX schema manager of the CAEX object. (Defined by [CAEXBasicObjectExtensions][22].)                                                                                                                                                                                                                                                                                
![Public Extension Method]                | [Ancestors&lt;T>][23]                                                          | Finds the ancestors of the provided CAEX object which have the given type. (Defined by [CAEXBasicObjectExtensions][22].)                                                                                                                                                                                                                                                                 
![Public Extension Method]                | [Attributes][24]                                                               | Enumeration Method for direct Children of Type [AttributeType][16] (Defined by [AMLEngineAdapter][25].)                                                                                                                                                                                                                                                                                  
![Public Extension Method]                | [CAEXDocument][26]                                                             | Gets the CAEX document which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][22].)                                                                                                                                                                                                                                                                                    
![Public Extension Method]                | [CAEXFile][27]                                                                 | Gets the CAEX file which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][22].)                                                                                                                                                                                                                                                                                        
![Public Extension Method]                | [CAEXSchema][28]                                                               | Gets the associated CAEX schema of the CAEX object. (Defined by [CAEXBasicObjectExtensions][22].)                                                                                                                                                                                                                                                                                        
![Public Extension Method]                | [CopyAttributesFrom][29]                                                       | Copies all attribute of the source object with attributes to the target object including children (Defined by [ObjectWithAttributes][17].)                                                                                                                                                                                                                                               
![Public Extension Method]                | [CreateListAttribute][30]                                                      | Creates a new list attribute for an element which can have attributes. (Defined by [ListAttribute][31].)                                                                                                                                                                                                                                                                                 
![Public Extension Method]                | [Descendants&lt;T>][32]                                                        | Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][22].)                                                                                                                                                                                                                                                             
![Public Extension Method]                | [FindCaexObjectFromId&lt;T>][33]                                               | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][22].)                                                                                                                                                                                                                                                                        
![Public Extension Method]                | [FindReferencedClass&lt;T>][34]                                                | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][22].)                                                                                                                                                                                                                                                                 
![Public Extension Method]                | [FirstAncestor(String)][35]                                                    | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][22].)                                                                                                                                                                                                                                                  
![Public Extension Method]                | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][36]                                | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][22].)                                                                                                                                                                                                                                    
![Public Extension Method]                | [FirstAncestor&lt;T>()][37]                                                    | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][22].)                                                                                                                                                                                                                                                       
![Public Extension Method]                | [FrameAttribute][38]                                                           | Gets a defined FrameAttribute from the [Attribute][2] collection of the **IObjectWithAttributes**. If no such attribute exists, `null` is returned. (Defined by [AmlObjectsExtensions][20].)                                                                                                                                                                                             
![Public Extension Method]                | [GetAttribute][39]                                                             | Gets the first attribute with the specified name from the attribute collection of the CAEX object. (Defined by [ObjectWithAttributes][17].)                                                                                                                                                                                                                                              
![Public Extension Method]                | [getAttributeField][40]                                                        | Get the whole attribute field containing a collection of all attributes of this object. (Defined by [AMLEngineAdapter][25].)                                                                                                                                                                                                                                                             
![Public Extension Method]                | [GetAttributeValue][41]                                                        | Returns an attribute value of a given attribute name. (Defined by [AMLEngineAdapter][25].)                                                                                                                                                                                                                                                                                               
![Public Extension Method]                | [GetParent&lt;T>][42]                                                          | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][22].)                                                                                                                                                                                 
![Public Extension Method]                | [Insert_Attribute][43]                                                         | Inserts an Attribute object in the Attribute collection of the *objectWithAttributes*. (Defined by [SystemUnitClassTypeExtensions][44].)                                                                                                                                                                                                                                                 
![Public Extension Method]                | [IsAMLObject][45]                                                              | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][20].) 
![Public Extension Method]                | [Library][46]                                                                  | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][22].)                                                                                                                                                                                                                                                                                          
![Public Extension Method]                | [New_Attribute][47]                                                            | Appends a new Attribute object with the defined name to the specified CAEX object. (Defined by [ObjectWithAttributes][17].)                                                                                                                                                                                                                                                              
![Public Extension Method]                | [New_FrameAttribute][48]                                                       | Creates a new Frame attribute for the **IObjectWithAttributes** if no Frame attribute exists. The provided values are used to initialize the Frame attribute values. (Defined by [AmlObjectsExtensions][20].)                                                                                                                                                                            
![Public Extension Method]                | [RefTypeAttribute][49]                                                         | Gets the RefTypeAttribute from the *objectWithAttributes* if one exists. (Defined by [AmlObjectsExtensions][20].)                                                                                                                                                                                                                                                                        
![Public Extension Method]                | [RefURIAttribute][50]                                                          | Gets the RefURIAttribute from the *objectWithAttributes* if one exists. (Defined by [AmlObjectsExtensions][20].)                                                                                                                                                                                                                                                                         
![Public Extension Method]                | [SetAttributeValue(String, String)][51]                                        | Overloaded. Sets the value for the attribute with the specified name from the attribute collection of the CAEX object. If no attribute with that name exists, it is created. (Defined by [ObjectWithAttributes][17].)                                                                                                                                                                    
![Public Extension Method]                | [SetAttributeValue(String, Double)][52]                                        | Overloaded. Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created. Sets the AttributeDataType to xs:double (Defined by [ObjectWithAttributes][17].)                                                                                                           
![Public Extension Method]                | [SetAttributeValue(String, String, String, String)][53]                        | Overloaded. Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created. (Defined by [ObjectWithAttributes][17].)                                                                                                                                                   
![Public Extension Method]                | [SetAttributeValue(String, Double, Double, String, String)][54]                | Overloaded. Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created. Sets the AttributeDataType to xs:double (Defined by [ObjectWithAttributes][17].)                                                                                                           
![Public Extension Method]                | [SetAttributeValue(String, String, String, String, String, String)][55]        | Overloaded. Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created. (Defined by [ObjectWithAttributes][17].)                                                                                                                                                   


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][1]  
[Aml.Engine.CAEX.ICAEXWrapper][5]  

[1]: ../README.md
[2]: Attribute.md
[3]: AttributeAndDescendants.md
[4]: ../ICAEXWrapper/CAEXParent.md
[5]: ../ICAEXWrapper/README.md
[6]: ../../Aml.Engine.XML/IXMLWrapper/Document.md
[7]: ../../Aml.Engine.XML/IXMLWrapper/README.md
[8]: ../../Aml.Engine.XML/IXMLWrapper/Exists.md
[9]: ../../Aml.Engine.XML/IXMLWrapper/Node.md
[10]: ../../Aml.Engine.XML/IXMLWrapper/Owner.md
[11]: ../../Aml.Engine.XML/IXMLWrapper/TagName.md
[12]: ../ICAEXWrapper/CAEXChild.md
[13]: ../ICAEXWrapper/CAEXChildren.md
[14]: ../ICAEXWrapper/Remove.md
[15]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/AddAttributeTypeReference_1.md
[16]: ../AttributeType/README.md
[17]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/README.md
[18]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/AddAttributeTypeReference.md
[19]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/AMLAttributes.md
[20]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[21]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/AMLSchemaManager.md
[22]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[23]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Ancestors__1.md
[24]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Attributes.md
[25]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[26]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXDocument.md
[27]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXFile.md
[28]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXSchema.md
[29]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/CopyAttributesFrom.md
[30]: ../../Aml.Engine.AmlObjects/ListAttribute/CreateListAttribute.md
[31]: ../../Aml.Engine.AmlObjects/ListAttribute/README.md
[32]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[33]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[34]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[35]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[36]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[37]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[38]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/FrameAttribute.md
[39]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/GetAttribute.md
[40]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getAttributeField.md
[41]: ../../Aml.Engine.Adapter/AMLEngineAdapter/GetAttributeValue.md
[42]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/GetParent__1.md
[43]: ../../Aml.Engine.CAEX.Extensions/SystemUnitClassTypeExtensions/Insert_Attribute.md
[44]: ../../Aml.Engine.CAEX.Extensions/SystemUnitClassTypeExtensions/README.md
[45]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsAMLObject.md
[46]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Library.md
[47]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/New_Attribute.md
[48]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/New_FrameAttribute.md
[49]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/RefTypeAttribute.md
[50]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/RefURIAttribute.md
[51]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/SetAttributeValue_2.md
[52]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/SetAttributeValue.md
[53]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/SetAttributeValue_3.md
[54]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/SetAttributeValue_1.md
[55]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/SetAttributeValue_4.md
[56]: https://www.automationml.org
[57]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"
[Code example]: ../../icons/CodeExample.png "Code example"