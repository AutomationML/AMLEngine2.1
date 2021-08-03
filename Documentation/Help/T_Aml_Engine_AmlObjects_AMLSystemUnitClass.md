# AMLSystemUnitClass Class
AutomationML 2.1 API 

An AMLSystemUnitClass is a SystemUnitClass which can contain <a href="T_Aml_Engine_AmlObjects_AMLPort">AMLPort</a> AML objects.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;<a href="T_Aml_Engine_CAEX_CAEXWrapper">Aml.Engine.CAEX.CAEXWrapper</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Aml_Engine_CAEX_CAEXObject">Aml.Engine.CAEX.CAEXObject</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Aml_Engine_CAEX_SystemUnitClassType">Aml.Engine.CAEX.SystemUnitClassType</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Aml.Engine.AmlObjects.AMLSystemUnitClass<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class AMLSystemUnitClass : SystemUnitClassType
```

**VB**<br />
``` VB
Public Class AMLSystemUnitClass
	Inherits SystemUnitClassType
```

**C++**<br />
``` C++
public ref class AMLSystemUnitClass : public SystemUnitClassType
```

The AMLSystemUnitClass type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_AmlObjects_AMLSystemUnitClass__ctor_1">AMLSystemUnitClass(XElement)</a></td><td>
Initializes a new instance of the AMLSystemUnitClass class.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_AmlObjects_AMLSystemUnitClass__ctor">AMLSystemUnitClass(SystemUnitClassType)</a></td><td>
Initializes a new instance of the AMLSystemUnitClass class.</td></tr></table>&nbsp;
<a href="#amlsystemunitclass-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_AdditionalInformation">AdditionalInformation</a></td><td>
Gets the collection of AdditionalInformation values contained in this instance.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_AMLSystemUnitClass_AMLFacets">AMLFacets</a></td><td>
Gets the Collection of AMLFacet objects.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_AMLSystemUnitClass_AMLGroups">AMLGroups</a></td><td>
Gets the Collection of AMLGroup objects.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_AMLSystemUnitClass_AMLPorts">AMLPorts</a></td><td>
Gets the Collection of AMLPort objects.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_SystemUnitClassType_Attribute">Attribute</a></td><td>
Gets the collection of Attribute objects for this instance.
 (Inherited from <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_SystemUnitClassType_AttributeAndDescendants">AttributeAndDescendants</a></td><td>
Gets the attributes and all nested attributes.
 (Inherited from <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_CAEXDocument">CAEXDocument</a></td><td>
Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_CAEXParent">CAEXParent</a></td><td>
Gets the CAEXParent of this instance if it exists.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_CAEXSequenceOfCAEXObject">CAEXSequenceOfCAEXObject</a></td><td>
Gets the CAEXSequence containing this CAEX object
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_ChangeMode">ChangeMode</a></td><td>
Gets and sets the change mode for a CAEX element (Optional in CAEX).
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_Copyright">Copyright</a></td><td>
Gets and sets the Copyright for this object.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_CopyrightElement">CopyrightElement</a></td><td>
Gets the wrapper for the Copyright element.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_Description">Description</a></td><td>
Gets and sets the Description for this object.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_DescriptionElement">DescriptionElement</a></td><td>
Gets the wrapper for the Description element.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_Document">Document</a></td><td>
Gets the XDocument of the wrapped XML-Element
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_Exists">Exists</a></td><td>
Determines if this is a wrapper around an existing XML-Element
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_SystemUnitClassType_ExternalInterface">ExternalInterface</a></td><td>
Gets a collection of ExternalInterface objects contained in this instance.
 (Inherited from <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_SystemUnitClassType_ExternalInterfaceAndDescendants">ExternalInterfaceAndDescendants</a></td><td>
Gets the collection of ExternalInterface objects including all nested descendant interfaces
 (Inherited from <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXObject_ID">ID</a></td><td>
Gets and sets a unique identifier of the CAEX object (optional in CAEX). AutomationML requires IDs for some Elements. These IDs are automatically set when such elements are created.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_SystemUnitClassType_InternalElement">InternalElement</a></td><td>
Gets the collection of InternalElement objects for this instance.
 (Inherited from <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_SystemUnitClassType_InternalLink">InternalLink</a></td><td>
Gets the collection of InternalLink objects contained in this instance.
 (Inherited from <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXObject_Name">Name</a></td><td>
Gets and sets the name of the CAEX object (required in CAEX).
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_Node">Node</a></td><td>
Gets the wrapped XML-Element
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_Owner">Owner</a></td><td>
Gets the wrapped Xml-Element's parent
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_Revision">Revision</a></td><td>
Gets the collection of Revision objects contained in this instance.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_SystemUnitClassType_RoleReferences">RoleReferences</a></td><td>
Gets all role references for the SystemUnitClass. The collection includes all RoleRequirement objects and SupportedRoleClass objects.
 (Inherited from <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_SourceObjectInformation">SourceObjectInformation</a></td><td>
Gets the collection of SourceObjectInformation objects contained in this instance.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_SystemUnitClassType_SupportedRoleClass">SupportedRoleClass</a></td><td>
Gets the collection of SupportedRoleClass objects contained in this instance.
 (Inherited from <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_TagName">TagName</a></td><td>
Gets the name of the CAEX tag for this CAEX object.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_Version">Version</a></td><td>
Gets and sets the Version for this object.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_VersionElement">VersionElement</a></td><td>
Gets the wrapper for the Version element.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr></table>&nbsp;
<a href="#amlsystemunitclass-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_AmlObjects_AMLSystemUnitClass_AddFacet">AddFacet</a></td><td>
Adds an AMLFacet object to the AMLSystemUnitClass with the provided name.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_AmlObjects_AMLSystemUnitClass_AddGroup">AddGroup</a></td><td>
Adds an AMLGroup object to the AMLSystemUnitClass with the provided name.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Aml_Engine_CAEX_SystemUnitClassType_AddInterfaceClassReference_1">AddInterfaceClassReference(String, Boolean, Boolean, String)</a></td><td>
Adds an InterfaceClass reference to this SystemUnitClass object using the provided CAEX path, referencing an InterfaceClass object. The InterfaceClass reference is added as a <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a> object.
 (Inherited from <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Aml_Engine_CAEX_SystemUnitClassType_AddInterfaceClassReference">AddInterfaceClassReference(InterfaceFamilyType, Boolean, Boolean, String)</a></td><td>
Adds an InterfaceClass reference to this SystemUnitClass object using the provided InterfaceClass object. The InterfaceClass reference is added as a <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a> object.
 (Inherited from <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_AmlObjects_AMLSystemUnitClass_AddPort">AddPort</a></td><td>
Adds an AMLPort object to the AMLSystemUnitClass with the provided name.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXObject_AssignNewGuidAsID">AssignNewGuidAsID</a></td><td>
Assigns the new unique identifier as a new ID to this CAEX object.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_CAEXChild">CAEXChild</a></td><td>
Gets the first child of this CAEX object with the defined CAEX tag name.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_CAEXChildren">CAEXChildren</a></td><td>
Gets all children of this CAEX object with the defined CAEX tag name.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXObject_CAEXPath">CAEXPath</a></td><td>
Gets the CAEX path for this object. A path can be used to uniquely reference an object, for example in inheritances and instances. The path syntax for an object is defined differently in CAEX 2.15 and CAEX 3.0. The engine uses the <a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder</a> to generate the CAEX path of an object according to the documents CAEX version.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_SystemUnitClassType_CAEXSequence">CAEXSequence</a></td><td>
Gets the CAEXSequence owned by this CAEX object, which contains the specified CAEX object.
 (Inherited from <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_SystemUnitClassType_Container__1">Container(T)</a></td><td>
Gets the CAEX Container for elements of type T, which is owned by this CAEX object
 (Inherited from <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXObject_Copy">Copy</a></td><td>
Creates a deep copy of this CAEX object, containing all child elements. The created copy will have replaced unique IDs and updated references, if the *assignNewIDs* is set to true (default). When a CAEX class is copied, the nested classes that can exist for AttributeType, RoleClass, SystemUnitClass, and InterfaceClass are not included in the created copy.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_Equals">Equals</a></td><td>
Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_SystemUnitClassType_GetEnumerator">GetEnumerator</a></td><td>
Enumeration of contained InternalElement objects
 (Inherited from <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_GetHashCode">GetHashCode</a></td><td>
Gets the Hash code for this instance, using the wrapped XML element.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_GetXAttributeValue">GetXAttributeValue</a></td><td>
Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Aml_Engine_CAEX_SystemUnitClassType_HasInterfaceClassReference">HasInterfaceClassReference</a></td><td>
Determines whether this CAEX Element has an associated reference to the specified InterfaceClass. If inheritance relations between InterfaceClasses should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified InterfaceClass is either identical to a referenced InterfaceClass or a referenced InterfaceClass is derived from the specified InterfaceClass.
 (Inherited from <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_SystemUnitClassType_Insert_1">Insert(Int32, CAEXWrapper)</a></td><td>
Inserts the specified CAEX object in it's associated sequence. The SystemUnitClass defines the <a href="P_Aml_Engine_CAEX_SystemUnitClassType_Attribute">Attribute</a>, <a href="P_Aml_Engine_CAEX_SystemUnitClassType_ExternalInterface">ExternalInterface</a>, <a href="P_Aml_Engine_CAEX_SystemUnitClassType_InternalElement">InternalElement</a>, <a href="P_Aml_Engine_CAEX_SystemUnitClassType_InternalLink">InternalLink</a>, and <a href="P_Aml_Engine_CAEX_SystemUnitClassType_SupportedRoleClass">SupportedRoleClass</a> sequence.
 (Inherited from <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_SystemUnitClassType_Insert">Insert(CAEXWrapper, Boolean)</a></td><td>
Inserts the specified CAEX object in it's associated sequence. The SystemUnitClass defines the <a href="P_Aml_Engine_CAEX_SystemUnitClassType_Attribute">Attribute</a>, <a href="P_Aml_Engine_CAEX_SystemUnitClassType_ExternalInterface">ExternalInterface</a>, <a href="P_Aml_Engine_CAEX_SystemUnitClassType_InternalElement">InternalElement</a>, <a href="P_Aml_Engine_CAEX_SystemUnitClassType_InternalLink">InternalLink</a>, and <a href="P_Aml_Engine_CAEX_SystemUnitClassType_SupportedRoleClass">SupportedRoleClass</a> sequence.
 (Inherited from <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_SystemUnitClassType_InsertAfter">InsertAfter</a></td><td>
Inserts the provided CAEX object as a new sibling after this CAEX object.
 (Inherited from <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_SystemUnitClassType_InsertBefore">InsertBefore</a></td><td>
Inserts the provided CAEX object as a new sibling before this CAEX object.
 (Inherited from <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_InsertNew">InsertNew</a></td><td>
This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an <a href="P_Aml_Engine_CAEX_CAEXWrapper_Owner">Owner</a> is defined. The new created CAEX object is inserted as a new child of the owner.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_SystemUnitClassType_LowestCommonParent">LowestCommonParent</a></td><td>
Gets the Lowest common parent to this SystemUnitClass and the provided SystemUnitClass. The common parent is used to store an InternalLink relating this two SystemUnitClass objects. An InternalLink is not allowed to leave the boundary of a SystemUnitClass which means, that no common parent is defined for two different SystemUnitClass objects. If one Element is a SystemUnitClass the other one should be an InternalElement descendant of the SystemUnitClass.
 (Inherited from <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXBasicObject_New_Revision">New_Revision</a></td><td>
Creates a new Revision object and inserts it to the collection of Revision objects <a href="P_Aml_Engine_CAEX_CAEXBasicObject_Revision">Revision</a> either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_Remove">Remove</a></td><td>
Removes this element. After that it is no longer assigned to a document and has no owner anymore.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_SetXAttributeValue">SetXAttributeValue</a></td><td>
Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null).
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_SystemUnitClassType_SupportedRoleClassWithName">SupportedRoleClassWithName</a></td><td>
Get the RoleClass from the sequence of <a href="P_Aml_Engine_CAEX_SystemUnitClassType_SupportedRoleClass">SupportedRoleClass</a> with the provided *roleClassName*.
 (Inherited from <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXObject_ToString">ToString</a></td><td>
Returns the value of the 'Name' attribute of this CAEX object as the string representation of the object.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>.)</td></tr></table>&nbsp;
<a href="#amlsystemunitclass-class">Back to Top</a>

## Events
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Aml_Engine_CAEX_CAEXWrapper_PropertyChanged">PropertyChanged</a></td><td>
The Change event raised when any property is modified.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr></table>&nbsp;
<a href="#amlsystemunitclass-class">Back to Top</a>

## Extension Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_ExternalDataReference_AddDocumentElement">AddDocumentElement</a></td><td>
Adds a document element to the defined internalElement. A Document Element is semantically described with an attached role defined with the base role class <a href="F_Aml_Engine_AmlObjects_ExternalDataReference_ExternalDataRoleClassPath">ExternalDataRoleClassPath</a> or a derived role class. If no role class path is given as a parameter the default is used. If the specified role class path can not be identified as a derived role from the <a href="F_Aml_Engine_AmlObjects_ExternalDataReference_ExternalDataRoleClassPath">ExternalDataRoleClassPath</a> no document element is added (returns null).
 (Defined by <a href="T_Aml_Engine_AmlObjects_ExternalDataReference">ExternalDataReference</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions_AddInstance">AddInstance</a></td><td>
Inserts a new class instance to the InternalElement collection of the parentInternalElement. If there are existing instances of the same Type, the Element is inserted after the last Element of that Type. Before Insertion, the Uniqueness of the Name among the siblings of that Type is checked.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions">SystemUnitClassTypeExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions_AddNewInternalElement">AddNewInternalElement</a></td><td>
Creates a new InternalElement and inserts it after the last InternalElement of the parent if the elementName is unique among the child's. The ChangeMode is set to the Value 'Create'
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions">SystemUnitClassTypeExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_AMLSystemUnitClass">AMLSystemUnitClass</a></td><td>
Converts an SystemUnitClassType to an AMLSystemUnitClass.
 (Defined by <a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_Ancestors">Ancestors</a></td><td>
Returns all SystemUnit Classes which are ancestors of this. This SystemUnit Class is included in the enumeration as the first Element, The farthest is the last Element in the enumeration.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions_Append_InternalElement">Append_InternalElement</a></td><td>
Inserts the InternalElement object after the defined Predecessor in the InternalElement collection of the SystemUnitClass. If the Predecessor is null, the InternalElement object is inserted at the first position of the InternalElement collection.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions">SystemUnitClassTypeExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_AssignNewGUIDsAndRedirectExistingInternalLinks">AssignNewGUIDsAndRedirectExistingInternalLinks</a></td><td>
Assigns the new GUIds and redirect existing internal links.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_AssignNewGUIDsAndRedirectExistingInternalLinksAndMirrorObjects">AssignNewGUIDsAndRedirectExistingInternalLinksAndMirrorObjects</a></td><td>
This Method assigns new GUIds to the SystemUnitClass and its subordinate Children, which have an ID. The References to the old IDs in Mirrors and InternalLinks are redirected to the new ID. If a Reference is not found in any of the subordinate Elements, the Reference will not be changed.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_clone">clone</a></td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_Copy">Copy(Boolean, Boolean, Boolean)</a>
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_CloneNode">CloneNode</a></td><td>
Clones the node.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_ConsistencyCheck_ClassReference">ConsistencyCheck_ClassReference</a></td><td>
Check if the given classPath is a valid path to an existent class in the AML file.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_Descendants">Descendants(Type)</a></td><td>Overloaded.  
Finds the descendants of the provided CAEX object which are of the given type.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_Descendants__1">Descendants(T)()</a></td><td>Overloaded.  
Finds the descendants of the provided CAEX object which are of the given type.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_ExternalDataReference_DocumentElements">DocumentElements</a></td><td>
Gets all Internal Element Children from the specified internal element which are document elements.
 (Defined by <a href="T_Aml_Engine_AmlObjects_ExternalDataReference">ExternalDataReference</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_findInternalElement">findInternalElement</a></td><td>
Resolve a reference to an InternalElement and return the referenced element if found.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_getLinkedObjects">getLinkedObjects</a></td><td>
Getting a List of LinkedObjects object of this SystemUnitClass containing references to the concrete referenced InternalElements via an InternalLink.
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
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions_Insert_InternalLink">Insert_InternalLink</a></td><td>
Inserts the specified InternalLink as the first InternalLink if nothing else if explicit defined.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions">SystemUnitClassTypeExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_Insert_NewInstance">Insert_NewInstance</a></td><td>
Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions_Insert_SupportedRoleClass">Insert_SupportedRoleClass</a></td><td>
Inserts the SupportedRoleClass as the first SupportedRoleClass if nothing else if explicit defined.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions">SystemUnitClassTypeExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_Insert_TypeBaseElement">Insert_TypeBaseElement</a></td><td><a href="M_Aml_Engine_CAEX_CAEXBasicObject_Insert">Insert(CAEXWrapper, Boolean)</a>
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Services_QueryResult_InternalLinksToElement">InternalLinksToElement</a></td><td>
Gets all InternalLink referencing the provided SystemUnitClass object.
 (Defined by <a href="T_Aml_Engine_Services_QueryResult">QueryResult</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_Name">Name()</a></td><td>Overloaded.  
Get the Name of the specified object.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_Name">Name()</a></td><td>Overloaded.  
Gets a names for the specified caex wrapper object. If the specified object is a <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>, the Name is returned; otherwise the TagName of the CAEX item.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_New_Description">New_Description</a></td><td>
Adds an new Description node to this object if it doesn't exists.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions_New_InternalLink">New_InternalLink</a></td><td>
Inserts a new InternalLink as the first InternalLink if nothing else if explicit defined.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions">SystemUnitClassTypeExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions_New_SupportedRoleClass">New_SupportedRoleClass</a></td><td>
Inserts a new SupportedRoleClass as the first SupportedRoleClass if nothing else if explicit defined.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions">SystemUnitClassTypeExtensions</a>.)</td></tr></table>&nbsp;
<a href="#amlsystemunitclass-class">Back to Top</a>

## Explicit Interface Implementations
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td><a href="M_Aml_Engine_CAEX_SystemUnitClassType_System_Collections_IEnumerable_GetEnumerator">IEnumerable.GetEnumerator</a></td><td>
Enumeration of contained InternalElement objects
 (Inherited from <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>.)</td></tr></table>&nbsp;
<a href="#amlsystemunitclass-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br /><a href="T_Aml_Engine_CAEX_SystemUnitClassType">Aml.Engine.CAEX.SystemUnitClassType</a><br />