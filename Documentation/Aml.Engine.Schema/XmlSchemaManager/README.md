XmlSchemaManager Class
======================
Class supports the creation of schema conform xml documents for a given schema. It can be used to create elements with all required attributes and child elements and default values associated. Insertion of new child elements for a given parent at a schema is supported, guaranteeing schema conform sequences and occurrences of all children.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.Schema.XmlSchemaManager**  
    [Aml.Engine.Schema.AMLSchemaManager][2]  

  **Namespace:**  [Aml.Engine.Schema][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public abstract class XmlSchemaManager
```

The **XmlSchemaManager** type exposes the following members.


Properties
----------

                   | Name                | Description                    
------------------ | ------------------- | ------------------------------ 
![Public property] | [Namespace][4]      | Gets the Schema Namespace      
![Public property] | [SchemaLocation][5] | Gets the SchemaLocation string 
![Public property] | [SchemaSet][6]      | Gets the actual XSD schema set 


Methods
-------

                 | Name                                           | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
---------------- | ---------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [AcceptsAny][7]                                | Determines if the schema element accepts values of any type.                                                                                                                                                                                                                                                                                                                                                                                                                           
![Public method] | [AddNew][8]                                    | Creates a new Xml-Element with the provided content and inserts it to the provided parent according to this schema instance.                                                                                                                                                                                                                                                                                                                                                           
![Public method] | [AddNewAfterSelf][9]                           | Creates a new Xml-Element with the provided content and inserts it behind the provided sibling according to this schema instance.                                                                                                                                                                                                                                                                                                                                                      
![Public method] | [AttributeNames][10]                           | Gets the Attribute names of the specified child element of the specified parent element.                                                                                                                                                                                                                                                                                                                                                                                               
![Public method] | [Attributes][11]                               | Gets the Schema Elements for all attributes of the specified child element of the specified parent element, if the defined parent child relation exists in the xml schema. If required is set to `true`, only the required attributes are returned. The default behaviour is, that all attributes - optional and required attributes - are returned.                                                                                                                                   
![Public method] | [AttributeValueRestrictions][12]               | Gets the List of Attribute value restrictions for the attribute with the defined name. The Attribute should be an attribute of a child defined by the given name, which exists in the defined parent child relation defined by the parent name.                                                                                                                                                                                                                                        
![Public method] | [AttributeValueType(XmlSchemaAttribute)][13]   | Gets the type code for the schema attribute.                                                                                                                                                                                                                                                                                                                                                                                                                                           
![Public method] | [AttributeValueType(XName, XName, String)][14] | Gets the Attribute value types for the attribute with the defined name of a child element which belongs to the given parent. If `XmlTypeCode.Item` is returned, the value type is equal to the schema internal any type.                                                                                                                                                                                                                                                               
![Public method] | [CanAddNew][15]                                | Determines, if a child with the specified name can be added to the parent node. The method checks the specified minimal and maximal occurrences, defined for this relation in the xml schema.                                                                                                                                                                                                                                                                                          
![Public method] | [ChildElementNames][16]                        | Gets the Names for all elements, which can be added to the child which is defined with the name of it's parent and the name of itself.                                                                                                                                                                                                                                                                                                                                                 
![Public method] | [ChildElements][17]                            | Gets the SchemaDefinition for all elements, which can be added to the child which is defined with the name of it's parent and the name of itself.                                                                                                                                                                                                                                                                                                                                      
![Public method] | [Choices][18]                                  | Gets the names of all alternative child nodes, which can be added to a parent node with the given name. The specified child itself is included. Choices only exists, if [IsChoice(String, String)][19] returns true for the defined child name.                                                                                                                                                                                                                                        
![Public method] | [CreateAttribute][20]                          | Creates the attribute with the provided name if this attribute is defined in this schema instance.                                                                                                                                                                                                                                                                                                                                                                                     
![Public method] | [CreateElement][21]                            | Creates a new node with the specified child name in the given xmlDocument. The node is created with all required attributes and elements but is not inserted in the document tree at this point. Use [Insert(XElement, XElement)][22] for insertion or [InsertNew(XElement, XName, Boolean)][23] for a combined creation and insertion.                                                                                                                                                
![Public method] | [GetAnnotation(XmlSchemaAnnotated)][24]        | Gets the annotation from the annotated schema element.                                                                                                                                                                                                                                                                                                                                                                                                                                 
![Public method] | [GetAnnotation(XmlSchemaAttribute)][25]        | Gets the annotation from the schema attribute element.                                                                                                                                                                                                                                                                                                                                                                                                                                 
![Public method] | [GetAnnotation(XmlSchemaElement)][26]          | Gets the annotation from the schema element.                                                                                                                                                                                                                                                                                                                                                                                                                                           
![Public method] | [HasChoiceOfElements][27]                      | Determines, whether the schema element representing the parent - child relation has a content, which is restricted to a choice of elements. If onlyOne is set to true, there can not be more than one element added to the element                                                                                                                                                                                                                                                     
![Public method] | [HasSequenceOfSimpleElements][28]              | Determines, if the schema defines a sequence of simple elements for the provided parent child combination.                                                                                                                                                                                                                                                                                                                                                                             
![Public method] | [Insert][22]                                   | Inserts an existing child node into the collection of child nodes of the specified parent node.                                                                                                                                                                                                                                                                                                                                                                                        
![Public method] | [InsertNew][23]                                | Creates a new node with the defined child name and inserts the newly created child into the child nodes collection of the specified parent. Optional, it can be specified, if the new node should get all attributes, which are defined in the schema, or only those attributes which are required (default behaviour). The Method can be overridden by specific schema managers, to add additional properties to the created node, which can not be derived directly from the schema. 
![Public method] | [IsChoice][19]                                 | Determines, whether the occurrence of a child with that name under a parent with that name is part of a choice (means that there are other exclusive alternatives for child nodes). If not, the child is defined in a sequence. For choices, the names of alternatives are available with [Choices(XName, XName)][18].                                                                                                                                                                 
![Public method] | [IsChoiceForOneElement][29]                    | Determines if the schema defines a choice of only one element for the provided schema element.                                                                                                                                                                                                                                                                                                                                                                                         
![Public method] | [IsDefinedAttribute][30]                       | Determines, if the Attribute with the provided is defined for this element                                                                                                                                                                                                                                                                                                                                                                                                             
![Public method] | [IsParent][31]                                 | Determines, if the parent is allowed to contain a child with the provided name according to this schema instance.                                                                                                                                                                                                                                                                                                                                                                      
![Public method] | [IsRequiredAttribute][32]                      | Determines, if the Attribute with the provided name is a required attribute when added to the parent child combination.                                                                                                                                                                                                                                                                                                                                                                
![Public method] | [MaxOccurence][33]                             | Returned the maximal occurrence for child nodes with the specified name under a parent node with the specified name. For unbounded occurrences, the returned value is [MaxValue][34]. If the occurrence is `0`, the existence of a child with that name under a parent with that name is not allowed.                                                                                                                                                                                  
![Public method] | [MinOccurence][35]                             | The minimal occurrence for child node with the defined name under a parent node with the defined name. If 0 is returned, the existence of a child node with that node is optional. If 1 is returned, the existence is mandatory.                                                                                                                                                                                                                                                       
![Public method] | [SchemaElement][36]                            | Gets the schema information for the provided parent child combination.                                                                                                                                                                                                                                                                                                                                                                                                                 
![Public method] | [SiblingBefore][37]                            | This method is a utility method for insert operations. The method will return the node which should be used as the sibling before a newly added child with the defined name. The Insertion has to be done after the returned node or prepended to the parent itself, if no node `null` is returned.                                                                                                                                                                                    
![Public method] | [Validate][38]                                 | Validates a document if it is conform to this schema instance.                                                                                                                                                                                                                                                                                                                                                                                                                         
![Public method] | [ValueType][39]                                | Returns the type code for a value that may be associated with the defined child.                                                                                                                                                                                                                                                                                                                                                                                                       


See Also
--------

#### Reference
[Aml.Engine.Schema Namespace][3]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../AMLSchemaManager/README.md
[3]: ../README.md
[4]: Namespace.md
[5]: SchemaLocation.md
[6]: SchemaSet.md
[7]: AcceptsAny.md
[8]: AddNew.md
[9]: AddNewAfterSelf.md
[10]: AttributeNames.md
[11]: Attributes.md
[12]: AttributeValueRestrictions.md
[13]: AttributeValueType_1.md
[14]: AttributeValueType.md
[15]: CanAddNew.md
[16]: ChildElementNames.md
[17]: ChildElements.md
[18]: Choices.md
[19]: IsChoice.md
[20]: CreateAttribute.md
[21]: CreateElement.md
[22]: Insert.md
[23]: InsertNew.md
[24]: GetAnnotation.md
[25]: GetAnnotation_1.md
[26]: GetAnnotation_2.md
[27]: HasChoiceOfElements.md
[28]: HasSequenceOfSimpleElements.md
[29]: IsChoiceForOneElement.md
[30]: IsDefinedAttribute.md
[31]: IsParent.md
[32]: IsRequiredAttribute.md
[33]: MaxOccurence.md
[34]: https://docs.microsoft.com/dotnet/api/system.decimal.maxvalue
[35]: MinOccurence.md
[36]: SchemaElement.md
[37]: SiblingBefore.md
[38]: Validate.md
[39]: ValueType.md
[40]: https://www.automationml.org
[41]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"