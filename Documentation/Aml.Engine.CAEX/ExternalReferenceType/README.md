ExternalReferenceType Class
===========================
This Class is a wrapper for the CAEXElement 'ExternalReference' which is a container element for the alias definition of external CAEX files.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.CAEXWrapper][2]  
    [Aml.Engine.CAEX.CAEXBasicObject][3]  
      **Aml.Engine.CAEX.ExternalReferenceType**  

  **Namespace:**  [Aml.Engine.CAEX][4]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class ExternalReferenceType : CAEXBasicObject, 
	IMultipleOccurrences<ExternalReferenceType>, ICAEXBasicObject, ICAEXWrapper, IXMLWrapper
```

The **ExternalReferenceType** type exposes the following members.


Constructors
------------

                 | Name                       | Description                                                        
---------------- | -------------------------- | ------------------------------------------------------------------ 
![Public method] | [ExternalReferenceType][5] | Initializes a new instance of the **ExternalReferenceType** class. 


Properties
----------

                   | Name                           | Description                                                                                                                                                                                         
------------------ | ------------------------------ | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AdditionalInformation][6]     | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                              
![Public property] | [Alias][7]                     | Gets and sets the alias name of an external CAEX file to enable referencing elements of the external CAEX file from other elements                                                                  
![Public property] | [CAEXDocument][8]              | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][2].) 
![Public property] | [CAEXParent][9]                | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][2].)                                                                                                               
![Public property] | [CAEXSequenceOfCAEXObject][10] | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                
![Public property] | [ChangeMode][11]               | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [CAEXBasicObject][3].)                                                                                         
![Public property] | [Copyright][12]                | Gets and sets the Copyright for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                 
![Public property] | [CopyrightElement][13]         | Gets the wrapper for the Copyright element. (Inherited from [CAEXBasicObject][3].)                                                                                                                  
![Public property] | [Description][14]              | Gets and sets the Description for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                               
![Public property] | [DescriptionElement][15]       | Gets the wrapper for the Description element. (Inherited from [CAEXBasicObject][3].)                                                                                                                
![Public property] | [Document][16]                 | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                    
![Public property] | [Exists][17]                   | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                   
![Public property] | [ExternalDocument][18]         | Gets the external document referenced by this instance. To get the document, a [IExternalReferenceResolver][19] has to be registered. If no such service exists, the value is `null`.               
![Public property] | [Node][20]                     | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                     
![Public property] | [Owner][21]                    | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][2].)                                                                                                                            
![Public property] | [Path][22]                     | Gets and sets the path of the external CAEX file. According to CAEX absolute and relative paths are allowed.                                                                                        
![Public property] | [Revision][23]                 | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                          
![Public property] | [SourceObjectInformation][24]  | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                           
![Public property] | [TagName][25]                  | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][2].)                                                                                                              
![Public property] | [Version][26]                  | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                   
![Public property] | [VersionElement][27]           | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][3].)                                                                                                                    


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                                             
---------------- | ---------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [CAEXChild][28]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                             
![Public method] | [CAEXChildren][29]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                
![Public method] | [CAEXSequence][30]                 | Gets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects [Revision][23] is returned. (Inherited from [CAEXBasicObject][3].)                                              
![Public method] | [Container&lt;T>][31]              | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                               
![Public method] | [Copy][32]                         | Creates a deep copy of this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                              
![Public method] | [Equals][33]                       | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                           
![Public method] | [GetHashCode][34]                  | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                 
![Public method] | [GetXAttributeValue][35]           | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                    
![Public method] | [Insert(Int32, CAEXWrapper)][36]   | Inserts the specified CAEX object in it's associated sequence at the defined position. The CAEXBasicObject defines the [Revision][23] and [SourceObjectInformation][24] sequences. (Inherited from [CAEXBasicObject][3].)                                                                               
![Public method] | [Insert(CAEXWrapper, Boolean)][37] | Inserts the specified CAEX object in it's associated sequence. The CAEXBasicObject defines the [Revision][23] and [SourceObjectInformation][24] sequences. (Inherited from [CAEXBasicObject][3].)                                                                                                       
![Public method] | [InsertAfter][38]                  | Inserts the provided CAEX object as a new sibling after this CAEX object.                                                                                                                                                                                                                               
![Public method] | [InsertBefore][39]                 | Inserts the provided CAEX object as a new sibling before this CAEX object.                                                                                                                                                                                                                              
![Public method] | [InsertNew][40]                    | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][21] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][2].)                        
![Public method] | [New_Revision][41]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][23] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][3].) 
![Public method] | [Remove][42]                       | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                    
![Public method] | [SetXAttributeValue][43]           | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][2].)                                                                                                                                                                   


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][44] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][2].) 


Extension Methods
-----------------

                           | Name                                            | Description                                                                                                                                                                                                                                                                                                                                                                              
-------------------------- | ----------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [AMLSchemaManager][45]                          | Gets the associated CAEX schema manager of the CAEX object. (Defined by [CAEXBasicObjectExtensions][46].)                                                                                                                                                                                                                                                                                
![Public Extension Method] | [Ancestors&lt;T>][47]                           | Finds the ancestors of the provided CAEX object which have the given type. (Defined by [CAEXBasicObjectExtensions][46].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [CAEXDocument][48]                              | Gets the CAEX document which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][46].)                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [CAEXFile][49]                                  | Gets the CAEX file which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][46].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [CAEXSchema][50]                                | Gets the associated CAEX schema of the CAEX object. (Defined by [CAEXBasicObjectExtensions][46].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [clone][51]                                     | [Copy(Boolean, Boolean, Boolean)][32] (Defined by [AMLEngineAdapter][52].)                                                                                                                                                                                                                                                                                                               
![Public Extension Method] | [CloneNode][53]                                 | Clones the node. (Defined by [AMLEngineAdapter][52].)                                                                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [ConsistencyCheck_ClassReference][54]           | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][52].)                                                                                                                                                                                                                                                                  
![Public Extension Method] | [Descendants(Type)][55]                         | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][46].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [Descendants&lt;T>()][56]                       | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][46].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [Descendants&lt;T>(Boolean)][57]                | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][46].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [FindCaexObjectFromId&lt;T>][58]                | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][46].)                                                                                                                                                                                                                                                                        
![Public Extension Method] | [findInternalElement][59]                       | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][52].)                                                                                                                                                                                                                                                               
![Public Extension Method] | [FindReferencedClass&lt;T>][60]                 | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][46].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [FirstAncestor(String)][61]                     | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][46].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][62] | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][46].)                                                                                                                                                                                                                                    
![Public Extension Method] | [FirstAncestor&lt;T>()][63]                     | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][46].)                                                                                                                                                                                                                                                       
![Public Extension Method] | [GetParent&lt;T>][64]                           | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][46].)                                                                                                                                                                                 
![Public Extension Method] | [getReferencedClass][65]                        | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][52].)                                                                                                                                                                                                                                                                                                              
![Public Extension Method] | [getReferencedGUID][66]                         | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][52].)                                                                                                                                                                                                                                                                                      
![Public Extension Method] | [getReferencedInterfaceClass][67]               | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][52].)                                                                                                                                                                                                                                                                    
![Public Extension Method] | [getReferencedInterfaceName][68]                | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][52].)                                                                                                                                                                                                                                                                                                       
![Public Extension Method] | [Insert_Element][69]                            | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][52].)                                                                                                                                                              
![Public Extension Method] | [Insert_NewInstance][70]                        | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][52].)                                                                                                                        
![Public Extension Method] | [Insert_TypeBaseElement][71]                    | [Insert(CAEXWrapper, Boolean)][37] (Defined by [AMLEngineAdapter][52].)                                                                                                                                                                                                                                                                                                                  
![Public Extension Method] | [IsAMLObject][72]                               | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][73].) 
![Public Extension Method] | [Library][74]                                   | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][46].)                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [Name()][75]                                    | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][52].)                                                                                                                                                                                                                                                                                                   
![Public Extension Method] | [Name()][76]                                    | Overloaded. Gets a names for the specified CAEX wrapper object. If the specified object is a [CAEXObject][77], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][46].)                                                                                                                                                               
![Public Extension Method] | [New_Copyright][78]                             | Adds an new Copyright node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][46].)                                                                                                                                                                                                                                                                            
![Public Extension Method] | [New_Description][79]                           | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][46].)                                                                                                                                                                                                                                                                          
![Public Extension Method] | [New_Version][80]                               | Adds an new Version node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][46].)                                                                                                                                                                                                                                                                              


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][4]  
[Aml.Engine.CAEX.CAEXBasicObject][3]  
[Aml.Engine.CAEX.IMultipleOccurrences&lt;T>][81]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../CAEXWrapper/README.md
[3]: ../CAEXBasicObject/README.md
[4]: ../README.md
[5]: _ctor.md
[6]: ../CAEXBasicObject/AdditionalInformation.md
[7]: Alias.md
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
[18]: ExternalDocument.md
[19]: ../../Aml.Engine.Services.Interfaces/IExternalReferenceResolver/README.md
[20]: ../CAEXWrapper/Node.md
[21]: ../CAEXWrapper/Owner.md
[22]: Path.md
[23]: ../CAEXBasicObject/Revision.md
[24]: ../CAEXBasicObject/SourceObjectInformation.md
[25]: ../CAEXWrapper/TagName.md
[26]: ../CAEXBasicObject/Version.md
[27]: ../CAEXBasicObject/VersionElement.md
[28]: ../CAEXWrapper/CAEXChild.md
[29]: ../CAEXWrapper/CAEXChildren.md
[30]: ../CAEXBasicObject/CAEXSequence.md
[31]: ../CAEXBasicObject/Container__1.md
[32]: ../CAEXWrapper/Copy.md
[33]: ../CAEXWrapper/Equals.md
[34]: ../CAEXWrapper/GetHashCode.md
[35]: ../CAEXWrapper/GetXAttributeValue.md
[36]: ../CAEXBasicObject/Insert_1.md
[37]: ../CAEXBasicObject/Insert.md
[38]: InsertAfter.md
[39]: InsertBefore.md
[40]: ../CAEXWrapper/InsertNew.md
[41]: ../CAEXBasicObject/New_Revision.md
[42]: ../CAEXWrapper/Remove.md
[43]: ../CAEXWrapper/SetXAttributeValue.md
[44]: ../CAEXWrapper/PropertyChanged.md
[45]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/AMLSchemaManager.md
[46]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[47]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Ancestors__1.md
[48]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXDocument.md
[49]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXFile.md
[50]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXSchema.md
[51]: ../../Aml.Engine.Adapter/AMLEngineAdapter/clone.md
[52]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[53]: ../../Aml.Engine.Adapter/AMLEngineAdapter/CloneNode.md
[54]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ConsistencyCheck_ClassReference.md
[55]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[56]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[57]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[58]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[59]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[60]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[61]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[62]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[63]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[64]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/GetParent__1.md
[65]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedClass.md
[66]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedGUID.md
[67]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceClass.md
[68]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceName.md
[69]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_Element.md
[70]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_NewInstance.md
[71]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_TypeBaseElement.md
[72]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsAMLObject.md
[73]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[74]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Library.md
[75]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Name.md
[76]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[77]: ../CAEXObject/README.md
[78]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Copyright.md
[79]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[80]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Version.md
[81]: ../IMultipleOccurrences_1/README.md
[82]: https://www.automationml.org
[83]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"