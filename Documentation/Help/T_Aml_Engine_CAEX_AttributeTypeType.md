# AttributeTypeType Class
AutomationML 2.1 API 

This Class is the generic base class for 'Attribute' and 'AttributeType' elements and defines base structures for Attribute- and AttributeType definitions.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;<a href="T_Aml_Engine_CAEX_CAEXWrapper">Aml.Engine.CAEX.CAEXWrapper</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Aml_Engine_CAEX_CAEXObject">Aml.Engine.CAEX.CAEXObject</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Aml.Engine.CAEX.AttributeTypeType<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Aml_Engine_CAEX_AttributeFamilyType">Aml.Engine.CAEX.AttributeFamilyType</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Aml_Engine_CAEX_AttributeType">Aml.Engine.CAEX.AttributeType</a><br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class AttributeTypeType : CAEXObject, 
	IAttributeValueType, ICAEXWrapper, IXMLWrapper, IMultipleOccurrences<AttributeTypeType>, 
	ICAEXBasicObject, IObjectWithAttributes
```

**VB**<br />
``` VB
Public Class AttributeTypeType
	Inherits CAEXObject
	Implements IAttributeValueType, ICAEXWrapper, IXMLWrapper, IMultipleOccurrences(Of AttributeTypeType), 
	ICAEXBasicObject, IObjectWithAttributes
```

**C++**<br />
``` C++
public ref class AttributeTypeType : public CAEXObject, 
	IAttributeValueType, ICAEXWrapper, IXMLWrapper, IMultipleOccurrences<AttributeTypeType^>, 
	ICAEXBasicObject, IObjectWithAttributes
```

The AttributeTypeType type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType__ctor">AttributeTypeType</a></td><td>
Initializes a new instance of the AttributeTypeType class.</td></tr></table>&nbsp;
<a href="#attributetypetype-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_AdditionalInformation">AdditionalInformation</a></td><td>
Gets the collection of AdditionalInformation values contained in this instance.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_Attribute">Attribute</a></td><td>
Gets a collection of Attributes contained in this instance.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_AttributeAndDescendants">AttributeAndDescendants</a></td><td>
Gets the attributes and all nested attributes.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_AttributeDataType">AttributeDataType</a></td><td>
Gets and sets the AttributeDataType attribute of this Attribute object. If the referenced attribute type does not base on an XML standard base type, the AttributeDataType may remain empty or not present.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_AttributeTypeDefiningAttribute">AttributeTypeDefiningAttribute</a></td><td>
Gets the Attribute datatype which is valid for values of all <a href="P_Aml_Engine_CAEX_AttributeTypeType_ValueAttributes">ValueAttributes</a> of this element. For this class, it is the instance itself.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_AttributeValue">AttributeValue</a></td><td>
Gets and set the encoded/decoded attribute value according to the defined AttributeDataType.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_CAEXDocument">CAEXDocument</a></td><td>
Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_CAEXParent">CAEXParent</a></td><td>
Gets the CAEXParent of this instance if it exists.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_CAEXSequenceOfCAEXObject">CAEXSequenceOfCAEXObject</a></td><td>
Gets the CAEXSequence containing this CAEX object
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_ChangeMode">ChangeMode</a></td><td>
Gets and sets the change mode for a CAEX element (Optional in CAEX).
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_Constraint">Constraint</a></td><td>
Gets the collection of AttributeValueRequirement objects contained in this instance.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_Copyright">Copyright</a></td><td>
Gets and sets the Copyright for this object.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_CopyrightElement">CopyrightElement</a></td><td>
Gets the wrapper for the Copyright element.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_DefaultAttributeValue">DefaultAttributeValue</a></td><td>
Gets and set the encoded/decoded default attribute value according to the defined AttributeDataType.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_DefaultValue">DefaultValue</a></td><td>
Gets and sets the DefaultValue element of this Attribute object. Use the property <a href="P_Aml_Engine_CAEX_AttributeTypeType_DefaultAttributeValue">DefaultAttributeValue</a>, to get or set the type encoded default value according to the Attribute Data Type.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_Description">Description</a></td><td>
Gets and sets the Description for this object.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_DescriptionElement">DescriptionElement</a></td><td>
Gets the wrapper for the Description element.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_Document">Document</a></td><td>
Gets the XDocument of the wrapped XML-Element
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_Exists">Exists</a></td><td>
Determines if this is a wrapper around an existing XML-Element
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXObject_ID">ID</a></td><td>
Gets and sets a unique identifier of the CAEX object (optional in CAEX). AutomationML requires IDs for some Elements. These IDs are automatically set when such elements are created.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_Item">Item</a></td><td>
Gets the type-decoded value and sets the type-encoded value for the value attribute with the defined name. The allowed Names as <a href="F_Aml_Engine_CAEX_CAEX_CLASSModel_TagNames_ATTRIBUTE_VALUE_STRING">ATTRIBUTE_VALUE_STRING</a> and <a href="F_Aml_Engine_CAEX_CAEX_CLASSModel_TagNames_ATTRIBUTE_DEFAULTVALUE_STRING">ATTRIBUTE_DEFAULTVALUE_STRING</a>.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXObject_Name">Name</a></td><td>
Gets and sets the name of the CAEX object (required in CAEX).
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_Node">Node</a></td><td>
Gets the wrapped XML-Element
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_Owner">Owner</a></td><td>
Gets the wrapped Xml-Element's parent
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_RefAttributeType">RefAttributeType</a></td><td>
Gets and sets the RefAttributeType CAEX attribute of the Attribute object. This property is used to create instance to class relations between Attributes (instances) and AttributeType objects (classes).</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_RefSemantic">RefSemantic</a></td><td>
Gets the collection of RefSemantic objects contained in this instance</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_Revision">Revision</a></td><td>
Gets the collection of Revision objects contained in this instance.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_SourceObjectInformation">SourceObjectInformation</a></td><td>
Gets the collection of SourceObjectInformation objects contained in this instance.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_TagName">TagName</a></td><td>
Gets the name of the CAEX tag for this CAEX object.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_Unit">Unit</a></td><td>
Gets and sets the Unit attribute for this Attribute object.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_Value">Value</a></td><td>
Gets and sets the Value for this Attribute object. The correct XML-String representation for the defined <a href="P_Aml_Engine_CAEX_AttributeTypeType_AttributeDataType">AttributeDataType</a> has to be ensured by the caller.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_ValueAttributes">ValueAttributes</a></td><td>
Gets all the CAEXValue objects for the defined value attributes of this instance. Recognized value attributes are <a href="F_Aml_Engine_CAEX_CAEX_CLASSModel_TagNames_ATTRIBUTE_DEFAULTVALUE_STRING">ATTRIBUTE_DEFAULTVALUE_STRING</a> and <a href="F_Aml_Engine_CAEX_CAEX_CLASSModel_TagNames_ATTRIBUTE_VALUE_STRING">ATTRIBUTE_VALUE_STRING</a>.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_Version">Version</a></td><td>
Gets and sets the Version for this object.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_VersionElement">VersionElement</a></td><td>
Gets the wrapper for the Version element.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_XsdDataTypes">XsdDataTypes</a></td><td>
The XSD data types which are supported.</td></tr></table>&nbsp;
<a href="#attributetypetype-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXObject_AssignNewGuidAsID">AssignNewGuidAsID</a></td><td>
Assigns the new unique identifier as a new ID to this CAEX object.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_CAEXChild">CAEXChild</a></td><td>
Gets the first child of this CAEX object with the defined CAEX tag name.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_CAEXChildren">CAEXChildren</a></td><td>
Gets all children of this CAEX object with the defined CAEX tag name.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXObject_CAEXPath">CAEXPath</a></td><td>
Gets the CAEX path for this object. A path can be used to uniquely reference an object, for example in inheritances and instances. The path syntax for an object is defined differently in CAEX 2.15 and CAEX 3.0. The engine uses the <a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder</a> to generate the CAEX path of an object according to the documents CAEX version.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_CAEXSequence">CAEXSequence</a></td><td>
Gets the CAEXSequence owned by this CAEX object, which contains the specified CAEX object.
 (Overrides <a href="M_Aml_Engine_CAEX_CAEXBasicObject_CAEXSequence">CAEXBasicObject.CAEXSequence(ICAEXWrapper)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_ClrToXmlType">ClrToXmlType</a></td><td>
Gets the xmlType type for the specified CLR type. The Mapping is done according to <a href="https://msdn.microsoft.com/en-us/library/xa669bew(v=vs.110).aspx" target="_blank" rel="noopener noreferrer">Mapping XML Data Types to CLR Types.</a> This reverse mapping is not unambiguous. If more than one mapping is possible, the most common used description is generated. If No mapping is defined the 'xs:string' is used.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_Container__1">Container(T)</a></td><td>
Gets the CAEX Container for elements of type T, which is owned by this CAEX object
 (Overrides <a href="M_Aml_Engine_CAEX_CAEXBasicObject_Container__1">CAEXBasicObject.Container(T)()</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXObject_Copy">Copy</a></td><td>
Creates a deep copy of this CAEX object, containing all child elements. The created copy will have replaced unique IDs and updated references, if the *assignNewIDs* is set to true (default). When a CAEX class is copied, the nested classes that can exist for AttributeType, RoleClass, SystemUnitClass, and InterfaceClass are not included in the created copy.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_Equals">Equals</a></td><td>
Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_GetCaexValue">GetCaexValue</a></td><td>
Gets the <a href="T_Aml_Engine_CAEX_Extensions_CaexValue">CaexValue</a> for the value attribute with the defined attribute name. The allowed Names as <a href="F_Aml_Engine_CAEX_CAEX_CLASSModel_TagNames_ATTRIBUTE_VALUE_STRING">ATTRIBUTE_VALUE_STRING</a> and <a href="F_Aml_Engine_CAEX_CAEX_CLASSModel_TagNames_ATTRIBUTE_DEFAULTVALUE_STRING">ATTRIBUTE_DEFAULTVALUE_STRING</a>.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_GetDateTime">GetDateTime</a></td><td>
Parse the Attribute Value string as dateTime. If the string can not be parsed, a format exception is returned. This method uses the XmlConvert <a href="https://docs.microsoft.com/dotnet/api/system.xml.xmlconvert.todatetime#System_Xml_XmlConvert_ToDateTime_System_String_System_Xml_XmlDateTimeSerializationMode_" target="_parent" rel="noopener noreferrer">ToDateTime(String, XmlDateTimeSerializationMode)</a> method.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_GetDouble">GetDouble</a></td><td>
Parse the Attribute Value string as double. If the string can not be parsed, a format exception is returned. This method uses the XmlConvert <a href="https://docs.microsoft.com/dotnet/api/system.xml.xmlconvert.todouble#System_Xml_XmlConvert_ToDouble_System_String_" target="_parent" rel="noopener noreferrer">ToDouble(String)</a> method and a fall back conversion, if the first conversion fails.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_GetHashCode">GetHashCode</a></td><td>
Gets the Hash code for this instance, using the wrapped XML element.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_GetXAttributeValue">GetXAttributeValue</a></td><td>
Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_Insert_1">Insert(Int32, CAEXWrapper)</a></td><td>
Inserts the specified CAEX object in it's associated sequence at the defined position. The AttributeType defines additional sequences for <a href="P_Aml_Engine_CAEX_AttributeTypeType_Attribute">Attribute</a>, <a href="P_Aml_Engine_CAEX_AttributeTypeType_Constraint">Constraint</a> and <a href="P_Aml_Engine_CAEX_AttributeTypeType_RefSemantic">RefSemantic</a>.
 (Overrides <a href="M_Aml_Engine_CAEX_CAEXBasicObject_Insert_1">CAEXBasicObject.Insert(Int32, CAEXWrapper)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_Insert">Insert(CAEXWrapper, Boolean)</a></td><td>
Inserts the specified CAEX object in it's associated sequence. The AttributeType defines additional sequences for <a href="P_Aml_Engine_CAEX_AttributeTypeType_Attribute">Attribute</a>, <a href="P_Aml_Engine_CAEX_AttributeTypeType_Constraint">Constraint</a> and <a href="P_Aml_Engine_CAEX_AttributeTypeType_RefSemantic">RefSemantic</a>.
 (Overrides <a href="M_Aml_Engine_CAEX_CAEXBasicObject_Insert">CAEXBasicObject.Insert(CAEXWrapper, Boolean)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_InsertAfter">InsertAfter</a></td><td>
Inserts the provided CAEX object as a new sibling after this CAEX object.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_InsertBefore">InsertBefore</a></td><td>
Inserts the provided CAEX object as a new sibling before this CAEX object.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_InsertNew">InsertNew</a></td><td>
This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an <a href="P_Aml_Engine_CAEX_CAEXWrapper_Owner">Owner</a> is defined. The new created CAEX object is inserted as a new child of the owner.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXBasicObject_New_Revision">New_Revision</a></td><td>
Creates a new Revision object and inserts it to the collection of Revision objects <a href="P_Aml_Engine_CAEX_CAEXBasicObject_Revision">Revision</a> either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_Remove">Remove</a></td><td>
Removes this element. After that it is no longer assigned to a document and has no owner anymore.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_SetDateTime">SetDateTime</a></td><td>
Sets the specified dateTime value as the attribute value. The AttributeDataType is set to xs:dateTime</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_SetDouble">SetDouble</a></td><td>
Sets the specified double value as the attribute value. The AttributeDataType is set to xs:double</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_SetXAttributeValue">SetXAttributeValue</a></td><td>
Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null).
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXObject_ToString">ToString</a></td><td>
Returns the value of the 'Name' attribute of this CAEX object as the string representation of the object.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_TryGetDateTime">TryGetDateTime</a></td><td>
Tries to parse the Attribute Value string as dateTime. This method uses the XmlConvert <a href="https://docs.microsoft.com/dotnet/api/system.xml.xmlconvert.todatetime#System_Xml_XmlConvert_ToDateTime_System_String_System_Xml_XmlDateTimeSerializationMode_" target="_parent" rel="noopener noreferrer">ToDateTime(String, XmlDateTimeSerializationMode)</a> method.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_TryGetDouble">TryGetDouble</a></td><td>
Tries to parse the Attribute Value string as double. This method uses the XmlConvert <a href="https://docs.microsoft.com/dotnet/api/system.xml.xmlconvert.todouble#System_Xml_XmlConvert_ToDouble_System_String_" target="_parent" rel="noopener noreferrer">ToDouble(String)</a> method and a fall back conversion, if the first conversion fails.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_XmlTypeToClrType">XmlTypeToClrType</a></td><td>
Gets the CLR type for the specified xmlType. The Mapping is done according to <a href="https://msdn.microsoft.com/en-us/library/xa669bew(v=vs.110).aspx" target="_blank" rel="noopener noreferrer">Mapping XML Data Types to CLR Types.</a></td></tr></table>&nbsp;
<a href="#attributetypetype-class">Back to Top</a>

## Events
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Aml_Engine_CAEX_CAEXWrapper_PropertyChanged">PropertyChanged</a></td><td>
The Change event raised when any property is modified.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr></table>&nbsp;
<a href="#attributetypetype-class">Back to Top</a>

## Operators
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public operator](media/puboperator.gif "Public operator")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_op_Implicit">Implicit(AttributeTypeType to ObjectWithAMLAttributes)</a></td><td>
Conversion to get access to specific AutomationML defined Attributes</td></tr></table>&nbsp;
<a href="#attributetypetype-class">Back to Top</a>

## Extension Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_AddAttributeTypeReference_1">AddAttributeTypeReference(String, Boolean, Boolean, String)</a></td><td>Overloaded.  
Adds an AttributeType reference to this ObjectWithAttribute using the provided CAEX path, referencing an AttributeType object. The AttributeType reference is added as a <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a> object.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithAttributes">ObjectWithAttributes</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_AddAttributeTypeReference">AddAttributeTypeReference(AttributeFamilyType, Boolean, Boolean, String)</a></td><td>Overloaded.  
Adds an AttributeType reference to this ObjectWithAttribute using the provided AttributeType object. The AttributeType reference is added as a <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a> object.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithAttributes">ObjectWithAttributes</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_AMLAttributes">AMLAttributes</a></td><td>
Conversion of any object which has an attribute collection to get access to specific AutomationML defined attributes.
 (Defined by <a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_AMLSchemaManager">AMLSchemaManager</a></td><td>
Gets the associated CAEX schema manager of the CAEX object.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_Ancestors__1">Ancestors(T)</a></td><td>
Finds the ancestors of the provided CAEX object which have the given type.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_Attributes">Attributes</a></td><td>
Enumeration Method for direct Children of Type <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_CAEXDocument">CAEXDocument</a></td><td>
Gets the CAEX document which contains this CAEX object.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_CAEXFile">CAEXFile</a></td><td>
Gets the CAEX file which contains this CAEX object.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_CAEXSchema">CAEXSchema</a></td><td>
Gets the associated CAEX schema of the CAEX object.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_clone">clone</a></td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_Copy">Copy(Boolean, Boolean, Boolean)</a>
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_CloneNode">CloneNode</a></td><td>
Clones the node.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_ConsistencyCheck_ClassReference">ConsistencyCheck_ClassReference</a></td><td>
Check if the given classPath is a valid path to an existent class in the AML file.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_CopyAttributesFrom">CopyAttributesFrom</a></td><td>
Copies all attribute of the source object with attributes to the target object including children
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithAttributes">ObjectWithAttributes</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_ListAttribute_CreateListAttribute">CreateListAttribute</a></td><td>
Creates a new list attribute for an element which can have attributes.
 (Defined by <a href="T_Aml_Engine_AmlObjects_ListAttribute">ListAttribute</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_Descendants">Descendants(Type)</a></td><td>Overloaded.  
Finds the descendants of the provided CAEX object which are of the given type.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_Descendants__1">Descendants(T)()</a></td><td>Overloaded.  
Finds the descendants of the provided CAEX object which are of the given type.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_Descendants__1_1">Descendants(T)(Boolean)</a></td><td>Overloaded.  
Finds the descendants of the provided CAEX object which are of the given type.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_FindCaexObjectFromId__1">FindCaexObjectFromId(T)</a></td><td>
Finds the CAEX object with the specified id and the specified Type.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_findInternalElement">findInternalElement</a></td><td>
Resolve a reference to an InternalElement and return the referenced element if found.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_FindReferencedClass__1">FindReferencedClass(T)</a></td><td>
Finds the CAEX object with the specified CAEX path and the specified Type.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_FirstAncestor_1">FirstAncestor(String)</a></td><td>Overloaded.  
Finds the first ancestor of the specified CAEX object with the given Tag name
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_FirstAncestor">FirstAncestor(Predicate(ICAEXWrapper))</a></td><td>Overloaded.  
Finds the first ancestor of the specified CAEX object which fulfils the specified predicate
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_FirstAncestor__1">FirstAncestor(T)()</a></td><td>Overloaded.  
Finds the first ancestor of the specified CAEX object in the given Type.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_FrameAttribute">FrameAttribute</a></td><td>
Gets a defined FrameAttribute from the <a href="P_Aml_Engine_CAEX_IObjectWithAttributes_Attribute">Attribute</a> collection of the <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">IObjectWithAttributes</a>. If no such attribute exists, `null` is returned.
 (Defined by <a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_GetAttribute">GetAttribute</a></td><td>
Gets the first attribute with the specified name from the attribute collection of the CAEX object.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithAttributes">ObjectWithAttributes</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_getAttributeField">getAttributeField</a></td><td>
Get the whole attribute field containing a collection of all attributes of this object.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_GetAttributeValue">GetAttributeValue</a></td><td>
Returns an attribute value of a given attribute name.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_GetParent__1">GetParent(T)</a></td><td>
Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_getReferencedClass">getReferencedClass</a></td><td>
Getting the XML Node for a class path.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_getReferencedGUID">getReferencedGUID</a></td><td>
Parsing a string of form GUID:Interface and returning the GUID
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_getReferencedInterfaceClass">getReferencedInterfaceClass</a></td><td>
Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_getReferencedInterfaceName">getReferencedInterfaceName</a></td><td>
Getting the name of the referenced Interface.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions_Insert_Attribute">Insert_Attribute</a></td><td>
Inserts an Attribute object in the Attribute collection of the *objectWithAttributes*.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions">SystemUnitClassTypeExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_Insert_Element">Insert_Element</a></td><td>
Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_Insert_NewInstance">Insert_NewInstance</a></td><td>
Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_Insert_TypeBaseElement">Insert_TypeBaseElement</a></td><td><a href="M_Aml_Engine_CAEX_CAEXBasicObject_Insert">Insert(CAEXWrapper, Boolean)</a>
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_IsAMLObject">IsAMLObject</a></td><td>
Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface.
 (Defined by <a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib_IsAssociatedExternalValue">IsAssociatedExternalValue</a></td><td> (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib">AutomationMLBaseAttributeTypeLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib_IsAssociatedFacet">IsAssociatedFacet</a></td><td>
Determines whether the specified attribute reference defines an inheritance relation from the AssociatedFacet AttributeType
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib">AutomationMLBaseAttributeTypeLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib_IsAssociatedValue">IsAssociatedValue</a></td><td>
Determines whether the specified attribute reference defines an inheritance relation from the AssociatedValue AttributeType
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib">AutomationMLBaseAttributeTypeLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib_IsCardinality">IsCardinality</a></td><td>
Determines whether the specified attribute reference defines an inheritance relation from the Cardinality AttributeType
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib">AutomationMLBaseAttributeTypeLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib_IsCategory">IsCategory</a></td><td>
Determines whether the specified attribute reference defines an inheritance relation from the Category AttributeType
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib">AutomationMLBaseAttributeTypeLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_InheritanceExtensions_IsDerivedFromAttributeType">IsDerivedFromAttributeType</a></td><td>
Determines whether the specified attribute defines an inheritance relation from the attribute, uniquely identifiable by the given attribute type path. The attribute type path may contain an alias.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_InheritanceExtensions">InheritanceExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib_IsDirection">IsDirection</a></td><td>
Determines whether the specified attribute reference defines an inheritance relation from the Direction AttributeType
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib">AutomationMLBaseAttributeTypeLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib_IsDocLang">IsDocLang</a></td><td>
Determines whether the specified attribute reference defines an inheritance relation from the DocLang AttributeType
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib">AutomationMLBaseAttributeTypeLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib_IsFrame">IsFrame</a></td><td>
Determines whether the specified attribute reference defines an inheritance relation from the Frame AttributeType
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib">AutomationMLBaseAttributeTypeLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib_IsListType">IsListType</a></td><td>
Determines whether the specified attribute reference defines an inheritance relation from the ListType AttributeType
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib">AutomationMLBaseAttributeTypeLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib_IsLocalizedAttribute">IsLocalizedAttribute</a></td><td>
Determines whether the specified attribute reference defines an inheritance relation from the LocalizedAttribute AttributeType
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib">AutomationMLBaseAttributeTypeLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib_IsMIMEType">IsMIMEType</a></td><td>
Determines whether the specified attribute reference defines an inheritance relation from the MIMEType AttributeType
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib">AutomationMLBaseAttributeTypeLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib_IsOrderedListType">IsOrderedListType</a></td><td>
Determines whether the specified attribute reference defines an inheritance relation from the OrderedListType AttributeType
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib">AutomationMLBaseAttributeTypeLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib_IsRefUri">IsRefUri</a></td><td>
Determines whether the specified attribute reference defines an inheritance relation from the RefURI AttributeType
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib">AutomationMLBaseAttributeTypeLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_Library">Library</a></td><td>
Gets the Library which contains this CAEX object.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_Name">Name()</a></td><td>Overloaded.  
Get the Name of the specified object.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_Name">Name()</a></td><td>Overloaded.  
Gets a names for the specified caex wrapper object. If the specified object is a <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>, the Name is returned; otherwise the TagName of the CAEX item.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_New_Attribute">New_Attribute</a></td><td>
Appends a new Attribute object with the defined name to the specified CAEX object.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithAttributes">ObjectWithAttributes</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_New_Copyright">New_Copyright</a></td><td>
Adds an new Copyright node to this object if it doesn't exists.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_New_Description">New_Description</a></td><td>
Adds an new Description node to this object if it doesn't exists.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_New_FrameAttribute">New_FrameAttribute</a></td><td>
Creates a new Frame attribute for the <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">IObjectWithAttributes</a> if no Frame attribute exists. The provided values are used to initialize the Frame attribute values.
 (Defined by <a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_AttributeTypeTypeExtensions_New_RefSemantic">New_RefSemantic</a></td><td>
Appends a new RefSemantic object with the defined semantics to the specified CAEX object.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_AttributeTypeTypeExtensions">AttributeTypeTypeExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_New_Version">New_Version</a></td><td>
Adds an new Version node to this object if it doesn't exists.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_RefTypeAttribute">RefTypeAttribute</a></td><td>
Gets the RefTypeAttribute from the *objectWithAttributes* if one exists.
 (Defined by <a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_RefURIAttribute">RefURIAttribute</a></td><td>
Gets the RefURIAttribute from the *objectWithAttributes* if one exists.
 (Defined by <a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_SetAttributeValue_2">SetAttributeValue(String, String)</a></td><td>Overloaded.  
Sets the value for the attribute with the specified name from the attribute collection of the CAEX object. If no attribute with that name exists, it is created.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithAttributes">ObjectWithAttributes</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_SetAttributeValue">SetAttributeValue(String, Double)</a></td><td>Overloaded.  
Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created. Sets the AttributeDataType to xs:double
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithAttributes">ObjectWithAttributes</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_SetAttributeValue_3">SetAttributeValue(String, String, String, String)</a></td><td>Overloaded.  
Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithAttributes">ObjectWithAttributes</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_SetAttributeValue_1">SetAttributeValue(String, Double, Double, String, String)</a></td><td>Overloaded.  
Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created. Sets the AttributeDataType to xs:double
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithAttributes">ObjectWithAttributes</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_SetAttributeValue_4">SetAttributeValue(String, String, String, String, String, String)</a></td><td>Overloaded.  
Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithAttributes">ObjectWithAttributes</a>.)</td></tr></table>&nbsp;
<a href="#attributetypetype-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br /><a href="T_Aml_Engine_CAEX_CAEXObject">Aml.Engine.CAEX.CAEXObject</a><br /><a href="T_Aml_Engine_CAEX_IMultipleOccurrences_1">Aml.Engine.CAEX.IMultipleOccurrences(T)</a><br /><a href="T_Aml_Engine_CAEX_IObjectWithAttributes">Aml.Engine.CAEX.IObjectWithAttributes</a><br /><a href="T_Aml_Engine_CAEX_IAttributeValueType">Aml.Engine.CAEX.IAttributeValueType</a><br />