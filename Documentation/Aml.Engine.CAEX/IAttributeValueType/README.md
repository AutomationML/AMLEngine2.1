IAttributeValueType Interface
=============================
AutomationML 2.1 APIThis Interface is implemented by CAEX elements which contain Value properties. With the specified properties and methods it is possible to convert attribute values according to an existing attribute data type into a type based object. The type conversion is supported by a new class [CaexValue][1].

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public interface IAttributeValueType : ICAEXWrapper, 
	IXMLWrapper
```

The **IAttributeValueType** type exposes the following members.


Properties
----------

                   | Name                                | Description                                                                                                                                                                                                                                               
------------------ | ----------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AttributeDataType][3]              | Gets the Attribute datatype which is valid for all attribute values of this element                                                                                                                                                                       
![Public property] | [AttributeTypeDefiningAttribute][4] | Gets the attribute, which specifies the attribute data type for the attribute values.                                                                                                                                                                     
![Public property] | [CAEXParent][5]                     | Gets the CAEXParent of this CAEX object (Inherited from [ICAEXWrapper][6].)                                                                                                                                                                               
![Public property] | [Document][7]                       | Gets the XDocument containing the XML node of this object. If the object has not been inserted into a document, the XDocument is `null`. Direct manipulations of the XML document are not monitored by the AML engine. (Inherited from [IXMLWrapper][8].) 
![Public property] | [Exists][9]                         | Determines, if this instance is wrapped around an existing XML node (Inherited from [IXMLWrapper][8].)                                                                                                                                                    
![Public property] | [Item][10]                          | Gets and sets the attribute value for the named attribute using the decoding and encoding methods of [CaexValue][1].                                                                                                                                      
![Public property] | [Node][11]                          | Get the XML node of this instance. Direct manipulations of the XML node are not monitored by the AML engine. (Inherited from [IXMLWrapper][8].)                                                                                                           
![Public property] | [Owner][12]                         | Gets the XML parent node of this instance. Direct manipulations of the XML node are not monitored by the AML engine. (Inherited from [IXMLWrapper][8].)                                                                                                   
![Public property] | [TagName][13]                       | Gets the Schema Tag name of this instance. (Inherited from [IXMLWrapper][8].)                                                                                                                                                                             
![Public property] | [ValueAttributes][14]               | Gets all the CAEXValue objects for the defined value attributes of this instance.                                                                                                                                                                         


Methods
-------

                 | Name               | Description                                                                                                                                            
---------------- | ------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public method] | [CAEXChild][15]    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [ICAEXWrapper][6].)                                           
![Public method] | [CAEXChildren][16] | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [ICAEXWrapper][6].)                                              
![Public method] | [GetCaexValue][17] | Gets the CAEXValue for the named value attribute which allows type-coded access to the value property using appropriate encoding and decoding methods. 
![Public method] | [Remove][18]       | Removes this object (Inherited from [ICAEXWrapper][6].)                                                                                                


Extension Methods
-----------------

                           | Name                                            | Description                                                                                                                                                                                                                                                                                                                                                                              
-------------------------- | ----------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [AMLSchemaManager][19]                          | Gets the associated CAEX schema manager of the CAEX object. (Defined by [CAEXBasicObjectExtensions][20].)                                                                                                                                                                                                                                                                                
![Public Extension Method] | [Ancestors&lt;T>][21]                           | Finds the ancestors of the provided CAEX object which have the given type. (Defined by [CAEXBasicObjectExtensions][20].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [CAEXDocument][22]                              | Gets the CAEX document which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][20].)                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [CAEXFile][23]                                  | Gets the CAEX file which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][20].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [CAEXSchema][24]                                | Gets the associated CAEX schema of the CAEX object. (Defined by [CAEXBasicObjectExtensions][20].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [Descendants&lt;T>][25]                         | Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][20].)                                                                                                                                                                                                                                                             
![Public Extension Method] | [FindCaexObjectFromId&lt;T>][26]                | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][20].)                                                                                                                                                                                                                                                                        
![Public Extension Method] | [FindReferencedClass&lt;T>][27]                 | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][20].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [FirstAncestor(String)][28]                     | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][20].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][29] | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][20].)                                                                                                                                                                                                                                    
![Public Extension Method] | [FirstAncestor&lt;T>()][30]                     | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][20].)                                                                                                                                                                                                                                                       
![Public Extension Method] | [GetParent&lt;T>][31]                           | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][20].)                                                                                                                                                                                 
![Public Extension Method] | [IsAMLObject][32]                               | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][33].) 
![Public Extension Method] | [Library][34]                                   | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][20].)                                                                                                                                                                                                                                                                                          


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][2]  
[Aml.Engine.CAEX.ICAEXWrapper][6]  

[1]: ../../Aml.Engine.CAEX.Extensions/CaexValue/README.md
[2]: ../README.md
[3]: AttributeDataType.md
[4]: AttributeTypeDefiningAttribute.md
[5]: ../ICAEXWrapper/CAEXParent.md
[6]: ../ICAEXWrapper/README.md
[7]: ../../Aml.Engine.XML/IXMLWrapper/Document.md
[8]: ../../Aml.Engine.XML/IXMLWrapper/README.md
[9]: ../../Aml.Engine.XML/IXMLWrapper/Exists.md
[10]: Item.md
[11]: ../../Aml.Engine.XML/IXMLWrapper/Node.md
[12]: ../../Aml.Engine.XML/IXMLWrapper/Owner.md
[13]: ../../Aml.Engine.XML/IXMLWrapper/TagName.md
[14]: ValueAttributes.md
[15]: ../ICAEXWrapper/CAEXChild.md
[16]: ../ICAEXWrapper/CAEXChildren.md
[17]: GetCaexValue.md
[18]: ../ICAEXWrapper/Remove.md
[19]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/AMLSchemaManager.md
[20]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[21]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Ancestors__1.md
[22]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXDocument.md
[23]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXFile.md
[24]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXSchema.md
[25]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[26]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[27]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[28]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[29]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[30]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[31]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/GetParent__1.md
[32]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsAMLObject.md
[33]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[34]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Library.md
[35]: https://www.automationml.org
[36]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"