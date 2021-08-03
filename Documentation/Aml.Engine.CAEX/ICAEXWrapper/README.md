ICAEXWrapper Interface
======================
AutomationML 2.1 APIThis interface class is implemented by all CAEX - object classes and defines accessors to the wrapped XML node.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public interface ICAEXWrapper : IXMLWrapper
```

The **ICAEXWrapper** type exposes the following members.


Properties
----------

                   | Name            | Description                                                                                                                                                                                                                                               
------------------ | --------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [CAEXParent][2] | Gets the CAEXParent of this CAEX object                                                                                                                                                                                                                   
![Public property] | [Document][3]   | Gets the XDocument containing the XML node of this object. If the object has not been inserted into a document, the XDocument is `null`. Direct manipulations of the XML document are not monitored by the AML engine. (Inherited from [IXMLWrapper][4].) 
![Public property] | [Exists][5]     | Determines, if this instance is wrapped around an existing XML node (Inherited from [IXMLWrapper][4].)                                                                                                                                                    
![Public property] | [Node][6]       | Get the XML node of this instance. Direct manipulations of the XML node are not monitored by the AML engine. (Inherited from [IXMLWrapper][4].)                                                                                                           
![Public property] | [Owner][7]      | Gets the XML parent node of this instance. Direct manipulations of the XML node are not monitored by the AML engine. (Inherited from [IXMLWrapper][4].)                                                                                                   
![Public property] | [TagName][8]    | Gets the Schema Tag name of this instance. (Inherited from [IXMLWrapper][4].)                                                                                                                                                                             


Methods
-------

                 | Name               | Description                                                              
---------------- | ------------------ | ------------------------------------------------------------------------ 
![Public method] | [CAEXChild][9]     | Gets the first child of this CAEX object with the defined CAEX tag name. 
![Public method] | [CAEXChildren][10] | Gets all children of this CAEX object with the defined CAEX tag name.    
![Public method] | [Remove][11]       | Removes this object                                                      


Extension Methods
-----------------

                           | Name                                            | Description                                                                                                                                                                                                                                                                                                                                                                              
-------------------------- | ----------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [AMLSchemaManager][12]                          | Gets the associated CAEX schema manager of the CAEX object. (Defined by [CAEXBasicObjectExtensions][13].)                                                                                                                                                                                                                                                                                
![Public Extension Method] | [Ancestors&lt;T>][14]                           | Finds the ancestors of the provided CAEX object which have the given type. (Defined by [CAEXBasicObjectExtensions][13].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [CAEXDocument][15]                              | Gets the CAEX document which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][13].)                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [CAEXFile][16]                                  | Gets the CAEX file which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][13].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [CAEXSchema][17]                                | Gets the associated CAEX schema of the CAEX object. (Defined by [CAEXBasicObjectExtensions][13].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [Descendants&lt;T>][18]                         | Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][13].)                                                                                                                                                                                                                                                             
![Public Extension Method] | [FindCaexObjectFromId&lt;T>][19]                | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][13].)                                                                                                                                                                                                                                                                        
![Public Extension Method] | [FindReferencedClass&lt;T>][20]                 | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][13].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [FirstAncestor(String)][21]                     | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][13].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][22] | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][13].)                                                                                                                                                                                                                                    
![Public Extension Method] | [FirstAncestor&lt;T>()][23]                     | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][13].)                                                                                                                                                                                                                                                       
![Public Extension Method] | [GetParent&lt;T>][24]                           | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][13].)                                                                                                                                                                                 
![Public Extension Method] | [IsAMLObject][25]                               | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][26].) 
![Public Extension Method] | [Library][27]                                   | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][13].)                                                                                                                                                                                                                                                                                          


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: CAEXParent.md
[3]: ../../Aml.Engine.XML/IXMLWrapper/Document.md
[4]: ../../Aml.Engine.XML/IXMLWrapper/README.md
[5]: ../../Aml.Engine.XML/IXMLWrapper/Exists.md
[6]: ../../Aml.Engine.XML/IXMLWrapper/Node.md
[7]: ../../Aml.Engine.XML/IXMLWrapper/Owner.md
[8]: ../../Aml.Engine.XML/IXMLWrapper/TagName.md
[9]: CAEXChild.md
[10]: CAEXChildren.md
[11]: Remove.md
[12]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/AMLSchemaManager.md
[13]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[14]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Ancestors__1.md
[15]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXDocument.md
[16]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXFile.md
[17]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXSchema.md
[18]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[19]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[20]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[21]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[22]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[23]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[24]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/GetParent__1.md
[25]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsAMLObject.md
[26]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[27]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Library.md
[28]: https://www.automationml.org
[29]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"