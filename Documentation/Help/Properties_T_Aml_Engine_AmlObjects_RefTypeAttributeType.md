# RefTypeAttributeType Properties
AutomationML 2.1 API 

The <a href="T_Aml_Engine_AmlObjects_RefTypeAttributeType">RefTypeAttributeType</a> type exposes the following members.


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
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXObject_ID">ID</a></td><td>
Gets and sets a unique identifier of the CAEX object (optional in CAEX). AutomationML requires IDs for some Elements. These IDs are automatically set when such elements are created.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeType_IsMirror">IsMirror</a></td><td>
Gets a value indicating whether this instance is a mirror of another Attribute object.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_RefTypeAttributeType_IsRefTypeAttribute">IsRefTypeAttribute</a></td><td>
Gets a value indicating whether this instance is a RefURI attribute.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_AttributeTypeType_Item">Item</a></td><td>
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
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_SourceObjectInformation">SourceObjectInformation</a></td><td>
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
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr></table>&nbsp;
<a href="#reftypeattributetype-properties">Back to Top</a>

## Explicit Interface Implementations
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private property](media/privproperty.gif "Private property")</td><td><a href="P_Aml_Engine_CAEX_AttributeType_Aml_Engine_CAEX_IMirror_IsMaster">IMirror.IsMaster</a></td><td>
Gets a value indicating whether this instance is a master attribute referenced by mirror attributes.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private property](media/privproperty.gif "Private property")</td><td><a href="P_Aml_Engine_CAEX_AttributeType_Aml_Engine_CAEX_IMirror_Master">IMirror.Master</a></td><td>
Gets the master, if this is a mirror attribute
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>.)</td></tr></table>&nbsp;
<a href="#reftypeattributetype-properties">Back to Top</a>

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_RefTypeAttributeType">RefTypeAttributeType Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />