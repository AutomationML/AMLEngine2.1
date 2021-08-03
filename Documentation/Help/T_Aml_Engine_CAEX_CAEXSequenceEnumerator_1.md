# CAEXSequenceEnumerator(*T*) Class
AutomationML 2.1 API 

This class implements the CAEX sequence enumerator which creates a CAEXWrapper for each enumerated XML-Element.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.CAEX.CAEXSequenceEnumerator(T)<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class CAEXSequenceEnumerator<T> : IEnumerator<T>, 
	IDisposable, IEnumerator
where T : CAEXWrapper

```

**VB**<br />
``` VB
Public Class CAEXSequenceEnumerator(Of T As CAEXWrapper)
	Implements IEnumerator(Of T), IDisposable, IEnumerator
```

**C++**<br />
``` C++
generic<typename T>
where T : CAEXWrapper
public ref class CAEXSequenceEnumerator : IEnumerator<T>, 
	IDisposable, IEnumerator
```


#### Type Parameters
&nbsp;<dl><dt>T</dt><dd /></dl>&nbsp;
The CAEXSequenceEnumerator(T) type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequenceEnumerator_1__ctor">CAEXSequenceEnumerator(T)</a></td><td>
Initializes a new instance of the CAEXSequenceEnumerator(T) class.</td></tr></table>&nbsp;
<a href="#caexsequenceenumerator(*t*)-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXSequenceEnumerator_1_Current">Current</a></td><td>
Gets the item in the collection at the current position of the enumerator.</td></tr></table>&nbsp;
<a href="#caexsequenceenumerator(*t*)-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequenceEnumerator_1_Dispose">Dispose</a></td><td>
Dispose this instance.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequenceEnumerator_1_MoveNext">MoveNext</a></td><td>
Sets the enumerator to the next item in the collection.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXSequenceEnumerator_1_Reset">Reset</a></td><td>
Resets the enumerator.</td></tr></table>&nbsp;
<a href="#caexsequenceenumerator(*t*)-class">Back to Top</a>

## Explicit Interface Implementations
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private property](media/privproperty.gif "Private property")</td><td><a href="P_Aml_Engine_CAEX_CAEXSequenceEnumerator_1_System_Collections_IEnumerator_Current">IEnumerator.Current</a></td><td>
Gets the item in the collection at the current position of the enumerator.</td></tr></table>&nbsp;
<a href="#caexsequenceenumerator(*t*)-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br /><a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerator-1" target="_parent" rel="noopener noreferrer">System.Collections.Generic.IEnumerator(T)</a><br />