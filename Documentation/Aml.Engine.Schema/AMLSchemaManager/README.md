AMLSchemaManager Class
======================
AutomationML 2.1 APIClass AMLSchemaManager extends the XMLSchemaManager. Methods which create new objects are overridden to add required properties and values to some objects which is not defined in the underlying CAEX schema but in the AML standard.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.Schema.XmlSchemaManager][2]  
    **Aml.Engine.Schema.AMLSchemaManager**  
      [Aml.Engine.Schema.AMLSchemaManager2_15][3]  
      [Aml.Engine.Schema.AMLSchemaManager3_0][4]  

  **Namespace:**  [Aml.Engine.Schema][5]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public abstract class AMLSchemaManager : XmlSchemaManager
```

The **AMLSchemaManager** type exposes the following members.


Properties
----------

                   | Name                | Description                                                            
------------------ | ------------------- | ---------------------------------------------------------------------- 
![Public property] | [Namespace][6]      | Gets the Schema Namespace (Inherited from [XmlSchemaManager][2].)      
![Public property] | [SchemaLocation][7] | Gets the SchemaLocation string (Inherited from [XmlSchemaManager][2].) 
![Public property] | [SchemaSet][8]      | Gets the actual XSD schema set (Inherited from [XmlSchemaManager][2].) 


Methods
-------

                 | Name                                           | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
---------------- | ---------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public method] | [AcceptsAny][9]                                | Determines if the schema element accepts values of any type. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                                                                           
![Public method] | [AddNew][10]                                   | Creates a new Xml-Element with the provided content and inserts it to the provided parent according to this schema instance. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                           
![Public method] | [AddNewAfterSelf][11]                          | Creates a new Xml-Element with the provided content and inserts it behind the provided sibling according to this schema instance. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                      
![Public method] | [AttributeNames][12]                           | Gets the Attribute names of the specified child element of the specified parent element. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                                               
![Public method] | [Attributes][13]                               | Gets the Schema Elements for all attributes of the specified child element of the specified parent element, if the defined parent child relation exists in the xml schema. If required is set to `true`, only the required attributes are returned. The default behaviour is, that all attributes - optional and required attributes - are returned. (Inherited from [XmlSchemaManager][2].)                                                                                                                                   
![Public method] | [AttributeValueRestrictions][14]               | Gets the List of Attribute value restrictions for the attribute with the defined name. The Attribute should be an attribute of a child defined by the given name, which exists in the defined parent child relation defined by the parent name. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                        
![Public method] | [AttributeValueType(XmlSchemaAttribute)][15]   | Gets the type code for the schema attribute. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                                                                                           
![Public method] | [AttributeValueType(XName, XName, String)][16] | Gets the Attribute value types for the attribute with the defined name of a child element which belongs to the given parent. If `XmlTypeCode.Item` is returned, the value type is equal to the schema internal any type. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                               
![Public method] | [CanAddNew][17]                                | Determines, if a child with the specified name can be added to the parent node. The method checks the specified minimal and maximal occurrences, defined for this relation in the xml schema. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                          
![Public method] | [ChildElementNames][18]                        | Gets the Names for all elements, which can be added to the child which is defined with the name of it's parent and the name of itself. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                 
![Public method] | [ChildElements][19]                            | Gets the SchemaDefinition for all elements, which can be added to the child which is defined with the name of it's parent and the name of itself. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                      
![Public method] | [Choices][20]                                  | Gets the names of all alternative child nodes, which can be added to a parent node with the given name. The specified child itself is included. Choices only exists, if [IsChoice(String, String)][21] returns true for the defined child name. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                        
![Public method] | [CreateAttribute][22]                          | Creates the attribute with the provided name if this attribute is defined in this schema instance. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                                     
![Public method] | [CreateElement][23]                            | Method overrides the [CreateElement(XName, XName, Boolean)][24]. The created node is made to an AML node. (Overrides [XmlSchemaManager.CreateElement(XName, XName, Boolean)][24].)                                                                                                                                                                                                                                                                                                                                             
![Public method] | [GetAnnotation(XmlSchemaAnnotated)][25]        | Gets the annotation from the annotated schema element. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                                                                                 
![Public method] | [GetAnnotation(XmlSchemaAttribute)][26]        | Gets the annotation from the schema attribute element. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                                                                                 
![Public method] | [GetAnnotation(XmlSchemaElement)][27]          | Gets the annotation from the schema element. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                                                                                           
![Public method] | [HasChoiceOfElements][28]                      | Determines, whether the schema element representing the parent - child relation has a content, which is restricted to a choice of elements. If onlyOne is set to true, there can not be more than one element added to the element (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                     
![Public method] | [HasSequenceOfSimpleElements][29]              | Determines, if the schema defines a sequence of simple elements for the provided parent child combination. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                             
![Public method] | [Insert][30]                                   | Inserts an existing child node into the collection of child nodes of the specified parent node. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                                        
![Public method] | [InsertNew][31]                                | Creates a new node with the defined child name and inserts the newly created child into the child nodes collection of the specified parent. Optional, it can be specified, if the new node should get all attributes, which are defined in the schema, or only those attributes which are required (default behaviour). The Method can be overridden by specific schema managers, to add additional properties to the created node, which can not be derived directly from the schema. (Inherited from [XmlSchemaManager][2].) 
![Public method] | [IsChoice][21]                                 | Determines, whether the occurrence of a child with that name under a parent with that name is part of a choice (means that there are other exclusive alternatives for child nodes). If not, the child is defined in a sequence. For choices, the names of alternatives are available with [Choices(XName, XName)][20]. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                 
![Public method] | [IsChoiceForOneElement][32]                    | Determines if the schema defines a choice of only one element for the provided schema element. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                                         
![Public method] | [IsDefinedAttribute][33]                       | Determines, if the Attribute with the provided is defined for this element (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                                                             
![Public method] | [IsParent][34]                                 | Determines, if the parent is allowed to contain a child with the provided name according to this schema instance. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                      
![Public method] | [IsRequiredAttribute][35]                      | Determines, if the Attribute with the provided name is a required attribute when added to the parent child combination. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                
![Public method] | [MaxOccurence][36]                             | Returned the maximal occurrence for child nodes with the specified name under a parent node with the specified name. For unbounded occurrences, the returned value is [MaxValue][37]. If the occurrence is `0`, the existence of a child with that name under a parent with that name is not allowed. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                  
![Public method] | [MinOccurence][38]                             | The minimal occurrence for child node with the defined name under a parent node with the defined name. If 0 is returned, the existence of a child node with that node is optional. If 1 is returned, the existence is mandatory. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                       
![Public method] | [SchemaElement][39]                            | Gets the schema information for the provided parent child combination. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                                                                 
![Public method] | [SetSchemaVersion][40]                         | Sets the schema version.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
![Public method] | [SiblingBefore][41]                            | This method is a utility method for insert operations. The method will return the node which should be used as the sibling before a newly added child with the defined name. The Insertion has to be done after the returned node or prepended to the parent itself, if no node `null` is returned. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                    
![Public method] | [Validate][42]                                 | Validates a document if it is conform to this schema instance. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                                                                         
![Public method] | [ValueType][43]                                | Returns the type code for a value that may be associated with the defined child. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                                                       


Fields
------

                                | Name               | Description                               
------------------------------- | ------------------ | ----------------------------------------- 
![Public field]![Static member] | [ResourcePath][44] | Defines the resource path of the assembly 


See Also
--------

#### Reference
[Aml.Engine.Schema Namespace][5]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../XmlSchemaManager/README.md
[3]: ../AMLSchemaManager2_15/README.md
[4]: ../AMLSchemaManager3_0/README.md
[5]: ../README.md
[6]: ../XmlSchemaManager/Namespace.md
[7]: ../XmlSchemaManager/SchemaLocation.md
[8]: ../XmlSchemaManager/SchemaSet.md
[9]: ../XmlSchemaManager/AcceptsAny.md
[10]: ../XmlSchemaManager/AddNew.md
[11]: ../XmlSchemaManager/AddNewAfterSelf.md
[12]: ../XmlSchemaManager/AttributeNames.md
[13]: ../XmlSchemaManager/Attributes.md
[14]: ../XmlSchemaManager/AttributeValueRestrictions.md
[15]: ../XmlSchemaManager/AttributeValueType_1.md
[16]: ../XmlSchemaManager/AttributeValueType.md
[17]: ../XmlSchemaManager/CanAddNew.md
[18]: ../XmlSchemaManager/ChildElementNames.md
[19]: ../XmlSchemaManager/ChildElements.md
[20]: ../XmlSchemaManager/Choices.md
[21]: ../XmlSchemaManager/IsChoice.md
[22]: ../XmlSchemaManager/CreateAttribute.md
[23]: CreateElement.md
[24]: ../XmlSchemaManager/CreateElement.md
[25]: ../XmlSchemaManager/GetAnnotation.md
[26]: ../XmlSchemaManager/GetAnnotation_1.md
[27]: ../XmlSchemaManager/GetAnnotation_2.md
[28]: ../XmlSchemaManager/HasChoiceOfElements.md
[29]: ../XmlSchemaManager/HasSequenceOfSimpleElements.md
[30]: ../XmlSchemaManager/Insert.md
[31]: ../XmlSchemaManager/InsertNew.md
[32]: ../XmlSchemaManager/IsChoiceForOneElement.md
[33]: ../XmlSchemaManager/IsDefinedAttribute.md
[34]: ../XmlSchemaManager/IsParent.md
[35]: ../XmlSchemaManager/IsRequiredAttribute.md
[36]: ../XmlSchemaManager/MaxOccurence.md
[37]: https://docs.microsoft.com/dotnet/api/system.decimal.maxvalue
[38]: ../XmlSchemaManager/MinOccurence.md
[39]: ../XmlSchemaManager/SchemaElement.md
[40]: SetSchemaVersion.md
[41]: ../XmlSchemaManager/SiblingBefore.md
[42]: ../XmlSchemaManager/Validate.md
[43]: ../XmlSchemaManager/ValueType.md
[44]: ResourcePath.md
[45]: https://www.automationml.org
[46]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public field]: ../../icons/pubfield.gif "Public field"
[Static member]: ../../icons/static.gif "Static member"