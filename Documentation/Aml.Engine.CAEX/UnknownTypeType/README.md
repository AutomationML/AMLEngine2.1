UnknownTypeType Class
=====================
AutomationML 2.1 APIThis class is a CAEXWrapper for the 'UnknownType' Element which is a choice for an [AttributeValueRequirementType][1]


Inheritance Hierarchy
---------------------
[System.Object][2]  
  [Aml.Engine.CAEX.CAEXWrapper][3]  
    **Aml.Engine.CAEX.UnknownTypeType**  

  **Namespace:**  [Aml.Engine.CAEX][4]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class UnknownTypeType : CAEXWrapper
```

The **UnknownTypeType** type exposes the following members.


Constructors
------------

                 | Name                 | Description                                                  
---------------- | -------------------- | ------------------------------------------------------------ 
![Public method] | [UnknownTypeType][5] | Initializes a new instance of the **UnknownTypeType** class. 


Properties
----------

                   | Name                          | Description                                                                                                                                                                                         
------------------ | ----------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [CAEXDocument][6]             | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][3].) 
![Public property] | [CAEXParent][7]               | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][3].)                                                                                                               
![Public property] | [CAEXSequenceOfCAEXObject][8] | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][3].)                                                                                                                
![Public property] | [Document][9]                 | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][3].)                                                                                                                    
![Public property] | [Exists][10]                  | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][3].)                                                                                                   
![Public property] | [Node][11]                    | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][3].)                                                                                                                                     
![Public property] | [Owner][12]                   | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][3].)                                                                                                                            
![Public property] | [Requirements][13]            | Gets and sets the value of the Requirements element                                                                                                                                                 
![Public property] | [TagName][14]                 | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][3].)                                                                                                              


Methods
-------

                 | Name                     | Description                                                                                                                                                                                                                                                                      
---------------- | ------------------------ | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [CAEXChild][15]          | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                      
![Public method] | [CAEXChildren][16]       | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                         
![Public method] | [Copy][17]               | Creates a deep copy of this CAEX object (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                       
![Public method] | [Equals][18]             | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][3].)                                                                                                                                                    
![Public method] | [GetHashCode][19]        | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                          
![Public method] | [GetXAttributeValue][20] | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][3].)                                                                                                                                             
![Public method] | [InsertNew][21]          | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][12] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][3].) 
![Public method] | [Remove][22]             | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][3].)                                                                                                                                             
![Public method] | [SetXAttributeValue][23] | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][3].)                                                                                                                                            


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][24] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][3].) 


Extension Methods
-----------------

                           | Name                      | Description                                                                                                                                                                                                    
-------------------------- | ------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [Descendants(Type)][25]   | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][26].)                                                                       
![Public Extension Method] | [Descendants&lt;T>()][27] | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][26].)                                                                       
![Public Extension Method] | [Name][28]                | Gets a names for the specified caex wrapper object. If the specified object is a [CAEXObject][29], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][26].) 


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][4]  
[Aml.Engine.CAEX.CAEXWrapper][3]  

[1]: ../AttributeValueRequirementType/README.md
[2]: https://docs.microsoft.com/dotnet/api/system.object
[3]: ../CAEXWrapper/README.md
[4]: ../README.md
[5]: _ctor.md
[6]: ../CAEXWrapper/CAEXDocument.md
[7]: ../CAEXWrapper/CAEXParent.md
[8]: ../CAEXWrapper/CAEXSequenceOfCAEXObject.md
[9]: ../CAEXWrapper/Document.md
[10]: ../CAEXWrapper/Exists.md
[11]: ../CAEXWrapper/Node.md
[12]: ../CAEXWrapper/Owner.md
[13]: Requirements.md
[14]: ../CAEXWrapper/TagName.md
[15]: ../CAEXWrapper/CAEXChild.md
[16]: ../CAEXWrapper/CAEXChildren.md
[17]: ../CAEXWrapper/Copy.md
[18]: ../CAEXWrapper/Equals.md
[19]: ../CAEXWrapper/GetHashCode.md
[20]: ../CAEXWrapper/GetXAttributeValue.md
[21]: ../CAEXWrapper/InsertNew.md
[22]: ../CAEXWrapper/Remove.md
[23]: ../CAEXWrapper/SetXAttributeValue.md
[24]: ../CAEXWrapper/PropertyChanged.md
[25]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[26]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[27]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[28]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[29]: ../CAEXObject/README.md
[30]: https://www.automationml.org
[31]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"