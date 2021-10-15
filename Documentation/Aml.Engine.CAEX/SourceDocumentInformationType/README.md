SourceDocumentInformationType Class
===================================
This Class is a wrapper for the CAEXElement 'SourceDocumentInformation' which a structure to model information about the data source of the present CAEX document.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.CAEXWrapper][2]  
    **Aml.Engine.CAEX.SourceDocumentInformationType**  

  **Namespace:**  [Aml.Engine.CAEX][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class SourceDocumentInformationType : CAEXWrapper
```

The **SourceDocumentInformationType** type exposes the following members.


Constructors
------------

                 | Name                               | Description                                                                
---------------- | ---------------------------------- | -------------------------------------------------------------------------- 
![Public method] | [SourceDocumentInformationType][4] | Initializes a new instance of the **SourceDocumentInformationType** class. 


Properties
----------

                   | Name                          | Description                                                                                                                                                                                            
------------------ | ----------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public property] | [CAEXDocument][5]             | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][2].)    
![Public property] | [CAEXParent][6]               | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][2].)                                                                                                                  
![Public property] | [CAEXSequenceOfCAEXObject][7] | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                   
![Public property] | [Document][8]                 | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                       
![Public property] | [Exists][9]                   | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                      
![Public property] | [LastWritingDateTime][10]     | gets and sets the Date and time of the creation of the CAEX document.                                                                                                                                  
![Public property] | [Node][11]                    | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                        
![Public property] | [OriginID][12]                | Gets and sets an identifier of the origin of the CAEX document, e.g. a unique identifier of a source engineering tool or an exporter software. The ID shall not change even if the origin gets renamed 
![Public property] | [OriginName][13]              | Gets and sets the Name of the origin of the CAEX document, e.g. the source engineering tool or an exporter software                                                                                    
![Public property] | [OriginProjectID][14]         | Gets and sets a unique identifier of the corresponding source project (optional in CAEX)                                                                                                               
![Public property] | [OriginProjectTitle][15]      | Gets and sets the title of the corresponding source project (optional in CAEX)                                                                                                                         
![Public property] | [OriginRelease][16]           | Gets and sets the release information of the origin of the CAEX document, e.g. the version of the source engineering tool or the exporter software (optional in CAEX)                                  
![Public property] | [OriginVendor][17]            | Gets and sets the vendor of the data source of the CAEX document (optional in CAEX)                                                                                                                    
![Public property] | [OriginVendorURL][18]         | Gets and sets the vendors URL of the data source of the CAEX document (optional in CAEX)                                                                                                               
![Public property] | [OriginVersion][19]           | Gets and sets the Version of the origin of the CAEX document, e.g. the version of the source engineering tool or the exporter software.                                                                
![Public property] | [Owner][20]                   | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][2].)                                                                                                                               
![Public property] | [TagName][21]                 | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][2].)                                                                                                                 


Methods
-------

                 | Name                     | Description                                                                                                                                                                                                                                                                      
---------------- | ------------------------ | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [CAEXChild][22]          | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                      
![Public method] | [CAEXChildren][23]       | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                         
![Public method] | [Copy][24]               | Creates a deep copy of this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                       
![Public method] | [Equals][25]             | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][2].)                                                                                                                                                    
![Public method] | [GetHashCode][26]        | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                          
![Public method] | [GetXAttributeValue][27] | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][2].)                                                                                                                                             
![Public method] | [InsertNew][28]          | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][20] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][2].) 
![Public method] | [Remove][29]             | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][2].)                                                                                                                                             
![Public method] | [SetXAttributeValue][30] | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][2].)                                                                                                                                            


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][31] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][2].) 


Extension Methods
-----------------

                           | Name                      | Description                                                                                                                                                                                                    
-------------------------- | ------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [Descendants(Type)][32]   | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][33].)                                                                       
![Public Extension Method] | [Descendants&lt;T>()][34] | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][33].)                                                                       
![Public Extension Method] | [Name][35]                | Gets a names for the specified CAEX wrapper object. If the specified object is a [CAEXObject][36], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][33].) 
![Public Extension Method] | [SetMetaInformation][37]  | Sets the properties for the specified SourceDocumentInformation object using the provided MetaInformation (Defined by [AmlObjectsExtensions][38].)                                                             


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][3]  
[Aml.Engine.CAEX.CAEXWrapper][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../CAEXWrapper/README.md
[3]: ../README.md
[4]: _ctor.md
[5]: ../CAEXWrapper/CAEXDocument.md
[6]: ../CAEXWrapper/CAEXParent.md
[7]: ../CAEXWrapper/CAEXSequenceOfCAEXObject.md
[8]: ../CAEXWrapper/Document.md
[9]: ../CAEXWrapper/Exists.md
[10]: LastWritingDateTime.md
[11]: ../CAEXWrapper/Node.md
[12]: OriginID.md
[13]: OriginName.md
[14]: OriginProjectID.md
[15]: OriginProjectTitle.md
[16]: OriginRelease.md
[17]: OriginVendor.md
[18]: OriginVendorURL.md
[19]: OriginVersion.md
[20]: ../CAEXWrapper/Owner.md
[21]: ../CAEXWrapper/TagName.md
[22]: ../CAEXWrapper/CAEXChild.md
[23]: ../CAEXWrapper/CAEXChildren.md
[24]: ../CAEXWrapper/Copy.md
[25]: ../CAEXWrapper/Equals.md
[26]: ../CAEXWrapper/GetHashCode.md
[27]: ../CAEXWrapper/GetXAttributeValue.md
[28]: ../CAEXWrapper/InsertNew.md
[29]: ../CAEXWrapper/Remove.md
[30]: ../CAEXWrapper/SetXAttributeValue.md
[31]: ../CAEXWrapper/PropertyChanged.md
[32]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[33]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[34]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[35]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[36]: ../CAEXObject/README.md
[37]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/SetMetaInformation_2.md
[38]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[39]: https://www.automationml.org
[40]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"