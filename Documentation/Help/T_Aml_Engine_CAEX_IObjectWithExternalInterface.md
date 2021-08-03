# IObjectWithExternalInterface Interface
AutomationML 2.1 API 

Interface that defines methods and properties that apply to all classes that are able to contain ExternalInterface objects.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public interface IObjectWithExternalInterface : IObjectWithAttributes, 
	ICAEXWrapper, IXMLWrapper
```

**VB**<br />
``` VB
Public Interface IObjectWithExternalInterface
	Inherits IObjectWithAttributes, ICAEXWrapper, IXMLWrapper
```

**C++**<br />
``` C++
public interface class IObjectWithExternalInterface : IObjectWithAttributes, 
	ICAEXWrapper, IXMLWrapper
```

The IObjectWithExternalInterface type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_IObjectWithAttributes_Attribute">Attribute</a></td><td>
Get the collection of all attributes of this object. Inherited Attributes are not included.
 (Inherited from <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">IObjectWithAttributes</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_IObjectWithAttributes_AttributeAndDescendants">AttributeAndDescendants</a></td><td>
Gets the attributes and all nested attributes.
 (Inherited from <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">IObjectWithAttributes</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_ICAEXWrapper_CAEXParent">CAEXParent</a></td><td>
Gets the CAEXParent of this CAEX object
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXWrapper">ICAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_XML_IXMLWrapper_Document">Document</a></td><td>
Gets the XDocument containing the XML node of this object. If the object has not been inserted into a document, the XDocument is `null`. Direct manipulations of the XML document are not monitored by the AML engine.
 (Inherited from <a href="T_Aml_Engine_XML_IXMLWrapper">IXMLWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_XML_IXMLWrapper_Exists">Exists</a></td><td>
Determines, if this instance is wrapped around an existing XML node
 (Inherited from <a href="T_Aml_Engine_XML_IXMLWrapper">IXMLWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_IObjectWithExternalInterface_ExternalInterface">ExternalInterface</a></td><td>
Gets the collection of ExternalInterface objects</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_IObjectWithExternalInterface_ExternalInterfaceAndDescendants">ExternalInterfaceAndDescendants</a></td><td>
Gets the collection of ExternalInterface objects including all nested descendant interfaces</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_XML_IXMLWrapper_Node">Node</a></td><td>
Get the XML node of this instance. Direct manipulations of the XML node are not monitored by the AML engine.
 (Inherited from <a href="T_Aml_Engine_XML_IXMLWrapper">IXMLWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_XML_IXMLWrapper_Owner">Owner</a></td><td>
Gets the XML parent node of this instance. Direct manipulations of the XML node are not monitored by the AML engine.
 (Inherited from <a href="T_Aml_Engine_XML_IXMLWrapper">IXMLWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_XML_IXMLWrapper_TagName">TagName</a></td><td>
Gets the Schema Tag name of this instance.
 (Inherited from <a href="T_Aml_Engine_XML_IXMLWrapper">IXMLWrapper</a>.)</td></tr></table>&nbsp;
<a href="#iobjectwithexternalinterface-interface">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ICAEXWrapper_CAEXChild">CAEXChild</a></td><td>
Gets the first child of this CAEX object with the defined CAEX tag name.
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXWrapper">ICAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ICAEXWrapper_CAEXChildren">CAEXChildren</a></td><td>
Gets all children of this CAEX object with the defined CAEX tag name.
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXWrapper">ICAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ICAEXWrapper_Remove">Remove</a></td><td>
Removes this object
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXWrapper">ICAEXWrapper</a>.)</td></tr></table>&nbsp;
<a href="#iobjectwithexternalinterface-interface">Back to Top</a>

## Extension Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_AddAttributeTypeReference_1">AddAttributeTypeReference(String, Boolean, Boolean, String)</a></td><td>Overloaded.  
Adds an AttributeType reference to this ObjectWithAttribute using the provided CAEX path, referencing an AttributeType object. The AttributeType reference is added as a <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a> object.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithAttributes">ObjectWithAttributes</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_AddAttributeTypeReference">AddAttributeTypeReference(AttributeFamilyType, Boolean, Boolean, String)</a></td><td>Overloaded.  
Adds an AttributeType reference to this ObjectWithAttribute using the provided AttributeType object. The AttributeType reference is added as a <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a> object.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithAttributes">ObjectWithAttributes</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithExternalInterface_AddInterfaceClassReference_1">AddInterfaceClassReference(String, Boolean, Boolean, String)</a></td><td>Overloaded.  
Adds an InterfaceClass reference to this ObjectWithExternalInterface using the provided CAEX path, referencing an InterfaceClass object. The InterfaceClass reference is added as a <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a> object.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithExternalInterface">ObjectWithExternalInterface</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithExternalInterface_AddInterfaceClassReference">AddInterfaceClassReference(InterfaceFamilyType, Boolean, Boolean, String)</a></td><td>Overloaded.  
Adds an InterfaceClass reference to this ObjectWithExternalInterface using the provided InterfaceClass object. The InterfaceClass reference is added as a <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a> object.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithExternalInterface">ObjectWithExternalInterface</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_AMLAttributes">AMLAttributes</a></td><td>
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
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_CopyAttributesFrom">CopyAttributesFrom</a></td><td>
Copies all attribute of the source object with attributes to the target object including children
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithAttributes">ObjectWithAttributes</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_ListAttribute_CreateListAttribute">CreateListAttribute</a></td><td>
Creates a new list attribute for an element which can have attributes.
 (Defined by <a href="T_Aml_Engine_AmlObjects_ListAttribute">ListAttribute</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_Descendants__1_1">Descendants(T)</a></td><td>
Finds the descendants of the provided CAEX object which are of the given type.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_ExternalInterfaces">ExternalInterfaces</a></td><td>
Enumeration Method for direct Children of Type <a href="T_Aml_Engine_CAEX_InterfaceClassType">InterfaceClassType</a>
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_FindCaexObjectFromId__1">FindCaexObjectFromId(T)</a></td><td>
Finds the CAEX object with the specified id and the specified Type.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_findExternalInterface">findExternalInterface</a></td><td>
Searches for an ExternalInterface in this InternalElement
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
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Adapter_AMLEngineAdapter_GetExternalInterfaces">GetExternalInterfaces</a></td><td>
Gets the external interfaces.
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_GetParent__1">GetParent(T)</a></td><td>
Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithExternalInterface_HasInterfaceClassReference_1">HasInterfaceClassReference(String, Boolean)</a></td><td>Overloaded.  
Determines whether this Object with ExternalInterfaces has an associated InterfaceClass reference with the specified CAEX path interface reference. If inheritance relations between interface classes should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified InterfaceClass is either identical to a referenced InterfaceClass or a referenced InterfaceClass is derived from the specified InterfaceClass.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithExternalInterface">ObjectWithExternalInterface</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithExternalInterface_HasInterfaceClassReference">HasInterfaceClassReference(InterfaceFamilyType, Boolean)</a></td><td>Overloaded.  
Determines whether an object with ExternalInterfaces has an associated reference to the specified InterfaceClass. If inheritance relations between InterfaceClasses should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified InterfaceClass is either identical to a referenced InterfaceClass or a referenced InterfaceClass is derived from the specified InterfaceClass.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithExternalInterface">ObjectWithExternalInterface</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions_Insert_Attribute">Insert_Attribute</a></td><td>
Inserts an Attribute object in the Attribute collection of the *objectWithAttributes*.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions">SystemUnitClassTypeExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions_Insert_ExternalInterface">Insert_ExternalInterface</a></td><td>
Inserting an ExternalInterface to the ExternalInterface-Collection of the *objectWithExternalInterface*. The Element is inserted at the first Element of any existing ExternalInterfaces if no other position is defined.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions">SystemUnitClassTypeExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithExternalInterface_InterfaceClassReferences">InterfaceClassReferences</a></td><td>
All external Interfaces of this Object with ExternalInterfaces with an associated InterfaceClass reference with the specified CAEX path interface reference. If inheritance relations between interface classes should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified InterfaceClass is either identical to a referenced InterfaceClass or a referenced InterfaceClass is derived from the specified InterfaceClass.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithExternalInterface">ObjectWithExternalInterface</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_IsAMLObject">IsAMLObject</a></td><td>
Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface.
 (Defined by <a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_Library">Library</a></td><td>
Gets the Library which contains this CAEX object.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_New_Attribute">New_Attribute</a></td><td>
Appends a new Attribute object with the defined name to the specified CAEX object.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithAttributes">ObjectWithAttributes</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions_New_ExternalInterface">New_ExternalInterface(String, Boolean)</a></td><td>Overloaded.  
Adding a new ExternalInterface instance to the ExternalInterface-Collection of the *objectWithExternalInterface*. The New ExternalInterface is inserted as the first ExternalInterface of any existing Interfaces if nothing else is explicit defined.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions">SystemUnitClassTypeExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions_New_ExternalInterface_1">New_ExternalInterface(String, String, Boolean)</a></td><td>Overloaded.  
Adding a new ExternalInterface instance to the ExternalInterface-Collection of the *objectWithExternalInterface* referencing a specific InterfaceClass. The New ExternalInterface is inserted as the first ExternalInterface of any existing Interfaces if nothing else is explicit defined. The provided *interfaceClassPath* is set as the RefBaseClassPath value.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions">SystemUnitClassTypeExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_New_FrameAttribute">New_FrameAttribute</a></td><td>
Creates a new Frame attribute for the <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">IObjectWithAttributes</a> if no Frame attribute exists. The provided values are used to initialize the Frame attribute values.
 (Defined by <a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ExternalInterfaceTypeExtensions_OfInterfaceClass">OfInterfaceClass</a></td><td>
Gets all ExternalInterface objects from the specified *objectWithExternalInterface*, which are derived from an InterfaceClass, identified with the given *interfaceClassPath*.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ExternalInterfaceTypeExtensions">ExternalInterfaceTypeExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_RefTypeAttribute">RefTypeAttribute</a></td><td>
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
<a href="#iobjectwithexternalinterface-interface">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br /><a href="T_Aml_Engine_CAEX_ICAEXWrapper">Aml.Engine.CAEX.ICAEXWrapper</a><br />