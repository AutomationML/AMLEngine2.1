CAEXObject Class
================
AutomationML 2.1 APIThe class CAEXObject is derived from CAEXBasicObject, augmented by the CAEX Attributes Name(required) and ID(optional).


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.CAEXWrapper][2]  
    [Aml.Engine.CAEX.CAEXBasicObject][3]  
      **Aml.Engine.CAEX.CAEXObject**  
        [More...][4]

  **Namespace:**  [Aml.Engine.CAEX][5]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class CAEXObject : CAEXBasicObject, ICAEXObject, 
	ICAEXBasicObject, ICAEXWrapper, IXMLWrapper
```

The **CAEXObject** type exposes the following members.


Constructors
------------

                 | Name            | Description                                             
---------------- | --------------- | ------------------------------------------------------- 
![Public method] | [CAEXObject][6] | Initializes a new instance of the **CAEXObject** class. 


Properties
----------

                                   | Name                           | Description                                                                                                                                                                                         
---------------------------------- | ------------------------------ | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property]                 | [AdditionalInformation][7]     | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                              
![Public property]                 | [CAEXDocument][8]              | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][2].) 
![Public property]                 | [CAEXParent][9]                | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][2].)                                                                                                               
![Public property]                 | [CAEXSequenceOfCAEXObject][10] | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                
![Public property]                 | [ChangeMode][11]               | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [CAEXBasicObject][3].)                                                                                         
![Public property]                 | [Copyright][12]                | Gets and sets the Copyright for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                 
![Public property]                 | [CopyrightElement][13]         | Gets the wrapper for the Copyright element. (Inherited from [CAEXBasicObject][3].)                                                                                                                  
![Public property]                 | [Description][14]              | Gets and sets the Description for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                               
![Public property]                 | [DescriptionElement][15]       | Gets the wrapper for the Description element. (Inherited from [CAEXBasicObject][3].)                                                                                                                
![Public property]                 | [Document][16]                 | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                    
![Public property]                 | [Exists][17]                   | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                   
![Public property]                 | [ID][18]                       | Gets and sets a unique identifier of the CAEX object (optional in CAEX). AutomationML requires IDs for some Elements. These IDs are automatically set when such elements are created.               
![Public property]                 | [Name][19]                     | Gets and sets the name of the CAEX object (required in CAEX).                                                                                                                                       
![Public property]![Static member] | [NewGUID][20]                  | Gets a new unique identifier.                                                                                                                                                                       
![Public property]                 | [Node][21]                     | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                     
![Public property]                 | [Owner][22]                    | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][2].)                                                                                                                            
![Public property]                 | [Revision][23]                 | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                          
![Public property]                 | [SourceObjectInformation][24]  | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                           
![Public property]                 | [TagName][25]                  | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][2].)                                                                                                              
![Public property]                 | [Version][26]                  | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                   
![Public property]                 | [VersionElement][27]           | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][3].)                                                                                                                    


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                                                                                                                                                                          
---------------- | ---------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public method] | [AssignNewGuidAsID][28]            | Assigns the new unique identifier as a new ID to this CAEX object.                                                                                                                                                                                                                                                                                                                                                                   
![Public method] | [CAEXChild][29]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                          
![Public method] | [CAEXChildren][30]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                             
![Public method] | [CAEXPath][31]                     | Gets the CAEX path for this object. A path can be used to uniquely reference an object, for example in inheritances and instances. The path syntax for an object is defined differently in CAEX 2.15 and CAEX 3.0. The engine uses the [CAEXPathBuilder][32] to generate the CAEX path of an object according to the documents CAEX version.                                                                                         
![Public method] | [CAEXSequence][33]                 | Gets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects [Revision][23] is returned. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                           
![Public method] | [Container&lt;T>][34]              | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                                                                                            
![Public method] | [Copy][35]                         | Creates a deep copy of this CAEX object, containing all child elements. The created copy will have replaced unique IDs and updated references, if the *assignNewIDs* is set to true (default). When a CAEX class is copied, the nested classes that can exist for AttributeType, RoleClass, SystemUnitClass, and InterfaceClass are not included in the created copy. (Overrides [CAEXWrapper.Copy(Boolean, Boolean, Boolean)][36].) 
![Public method] | [Equals][37]                       | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                        
![Public method] | [GetHashCode][38]                  | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                              
![Public method] | [GetXAttributeValue][39]           | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                 
![Public method] | [Insert(Int32, CAEXWrapper)][40]   | Inserts the specified CAEX object in it's associated sequence at the defined position. The CAEXBasicObject defines the [Revision][23] and [SourceObjectInformation][24] sequences. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                            
![Public method] | [Insert(CAEXWrapper, Boolean)][41] | Inserts the specified CAEX object in it's associated sequence. The CAEXBasicObject defines the [Revision][23] and [SourceObjectInformation][24] sequences. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                    
![Public method] | [InsertNew][42]                    | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][22] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][2].)                                                                                                                                                     
![Public method] | [New_Revision][43]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][23] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][3].)                                                                                                                              
![Public method] | [Remove][44]                       | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                 
![Public method] | [SetXAttributeValue][45]           | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                
![Public method] | [ToString][46]                     | Returns the value of the 'Name' attribute of this CAEX object as the string representation of the object. (Overrides [Object.ToString()][47].)                                                                                                                                                                                                                                                                                       


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][48] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][2].) 


Fields
------

                                | Name              | Description                                                                      
------------------------------- | ----------------- | -------------------------------------------------------------------------------- 
![Public field]![Static member] | [GUID_FORMAT][49] | Specifies the format used for GUIDs. Format "D" is NOT adding {} around the GUID 


Extension Methods
-----------------

                           | Name                                            | Description                                                                                                                                                                                                                                                                                                                                                                              
-------------------------- | ----------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [AMLSchemaManager][50]                          | Gets the associated CAEX schema manager of the CAEX object. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                                                
![Public Extension Method] | [Ancestors&lt;T>][52]                           | Finds the ancestors of the provided CAEX object which have the given type. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [CAEXDocument][53]                              | Gets the CAEX document which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [CAEXFile][54]                                  | Gets the CAEX file which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [CAEXSchema][55]                                | Gets the associated CAEX schema of the CAEX object. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [clone][56]                                     | [Copy(Boolean, Boolean, Boolean)][36] (Defined by [AMLEngineAdapter][57].)                                                                                                                                                                                                                                                                                                               
![Public Extension Method] | [CloneNode][58]                                 | Clones the node. (Defined by [AMLEngineAdapter][57].)                                                                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [ConsistencyCheck_ClassReference][59]           | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][57].)                                                                                                                                                                                                                                                                  
![Public Extension Method] | [Descendants(Type)][60]                         | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [Descendants&lt;T>()][61]                       | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [Descendants&lt;T>(Boolean)][62]                | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [FindCaexObjectFromId&lt;T>][63]                | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                                        
![Public Extension Method] | [findInternalElement][64]                       | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][57].)                                                                                                                                                                                                                                                               
![Public Extension Method] | [FindReferencedClass&lt;T>][65]                 | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [FirstAncestor(String)][66]                     | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][67] | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                    
![Public Extension Method] | [FirstAncestor&lt;T>()][68]                     | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                       
![Public Extension Method] | [GetFullNodePath][69]                           | Gets the full node path of the provided CAEX object, which includes the object names of all ancestor hierarchy levels and the name of the object itself. (Defined by [CAEXObjectExtensions][70].)                                                                                                                                                                                        
![Public Extension Method] | [GetParent&lt;T>][71]                           | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                 
![Public Extension Method] | [getReferencedClass][72]                        | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][57].)                                                                                                                                                                                                                                                                                                              
![Public Extension Method] | [getReferencedGUID][73]                         | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][57].)                                                                                                                                                                                                                                                                                      
![Public Extension Method] | [getReferencedInterfaceClass][74]               | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][57].)                                                                                                                                                                                                                                                                    
![Public Extension Method] | [getReferencedInterfaceName][75]                | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][57].)                                                                                                                                                                                                                                                                                                       
![Public Extension Method] | [Insert_Element][76]                            | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][57].)                                                                                                                                                              
![Public Extension Method] | [Insert_NewInstance][77]                        | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][57].)                                                                                                                        
![Public Extension Method] | [Insert_TypeBaseElement][78]                    | [Insert(CAEXWrapper, Boolean)][41] (Defined by [AMLEngineAdapter][57].)                                                                                                                                                                                                                                                                                                                  
![Public Extension Method] | [IsAMLObject][79]                               | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][80].) 
![Public Extension Method] | [Library][81]                                   | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [Name()][82]                                    | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][57].)                                                                                                                                                                                                                                                                                                   
![Public Extension Method] | [Name()][83]                                    | Overloaded. Gets a names for the specified caex wrapper object. If the specified object is a **CAEXObject**, the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                 
![Public Extension Method] | [New_Copyright][84]                             | Adds an new Copyright node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                                            
![Public Extension Method] | [New_Description][85]                           | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                                          
![Public Extension Method] | [New_Version][86]                               | Adds an new Version node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                                              
![Public Extension Method] | [SetDescription][87]                            | This method sets a description. If no description exists, it is created. (Defined by [CAEXObjectExtensions][70].)                                                                                                                                                                                                                                                                        


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][5]  
[Aml.Engine.CAEX.CAEXBasicObject][3]  


Inheritance Hierarchy (Continued)
---------------------------------
[System.Object][1]  
  [Aml.Engine.CAEX.CAEXWrapper][2]  
    [Aml.Engine.CAEX.CAEXBasicObject][3]  
      **Aml.Engine.CAEX.CAEXObject**  
        [Aml.Engine.AmlObjects.ObjectWithAMLAttributes][88]  
        [Aml.Engine.CAEX.AttributeTypeType][89]  
        [Aml.Engine.CAEX.CAEXLibrary&lt;TLibItem>][90]  
        [Aml.Engine.CAEX.CaexObjectWithReference&lt;T>][91]  
        [Aml.Engine.CAEX.InternalLinkType][92]  
        [Aml.Engine.CAEX.SystemUnitClassType][93]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../CAEXWrapper/README.md
[3]: ../CAEXBasicObject/README.md
[4]: #inheritance-hierarchy-continued
[5]: ../README.md
[6]: _ctor.md
[7]: ../CAEXBasicObject/AdditionalInformation.md
[8]: ../CAEXWrapper/CAEXDocument.md
[9]: ../CAEXWrapper/CAEXParent.md
[10]: ../CAEXWrapper/CAEXSequenceOfCAEXObject.md
[11]: ../CAEXBasicObject/ChangeMode.md
[12]: ../CAEXBasicObject/Copyright.md
[13]: ../CAEXBasicObject/CopyrightElement.md
[14]: ../CAEXBasicObject/Description.md
[15]: ../CAEXBasicObject/DescriptionElement.md
[16]: ../CAEXWrapper/Document.md
[17]: ../CAEXWrapper/Exists.md
[18]: ID.md
[19]: Name.md
[20]: NewGUID.md
[21]: ../CAEXWrapper/Node.md
[22]: ../CAEXWrapper/Owner.md
[23]: ../CAEXBasicObject/Revision.md
[24]: ../CAEXBasicObject/SourceObjectInformation.md
[25]: ../CAEXWrapper/TagName.md
[26]: ../CAEXBasicObject/Version.md
[27]: ../CAEXBasicObject/VersionElement.md
[28]: AssignNewGuidAsID.md
[29]: ../CAEXWrapper/CAEXChild.md
[30]: ../CAEXWrapper/CAEXChildren.md
[31]: CAEXPath.md
[32]: ../../Aml.Engine.CAEX.Extensions/CAEXPathBuilder/README.md
[33]: ../CAEXBasicObject/CAEXSequence.md
[34]: ../CAEXBasicObject/Container__1.md
[35]: Copy.md
[36]: ../CAEXWrapper/Copy.md
[37]: ../CAEXWrapper/Equals.md
[38]: ../CAEXWrapper/GetHashCode.md
[39]: ../CAEXWrapper/GetXAttributeValue.md
[40]: ../CAEXBasicObject/Insert_1.md
[41]: ../CAEXBasicObject/Insert.md
[42]: ../CAEXWrapper/InsertNew.md
[43]: ../CAEXBasicObject/New_Revision.md
[44]: ../CAEXWrapper/Remove.md
[45]: ../CAEXWrapper/SetXAttributeValue.md
[46]: ToString.md
[47]: https://docs.microsoft.com/dotnet/api/system.object.tostring#System_Object_ToString
[48]: ../CAEXWrapper/PropertyChanged.md
[49]: GUID_FORMAT.md
[50]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/AMLSchemaManager.md
[51]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[52]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Ancestors__1.md
[53]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXDocument.md
[54]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXFile.md
[55]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXSchema.md
[56]: ../../Aml.Engine.Adapter/AMLEngineAdapter/clone.md
[57]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[58]: ../../Aml.Engine.Adapter/AMLEngineAdapter/CloneNode.md
[59]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ConsistencyCheck_ClassReference.md
[60]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[61]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[62]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[63]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[64]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[65]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[66]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[67]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[68]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[69]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/GetFullNodePath.md
[70]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/README.md
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
[84]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Copyright.md
[85]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[86]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Version.md
[87]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/SetDescription.md
[88]: ../../Aml.Engine.AmlObjects/ObjectWithAMLAttributes/README.md
[89]: ../AttributeTypeType/README.md
[90]: ../CAEXLibrary_1/README.md
[91]: ../CaexObjectWithReference_1/README.md
[92]: ../InternalLinkType/README.md
[93]: ../SystemUnitClassType/README.md
[94]: https://www.automationml.org
[95]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Static member]: ../../icons/static.gif "Static member"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public field]: ../../icons/pubfield.gif "Public field"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"