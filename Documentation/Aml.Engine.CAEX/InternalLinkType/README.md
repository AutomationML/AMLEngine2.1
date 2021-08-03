InternalLinkType Class
======================
AutomationML 2.1 APIThis Class is a wrapper for the CAEXElement 'InternalLink' that defines instance to instance relations using ExternalInterfaces to relate InternalElement- and SystemUnitClass-Objects.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.CAEXWrapper][2]  
    [Aml.Engine.CAEX.CAEXBasicObject][3]  
      [Aml.Engine.CAEX.CAEXObject][4]  
        **Aml.Engine.CAEX.InternalLinkType**  

  **Namespace:**  [Aml.Engine.CAEX][5]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class InternalLinkType : CAEXObject, 
	IMultipleOccurrences<InternalLinkType>, ICAEXBasicObject, ICAEXWrapper, IXMLWrapper
```

The **InternalLinkType** type exposes the following members.


Constructors
------------

                 | Name                  | Description                                                   
---------------- | --------------------- | ------------------------------------------------------------- 
![Public method] | [InternalLinkType][6] | Initializes a new instance of the **InternalLinkType** class. 


Properties
----------

                   | Name                           | Description                                                                                                                                                                                                                                                                                                      
------------------ | ------------------------------ | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AdditionalInformation][7]     | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                           
![Public property] | [AInterface][8]                | Gets and sets the AInterface of the InternalLink by reading or setting the [RefPartnerSideA][9] Attribute. A read access to this property updates the [RelatedObjects][10].                                                                                                                                      
![Public property] | [ASystemUnitClass][11]         | Gets the SystemUnitClass associated to the [AInterface][8].                                                                                                                                                                                                                                                      
![Public property] | [BInterface][12]               | Gets and sets the BInterface of the InternalLink by reading or setting the [RefPartnerSideB][13] Attribute. A read access to this property updates the [RelatedObjects][10].                                                                                                                                     
![Public property] | [BSystemUnitClass][14]         | Gets the SystemUnitClass associated to the [BInterface][12].                                                                                                                                                                                                                                                     
![Public property] | [CAEXDocument][15]             | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][2].)                                                                                                              
![Public property] | [CAEXParent][16]               | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                            
![Public property] | [CAEXSequenceOfCAEXObject][17] | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                             
![Public property] | [ChangeMode][18]               | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                      
![Public property] | [Copyright][19]                | Gets and sets the Copyright for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                              
![Public property] | [CopyrightElement][20]         | Gets the wrapper for the Copyright element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                               
![Public property] | [Description][21]              | Gets and sets the Description for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                            
![Public property] | [DescriptionElement][22]       | Gets the wrapper for the Description element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                             
![Public property] | [Document][23]                 | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                 
![Public property] | [Exists][24]                   | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                
![Public property] | [ID][25]                       | Gets and sets a unique identifier of the CAEX object (optional in CAEX). AutomationML requires IDs for some Elements. These IDs are automatically set when such elements are created. (Inherited from [CAEXObject][4].)                                                                                          
![Public property] | [IsDefined][26]                | Determines, if this InternalLink Instance has defined Interfaces.                                                                                                                                                                                                                                                
![Public property] | [Name][27]                     | Gets and sets the name of the CAEX object (required in CAEX). (Inherited from [CAEXObject][4].)                                                                                                                                                                                                                  
![Public property] | [Node][28]                     | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                  
![Public property] | [Owner][29]                    | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                         
![Public property] | [RefPartnerSideA][9]           | Gets and sets the Path to an ExternalInterface, defining the A-Side of the relation.                                                                                                                                                                                                                             
![Public property] | [RefPartnerSideB][13]          | Gets and sets the Path to an ExternalInterface, defining the B-Side of the relation.                                                                                                                                                                                                                             
![Public property] | [RelatedObjects][10]           | Gets the related objects for the InternalLink. This property allows to access the listed related objects without recalculation. [AInterface][8][BInterface][12][ASystemUnitClass][11][BSystemUnitClass][14] A direct access to one of the listed properties results in a recalculation of the accessed property. 
![Public property] | [Revision][30]                 | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                       
![Public property] | [SourceObjectInformation][31]  | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                        
![Public property] | [TagName][32]                  | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                           
![Public property] | [Version][33]                  | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                
![Public property] | [VersionElement][34]           | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                 


Methods
-------

                                 | Name                               | Description                                                                                                                                                                                                                                                                                                                                                                                             
-------------------------------- | ---------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]                 | [AssignNewGuidAsID][35]            | Assigns the new unique identifier as a new ID to this CAEX object. (Inherited from [CAEXObject][4].)                                                                                                                                                                                                                                                                                                    
![Public method]                 | [CAEXChild][36]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                             
![Public method]                 | [CAEXChildren][37]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                
![Public method]                 | [CAEXPath][38]                     | Gets the CAEX path for this object. A path can be used to uniquely reference an object, for example in inheritances and instances. The path syntax for an object is defined differently in CAEX 2.15 and CAEX 3.0. The engine uses the [CAEXPathBuilder][39] to generate the CAEX path of an object according to the documents CAEX version. (Inherited from [CAEXObject][4].)                          
![Public method]                 | [CAEXSequence][40]                 | Gets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects [Revision][30] is returned. (Inherited from [CAEXBasicObject][3].)                                                                                                                                              
![Public method]                 | [Container&lt;T>][41]              | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                                                                                               
![Public method]                 | [Copy][42]                         | Creates a deep copy of this CAEX object, containing all child elements. The created copy will have replaced unique IDs and updated references, if the *assignNewIDs* is set to true (default). When a CAEX class is copied, the nested classes that can exist for AttributeType, RoleClass, SystemUnitClass, and InterfaceClass are not included in the created copy. (Inherited from [CAEXObject][4].) 
![Public method]                 | [Equals][43]                       | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                           
![Public method]                 | [GetHashCode][44]                  | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                 
![Public method]                 | [GetXAttributeValue][45]           | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                    
![Public method]                 | [Insert(Int32, CAEXWrapper)][46]   | Inserts the specified CAEX object in it's associated sequence at the defined position. The CAEXBasicObject defines the [Revision][30] and [SourceObjectInformation][31] sequences. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                               
![Public method]                 | [Insert(CAEXWrapper, Boolean)][47] | Inserts the specified CAEX object in it's associated sequence. The CAEXBasicObject defines the [Revision][30] and [SourceObjectInformation][31] sequences. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                                       
![Public method]                 | [InsertAfter][48]                  | Inserts the provided CAEX object as a new sibling after this CAEX object.                                                                                                                                                                                                                                                                                                                               
![Public method]                 | [InsertBefore][49]                 | Inserts the provided CAEX object as a new sibling before this CAEX object.                                                                                                                                                                                                                                                                                                                              
![Public method]                 | [InsertNew][50]                    | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][29] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][2].)                                                                                                                        
![Public method]                 | [InterfaceFromAttributeValue][51]  | Gets the Interface from the provided InternalLink Attribute value, which is from [RefPartnerSideA][9] or from the [RefPartnerSideB][13] attribute.                                                                                                                                                                                                                                                      
![Public method]![Static member] | [New_InternalLink][52]             | Creates a new InternalLink object and append it to the lowest common parent of the SystemUnitClass objects, associated with the provided ExternalInterface objects. If no common parent exists, the InternalLink will be associated with the owner of the *aInterface*.                                                                                                                                 
![Public method]                 | [New_Revision][53]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][30] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][3].)                                                                                                 
![Public method]                 | [Remove][54]                       | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                    
![Public method]                 | [SetXAttributeValue][55]           | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                   
![Public method]                 | [ToString][56]                     | Returns the value of the 'Name' attribute of this CAEX object as the string representation of the object. (Inherited from [CAEXObject][4].)                                                                                                                                                                                                                                                             


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][57] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][2].) 


Fields
------

                                | Name                 | Description                                                                                                   
------------------------------- | -------------------- | ------------------------------------------------------------------------------------------------------------- 
![Public field]![Static member] | [LINK_SEPARATOR][58] | definition of the separator used for qualifying an interface of an internal element via syntax GUID:Interface 


Extension Methods
-----------------

                           | Name                                            | Description                                                                                                                                                                                                                                                                                                                                                                              
-------------------------- | ----------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [AMLSchemaManager][59]                          | Gets the associated CAEX schema manager of the CAEX object. (Defined by [CAEXBasicObjectExtensions][60].)                                                                                                                                                                                                                                                                                
![Public Extension Method] | [Ancestors&lt;T>][61]                           | Finds the ancestors of the provided CAEX object which have the given type. (Defined by [CAEXBasicObjectExtensions][60].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [CAEXDocument][62]                              | Gets the CAEX document which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][60].)                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [CAEXFile][63]                                  | Gets the CAEX file which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][60].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [CAEXSchema][64]                                | Gets the associated CAEX schema of the CAEX object. (Defined by [CAEXBasicObjectExtensions][60].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [clone][65]                                     | [Copy(Boolean, Boolean, Boolean)][66] (Defined by [AMLEngineAdapter][67].)                                                                                                                                                                                                                                                                                                               
![Public Extension Method] | [CloneNode][68]                                 | Clones the node. (Defined by [AMLEngineAdapter][67].)                                                                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [ConsistencyCheck_ClassReference][69]           | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][67].)                                                                                                                                                                                                                                                                  
![Public Extension Method] | [Descendants(Type)][70]                         | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][60].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [Descendants&lt;T>()][71]                       | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][60].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [Descendants&lt;T>(Boolean)][72]                | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][60].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [FindCaexObjectFromId&lt;T>][73]                | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][60].)                                                                                                                                                                                                                                                                        
![Public Extension Method] | [findInternalElement][74]                       | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][67].)                                                                                                                                                                                                                                                               
![Public Extension Method] | [FindReferencedClass&lt;T>][75]                 | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][60].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [FirstAncestor(String)][76]                     | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][60].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][77] | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][60].)                                                                                                                                                                                                                                    
![Public Extension Method] | [FirstAncestor&lt;T>()][78]                     | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][60].)                                                                                                                                                                                                                                                       
![Public Extension Method] | [GetParent&lt;T>][79]                           | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][60].)                                                                                                                                                                                 
![Public Extension Method] | [getReferencedClass][80]                        | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][67].)                                                                                                                                                                                                                                                                                                              
![Public Extension Method] | [getReferencedGUID][81]                         | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][67].)                                                                                                                                                                                                                                                                                      
![Public Extension Method] | [getReferencedInterfaceClass][82]               | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][67].)                                                                                                                                                                                                                                                                    
![Public Extension Method] | [getReferencedInterfaceName][83]                | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][67].)                                                                                                                                                                                                                                                                                                       
![Public Extension Method] | [Insert_Element][84]                            | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][67].)                                                                                                                                                              
![Public Extension Method] | [Insert_NewInstance][85]                        | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][67].)                                                                                                                        
![Public Extension Method] | [Insert_TypeBaseElement][86]                    | [Insert(CAEXWrapper, Boolean)][47] (Defined by [AMLEngineAdapter][67].)                                                                                                                                                                                                                                                                                                                  
![Public Extension Method] | [IsAMLObject][87]                               | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][88].) 
![Public Extension Method] | [Library][89]                                   | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][60].)                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [Name()][90]                                    | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][67].)                                                                                                                                                                                                                                                                                                   
![Public Extension Method] | [Name()][91]                                    | Overloaded. Gets a names for the specified caex wrapper object. If the specified object is a [CAEXObject][4], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][60].)                                                                                                                                                                
![Public Extension Method] | [New_Copyright][92]                             | Adds an new Copyright node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][60].)                                                                                                                                                                                                                                                                            
![Public Extension Method] | [New_Description][93]                           | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][60].)                                                                                                                                                                                                                                                                          
![Public Extension Method] | [New_Version][94]                               | Adds an new Version node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][60].)                                                                                                                                                                                                                                                                              


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][5]  
[Aml.Engine.CAEX.CAEXObject][4]  
[Aml.Engine.CAEX.IMultipleOccurrences&lt;T>][95]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../CAEXWrapper/README.md
[3]: ../CAEXBasicObject/README.md
[4]: ../CAEXObject/README.md
[5]: ../README.md
[6]: _ctor.md
[7]: ../CAEXBasicObject/AdditionalInformation.md
[8]: AInterface.md
[9]: RefPartnerSideA.md
[10]: RelatedObjects.md
[11]: ASystemUnitClass.md
[12]: BInterface.md
[13]: RefPartnerSideB.md
[14]: BSystemUnitClass.md
[15]: ../CAEXWrapper/CAEXDocument.md
[16]: ../CAEXWrapper/CAEXParent.md
[17]: ../CAEXWrapper/CAEXSequenceOfCAEXObject.md
[18]: ../CAEXBasicObject/ChangeMode.md
[19]: ../CAEXBasicObject/Copyright.md
[20]: ../CAEXBasicObject/CopyrightElement.md
[21]: ../CAEXBasicObject/Description.md
[22]: ../CAEXBasicObject/DescriptionElement.md
[23]: ../CAEXWrapper/Document.md
[24]: ../CAEXWrapper/Exists.md
[25]: ../CAEXObject/ID.md
[26]: IsDefined.md
[27]: ../CAEXObject/Name.md
[28]: ../CAEXWrapper/Node.md
[29]: ../CAEXWrapper/Owner.md
[30]: ../CAEXBasicObject/Revision.md
[31]: ../CAEXBasicObject/SourceObjectInformation.md
[32]: ../CAEXWrapper/TagName.md
[33]: ../CAEXBasicObject/Version.md
[34]: ../CAEXBasicObject/VersionElement.md
[35]: ../CAEXObject/AssignNewGuidAsID.md
[36]: ../CAEXWrapper/CAEXChild.md
[37]: ../CAEXWrapper/CAEXChildren.md
[38]: ../CAEXObject/CAEXPath.md
[39]: ../../Aml.Engine.CAEX.Extensions/CAEXPathBuilder/README.md
[40]: ../CAEXBasicObject/CAEXSequence.md
[41]: ../CAEXBasicObject/Container__1.md
[42]: ../CAEXObject/Copy.md
[43]: ../CAEXWrapper/Equals.md
[44]: ../CAEXWrapper/GetHashCode.md
[45]: ../CAEXWrapper/GetXAttributeValue.md
[46]: ../CAEXBasicObject/Insert_1.md
[47]: ../CAEXBasicObject/Insert.md
[48]: InsertAfter.md
[49]: InsertBefore.md
[50]: ../CAEXWrapper/InsertNew.md
[51]: InterfaceFromAttributeValue.md
[52]: New_InternalLink.md
[53]: ../CAEXBasicObject/New_Revision.md
[54]: ../CAEXWrapper/Remove.md
[55]: ../CAEXWrapper/SetXAttributeValue.md
[56]: ../CAEXObject/ToString.md
[57]: ../CAEXWrapper/PropertyChanged.md
[58]: LINK_SEPARATOR.md
[59]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/AMLSchemaManager.md
[60]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[61]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Ancestors__1.md
[62]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXDocument.md
[63]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXFile.md
[64]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXSchema.md
[65]: ../../Aml.Engine.Adapter/AMLEngineAdapter/clone.md
[66]: ../CAEXWrapper/Copy.md
[67]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[68]: ../../Aml.Engine.Adapter/AMLEngineAdapter/CloneNode.md
[69]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ConsistencyCheck_ClassReference.md
[70]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[71]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[72]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[73]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[74]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[75]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[76]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[77]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[78]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[79]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/GetParent__1.md
[80]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedClass.md
[81]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedGUID.md
[82]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceClass.md
[83]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceName.md
[84]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_Element.md
[85]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_NewInstance.md
[86]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_TypeBaseElement.md
[87]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsAMLObject.md
[88]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[89]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Library.md
[90]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Name.md
[91]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[92]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Copyright.md
[93]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[94]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Version.md
[95]: ../IMultipleOccurrences_1/README.md
[96]: https://www.automationml.org
[97]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Static member]: ../../icons/static.gif "Static member"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public field]: ../../icons/pubfield.gif "Public field"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"