CopyrightType Class
===================
This class is a wrapper for the CAEX element 'Copyright'.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.CAEXWrapper][2]  
    [Aml.Engine.CAEX.CAEXWrapper][3]&lt;[String][4]>  
      [Aml.Engine.CAEX.BaseElementType][5]&lt;[String][4]>  
        **Aml.Engine.CAEX.CopyrightType**  

  **Namespace:**  [Aml.Engine.CAEX][6]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class CopyrightType : BaseElementType<string>
```

The **CopyrightType** type exposes the following members.


Constructors
------------

                 | Name               | Description                                                
---------------- | ------------------ | ---------------------------------------------------------- 
![Public method] | [CopyrightType][7] | Initializes a new instance of the **CopyrightType** class. 


Properties
----------

                   | Name                           | Description                                                                                                                                                                                                                                                                              
------------------ | ------------------------------ | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [CAEXDocument][8]              | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][2].)                                                                                      
![Public property] | [CAEXParent][9]                | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                    
![Public property] | [CAEXSequenceOfCAEXObject][10] | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                     
![Public property] | [ChangeMode][11]               | Optionally describes the change state of a CAEX object. If used, the ChangeMode shall have the following value range: state, create, delete and change. This information should be used for further change management applications. (Inherited from [BaseElementType&lt;TDataType>][5].) 
![Public property] | [Document][12]                 | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                         
![Public property] | [Exists][13]                   | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                        
![Public property] | [Node][14]                     | Gets the wrapped XML node. (Inherited from [CAEXWrapper&lt;TDataType>][3].)                                                                                                                                                                                                              
![Public property] | [Owner][15]                    | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                 
![Public property] | [TagName][16]                  | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                   
![Public property] | [Value][17]                    | Gets and sets the value of the wrapped XML node, according to the defined DataType. If the element doesn't exists, it is created and inserted into the document as a child of the defined owner. (Inherited from [CAEXWrapper&lt;TDataType>][3].)                                        


Methods
-------

                 | Name                     | Description                                                                                                                                                                                                                                                                      
---------------- | ------------------------ | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [CAEXChild][18]          | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                      
![Public method] | [CAEXChildren][19]       | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                         
![Public method] | [Copy][20]               | Creates a deep copy of this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                       
![Public method] | [Equals][21]             | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][2].)                                                                                                                                                    
![Public method] | [GetHashCode][22]        | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                          
![Public method] | [GetXAttributeValue][23] | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][2].)                                                                                                                                             
![Public method] | [InsertNew][24]          | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][15] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][2].) 
![Public method] | [Remove][25]             | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][2].)                                                                                                                                             
![Public method] | [SetXAttributeValue][26] | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][2].)                                                                                                                                            


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][27] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][2].) 


Extension Methods
-----------------

                           | Name                      | Description                                                                                                                                                                                                    
-------------------------- | ------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [Descendants(Type)][28]   | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][29].)                                                                       
![Public Extension Method] | [Descendants&lt;T>()][30] | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][29].)                                                                       
![Public Extension Method] | [Name][31]                | Gets a names for the specified CAEX wrapper object. If the specified object is a [CAEXObject][32], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][29].) 


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][6]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../CAEXWrapper/README.md
[3]: ../CAEXWrapper_1/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: ../BaseElementType_1/README.md
[6]: ../README.md
[7]: _ctor.md
[8]: ../CAEXWrapper/CAEXDocument.md
[9]: ../CAEXWrapper/CAEXParent.md
[10]: ../CAEXWrapper/CAEXSequenceOfCAEXObject.md
[11]: ../BaseElementType_1/ChangeMode.md
[12]: ../CAEXWrapper/Document.md
[13]: ../CAEXWrapper/Exists.md
[14]: ../CAEXWrapper_1/Node.md
[15]: ../CAEXWrapper/Owner.md
[16]: ../CAEXWrapper/TagName.md
[17]: ../CAEXWrapper_1/Value.md
[18]: ../CAEXWrapper/CAEXChild.md
[19]: ../CAEXWrapper/CAEXChildren.md
[20]: ../CAEXWrapper/Copy.md
[21]: ../CAEXWrapper/Equals.md
[22]: ../CAEXWrapper/GetHashCode.md
[23]: ../CAEXWrapper/GetXAttributeValue.md
[24]: ../CAEXWrapper/InsertNew.md
[25]: ../CAEXWrapper/Remove.md
[26]: ../CAEXWrapper/SetXAttributeValue.md
[27]: ../CAEXWrapper/PropertyChanged.md
[28]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[29]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[30]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[31]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[32]: ../CAEXObject/README.md
[33]: https://www.automationml.org
[34]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"