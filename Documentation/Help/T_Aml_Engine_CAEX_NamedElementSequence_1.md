# NamedElementSequence(*T*) Class
AutomationML 2.1 API 

A Sequence of XML elements related to a specific element name. An XML element may contain different NamedElementSequences with different names.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.CAEX.NamedElementSequence(T)<br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Aml_Engine_CAEX_CAEXSequence_1">Aml.Engine.CAEX.CAEXSequence(T)</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Aml_Engine_CAEX_ValueSequence_1">Aml.Engine.CAEX.ValueSequence(TDataType)</a><br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public abstract class NamedElementSequence<T> : IEnumerable<T>, 
	IEnumerable

```

**VB**<br />
``` VB
Public MustInherit Class NamedElementSequence(Of T)
	Implements IEnumerable(Of T), IEnumerable
```

**C++**<br />
``` C++
generic<typename T>
public ref class NamedElementSequence abstract : IEnumerable<T>, 
	IEnumerable
```


#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>\[Missing <typeparam name="T"/> documentation for "T:Aml.Engine.CAEX.NamedElementSequence`1"\]</dd></dl>&nbsp;
The NamedElementSequence(T) type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_NamedElementSequence_1_CAEXOwner">CAEXOwner</a></td><td>
Gets the CAEX owner of this sequence</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_NamedElementSequence_1_Count">Count</a></td><td>
Gets the number of elements in this sequence</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_NamedElementSequence_1_ElementName">ElementName</a></td><td>
Gets the name of the elements in this sequence</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_NamedElementSequence_1_Elements">Elements</a></td><td>
Gets a list of unwrapped CAEX elements (XElements) of this sequence</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_NamedElementSequence_1_Exists">Exists</a></td><td>
Determines, if the sequence contains any element</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_NamedElementSequence_1_Item">Item</a></td><td>
Gets or sets the value at the specified index.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_NamedElementSequence_1_Owner">Owner</a></td><td>
Gets the owner of this sequence</td></tr></table>&nbsp;
<a href="#namedelementsequence(*t*)-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_NamedElementSequence_1_GetEnumerator">GetEnumerator</a></td><td>
Returns an enumerator that iterates through the collection.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_NamedElementSequence_1_Remove">Remove</a></td><td>
Removes all CAEX objects from this sequence.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_NamedElementSequence_1_RemoveAt">RemoveAt</a></td><td>
Removes the element at the given index.</td></tr></table>&nbsp;
<a href="#namedelementsequence(*t*)-class">Back to Top</a>

## Explicit Interface Implementations
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td><a href="M_Aml_Engine_CAEX_NamedElementSequence_1_System_Collections_IEnumerable_GetEnumerator">IEnumerable.GetEnumerator</a></td><td /></tr></table>&nbsp;
<a href="#namedelementsequence(*t*)-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />