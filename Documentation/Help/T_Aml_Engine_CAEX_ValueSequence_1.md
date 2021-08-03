# ValueSequence(*TDataType*) Class
AutomationML 2.1 API 

This class implements methods to work with a sequence of CAEX elements and indexed access to their values.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;<a href="T_Aml_Engine_CAEX_NamedElementSequence_1">Aml.Engine.CAEX.NamedElementSequence</a>(*TDataType*)<br />&nbsp;&nbsp;&nbsp;&nbsp;Aml.Engine.CAEX.ValueSequence(TDataType)<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class ValueSequence<TDataType> : NamedElementSequence<TDataType>

```

**VB**<br />
``` VB
Public Class ValueSequence(Of TDataType)
	Inherits NamedElementSequence(Of TDataType)
```

**C++**<br />
``` C++
generic<typename TDataType>
public ref class ValueSequence : public NamedElementSequence<TDataType>
```


#### Type Parameters
&nbsp;<dl><dt>TDataType</dt><dd>The Value type</dd></dl>&nbsp;
The ValueSequence(TDataType) type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ValueSequence_1__ctor">ValueSequence(TDataType)(XElement, String)</a></td><td>
Creates a new instance of the ValueSequence for the specified owner and the specified name which has to be a valid name for child elements, which can be filtered out from the owner by this name.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ValueSequence_1__ctor_1">ValueSequence(TDataType)(XElement, String, Predicate(XElement))</a></td><td>
Creates a new instance of the ValueSequence for the specified owner and the specified name which has to be a valid name for child elements, which can be filtered out from the owner by this name. The specified condition is used as an additional filter criteria.</td></tr></table>&nbsp;
<a href="#valuesequence(*tdatatype*)-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_NamedElementSequence_1_CAEXOwner">CAEXOwner</a></td><td>
Gets the CAEX owner of this sequence
 (Inherited from <a href="T_Aml_Engine_CAEX_NamedElementSequence_1">NamedElementSequence(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_NamedElementSequence_1_Count">Count</a></td><td>
Gets the number of elements in this sequence
 (Inherited from <a href="T_Aml_Engine_CAEX_NamedElementSequence_1">NamedElementSequence(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_ValueSequence_1_ElementAndValues">ElementAndValues</a></td><td>
Gets the collection of Xml-Elements and their associated Values in this ValueSequence.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_NamedElementSequence_1_ElementName">ElementName</a></td><td>
Gets the name of the elements in this sequence
 (Inherited from <a href="T_Aml_Engine_CAEX_NamedElementSequence_1">NamedElementSequence(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_NamedElementSequence_1_Elements">Elements</a></td><td>
Gets a list of unwrapped CAEX elements (XElements) of this sequence
 (Inherited from <a href="T_Aml_Engine_CAEX_NamedElementSequence_1">NamedElementSequence(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_NamedElementSequence_1_Exists">Exists</a></td><td>
Determines, if the sequence contains any element
 (Inherited from <a href="T_Aml_Engine_CAEX_NamedElementSequence_1">NamedElementSequence(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_ValueSequence_1_Item">Item</a></td><td>
Gets the value of the CAEX object in this sequence at the given position
 (Overrides <a href="P_Aml_Engine_CAEX_NamedElementSequence_1_Item">NamedElementSequence(T).Item(Int32)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_NamedElementSequence_1_Owner">Owner</a></td><td>
Gets the owner of this sequence
 (Inherited from <a href="T_Aml_Engine_CAEX_NamedElementSequence_1">NamedElementSequence(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_ValueSequence_1_ValueConverter">ValueConverter</a></td><td>
The value converter</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_ValueSequence_1_Values">Values</a></td><td>
Gets a collection of values of the CAEX elements of this sequence</td></tr></table>&nbsp;
<a href="#valuesequence(*tdatatype*)-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ValueSequence_1_Append">Append</a></td><td>
Creates a new CAEX object and appends it to the value sequence. The value of the appended object is set to the provided value.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ValueSequence_1_At">At</a></td><td>
Gets the value from the element at the specified index.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ValueSequence_1_GetEnumerator">GetEnumerator</a></td><td>
Gets the enumerator for this sequence which enumerates the <a href="P_Aml_Engine_CAEX_ValueSequence_1_Values">Values</a>.
 (Overrides <a href="M_Aml_Engine_CAEX_NamedElementSequence_1_GetEnumerator">NamedElementSequence(T).GetEnumerator()</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ValueSequence_1_IndexOf">IndexOf</a></td><td>
Gets the Index of the specified element in the sequence of elements with the same name</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ValueSequence_1_Prepend">Prepend</a></td><td>
Creates a new CAEX object with the provided value and prepends it to already existing elements.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_NamedElementSequence_1_Remove">Remove</a></td><td>
Removes all CAEX objects from this sequence.
 (Inherited from <a href="T_Aml_Engine_CAEX_NamedElementSequence_1">NamedElementSequence(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_NamedElementSequence_1_RemoveAt">RemoveAt</a></td><td>
Removes the element at the given index.
 (Inherited from <a href="T_Aml_Engine_CAEX_NamedElementSequence_1">NamedElementSequence(T)</a>.)</td></tr></table>&nbsp;
<a href="#valuesequence(*tdatatype*)-class">Back to Top</a>

## Explicit Interface Implementations
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td><a href="M_Aml_Engine_CAEX_NamedElementSequence_1_System_Collections_IEnumerable_GetEnumerator">IEnumerable.GetEnumerator</a></td><td> (Inherited from <a href="T_Aml_Engine_CAEX_NamedElementSequence_1">NamedElementSequence(T)</a>.)</td></tr></table>&nbsp;
<a href="#valuesequence(*tdatatype*)-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br /><a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">System.Collections.Generic.IEnumerable(T)</a><br />