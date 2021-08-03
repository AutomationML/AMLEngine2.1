# CAEXEnumerable(*T*) Class
AutomationML 2.1 API 

This class implements a specific enumeration type which wraps an XElement with a CAEXWrapper during enumeration. The enumerator for this class is <a href="T_Aml_Engine_CAEX_CAEXSequenceEnumerator_1">CAEXSequenceEnumerator(T)</a>


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.CAEX.CAEXEnumerable(T)<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class CAEXEnumerable<T> : IEnumerable<T>, 
	IEnumerable
where T : CAEXWrapper

```

**VB**<br />
``` VB
Public Class CAEXEnumerable(Of T As CAEXWrapper)
	Implements IEnumerable(Of T), IEnumerable
```

**C++**<br />
``` C++
generic<typename T>
where T : CAEXWrapper
public ref class CAEXEnumerable : IEnumerable<T>, 
	IEnumerable
```


#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>Type of the CAEX wrapper</dd></dl>&nbsp;
The CAEXEnumerable(T) type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXEnumerable_1__ctor_1">CAEXEnumerable(T)(IEnumerable(XElement))</a></td><td>
Creates a new instance for the CAEX enumerable without an associated CAEXSequence.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXEnumerable_1__ctor">CAEXEnumerable(T)(CAEXSequence(T), IEnumerable(XElement))</a></td><td>
Creates a new instance for a CAEXEnumerable with an associated CAEXSequence.</td></tr></table>&nbsp;
<a href="#caexenumerable(*t*)-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXEnumerable_1_GetEnumerator">GetEnumerator</a></td><td>
Gets the CAEXSequenceEnumerator</td></tr></table>&nbsp;
<a href="#caexenumerable(*t*)-class">Back to Top</a>

## Explicit Interface Implementations
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td><a href="M_Aml_Engine_CAEX_CAEXEnumerable_1_System_Collections_IEnumerable_GetEnumerator">IEnumerable.GetEnumerator</a></td><td>
Returns an enumerator that iterates through a collection.</td></tr></table>&nbsp;
<a href="#caexenumerable(*t*)-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br /><a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">System.Collections.Generic.IEnumerable(T)</a><br />