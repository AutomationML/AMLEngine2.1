# FacetAttributeSequence Methods
AutomationML 2.1 API 

The <a href="T_Aml_Engine_AmlObjects_FacetAttributeSequence">FacetAttributeSequence</a> type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_AmlObjects_FacetAttributeSequence_Append">Append()</a></td><td>
This method is not applicable if the owner is an <a href="T_Aml_Engine_AmlObjects_AMLFacet">AMLFacet</a>.
 (Overrides <a href="M_Aml_Engine_CAEX_CAEXSequence_1_Append">CAEXSequence(T).Append()</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_AmlObjects_FacetAttributeSequence_Append_1">Append(String)</a></td><td>
Appends a new Attribute with the provided name to the sequence of Attributes, if the conditions for Facet Attributes are fulfilled. Facet Attributes are a subset of Attributes which are defined for the Parent object of an <a href="T_Aml_Engine_AmlObjects_AMLFacet">AMLFacet</a>. An Attribute with the specified name can only be added as a Facet Attribute, if the Facets parent has an identical Attribute with that name and the Attribute has not been associated to the Facet before.
 (Overrides <a href="M_Aml_Engine_CAEX_CAEXSequenceOfCAEXObjects_1_Append">CAEXSequenceOfCAEXObjects(T).Append(String)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_Append_1">Append(ValueTuple(String, Object)[])</a></td><td>
Creates a new CAEX object and appends it to already existing elements. The content of the new element can be optionally defined using an array of tuples defining attribute names and their values.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_At">At</a></td><td>
Gets the CAEX object at the specified index.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_AttributeSequence_GetCAEXAttribute">GetCAEXAttribute</a></td><td>
Gets the CAEX attribute with the provided attribute path from the Attribute sequence. This method can be used to direct access a nested attribute using the complete attribute path. The Path root should be the top level attribute.
 (Inherited from <a href="T_Aml_Engine_CAEX_AttributeSequence">AttributeSequence</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_GetEnumerator">GetEnumerator</a></td><td>
Gets the enumerator for this sequence.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_IndexOf">IndexOf</a></td><td>
Gets the Index of the specified CAEX object in this sequence of elements.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_AmlObjects_FacetAttributeSequence_Insert">Insert</a></td><td>
Inserts the specified attribute into this sequence. Before the attribute is inserted, it is checked, if it is a valid Facet attribute.
 (Overrides <a href="M_Aml_Engine_CAEX_CAEXSequenceOfCAEXObjects_1_Insert">CAEXSequenceOfCAEXObjects(T).Insert(T, Boolean)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_InsertAt">InsertAt</a></td><td>
Inserts the specified CAEX object into this sequence at the defined index.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_Move">Move</a></td><td>
Moves the CAEX object at the specified index to a new location in the collection.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_AmlObjects_FacetAttributeSequence_Prepend">Prepend()</a></td><td>
This method is not applicable for Facet attributes.
 (Overrides <a href="M_Aml_Engine_CAEX_CAEXSequence_1_Prepend">CAEXSequence(T).Prepend()</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_Prepend_1">Prepend(ValueTuple(String, Object)[])</a></td><td>
Creates a new CAEX object and prepends it to already existing elements. The content of the new element can be defined using an array of tuples defining attribute names and their values.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequenceOfCAEXObjects_1_Prepend">Prepend(String)</a></td><td>
Creates a new CAEX object with the specified name and prepends it to the sequence.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequenceOfCAEXObjects_1">CAEXSequenceOfCAEXObjects(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_NamedElementSequence_1_Remove">Remove</a></td><td>
Removes all CAEX objects from this sequence.
 (Inherited from <a href="T_Aml_Engine_CAEX_NamedElementSequence_1">NamedElementSequence(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_NamedElementSequence_1_RemoveAt">RemoveAt</a></td><td>
Removes the element at the given index.
 (Inherited from <a href="T_Aml_Engine_CAEX_NamedElementSequence_1">NamedElementSequence(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_RemoveElement">RemoveElement</a></td><td>
Removes the provided CAEX object from this sequence.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr></table>&nbsp;
<a href="#facetattributesequence-methods">Back to Top</a>

## Explicit Interface Implementations
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td><a href="M_Aml_Engine_CAEX_NamedElementSequence_1_System_Collections_IEnumerable_GetEnumerator">IEnumerable.GetEnumerator</a></td><td> (Inherited from <a href="T_Aml_Engine_CAEX_NamedElementSequence_1">NamedElementSequence(T)</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_Aml_Engine_CAEX_ICAEXSequence_Append">ICAEXSequence.Append()</a></td><td>
Creates a new CAEX object and appends it to already existing elements in this sequence.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_Aml_Engine_CAEX_ICAEXSequence_Append_1">ICAEXSequence.Append(ValueTuple(String, Object)[])</a></td><td>
Creates a new CAEX object and appends it to already existing elements. The content of the new element can be optionally defined using an array of tuples defining attribute names and their values.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_Aml_Engine_CAEX_ICAEXSequence_At">ICAEXSequence.At</a></td><td>
Gets the CAEX object at the specified index.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_Aml_Engine_CAEX_ICAEXSequence_GetEnumerator">ICAEXSequence.GetEnumerator</a></td><td>
Gets the enumerator for this sequence.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_Aml_Engine_CAEX_ICAEXSequence_IndexOf">ICAEXSequence.IndexOf</a></td><td>
Gets the Index of the specified CAEX object in this sequence of elements.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_Aml_Engine_CAEX_ICAEXSequence_Insert">ICAEXSequence.Insert</a></td><td>
Inserts the specified CAEX object into this sequence. If no position is specified the element is appended. If 'asFirst' is set to `true`, the element is prepended to already existing ones.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_Aml_Engine_CAEX_ICAEXSequence_InsertAt">ICAEXSequence.InsertAt</a></td><td>
Inserts the specified CAEX object into this sequence at the defined index.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_Aml_Engine_CAEX_ICAEXSequence_Prepend">ICAEXSequence.Prepend()</a></td><td>
Creates a new CAEX object and prepends it to already existing elements.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_Aml_Engine_CAEX_ICAEXSequence_Prepend_1">ICAEXSequence.Prepend(ValueTuple(String, Object)[])</a></td><td>
Creates a new CAEX object and prepends it to already existing elements. The content of the new element can be defined using an array of tuples defining attribute names and their values.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_Aml_Engine_CAEX_ICAEXSequence_RemoveElement">ICAEXSequence.RemoveElement</a></td><td>
Removes the provided CAEX object from this sequence.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr></table>&nbsp;
<a href="#facetattributesequence-methods">Back to Top</a>

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_FacetAttributeSequence">FacetAttributeSequence Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />