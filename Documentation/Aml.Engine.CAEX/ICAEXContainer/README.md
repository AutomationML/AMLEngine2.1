ICAEXContainer Interface
========================
AutomationML 2.1 APIThis interface is defined for CAEXObjects, which may contain different types of CAEX objects like the [SystemUnitClassType][1]. The defined methods allow the selection of the associated container for a specific type and the insertion of a CAEX object to its associated container.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public interface ICAEXContainer : ICAEXWrapper, 
	IXMLWrapper
```

The **ICAEXContainer** type exposes the following members.


Properties
----------

                   | Name            | Description                                                                                                                                                                                                                                               
------------------ | --------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [CAEXParent][3] | Gets the CAEXParent of this CAEX object (Inherited from [ICAEXWrapper][4].)                                                                                                                                                                               
![Public property] | [Document][5]   | Gets the XDocument containing the XML node of this object. If the object has not been inserted into a document, the XDocument is `null`. Direct manipulations of the XML document are not monitored by the AML engine. (Inherited from [IXMLWrapper][6].) 
![Public property] | [Exists][7]     | Determines, if this instance is wrapped around an existing XML node (Inherited from [IXMLWrapper][6].)                                                                                                                                                    
![Public property] | [Node][8]       | Get the XML node of this instance. Direct manipulations of the XML node are not monitored by the AML engine. (Inherited from [IXMLWrapper][6].)                                                                                                           
![Public property] | [Owner][9]      | Gets the XML parent node of this instance. Direct manipulations of the XML node are not monitored by the AML engine. (Inherited from [IXMLWrapper][6].)                                                                                                   
![Public property] | [TagName][10]   | Gets the Schema Tag name of this instance. (Inherited from [IXMLWrapper][6].)                                                                                                                                                                             


Methods
-------

                 | Name               | Description                                                                                                  
---------------- | ------------------ | ------------------------------------------------------------------------------------------------------------ 
![Public method] | [CAEXChild][11]    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [ICAEXWrapper][4].) 
![Public method] | [CAEXChildren][12] | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [ICAEXWrapper][4].)    
![Public method] | [Insert][13]       | Inserts the specified CAEX object in its associated container.                                               
![Public method] | [Remove][14]       | Removes this object (Inherited from [ICAEXWrapper][4].)                                                      


Extension Methods
-----------------

                           | Name                                            | Description                                                                                                                                                                                                                                                                                                                                                                              
-------------------------- | ----------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [AMLSchemaManager][15]                          | Gets the associated CAEX schema manager of the CAEX object. (Defined by [CAEXBasicObjectExtensions][16].)                                                                                                                                                                                                                                                                                
![Public Extension Method] | [Ancestors&lt;T>][17]                           | Finds the ancestors of the provided CAEX object which have the given type. (Defined by [CAEXBasicObjectExtensions][16].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [CAEXDocument][18]                              | Gets the CAEX document which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][16].)                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [CAEXFile][19]                                  | Gets the CAEX file which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][16].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [CAEXSchema][20]                                | Gets the associated CAEX schema of the CAEX object. (Defined by [CAEXBasicObjectExtensions][16].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [Descendants&lt;T>][21]                         | Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][16].)                                                                                                                                                                                                                                                             
![Public Extension Method] | [FindCaexObjectFromId&lt;T>][22]                | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][16].)                                                                                                                                                                                                                                                                        
![Public Extension Method] | [FindReferencedClass&lt;T>][23]                 | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][16].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [FirstAncestor(String)][24]                     | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][16].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][25] | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][16].)                                                                                                                                                                                                                                    
![Public Extension Method] | [FirstAncestor&lt;T>()][26]                     | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][16].)                                                                                                                                                                                                                                                       
![Public Extension Method] | [GetParent&lt;T>][27]                           | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][16].)                                                                                                                                                                                 
![Public Extension Method] | [IsAMLObject][28]                               | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][29].) 
![Public Extension Method] | [Library][30]                                   | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][16].)                                                                                                                                                                                                                                                                                          


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][2]  
[Aml.Engine.CAEX.ICAEXWrapper][4]  

[1]: ../SystemUnitClassType/README.md
[2]: ../README.md
[3]: ../ICAEXWrapper/CAEXParent.md
[4]: ../ICAEXWrapper/README.md
[5]: ../../Aml.Engine.XML/IXMLWrapper/Document.md
[6]: ../../Aml.Engine.XML/IXMLWrapper/README.md
[7]: ../../Aml.Engine.XML/IXMLWrapper/Exists.md
[8]: ../../Aml.Engine.XML/IXMLWrapper/Node.md
[9]: ../../Aml.Engine.XML/IXMLWrapper/Owner.md
[10]: ../../Aml.Engine.XML/IXMLWrapper/TagName.md
[11]: ../ICAEXWrapper/CAEXChild.md
[12]: ../ICAEXWrapper/CAEXChildren.md
[13]: Insert.md
[14]: ../ICAEXWrapper/Remove.md
[15]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/AMLSchemaManager.md
[16]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[17]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Ancestors__1.md
[18]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXDocument.md
[19]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXFile.md
[20]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXSchema.md
[21]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[22]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[23]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[24]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[25]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[26]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[27]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/GetParent__1.md
[28]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsAMLObject.md
[29]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[30]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Library.md
[31]: https://www.automationml.org
[32]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"