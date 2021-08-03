OrdinalScaledTypeType Class
===========================
AutomationML 2.1 APIThis class is a wrapper for the CAEXElement 'OrdinalScaledType" which defined a value range for an attribute constraint.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.CAEXWrapper][2]  
    **Aml.Engine.CAEX.OrdinalScaledTypeType**  

  **Namespace:**  [Aml.Engine.CAEX][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class OrdinalScaledTypeType : CAEXWrapper, 
	IAttributeValueType, ICAEXWrapper, IXMLWrapper
```

The **OrdinalScaledTypeType** type exposes the following members.


Constructors
------------

                 | Name                       | Description                                                        
---------------- | -------------------------- | ------------------------------------------------------------------ 
![Public method] | [OrdinalScaledTypeType][4] | Initializes a new instance of the **OrdinalScaledTypeType** class. 


Properties
----------

                   | Name                                | Description                                                                                                                                                                                                                                                                           
------------------ | ----------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AttributeDataType][5]              | Gets the Attribute datatype which is valid for values of all [ValueAttributes][6] of this element.                                                                                                                                                                                    
![Public property] | [AttributeTypeDefiningAttribute][7] | Gets the attribute, which specifies the attribute data type for the value elements of this instance.                                                                                                                                                                                  
![Public property] | [CAEXDocument][8]                   | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][2].)                                                                                   
![Public property] | [CAEXParent][9]                     | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                 
![Public property] | [CAEXSequenceOfCAEXObject][10]      | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                  
![Public property] | [Document][11]                      | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                      
![Public property] | [Exists][12]                        | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                     
![Public property] | [Item][13]                          | Gets the type-decoded value and sets the type-encoded value for the value attribute with the defined name. The allowed Names are [ATTRIBUTE_CONSTRAINT_ORDINAL_VALUE_STRING][14] and [ATTRIBUTE_CONSTRAINT_ORDINAL_MIN_STRING][15] and [ATTRIBUTE_CONSTRAINT_ORDINAL_MAX_STRING][16]. 
![Public property] | [Node][17]                          | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                       
![Public property] | [Owner][18]                         | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                              
![Public property] | [RequiredMaxValue][19]              | Gets and sets the required maximal value for this ordinal scaled attribute constraint.                                                                                                                                                                                                
![Public property] | [RequiredMinValue][20]              | Gets and sets the required minimal value for this ordinal scaled attribute constraint.                                                                                                                                                                                                
![Public property] | [RequiredValue][21]                 | Gets and sets the required value for this ordinal scaled attribute constraint.                                                                                                                                                                                                        
![Public property] | [TagName][22]                       | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                
![Public property] | [ValueAttributes][6]                | Gets all the CAEXValue objects for the defined value attributes of this instance. Recognized value attributes are [ATTRIBUTE_CONSTRAINT_ORDINAL_MAX_STRING][16] and [ATTRIBUTE_CONSTRAINT_ORDINAL_MIN_STRING][15] and [ATTRIBUTE_CONSTRAINT_ORDINAL_VALUE_STRING][14].                


Methods
-------

                 | Name                     | Description                                                                                                                                                                                                                                                                      
---------------- | ------------------------ | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [CAEXChild][23]          | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                      
![Public method] | [CAEXChildren][24]       | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                         
![Public method] | [Copy][25]               | Creates a deep copy of this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                       
![Public method] | [Equals][26]             | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][2].)                                                                                                                                                    
![Public method] | [GetCaexValue][27]       | Gets the [CaexValue][28] for the value attribute with the defined attribute name. are [ATTRIBUTE_CONSTRAINT_ORDINAL_VALUE_STRING][14] and [ATTRIBUTE_CONSTRAINT_ORDINAL_MIN_STRING][15] and [ATTRIBUTE_CONSTRAINT_ORDINAL_MAX_STRING][16].                                       
![Public method] | [GetHashCode][29]        | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                          
![Public method] | [GetXAttributeValue][30] | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][2].)                                                                                                                                             
![Public method] | [InsertNew][31]          | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][18] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][2].) 
![Public method] | [Remove][32]             | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][2].)                                                                                                                                             
![Public method] | [SetXAttributeValue][33] | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][2].)                                                                                                                                            


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][34] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][2].) 


Extension Methods
-----------------

                           | Name                                            | Description                                                                                                                                                                                                                                                                                                                                                                              
-------------------------- | ----------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [AMLSchemaManager][35]                          | Gets the associated CAEX schema manager of the CAEX object. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                                                                
![Public Extension Method] | [Ancestors&lt;T>][37]                           | Finds the ancestors of the provided CAEX object which have the given type. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [CAEXDocument][38]                              | Gets the CAEX document which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [CAEXFile][39]                                  | Gets the CAEX file which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [CAEXSchema][40]                                | Gets the associated CAEX schema of the CAEX object. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [Descendants(Type)][41]                         | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [Descendants&lt;T>()][42]                       | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [Descendants&lt;T>(Boolean)][43]                | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [FindCaexObjectFromId&lt;T>][44]                | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                                                        
![Public Extension Method] | [FindReferencedClass&lt;T>][45]                 | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [FirstAncestor(String)][46]                     | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][47] | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                    
![Public Extension Method] | [FirstAncestor&lt;T>()][48]                     | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                                       
![Public Extension Method] | [GetParent&lt;T>][49]                           | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                 
![Public Extension Method] | [IsAMLObject][50]                               | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][51].) 
![Public Extension Method] | [Library][52]                                   | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [Name][53]                                      | Gets a names for the specified caex wrapper object. If the specified object is a [CAEXObject][54], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                           
![Public Extension Method] | [New_RequiredMaxValue][55]                      | Adding a new RequiredMaxValue to this ordinal scaled constraint (Defined by [AMLEngineAdapter][56].)                                                                                                                                                                                                                                                                                     
![Public Extension Method] | [New_RequiredMinValue][57]                      | Adding a new RequiredMinValue to this ordinal scaled constraint (Defined by [AMLEngineAdapter][56].)                                                                                                                                                                                                                                                                                     
![Public Extension Method] | [New_RequiredValue][58]                         | Adding a new RequiredValue to this ordinal scaled constraint (Defined by [AMLEngineAdapter][56].)                                                                                                                                                                                                                                                                                        


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][3]  
[Aml.Engine.CAEX.CAEXWrapper][2]  
[Aml.Engine.CAEX.IAttributeValueType][59]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../CAEXWrapper/README.md
[3]: ../README.md
[4]: _ctor.md
[5]: AttributeDataType.md
[6]: ValueAttributes.md
[7]: AttributeTypeDefiningAttribute.md
[8]: ../CAEXWrapper/CAEXDocument.md
[9]: ../CAEXWrapper/CAEXParent.md
[10]: ../CAEXWrapper/CAEXSequenceOfCAEXObject.md
[11]: ../CAEXWrapper/Document.md
[12]: ../CAEXWrapper/Exists.md
[13]: Item.md
[14]: ../CAEX_CLASSModel_TagNames/ATTRIBUTE_CONSTRAINT_ORDINAL_VALUE_STRING.md
[15]: ../CAEX_CLASSModel_TagNames/ATTRIBUTE_CONSTRAINT_ORDINAL_MIN_STRING.md
[16]: ../CAEX_CLASSModel_TagNames/ATTRIBUTE_CONSTRAINT_ORDINAL_MAX_STRING.md
[17]: ../CAEXWrapper/Node.md
[18]: ../CAEXWrapper/Owner.md
[19]: RequiredMaxValue.md
[20]: RequiredMinValue.md
[21]: RequiredValue.md
[22]: ../CAEXWrapper/TagName.md
[23]: ../CAEXWrapper/CAEXChild.md
[24]: ../CAEXWrapper/CAEXChildren.md
[25]: ../CAEXWrapper/Copy.md
[26]: ../CAEXWrapper/Equals.md
[27]: GetCaexValue.md
[28]: ../../Aml.Engine.CAEX.Extensions/CaexValue/README.md
[29]: ../CAEXWrapper/GetHashCode.md
[30]: ../CAEXWrapper/GetXAttributeValue.md
[31]: ../CAEXWrapper/InsertNew.md
[32]: ../CAEXWrapper/Remove.md
[33]: ../CAEXWrapper/SetXAttributeValue.md
[34]: ../CAEXWrapper/PropertyChanged.md
[35]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/AMLSchemaManager.md
[36]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[37]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Ancestors__1.md
[38]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXDocument.md
[39]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXFile.md
[40]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXSchema.md
[41]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[42]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[43]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[44]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[45]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[46]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[47]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[48]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[49]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/GetParent__1.md
[50]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsAMLObject.md
[51]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[52]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Library.md
[53]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[54]: ../CAEXObject/README.md
[55]: ../../Aml.Engine.Adapter/AMLEngineAdapter/New_RequiredMaxValue.md
[56]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[57]: ../../Aml.Engine.Adapter/AMLEngineAdapter/New_RequiredMinValue.md
[58]: ../../Aml.Engine.Adapter/AMLEngineAdapter/New_RequiredValue_1.md
[59]: ../IAttributeValueType/README.md
[60]: https://www.automationml.org
[61]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"