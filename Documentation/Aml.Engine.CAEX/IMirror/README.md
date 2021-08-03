IMirror Interface
=================
Interface class, implemented by any CAEX object, which can be mirrored

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public interface IMirror : ICAEXObject, 
	ICAEXBasicObject, ICAEXWrapper, IXMLWrapper
```

The **IMirror** type exposes the following members.


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
![Public property] | [ID][14]                      | Gets or sets the identifier. (Inherited from [ICAEXObject][15].)                                                                                                                                                                                           
![Public property] | [IsMaster][16]                | Gets a value indicating whether this instance is a master.                                                                                                                                                                                                 
![Public property] | [IsMirror][17]                | Gets a value indicating whether this instance is mirror.                                                                                                                                                                                                   
![Public property] | [Master][18]                  | Gets the master.                                                                                                                                                                                                                                           
![Public property] | [MasterID][19]                | Gets the master identifier.                                                                                                                                                                                                                                
![Public property] | [Name][20]                    | Gets or sets the name. (Inherited from [ICAEXObject][15].)                                                                                                                                                                                                 
![Public property] | [Node][21]                    | Get the XML node of this instance. Direct manipulations of the XML node are not monitored by the AML engine. (Inherited from [IXMLWrapper][12].)                                                                                                           
![Public property] | [Owner][22]                   | Gets the XML parent node of this instance. Direct manipulations of the XML node are not monitored by the AML engine. (Inherited from [IXMLWrapper][12].)                                                                                                   
![Public property] | [Revision][23]                | Gets the collection of Revision objects contained in this instance. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                
![Public property] | [SourceObjectInformation][24] | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                 
![Public property] | [TagName][25]                 | Gets the Schema Tag name of this instance. (Inherited from [IXMLWrapper][12].)                                                                                                                                                                             
![Public property] | [Version][26]                 | Gets and sets the Version for this object. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                                         
![Public property] | [VersionElement][27]          | Gets the wrapper for the Version element. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                                          


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                                                                                                                      
---------------- | ---------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [CAEXChild][28]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [ICAEXWrapper][5].)                                                                                                                                                                                                                                                                     
![Public method] | [CAEXChildren][29]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [ICAEXWrapper][5].)                                                                                                                                                                                                                                                                        
![Public method] | [CAEXPath][30]                     | Gets the CAEX path for this object. A path can be used to uniquely reference an object, for example in inheritances and instances. The path syntax for an object is defined differently in CAEX 2.15 and CAEX 3.0. The engine uses the [CAEXPathBuilder][31] to generate the CAEX path of an object according to the documents CAEX version. (Inherited from [ICAEXObject][15].) 
![Public method] | [CAEXSequence][32]                 | Gets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects [Revision][23] is returned. (Inherited from [ICAEXBasicObject][3].)                                                                                                                      
![Public method] | [Container&lt;T>][33]              | Gets the CAEXSequence for elements of type T, which is owned by this CAEX object. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                                                                                                                        
![Public method] | [CreateMirror][34]                 | Creates a mirror.                                                                                                                                                                                                                                                                                                                                                                
![Public method] | [Insert(Int32, CAEXWrapper)][35]   | Inserts the specified CAEX object in it's associated sequence at the defined position. The CAEXBasicObject defines the [Revision][23] and [SourceObjectInformation][24] sequences. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                       
![Public method] | [Insert(CAEXWrapper, Boolean)][36] | Inserts the specified CAEX object in it's associated sequence. The CAEXBasicObject defines the [Revision][23] and [SourceObjectInformation][24] sequences. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                                               
![Public method] | [New_Revision][37]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][23] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [ICAEXBasicObject][3].)                                                                         
![Public method] | [Remove][38]                       | Removes this object (Inherited from [ICAEXWrapper][5].)                                                                                                                                                                                                                                                                                                                          


Extension Methods
-----------------

                           | Name                                            | Description                                                                                                                                                                                                                                                                                                                                                                              
-------------------------- | ----------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [AMLSchemaManager][39]                          | Gets the associated CAEX schema manager of the CAEX object. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                                                
![Public Extension Method] | [Ancestors&lt;T>][41]                           | Finds the ancestors of the provided CAEX object which have the given type. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [CAEXDocument][42]                              | Gets the CAEX document which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [CAEXFile][43]                                  | Gets the CAEX file which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [CAEXSchema][44]                                | Gets the associated CAEX schema of the CAEX object. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [Descendants&lt;T>][45]                         | Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                             
![Public Extension Method] | [FindCaexObjectFromId&lt;T>][46]                | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                                        
![Public Extension Method] | [FindReferencedClass&lt;T>][47]                 | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [FirstAncestor(String)][48]                     | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][49] | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                    
![Public Extension Method] | [FirstAncestor&lt;T>()][50]                     | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                       
![Public Extension Method] | [GetFullNodePath][51]                           | Gets the full node path of the provided CAEX object, which includes the object names of all ancestor hierarchy levels and the name of the object itself. (Defined by [CAEXObjectExtensions][52].)                                                                                                                                                                                        
![Public Extension Method] | [GetParent&lt;T>][53]                           | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                 
![Public Extension Method] | [IsAMLObject][54]                               | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][55].) 
![Public Extension Method] | [Library][56]                                   | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [New_Copyright][57]                             | Adds an new Copyright node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                                            
![Public Extension Method] | [New_Version][58]                               | Adds an new Version node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][40].)                                                                                                                                                                                                                                                                              
![Public Extension Method] | [SetDescription][59]                            | This method sets a description. If no description exists, it is created. (Defined by [CAEXObjectExtensions][52].)                                                                                                                                                                                                                                                                        


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][1]  
[Aml.Engine.CAEX.ICAEXObject][15]  

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
[14]: ../ICAEXObject/ID.md
[15]: ../ICAEXObject/README.md
[16]: IsMaster.md
[17]: IsMirror.md
[18]: Master.md
[19]: MasterID.md
[20]: ../ICAEXObject/Name.md
[21]: ../../Aml.Engine.XML/IXMLWrapper/Node.md
[22]: ../../Aml.Engine.XML/IXMLWrapper/Owner.md
[23]: ../ICAEXBasicObject/Revision.md
[24]: ../ICAEXBasicObject/SourceObjectInformation.md
[25]: ../../Aml.Engine.XML/IXMLWrapper/TagName.md
[26]: ../ICAEXBasicObject/Version.md
[27]: ../ICAEXBasicObject/VersionElement.md
[28]: ../ICAEXWrapper/CAEXChild.md
[29]: ../ICAEXWrapper/CAEXChildren.md
[30]: ../ICAEXObject/CAEXPath.md
[31]: ../../Aml.Engine.CAEX.Extensions/CAEXPathBuilder/README.md
[32]: ../ICAEXBasicObject/CAEXSequence.md
[33]: ../ICAEXBasicObject/Container__1.md
[34]: CreateMirror.md
[35]: ../ICAEXBasicObject/Insert_1.md
[36]: ../ICAEXBasicObject/Insert.md
[37]: ../ICAEXBasicObject/New_Revision.md
[38]: ../ICAEXWrapper/Remove.md
[39]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/AMLSchemaManager.md
[40]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[41]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Ancestors__1.md
[42]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXDocument.md
[43]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXFile.md
[44]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXSchema.md
[45]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[46]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[47]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[48]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[49]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[50]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[51]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/GetFullNodePath.md
[52]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/README.md
[53]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/GetParent__1.md
[54]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsAMLObject.md
[55]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[56]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Library.md
[57]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Copyright.md
[58]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Version.md
[59]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/SetDescription.md
[60]: https://www.automationml.org
[61]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"