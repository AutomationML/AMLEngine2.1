IMappingElementType Interface
=============================
AutomationML 2.1 APIInterface implemented by Mapping elements [InterfaceNameMappingType][1], [InterfaceIDMappingType][2], and [AttributeNameMappingType][3].

  **Namespace:**  [Aml.Engine.CAEX][4]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public interface IMappingElementType : IMapping, 
	ICAEXBasicObject, ICAEXWrapper, IXMLWrapper
```

The **IMappingElementType** type exposes the following members.


Properties
----------

                   | Name                                   | Description                                                                                                                                                                                                                                                
------------------ | -------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AdditionalInformation][5]             | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [ICAEXBasicObject][6].)                                                                                                                                    
![Public property] | [CAEXParent][7]                        | Gets the CAEXParent of this CAEX object (Inherited from [ICAEXWrapper][8].)                                                                                                                                                                                
![Public property] | [ChangeMode][9]                        | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [ICAEXBasicObject][6].)                                                                                                                                               
![Public property] | [Copyright][10]                        | Gets and sets the Copyright for this object. (Inherited from [ICAEXBasicObject][6].)                                                                                                                                                                       
![Public property] | [CopyrightElement][11]                 | Gets the wrapper for the Copyright element. (Inherited from [ICAEXBasicObject][6].)                                                                                                                                                                        
![Public property] | [Description][12]                      | Gets and sets the Description for this object. (Inherited from [ICAEXBasicObject][6].)                                                                                                                                                                     
![Public property] | [DescriptionElement][13]               | Gets the wrapper for the Description element. (Inherited from [ICAEXBasicObject][6].)                                                                                                                                                                      
![Public property] | [Document][14]                         | Gets the XDocument containing the XML node of this object. If the object has not been inserted into a document, the XDocument is `null`. Direct manipulations of the XML document are not monitored by the AML engine. (Inherited from [IXMLWrapper][15].) 
![Public property] | [Exists][16]                           | Determines, if this instance is wrapped around an existing XML node (Inherited from [IXMLWrapper][15].)                                                                                                                                                    
![Public property] | [MappingObject][17]                    | Gets the mapping object which contains this Mapping Element. (Inherited from [IMapping][18].)                                                                                                                                                              
![Public property] | [MappingRoleClass][19]                 | Gets the RoleClass, which provides the mapping elements.                                                                                                                                                                                                   
![Public property] | [MappingSystemUnitClass][20]           | Gets the SystemUnitClass, which is either an [InternalElementType][21] or a [SystemUnitFamilyType][22], which provides the mapping elements.                                                                                                               
![Public property] | [Node][23]                             | Get the XML node of this instance. Direct manipulations of the XML node are not monitored by the AML engine. (Inherited from [IXMLWrapper][15].)                                                                                                           
![Public property] | [Owner][24]                            | Gets the XML parent node of this instance. Direct manipulations of the XML node are not monitored by the AML engine. (Inherited from [IXMLWrapper][15].)                                                                                                   
![Public property] | [Revision][25]                         | Gets the collection of Revision objects contained in this instance. (Inherited from [ICAEXBasicObject][6].)                                                                                                                                                
![Public property] | [RoleClassElementIdentifier][26]       | Gets and sets the identifier for the mapped RoleClass element.                                                                                                                                                                                             
![Public property] | [SourceObjectInformation][27]          | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [ICAEXBasicObject][6].)                                                                                                                                 
![Public property] | [SystemUnitClassElementIdentifier][28] | Gets or sets the identifier for the mapped SystemUnitClass element.                                                                                                                                                                                        
![Public property] | [TagName][29]                          | Gets the Schema Tag name of this instance. (Inherited from [IXMLWrapper][15].)                                                                                                                                                                             
![Public property] | [Version][30]                          | Gets and sets the Version for this object. (Inherited from [ICAEXBasicObject][6].)                                                                                                                                                                         
![Public property] | [VersionElement][31]                   | Gets the wrapper for the Version element. (Inherited from [ICAEXBasicObject][6].)                                                                                                                                                                          


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                                              
---------------- | ---------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [CAEXChild][32]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [ICAEXWrapper][8].)                                                                                                                                                                                             
![Public method] | [CAEXChildren][33]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [ICAEXWrapper][8].)                                                                                                                                                                                                
![Public method] | [CAEXSequence][34]                 | Gets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects [Revision][25] is returned. (Inherited from [ICAEXBasicObject][6].)                                              
![Public method] | [Container&lt;T>][35]              | Gets the CAEXSequence for elements of type T, which is owned by this CAEX object. (Inherited from [ICAEXBasicObject][6].)                                                                                                                                                                                
![Public method] | [Insert(Int32, CAEXWrapper)][36]   | Inserts the specified CAEX object in it's associated sequence at the defined position. The CAEXBasicObject defines the [Revision][25] and [SourceObjectInformation][27] sequences. (Inherited from [ICAEXBasicObject][6].)                                                                               
![Public method] | [Insert(CAEXWrapper, Boolean)][37] | Inserts the specified CAEX object in it's associated sequence. The CAEXBasicObject defines the [Revision][25] and [SourceObjectInformation][27] sequences. (Inherited from [ICAEXBasicObject][6].)                                                                                                       
![Public method] | [New_Revision][38]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][25] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [ICAEXBasicObject][6].) 
![Public method] | [Remove][39]                       | Removes this object (Inherited from [ICAEXWrapper][8].)                                                                                                                                                                                                                                                  


Extension Methods
-----------------

                           | Name                                            | Description                                                                                                                                                                                                                                                                                                                                                                              
-------------------------- | ----------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [AMLSchemaManager][40]                          | Gets the associated CAEX schema manager of the CAEX object. (Defined by [CAEXBasicObjectExtensions][41].)                                                                                                                                                                                                                                                                                
![Public Extension Method] | [Ancestors&lt;T>][42]                           | Finds the ancestors of the provided CAEX object which have the given type. (Defined by [CAEXBasicObjectExtensions][41].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [CAEXDocument][43]                              | Gets the CAEX document which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][41].)                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [CAEXFile][44]                                  | Gets the CAEX file which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][41].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [CAEXSchema][45]                                | Gets the associated CAEX schema of the CAEX object. (Defined by [CAEXBasicObjectExtensions][41].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [Descendants&lt;T>][46]                         | Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][41].)                                                                                                                                                                                                                                                             
![Public Extension Method] | [FindCaexObjectFromId&lt;T>][47]                | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][41].)                                                                                                                                                                                                                                                                        
![Public Extension Method] | [FindReferencedClass&lt;T>][48]                 | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][41].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [FirstAncestor(String)][49]                     | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][41].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][50] | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][41].)                                                                                                                                                                                                                                    
![Public Extension Method] | [FirstAncestor&lt;T>()][51]                     | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][41].)                                                                                                                                                                                                                                                       
![Public Extension Method] | [GetParent&lt;T>][52]                           | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][41].)                                                                                                                                                                                 
![Public Extension Method] | [IsAMLObject][53]                               | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][54].) 
![Public Extension Method] | [Library][55]                                   | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][41].)                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [New_Copyright][56]                             | Adds an new Copyright node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][41].)                                                                                                                                                                                                                                                                            
![Public Extension Method] | [New_Version][57]                               | Adds an new Version node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][41].)                                                                                                                                                                                                                                                                              


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][4]  
[Aml.Engine.CAEX.IMapping][18]  

[1]: ../InterfaceNameMappingType/README.md
[2]: ../InterfaceIDMappingType/README.md
[3]: ../AttributeNameMappingType/README.md
[4]: ../README.md
[5]: ../ICAEXBasicObject/AdditionalInformation.md
[6]: ../ICAEXBasicObject/README.md
[7]: ../ICAEXWrapper/CAEXParent.md
[8]: ../ICAEXWrapper/README.md
[9]: ../ICAEXBasicObject/ChangeMode.md
[10]: ../ICAEXBasicObject/Copyright.md
[11]: ../ICAEXBasicObject/CopyrightElement.md
[12]: ../ICAEXBasicObject/Description.md
[13]: ../ICAEXBasicObject/DescriptionElement.md
[14]: ../../Aml.Engine.XML/IXMLWrapper/Document.md
[15]: ../../Aml.Engine.XML/IXMLWrapper/README.md
[16]: ../../Aml.Engine.XML/IXMLWrapper/Exists.md
[17]: ../IMapping/MappingObject.md
[18]: ../IMapping/README.md
[19]: MappingRoleClass.md
[20]: MappingSystemUnitClass.md
[21]: ../InternalElementType/README.md
[22]: ../SystemUnitFamilyType/README.md
[23]: ../../Aml.Engine.XML/IXMLWrapper/Node.md
[24]: ../../Aml.Engine.XML/IXMLWrapper/Owner.md
[25]: ../ICAEXBasicObject/Revision.md
[26]: RoleClassElementIdentifier.md
[27]: ../ICAEXBasicObject/SourceObjectInformation.md
[28]: SystemUnitClassElementIdentifier.md
[29]: ../../Aml.Engine.XML/IXMLWrapper/TagName.md
[30]: ../ICAEXBasicObject/Version.md
[31]: ../ICAEXBasicObject/VersionElement.md
[32]: ../ICAEXWrapper/CAEXChild.md
[33]: ../ICAEXWrapper/CAEXChildren.md
[34]: ../ICAEXBasicObject/CAEXSequence.md
[35]: ../ICAEXBasicObject/Container__1.md
[36]: ../ICAEXBasicObject/Insert_1.md
[37]: ../ICAEXBasicObject/Insert.md
[38]: ../ICAEXBasicObject/New_Revision.md
[39]: ../ICAEXWrapper/Remove.md
[40]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/AMLSchemaManager.md
[41]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[42]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Ancestors__1.md
[43]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXDocument.md
[44]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXFile.md
[45]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXSchema.md
[46]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[47]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[48]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[49]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[50]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[51]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[52]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/GetParent__1.md
[53]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsAMLObject.md
[54]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[55]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Library.md
[56]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Copyright.md
[57]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Version.md
[58]: https://www.automationml.org
[59]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"