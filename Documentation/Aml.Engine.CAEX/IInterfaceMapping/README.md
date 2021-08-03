IInterfaceMapping Interface
===========================
AutomationML 2.1 APISince CAEX 3.0 a new definition has been added to model Interface mappings using the ID of the mapped ExternalInterface. This Interface has been designed, to support InterfaceMapping access to the CAEX documents, defined using prior schema versions.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public interface IInterfaceMapping : IMapping, 
	ICAEXBasicObject, ICAEXWrapper, IXMLWrapper
```

The **IInterfaceMapping** type exposes the following members.


Properties
----------

                   | Name                          | Description                                                                                                                                                                                                                                                
------------------ | ----------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AdditionalInformation][2]    | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                    
![Public property] | [CAEXParent][4]               | Gets the CAEXParent of this CAEX object (Inherited from [ICAEXWrapper][5].)                                                                                                                                                                                
![Public property] | [ChangeMode][6]               | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [ICAEXBasicObject][3].)                                                                                                                                               
![Public property] | [Copyright][7]                | Gets and sets the Copyright for this object. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                                       
![Public property] | [CopyrightElement][8]         | Gets the wrapper for the Copyright element. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                                        
![Public property] | [Description][9]              | Gets and sets the Description for this object. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                                     
![Public property] | [DescriptionElement][10]      | Gets the wrapper for the Description element. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                                      
![Public property] | [Document][11]                | Gets the XDocument containing the XML node of this object. If the object has not been inserted into a document, the XDocument is `null`. Direct manipulations of the XML document are not monitored by the AML engine. (Inherited from [IXMLWrapper][12].) 
![Public property] | [Exists][13]                  | Determines, if this instance is wrapped around an existing XML node (Inherited from [IXMLWrapper][12].)                                                                                                                                                    
![Public property] | [MappingObject][14]           | Gets the mapping object which contains this Mapping Element. (Inherited from [IMapping][15].)                                                                                                                                                              
![Public property] | [Node][16]                    | Get the XML node of this instance. Direct manipulations of the XML node are not monitored by the AML engine. (Inherited from [IXMLWrapper][12].)                                                                                                           
![Public property] | [Owner][17]                   | Gets the XML parent node of this instance. Direct manipulations of the XML node are not monitored by the AML engine. (Inherited from [IXMLWrapper][12].)                                                                                                   
![Public property] | [Revision][18]                | Gets the collection of Revision objects contained in this instance. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                
![Public property] | [RoleInterface][19]           | Gets and sets the mapped ExternalInterface of the role reference                                                                                                                                                                                           
![Public property] | [SourceObjectInformation][20] | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                 
![Public property] | [SystemUnitInterface][21]     | Gets and sets the mapped ExternalInterface of the SystemUnitClass                                                                                                                                                                                          
![Public property] | [TagName][22]                 | Gets the Schema Tag name of this instance. (Inherited from [IXMLWrapper][12].)                                                                                                                                                                             
![Public property] | [Version][23]                 | Gets and sets the Version for this object. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                                         
![Public property] | [VersionElement][24]          | Gets the wrapper for the Version element. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                                          


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                                              
---------------- | ---------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [CAEXChild][25]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [ICAEXWrapper][5].)                                                                                                                                                                                             
![Public method] | [CAEXChildren][26]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [ICAEXWrapper][5].)                                                                                                                                                                                                
![Public method] | [CAEXSequence][27]                 | Gets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects [Revision][18] is returned. (Inherited from [ICAEXBasicObject][3].)                                              
![Public method] | [Container&lt;T>][28]              | Gets the CAEXSequence for elements of type T, which is owned by this CAEX object. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                                                
![Public method] | [Insert(Int32, CAEXWrapper)][29]   | Inserts the specified CAEX object in it's associated sequence at the defined position. The CAEXBasicObject defines the [Revision][18] and [SourceObjectInformation][20] sequences. (Inherited from [ICAEXBasicObject][3].)                                                                               
![Public method] | [Insert(CAEXWrapper, Boolean)][30] | Inserts the specified CAEX object in it's associated sequence. The CAEXBasicObject defines the [Revision][18] and [SourceObjectInformation][20] sequences. (Inherited from [ICAEXBasicObject][3].)                                                                                                       
![Public method] | [New_Revision][31]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][18] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [ICAEXBasicObject][3].) 
![Public method] | [Remove][32]                       | Removes this object (Inherited from [ICAEXWrapper][5].)                                                                                                                                                                                                                                                  


Extension Methods
-----------------

                           | Name                                            | Description                                                                                                                                                                                                                                                                                                                                                                              
-------------------------- | ----------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [AMLSchemaManager][33]                          | Gets the associated CAEX schema manager of the CAEX object. (Defined by [CAEXBasicObjectExtensions][34].)                                                                                                                                                                                                                                                                                
![Public Extension Method] | [Ancestors&lt;T>][35]                           | Finds the ancestors of the provided CAEX object which have the given type. (Defined by [CAEXBasicObjectExtensions][34].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [CAEXDocument][36]                              | Gets the CAEX document which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][34].)                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [CAEXFile][37]                                  | Gets the CAEX file which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][34].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [CAEXSchema][38]                                | Gets the associated CAEX schema of the CAEX object. (Defined by [CAEXBasicObjectExtensions][34].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [Descendants&lt;T>][39]                         | Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][34].)                                                                                                                                                                                                                                                             
![Public Extension Method] | [FindCaexObjectFromId&lt;T>][40]                | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][34].)                                                                                                                                                                                                                                                                        
![Public Extension Method] | [FindReferencedClass&lt;T>][41]                 | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][34].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [FirstAncestor(String)][42]                     | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][34].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][43] | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][34].)                                                                                                                                                                                                                                    
![Public Extension Method] | [FirstAncestor&lt;T>()][44]                     | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][34].)                                                                                                                                                                                                                                                       
![Public Extension Method] | [GetParent&lt;T>][45]                           | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][34].)                                                                                                                                                                                 
![Public Extension Method] | [IsAMLObject][46]                               | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][47].) 
![Public Extension Method] | [Library][48]                                   | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][34].)                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [New_Copyright][49]                             | Adds an new Copyright node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][34].)                                                                                                                                                                                                                                                                            
![Public Extension Method] | [New_Version][50]                               | Adds an new Version node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][34].)                                                                                                                                                                                                                                                                              


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][1]  
[Aml.Engine.CAEX.IMapping][15]  

[1]: ../README.md
[2]: ../ICAEXBasicObject/AdditionalInformation.md
[3]: ../ICAEXBasicObject/README.md
[4]: ../ICAEXWrapper/CAEXParent.md
[5]: ../ICAEXWrapper/README.md
[6]: ../ICAEXBasicObject/ChangeMode.md
[7]: ../ICAEXBasicObject/Copyright.md
[8]: ../ICAEXBasicObject/CopyrightElement.md
[9]: ../ICAEXBasicObject/Description.md
[10]: ../ICAEXBasicObject/DescriptionElement.md
[11]: ../../Aml.Engine.XML/IXMLWrapper/Document.md
[12]: ../../Aml.Engine.XML/IXMLWrapper/README.md
[13]: ../../Aml.Engine.XML/IXMLWrapper/Exists.md
[14]: ../IMapping/MappingObject.md
[15]: ../IMapping/README.md
[16]: ../../Aml.Engine.XML/IXMLWrapper/Node.md
[17]: ../../Aml.Engine.XML/IXMLWrapper/Owner.md
[18]: ../ICAEXBasicObject/Revision.md
[19]: RoleInterface.md
[20]: ../ICAEXBasicObject/SourceObjectInformation.md
[21]: SystemUnitInterface.md
[22]: ../../Aml.Engine.XML/IXMLWrapper/TagName.md
[23]: ../ICAEXBasicObject/Version.md
[24]: ../ICAEXBasicObject/VersionElement.md
[25]: ../ICAEXWrapper/CAEXChild.md
[26]: ../ICAEXWrapper/CAEXChildren.md
[27]: ../ICAEXBasicObject/CAEXSequence.md
[28]: ../ICAEXBasicObject/Container__1.md
[29]: ../ICAEXBasicObject/Insert_1.md
[30]: ../ICAEXBasicObject/Insert.md
[31]: ../ICAEXBasicObject/New_Revision.md
[32]: ../ICAEXWrapper/Remove.md
[33]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/AMLSchemaManager.md
[34]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[35]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Ancestors__1.md
[36]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXDocument.md
[37]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXFile.md
[38]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXSchema.md
[39]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[40]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[41]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[42]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[43]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[44]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[45]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/GetParent__1.md
[46]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsAMLObject.md
[47]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[48]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Library.md
[49]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Copyright.md
[50]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Version.md
[51]: https://www.automationml.org
[52]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"