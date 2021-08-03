RefSemanticType Class
=====================
AutomationML 2.1 APIThis class is a CAEXWrapper for the CAEX element 'RefSemantic' used in an [AttributeType][1].


Inheritance Hierarchy
---------------------
[System.Object][2]  
  [Aml.Engine.CAEX.CAEXWrapper][3]  
    [Aml.Engine.CAEX.CAEXBasicObject][4]  
      **Aml.Engine.CAEX.RefSemanticType**  

  **Namespace:**  [Aml.Engine.CAEX][5]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class RefSemanticType : CAEXBasicObject
```

The **RefSemanticType** type exposes the following members.


Constructors
------------

                 | Name                 | Description                                                  
---------------- | -------------------- | ------------------------------------------------------------ 
![Public method] | [RefSemanticType][6] | Initializes a new instance of the **RefSemanticType** class. 


Properties
----------

                   | Name                             | Description                                                                                                                                                                                         
------------------ | -------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AdditionalInformation][7]       | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [CAEXBasicObject][4].)                                                                              
![Public property] | [CAEXDocument][8]                | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][3].) 
![Public property] | [CAEXParent][9]                  | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][3].)                                                                                                               
![Public property] | [CAEXSequenceOfCAEXObject][10]   | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][3].)                                                                                                                
![Public property] | [ChangeMode][11]                 | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [CAEXBasicObject][4].)                                                                                         
![Public property] | [Copyright][12]                  | Gets and sets the Copyright for this object. (Inherited from [CAEXBasicObject][4].)                                                                                                                 
![Public property] | [CopyrightElement][13]           | Gets the wrapper for the Copyright element. (Inherited from [CAEXBasicObject][4].)                                                                                                                  
![Public property] | [CorrespondingAttributePath][14] | Gets and sets the Attribute 'CorrespondingAttributePath' of the RefSemantic object.                                                                                                                 
![Public property] | [Description][15]                | Gets and sets the Description for this object. (Inherited from [CAEXBasicObject][4].)                                                                                                               
![Public property] | [DescriptionElement][16]         | Gets the wrapper for the Description element. (Inherited from [CAEXBasicObject][4].)                                                                                                                
![Public property] | [Document][17]                   | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][3].)                                                                                                                    
![Public property] | [Exists][18]                     | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][3].)                                                                                                   
![Public property] | [Node][19]                       | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][3].)                                                                                                                                     
![Public property] | [Owner][20]                      | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][3].)                                                                                                                            
![Public property] | [Revision][21]                   | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][4].)                                                                                          
![Public property] | [SourceObjectInformation][22]    | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][4].)                                                                           
![Public property] | [TagName][23]                    | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][3].)                                                                                                              
![Public property] | [Version][24]                    | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][4].)                                                                                                                   
![Public property] | [VersionElement][25]             | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][4].)                                                                                                                    


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                                             
---------------- | ---------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [CAEXChild][26]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                             
![Public method] | [CAEXChildren][27]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                
![Public method] | [CAEXSequence][28]                 | Gets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects [Revision][21] is returned. (Inherited from [CAEXBasicObject][4].)                                              
![Public method] | [Container&lt;T>][29]              | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Inherited from [CAEXBasicObject][4].)                                                                                                                                                                               
![Public method] | [Copy][30]                         | Creates a deep copy of this CAEX object (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                              
![Public method] | [Equals][31]                       | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                           
![Public method] | [GetHashCode][32]                  | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                 
![Public method] | [GetXAttributeValue][33]           | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                    
![Public method] | [Insert(Int32, CAEXWrapper)][34]   | Inserts the specified CAEX object in it's associated sequence at the defined position. The CAEXBasicObject defines the [Revision][21] and [SourceObjectInformation][22] sequences. (Inherited from [CAEXBasicObject][4].)                                                                               
![Public method] | [Insert(CAEXWrapper, Boolean)][35] | Inserts the specified CAEX object in it's associated sequence. The CAEXBasicObject defines the [Revision][21] and [SourceObjectInformation][22] sequences. (Inherited from [CAEXBasicObject][4].)                                                                                                       
![Public method] | [InsertNew][36]                    | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][20] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][3].)                        
![Public method] | [New_Revision][37]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][21] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][4].) 
![Public method] | [Remove][38]                       | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                    
![Public method] | [SetXAttributeValue][39]           | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][3].)                                                                                                                                                                   


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][40] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][3].) 


Extension Methods
-----------------

                           | Name                                  | Description                                                                                                                                                                                                                                                       
-------------------------- | ------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [clone][41]                           | [Copy(Boolean, Boolean, Boolean)][30] (Defined by [AMLEngineAdapter][42].)                                                                                                                                                                                        
![Public Extension Method] | [CloneNode][43]                       | Clones the node. (Defined by [AMLEngineAdapter][42].)                                                                                                                                                                                                             
![Public Extension Method] | [ConsistencyCheck_ClassReference][44] | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][42].)                                                                                                                                           
![Public Extension Method] | [Descendants(Type)][45]               | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][46].)                                                                                                                          
![Public Extension Method] | [Descendants&lt;T>()][47]             | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][46].)                                                                                                                          
![Public Extension Method] | [findInternalElement][48]             | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][42].)                                                                                                                                        
![Public Extension Method] | [getReferencedClass][49]              | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][42].)                                                                                                                                                                                       
![Public Extension Method] | [getReferencedGUID][50]               | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][42].)                                                                                                                                                               
![Public Extension Method] | [getReferencedInterfaceClass][51]     | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][42].)                                                                                                                                             
![Public Extension Method] | [getReferencedInterfaceName][52]      | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][42].)                                                                                                                                                                                
![Public Extension Method] | [Insert_Element][53]                  | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][42].)                                       
![Public Extension Method] | [Insert_NewInstance][54]              | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][42].) 
![Public Extension Method] | [Insert_TypeBaseElement][55]          | [Insert(CAEXWrapper, Boolean)][35] (Defined by [AMLEngineAdapter][42].)                                                                                                                                                                                           
![Public Extension Method] | [Name()][56]                          | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][42].)                                                                                                                                                                            
![Public Extension Method] | [Name()][57]                          | Overloaded. Gets a names for the specified caex wrapper object. If the specified object is a [CAEXObject][58], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][46].)                                        
![Public Extension Method] | [New_Description][59]                 | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][46].)                                                                                                                                                   


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][5]  
[Aml.Engine.CAEX.CAEXBasicObject][4]  

[1]: ../AttributeType/README.md
[2]: https://docs.microsoft.com/dotnet/api/system.object
[3]: ../CAEXWrapper/README.md
[4]: ../CAEXBasicObject/README.md
[5]: ../README.md
[6]: _ctor.md
[7]: ../CAEXBasicObject/AdditionalInformation.md
[8]: ../CAEXWrapper/CAEXDocument.md
[9]: ../CAEXWrapper/CAEXParent.md
[10]: ../CAEXWrapper/CAEXSequenceOfCAEXObject.md
[11]: ../CAEXBasicObject/ChangeMode.md
[12]: ../CAEXBasicObject/Copyright.md
[13]: ../CAEXBasicObject/CopyrightElement.md
[14]: CorrespondingAttributePath.md
[15]: ../CAEXBasicObject/Description.md
[16]: ../CAEXBasicObject/DescriptionElement.md
[17]: ../CAEXWrapper/Document.md
[18]: ../CAEXWrapper/Exists.md
[19]: ../CAEXWrapper/Node.md
[20]: ../CAEXWrapper/Owner.md
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
[36]: ../CAEXWrapper/InsertNew.md
[37]: ../CAEXBasicObject/New_Revision.md
[38]: ../CAEXWrapper/Remove.md
[39]: ../CAEXWrapper/SetXAttributeValue.md
[40]: ../CAEXWrapper/PropertyChanged.md
[41]: ../../Aml.Engine.Adapter/AMLEngineAdapter/clone.md
[42]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[43]: ../../Aml.Engine.Adapter/AMLEngineAdapter/CloneNode.md
[44]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ConsistencyCheck_ClassReference.md
[45]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[46]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[47]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[48]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[49]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedClass.md
[50]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedGUID.md
[51]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceClass.md
[52]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceName.md
[53]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_Element.md
[54]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_NewInstance.md
[55]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_TypeBaseElement.md
[56]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Name.md
[57]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[58]: ../CAEXObject/README.md
[59]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[60]: https://www.automationml.org
[61]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"