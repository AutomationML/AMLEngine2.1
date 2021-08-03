BaseElementType&lt;TDataType> Class
===================================
This class is a generic base class for CAEX elements with simple values. This class is used by the CAEX adapter only.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.CAEXWrapper][2]  
    [Aml.Engine.CAEX.CAEXWrapper][3]&lt;**TDataType**>  
      **Aml.Engine.CAEX.BaseElementType&lt;TDataType>**  
        [Aml.Engine.CAEX.CopyrightType][4]  
        [Aml.Engine.CAEX.DescriptionType][5]  
        [Aml.Engine.CAEX.VersionType][6]  

  **Namespace:**  [Aml.Engine.CAEX][7]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class BaseElementType<TDataType> : CAEXWrapper<TDataType>
where TDataType : class

```

#### Type Parameters

##### *TDataType*
The type of the element data type.

The **BaseElementType&lt;TDataType>** type exposes the following members.


Constructors
------------

                 | Name                               | Description                                                                
---------------- | ---------------------------------- | -------------------------------------------------------------------------- 
![Public method] | [BaseElementType&lt;TDataType>][8] | Initializes a new instance of the **BaseElementType&lt;TDataType>** class. 


Properties
----------

                   | Name                           | Description                                                                                                                                                                                                                                       
------------------ | ------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [CAEXDocument][9]              | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][2].)                                               
![Public property] | [CAEXParent][10]               | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][2].)                                                                                                                                                             
![Public property] | [CAEXSequenceOfCAEXObject][11] | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                                              
![Public property] | [ChangeMode][12]               | Optionally describes the change state of a CAEX object. If used, the ChangeMode shall have the following value range: state, create, delete and change. This information should be used for further change management applications.               
![Public property] | [Document][13]                 | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                                                  
![Public property] | [Exists][14]                   | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                                 
![Public property] | [Node][15]                     | Gets the wrapped XML node. (Inherited from [CAEXWrapper&lt;TDataType>][3].)                                                                                                                                                                       
![Public property] | [Owner][16]                    | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][2].)                                                                                                                                                                          
![Public property] | [TagName][17]                  | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][2].)                                                                                                                                                            
![Public property] | [Value][18]                    | Gets and sets the value of the wrapped XML node, according to the defined DataType. If the element doesn't exists, it is created and inserted into the document as a child of the defined owner. (Inherited from [CAEXWrapper&lt;TDataType>][3].) 


Methods
-------

                 | Name                     | Description                                                                                                                                                                                                                                                                      
---------------- | ------------------------ | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [CAEXChild][19]          | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                      
![Public method] | [CAEXChildren][20]       | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                         
![Public method] | [Copy][21]               | Creates a deep copy of this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                       
![Public method] | [Equals][22]             | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][2].)                                                                                                                                                    
![Public method] | [GetHashCode][23]        | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                          
![Public method] | [GetXAttributeValue][24] | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][2].)                                                                                                                                             
![Public method] | [InsertNew][25]          | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][16] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][2].) 
![Public method] | [Remove][26]             | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][2].)                                                                                                                                             
![Public method] | [SetXAttributeValue][27] | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][2].)                                                                                                                                            


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][28] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][2].) 


Extension Methods
-----------------

                           | Name                      | Description                                                                                                                                                                                                    
-------------------------- | ------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [Descendants(Type)][29]   | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][30].)                                                                       
![Public Extension Method] | [Descendants&lt;T>()][31] | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][30].)                                                                       
![Public Extension Method] | [Name][32]                | Gets a names for the specified caex wrapper object. If the specified object is a [CAEXObject][33], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][30].) 


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][7]  
[Aml.Engine.CAEX.CAEXWrapper&lt;TDataType>][3]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../CAEXWrapper/README.md
[3]: ../CAEXWrapper_1/README.md
[4]: ../CopyrightType/README.md
[5]: ../DescriptionType/README.md
[6]: ../VersionType/README.md
[7]: ../README.md
[8]: _ctor.md
[9]: ../CAEXWrapper/CAEXDocument.md
[10]: ../CAEXWrapper/CAEXParent.md
[11]: ../CAEXWrapper/CAEXSequenceOfCAEXObject.md
[12]: ChangeMode.md
[13]: ../CAEXWrapper/Document.md
[14]: ../CAEXWrapper/Exists.md
[15]: ../CAEXWrapper_1/Node.md
[16]: ../CAEXWrapper/Owner.md
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
[33]: ../CAEXObject/README.md
[34]: https://www.automationml.org
[35]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"