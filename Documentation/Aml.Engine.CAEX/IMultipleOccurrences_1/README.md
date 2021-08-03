IMultipleOccurrences&lt;T> Interface
====================================
This interface class is used to define generic methods for CAEX objects which can have multiple occurrences below its parent element. The methods defined in this interface class affect the relation to the sibling elements of a CAEX object with the same type.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public interface IMultipleOccurrences<in T> : ICAEXBasicObject, 
	ICAEXWrapper, IXMLWrapper
where T : CAEXBasicObject

```

#### Type Parameters

##### *T*


The **IMultipleOccurrences&lt;T>** type exposes the following members.


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
![Public property] | [Node][14]                    | Get the XML node of this instance. Direct manipulations of the XML node are not monitored by the AML engine. (Inherited from [IXMLWrapper][12].)                                                                                                           
![Public property] | [Owner][15]                   | Gets the XML parent node of this instance. Direct manipulations of the XML node are not monitored by the AML engine. (Inherited from [IXMLWrapper][12].)                                                                                                   
![Public property] | [Revision][16]                | Gets the collection of Revision objects contained in this instance. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                
![Public property] | [SourceObjectInformation][17] | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                 
![Public property] | [TagName][18]                 | Gets the Schema Tag name of this instance. (Inherited from [IXMLWrapper][12].)                                                                                                                                                                             
![Public property] | [Version][19]                 | Gets and sets the Version for this object. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                                         
![Public property] | [VersionElement][20]          | Gets the wrapper for the Version element. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                                          


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                                              
---------------- | ---------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [CAEXChild][21]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [ICAEXWrapper][5].)                                                                                                                                                                                             
![Public method] | [CAEXChildren][22]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [ICAEXWrapper][5].)                                                                                                                                                                                                
![Public method] | [CAEXSequence][23]                 | Gets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects [Revision][16] is returned. (Inherited from [ICAEXBasicObject][3].)                                              
![Public method] | [Container&lt;T>][24]              | Gets the CAEXSequence for elements of type T, which is owned by this CAEX object. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                                                
![Public method] | [Insert(Int32, CAEXWrapper)][25]   | Inserts the specified CAEX object in it's associated sequence at the defined position. The CAEXBasicObject defines the [Revision][16] and [SourceObjectInformation][17] sequences. (Inherited from [ICAEXBasicObject][3].)                                                                               
![Public method] | [Insert(CAEXWrapper, Boolean)][26] | Inserts the specified CAEX object in it's associated sequence. The CAEXBasicObject defines the [Revision][16] and [SourceObjectInformation][17] sequences. (Inherited from [ICAEXBasicObject][3].)                                                                                                       
![Public method] | [InsertAfter][27]                  | Inserts the provided CAEX object as a new sibling after this CAEX object, if both are of the same type.                                                                                                                                                                                                  
![Public method] | [InsertBefore][28]                 | Inserts the provided CAEX object as a new sibling before this CAEX object, if both are of the same type.                                                                                                                                                                                                 
![Public method] | [New_Revision][29]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][16] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [ICAEXBasicObject][3].) 
![Public method] | [Remove][30]                       | Removes this object (Inherited from [ICAEXWrapper][5].)                                                                                                                                                                                                                                                  


Extension Methods
-----------------

                           | Name                                            | Description                                                                                                                                                                                                                                                                                                                                                                              
-------------------------- | ----------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [AMLSchemaManager][31]                          | Gets the associated CAEX schema manager of the CAEX object. (Defined by [CAEXBasicObjectExtensions][32].)                                                                                                                                                                                                                                                                                
![Public Extension Method] | [Ancestors&lt;T>][33]                           | Finds the ancestors of the provided CAEX object which have the given type. (Defined by [CAEXBasicObjectExtensions][32].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [CAEXDocument][34]                              | Gets the CAEX document which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][32].)                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [CAEXFile][35]                                  | Gets the CAEX file which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][32].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [CAEXSchema][36]                                | Gets the associated CAEX schema of the CAEX object. (Defined by [CAEXBasicObjectExtensions][32].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [Descendants&lt;T>][37]                         | Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][32].)                                                                                                                                                                                                                                                             
![Public Extension Method] | [FindCaexObjectFromId&lt;T>][38]                | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][32].)                                                                                                                                                                                                                                                                        
![Public Extension Method] | [FindReferencedClass&lt;T>][39]                 | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][32].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [FirstAncestor(String)][40]                     | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][32].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][41] | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][32].)                                                                                                                                                                                                                                    
![Public Extension Method] | [FirstAncestor&lt;T>()][42]                     | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][32].)                                                                                                                                                                                                                                                       
![Public Extension Method] | [GetParent&lt;T>][43]                           | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][32].)                                                                                                                                                                                 
![Public Extension Method] | [IsAMLObject][44]                               | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][45].) 
![Public Extension Method] | [Library][46]                                   | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][32].)                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [New_Copyright][47]                             | Adds an new Copyright node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][32].)                                                                                                                                                                                                                                                                            
![Public Extension Method] | [New_Version][48]                               | Adds an new Version node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][32].)                                                                                                                                                                                                                                                                              


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][1]  
[Aml.Engine.CAEX.ICAEXWrapper][5]  

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
[14]: ../../Aml.Engine.XML/IXMLWrapper/Node.md
[15]: ../../Aml.Engine.XML/IXMLWrapper/Owner.md
[16]: ../ICAEXBasicObject/Revision.md
[17]: ../ICAEXBasicObject/SourceObjectInformation.md
[18]: ../../Aml.Engine.XML/IXMLWrapper/TagName.md
[19]: ../ICAEXBasicObject/Version.md
[20]: ../ICAEXBasicObject/VersionElement.md
[21]: ../ICAEXWrapper/CAEXChild.md
[22]: ../ICAEXWrapper/CAEXChildren.md
[23]: ../ICAEXBasicObject/CAEXSequence.md
[24]: ../ICAEXBasicObject/Container__1.md
[25]: ../ICAEXBasicObject/Insert_1.md
[26]: ../ICAEXBasicObject/Insert.md
[27]: InsertAfter.md
[28]: InsertBefore.md
[29]: ../ICAEXBasicObject/New_Revision.md
[30]: ../ICAEXWrapper/Remove.md
[31]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/AMLSchemaManager.md
[32]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[33]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Ancestors__1.md
[34]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXDocument.md
[35]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXFile.md
[36]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXSchema.md
[37]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[38]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[39]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[40]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[41]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[42]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[43]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/GetParent__1.md
[44]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsAMLObject.md
[45]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[46]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Library.md
[47]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Copyright.md
[48]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Version.md
[49]: https://www.automationml.org
[50]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"