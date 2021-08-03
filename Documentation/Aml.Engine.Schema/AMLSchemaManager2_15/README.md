AMLSchemaManager2_15 Class
==========================
Singleton Class: Schema manager for CAEX-Schema Version 2.15 used in AutomationML


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.Schema.XmlSchemaManager][2]  
    [Aml.Engine.Schema.AMLSchemaManager][3]  
      **Aml.Engine.Schema.AMLSchemaManager2_15**  

  **Namespace:**  [Aml.Engine.Schema][4]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class AMLSchemaManager2_15 : AMLSchemaManager
```

The **AMLSchemaManager2_15** type exposes the following members.


Properties
----------

                                   | Name                | Description                                                                                                   
---------------------------------- | ------------------- | ------------------------------------------------------------------------------------------------------------- 
![Public property]![Static member] | [Instance][5]       | Gets the static default SchemaManager Instance for the CAEX-Schema Version 2.15 used in AutomationML          
![Public property]                 | [Namespace][6]      | Gets the Schema Namespace (Inherited from [XmlSchemaManager][2].)                                             
![Public property]                 | [SchemaLocation][7] | SchemaLocation attribute defining noNamespaceSchemaLocation (Overrides [XmlSchemaManager.SchemaLocation][8].) 
![Public property]                 | [SchemaSet][9]      | Gets the actual XSD schema set (Inherited from [XmlSchemaManager][2].)                                        


Methods
-------

                 | Name                                           | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
---------------- | ---------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public method] | [AcceptsAny][10]                               | Determines if the schema element accepts values of any type. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                                                                           
![Public method] | [AddNew][11]                                   | Creates a new Xml-Element with the provided content and inserts it to the provided parent according to this schema instance. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                           
![Public method] | [AddNewAfterSelf][12]                          | Creates a new Xml-Element with the provided content and inserts it behind the provided sibling according to this schema instance. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                      
![Public method] | [AttributeNames][13]                           | Gets the Attribute names of the specified child element of the specified parent element. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                                               
![Public method] | [Attributes][14]                               | Gets the Schema Elements for all attributes of the specified child element of the specified parent element, if the defined parent child relation exists in the xml schema. If required is set to `true`, only the required attributes are returned. The default behaviour is, that all attributes - optional and required attributes - are returned. (Inherited from [XmlSchemaManager][2].)                                                                                                                                   
![Public method] | [AttributeValueRestrictions][15]               | Gets the List of Attribute value restrictions for the attribute with the defined name. The Attribute should be an attribute of a child defined by the given name, which exists in the defined parent child relation defined by the parent name. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                        
![Public method] | [AttributeValueType(XmlSchemaAttribute)][16]   | Gets the type code for the schema attribute. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                                                                                           
![Public method] | [AttributeValueType(XName, XName, String)][17] | Gets the Attribute value types for the attribute with the defined name of a child element which belongs to the given parent. If `XmlTypeCode.Item` is returned, the value type is equal to the schema internal any type. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                               
![Public method] | [CanAddNew][18]                                | Determines, if a child with the specified name can be added to the parent node. The method checks the specified minimal and maximal occurrences, defined for this relation in the xml schema. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                          
![Public method] | [ChildElementNames][19]                        | Gets the Names for all elements, which can be added to the child which is defined with the name of it's parent and the name of itself. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                 
![Public method] | [ChildElements][20]                            | Gets the SchemaDefinition for all elements, which can be added to the child which is defined with the name of it's parent and the name of itself. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                      
![Public method] | [Choices][21]                                  | Gets the names of all alternative child nodes, which can be added to a parent node with the given name. The specified child itself is included. Choices only exists, if [IsChoice(String, String)][22] returns true for the defined child name. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                        
![Public method] | [CreateAttribute][23]                          | Creates the attribute with the provided name if this attribute is defined in this schema instance. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                                     
![Public method] | [CreateElement][24]                            | Method overrides the [CreateElement(XName, XName, Boolean)][25]. The created node is made to an AML node. (Inherited from [AMLSchemaManager][3].)                                                                                                                                                                                                                                                                                                                                                                              
![Public method] | [GetAnnotation(XmlSchemaAnnotated)][26]        | Gets the annotation from the annotated schema element. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                                                                                 
![Public method] | [GetAnnotation(XmlSchemaAttribute)][27]        | Gets the annotation from the schema attribute element. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                                                                                 
![Public method] | [GetAnnotation(XmlSchemaElement)][28]          | Gets the annotation from the schema element. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                                                                                           
![Public method] | [HasChoiceOfElements][29]                      | Determines, whether the schema element representing the parent - child relation has a content, which is restricted to a choice of elements. If onlyOne is set to true, there can not be more than one element added to the element (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                     
![Public method] | [HasSequenceOfSimpleElements][30]              | Determines, if the schema defines a sequence of simple elements for the provided parent child combination. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                             
![Public method] | [Insert][31]                                   | Inserts an existing child node into the collection of child nodes of the specified parent node. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                                        
![Public method] | [InsertNew][32]                                | Creates a new node with the defined child name and inserts the newly created child into the child nodes collection of the specified parent. Optional, it can be specified, if the new node should get all attributes, which are defined in the schema, or only those attributes which are required (default behaviour). The Method can be overridden by specific schema managers, to add additional properties to the created node, which can not be derived directly from the schema. (Inherited from [XmlSchemaManager][2].) 
![Public method] | [IsChoice][22]                                 | Determines, whether the occurrence of a child with that name under a parent with that name is part of a choice (means that there are other exclusive alternatives for child nodes). If not, the child is defined in a sequence. For choices, the names of alternatives are available with [Choices(XName, XName)][21]. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                 
![Public method] | [IsChoiceForOneElement][33]                    | Determines if the schema defines a choice of only one element for the provided schema element. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                                         
![Public method] | [IsDefinedAttribute][34]                       | Determines, if the Attribute with the provided is defined for this element (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                                                             
![Public method] | [IsParent][35]                                 | Determines, if the parent is allowed to contain a child with the provided name according to this schema instance. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                      
![Public method] | [IsRequiredAttribute][36]                      | Determines, if the Attribute with the provided name is a required attribute when added to the parent child combination. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                
![Public method] | [MaxOccurence][37]                             | Returned the maximal occurrence for child nodes with the specified name under a parent node with the specified name. For unbounded occurrences, the returned value is [MaxValue][38]. If the occurrence is `0`, the existence of a child with that name under a parent with that name is not allowed. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                  
![Public method] | [MinOccurence][39]                             | The minimal occurrence for child node with the defined name under a parent node with the defined name. If 0 is returned, the existence of a child node with that node is optional. If 1 is returned, the existence is mandatory. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                       
![Public method] | [SchemaElement][40]                            | Gets the schema information for the provided parent child combination. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                                                                 
![Public method] | [SetSchemaVersion][41]                         | Sets the schema version. (Overrides [AMLSchemaManager.SetSchemaVersion(XElement)][42].)                                                                                                                                                                                                                                                                                                                                                                                                                                        
![Public method] | [SiblingBefore][43]                            | This method is a utility method for insert operations. The method will return the node which should be used as the sibling before a newly added child with the defined name. The Insertion has to be done after the returned node or prepended to the parent itself, if no node `null` is returned. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                    
![Public method] | [Validate][44]                                 | Validates a document if it is conform to this schema instance. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                                                                         
![Public method] | [ValueType][45]                                | Returns the type code for a value that may be associated with the defined child. (Inherited from [XmlSchemaManager][2].)                                                                                                                                                                                                                                                                                                                                                                                                       


See Also
--------

#### Reference
[Aml.Engine.Schema Namespace][4]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../XmlSchemaManager/README.md
[3]: ../AMLSchemaManager/README.md
[4]: ../README.md
[5]: Instance.md
[6]: ../XmlSchemaManager/Namespace.md
[7]: SchemaLocation.md
[8]: ../XmlSchemaManager/SchemaLocation.md
[9]: ../XmlSchemaManager/SchemaSet.md
[10]: ../XmlSchemaManager/AcceptsAny.md
[11]: ../XmlSchemaManager/AddNew.md
[12]: ../XmlSchemaManager/AddNewAfterSelf.md
[13]: ../XmlSchemaManager/AttributeNames.md
[14]: ../XmlSchemaManager/Attributes.md
[15]: ../XmlSchemaManager/AttributeValueRestrictions.md
[16]: ../XmlSchemaManager/AttributeValueType_1.md
[17]: ../XmlSchemaManager/AttributeValueType.md
[18]: ../XmlSchemaManager/CanAddNew.md
[19]: ../XmlSchemaManager/ChildElementNames.md
[20]: ../XmlSchemaManager/ChildElements.md
[21]: ../XmlSchemaManager/Choices.md
[22]: ../XmlSchemaManager/IsChoice.md
[23]: ../XmlSchemaManager/CreateAttribute.md
[24]: ../AMLSchemaManager/CreateElement.md
[25]: ../XmlSchemaManager/CreateElement.md
[26]: ../XmlSchemaManager/GetAnnotation.md
[27]: ../XmlSchemaManager/GetAnnotation_1.md
[28]: ../XmlSchemaManager/GetAnnotation_2.md
[29]: ../XmlSchemaManager/HasChoiceOfElements.md
[30]: ../XmlSchemaManager/HasSequenceOfSimpleElements.md
[31]: ../XmlSchemaManager/Insert.md
[32]: ../XmlSchemaManager/InsertNew.md
[33]: ../XmlSchemaManager/IsChoiceForOneElement.md
[34]: ../XmlSchemaManager/IsDefinedAttribute.md
[35]: ../XmlSchemaManager/IsParent.md
[36]: ../XmlSchemaManager/IsRequiredAttribute.md
[37]: ../XmlSchemaManager/MaxOccurence.md
[38]: https://docs.microsoft.com/dotnet/api/system.decimal.maxvalue
[39]: ../XmlSchemaManager/MinOccurence.md
[40]: ../XmlSchemaManager/SchemaElement.md
[41]: SetSchemaVersion.md
[42]: ../AMLSchemaManager/SetSchemaVersion.md
[43]: ../XmlSchemaManager/SiblingBefore.md
[44]: ../XmlSchemaManager/Validate.md
[45]: ../XmlSchemaManager/ValueType.md
[46]: https://www.automationml.org
[47]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Static member]: ../../icons/static.gif "Static member"
[Public method]: ../../icons/pubmethod.gif "Public method"