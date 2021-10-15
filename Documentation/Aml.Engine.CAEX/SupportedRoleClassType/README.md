SupportedRoleClassType Class
============================
This class is a wrapper for the CAEXElement 'SupportedRoleClass' assignable to a SystemUnitClass. Associated supported roles of a SystemUnitClass are used to specify some semantic meanings like features or functions for the associated object.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.CAEXWrapper][2]  
    [Aml.Engine.CAEX.CAEXBasicObject][3]  
      **Aml.Engine.CAEX.SupportedRoleClassType**  

  **Namespace:**  [Aml.Engine.CAEX][4]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class SupportedRoleClassType : CAEXBasicObject, 
	IObjectWithRoleReference, ICAEXWrapper, IXMLWrapper
```

The **SupportedRoleClassType** type exposes the following members.


Constructors
------------

                 | Name                        | Description                                                         
---------------- | --------------------------- | ------------------------------------------------------------------- 
![Public method] | [SupportedRoleClassType][5] | Initializes a new instance of the **SupportedRoleClassType** class. 


Properties
----------

                   | Name                          | Description                                                                                                                                                                                         
------------------ | ----------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AdditionalInformation][6]    | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                              
![Public property] | [CAEXDocument][7]             | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][2].) 
![Public property] | [CAEXParent][8]               | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][2].)                                                                                                               
![Public property] | [CAEXSequenceOfCAEXObject][9] | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                
![Public property] | [ChangeMode][10]              | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [CAEXBasicObject][3].)                                                                                         
![Public property] | [Copyright][11]               | Gets and sets the Copyright for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                 
![Public property] | [CopyrightElement][12]        | Gets the wrapper for the Copyright element. (Inherited from [CAEXBasicObject][3].)                                                                                                                  
![Public property] | [Description][13]             | Gets and sets the Description for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                               
![Public property] | [DescriptionElement][14]      | Gets the wrapper for the Description element. (Inherited from [CAEXBasicObject][3].)                                                                                                                
![Public property] | [Document][15]                | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                    
![Public property] | [Exists][16]                  | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                   
![Public property] | [MappingObject][17]           | Gets the MappingObject associated with a SupportedRoleClass. Mapping objects are used to define mappings between properties of the associated object and the role class itself.                     
![Public property] | [Node][18]                    | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                     
![Public property] | [Owner][19]                   | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][2].)                                                                                                                            
![Public property] | [RefRoleClassPath][20]        | Gets and sets the Attribute [ATTRIBUTE_NAME_REFROLECLASSPATH][21] of this SupportedRoleClass object.                                                                                                
![Public property] | [Revision][22]                | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                          
![Public property] | [RoleClass][23]               | Gets and sets the RoleClass, referenced from this SupportedRoleClass object using the [RefRoleClassPath][20].                                                                                       
![Public property] | [RoleReference][24]           | Gets or sets the role reference. This property is equivalent to [RefRoleClassPath][20].                                                                                                             
![Public property] | [SourceObjectInformation][25] | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                           
![Public property] | [SystemUnitClass][26]         | Gets the associated SystemUnitClass for this SupportedRoleClass object.                                                                                                                             
![Public property] | [TagName][27]                 | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][2].)                                                                                                              
![Public property] | [Version][28]                 | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                   
![Public property] | [VersionElement][29]          | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][3].)                                                                                                                    


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                                             
---------------- | ---------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [CAEXChild][30]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                             
![Public method] | [CAEXChildren][31]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                
![Public method] | [CAEXSequence][32]                 | Gets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects [Revision][22] is returned. (Inherited from [CAEXBasicObject][3].)                                              
![Public method] | [Container&lt;T>][33]              | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                               
![Public method] | [Copy][34]                         | Creates a deep copy of this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                              
![Public method] | [Equals][35]                       | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                           
![Public method] | [GetHashCode][36]                  | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                 
![Public method] | [GetXAttributeValue][37]           | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                    
![Public method] | [Insert(Int32, CAEXWrapper)][38]   | Inserts the specified CAEX object in it's associated sequence. The SupportedRoleClassType defines the [MappingType][39] (Overrides [CAEXBasicObject.Insert(Int32, CAEXWrapper)][40].)                                                                                                                   
![Public method] | [Insert(CAEXWrapper, Boolean)][41] | Inserts the specified CAEX object in it's associated sequence. The SupportedRoleClassType defines the [MappingType][39] (Overrides [CAEXBasicObject.Insert(CAEXWrapper, Boolean)][42].)                                                                                                                 
![Public method] | [InsertNew][43]                    | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][19] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][2].)                        
![Public method] | [New_MappingObject][44]            | Adding a new MappingObject element to this SupportedRoleClass.                                                                                                                                                                                                                                          
![Public method] | [New_Revision][45]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][22] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][3].) 
![Public method] | [Remove][46]                       | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                    
![Public method] | [SetXAttributeValue][47]           | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][2].)                                                                                                                                                                   


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][48] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][2].) 


Extension Methods
-----------------

                           | Name                                            | Description                                                                                                                                                                                                                                                                                                                                                                              
-------------------------- | ----------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [AMLSchemaManager][49]                          | Gets the associated CAEX schema manager of the CAEX object. (Defined by [CAEXBasicObjectExtensions][50].)                                                                                                                                                                                                                                                                                
![Public Extension Method] | [Ancestors&lt;T>][51]                           | Finds the ancestors of the provided CAEX object which have the given type. (Defined by [CAEXBasicObjectExtensions][50].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [CAEXDocument][52]                              | Gets the CAEX document which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][50].)                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [CAEXFile][53]                                  | Gets the CAEX file which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][50].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [CAEXSchema][54]                                | Gets the associated CAEX schema of the CAEX object. (Defined by [CAEXBasicObjectExtensions][50].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [clone][55]                                     | [Copy(Boolean, Boolean, Boolean)][34] (Defined by [AMLEngineAdapter][56].)                                                                                                                                                                                                                                                                                                               
![Public Extension Method] | [CloneNode][57]                                 | Clones the node. (Defined by [AMLEngineAdapter][56].)                                                                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [ConsistencyCheck_ClassReference][58]           | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][56].)                                                                                                                                                                                                                                                                  
![Public Extension Method] | [Descendants(Type)][59]                         | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][50].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [Descendants&lt;T>()][60]                       | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][50].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [Descendants&lt;T>(Boolean)][61]                | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][50].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [FindCaexObjectFromId&lt;T>][62]                | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][50].)                                                                                                                                                                                                                                                                        
![Public Extension Method] | [findInternalElement][63]                       | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][56].)                                                                                                                                                                                                                                                               
![Public Extension Method] | [FindReferencedClass&lt;T>][64]                 | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][50].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [FirstAncestor(String)][65]                     | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][50].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][66] | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][50].)                                                                                                                                                                                                                                    
![Public Extension Method] | [FirstAncestor&lt;T>()][67]                     | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][50].)                                                                                                                                                                                                                                                       
![Public Extension Method] | [GetParent&lt;T>][68]                           | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][50].)                                                                                                                                                                                 
![Public Extension Method] | [getReferencedClass][69]                        | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][56].)                                                                                                                                                                                                                                                                                                              
![Public Extension Method] | [getReferencedGUID][70]                         | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][56].)                                                                                                                                                                                                                                                                                      
![Public Extension Method] | [getReferencedInterfaceClass][71]               | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][56].)                                                                                                                                                                                                                                                                    
![Public Extension Method] | [getReferencedInterfaceName][72]                | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][56].)                                                                                                                                                                                                                                                                                                       
![Public Extension Method] | [Insert_Element][73]                            | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][56].)                                                                                                                                                              
![Public Extension Method] | [Insert_MappingObject][74]                      | Adding a MappingObject element to this Supported Role. (Defined by [AMLEngineAdapter][56].)                                                                                                                                                                                                                                                                                              
![Public Extension Method] | [Insert_NewInstance][75]                        | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][56].)                                                                                                                        
![Public Extension Method] | [Insert_TypeBaseElement][76]                    | [Insert(CAEXWrapper, Boolean)][42] (Defined by [AMLEngineAdapter][56].)                                                                                                                                                                                                                                                                                                                  
![Public Extension Method] | [IsAMLObject][77]                               | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][78].) 
![Public Extension Method] | [IsAutomationMLBaseRole][79]                    | Determines whether the specified role reference defines an inheritance relation from the AutomationMLBaseRole RoleClass (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                                 
![Public Extension Method] | [IsDerivedFromRoleClass][81]                    | Determines whether the specified role reference defines an inheritance relation from the role, uniquely identifiable by the given role class path. The role class path may contain an alias. (Defined by [InheritanceExtensions][82].)                                                                                                                                                   
![Public Extension Method] | [IsFacet][83]                                   | Determines whether the specified role reference defines an inheritance relation from the Facet RoleClass (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                                                
![Public Extension Method] | [IsFrame][84]                                   | Determines whether the specified role reference defines an inheritance relation from the Frame RoleClass (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                                                
![Public Extension Method] | [IsGroup][85]                                   | Determines whether the specified role reference defines an inheritance relation from the Group RoleClass (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                                                
![Public Extension Method] | [IsInterlockingSourceGroup][86]                 | Determines whether the specified role reference defines an inheritance relation from the InterlockingSourceGroup RoleClass (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                              
![Public Extension Method] | [IsInterlockingTargetGroup][87]                 | Determines whether the specified role reference defines an inheritance relation from the InterlockingTargetGroup RoleClass (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                              
![Public Extension Method] | [IsLogicObject][88]                             | Determines whether the specified role reference defines an inheritance relation from the LogicObject RoleClass (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                                          
![Public Extension Method] | [IsPort][89]                                    | Determines whether the specified role reference defines an inheritance relation from the Port RoleClass (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                                                 
![Public Extension Method] | [IsProcess][90]                                 | Determines whether the specified role reference defines an inheritance relation from the Process RoleClass (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                                              
![Public Extension Method] | [IsProcessStructure][91]                        | Determines whether the specified role reference defines an inheritance relation from the ProcessStructure RoleClass (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                                     
![Public Extension Method] | [IsProduct][92]                                 | Determines whether the specified role reference defines an inheritance relation from the Product RoleClass (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                                              
![Public Extension Method] | [IsProductStructure][93]                        | Determines whether the specified role reference defines an inheritance relation from the ProductStructure RoleClass (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                                     
![Public Extension Method] | [IsPropertySet][94]                             | Determines whether the specified role reference defines an inheritance relation from the PropertySet RoleClass (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                                          
![Public Extension Method] | [IsResource][95]                                | Determines whether the specified role reference defines an inheritance relation from the Resource RoleClass (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                                             
![Public Extension Method] | [IsResourceStructure][96]                       | Determines whether the specified role reference defines an inheritance relation from the ResourceStructure RoleClass (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                                    
![Public Extension Method] | [IsStructure][97]                               | Determines whether the specified role reference defines an inheritance relation from the Structure RoleClass (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                                            
![Public Extension Method] | [Library][98]                                   | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][50].)                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [MakeAutomationMLBaseRole][99]                  | Makes the AutomationML base role. (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                                                                                                                       
![Public Extension Method] | [MakeFacet][100]                                | Makes the facet. (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [MakeGroup][101]                                | Makes the group. (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [MakePort][102]                                 | Makes the port. (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                                                                                                                                         
![Public Extension Method] | [MakeProcess][103]                              | Makes the process. (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                                                                                                                                      
![Public Extension Method] | [MakeProcessStructure][104]                     | Makes the process structure. (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                                                                                                                            
![Public Extension Method] | [MakeProduct][105]                              | Makes the Product. (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                                                                                                                                      
![Public Extension Method] | [MakeProductStructure][106]                     | Makes the product structure. (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                                                                                                                            
![Public Extension Method] | [MakePropertySet][107]                          | Makes the property set. (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                                                                                                                                 
![Public Extension Method] | [MakeResource][108]                             | Makes the resource. (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                                                                                                                                     
![Public Extension Method] | [MakeResourceStructure][109]                    | Makes the resource structure. (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                                                                                                                           
![Public Extension Method] | [MakeStructure][110]                            | Makes the structure. (Defined by [AutomationMLBaseRoleClassLib][80].)                                                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [Name()][111]                                   | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][56].)                                                                                                                                                                                                                                                                                                   
![Public Extension Method] | [Name()][112]                                   | Overloaded. Gets a names for the specified CAEX wrapper object. If the specified object is a [CAEXObject][113], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][50].)                                                                                                                                                              
![Public Extension Method] | [New_Description][114]                          | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][50].)                                                                                                                                                                                                                                                                          


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][4]  
[Aml.Engine.CAEX.CAEXBasicObject][3]  
[Aml.Engine.CAEX.IObjectWithRoleReference][115]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../CAEXWrapper/README.md
[3]: ../CAEXBasicObject/README.md
[4]: ../README.md
[5]: _ctor.md
[6]: ../CAEXBasicObject/AdditionalInformation.md
[7]: ../CAEXWrapper/CAEXDocument.md
[8]: ../CAEXWrapper/CAEXParent.md
[9]: ../CAEXWrapper/CAEXSequenceOfCAEXObject.md
[10]: ../CAEXBasicObject/ChangeMode.md
[11]: ../CAEXBasicObject/Copyright.md
[12]: ../CAEXBasicObject/CopyrightElement.md
[13]: ../CAEXBasicObject/Description.md
[14]: ../CAEXBasicObject/DescriptionElement.md
[15]: ../CAEXWrapper/Document.md
[16]: ../CAEXWrapper/Exists.md
[17]: MappingObject.md
[18]: ../CAEXWrapper/Node.md
[19]: ../CAEXWrapper/Owner.md
[20]: RefRoleClassPath.md
[21]: ../CAEX_CLASSModel_TagNames/ATTRIBUTE_NAME_REFROLECLASSPATH.md
[22]: ../CAEXBasicObject/Revision.md
[23]: RoleClass.md
[24]: RoleReference.md
[25]: ../CAEXBasicObject/SourceObjectInformation.md
[26]: SystemUnitClass.md
[27]: ../CAEXWrapper/TagName.md
[28]: ../CAEXBasicObject/Version.md
[29]: ../CAEXBasicObject/VersionElement.md
[30]: ../CAEXWrapper/CAEXChild.md
[31]: ../CAEXWrapper/CAEXChildren.md
[32]: ../CAEXBasicObject/CAEXSequence.md
[33]: ../CAEXBasicObject/Container__1.md
[34]: ../CAEXWrapper/Copy.md
[35]: ../CAEXWrapper/Equals.md
[36]: ../CAEXWrapper/GetHashCode.md
[37]: ../CAEXWrapper/GetXAttributeValue.md
[38]: Insert_1.md
[39]: ../MappingType/README.md
[40]: ../CAEXBasicObject/Insert_1.md
[41]: Insert.md
[42]: ../CAEXBasicObject/Insert.md
[43]: ../CAEXWrapper/InsertNew.md
[44]: New_MappingObject.md
[45]: ../CAEXBasicObject/New_Revision.md
[46]: ../CAEXWrapper/Remove.md
[47]: ../CAEXWrapper/SetXAttributeValue.md
[48]: ../CAEXWrapper/PropertyChanged.md
[49]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/AMLSchemaManager.md
[50]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[51]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Ancestors__1.md
[52]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXDocument.md
[53]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXFile.md
[54]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXSchema.md
[55]: ../../Aml.Engine.Adapter/AMLEngineAdapter/clone.md
[56]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[57]: ../../Aml.Engine.Adapter/AMLEngineAdapter/CloneNode.md
[58]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ConsistencyCheck_ClassReference.md
[59]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[60]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[61]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[62]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[63]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[64]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[65]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[66]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[67]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[68]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/GetParent__1.md
[69]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedClass.md
[70]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedGUID.md
[71]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceClass.md
[72]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceName.md
[73]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_Element.md
[74]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_MappingObject_1.md
[75]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_NewInstance.md
[76]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_TypeBaseElement.md
[77]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsAMLObject.md
[78]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[79]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsAutomationMLBaseRole.md
[80]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/README.md
[81]: ../../Aml.Engine.CAEX.Extensions/InheritanceExtensions/IsDerivedFromRoleClass.md
[82]: ../../Aml.Engine.CAEX.Extensions/InheritanceExtensions/README.md
[83]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsFacet.md
[84]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsFrame.md
[85]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsGroup.md
[86]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsInterlockingSourceGroup.md
[87]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsInterlockingTargetGroup.md
[88]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsLogicObject.md
[89]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsPort.md
[90]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsProcess.md
[91]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsProcessStructure.md
[92]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsProduct.md
[93]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsProductStructure.md
[94]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsPropertySet.md
[95]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsResource.md
[96]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsResourceStructure.md
[97]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsStructure.md
[98]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Library.md
[99]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/MakeAutomationMLBaseRole.md
[100]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/MakeFacet.md
[101]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/MakeGroup.md
[102]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/MakePort.md
[103]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/MakeProcess.md
[104]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/MakeProcessStructure.md
[105]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/MakeProduct.md
[106]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/MakeProductStructure.md
[107]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/MakePropertySet.md
[108]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/MakeResource.md
[109]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/MakeResourceStructure.md
[110]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/MakeStructure.md
[111]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Name.md
[112]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[113]: ../CAEXObject/README.md
[114]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[115]: ../IObjectWithRoleReference/README.md
[116]: https://www.automationml.org
[117]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"