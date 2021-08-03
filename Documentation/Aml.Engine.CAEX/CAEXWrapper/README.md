CAEXWrapper Class
=================
This class is the base CAEXWrapper class, defined for all CAEX objects. The CAEXWrapper class supports notifications of changes.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.CAEX.CAEXWrapper**  
    [More...][2]

  **Namespace:**  [Aml.Engine.CAEX][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class CAEXWrapper : INotifyPropertyChanged, 
	ICAEXWrapper, IXMLWrapper
```

The **CAEXWrapper** type exposes the following members.


Constructors
------------

                 | Name             | Description                                                                 
---------------- | ---------------- | --------------------------------------------------------------------------- 
![Public method] | [CAEXWrapper][4] | A new CAEXWrapper instance is constructed to wrap the provided XML element. 


Properties
----------

                   | Name                          | Description                                                                                                                                                      
------------------ | ----------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [CAEXDocument][5]             | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. 
![Public property] | [CAEXParent][6]               | Gets the CAEXParent of this instance if it exists.                                                                                                               
![Public property] | [CAEXSequenceOfCAEXObject][7] | Gets the CAEXSequence containing this CAEX object                                                                                                                
![Public property] | [Document][8]                 | Gets the XDocument of the wrapped XML-Element                                                                                                                    
![Public property] | [Exists][9]                   | Determines if this is a wrapper around an existing XML-Element                                                                                                   
![Public property] | [Node][10]                    | Gets the wrapped XML-Element                                                                                                                                     
![Public property] | [Owner][11]                   | Gets the wrapped Xml-Element's parent                                                                                                                            
![Public property] | [TagName][12]                 | Gets the name of the CAEX tag for this CAEX object.                                                                                                              


Methods
-------

                 | Name                     | Description                                                                                                                                                                                                                                   
---------------- | ------------------------ | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [CAEXChild][13]          | Gets the first child of this CAEX object with the defined CAEX tag name.                                                                                                                                                                      
![Public method] | [CAEXChildren][14]       | Gets all children of this CAEX object with the defined CAEX tag name.                                                                                                                                                                         
![Public method] | [Copy][15]               | Creates a deep copy of this CAEX object                                                                                                                                                                                                       
![Public method] | [Equals][16]             | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Overrides [Object.Equals(Object)][17].)                                                                                                           
![Public method] | [GetHashCode][18]        | Gets the Hash code for this instance, using the wrapped XML element. (Overrides [Object.GetHashCode()][19].)                                                                                                                                  
![Public method] | [GetXAttributeValue][20] | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element.                                                                                                                                             
![Public method] | [InsertNew][21]          | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][11] is defined. The new created CAEX object is inserted as a new child of the owner. 
![Public method] | [Remove][22]             | Removes this element. After that it is no longer assigned to a document and has no owner anymore.                                                                                                                                             
![Public method] | [SetXAttributeValue][23] | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null).                                                                                                                                            


Events
------

                | Name                  | Description                                            
--------------- | --------------------- | ------------------------------------------------------ 
![Public event] | [PropertyChanged][24] | The Change event raised when any property is modified. 


Operators
---------

                                   | Name             | Description                                    
---------------------------------- | ---------------- | ---------------------------------------------- 
![Public operator]![Static member] | [Equality][25]   | operator overload (compares the wrapped nodes) 
![Public operator]![Static member] | [Inequality][26] | operator overload (compares the wrapped nodes) 


Extension Methods
-----------------

                           | Name                                            | Description                                                                                                                                                                                                                                                                                                                                                                              
-------------------------- | ----------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [AMLSchemaManager][27]                          | Gets the associated CAEX schema manager of the CAEX object. (Defined by [CAEXBasicObjectExtensions][28].)                                                                                                                                                                                                                                                                                
![Public Extension Method] | [Ancestors&lt;T>][29]                           | Finds the ancestors of the provided CAEX object which have the given type. (Defined by [CAEXBasicObjectExtensions][28].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [CAEXDocument][30]                              | Gets the CAEX document which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][28].)                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [CAEXFile][31]                                  | Gets the CAEX file which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][28].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [CAEXSchema][32]                                | Gets the associated CAEX schema of the CAEX object. (Defined by [CAEXBasicObjectExtensions][28].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [Descendants(Type)][33]                         | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][28].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [Descendants&lt;T>()][34]                       | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][28].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [Descendants&lt;T>(Boolean)][35]                | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][28].)                                                                                                                                                                                                                                                 
![Public Extension Method] | [FindCaexObjectFromId&lt;T>][36]                | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][28].)                                                                                                                                                                                                                                                                        
![Public Extension Method] | [FindReferencedClass&lt;T>][37]                 | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][28].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [FirstAncestor(String)][38]                     | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][28].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][39] | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][28].)                                                                                                                                                                                                                                    
![Public Extension Method] | [FirstAncestor&lt;T>()][40]                     | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][28].)                                                                                                                                                                                                                                                       
![Public Extension Method] | [GetParent&lt;T>][41]                           | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][28].)                                                                                                                                                                                 
![Public Extension Method] | [IsAMLObject][42]                               | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][43].) 
![Public Extension Method] | [Library][44]                                   | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][28].)                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [Name][45]                                      | Gets a names for the specified caex wrapper object. If the specified object is a [CAEXObject][46], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][28].)                                                                                                                                                                           


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][3]  
[System.ComponentModel.INotifyPropertyChanged][47]  
[Aml.Engine.CAEX.ICAEXWrapper][48]  


Inheritance Hierarchy (Continued)
---------------------------------
[System.Object][1]  
  **Aml.Engine.CAEX.CAEXWrapper**  
    [Aml.Engine.CAEX.CAEXBasicObject][49]  
    [Aml.Engine.CAEX.CAEXWrapper&lt;TDataType>][50]  
    [Aml.Engine.CAEX.NominalScaledTypeType][51]  
    [Aml.Engine.CAEX.OrdinalScaledTypeType][52]  
    [Aml.Engine.CAEX.SourceDocumentInformationType][53]  
    [Aml.Engine.CAEX.UnknownTypeType][54]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: #inheritance-hierarchy-continued
[3]: ../README.md
[4]: _ctor.md
[5]: CAEXDocument.md
[6]: CAEXParent.md
[7]: CAEXSequenceOfCAEXObject.md
[8]: Document.md
[9]: Exists.md
[10]: Node.md
[11]: Owner.md
[12]: TagName.md
[13]: CAEXChild.md
[14]: CAEXChildren.md
[15]: Copy.md
[16]: Equals.md
[17]: https://docs.microsoft.com/dotnet/api/system.object.equals#System_Object_Equals_System_Object_
[18]: GetHashCode.md
[19]: https://docs.microsoft.com/dotnet/api/system.object.gethashcode#System_Object_GetHashCode
[20]: GetXAttributeValue.md
[21]: InsertNew.md
[22]: Remove.md
[23]: SetXAttributeValue.md
[24]: PropertyChanged.md
[25]: op_Equality.md
[26]: op_Inequality.md
[27]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/AMLSchemaManager.md
[28]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[29]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Ancestors__1.md
[30]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXDocument.md
[31]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXFile.md
[32]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXSchema.md
[33]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[34]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[35]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[36]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[37]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[38]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[39]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[40]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[41]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/GetParent__1.md
[42]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsAMLObject.md
[43]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[44]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Library.md
[45]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[46]: ../CAEXObject/README.md
[47]: https://docs.microsoft.com/dotnet/api/system.componentmodel.inotifypropertychanged
[48]: ../ICAEXWrapper/README.md
[49]: ../CAEXBasicObject/README.md
[50]: ../CAEXWrapper_1/README.md
[51]: ../NominalScaledTypeType/README.md
[52]: ../OrdinalScaledTypeType/README.md
[53]: ../SourceDocumentInformationType/README.md
[54]: ../UnknownTypeType/README.md
[55]: https://www.automationml.org
[56]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public operator]: ../../icons/puboperator.gif "Public operator"
[Static member]: ../../icons/static.gif "Static member"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"