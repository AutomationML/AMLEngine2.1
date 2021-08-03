IInstantiable&lt;TINSTANCE> Interface
=====================================
AutomationML 2.1 APIGeneric interface IInstantiable defining the instantiation method and the instance type.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public interface IInstantiable<out TINSTANCE> : IInstantiable, 
	ICAEXObject, ICAEXBasicObject, ICAEXWrapper, IXMLWrapper
where TINSTANCE : CAEXBasicObject

```

#### Type Parameters

##### *TINSTANCE*
The type of the created instance.

The **IInstantiable&lt;TINSTANCE>** type exposes the following members.


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
![Public property] | [Name][16]                    | Gets or sets the name. (Inherited from [ICAEXObject][15].)                                                                                                                                                                                                 
![Public property] | [Node][17]                    | Get the XML node of this instance. Direct manipulations of the XML node are not monitored by the AML engine. (Inherited from [IXMLWrapper][12].)                                                                                                           
![Public property] | [Owner][18]                   | Gets the XML parent node of this instance. Direct manipulations of the XML node are not monitored by the AML engine. (Inherited from [IXMLWrapper][12].)                                                                                                   
![Public property] | [Revision][19]                | Gets the collection of Revision objects contained in this instance. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                
![Public property] | [SourceObjectInformation][20] | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                 
![Public property] | [TagName][21]                 | Gets the Schema Tag name of this instance. (Inherited from [IXMLWrapper][12].)                                                                                                                                                                             
![Public property] | [Version][22]                 | Gets and sets the Version for this object. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                                         
![Public property] | [VersionElement][23]          | Gets the wrapper for the Version element. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                                          


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                                                                                                                      
---------------- | ---------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [CAEXChild][24]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [ICAEXWrapper][5].)                                                                                                                                                                                                                                                                     
![Public method] | [CAEXChildren][25]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [ICAEXWrapper][5].)                                                                                                                                                                                                                                                                        
![Public method] | [CAEXPath][26]                     | Gets the CAEX path for this object. A path can be used to uniquely reference an object, for example in inheritances and instances. The path syntax for an object is defined differently in CAEX 2.15 and CAEX 3.0. The engine uses the [CAEXPathBuilder][27] to generate the CAEX path of an object according to the documents CAEX version. (Inherited from [ICAEXObject][15].) 
![Public method] | [CAEXSequence][28]                 | Gets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects [Revision][19] is returned. (Inherited from [ICAEXBasicObject][3].)                                                                                                                      
![Public method] | [Container&lt;T>][29]              | Gets the CAEXSequence for elements of type T, which is owned by this CAEX object. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                                                                                                                        
![Public method] | [CreateClassInstance][30]          | Creates the class instance.                                                                                                                                                                                                                                                                                                                                                      
![Public method] | [Insert(Int32, CAEXWrapper)][31]   | Inserts the specified CAEX object in it's associated sequence at the defined position. The CAEXBasicObject defines the [Revision][19] and [SourceObjectInformation][20] sequences. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                       
![Public method] | [Insert(CAEXWrapper, Boolean)][32] | Inserts the specified CAEX object in it's associated sequence. The CAEXBasicObject defines the [Revision][19] and [SourceObjectInformation][20] sequences. (Inherited from [ICAEXBasicObject][3].)                                                                                                                                                                               
![Public method] | [New_Revision][33]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][19] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [ICAEXBasicObject][3].)                                                                         
![Public method] | [Remove][34]                       | Removes this object (Inherited from [ICAEXWrapper][5].)                                                                                                                                                                                                                                                                                                                          


Extension Methods
-----------------

                           | Name                                            | Description                                                                                                                                                                                                                                                                                                                                                                              
-------------------------- | ----------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [AMLSchemaManager][35]                          | Gets the associated CAEX schema manager of the CAEX object. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                                                                
![Public Extension Method] | [Ancestors&lt;T>][37]                           | Finds the ancestors of the provided CAEX object which have the given type. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [CAEXDocument][38]                              | Gets the CAEX document which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [CAEXFile][39]                                  | Gets the CAEX file which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [CAEXSchema][40]                                | Gets the associated CAEX schema of the CAEX object. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [Descendants&lt;T>][41]                         | Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                                             
![Public Extension Method] | [FindCaexObjectFromId&lt;T>][42]                | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                                                        
![Public Extension Method] | [FindReferencedClass&lt;T>][43]                 | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [FirstAncestor(String)][44]                     | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][45] | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                    
![Public Extension Method] | [FirstAncestor&lt;T>()][46]                     | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                                       
![Public Extension Method] | [GetFullNodePath][47]                           | Gets the full node path of the provided CAEX object, which includes the object names of all ancestor hierarchy levels and the name of the object itself. (Defined by [CAEXObjectExtensions][48].)                                                                                                                                                                                        
![Public Extension Method] | [GetParent&lt;T>][49]                           | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                 
![Public Extension Method] | [IsAMLObject][50]                               | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][51].) 
![Public Extension Method] | [Library][52]                                   | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [New_Copyright][53]                             | Adds an new Copyright node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                                                            
![Public Extension Method] | [New_Version][54]                               | Adds an new Version node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][36].)                                                                                                                                                                                                                                                                              
![Public Extension Method] | [SetDescription][55]                            | This method sets a description. If no description exists, it is created. (Defined by [CAEXObjectExtensions][48].)                                                                                                                                                                                                                                                                        


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
[14]: ../ICAEXObject/ID.md
[15]: ../ICAEXObject/README.md
[16]: ../ICAEXObject/Name.md
[17]: ../../Aml.Engine.XML/IXMLWrapper/Node.md
[18]: ../../Aml.Engine.XML/IXMLWrapper/Owner.md
[19]: ../ICAEXBasicObject/Revision.md
[20]: ../ICAEXBasicObject/SourceObjectInformation.md
[21]: ../../Aml.Engine.XML/IXMLWrapper/TagName.md
[22]: ../ICAEXBasicObject/Version.md
[23]: ../ICAEXBasicObject/VersionElement.md
[24]: ../ICAEXWrapper/CAEXChild.md
[25]: ../ICAEXWrapper/CAEXChildren.md
[26]: ../ICAEXObject/CAEXPath.md
[27]: ../../Aml.Engine.CAEX.Extensions/CAEXPathBuilder/README.md
[28]: ../ICAEXBasicObject/CAEXSequence.md
[29]: ../ICAEXBasicObject/Container__1.md
[30]: CreateClassInstance.md
[31]: ../ICAEXBasicObject/Insert_1.md
[32]: ../ICAEXBasicObject/Insert.md
[33]: ../ICAEXBasicObject/New_Revision.md
[34]: ../ICAEXWrapper/Remove.md
[35]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/AMLSchemaManager.md
[36]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[37]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Ancestors__1.md
[38]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXDocument.md
[39]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXFile.md
[40]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXSchema.md
[41]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[42]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[43]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[44]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[45]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[46]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[47]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/GetFullNodePath.md
[48]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/README.md
[49]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/GetParent__1.md
[50]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsAMLObject.md
[51]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[52]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Library.md
[53]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Copyright.md
[54]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Version.md
[55]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/SetDescription.md
[56]: https://www.automationml.org
[57]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"