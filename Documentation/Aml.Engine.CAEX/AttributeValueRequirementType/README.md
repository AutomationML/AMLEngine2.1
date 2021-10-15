AttributeValueRequirementType Class
===================================
This class is a wrapper for the CAEX-Element 'AttributeValueRequirement' which allows the specification of one value constraint for an attribute. There is a choice of different types defined for the type of the condition. [NominalScaledTypeType][1][OrdinalScaledTypeType][2][UnknownTypeType][3]


Inheritance Hierarchy
---------------------
[System.Object][4]  
  [Aml.Engine.CAEX.CAEXWrapper][5]  
    [Aml.Engine.CAEX.CAEXBasicObject][6]  
      **Aml.Engine.CAEX.AttributeValueRequirementType**  

  **Namespace:**  [Aml.Engine.CAEX][7]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class AttributeValueRequirementType : CAEXBasicObject
```

The **AttributeValueRequirementType** type exposes the following members.


Constructors
------------

                 | Name                               | Description                                                                
---------------- | ---------------------------------- | -------------------------------------------------------------------------- 
![Public method] | [AttributeValueRequirementType][8] | Initializes a new instance of the **AttributeValueRequirementType** class. 


Properties
----------

                   | Name                           | Description                                                                                                                                                                                         
------------------ | ------------------------------ | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AdditionalInformation][9]     | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [CAEXBasicObject][6].)                                                                              
![Public property] | [CAEXDocument][10]             | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][5].) 
![Public property] | [CAEXParent][11]               | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][5].)                                                                                                               
![Public property] | [CAEXSequenceOfCAEXObject][12] | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][5].)                                                                                                                
![Public property] | [ChangeMode][13]               | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [CAEXBasicObject][6].)                                                                                         
![Public property] | [Copyright][14]                | Gets and sets the Copyright for this object. (Inherited from [CAEXBasicObject][6].)                                                                                                                 
![Public property] | [CopyrightElement][15]         | Gets the wrapper for the Copyright element. (Inherited from [CAEXBasicObject][6].)                                                                                                                  
![Public property] | [Description][16]              | Gets and sets the Description for this object. (Inherited from [CAEXBasicObject][6].)                                                                                                               
![Public property] | [DescriptionElement][17]       | Gets the wrapper for the Description element. (Inherited from [CAEXBasicObject][6].)                                                                                                                
![Public property] | [Document][18]                 | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][5].)                                                                                                                    
![Public property] | [Exists][19]                   | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][5].)                                                                                                   
![Public property] | [Name][20]                     | Gets and sets the name of the attribute value constraint.                                                                                                                                           
![Public property] | [Node][21]                     | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][5].)                                                                                                                                     
![Public property] | [NominalScaledType][22]        | Gets the 'NominalScaledType' constraint.                                                                                                                                                            
![Public property] | [OrdinalScaledType][23]        | Gets the 'OrdinalScaledType' constraint.                                                                                                                                                            
![Public property] | [Owner][24]                    | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][5].)                                                                                                                            
![Public property] | [Revision][25]                 | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][6].)                                                                                          
![Public property] | [SourceObjectInformation][26]  | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][6].)                                                                           
![Public property] | [TagName][27]                  | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][5].)                                                                                                              
![Public property] | [UnknownType][28]              | Gets the 'UnknownType' constraint.                                                                                                                                                                  
![Public property] | [Version][29]                  | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][6].)                                                                                                                   
![Public property] | [VersionElement][30]           | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][6].)                                                                                                                    


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                                                                                                           
---------------- | ---------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [CAEXChild][31]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][5].)                                                                                                                                                                                                                                                           
![Public method] | [CAEXChildren][32]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][5].)                                                                                                                                                                                                                                                              
![Public method] | [CAEXSequence][33]                 | Gets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects [Revision][25] is returned. (Inherited from [CAEXBasicObject][6].)                                                                                                            
![Public method] | [Container&lt;T>][34]              | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Inherited from [CAEXBasicObject][6].)                                                                                                                                                                                                                                             
![Public method] | [Copy][35]                         | Creates a deep copy of this CAEX object (Inherited from [CAEXWrapper][5].)                                                                                                                                                                                                                                                                                            
![Public method] | [Equals][36]                       | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][5].)                                                                                                                                                                                                                                         
![Public method] | [GetHashCode][37]                  | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][5].)                                                                                                                                                                                                                                                               
![Public method] | [GetXAttributeValue][38]           | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][5].)                                                                                                                                                                                                                                  
![Public method] | [Insert(Int32, CAEXWrapper)][39]   | Inserts the specified CAEX object in it's associated sequence at the defined position. The AttributeValueRequirementType defines the [UnknownTypeType][3], the [OrdinalScaledTypeType][2] and the [NominalScaledTypeType][1] as possible child elements. Only one of these types is allowed as a child. (Overrides [CAEXBasicObject.Insert(Int32, CAEXWrapper)][40].) 
![Public method] | [Insert(CAEXWrapper, Boolean)][41] | Inserts the specified CAEX object in it's associated sequence. The AttributeValueRequirementType defines the [UnknownTypeType][3], the [OrdinalScaledTypeType][2] and the [NominalScaledTypeType][1] as possible child elements. Only one of these types is allowed as a child. (Overrides [CAEXBasicObject.Insert(CAEXWrapper, Boolean)][42].)                       
![Public method] | [InsertNew][43]                    | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][24] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][5].)                                                                                      
![Public method] | [New_NominalType][44]              | A new 'NominalScaledType' constraint is defined if no constraint has been defined before.                                                                                                                                                                                                                                                                             
![Public method] | [New_OrdinalType][45]              | A new 'OrdinalScaledType' constraint is added if no constraint has been defined before.                                                                                                                                                                                                                                                                               
![Public method] | [New_Revision][46]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][25] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][6].)                                                               
![Public method] | [New_UnknownType][47]              | A new 'UnknownType' constraint is added if no constraint has been defined before.                                                                                                                                                                                                                                                                                     
![Public method] | [Remove][48]                       | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][5].)                                                                                                                                                                                                                                  
![Public method] | [SetXAttributeValue][49]           | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][5].)                                                                                                                                                                                                                                 


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][50] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][5].) 


Extension Methods
-----------------

                           | Name                                  | Description                                                                                                                                                                                                                                                       
-------------------------- | ------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [clone][51]                           | [Copy(Boolean, Boolean, Boolean)][35] (Defined by [AMLEngineAdapter][52].)                                                                                                                                                                                        
![Public Extension Method] | [CloneNode][53]                       | Clones the node. (Defined by [AMLEngineAdapter][52].)                                                                                                                                                                                                             
![Public Extension Method] | [ConsistencyCheck_ClassReference][54] | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][52].)                                                                                                                                           
![Public Extension Method] | [Descendants(Type)][55]               | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][56].)                                                                                                                          
![Public Extension Method] | [Descendants&lt;T>()][57]             | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][56].)                                                                                                                          
![Public Extension Method] | [findInternalElement][58]             | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][52].)                                                                                                                                        
![Public Extension Method] | [getReferencedClass][59]              | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][52].)                                                                                                                                                                                       
![Public Extension Method] | [getReferencedGUID][60]               | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][52].)                                                                                                                                                               
![Public Extension Method] | [getReferencedInterfaceClass][61]     | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][52].)                                                                                                                                             
![Public Extension Method] | [getReferencedInterfaceName][62]      | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][52].)                                                                                                                                                                                
![Public Extension Method] | [Insert_Element][63]                  | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][52].)                                       
![Public Extension Method] | [Insert_NewInstance][64]              | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][52].) 
![Public Extension Method] | [Insert_TypeBaseElement][65]          | [Insert(CAEXWrapper, Boolean)][42] (Defined by [AMLEngineAdapter][52].)                                                                                                                                                                                           
![Public Extension Method] | [Name()][66]                          | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][52].)                                                                                                                                                                            
![Public Extension Method] | [Name()][67]                          | Overloaded. Gets a names for the specified CAEX wrapper object. If the specified object is a [CAEXObject][68], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][56].)                                        
![Public Extension Method] | [New_Description][69]                 | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][56].)                                                                                                                                                   


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][7]  
[Aml.Engine.CAEX.CAEXBasicObject][6]  

[1]: ../NominalScaledTypeType/README.md
[2]: ../OrdinalScaledTypeType/README.md
[3]: ../UnknownTypeType/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.object
[5]: ../CAEXWrapper/README.md
[6]: ../CAEXBasicObject/README.md
[7]: ../README.md
[8]: _ctor.md
[9]: ../CAEXBasicObject/AdditionalInformation.md
[10]: ../CAEXWrapper/CAEXDocument.md
[11]: ../CAEXWrapper/CAEXParent.md
[12]: ../CAEXWrapper/CAEXSequenceOfCAEXObject.md
[13]: ../CAEXBasicObject/ChangeMode.md
[14]: ../CAEXBasicObject/Copyright.md
[15]: ../CAEXBasicObject/CopyrightElement.md
[16]: ../CAEXBasicObject/Description.md
[17]: ../CAEXBasicObject/DescriptionElement.md
[18]: ../CAEXWrapper/Document.md
[19]: ../CAEXWrapper/Exists.md
[20]: Name.md
[21]: ../CAEXWrapper/Node.md
[22]: NominalScaledType.md
[23]: OrdinalScaledType.md
[24]: ../CAEXWrapper/Owner.md
[25]: ../CAEXBasicObject/Revision.md
[26]: ../CAEXBasicObject/SourceObjectInformation.md
[27]: ../CAEXWrapper/TagName.md
[28]: UnknownType.md
[29]: ../CAEXBasicObject/Version.md
[30]: ../CAEXBasicObject/VersionElement.md
[31]: ../CAEXWrapper/CAEXChild.md
[32]: ../CAEXWrapper/CAEXChildren.md
[33]: ../CAEXBasicObject/CAEXSequence.md
[34]: ../CAEXBasicObject/Container__1.md
[35]: ../CAEXWrapper/Copy.md
[36]: ../CAEXWrapper/Equals.md
[37]: ../CAEXWrapper/GetHashCode.md
[38]: ../CAEXWrapper/GetXAttributeValue.md
[39]: Insert_1.md
[40]: ../CAEXBasicObject/Insert_1.md
[41]: Insert.md
[42]: ../CAEXBasicObject/Insert.md
[43]: ../CAEXWrapper/InsertNew.md
[44]: New_NominalType.md
[45]: New_OrdinalType.md
[46]: ../CAEXBasicObject/New_Revision.md
[47]: New_UnknownType.md
[48]: ../CAEXWrapper/Remove.md
[49]: ../CAEXWrapper/SetXAttributeValue.md
[50]: ../CAEXWrapper/PropertyChanged.md
[51]: ../../Aml.Engine.Adapter/AMLEngineAdapter/clone.md
[52]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[53]: ../../Aml.Engine.Adapter/AMLEngineAdapter/CloneNode.md
[54]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ConsistencyCheck_ClassReference.md
[55]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[56]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[57]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[58]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[59]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedClass.md
[60]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedGUID.md
[61]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceClass.md
[62]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceName.md
[63]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_Element.md
[64]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_NewInstance.md
[65]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_TypeBaseElement.md
[66]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Name.md
[67]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[68]: ../CAEXObject/README.md
[69]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[70]: https://www.automationml.org
[71]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"