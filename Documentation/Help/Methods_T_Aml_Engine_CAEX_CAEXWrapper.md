# CAEXWrapper Methods
AutomationML 2.1 API 

The <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a> type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_CAEXChild">CAEXChild</a></td><td>
Gets the first child of this CAEX object with the defined CAEX tag name.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_CAEXChildren">CAEXChildren</a></td><td>
Gets all children of this CAEX object with the defined CAEX tag name.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_Copy">Copy</a></td><td>
Creates a deep copy of this CAEX object</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_Equals">Equals</a></td><td>
Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements.
 (Overrides <a href="https://docs.microsoft.com/dotnet/api/system.object.equals#System_Object_Equals_System_Object_" target="_parent" rel="noopener noreferrer">Object.Equals(Object)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_GetHashCode">GetHashCode</a></td><td>
Gets the Hash code for this instance, using the wrapped XML element.
 (Overrides <a href="https://docs.microsoft.com/dotnet/api/system.object.gethashcode#System_Object_GetHashCode" target="_parent" rel="noopener noreferrer">Object.GetHashCode()</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_GetXAttributeValue">GetXAttributeValue</a></td><td>
Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_InsertNew">InsertNew</a></td><td>
This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an <a href="P_Aml_Engine_CAEX_CAEXWrapper_Owner">Owner</a> is defined. The new created CAEX object is inserted as a new child of the owner.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_Remove">Remove</a></td><td>
Removes this element. After that it is no longer assigned to a document and has no owner anymore.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXWrapper_SetXAttributeValue">SetXAttributeValue</a></td><td>
Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null).</td></tr></table>&nbsp;
<a href="#caexwrapper-methods">Back to Top</a>

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
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_Descendants">Descendants(Type)</a></td><td>Overloaded.  
Finds the descendants of the provided CAEX object which are of the given type.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_Descendants__1">Descendants(T)()</a></td><td>Overloaded.  
Finds the descendants of the provided CAEX object which are of the given type.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_Descendants__1_1">Descendants(T)(Boolean)</a></td><td>Overloaded.  
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
 (Defined by <a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_Library">Library</a></td><td>
Gets the Library which contains this CAEX object.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_Name">Name</a></td><td>
Gets a names for the specified caex wrapper object. If the specified object is a <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>, the Name is returned; otherwise the TagName of the CAEX item.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions</a>.)</td></tr></table>&nbsp;
<a href="#caexwrapper-methods">Back to Top</a>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />