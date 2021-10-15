CaexObjectWithReference&lt;T> Class
===================================
Base class for all CAEX objects which may define a class to class relation referencing some base class.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.CAEXWrapper][2]  
    [Aml.Engine.CAEX.CAEXBasicObject][3]  
      [Aml.Engine.CAEX.CAEXObject][4]  
        **Aml.Engine.CAEX.CaexObjectWithReference&lt;T>**  
          [Aml.Engine.CAEX.InterfaceClassType][5]  
          [Aml.Engine.CAEX.RoleClassType][6]  

  **Namespace:**  [Aml.Engine.CAEX][7]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public abstract class CaexObjectWithReference<T> : CAEXObject, 
	IMultipleOccurrences<T>, ICAEXBasicObject, ICAEXWrapper, IXMLWrapper
where T : CAEXObject

```

#### Type Parameters

##### *T*
Type parameter, specifying the CAEX class type.

The **CaexObjectWithReference&lt;T>** type exposes the following members.


Properties
----------

                   | Name                           | Description                                                                                                                                                                                                             
------------------ | ------------------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AdditionalInformation][8]     | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                                  
![Public property] | [CAEXDocument][9]              | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][2].)                     
![Public property] | [CAEXParent][10]               | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][2].)                                                                                                                                   
![Public property] | [CAEXSequenceOfCAEXObject][11] | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                    
![Public property] | [ChangeMode][12]               | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [CAEXBasicObject][3].)                                                                                                             
![Public property] | [Copyright][13]                | Gets and sets the Copyright for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                     
![Public property] | [CopyrightElement][14]         | Gets the wrapper for the Copyright element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                      
![Public property] | [Description][15]              | Gets and sets the Description for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                   
![Public property] | [DescriptionElement][16]       | Gets the wrapper for the Description element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                    
![Public property] | [Document][17]                 | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                        
![Public property] | [Exists][18]                   | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                       
![Public property] | [ID][19]                       | Gets and sets a unique identifier of the CAEX object (optional in CAEX). AutomationML requires IDs for some Elements. These IDs are automatically set when such elements are created. (Inherited from [CAEXObject][4].) 
![Public property] | [Name][20]                     | Gets and sets the name of the CAEX object (required in CAEX). (Inherited from [CAEXObject][4].)                                                                                                                         
![Public property] | [Node][21]                     | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                                         
![Public property] | [Owner][22]                    | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][2].)                                                                                                                                                
![Public property] | [ReferenceAttributeName][23]   | Gets the Name of the attribute of the wrapped Xml-Element, which is used to define the reference to the base class.                                                                                                     
![Public property] | [Revision][24]                 | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                                              
![Public property] | [SourceObjectInformation][25]  | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                               
![Public property] | [TagName][26]                  | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][2].)                                                                                                                                  
![Public property] | [Version][27]                  | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                       
![Public property] | [VersionElement][28]           | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                        


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                                                                                                                                                                                      
---------------- | ---------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public method] | [AssignNewGuidAsID][29]            | Assigns the new unique identifier as a new ID to this CAEX object. (Inherited from [CAEXObject][4].)                                                                                                                                                                                                                                                                                                                                             
![Public method] | [CAEXChild][30]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                      
![Public method] | [CAEXChildren][31]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                         
![Public method] | [CAEXPath][32]                     | Gets the CAEX path for this object. A path can be used to uniquely reference an object, for example in inheritances and instances. The path syntax for an object is defined differently in CAEX 2.15 and CAEX 3.0. The engine uses the [CAEXPathBuilder][33] to generate the CAEX path of an object according to the documents CAEX version. (Inherited from [CAEXObject][4].)                                                                   
![Public method] | [CAEXSequence][34]                 | Gets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects [Revision][24] is returned. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                       
![Public method] | [Container&lt;T>][35]              | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                                                                                                        
![Public method] | [Copy][36]                         | Creates a copy of this CAEX object, containing all child elements. The created copy will have replaced unique IDs and updated references, if the *assignNewIDs* is set to true (default). When a CAEX class is copied, the nested classes that can exist for AttributeType, RoleClass, SystemUnitClass, and InterfaceClass could be included in the created copy, if the *includeSubClasses* is set to `true`. (Inherited from [CAEXObject][4].) 
![Public method] | [Equals][37]                       | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                    
![Public method] | [GetHashCode][38]                  | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                          
![Public method] | [GetXAttributeValue][39]           | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                             
![Public method] | [Insert(Int32, CAEXWrapper)][40]   | Inserts the specified CAEX object in it's associated sequence at the defined position. The CAEXBasicObject defines the [Revision][24] and [SourceObjectInformation][25] sequences. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                        
![Public method] | [Insert(CAEXWrapper, Boolean)][41] | Inserts the specified CAEX object in it's associated sequence. The CAEXBasicObject defines the [Revision][24] and [SourceObjectInformation][25] sequences. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                                
![Public method] | [InsertAfter][42]                  | Inserts the provided CAEX object as a new sibling after this CAEX object.                                                                                                                                                                                                                                                                                                                                                                        
![Public method] | [InsertBefore][43]                 | Inserts the provided CAEX object as a new sibling before this CAEX object.                                                                                                                                                                                                                                                                                                                                                                       
![Public method] | [InsertNew][44]                    | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][22] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                 
![Public method] | [New_Revision][45]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][24] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][3].)                                                                                                                                          
![Public method] | [Remove][46]                       | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                             
![Public method] | [SetXAttributeValue][47]           | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                            
![Public method] | [ToString][48]                     | Returns the value of the 'Name' attribute of this CAEX object as the string representation of the object. (Inherited from [CAEXObject][4].)                                                                                                                                                                                                                                                                                                      


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][49] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][2].) 


Extension Methods
-----------------

                           | Name                                            | Description                                                                                                                                                                                                                                                                                                                                                                              
-------------------------- | ----------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [AMLSchemaManager][50]                          | Gets the associated CAEX schema manager of the CAEX object. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                                                
![Public Extension Method] | [Ancestors&lt;T>][52]                           | Finds the ancestors of the provided CAEX object which have the given type. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [CAEXDocument][53]                              | Gets the CAEX document which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [CAEXFile][54]                                  | Gets the CAEX file which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [CAEXSchema][55]                                | Gets the associated CAEX schema of the CAEX object. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [clone][56]                                     | [Copy(Boolean, Boolean, Boolean)][57] (Defined by [AMLEngineAdapter][58].)                                                                                                                                                                                                                                                                                                               
![Public Extension Method] | [CloneNode][59]                                 | Clones the node. (Defined by [AMLEngineAdapter][58].)                                                                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [ConsistencyCheck_ClassReference][60]           | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][58].)                                                                                                                                                                                                                                                                  
![Public Extension Method] | [Copy][61]                                      | Copies the CAEX object and assigns the name to the created copy. (Defined by [CAEXObjectExtensions][62].)                                                                                                                                                                                                                                                                                
![Public Extension Method] | [Descendants(Type)][63]                         | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [Descendants&lt;T>()][64]                       | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [Descendants&lt;T>(Boolean)][65]                | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [FindCaexObjectFromId&lt;T>][66]                | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                                        
![Public Extension Method] | [findInternalElement][67]                       | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][58].)                                                                                                                                                                                                                                                               
![Public Extension Method] | [FindReferencedClass&lt;T>][68]                 | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [FirstAncestor(String)][69]                     | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][70] | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                    
![Public Extension Method] | [FirstAncestor&lt;T>()][71]                     | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                       
![Public Extension Method] | [GetParent&lt;T>][72]                           | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                 
![Public Extension Method] | [getReferencedClass][73]                        | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][58].)                                                                                                                                                                                                                                                                                                              
![Public Extension Method] | [getReferencedGUID][74]                         | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][58].)                                                                                                                                                                                                                                                                                      
![Public Extension Method] | [getReferencedInterfaceClass][75]               | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][58].)                                                                                                                                                                                                                                                                    
![Public Extension Method] | [getReferencedInterfaceName][76]                | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][58].)                                                                                                                                                                                                                                                                                                       
![Public Extension Method] | [Insert_Element][77]                            | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][58].)                                                                                                                                                              
![Public Extension Method] | [Insert_NewInstance][78]                        | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][58].)                                                                                                                        
![Public Extension Method] | [Insert_TypeBaseElement][79]                    | [Insert(CAEXWrapper, Boolean)][41] (Defined by [AMLEngineAdapter][58].)                                                                                                                                                                                                                                                                                                                  
![Public Extension Method] | [IsAMLObject][80]                               | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][81].) 
![Public Extension Method] | [Library][82]                                   | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [Name()][83]                                    | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][58].)                                                                                                                                                                                                                                                                                                   
![Public Extension Method] | [Name()][84]                                    | Overloaded. Gets a names for the specified CAEX wrapper object. If the specified object is a [CAEXObject][4], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                
![Public Extension Method] | [New_Copyright][85]                             | Adds an new Copyright node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                                            
![Public Extension Method] | [New_Description][86]                           | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                                          
![Public Extension Method] | [New_Version][87]                               | Adds an new Version node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                                                                                                                                              


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][7]  
[Aml.Engine.CAEX.CAEXObject][4]  
[Aml.Engine.CAEX.IMultipleOccurrences&lt;T>][88]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../CAEXWrapper/README.md
[3]: ../CAEXBasicObject/README.md
[4]: ../CAEXObject/README.md
[5]: ../InterfaceClassType/README.md
[6]: ../RoleClassType/README.md
[7]: ../README.md
[8]: ../CAEXBasicObject/AdditionalInformation.md
[9]: ../CAEXWrapper/CAEXDocument.md
[10]: ../CAEXWrapper/CAEXParent.md
[11]: ../CAEXWrapper/CAEXSequenceOfCAEXObject.md
[12]: ../CAEXBasicObject/ChangeMode.md
[13]: ../CAEXBasicObject/Copyright.md
[14]: ../CAEXBasicObject/CopyrightElement.md
[15]: ../CAEXBasicObject/Description.md
[16]: ../CAEXBasicObject/DescriptionElement.md
[17]: ../CAEXWrapper/Document.md
[18]: ../CAEXWrapper/Exists.md
[19]: ../CAEXObject/ID.md
[20]: ../CAEXObject/Name.md
[21]: ../CAEXWrapper/Node.md
[22]: ../CAEXWrapper/Owner.md
[23]: ReferenceAttributeName.md
[24]: ../CAEXBasicObject/Revision.md
[25]: ../CAEXBasicObject/SourceObjectInformation.md
[26]: ../CAEXWrapper/TagName.md
[27]: ../CAEXBasicObject/Version.md
[28]: ../CAEXBasicObject/VersionElement.md
[29]: ../CAEXObject/AssignNewGuidAsID.md
[30]: ../CAEXWrapper/CAEXChild.md
[31]: ../CAEXWrapper/CAEXChildren.md
[32]: ../CAEXObject/CAEXPath.md
[33]: ../../Aml.Engine.CAEX.Extensions/CAEXPathBuilder/README.md
[34]: ../CAEXBasicObject/CAEXSequence.md
[35]: ../CAEXBasicObject/Container__1.md
[36]: ../CAEXObject/Copy.md
[37]: ../CAEXWrapper/Equals.md
[38]: ../CAEXWrapper/GetHashCode.md
[39]: ../CAEXWrapper/GetXAttributeValue.md
[40]: ../CAEXBasicObject/Insert_1.md
[41]: ../CAEXBasicObject/Insert.md
[42]: InsertAfter.md
[43]: InsertBefore.md
[44]: ../CAEXWrapper/InsertNew.md
[45]: ../CAEXBasicObject/New_Revision.md
[46]: ../CAEXWrapper/Remove.md
[47]: ../CAEXWrapper/SetXAttributeValue.md
[48]: ../CAEXObject/ToString.md
[49]: ../CAEXWrapper/PropertyChanged.md
[50]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/AMLSchemaManager.md
[51]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[52]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Ancestors__1.md
[53]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXDocument.md
[54]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXFile.md
[55]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXSchema.md
[56]: ../../Aml.Engine.Adapter/AMLEngineAdapter/clone.md
[57]: ../CAEXWrapper/Copy.md
[58]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[59]: ../../Aml.Engine.Adapter/AMLEngineAdapter/CloneNode.md
[60]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ConsistencyCheck_ClassReference.md
[61]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/Copy.md
[62]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/README.md
[63]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[64]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[65]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[66]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[67]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[68]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[69]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[70]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[71]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[72]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/GetParent__1.md
[73]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedClass.md
[74]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedGUID.md
[75]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceClass.md
[76]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceName.md
[77]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_Element.md
[78]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_NewInstance.md
[79]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_TypeBaseElement.md
[80]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsAMLObject.md
[81]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[82]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Library.md
[83]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Name.md
[84]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[85]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Copyright.md
[86]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[87]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Version.md
[88]: ../IMultipleOccurrences_1/README.md
[89]: https://www.automationml.org
[90]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"