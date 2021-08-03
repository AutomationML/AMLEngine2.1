# FrameAttributeType Class
AutomationML 2.1 API 

This class is a wrapper for the AutomationML Attribute 'Frame'. To get access to instances of this type, use the <a href="T_Aml_Engine_AmlObjects_ObjectWithAMLAttributes">ObjectWithAMLAttributes</a> implicit type conversion operator, defined for all CAEX objects which are allowed to contain Attribute objects.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;<a href="T_Aml_Engine_CAEX_CAEXWrapper">Aml.Engine.CAEX.CAEXWrapper</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Aml_Engine_CAEX_CAEXObject">Aml.Engine.CAEX.CAEXObject</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Aml_Engine_CAEX_AttributeTypeType">Aml.Engine.CAEX.AttributeTypeType</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Aml_Engine_CAEX_AttributeType">Aml.Engine.CAEX.AttributeType</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Aml.Engine.AmlObjects.FrameAttributeType<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class FrameAttributeType : AttributeType
```

**VB**<br />
``` VB
Public Class FrameAttributeType
	Inherits AttributeType
```

**C++**<br />
``` C++
public ref class FrameAttributeType : public AttributeType
```

The FrameAttributeType type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_AmlObjects_FrameAttributeType__ctor">FrameAttributeType(XElement)</a></td><td>
Creates a wrapper for the specified Frame Attribute. It is not checked, if the provided attribute Node represents a valid Frame attribute.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_AmlObjects_FrameAttributeType__ctor_1">FrameAttributeType(XElement, FrameValues)</a></td><td>
Initializes a new instance of the FrameAttributeType class. It is not checked, if the provided attribute Node represents a valid Frame attribute. If Frame attributes exist, they are initialized using the specified frame values.</td></tr></table>&nbsp;
<a href="#frameattributetype-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_AdditionalInformation">AdditionalInformation</a></td><td>
Gets the collection of AdditionalInformation values contained in this instance.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_Attribute">Attribute</a></td><td>
Gets a collection of Attributes contained in this instance.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_AttributeAndDescendants">AttributeAndDescendants</a></td><td>
Gets the attributes and all nested attributes.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_AttributeDataType">AttributeDataType</a></td><td>
Gets and sets the AttributeDataType attribute of this Attribute object. If the referenced attribute type does not base on an XML standard base type, the AttributeDataType may remain empty or not present.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeType_AttributePath">AttributePath</a></td><td>
returns the attribute path, which is equal to the attribute name for any attribute, which is not a nested attribute or a concatenation of attribute names separated by the attribute path delimiter for nested attributes.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeType_AttributeTreeOwner">AttributeTreeOwner</a></td><td>
Gets the owner of the Attribute Tree. This is the first ancestor, which is not an AttributeType object.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_AttributeTypeDefiningAttribute">AttributeTypeDefiningAttribute</a></td><td>
Gets the Attribute datatype which is valid for values of all <a href="P_Aml_Engine_CAEX_AttributeTypeType_ValueAttributes">ValueAttributes</a> of this element. For this class, it is the instance itself.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeType_AttributeTypeReference">AttributeTypeReference</a></td><td>
Gets and sets the AttributeType of an Attribute object, defining a new instance to class relation, using the CAEX attribute <a href="P_Aml_Engine_CAEX_AttributeTypeType_RefAttributeType">RefAttributeType</a>.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_AttributeValue">AttributeValue</a></td><td>
Gets and set the encoded/decoded attribute value according to the defined AttributeDataType.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_CAEXDocument">CAEXDocument</a></td><td>
Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_CAEXParent">CAEXParent</a></td><td>
Gets the CAEXParent of this instance if it exists.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_CAEXSequenceOfCAEXObject">CAEXSequenceOfCAEXObject</a></td><td>
Gets the CAEXSequence containing this CAEX object
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_ChangeMode">ChangeMode</a></td><td>
Gets and sets the change mode for a CAEX element (Optional in CAEX).
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_Constraint">Constraint</a></td><td>
Gets the collection of AttributeValueRequirement objects contained in this instance.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_Copyright">Copyright</a></td><td>
Gets and sets the Copyright for this object.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_CopyrightElement">CopyrightElement</a></td><td>
Gets the wrapper for the Copyright element.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_DefaultAttributeValue">DefaultAttributeValue</a></td><td>
Gets and set the encoded/decoded default attribute value according to the defined AttributeDataType.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_DefaultValue">DefaultValue</a></td><td>
Gets and sets the DefaultValue element of this Attribute object. Use the property <a href="P_Aml_Engine_CAEX_AttributeTypeType_DefaultAttributeValue">DefaultAttributeValue</a>, to get or set the type encoded default value according to the Attribute Data Type.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_Description">Description</a></td><td>
Gets and sets the Description for this object.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_DescriptionElement">DescriptionElement</a></td><td>
Gets the wrapper for the Description element.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_Document">Document</a></td><td>
Gets the XDocument of the wrapped XML-Element
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_Exists">Exists</a></td><td>
Determines if this is a wrapper around an existing XML-Element
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_FrameAttributeType_Frame">Frame</a></td><td>
Gets and sets the frame values for this FrameAttribute</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXObject_ID">ID</a></td><td>
Gets and sets a unique identifier of the CAEX object (optional in CAEX). AutomationML requires IDs for some Elements. These IDs are automatically set when such elements are created.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeType_IsMirror">IsMirror</a></td><td>
Gets a value indicating whether this instance is a mirror of another Attribute object.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_Item">Item</a></td><td>
Gets the type-decoded value and sets the type-encoded value for the value attribute with the defined name. The allowed Names as <a href="F_Aml_Engine_CAEX_CAEX_CLASSModel_TagNames_ATTRIBUTE_VALUE_STRING">ATTRIBUTE_VALUE_STRING</a> and <a href="F_Aml_Engine_CAEX_CAEX_CLASSModel_TagNames_ATTRIBUTE_DEFAULTVALUE_STRING">ATTRIBUTE_DEFAULTVALUE_STRING</a>.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeType_Master">Master</a></td><td>
Gets the master Attribute object if this is a mirror and the master can be found in this CAEX document.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeType_MasterID">MasterID</a></td><td>
Gets the identifier of the master Attribute if this is a Mirror. The identifier contains the ID of the attribute owner followed by the Attribute path.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeType_MasterParentID">MasterParentID</a></td><td>
Gets the ID of the master attributes parent instance, if this is a mirror Attribute object. If it is not a mirror, `null` is returned.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXObject_Name">Name</a></td><td>
Gets and sets the name of the CAEX object (required in CAEX).
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_Node">Node</a></td><td>
Gets the wrapped XML-Element
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_Owner">Owner</a></td><td>
Gets the wrapped Xml-Element's parent
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_RefAttributeType">RefAttributeType</a></td><td>
Gets and sets the RefAttributeType CAEX attribute of the Attribute object. This property is used to create instance to class relations between Attributes (instances) and AttributeType objects (classes).
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_RefSemantic">RefSemantic</a></td><td>
Gets the collection of RefSemantic objects contained in this instance
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_Revision">Revision</a></td><td>
Gets the collection of Revision objects contained in this instance.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_FrameAttributeType_RxAttribute">RxAttribute</a></td><td>
The Rx-attribute</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_FrameAttributeType_RyAttribute">RyAttribute</a></td><td>
The Ry-attribute</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_FrameAttributeType_RzAttribute">RzAttribute</a></td><td>
The Rz-attribute</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_SourceObjectInformation">SourceObjectInformation</a></td><td>
Gets the collection of SourceObjectInformation objects contained in this instance.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_TagName">TagName</a></td><td>
Gets the name of the CAEX tag for this CAEX object.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_Unit">Unit</a></td><td>
Gets and sets the Unit attribute for this Attribute object.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_Value">Value</a></td><td>
Gets and sets the Value for this Attribute object. The correct XML-String representation for the defined <a href="P_Aml_Engine_CAEX_AttributeTypeType_AttributeDataType">AttributeDataType</a> has to be ensured by the caller.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_ValueAttributes">ValueAttributes</a></td><td>
Gets all the CAEXValue objects for the defined value attributes of this instance. Recognized value attributes are <a href="F_Aml_Engine_CAEX_CAEX_CLASSModel_TagNames_ATTRIBUTE_DEFAULTVALUE_STRING">ATTRIBUTE_DEFAULTVALUE_STRING</a> and <a href="F_Aml_Engine_CAEX_CAEX_CLASSModel_TagNames_ATTRIBUTE_VALUE_STRING">ATTRIBUTE_VALUE_STRING</a>.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_Version">Version</a></td><td>
Gets and sets the Version for this object.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_VersionElement">VersionElement</a></td><td>
Gets the wrapper for the Version element.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_FrameAttributeType_XAttribute">XAttribute</a></td><td>
The X-attribute</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_FrameAttributeType_YAttribute">YAttribute</a></td><td>
The Y-attribute</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_FrameAttributeType_ZAttribute">ZAttribute</a></td><td>
The Z-attribute</td></tr></table>&nbsp;
<a href="#frameattributetype-class">Back to Top</a>

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
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_Container__1">Container(T)</a></td><td>
Gets the CAEX Container for elements of type T, which is owned by this CAEX object
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXObject_Copy">Copy</a></td><td>
Creates a deep copy of this CAEX object, containing all child elements. The created copy will have replaced unique IDs and updated references, if the *assignNewIDs* is set to true (default). When a CAEX class is copied, the nested classes that can exist for AttributeType, RoleClass, SystemUnitClass, and InterfaceClass are not included in the created copy.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_FrameAttributeType_Create">Create</a></td><td>
Creates a new FrameAttribute using the specified document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeType_CreateAttributeType">CreateAttributeType</a></td><td>
Creates an AttriuteType from this Attribute instance.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeType_CreateMirror">CreateMirror</a></td><td>
Creates a new mirror element from this AttributeType
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_Equals">Equals</a></td><td>
Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_GetCaexValue">GetCaexValue</a></td><td>
Gets the <a href="T_Aml_Engine_CAEX_Extensions_CaexValue">CaexValue</a> for the value attribute with the defined attribute name. The allowed Names as <a href="F_Aml_Engine_CAEX_CAEX_CLASSModel_TagNames_ATTRIBUTE_VALUE_STRING">ATTRIBUTE_VALUE_STRING</a> and <a href="F_Aml_Engine_CAEX_CAEX_CLASSModel_TagNames_ATTRIBUTE_DEFAULTVALUE_STRING">ATTRIBUTE_DEFAULTVALUE_STRING</a>.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_GetDateTime">GetDateTime</a></td><td>
Parse the Attribute Value string as dateTime. If the string can not be parsed, a format exception is returned. This method uses the XmlConvert <a href="https://docs.microsoft.com/dotnet/api/system.xml.xmlconvert.todatetime#System_Xml_XmlConvert_ToDateTime_System_String_System_Xml_XmlDateTimeSerializationMode_" target="_parent" rel="noopener noreferrer">ToDateTime(String, XmlDateTimeSerializationMode)</a> method.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_GetDouble">GetDouble</a></td><td>
Parse the Attribute Value string as double. If the string can not be parsed, a format exception is returned. This method uses the XmlConvert <a href="https://docs.microsoft.com/dotnet/api/system.xml.xmlconvert.todouble#System_Xml_XmlConvert_ToDouble_System_String_" target="_parent" rel="noopener noreferrer">ToDouble(String)</a> method and a fall back conversion, if the first conversion fails.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_GetHashCode">GetHashCode</a></td><td>
Gets the Hash code for this instance, using the wrapped XML element.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_GetXAttributeValue">GetXAttributeValue</a></td><td>
Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_Insert_1">Insert(Int32, CAEXWrapper)</a></td><td>
Inserts the specified CAEX object in it's associated sequence at the defined position. The AttributeType defines additional sequences for <a href="P_Aml_Engine_CAEX_AttributeTypeType_Attribute">Attribute</a>, <a href="P_Aml_Engine_CAEX_AttributeTypeType_Constraint">Constraint</a> and <a href="P_Aml_Engine_CAEX_AttributeTypeType_RefSemantic">RefSemantic</a>.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_Insert">Insert(CAEXWrapper, Boolean)</a></td><td>
Inserts the specified CAEX object in it's associated sequence. The AttributeType defines additional sequences for <a href="P_Aml_Engine_CAEX_AttributeTypeType_Attribute">Attribute</a>, <a href="P_Aml_Engine_CAEX_AttributeTypeType_Constraint">Constraint</a> and <a href="P_Aml_Engine_CAEX_AttributeTypeType_RefSemantic">RefSemantic</a>.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_InsertAfter">InsertAfter</a></td><td>
Inserts the provided CAEX object as a new sibling after this CAEX object.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_InsertBefore">InsertBefore</a></td><td>
Inserts the provided CAEX object as a new sibling before this CAEX object.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_InsertNew">InsertNew</a></td><td>
This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an <a href="P_Aml_Engine_CAEX_CAEXWrapper_Owner">Owner</a> is defined. The new created CAEX object is inserted as a new child of the owner.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_FrameAttributeType_IsFrame">IsFrame</a></td><td>
Determines whether the specified node models an AutomationML Frame-Attribute.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_FrameAttributeType_IsFrameAttribute">IsFrameAttribute</a></td><td>
Gets a value indicating whether the attribute is a Frame attribute.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXBasicObject_New_Revision">New_Revision</a></td><td>
Creates a new Revision object and inserts it to the collection of Revision objects <a href="P_Aml_Engine_CAEX_CAEXBasicObject_Revision">Revision</a> either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeType_RecreateAttributeInstance">RecreateAttributeInstance</a></td><td>
Replaces the content of this Attribute object with the specified attribute type. This Attribute object is changed to an instance of the provided Attribute Type.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_Remove">Remove</a></td><td>
Removes this element. After that it is no longer assigned to a document and has no owner anymore.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_SetDateTime">SetDateTime</a></td><td>
Sets the specified dateTime value as the attribute value. The AttributeDataType is set to xs:dateTime
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_SetDouble">SetDouble</a></td><td>
Sets the specified double value as the attribute value. The AttributeDataType is set to xs:double
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_SetXAttributeValue">SetXAttributeValue</a></td><td>
Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null).
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXObject_ToString">ToString</a></td><td>
Returns the value of the 'Name' attribute of this CAEX object as the string representation of the object.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_TryGetDateTime">TryGetDateTime</a></td><td>
Tries to parse the Attribute Value string as dateTime. This method uses the XmlConvert <a href="https://docs.microsoft.com/dotnet/api/system.xml.xmlconvert.todatetime#System_Xml_XmlConvert_ToDateTime_System_String_System_Xml_XmlDateTimeSerializationMode_" target="_parent" rel="noopener noreferrer">ToDateTime(String, XmlDateTimeSerializationMode)</a> method.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeTypeType_TryGetDouble">TryGetDouble</a></td><td>
Tries to parse the Attribute Value string as double. This method uses the XmlConvert <a href="https://docs.microsoft.com/dotnet/api/system.xml.xmlconvert.todouble#System_Xml_XmlConvert_ToDouble_System_String_" target="_parent" rel="noopener noreferrer">ToDouble(String)</a> method and a fall back conversion, if the first conversion fails.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_FrameAttributeType_ValidateAndRepairFrameDatatypes">ValidateAndRepairFrameDatatypes</a></td><td>
Validates and repairs the frame data types if the data type is not defined or not of type 'xs:double'</td></tr></table>&nbsp;
<a href="#frameattributetype-class">Back to Top</a>

## Events
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Aml_Engine_CAEX_CAEXWrapper_PropertyChanged">PropertyChanged</a></td><td>
The Change event raised when any property is modified.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr></table>&nbsp;
<a href="#frameattributetype-class">Back to Top</a>

## Fields
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_FrameAttributeType_FormatInfo">FormatInfo</a></td><td> **Obsolete. **
The format information for the Frame attribute (don't use this, because all frame values have to be saved as xs:double with standard format) If you want to save values with specific number format, do the string conversion</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_FrameAttributeType_FRAME_NAME">FRAME_NAME</a></td><td>
The frame name</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_FrameAttributeType_RX_Name">RX_Name</a></td><td>
The rx name</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_FrameAttributeType_RY_Name">RY_Name</a></td><td>
The ry name</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_FrameAttributeType_RZ_Name">RZ_Name</a></td><td>
The rz name</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_FrameAttributeType_X_Name">X_Name</a></td><td>
The x name</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_FrameAttributeType_Y_Name">Y_Name</a></td><td>
The y name</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_FrameAttributeType_Z_Name">Z_Name</a></td><td>
The z name</td></tr></table>&nbsp;
<a href="#frameattributetype-class">Back to Top</a>

## Extension Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_ListAttribute_AddListItem">AddListItem</a></td><td>
Adds an additional list item attribute to the list attribute. If the List attribute already contains some items, the new item will have the same item type as the already existing items. If this is the first item, the specified itemType is used as the attribute data type. If no itemType is defined, the default data type for the list item is "xs:string". The Item name is automatically set to the Index if the List attribute is an ordered list, otherwise the defined itemName is used.
 (Defined by <a href="T_Aml_Engine_AmlObjects_ListAttribute">ListAttribute</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_clone">clone</a></td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_Copy">Copy(Boolean, Boolean, Boolean)</a>
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_CloneNode">CloneNode</a></td><td>
Clones the node.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_ConsistencyCheck_ClassReference">ConsistencyCheck_ClassReference</a></td><td>
Check if the given classPath is a valid path to an existent class in the AML file.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_ListAttribute_ConvertToListAttribute">ConvertToListAttribute</a></td><td>
Changes the semantic of the specified attribute and converts to a list attribute. A first item is added to the List attribute which is initialized with valued from the converted attribute. If the Attribute is already a list attribute or the attribute contains child attributes it will not be converted.
 (Defined by <a href="T_Aml_Engine_AmlObjects_ListAttribute">ListAttribute</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_Descendants">Descendants(Type)</a></td><td>Overloaded.  
Finds the descendants of the provided CAEX object which are of the given type.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_Descendants__1">Descendants(T)()</a></td><td>Overloaded.  
Finds the descendants of the provided CAEX object which are of the given type.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_findInternalElement">findInternalElement</a></td><td>
Resolve a reference to an InternalElement and return the referenced element if found.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_getReferencedClass">getReferencedClass</a></td><td>
Getting the XML Node for a class path.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_getReferencedGUID">getReferencedGUID</a></td><td>
Parsing a string of form GUID:Interface and returning the GUID
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_getReferencedInterfaceClass">getReferencedInterfaceClass</a></td><td>
Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_getReferencedInterfaceName">getReferencedInterfaceName</a></td><td>
Getting the name of the referenced Interface.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_Insert_Element">Insert_Element</a></td><td>
Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_Insert_NewInstance">Insert_NewInstance</a></td><td>
Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_Insert_TypeBaseElement">Insert_TypeBaseElement</a></td><td><a href="M_Aml_Engine_CAEX_CAEXBasicObject_Insert">Insert(CAEXWrapper, Boolean)</a>
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib_IsAssociatedExternalValue">IsAssociatedExternalValue</a></td><td> (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib">AutomationMLBaseAttributeTypeLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib_IsAssociatedFacet">IsAssociatedFacet</a></td><td>
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
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib">AutomationMLBaseAttributeTypeLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_IsFacetAttribute">IsFacetAttribute</a></td><td>
Determines, if the attribute is an attribute of an AMLFacet.
 (Defined by <a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib_IsFrame">IsFrame</a></td><td>
Determines whether the specified attribute reference defines an inheritance relation from the Frame AttributeType
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib">AutomationMLBaseAttributeTypeLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_ListAttribute_IsListAttribute">IsListAttribute</a></td><td>
Determines whether the specified attribute is a list attribute. This can be ordered or unordered.
 (Defined by <a href="T_Aml_Engine_AmlObjects_ListAttribute">ListAttribute</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib_IsListType">IsListType</a></td><td>
Determines whether the specified attribute reference defines an inheritance relation from the ListType AttributeType
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib">AutomationMLBaseAttributeTypeLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib_IsLocalizedAttribute">IsLocalizedAttribute</a></td><td>
Determines whether the specified attribute reference defines an inheritance relation from the LocalizedAttribute AttributeType
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib">AutomationMLBaseAttributeTypeLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_AttributeTypeTypeExtensions_IsMaster">IsMaster</a></td><td>
Determines whether the specified Attribute is referenced by other Attribute objects called 'Mirrors'.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_AttributeTypeTypeExtensions">AttributeTypeTypeExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib_IsMIMEType">IsMIMEType</a></td><td>
Determines whether the specified attribute reference defines an inheritance relation from the MIMEType AttributeType
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib">AutomationMLBaseAttributeTypeLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_ListAttribute_IsOrderedListAttribute">IsOrderedListAttribute</a></td><td>
Determines whether the specified attribute is an ordered list attribute.
 (Defined by <a href="T_Aml_Engine_AmlObjects_ListAttribute">ListAttribute</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib_IsOrderedListType">IsOrderedListType</a></td><td>
Determines whether the specified attribute reference defines an inheritance relation from the OrderedListType AttributeType
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib">AutomationMLBaseAttributeTypeLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_IsRefTypeAttribute">IsRefTypeAttribute</a></td><td>
Gets a value indicating whether this instance is a RefType attribute.
 (Defined by <a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib_IsRefUri">IsRefUri</a></td><td>
Determines whether the specified attribute reference defines an inheritance relation from the RefURI AttributeType
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLib">AutomationMLBaseAttributeTypeLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_IsRefURIAttribute">IsRefURIAttribute</a></td><td>
Gets a value indicating whether this instance is a RefURI attribute.
 (Defined by <a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_ListAttribute_IsUnOrderedListAttribute">IsUnOrderedListAttribute</a></td><td>
Determines whether the specified attribute is an unordered list attribute.
 (Defined by <a href="T_Aml_Engine_AmlObjects_ListAttribute">ListAttribute</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_ListAttribute_ListItems">ListItems</a></td><td>
Gets the values of all items in the list attribute
 (Defined by <a href="T_Aml_Engine_AmlObjects_ListAttribute">ListAttribute</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_ListAttribute_ListItemValues">ListItemValues</a></td><td>
Gets the values of all items in the list attribute
 (Defined by <a href="T_Aml_Engine_AmlObjects_ListAttribute">ListAttribute</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_ListAttribute_MakeListAttribute">MakeListAttribute</a></td><td>
Changes the semantic of the specified attribute and converts it to a list attribute. If the Attribute is already a list attribute or the attribute contains child attributes it will not be converted.
 (Defined by <a href="T_Aml_Engine_AmlObjects_ListAttribute">ListAttribute</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_Name">Name()</a></td><td>Overloaded.  
Get the Name of the specified object.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_Name">Name()</a></td><td>Overloaded.  
Gets a names for the specified caex wrapper object. If the specified object is a <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>, the Name is returned; otherwise the TagName of the CAEX item.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_New_Description">New_Description</a></td><td>
Adds an new Description node to this object if it doesn't exists.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_AttributeTypeTypeExtensions_New_RefSemantic">New_RefSemantic</a></td><td>
Appends a new RefSemantic object with the defined semantics to the specified CAEX object.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_AttributeTypeTypeExtensions">AttributeTypeTypeExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_ToRefTypeAttribute">ToRefTypeAttribute</a></td><td>
Converts an AttributeType to a RefTypeAttribute.
 (Defined by <a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_ToRefURIAttribute">ToRefURIAttribute</a></td><td>
Converts an AttributeType to a RefUriAttribute.
 (Defined by <a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions</a>.)</td></tr></table>&nbsp;
<a href="#frameattributetype-class">Back to Top</a>

## Explicit Interface Implementations
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td><a href="M_Aml_Engine_CAEX_AttributeType_Aml_Engine_CAEX_IMirror_CreateMirror">IMirror.CreateMirror</a></td><td>
Creates a mirror.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private property](media/privproperty.gif "Private property")</td><td><a href="P_Aml_Engine_CAEX_AttributeType_Aml_Engine_CAEX_IMirror_IsMaster">IMirror.IsMaster</a></td><td>
Gets a value indicating whether this instance is a master attribute referenced by mirror attributes.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private property](media/privproperty.gif "Private property")</td><td><a href="P_Aml_Engine_CAEX_AttributeType_Aml_Engine_CAEX_IMirror_Master">IMirror.Master</a></td><td>
Gets the master, if this is a mirror attribute
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>.)</td></tr></table>&nbsp;
<a href="#frameattributetype-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br /><a href="T_Aml_Engine_CAEX_AttributeType">Aml.Engine.CAEX.AttributeType</a><br />