# FacetAttributeSequence Class
AutomationML 2.1 API 

This class defines a sequence of Attributes which belong to an <a href="T_Aml_Engine_AmlObjects_AMLFacet">AMLFacet</a>. A Facet attribute shall be related to an existing attribute of the parent AML object, the identifier is the same name. Facet attributes which are not part of the parent object are not permitted. [IEC 62714-1:2014 8.3 (p.43)]


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;<a href="T_Aml_Engine_CAEX_NamedElementSequence_1">Aml.Engine.CAEX.NamedElementSequence</a>(<a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>)<br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Aml_Engine_CAEX_CAEXSequence_1">Aml.Engine.CAEX.CAEXSequence</a>(<a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>)<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Aml_Engine_CAEX_CAEXSequenceOfCAEXObjects_1">Aml.Engine.CAEX.CAEXSequenceOfCAEXObjects</a>(<a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>)<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Aml_Engine_CAEX_AttributeSequence">Aml.Engine.CAEX.AttributeSequence</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Aml.Engine.AmlObjects.FacetAttributeSequence<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class FacetAttributeSequence : AttributeSequence
```

**VB**<br />
``` VB
Public Class FacetAttributeSequence
	Inherits AttributeSequence
```

**C++**<br />
``` C++
public ref class FacetAttributeSequence : public AttributeSequence
```

The FacetAttributeSequence type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_AmlObjects_FacetAttributeSequence__ctor">FacetAttributeSequence</a></td><td>
Initializes a new instance of the FacetAttributeSequence class.</td></tr></table>&nbsp;
<a href="#facetattributesequence-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_NamedElementSequence_1_CAEXOwner">CAEXOwner</a></td><td>
Gets the CAEX owner of this sequence
 (Inherited from <a href="T_Aml_Engine_CAEX_NamedElementSequence_1">NamedElementSequence(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_NamedElementSequence_1_Count">Count</a></td><td>
Gets the number of elements in this sequence
 (Inherited from <a href="T_Aml_Engine_CAEX_NamedElementSequence_1">NamedElementSequence(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_NamedElementSequence_1_ElementName">ElementName</a></td><td>
Gets the name of the elements in this sequence
 (Inherited from <a href="T_Aml_Engine_CAEX_NamedElementSequence_1">NamedElementSequence(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_NamedElementSequence_1_Elements">Elements</a></td><td>
Gets a list of unwrapped CAEX elements (XElements) of this sequence
 (Inherited from <a href="T_Aml_Engine_CAEX_NamedElementSequence_1">NamedElementSequence(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_NamedElementSequence_1_Exists">Exists</a></td><td>
Determines, if the sequence contains any element
 (Inherited from <a href="T_Aml_Engine_CAEX_NamedElementSequence_1">NamedElementSequence(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXSequence_1_First">First</a></td><td>
Gets a wrapper for the first CAEX element in this sequence, if the sequence contains no elements `null` is returned.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXSequence_1_Item">Item(Int32)</a></td><td>
Gets a wrapper for the CAEX element in this sequence at the given position
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXSequence_1_Item_1">Item(ValueTuple(String, String))</a></td><td>
Gets the first CAEX object with a specific attribute value from the sequence of elements
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXSequenceOfCAEXObjects_1_Item">Item(String)</a></td><td>
Gets the first CAEX object with this name from the sequence of elements.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequenceOfCAEXObjects_1">CAEXSequenceOfCAEXObjects(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXSequenceOfCAEXObjects_1_Item_1">Item(String[])</a></td><td>
Gets the CAEX object which can be identified with a CAEX path, where the path parts are defined in the provided array of names.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequenceOfCAEXObjects_1">CAEXSequenceOfCAEXObjects(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXSequence_1_Last">Last</a></td><td>
Gets a wrapper for the last CAEX element in this sequence, if the sequence contains no elements `null` is returned.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_NamedElementSequence_1_Owner">Owner</a></td><td>
Gets the owner of this sequence
 (Inherited from <a href="T_Aml_Engine_CAEX_NamedElementSequence_1">NamedElementSequence(T)</a>.)</td></tr></table>&nbsp;
<a href="#facetattributesequence-class">Back to Top</a>

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
<a href="#facetattributesequence-class">Back to Top</a>

## Explicit Interface Implementations
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td><a href="M_Aml_Engine_CAEX_NamedElementSequence_1_System_Collections_IEnumerable_GetEnumerator">IEnumerable.GetEnumerator</a></td><td> (Inherited from <a href="T_Aml_Engine_CAEX_NamedElementSequence_1">NamedElementSequence(T)</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_Aml_Engine_CAEX_ICAEXSequence_Append">ICAEXSequence.Append()</a></td><td>
Creates a new CAEX object and appends it to already existing elements in this sequence.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_Aml_Engine_CAEX_ICAEXSequence_Append_1">ICAEXSequence.Append(ValueTuple(String, Object)[])</a></td><td>
Creates a new CAEX object and appends it to already existing elements. The content of the new element can be optionally defined using an array of tuples defining attribute names and their values.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_Aml_Engine_CAEX_ICAEXSequence_At">ICAEXSequence.At</a></td><td>
Gets the CAEX object at the specified index.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private property](media/privproperty.gif "Private property")</td><td><a href="P_Aml_Engine_CAEX_CAEXSequence_1_Aml_Engine_CAEX_ICAEXSequence_First">ICAEXSequence.First</a></td><td>
Gets a wrapper for the first CAEX element in this sequence, if the sequence contains no elements `null` is returned.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_Aml_Engine_CAEX_ICAEXSequence_GetEnumerator">ICAEXSequence.GetEnumerator</a></td><td>
Gets the enumerator for this sequence.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_Aml_Engine_CAEX_ICAEXSequence_IndexOf">ICAEXSequence.IndexOf</a></td><td>
Gets the Index of the specified CAEX object in this sequence of elements.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_Aml_Engine_CAEX_ICAEXSequence_Insert">ICAEXSequence.Insert</a></td><td>
Inserts the specified CAEX object into this sequence. If no position is specified the element is appended. If 'asFirst' is set to `true`, the element is prepended to already existing ones.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_Aml_Engine_CAEX_ICAEXSequence_InsertAt">ICAEXSequence.InsertAt</a></td><td>
Inserts the specified CAEX object into this sequence at the defined index.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private property](media/privproperty.gif "Private property")</td><td><a href="P_Aml_Engine_CAEX_CAEXSequence_1_Aml_Engine_CAEX_ICAEXSequence_Item">ICAEXSequence.Item(Int32)</a></td><td>
Gets a wrapper for the CAEX element in this sequence at the given position
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private property](media/privproperty.gif "Private property")</td><td><a href="P_Aml_Engine_CAEX_CAEXSequence_1_Aml_Engine_CAEX_ICAEXSequence_Item_1">ICAEXSequence.Item(ValueTuple(String, String))</a></td><td>
Gets the first CAEX object with a specific attribute value from the sequence of elements
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private property](media/privproperty.gif "Private property")</td><td><a href="P_Aml_Engine_CAEX_CAEXSequence_1_Aml_Engine_CAEX_ICAEXSequence_Last">ICAEXSequence.Last</a></td><td>
Gets a wrapper for the last CAEX element in this sequence, if the sequence contains no elements `null` is returned.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_Aml_Engine_CAEX_ICAEXSequence_Prepend">ICAEXSequence.Prepend()</a></td><td>
Creates a new CAEX object and prepends it to already existing elements.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_Aml_Engine_CAEX_ICAEXSequence_Prepend_1">ICAEXSequence.Prepend(ValueTuple(String, Object)[])</a></td><td>
Creates a new CAEX object and prepends it to already existing elements. The content of the new element can be defined using an array of tuples defining attribute names and their values.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequence_1_Aml_Engine_CAEX_ICAEXSequence_RemoveElement">ICAEXSequence.RemoveElement</a></td><td>
Removes the provided CAEX object from this sequence.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T)</a>.)</td></tr></table>&nbsp;
<a href="#facetattributesequence-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br /><a href="T_Aml_Engine_CAEX_AttributeSequence">Aml.Engine.CAEX.AttributeSequence</a><br />