# IObjectWithRoleReference Interface
AutomationML 2.1 API 

This Interface is implemented by <a href="T_Aml_Engine_CAEX_RoleRequirementsType">RoleRequirementsType</a> and <a href="T_Aml_Engine_CAEX_SupportedRoleClassType">SupportedRoleClassType</a>.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public interface IObjectWithRoleReference : ICAEXWrapper, 
	IXMLWrapper
```

**VB**<br />
``` VB
Public Interface IObjectWithRoleReference
	Inherits ICAEXWrapper, IXMLWrapper
```

**C++**<br />
``` C++
public interface class IObjectWithRoleReference : ICAEXWrapper, 
	IXMLWrapper
```

The IObjectWithRoleReference type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_ICAEXWrapper_CAEXParent">CAEXParent</a></td><td>
Gets the CAEXParent of this CAEX object
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXWrapper">ICAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_XML_IXMLWrapper_Document">Document</a></td><td>
Gets the XDocument containing the XML node of this object. If the object has not been inserted into a document, the XDocument is `null`. Direct manipulations of the XML document are not monitored by the AML engine.
 (Inherited from <a href="T_Aml_Engine_XML_IXMLWrapper">IXMLWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_XML_IXMLWrapper_Exists">Exists</a></td><td>
Determines, if this instance is wrapped around an existing XML node
 (Inherited from <a href="T_Aml_Engine_XML_IXMLWrapper">IXMLWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_XML_IXMLWrapper_Node">Node</a></td><td>
Get the XML node of this instance. Direct manipulations of the XML node are not monitored by the AML engine.
 (Inherited from <a href="T_Aml_Engine_XML_IXMLWrapper">IXMLWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_XML_IXMLWrapper_Owner">Owner</a></td><td>
Gets the XML parent node of this instance. Direct manipulations of the XML node are not monitored by the AML engine.
 (Inherited from <a href="T_Aml_Engine_XML_IXMLWrapper">IXMLWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_IObjectWithRoleReference_RoleClass">RoleClass</a></td><td>
Gets and sets the referenced role class</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_IObjectWithRoleReference_RoleReference">RoleReference</a></td><td>
Gets and sets the role reference attribute</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_XML_IXMLWrapper_TagName">TagName</a></td><td>
Gets the Schema Tag name of this instance.
 (Inherited from <a href="T_Aml_Engine_XML_IXMLWrapper">IXMLWrapper</a>.)</td></tr></table>&nbsp;
<a href="#iobjectwithrolereference-interface">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ICAEXWrapper_CAEXChild">CAEXChild</a></td><td>
Gets the first child of this CAEX object with the defined CAEX tag name.
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXWrapper">ICAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ICAEXWrapper_CAEXChildren">CAEXChildren</a></td><td>
Gets all children of this CAEX object with the defined CAEX tag name.
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXWrapper">ICAEXWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ICAEXWrapper_Remove">Remove</a></td><td>
Removes this object
 (Inherited from <a href="T_Aml_Engine_CAEX_ICAEXWrapper">ICAEXWrapper</a>.)</td></tr></table>&nbsp;
<a href="#iobjectwithrolereference-interface">Back to Top</a>

## Extension Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_AMLSchemaManager">AMLSchemaManager</a></td><td>
Gets the associated CAEX schema manager of the CAEX object.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_Ancestors__1">Ancestors(T)</a></td><td>
Finds the ancestors of the provided CAEX object which have the given type.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_CAEXDocument">CAEXDocument</a></td><td>
Gets the CAEX document which contains this CAEX object.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_CAEXFile">CAEXFile</a></td><td>
Gets the CAEX file which contains this CAEX object.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_CAEXSchema">CAEXSchema</a></td><td>
Gets the associated CAEX schema of the CAEX object.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_Descendants__1_1">Descendants(T)</a></td><td>
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
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_GetParent__1">GetParent(T)</a></td><td>
Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_IsAMLObject">IsAMLObject</a></td><td>
Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface.
 (Defined by <a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_IsAutomationMLBaseRole">IsAutomationMLBaseRole</a></td><td>
Determines whether the specified role reference defines an inheritance relation from the AutomationMLBaseRole RoleClass
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_InheritanceExtensions_IsDerivedFromRoleClass">IsDerivedFromRoleClass</a></td><td>
Determines whether the specified role reference defines an inheritance relation from the role, uniquely identifiable by the given role class path. The role class path may contain an alias.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_InheritanceExtensions">InheritanceExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_IsFacet">IsFacet</a></td><td>
Determines whether the specified role reference defines an inheritance relation from the Facet RoleClass
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_IsFrame">IsFrame</a></td><td>
Determines whether the specified role reference defines an inheritance relation from the Frame RoleClass
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_IsGroup">IsGroup</a></td><td>
Determines whether the specified role reference defines an inheritance relation from the Group RoleClass
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_IsInterlockingSourceGroup">IsInterlockingSourceGroup</a></td><td>
Determines whether the specified role reference defines an inheritance relation from the InterlockingSourceGroup RoleClass
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_IsInterlockingTargetGroup">IsInterlockingTargetGroup</a></td><td>
Determines whether the specified role reference defines an inheritance relation from the InterlockingTargetGroup RoleClass
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_IsLogicObject">IsLogicObject</a></td><td>
Determines whether the specified role reference defines an inheritance relation from the LogicObject RoleClass
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_IsPort">IsPort</a></td><td>
Determines whether the specified role reference defines an inheritance relation from the Port RoleClass
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_IsProcess">IsProcess</a></td><td>
Determines whether the specified role reference defines an inheritance relation from the Process RoleClass
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_IsProcessStructure">IsProcessStructure</a></td><td>
Determines whether the specified role reference defines an inheritance relation from the ProcessStructure RoleClass
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_IsProduct">IsProduct</a></td><td>
Determines whether the specified role reference defines an inheritance relation from the Product RoleClass
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_IsProductStructure">IsProductStructure</a></td><td>
Determines whether the specified role reference defines an inheritance relation from the ProductStructure RoleClass
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_IsPropertySet">IsPropertySet</a></td><td>
Determines whether the specified role reference defines an inheritance relation from the PropertySet RoleClass
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_IsResource">IsResource</a></td><td>
Determines whether the specified role reference defines an inheritance relation from the Resource RoleClass
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_IsResourceStructure">IsResourceStructure</a></td><td>
Determines whether the specified role reference defines an inheritance relation from the ResourceStructure RoleClass
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_IsStructure">IsStructure</a></td><td>
Determines whether the specified role reference defines an inheritance relation from the Structure RoleClass
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_Library">Library</a></td><td>
Gets the Library which contains this CAEX object.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_MakeAutomationMLBaseRole">MakeAutomationMLBaseRole</a></td><td>
Makes the AutomationML base role.
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_MakeFacet">MakeFacet</a></td><td>
Makes the facet.
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_MakeGroup">MakeGroup</a></td><td>
Makes the group.
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_MakePort">MakePort</a></td><td>
Makes the port.
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_MakeProcess">MakeProcess</a></td><td>
Makes the process.
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_MakeProcessStructure">MakeProcessStructure</a></td><td>
Makes the process structure.
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_MakeProduct">MakeProduct</a></td><td>
Makes the Product.
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_MakeProductStructure">MakeProductStructure</a></td><td>
Makes the product structure.
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_MakePropertySet">MakePropertySet</a></td><td>
Makes the property set.
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_MakeResource">MakeResource</a></td><td>
Makes the resource.
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_MakeResourceStructure">MakeResourceStructure</a></td><td>
Makes the resource structure.
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib_MakeStructure">MakeStructure</a></td><td>
Makes the structure.
 (Defined by <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>.)</td></tr></table>&nbsp;
<a href="#iobjectwithrolereference-interface">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br /><a href="T_Aml_Engine_CAEX_ICAEXWrapper">Aml.Engine.CAEX.ICAEXWrapper</a><br />