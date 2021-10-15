SourceObjectInformationType Class
=================================
This class is a wrapper for the CAEX element 'SourceObjectInformation'. This element can be assigned to a [CAEXObject][1] to store a mapping between the ID of a CAEXObject and the ID of the same object, as it is defined in the object source.


Inheritance Hierarchy
---------------------
[System.Object][2]  
  [Aml.Engine.CAEX.CAEXWrapper][3]  
    [Aml.Engine.CAEX.CAEXWrapper][4]&lt;[String][5]>  
      **Aml.Engine.CAEX.SourceObjectInformationType**  

  **Namespace:**  [Aml.Engine.CAEX][6]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class SourceObjectInformationType : CAEXWrapper<string>
```

The **SourceObjectInformationType** type exposes the following members.


Constructors
------------

                 | Name                             | Description                                                              
---------------- | -------------------------------- | ------------------------------------------------------------------------ 
![Public method] | [SourceObjectInformationType][7] | Initializes a new instance of the **SourceObjectInformationType** class. 


Properties
----------

                   | Name                           | Description                                                                                                                                                                                                                                       
------------------ | ------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [CAEXDocument][8]              | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][3].)                                               
![Public property] | [CAEXParent][9]                | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][3].)                                                                                                                                                             
![Public property] | [CAEXSequenceOfCAEXObject][10] | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][3].)                                                                                                                                                              
![Public property] | [Document][11]                 | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][3].)                                                                                                                                                                  
![Public property] | [Exists][12]                   | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][3].)                                                                                                                                                 
![Public property] | [Node][13]                     | Gets the wrapped XML node. (Inherited from [CAEXWrapper&lt;TDataType>][4].)                                                                                                                                                                       
![Public property] | [OriginID][14]                 | Gets and sets a value for the OriginID attribute of a SourceObjectInformation object.                                                                                                                                                             
![Public property] | [Owner][15]                    | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][3].)                                                                                                                                                                          
![Public property] | [SourceObjID][16]              | Gets and sets a value for the SourceObjID attribute of a SourceObjectInformation object.                                                                                                                                                          
![Public property] | [TagName][17]                  | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][3].)                                                                                                                                                            
![Public property] | [Value][18]                    | Gets and sets the value of the wrapped XML node, according to the defined DataType. If the element doesn't exists, it is created and inserted into the document as a child of the defined owner. (Inherited from [CAEXWrapper&lt;TDataType>][4].) 


Methods
-------

                 | Name                     | Description                                                                                                                                                                                                                                                                      
---------------- | ------------------------ | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [CAEXChild][19]          | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                      
![Public method] | [CAEXChildren][20]       | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                         
![Public method] | [Copy][21]               | Creates a deep copy of this CAEX object (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                       
![Public method] | [Equals][22]             | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][3].)                                                                                                                                                    
![Public method] | [GetHashCode][23]        | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                          
![Public method] | [GetXAttributeValue][24] | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][3].)                                                                                                                                             
![Public method] | [InsertNew][25]          | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][15] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][3].) 
![Public method] | [Remove][26]             | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][3].)                                                                                                                                             
![Public method] | [SetXAttributeValue][27] | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][3].)                                                                                                                                            


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][28] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][3].) 


Extension Methods
-----------------

                           | Name                      | Description                                                                                                                                                                                                   
-------------------------- | ------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [Descendants(Type)][29]   | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][30].)                                                                      
![Public Extension Method] | [Descendants&lt;T>()][31] | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][30].)                                                                      
![Public Extension Method] | [Name][32]                | Gets a names for the specified CAEX wrapper object. If the specified object is a [CAEXObject][1], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][30].) 


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][6]  
[Aml.Engine.CAEX.CAEXWrapper&lt;TDataType>][4]  

[1]: ../CAEXObject/README.md
[2]: https://docs.microsoft.com/dotnet/api/system.object
[3]: ../CAEXWrapper/README.md
[4]: ../CAEXWrapper_1/README.md
[5]: https://docs.microsoft.com/dotnet/api/system.string
[6]: ../README.md
[7]: _ctor.md
[8]: ../CAEXWrapper/CAEXDocument.md
[9]: ../CAEXWrapper/CAEXParent.md
[10]: ../CAEXWrapper/CAEXSequenceOfCAEXObject.md
[11]: ../CAEXWrapper/Document.md
[12]: ../CAEXWrapper/Exists.md
[13]: ../CAEXWrapper_1/Node.md
[14]: OriginID.md
[15]: ../CAEXWrapper/Owner.md
[16]: SourceObjID.md
[17]: ../CAEXWrapper/TagName.md
[18]: ../CAEXWrapper_1/Value.md
[19]: ../CAEXWrapper/CAEXChild.md
[20]: ../CAEXWrapper/CAEXChildren.md
[21]: ../CAEXWrapper/Copy.md
[22]: ../CAEXWrapper/Equals.md
[23]: ../CAEXWrapper/GetHashCode.md
[24]: ../CAEXWrapper/GetXAttributeValue.md
[25]: ../CAEXWrapper/InsertNew.md
[26]: ../CAEXWrapper/Remove.md
[27]: ../CAEXWrapper/SetXAttributeValue.md
[28]: ../CAEXWrapper/PropertyChanged.md
[29]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[30]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[31]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[32]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[33]: https://www.automationml.org
[34]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"