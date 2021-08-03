ExternalReferenceType Class
===========================
AutomationML 2.1 APIThis Class is a wrapper for the CAEXElement 'ExternalReference' which is a container element for the alias definition of external CAEX files.


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
![Public property] | [Node][18]                     | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                     
![Public property] | [Owner][19]                    | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][2].)                                                                                                                            
![Public property] | [Path][20]                     | Gets and sets the path of the external CAEX file. According to CAEX absolute and relative paths are allowed.                                                                                        
![Public property] | [Revision][21]                 | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                          
![Public property] | [SourceObjectInformation][22]  | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                           
![Public property] | [TagName][23]                  | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][2].)                                                                                                              
![Public property] | [Version][24]                  | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                   
![Public property] | [VersionElement][25]           | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][3].)                                                                                                                    


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                                             
---------------- | ---------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [CAEXChild][26]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                             
![Public method] | [CAEXChildren][27]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                
![Public method] | [CAEXSequence][28]                 | Gets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects [Revision][21] is returned. (Inherited from [CAEXBasicObject][3].)                                              
![Public method] | [Container&lt;T>][29]              | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                               
![Public method] | [Copy][30]                         | Creates a deep copy of this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                              
![Public method] | [Equals][31]                       | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                           
![Public method] | [GetHashCode][32]                  | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                 
![Public method] | [GetXAttributeValue][33]           | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                    
![Public method] | [Insert(Int32, CAEXWrapper)][34]   | Inserts the specified CAEX object in it's associated sequence at the defined position. The CAEXBasicObject defines the [Revision][21] and [SourceObjectInformation][22] sequences. (Inherited from [CAEXBasicObject][3].)                                                                               
![Public method] | [Insert(CAEXWrapper, Boolean)][35] | Inserts the specified CAEX object in it's associated sequence. The CAEXBasicObject defines the [Revision][21] and [SourceObjectInformation][22] sequences. (Inherited from [CAEXBasicObject][3].)                                                                                                       
![Public method] | [InsertAfter][36]                  | Inserts the provided CAEX object as a new sibling after this CAEX object.                                                                                                                                                                                                                               
![Public method] | [InsertBefore][37]                 | Inserts the provided CAEX object as a new sibling before this CAEX object.                                                                                                                                                                                                                              
![Public method] | [InsertNew][38]                    | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][19] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][2].)                        
![Public method] | [New_Revision][39]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][21] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][3].) 
![Public method] | [Remove][40]                       | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                    
![Public method] | [SetXAttributeValue][41]           | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][2].)                                                                                                                                                                   


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][42] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][2].) 


Extension Methods
-----------------

                           | Name                                            | Description                                                                                                                                                                                                                                                                                                                                                                              
-------------------------- | ----------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [AMLSchemaManager][43]                          | Gets the associated CAEX schema manager of the CAEX object. (Defined by [CAEXBasicObjectExtensions][44].)                                                                                                                                                                                                                                                                                
![Public Extension Method] | [Ancestors&lt;T>][45]                           | Finds the ancestors of the provided CAEX object which have the given type. (Defined by [CAEXBasicObjectExtensions][44].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [CAEXDocument][46]                              | Gets the CAEX document which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][44].)                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [CAEXFile][47]                                  | Gets the CAEX file which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][44].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [CAEXSchema][48]                                | Gets the associated CAEX schema of the CAEX object. (Defined by [CAEXBasicObjectExtensions][44].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [clone][49]                                     | [Copy(Boolean, Boolean, Boolean)][30] (Defined by [AMLEngineAdapter][50].)                                                                                                                                                                                                                                                                                                               
![Public Extension Method] | [CloneNode][51]                                 | Clones the node. (Defined by [AMLEngineAdapter][50].)                                                                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [ConsistencyCheck_ClassReference][52]           | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][50].)                                                                                                                                                                                                                                                                  
![Public Extension Method] | [Descendants(Type)][53]                         | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][44].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [Descendants&lt;T>()][54]                       | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][44].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [Descendants&lt;T>(Boolean)][55]                | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][44].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [FindCaexObjectFromId&lt;T>][56]                | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][44].)                                                                                                                                                                                                                                                                        
![Public Extension Method] | [findInternalElement][57]                       | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][50].)                                                                                                                                                                                                                                                               
![Public Extension Method] | [FindReferencedClass&lt;T>][58]                 | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][44].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [FirstAncestor(String)][59]                     | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][44].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][60] | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][44].)                                                                                                                                                                                                                                    
![Public Extension Method] | [FirstAncestor&lt;T>()][61]                     | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][44].)                                                                                                                                                                                                                                                       
![Public Extension Method] | [GetParent&lt;T>][62]                           | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][44].)                                                                                                                                                                                 
![Public Extension Method] | [getReferencedClass][63]                        | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][50].)                                                                                                                                                                                                                                                                                                              
![Public Extension Method] | [getReferencedGUID][64]                         | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][50].)                                                                                                                                                                                                                                                                                      
![Public Extension Method] | [getReferencedInterfaceClass][65]               | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][50].)                                                                                                                                                                                                                                                                    
![Public Extension Method] | [getReferencedInterfaceName][66]                | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][50].)                                                                                                                                                                                                                                                                                                       
![Public Extension Method] | [Insert_Element][67]                            | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][50].)                                                                                                                                                              
![Public Extension Method] | [Insert_NewInstance][68]                        | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][50].)                                                                                                                        
![Public Extension Method] | [Insert_TypeBaseElement][69]                    | [Insert(CAEXWrapper, Boolean)][35] (Defined by [AMLEngineAdapter][50].)                                                                                                                                                                                                                                                                                                                  
![Public Extension Method] | [IsAMLObject][70]                               | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][71].) 
![Public Extension Method] | [Library][72]                                   | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][44].)                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [Name()][73]                                    | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][50].)                                                                                                                                                                                                                                                                                                   
![Public Extension Method] | [Name()][74]                                    | Overloaded. Gets a names for the specified caex wrapper object. If the specified object is a [CAEXObject][75], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][44].)                                                                                                                                                               
![Public Extension Method] | [New_Copyright][76]                             | Adds an new Copyright node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][44].)                                                                                                                                                                                                                                                                            
![Public Extension Method] | [New_Description][77]                           | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][44].)                                                                                                                                                                                                                                                                          
![Public Extension Method] | [New_Version][78]                               | Adds an new Version node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][44].)                                                                                                                                                                                                                                                                              


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][4]  
[Aml.Engine.CAEX.CAEXBasicObject][3]  
[Aml.Engine.CAEX.IMultipleOccurrences&lt;T>][79]  

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
[18]: ../CAEXWrapper/Node.md
[19]: ../CAEXWrapper/Owner.md
[20]: Path.md
[21]: ../CAEXBasicObject/Revision.md
[22]: ../CAEXBasicObject/SourceObjectInformation.md
[23]: ../CAEXWrapper/TagName.md
[24]: ../CAEXBasicObject/Version.md
[25]: ../CAEXBasicObject/VersionElement.md
[26]: ../CAEXWrapper/CAEXChild.md
[27]: ../CAEXWrapper/CAEXChildren.md
[28]: ../CAEXBasicObject/CAEXSequence.md
[29]: ../CAEXBasicObject/Container__1.md
[30]: ../CAEXWrapper/Copy.md
[31]: ../CAEXWrapper/Equals.md
[32]: ../CAEXWrapper/GetHashCode.md
[33]: ../CAEXWrapper/GetXAttributeValue.md
[34]: ../CAEXBasicObject/Insert_1.md
[35]: ../CAEXBasicObject/Insert.md
[36]: InsertAfter.md
[37]: InsertBefore.md
[38]: ../CAEXWrapper/InsertNew.md
[39]: ../CAEXBasicObject/New_Revision.md
[40]: ../CAEXWrapper/Remove.md
[41]: ../CAEXWrapper/SetXAttributeValue.md
[42]: ../CAEXWrapper/PropertyChanged.md
[43]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/AMLSchemaManager.md
[44]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[45]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Ancestors__1.md
[46]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXDocument.md
[47]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXFile.md
[48]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXSchema.md
[49]: ../../Aml.Engine.Adapter/AMLEngineAdapter/clone.md
[50]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[51]: ../../Aml.Engine.Adapter/AMLEngineAdapter/CloneNode.md
[52]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ConsistencyCheck_ClassReference.md
[53]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[54]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[55]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[56]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[57]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[58]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[59]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[60]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[61]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[62]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/GetParent__1.md
[63]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedClass.md
[64]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedGUID.md
[65]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceClass.md
[66]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceName.md
[67]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_Element.md
[68]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_NewInstance.md
[69]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_TypeBaseElement.md
[70]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsAMLObject.md
[71]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[72]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Library.md
[73]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Name.md
[74]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[75]: ../CAEXObject/README.md
[76]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Copyright.md
[77]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[78]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Version.md
[79]: ../IMultipleOccurrences_1/README.md
[80]: https://www.automationml.org
[81]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"