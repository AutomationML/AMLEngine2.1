# ICAEXSequence Interface
AutomationML 2.1 API 

This interface defines a sequence of CAEX elements.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public interface ICAEXSequence
```

**VB**<br />
``` VB
Public Interface ICAEXSequence
```

**C++**<br />
``` C++
public interface class ICAEXSequence
```

The ICAEXSequence type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_ICAEXSequence_First">First</a></td><td>
Gets a wrapper for the first CAEX element in this sequence, if the sequence contains no elements `null` is returned.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_ICAEXSequence_Item">Item(Int32)</a></td><td>
Gets a wrapper for the CAEX element in this sequence at the given position</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_ICAEXSequence_Item_1">Item(ValueTuple(String, String))</a></td><td>
Gets the first CAEX object with a specific attribute value from the sequence of elements</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_ICAEXSequence_Last">Last</a></td><td>
Gets a wrapper for the last CAEX element in this sequence, if the sequence contains no elements `null` is returned.</td></tr></table>&nbsp;
<a href="#icaexsequence-interface">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ICAEXSequence_Append">Append()</a></td><td>
Creates a new CAEX object and appends it to already existing elements in this sequence.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Aml_Engine_CAEX_ICAEXSequence_Append_1">Append(ValueTuple(String, Object)[])</a></td><td>
Creates a new CAEX object and appends it to already existing elements. The content of the new element can be optionally defined using an array of tuples defining attribute names and their values.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ICAEXSequence_At">At</a></td><td>
Gets the CAEX object at the specified index.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ICAEXSequence_GetEnumerator">GetEnumerator</a></td><td>
Gets the enumerator for this sequence.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ICAEXSequence_IndexOf">IndexOf</a></td><td>
Gets the Index of the specified CAEX object in this sequence of elements.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ICAEXSequence_Insert">Insert</a></td><td>
Inserts the specified CAEX object into this sequence. If no position is specified the element is appended. If 'asFirst' is set to `true`, the element is prepended to already existing ones.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ICAEXSequence_InsertAt">InsertAt</a></td><td>
Inserts the specified CAEX object into this sequence at the defined index.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ICAEXSequence_Move">Move</a></td><td>
Moves the CAEX object at the specified index to a new location in the collection.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ICAEXSequence_Prepend">Prepend()</a></td><td>
Creates a new CAEX object and prepends it to already existing elements.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ICAEXSequence_Prepend_1">Prepend(ValueTuple(String, Object)[])</a></td><td>
Creates a new CAEX object and prepends it to already existing elements. The content of the new element can be defined using an array of tuples defining attribute names and their values.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_ICAEXSequence_RemoveElement">RemoveElement</a></td><td>
Removes the provided CAEX object from this sequence.</td></tr></table>&nbsp;
<a href="#icaexsequence-interface">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />