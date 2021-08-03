# FacetAttributeSequence.Append Method 
AutomationML 2.1 API 


## Overload List
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_AmlObjects_FacetAttributeSequence_Append">Append()</a></td><td>
This method is not applicable if the owner is an <a href="T_Aml_Engine_AmlObjects_AMLFacet">AMLFacet</a>.
 (Overrides <a href="M_Aml_Engine_CAEX_CAEXSequence_1_Append">CAEXSequence(T).Append()</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_AmlObjects_FacetAttributeSequence_Append_1">Append(String)</a></td><td>
Appends a new Attribute with the provided name to the sequence of Attributes, if the conditions for Facet Attributes are fulfilled. Facet Attributes are a subset of Attributes which are defined for the Parent object of an <a href="T_Aml_Engine_AmlObjects_AMLFacet">AMLFacet</a>. An Attribute with the specified name can only be added as a Facet Attribute, if the Facets parent has an identical Attribute with that name and the Attribute has not been associated to the Facet before.
 (Overrides <a href="M_Aml_Engine_CAEX_CAEXSequenceOfCAEXObjects_1_Append">CAEXSequenceOfCAEXObjects(T).Append(String)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_Append_1">Append(ValueTuple(String, Object)[])</a></td><td>
Creates a new CAEX object and appends it to already existing elements. The content of the new element can be optionally defined using an array of tuples defining attribute names and their values.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr></table>&nbsp;
<a href="#facetattributesequence.append-method">Back to Top</a>

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_FacetAttributeSequence">FacetAttributeSequence Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />