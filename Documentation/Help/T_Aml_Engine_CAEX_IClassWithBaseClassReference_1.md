# IClassWithBaseClassReference(*T*) Interface
AutomationML 2.1 API 

This interface class is derived from <a href="T_Aml_Engine_CAEX_IClassWithBaseClassReference">IClassWithBaseClassReference</a> and defines a generic interface using a type parameter to specify the type of the class to class relation. A class to class relation is also referred to as an inheritance relation.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public interface IClassWithBaseClassReference<T> : IClassWithBaseClassReference, 
	IObjectWithAttributes, ICAEXWrapper, IXMLWrapper, ICAEXObject, ICAEXBasicObject
where T : CAEXObject

```

**VB**<br />
``` VB
Public Interface IClassWithBaseClassReference(Of T As CAEXObject)
	Inherits IClassWithBaseClassReference, IObjectWithAttributes, ICAEXWrapper, IXMLWrapper, 
	ICAEXObject, ICAEXBasicObject
```

**C++**<br />
``` C++
generic<typename T>
where T : CAEXObject
public interface class IClassWithBaseClassReference : IClassWithBaseClassReference, 
	IObjectWithAttributes, ICAEXWrapper, IXMLWrapper, ICAEXObject, ICAEXBasicObject
```


#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>Type of the class with a base class relation.</dd></dl>&nbsp;
The IClassWithBaseClassReference(T) type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_ICAEXBasicObject_AdditionalInformation">AdditionalInformation</a></td><td>
Gets the collection of AdditionalInformation values contained in this instance.
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXBasicObject">ICAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_IObjectWithAttributes_Attribute">Attribute</a></td><td>
Get the collection of all attributes of this object. Inherited Attributes are not included.
 (Inherited from <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">IObjectWithAttributes</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_IObjectWithAttributes_AttributeAndDescendants">AttributeAndDescendants</a></td><td>
Gets the attributes and all nested attributes.
 (Inherited from <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">IObjectWithAttributes</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_IClassWithBaseClassReference_1_BaseClass">BaseClass</a></td><td>
Gets and sets the base class to define a class to class relation.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_ICAEXWrapper_CAEXParent">CAEXParent</a></td><td>
Gets the CAEXParent of this CAEX object
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXWrapper">ICAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_ICAEXBasicObject_ChangeMode">ChangeMode</a></td><td>
Gets and sets the change mode for a CAEX element (Optional in CAEX).
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXBasicObject">ICAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_ICAEXBasicObject_Copyright">Copyright</a></td><td>
Gets and sets the Copyright for this object.
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXBasicObject">ICAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_ICAEXBasicObject_CopyrightElement">CopyrightElement</a></td><td>
Gets the wrapper for the Copyright element.
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXBasicObject">ICAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_ICAEXBasicObject_Description">Description</a></td><td>
Gets and sets the Description for this object.
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXBasicObject">ICAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_ICAEXBasicObject_DescriptionElement">DescriptionElement</a></td><td>
Gets the wrapper for the Description element.
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXBasicObject">ICAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_XML_IXMLWrapper_Document">Document</a></td><td>
Gets the XDocument containing the XML node of this object. If the object has not been inserted into a document, the XDocument is `null`. Direct manipulations of the XML document are not monitored by the AML engine.
 (Inherited from <a href="T_Aml_Engine_XML_IXMLWrapper">IXMLWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_XML_IXMLWrapper_Exists">Exists</a></td><td>
Determines, if this instance is wrapped around an existing XML node
 (Inherited from <a href="T_Aml_Engine_XML_IXMLWrapper">IXMLWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_ICAEXObject_ID">ID</a></td><td>
Gets or sets the identifier.
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXObject">ICAEXObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_ICAEXObject_Name">Name</a></td><td>
Gets or sets the name.
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXObject">ICAEXObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_XML_IXMLWrapper_Node">Node</a></td><td>
Get the XML node of this instance. Direct manipulations of the XML node are not monitored by the AML engine.
 (Inherited from <a href="T_Aml_Engine_XML_IXMLWrapper">IXMLWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_XML_IXMLWrapper_Owner">Owner</a></td><td>
Gets the XML parent node of this instance. Direct manipulations of the XML node are not monitored by the AML engine.
 (Inherited from <a href="T_Aml_Engine_XML_IXMLWrapper">IXMLWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_IClassWithBaseClassReference_RefBaseClassPath">RefBaseClassPath</a></td><td>
Gets the reference base class path.
 (Inherited from <a href="T_Aml_Engine_CAEX_IClassWithBaseClassReference">IClassWithBaseClassReference</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_IClassWithBaseClassReference_ReferencedClassName">ReferencedClassName</a></td><td>
Gets the name (not the full path) of the referenced base class.
 (Inherited from <a href="T_Aml_Engine_CAEX_IClassWithBaseClassReference">IClassWithBaseClassReference</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_ICAEXBasicObject_Revision">Revision</a></td><td>
Gets the collection of Revision objects contained in this instance.
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXBasicObject">ICAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_ICAEXBasicObject_SourceObjectInformation">SourceObjectInformation</a></td><td>
Gets the collection of SourceObjectInformation objects contained in this instance.
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXBasicObject">ICAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_XML_IXMLWrapper_TagName">TagName</a></td><td>
Gets the Schema Tag name of this instance.
 (Inherited from <a href="T_Aml_Engine_XML_IXMLWrapper">IXMLWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_ICAEXBasicObject_Version">Version</a></td><td>
Gets and sets the Version for this object.
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXBasicObject">ICAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_ICAEXBasicObject_VersionElement">VersionElement</a></td><td>
Gets the wrapper for the Version element.
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXBasicObject">ICAEXBasicObject</a>.)</td></tr></table>&nbsp;
<a href="#iclasswithbaseclassreference(*t*)-interface">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ICAEXWrapper_CAEXChild">CAEXChild</a></td><td>
Gets the first child of this CAEX object with the defined CAEX tag name.
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXWrapper">ICAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ICAEXWrapper_CAEXChildren">CAEXChildren</a></td><td>
Gets all children of this CAEX object with the defined CAEX tag name.
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXWrapper">ICAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ICAEXObject_CAEXPath">CAEXPath</a></td><td>
Gets the CAEX path for this object. A path can be used to uniquely reference an object, for example in inheritances and instances. The path syntax for an object is defined differently in CAEX 2.15 and CAEX 3.0. The engine uses the <a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder</a> to generate the CAEX path of an object according to the documents CAEX version.
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXObject">ICAEXObject</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ICAEXBasicObject_CAEXSequence">CAEXSequence</a></td><td>
Gets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects <a href="P_Aml_Engine_CAEX_ICAEXBasicObject_Revision">Revision</a> is returned.
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXBasicObject">ICAEXBasicObject</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ICAEXBasicObject_Container__1">Container(T)</a></td><td>
Gets the CAEXSequence for elements of type T, which is owned by this CAEX object.
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXBasicObject">ICAEXBasicObject</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_IClassWithBaseClassReference_1_GetReferenceHierarchy">GetReferenceHierarchy</a></td><td>
Gets the reference hierarchy for all class to class relations, starting with this class.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ICAEXBasicObject_Insert_1">Insert(Int32, CAEXWrapper)</a></td><td>
Inserts the specified CAEX object in it's associated sequence at the defined position. The CAEXBasicObject defines the <a href="P_Aml_Engine_CAEX_ICAEXBasicObject_Revision">Revision</a> and <a href="P_Aml_Engine_CAEX_ICAEXBasicObject_SourceObjectInformation">SourceObjectInformation</a> sequences.
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXBasicObject">ICAEXBasicObject</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ICAEXBasicObject_Insert">Insert(CAEXWrapper, Boolean)</a></td><td>
Inserts the specified CAEX object in it's associated sequence. The CAEXBasicObject defines the <a href="P_Aml_Engine_CAEX_ICAEXBasicObject_Revision">Revision</a> and <a href="P_Aml_Engine_CAEX_ICAEXBasicObject_SourceObjectInformation">SourceObjectInformation</a> sequences.
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXBasicObject">ICAEXBasicObject</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ICAEXBasicObject_New_Revision">New_Revision</a></td><td>
Creates a new Revision object and inserts it to the collection of Revision objects <a href="P_Aml_Engine_CAEX_ICAEXBasicObject_Revision">Revision</a> either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values.
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXBasicObject">ICAEXBasicObject</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ICAEXWrapper_Remove">Remove</a></td><td>
Removes this object
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXWrapper">ICAEXWrapper</a>.)</td></tr></table>&nbsp;
<a href="#iclasswithbaseclassreference(*t*)-interface">Back to Top</a>

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
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_InheritanceExtensions_ClassIsDerivedFrom__1_2">ClassIsDerivedFrom(T)(String)</a></td><td>Overloaded.  
Determines, if the specified class is directly or indirectly (across multiple generations) a descendant of the class or identical to it, which is uniquely identified with the specified baseClass path. The base class path or the referenced class path may contain alias identifiers. If alias identifiers are present, the method tries to load the external referenced document.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_InheritanceExtensions">InheritanceExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_InheritanceExtensions_ClassIsDerivedFrom__1_1">ClassIsDerivedFrom(T)(IClassWithBaseClassReference(T))</a></td><td>Overloaded.  
Determines, if the specified class is directly or indirectly (across multiple generations) a descendant of the specified base class or identical to it. This method can be used, if the classes are distributed over different CAEX documents, the documents should be referenced by external references and alias references.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_InheritanceExtensions">InheritanceExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_CopyAttributesFrom">CopyAttributesFrom</a></td><td>
Copies all attribute of the source object with attributes to the target object including children
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithAttributes">ObjectWithAttributes</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_ListAttribute_CreateListAttribute">CreateListAttribute</a></td><td>
Creates a new list attribute for an element which can have attributes.
 (Defined by <a href="T_Aml_Engine_AmlObjects_ListAttribute">ListAttribute</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass_DeleteInheritedElement">DeleteInheritedElement</a></td><td>
Deletes the inherited element. According to CAEX [DIN EN 62424:2008-08 A.2.4.1 (pp.48-49)], deleting of inherited properties is possible by redefinition of the corresponding data again in the child object with the ChangeMode attribute set to "deleted".
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass">ObjectWithBaseClass</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_Descendants__1_1">Descendants(T)</a></td><td>
Finds the descendants of the provided CAEX object which are of the given type.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_FindCaexObjectFromId__1">FindCaexObjectFromId(T)</a></td><td>
Finds the CAEX object with the specified id and the specified Type.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_FindReferencedClass__1">FindReferencedClass(T)</a></td><td>
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
 (Defined by <a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass_GetDerivedAttributes">GetDerivedAttributes</a></td><td>
Gets a list of Attribute objects that are inherited from base classes. The List will also contain the elements own Attribute objects, if the parameter is set (default). If an Attribute is overwritten, only the last defined is contained.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass">ObjectWithBaseClass</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXObjectExtensions_GetFullNodePath">GetFullNodePath</a></td><td>
Gets the full node path of the provided CAEX object, which includes the object names of all ancestor hierarchy levels and the name of the object itself.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXObjectExtensions">CAEXObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass_GetInheritedAttributes">GetInheritedAttributes</a></td><td>
Gets a collection of Attribute objects that are inherited from base classes. The own attributes are included in the enumeration.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass">ObjectWithBaseClass</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass_GetInheritedAttributesAndDescendants">GetInheritedAttributesAndDescendants</a></td><td>
Gets a list of Attribute objects that are inherited from base classes. The List will also contain the elements own Attribute objects, if the parameter is set (default). If an Attribute is overwritten, only the last defined is contained.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass">ObjectWithBaseClass</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_GetParent__1">GetParent(T)</a></td><td>
Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass_InheritedElements__1">InheritedElements(TInheritedElement)</a></td><td>
Gets a collection of objects of the defined InheritedElement-Type that are inherited from base classes.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass">ObjectWithBaseClass</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions_Insert_Attribute">Insert_Attribute</a></td><td>
Inserts an Attribute object in the Attribute collection of the *objectWithAttributes*.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions">SystemUnitClassTypeExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_IsAMLObject">IsAMLObject</a></td><td>
Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface.
 (Defined by <a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass_IsInherited">IsInherited</a></td><td>
Determines, if the specified element is an inherited element. To be an inherited element, it has to be an AttributeType, ExternalInterfaceType or InternalElementType element.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass">ObjectWithBaseClass</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass_IsOverridden">IsOverridden</a></td><td>
Determines, if an element of a class with an inheritance relation to a base class is an overridden element, what means a base class contains an element which is considered as equal to the provided element. In most cases, equality is defined by equality of the element names.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass">ObjectWithBaseClass</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_Library">Library</a></td><td>
Gets the Library which contains this CAEX object.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_New_Attribute">New_Attribute</a></td><td>
Appends a new Attribute object with the defined name to the specified CAEX object.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithAttributes">ObjectWithAttributes</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_New_Copyright">New_Copyright</a></td><td>
Adds an new Copyright node to this object if it doesn't exists.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_New_FrameAttribute">New_FrameAttribute</a></td><td>
Creates a new Frame attribute for the <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">IObjectWithAttributes</a> if no Frame attribute exists. The provided values are used to initialize the Frame attribute values.
 (Defined by <a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_New_Version">New_Version</a></td><td>
Adds an new Version node to this object if it doesn't exists.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass_OverriddenElement">OverriddenElement</a></td><td>
Determines, if an element of a class with an inheritance relation to a base class has an overridden element with the specified name and type, what means a base class contains an element which name is equal to the provided elementName.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass">ObjectWithBaseClass</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass_ReferencedClassName">ReferencedClassName</a></td><td>
Name of the referenced Class without path information.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass">ObjectWithBaseClass</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_RefTypeAttribute">RefTypeAttribute</a></td><td>
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
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_ObjectWithAttributes">ObjectWithAttributes</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXObjectExtensions_SetDescription">SetDescription</a></td><td>
This method sets a description. If no description exists, it is created.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXObjectExtensions">CAEXObjectExtensions</a>.)</td></tr></table>&nbsp;
<a href="#iclasswithbaseclassreference(*t*)-interface">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br /><a href="T_Aml_Engine_CAEX_ICAEXWrapper">Aml.Engine.CAEX.ICAEXWrapper</a><br />