RevisionType Class
==================
AutomationML 2.1 APIThis Class is a wrapper for the CAEXElement 'Revision' which contains organizational information about the state of the revision of a CAEX object


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.CAEXWrapper][2]  
    [Aml.Engine.CAEX.CAEXBasicObject][3]  
      **Aml.Engine.CAEX.RevisionType**  

  **Namespace:**  [Aml.Engine.CAEX][4]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class RevisionType : CAEXBasicObject
```

The **RevisionType** type exposes the following members.


Constructors
------------

                 | Name              | Description                                               
---------------- | ----------------- | --------------------------------------------------------- 
![Public method] | [RevisionType][5] | Initializes a new instance of the **RevisionType** class. 


Properties
----------

                   | Name                           | Description                                                                                                                                                                                         
------------------ | ------------------------------ | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AdditionalInformation][6]     | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                              
![Public property] | [AuthorName][7]                | Gets or sets the name of the author.                                                                                                                                                                
![Public property] | [CAEXDocument][8]              | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][2].) 
![Public property] | [CAEXParent][9]                | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][2].)                                                                                                               
![Public property] | [CAEXSequenceOfCAEXObject][10] | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                
![Public property] | [ChangeMode][11]               | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [CAEXBasicObject][3].)                                                                                         
![Public property] | [Comment][12]                  | Gets or sets the comment.                                                                                                                                                                           
![Public property] | [Copyright][13]                | Gets and sets the Copyright for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                 
![Public property] | [CopyrightElement][14]         | Gets the wrapper for the Copyright element. (Inherited from [CAEXBasicObject][3].)                                                                                                                  
![Public property] | [Description][15]              | Gets and sets the Description for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                               
![Public property] | [DescriptionElement][16]       | Gets the wrapper for the Description element. (Inherited from [CAEXBasicObject][3].)                                                                                                                
![Public property] | [Document][17]                 | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                    
![Public property] | [Exists][18]                   | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                   
![Public property] | [NewVersion][19]               | Gets or sets the new version.                                                                                                                                                                       
![Public property] | [NewVersionObject][20]         | Gets and sets the provided CAEX object as the new version.                                                                                                                                          
![Public property] | [Node][21]                     | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                     
![Public property] | [OldVersion][22]               | Gets or sets the old version.                                                                                                                                                                       
![Public property] | [OldVersionObject][23]         | Gets and sets the provided CAEX object as the old version.                                                                                                                                          
![Public property] | [Owner][24]                    | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][2].)                                                                                                                            
![Public property] | [Revision][25]                 | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                          
![Public property] | [RevisionDate][26]             | Gets or sets the revision date.                                                                                                                                                                     
![Public property] | [SourceObjectInformation][27]  | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                           
![Public property] | [TagName][28]                  | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][2].)                                                                                                              
![Public property] | [Version][29]                  | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                   
![Public property] | [VersionElement][30]           | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][3].)                                                                                                                    


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                                             
---------------- | ---------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [CAEXChild][31]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                             
![Public method] | [CAEXChildren][32]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                
![Public method] | [CAEXSequence][33]                 | Gets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects [Revision][25] is returned. (Inherited from [CAEXBasicObject][3].)                                              
![Public method] | [Container&lt;T>][34]              | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                               
![Public method] | [Copy][35]                         | Creates a deep copy of this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                              
![Public method] | [Equals][36]                       | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                           
![Public method] | [GetHashCode][37]                  | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                 
![Public method] | [GetXAttributeValue][38]           | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                    
![Public method] | [Insert(Int32, CAEXWrapper)][39]   | Inserts the specified CAEX object in it's associated sequence at the defined position. The CAEXBasicObject defines the [Revision][25] and [SourceObjectInformation][27] sequences. (Inherited from [CAEXBasicObject][3].)                                                                               
![Public method] | [Insert(CAEXWrapper, Boolean)][40] | Inserts the specified CAEX object in it's associated sequence. The CAEXBasicObject defines the [Revision][25] and [SourceObjectInformation][27] sequences. (Inherited from [CAEXBasicObject][3].)                                                                                                       
![Public method] | [InsertNew][41]                    | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][24] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][2].)                        
![Public method] | [New_Revision][42]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][25] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][3].) 
![Public method] | [Remove][43]                       | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                    
![Public method] | [SetXAttributeValue][44]           | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][2].)                                                                                                                                                                   


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][45] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][2].) 


Extension Methods
-----------------

                           | Name                                  | Description                                                                                                                                                                                                                                                       
-------------------------- | ------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [clone][46]                           | [Copy(Boolean, Boolean, Boolean)][35] (Defined by [AMLEngineAdapter][47].)                                                                                                                                                                                        
![Public Extension Method] | [CloneNode][48]                       | Clones the node. (Defined by [AMLEngineAdapter][47].)                                                                                                                                                                                                             
![Public Extension Method] | [ConsistencyCheck_ClassReference][49] | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][47].)                                                                                                                                           
![Public Extension Method] | [Descendants(Type)][50]               | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                          
![Public Extension Method] | [Descendants&lt;T>()][52]             | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                          
![Public Extension Method] | [findInternalElement][53]             | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][47].)                                                                                                                                        
![Public Extension Method] | [getReferencedClass][54]              | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][47].)                                                                                                                                                                                       
![Public Extension Method] | [getReferencedGUID][55]               | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][47].)                                                                                                                                                               
![Public Extension Method] | [getReferencedInterfaceClass][56]     | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][47].)                                                                                                                                             
![Public Extension Method] | [getReferencedInterfaceName][57]      | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][47].)                                                                                                                                                                                
![Public Extension Method] | [Insert_Element][58]                  | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][47].)                                       
![Public Extension Method] | [Insert_NewInstance][59]              | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][47].) 
![Public Extension Method] | [Insert_TypeBaseElement][60]          | [Insert(CAEXWrapper, Boolean)][40] (Defined by [AMLEngineAdapter][47].)                                                                                                                                                                                           
![Public Extension Method] | [Name()][61]                          | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][47].)                                                                                                                                                                            
![Public Extension Method] | [Name()][62]                          | Overloaded. Gets a names for the specified caex wrapper object. If the specified object is a [CAEXObject][63], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][51].)                                        
![Public Extension Method] | [New_Comment][64]                     | Adding a new Comment node to this revision. (Defined by [AMLEngineAdapter][47].)                                                                                                                                                                                  
![Public Extension Method] | [New_Description][65]                 | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][51].)                                                                                                                                                   
![Public Extension Method] | [New_NewVersion][66]                  | Adding a new NewVersion node to this revision. (Defined by [AMLEngineAdapter][47].)                                                                                                                                                                               
![Public Extension Method] | [New_OldVersion][67]                  | Adding a new OldVersion node to this revision. (Defined by [AMLEngineAdapter][47].)                                                                                                                                                                               


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][4]  
[Aml.Engine.CAEX.CAEXBasicObject][3]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../CAEXWrapper/README.md
[3]: ../CAEXBasicObject/README.md
[4]: ../README.md
[5]: _ctor.md
[6]: ../CAEXBasicObject/AdditionalInformation.md
[7]: AuthorName.md
[8]: ../CAEXWrapper/CAEXDocument.md
[9]: ../CAEXWrapper/CAEXParent.md
[10]: ../CAEXWrapper/CAEXSequenceOfCAEXObject.md
[11]: ../CAEXBasicObject/ChangeMode.md
[12]: Comment.md
[13]: ../CAEXBasicObject/Copyright.md
[14]: ../CAEXBasicObject/CopyrightElement.md
[15]: ../CAEXBasicObject/Description.md
[16]: ../CAEXBasicObject/DescriptionElement.md
[17]: ../CAEXWrapper/Document.md
[18]: ../CAEXWrapper/Exists.md
[19]: NewVersion.md
[20]: NewVersionObject.md
[21]: ../CAEXWrapper/Node.md
[22]: OldVersion.md
[23]: OldVersionObject.md
[24]: ../CAEXWrapper/Owner.md
[25]: ../CAEXBasicObject/Revision.md
[26]: RevisionDate.md
[27]: ../CAEXBasicObject/SourceObjectInformation.md
[28]: ../CAEXWrapper/TagName.md
[29]: ../CAEXBasicObject/Version.md
[30]: ../CAEXBasicObject/VersionElement.md
[31]: ../CAEXWrapper/CAEXChild.md
[32]: ../CAEXWrapper/CAEXChildren.md
[33]: ../CAEXBasicObject/CAEXSequence.md
[34]: ../CAEXBasicObject/Container__1.md
[35]: ../CAEXWrapper/Copy.md
[36]: ../CAEXWrapper/Equals.md
[37]: ../CAEXWrapper/GetHashCode.md
[38]: ../CAEXWrapper/GetXAttributeValue.md
[39]: ../CAEXBasicObject/Insert_1.md
[40]: ../CAEXBasicObject/Insert.md
[41]: ../CAEXWrapper/InsertNew.md
[42]: ../CAEXBasicObject/New_Revision.md
[43]: ../CAEXWrapper/Remove.md
[44]: ../CAEXWrapper/SetXAttributeValue.md
[45]: ../CAEXWrapper/PropertyChanged.md
[46]: ../../Aml.Engine.Adapter/AMLEngineAdapter/clone.md
[47]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[48]: ../../Aml.Engine.Adapter/AMLEngineAdapter/CloneNode.md
[49]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ConsistencyCheck_ClassReference.md
[50]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[51]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[52]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[53]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[54]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedClass.md
[55]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedGUID.md
[56]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceClass.md
[57]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceName.md
[58]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_Element.md
[59]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_NewInstance.md
[60]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_TypeBaseElement.md
[61]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Name.md
[62]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[63]: ../CAEXObject/README.md
[64]: ../../Aml.Engine.Adapter/AMLEngineAdapter/New_Comment.md
[65]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[66]: ../../Aml.Engine.Adapter/AMLEngineAdapter/New_NewVersion.md
[67]: ../../Aml.Engine.Adapter/AMLEngineAdapter/New_OldVersion.md
[68]: https://www.automationml.org
[69]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"