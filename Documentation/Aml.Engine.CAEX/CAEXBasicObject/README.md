CAEXBasicObject Class
=====================
AutomationML 2.1 APIThe class CAEXBasicObject comprises a basic set of attributes and header information which exist for all CAEX elements.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.CAEXWrapper][2]  
    **Aml.Engine.CAEX.CAEXBasicObject**  
      [More...][3]

  **Namespace:**  [Aml.Engine.CAEX][4]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class CAEXBasicObject : CAEXWrapper, 
	ICAEXContainer, ICAEXWrapper, IXMLWrapper, ICAEXBasicObject
```

The **CAEXBasicObject** type exposes the following members.


Constructors
------------

                 | Name                 | Description                                                  
---------------- | -------------------- | ------------------------------------------------------------ 
![Public method] | [CAEXBasicObject][5] | Initializes a new instance of the **CAEXBasicObject** class. 


Properties
----------

                   | Name                          | Description                                                                                                                                                                                         
------------------ | ----------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AdditionalInformation][6]    | Gets the collection of AdditionalInformation values contained in this instance.                                                                                                                     
![Public property] | [CAEXDocument][7]             | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][2].) 
![Public property] | [CAEXParent][8]               | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][2].)                                                                                                               
![Public property] | [CAEXSequenceOfCAEXObject][9] | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                
![Public property] | [ChangeMode][10]              | Gets and sets the change mode for a CAEX element (Optional in CAEX).                                                                                                                                
![Public property] | [Copyright][11]               | Gets and sets the Copyright for this object.                                                                                                                                                        
![Public property] | [CopyrightElement][12]        | Gets the wrapper for the Copyright element.                                                                                                                                                         
![Public property] | [Description][13]             | Gets and sets the Description for this object.                                                                                                                                                      
![Public property] | [DescriptionElement][14]      | Gets the wrapper for the Description element.                                                                                                                                                       
![Public property] | [Document][15]                | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                    
![Public property] | [Exists][16]                  | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                   
![Public property] | [Node][17]                    | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                     
![Public property] | [Owner][18]                   | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][2].)                                                                                                                            
![Public property] | [Revision][19]                | Gets the collection of Revision objects contained in this instance.                                                                                                                                 
![Public property] | [SourceObjectInformation][20] | Gets the collection of SourceObjectInformation objects contained in this instance.                                                                                                                  
![Public property] | [TagName][21]                 | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][2].)                                                                                                              
![Public property] | [Version][22]                 | Gets and sets the Version for this object.                                                                                                                                                          
![Public property] | [VersionElement][23]          | Gets the wrapper for the Version element.                                                                                                                                                           


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                      
---------------- | ---------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [CAEXChild][24]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                      
![Public method] | [CAEXChildren][25]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                         
![Public method] | [CAEXSequence][26]                 | Gets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects [Revision][19] is returned.                                                              
![Public method] | [Container&lt;T>][27]              | Gets the CAEX Container for elements of type T, which is owned by this CAEX object                                                                                                                                                                                               
![Public method] | [Copy][28]                         | Creates a deep copy of this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                       
![Public method] | [Equals][29]                       | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][2].)                                                                                                                                                    
![Public method] | [GetHashCode][30]                  | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                          
![Public method] | [GetXAttributeValue][31]           | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][2].)                                                                                                                                             
![Public method] | [Insert(Int32, CAEXWrapper)][32]   | Inserts the specified CAEX object in it's associated sequence at the defined position. The CAEXBasicObject defines the [Revision][19] and [SourceObjectInformation][20] sequences.                                                                                               
![Public method] | [Insert(CAEXWrapper, Boolean)][33] | Inserts the specified CAEX object in it's associated sequence. The CAEXBasicObject defines the [Revision][19] and [SourceObjectInformation][20] sequences.                                                                                                                       
![Public method] | [InsertNew][34]                    | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][18] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][2].) 
![Public method] | [New_Revision][35]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][19] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values.                 
![Public method] | [Remove][36]                       | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][2].)                                                                                                                                             
![Public method] | [SetXAttributeValue][37]           | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][2].)                                                                                                                                            


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][38] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][2].) 


Extension Methods
-----------------

                           | Name                                            | Description                                                                                                                                                                                                                                                                                                                                                                              
-------------------------- | ----------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [AMLSchemaManager][39]                          | Gets the associated CAEX schema manager of the CAEX object. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                                                
![Public Extension Method] | [Ancestors&lt;T>][41]                           | Finds the ancestors of the provided CAEX object which have the given type. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [CAEXDocument][42]                              | Gets the CAEX document which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [CAEXFile][43]                                  | Gets the CAEX file which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [CAEXSchema][44]                                | Gets the associated CAEX schema of the CAEX object. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [clone][45]                                     | [Copy(Boolean, Boolean, Boolean)][28] (Defined by [AMLEngineAdapter][46].)                                                                                                                                                                                                                                                                                                               
![Public Extension Method] | [CloneNode][47]                                 | Clones the node. (Defined by [AMLEngineAdapter][46].)                                                                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [ConsistencyCheck_ClassReference][48]           | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][46].)                                                                                                                                                                                                                                                                  
![Public Extension Method] | [Descendants(Type)][49]                         | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [Descendants&lt;T>()][50]                       | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [Descendants&lt;T>(Boolean)][51]                | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [FindCaexObjectFromId&lt;T>][52]                | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                                        
![Public Extension Method] | [findInternalElement][53]                       | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][46].)                                                                                                                                                                                                                                                               
![Public Extension Method] | [FindReferencedClass&lt;T>][54]                 | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [FirstAncestor(String)][55]                     | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][56] | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                    
![Public Extension Method] | [FirstAncestor&lt;T>()][57]                     | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                       
![Public Extension Method] | [GetParent&lt;T>][58]                           | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                 
![Public Extension Method] | [getReferencedClass][59]                        | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][46].)                                                                                                                                                                                                                                                                                                              
![Public Extension Method] | [getReferencedGUID][60]                         | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][46].)                                                                                                                                                                                                                                                                                      
![Public Extension Method] | [getReferencedInterfaceClass][61]               | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][46].)                                                                                                                                                                                                                                                                    
![Public Extension Method] | [getReferencedInterfaceName][62]                | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][46].)                                                                                                                                                                                                                                                                                                       
![Public Extension Method] | [Insert_Element][63]                            | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][46].)                                                                                                                                                              
![Public Extension Method] | [Insert_NewInstance][64]                        | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][46].)                                                                                                                        
![Public Extension Method] | [Insert_TypeBaseElement][65]                    | [Insert(CAEXWrapper, Boolean)][33] (Defined by [AMLEngineAdapter][46].)                                                                                                                                                                                                                                                                                                                  
![Public Extension Method] | [IsAMLObject][66]                               | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][67].) 
![Public Extension Method] | [Library][68]                                   | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [Name()][69]                                    | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][46].)                                                                                                                                                                                                                                                                                                   
![Public Extension Method] | [Name()][70]                                    | Overloaded. Gets a names for the specified caex wrapper object. If the specified object is a [CAEXObject][71], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                               
![Public Extension Method] | [New_Copyright][72]                             | Adds an new Copyright node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                                            
![Public Extension Method] | [New_Description][73]                           | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                                          
![Public Extension Method] | [New_Version][74]                               | Adds an new Version node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                                              


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][4]  
[Aml.Engine.CAEX.CAEXWrapper][2]  


Inheritance Hierarchy (Continued)
---------------------------------
[System.Object][1]  
  [Aml.Engine.CAEX.CAEXWrapper][2]  
    **Aml.Engine.CAEX.CAEXBasicObject**  
      [Aml.Engine.CAEX.AttributeValueRequirementType][75]  
      [Aml.Engine.CAEX.CAEXFileType][76]  
      [Aml.Engine.CAEX.CAEXObject][71]  
      [Aml.Engine.CAEX.ExternalReferenceType][77]  
      [Aml.Engine.CAEX.MappingElementType&lt;T>][78]  
      [Aml.Engine.CAEX.MappingType][79]  
      [Aml.Engine.CAEX.RefSemanticType][80]  
      [Aml.Engine.CAEX.RevisionType][81]  
      [Aml.Engine.CAEX.RoleRequirementsType][82]  
      [Aml.Engine.CAEX.SupportedRoleClassType][83]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../CAEXWrapper/README.md
[3]: #inheritance-hierarchy-continued
[4]: ../README.md
[5]: _ctor.md
[6]: AdditionalInformation.md
[7]: ../CAEXWrapper/CAEXDocument.md
[8]: ../CAEXWrapper/CAEXParent.md
[9]: ../CAEXWrapper/CAEXSequenceOfCAEXObject.md
[10]: ChangeMode.md
[11]: Copyright.md
[12]: CopyrightElement.md
[13]: Description.md
[14]: DescriptionElement.md
[15]: ../CAEXWrapper/Document.md
[16]: ../CAEXWrapper/Exists.md
[17]: ../CAEXWrapper/Node.md
[18]: ../CAEXWrapper/Owner.md
[19]: Revision.md
[20]: SourceObjectInformation.md
[21]: ../CAEXWrapper/TagName.md
[22]: Version.md
[23]: VersionElement.md
[24]: ../CAEXWrapper/CAEXChild.md
[25]: ../CAEXWrapper/CAEXChildren.md
[26]: CAEXSequence.md
[27]: Container__1.md
[28]: ../CAEXWrapper/Copy.md
[29]: ../CAEXWrapper/Equals.md
[30]: ../CAEXWrapper/GetHashCode.md
[31]: ../CAEXWrapper/GetXAttributeValue.md
[32]: Insert_1.md
[33]: Insert.md
[34]: ../CAEXWrapper/InsertNew.md
[35]: New_Revision.md
[36]: ../CAEXWrapper/Remove.md
[37]: ../CAEXWrapper/SetXAttributeValue.md
[38]: ../CAEXWrapper/PropertyChanged.md
[39]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/AMLSchemaManager.md
[40]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[41]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Ancestors__1.md
[42]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXDocument.md
[43]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXFile.md
[44]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXSchema.md
[45]: ../../Aml.Engine.Adapter/AMLEngineAdapter/clone.md
[46]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[47]: ../../Aml.Engine.Adapter/AMLEngineAdapter/CloneNode.md
[48]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ConsistencyCheck_ClassReference.md
[49]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[50]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[51]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[52]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[53]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[54]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[55]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[56]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[57]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[58]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/GetParent__1.md
[59]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedClass.md
[60]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedGUID.md
[61]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceClass.md
[62]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceName.md
[63]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_Element.md
[64]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_NewInstance.md
[65]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_TypeBaseElement.md
[66]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsAMLObject.md
[67]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[68]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Library.md
[69]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Name.md
[70]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[71]: ../CAEXObject/README.md
[72]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Copyright.md
[73]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[74]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Version.md
[75]: ../AttributeValueRequirementType/README.md
[76]: ../CAEXFileType/README.md
[77]: ../ExternalReferenceType/README.md
[78]: ../MappingElementType_1/README.md
[79]: ../MappingType/README.md
[80]: ../RefSemanticType/README.md
[81]: ../RevisionType/README.md
[82]: ../RoleRequirementsType/README.md
[83]: ../SupportedRoleClassType/README.md
[84]: https://www.automationml.org
[85]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"