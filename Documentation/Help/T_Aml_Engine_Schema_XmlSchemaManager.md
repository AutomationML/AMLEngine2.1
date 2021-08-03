# XmlSchemaManager Class
AutomationML 2.1 API 

Class supports the creation of schema conform xml documents for a given schema. It can be used to create elements with all required attributes and child elements and default values associated. Insertion of new child elements for a given parent at a schema is supported, guaranteeing schema conform sequences and occurrences of all children.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.Schema.XmlSchemaManager<br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Aml_Engine_Schema_AMLSchemaManager">Aml.Engine.Schema.AMLSchemaManager</a><br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_Schema">Aml.Engine.Schema</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public abstract class XmlSchemaManager
```

**VB**<br />
``` VB
Public MustInherit Class XmlSchemaManager
```

**C++**<br />
``` C++
public ref class XmlSchemaManager abstract
```

The XmlSchemaManager type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Schema_XmlSchemaManager_Namespace">Namespace</a></td><td>
Gets the Schema Namespace</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Schema_XmlSchemaManager_SchemaLocation">SchemaLocation</a></td><td>
Gets the SchemaLocation string</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Schema_XmlSchemaManager_SchemaSet">SchemaSet</a></td><td>
Gets the actual XSD schema set</td></tr></table>&nbsp;
<a href="#xmlschemamanager-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_AcceptsAny">AcceptsAny</a></td><td>
Determines if the schema element accepts values of any type.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_AddNew">AddNew</a></td><td>
Creates a new Xml-Element with the provided content and inserts it to the provided parent according to this schema instance.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_AddNewAfterSelf">AddNewAfterSelf</a></td><td>
Creates a new Xml-Element with the provided content and inserts it behind the provided sibling according to this schema instance.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_AttributeNames">AttributeNames</a></td><td>
Gets the Attribute names of the specified child element of the specified parent element.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_Attributes">Attributes</a></td><td>
Gets the Schema Elements for all attributes of the specified child element of the specified parent element, if the defined parent child relation exists in the xml schema. If required is set to `true`, only the required attributes are returned. The default behaviour is, that all attributes - optional and required attributes - are returned.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_AttributeValueRestrictions">AttributeValueRestrictions</a></td><td>
Gets the List of Attribute value restrictions for the attribute with the defined name. The Attribute should be an attribute of a child defined by the given name, which exists in the defined parent child relation defined by the parent name.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_AttributeValueType_1">AttributeValueType(XmlSchemaAttribute)</a></td><td>
Gets the type code for the schema attribute.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_AttributeValueType">AttributeValueType(XName, XName, String)</a></td><td>
Gets the Attribute value types for the attribute with the defined name of a child element which belongs to the given parent. If `XmlTypeCode.Item` is returned, the value type is equal to the schema internal any type.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_CanAddNew">CanAddNew</a></td><td>
Determines, if a child with the specified name can be added to the parent node. The method checks the specified minimal and maximal occurrences, defined for this relation in the xml schema.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_ChildElementNames">ChildElementNames</a></td><td>
Gets the Names for all elements, which can be added to the child which is defined with the name of it's parent and the name of itself.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_ChildElements">ChildElements</a></td><td>
Gets the SchemaDefinition for all elements, which can be added to the child which is defined with the name of it's parent and the name of itself.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_Choices">Choices</a></td><td>
Gets the names of all alternative child nodes, which can be added to a parent node with the given name. The specified child itself is included. Choices only exists, if <a href="M_Aml_Engine_Schema_XmlSchemaManager_IsChoice">IsChoice(String, String)</a> returns true for the defined child name.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_CreateAttribute">CreateAttribute</a></td><td>
Creates the attribute with the provided name if this attribute is defined in this schema instance.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_CreateElement">CreateElement</a></td><td>
Creates a new node with the specified child name in the given xmlDocument. The node is created with all required attributes and elements but is not inserted in the document tree at this point. Use <a href="M_Aml_Engine_Schema_XmlSchemaManager_Insert">Insert(XElement, XElement)</a> for insertion or <a href="M_Aml_Engine_Schema_XmlSchemaManager_InsertNew">InsertNew(XElement, XName, Boolean)</a> for a combined creation and insertion.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_GetAnnotation">GetAnnotation(XmlSchemaAnnotated)</a></td><td>
Gets the annotation from the annotated schema element.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_GetAnnotation_1">GetAnnotation(XmlSchemaAttribute)</a></td><td>
Gets the annotation from the schema attribute element.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_GetAnnotation_2">GetAnnotation(XmlSchemaElement)</a></td><td>
Gets the annotation from the schema element.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_HasChoiceOfElements">HasChoiceOfElements</a></td><td>
Determines, whether the schema element representing the parent - child relation has a content, which is restricted to a choice of elements. If onlyOne is set to true, there can not be more than one element added to the element</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_HasSequenceOfSimpleElements">HasSequenceOfSimpleElements</a></td><td>
Determines, if the schema defines a sequence of simple elements for the provided parent child combination.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_Insert">Insert</a></td><td>
Inserts an existing child node into the collection of child nodes of the specified parent node.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_InsertNew">InsertNew</a></td><td>
Creates a new node with the defined child name and inserts the newly created child into the child nodes collection of the specified parent. Optional, it can be specified, if the new node should get all attributes, which are defined in the schema, or only those attributes which are required (default behaviour). The Method can be overridden by specific schema managers, to add additional properties to the created node, which can not be derived directly from the schema.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_IsChoice">IsChoice</a></td><td>
Determines, whether the occurrence of a child with that name under a parent with that name is part of a choice (means that there are other exclusive alternatives for child nodes). If not, the child is defined in a sequence. For choices, the names of alternatives are available with <a href="M_Aml_Engine_Schema_XmlSchemaManager_Choices">Choices(XName, XName)</a>.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_IsChoiceForOneElement">IsChoiceForOneElement</a></td><td>
Determines if the schema defines a choice of only one element for the provided schema element.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_IsDefinedAttribute">IsDefinedAttribute</a></td><td>
Determines, if the Attribute with the provided is defined for this element</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_IsParent">IsParent</a></td><td>
Determines, if the parent is allowed to contain a child with the provided name according to this schema instance.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_IsRequiredAttribute">IsRequiredAttribute</a></td><td>
Determines, if the Attribute with the provided name is a required attribute when added to the parent child combination.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_MaxOccurence">MaxOccurence</a></td><td>
Returned the maximal occurrence for child nodes with the specified name under a parent node with the specified name. For unbounded occurrences, the returned value is <a href="https://docs.microsoft.com/dotnet/api/system.decimal.maxvalue" target="_parent" rel="noopener noreferrer">MaxValue</a>. If the occurrence is `0`, the existence of a child with that name under a parent with that name is not allowed.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_MinOccurence">MinOccurence</a></td><td>
The minimal occurrence for child node with the defined name under a parent node with the defined name. If 0 is returned, the existence of a child node with that node is optional. If 1 is returned, the existence is mandatory.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_SchemaElement">SchemaElement</a></td><td>
Gets the schema information for the provided parent child combination.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_SiblingBefore">SiblingBefore</a></td><td>
This method is a utility method for insert operations. The method will return the node which should be used as the sibling before a newly added child with the defined name. The Insertion has to be done after the returned node or prepended to the parent itself, if no node `null` is returned.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_Validate">Validate</a></td><td>
Validates a document if it is conform to this schema instance.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Schema_XmlSchemaManager_ValueType">ValueType</a></td><td>
Returns the type code for a value that may be associated with the defined child.</td></tr></table>&nbsp;
<a href="#xmlschemamanager-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Schema">Aml.Engine.Schema Namespace</a><br />