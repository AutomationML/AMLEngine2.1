CAEXWrapper&lt;TDataType> Class
===============================
A CAEXWrapper for any Element, which is defined as a simple type. The DataType of the simple type is used as the generic type parameter.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.CAEXWrapper][2]  
    **Aml.Engine.CAEX.CAEXWrapper&lt;TDataType>**  
      [Aml.Engine.CAEX.BaseElementType&lt;TDataType>][3]  
      [Aml.Engine.CAEX.SourceObjectInformationType][4]  

  **Namespace:**  [Aml.Engine.CAEX][5]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class CAEXWrapper<TDataType> : CAEXWrapper

```

#### Type Parameters

##### *TDataType*
The type of the data type.

The **CAEXWrapper&lt;TDataType>** type exposes the following members.


Constructors
------------

                 | Name                           | Description                                                            
---------------- | ------------------------------ | ---------------------------------------------------------------------- 
![Public method] | [CAEXWrapper&lt;TDataType>][6] | Initializes a new instance of the **CAEXWrapper&lt;TDataType>** class. 


Properties
----------

                   | Name                          | Description                                                                                                                                                                                         
------------------ | ----------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [CAEXDocument][7]             | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][2].) 
![Public property] | [CAEXParent][8]               | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][2].)                                                                                                               
![Public property] | [CAEXSequenceOfCAEXObject][9] | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                
![Public property] | [Document][10]                | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                    
![Public property] | [Exists][11]                  | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                   
![Public property] | [Node][12]                    | Gets the wrapped XML node. (Overrides [CAEXWrapper.Node][13].)                                                                                                                                      
![Public property] | [Owner][14]                   | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][2].)                                                                                                                            
![Public property] | [TagName][15]                 | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][2].)                                                                                                              
![Public property] | [Value][16]                   | Gets and sets the value of the wrapped XML node, according to the defined DataType. If the element doesn't exists, it is created and inserted into the document as a child of the defined owner.    


Methods
-------

                 | Name                     | Description                                                                                                                                                                                                                                                                      
---------------- | ------------------------ | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [CAEXChild][17]          | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                      
![Public method] | [CAEXChildren][18]       | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                         
![Public method] | [Copy][19]               | Creates a deep copy of this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                       
![Public method] | [Equals][20]             | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][2].)                                                                                                                                                    
![Public method] | [GetHashCode][21]        | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                          
![Public method] | [GetXAttributeValue][22] | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][2].)                                                                                                                                             
![Public method] | [InsertNew][23]          | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][14] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][2].) 
![Public method] | [Remove][24]             | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][2].)                                                                                                                                             
![Public method] | [SetXAttributeValue][25] | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][2].)                                                                                                                                            


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][26] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][2].) 


Extension Methods
-----------------

                           | Name                      | Description                                                                                                                                                                                                    
-------------------------- | ------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [Descendants(Type)][27]   | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][28].)                                                                       
![Public Extension Method] | [Descendants&lt;T>()][29] | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][28].)                                                                       
![Public Extension Method] | [Name][30]                | Gets a names for the specified CAEX wrapper object. If the specified object is a [CAEXObject][31], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][28].) 


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][5]  
[System.ComponentModel.INotifyPropertyChanged][32]  
[Aml.Engine.CAEX.ICAEXWrapper][33]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../CAEXWrapper/README.md
[3]: ../BaseElementType_1/README.md
[4]: ../SourceObjectInformationType/README.md
[5]: ../README.md
[6]: _ctor.md
[7]: ../CAEXWrapper/CAEXDocument.md
[8]: ../CAEXWrapper/CAEXParent.md
[9]: ../CAEXWrapper/CAEXSequenceOfCAEXObject.md
[10]: ../CAEXWrapper/Document.md
[11]: ../CAEXWrapper/Exists.md
[12]: Node.md
[13]: ../CAEXWrapper/Node.md
[14]: ../CAEXWrapper/Owner.md
[15]: ../CAEXWrapper/TagName.md
[16]: Value.md
[17]: ../CAEXWrapper/CAEXChild.md
[18]: ../CAEXWrapper/CAEXChildren.md
[19]: ../CAEXWrapper/Copy.md
[20]: ../CAEXWrapper/Equals.md
[21]: ../CAEXWrapper/GetHashCode.md
[22]: ../CAEXWrapper/GetXAttributeValue.md
[23]: ../CAEXWrapper/InsertNew.md
[24]: ../CAEXWrapper/Remove.md
[25]: ../CAEXWrapper/SetXAttributeValue.md
[26]: ../CAEXWrapper/PropertyChanged.md
[27]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[28]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[29]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[30]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[31]: ../CAEXObject/README.md
[32]: https://docs.microsoft.com/dotnet/api/system.componentmodel.inotifypropertychanged
[33]: ../ICAEXWrapper/README.md
[34]: https://www.automationml.org
[35]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"