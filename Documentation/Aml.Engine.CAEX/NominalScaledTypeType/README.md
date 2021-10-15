NominalScaledTypeType Class
===========================
This class is a wrapper for the CAEXElement 'NominalScaledType" which defined a list of required values for an attribute constraint.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.CAEXWrapper][2]  
    **Aml.Engine.CAEX.NominalScaledTypeType**  

  **Namespace:**  [Aml.Engine.CAEX][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class NominalScaledTypeType : CAEXWrapper, 
	IAttributeValueType, ICAEXWrapper, IXMLWrapper
```

The **NominalScaledTypeType** type exposes the following members.


Constructors
------------

                 | Name                       | Description                                                        
---------------- | -------------------------- | ------------------------------------------------------------------ 
![Public method] | [NominalScaledTypeType][4] | Initializes a new instance of the **NominalScaledTypeType** class. 


Properties
----------

                   | Name                                | Description                                                                                                                                                                                         
------------------ | ----------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AttributeDataType][5]              | Gets the AttributeDataType of the defining attribute. The AttributeDataType can be used to interpret the defined nominal values of this instance.                                                   
![Public property] | [AttributeTypeDefiningAttribute][6] | Gets the AttributeType object, defining this instance.                                                                                                                                              
![Public property] | [CAEXDocument][7]                   | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][2].) 
![Public property] | [CAEXParent][8]                     | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][2].)                                                                                                               
![Public property] | [CAEXSequenceOfCAEXObject][9]       | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                
![Public property] | [Document][10]                      | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                    
![Public property] | [Exists][11]                        | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                   
![Public property] | [Item][12]                          | Gets the type-decoded value and sets the type-encoded value for the nominal value attribute with the defined value.                                                                                 
![Public property] | [Node][13]                          | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                     
![Public property] | [Owner][14]                         | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][2].)                                                                                                                            
![Public property] | [RequiredValue][15]                 | Gets the collection of the 'RequiredValue' elements for this nominal scaled attribute constraint.                                                                                                   
![Public property] | [TagName][16]                       | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][2].)                                                                                                              
![Public property] | [ValueAttributes][17]               | Gets a list of [CaexValue][18] corresponding to the associated nominal values of this instance.                                                                                                     


Methods
-------

                 | Name                     | Description                                                                                                                                                                                                                                                                      
---------------- | ------------------------ | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [CAEXChild][19]          | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                      
![Public method] | [CAEXChildren][20]       | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                         
![Public method] | [Copy][21]               | Creates a deep copy of this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                       
![Public method] | [Equals][22]             | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][2].)                                                                                                                                                    
![Public method] | [GetCaexValue][23]       | Gets the [CaexValue][18] for the for the nominal value attribute with the defined value.                                                                                                                                                                                         
![Public method] | [GetHashCode][24]        | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                          
![Public method] | [GetXAttributeValue][25] | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][2].)                                                                                                                                             
![Public method] | [InsertNew][26]          | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][14] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][2].) 
![Public method] | [Remove][27]             | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][2].)                                                                                                                                             
![Public method] | [SetXAttributeValue][28] | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][2].)                                                                                                                                            


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][29] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][2].) 


Extension Methods
-----------------

                           | Name                                            | Description                                                                                                                                                                                                                                                                                                                                                                              
-------------------------- | ----------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [AMLSchemaManager][30]                          | Gets the associated CAEX schema manager of the CAEX object. (Defined by [CAEXBasicObjectExtensions][31].)                                                                                                                                                                                                                                                                                
![Public Extension Method] | [Ancestors&lt;T>][32]                           | Finds the ancestors of the provided CAEX object which have the given type. (Defined by [CAEXBasicObjectExtensions][31].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [CAEXDocument][33]                              | Gets the CAEX document which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][31].)                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [CAEXFile][34]                                  | Gets the CAEX file which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][31].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [CAEXSchema][35]                                | Gets the associated CAEX schema of the CAEX object. (Defined by [CAEXBasicObjectExtensions][31].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [Descendants(Type)][36]                         | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][31].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [Descendants&lt;T>()][37]                       | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][31].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [Descendants&lt;T>(Boolean)][38]                | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][31].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [FindCaexObjectFromId&lt;T>][39]                | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][31].)                                                                                                                                                                                                                                                                        
![Public Extension Method] | [FindReferencedClass&lt;T>][40]                 | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][31].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [FirstAncestor(String)][41]                     | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][31].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][42] | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][31].)                                                                                                                                                                                                                                    
![Public Extension Method] | [FirstAncestor&lt;T>()][43]                     | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][31].)                                                                                                                                                                                                                                                       
![Public Extension Method] | [GetParent&lt;T>][44]                           | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][31].)                                                                                                                                                                                 
![Public Extension Method] | [IsAMLObject][45]                               | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][46].) 
![Public Extension Method] | [Library][47]                                   | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][31].)                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [Name][48]                                      | Gets a names for the specified CAEX wrapper object. If the specified object is a [CAEXObject][49], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][31].)                                                                                                                                                                           
![Public Extension Method] | [New_RequiredValue][50]                         | Adds a new required value to the NominalScaledType Constraint. (Defined by [AMLEngineAdapter][51].)                                                                                                                                                                                                                                                                                      


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][3]  
[Aml.Engine.CAEX.CAEXWrapper][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../CAEXWrapper/README.md
[3]: ../README.md
[4]: _ctor.md
[5]: AttributeDataType.md
[6]: AttributeTypeDefiningAttribute.md
[7]: ../CAEXWrapper/CAEXDocument.md
[8]: ../CAEXWrapper/CAEXParent.md
[9]: ../CAEXWrapper/CAEXSequenceOfCAEXObject.md
[10]: ../CAEXWrapper/Document.md
[11]: ../CAEXWrapper/Exists.md
[12]: Item.md
[13]: ../CAEXWrapper/Node.md
[14]: ../CAEXWrapper/Owner.md
[15]: RequiredValue.md
[16]: ../CAEXWrapper/TagName.md
[17]: ValueAttributes.md
[18]: ../../Aml.Engine.CAEX.Extensions/CaexValue/README.md
[19]: ../CAEXWrapper/CAEXChild.md
[20]: ../CAEXWrapper/CAEXChildren.md
[21]: ../CAEXWrapper/Copy.md
[22]: ../CAEXWrapper/Equals.md
[23]: GetCaexValue.md
[24]: ../CAEXWrapper/GetHashCode.md
[25]: ../CAEXWrapper/GetXAttributeValue.md
[26]: ../CAEXWrapper/InsertNew.md
[27]: ../CAEXWrapper/Remove.md
[28]: ../CAEXWrapper/SetXAttributeValue.md
[29]: ../CAEXWrapper/PropertyChanged.md
[30]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/AMLSchemaManager.md
[31]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[32]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Ancestors__1.md
[33]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXDocument.md
[34]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXFile.md
[35]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXSchema.md
[36]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[37]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[38]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[39]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[40]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[41]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[42]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[43]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[44]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/GetParent__1.md
[45]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsAMLObject.md
[46]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[47]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Library.md
[48]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[49]: ../CAEXObject/README.md
[50]: ../../Aml.Engine.Adapter/AMLEngineAdapter/New_RequiredValue.md
[51]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[52]: https://www.automationml.org
[53]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"