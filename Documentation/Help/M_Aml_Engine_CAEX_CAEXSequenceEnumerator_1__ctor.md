# CAEXSequenceEnumerator(*T*) Constructor 
AutomationML 2.1 API 

Initializes a new instance of the <a href="T_Aml_Engine_CAEX_CAEXSequenceEnumerator_1">CAEXSequenceEnumerator(T)</a> class.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public CAEXSequenceEnumerator(
	CAEXSequence<T> sequence,
	IEnumerable<XElement> elements
)
```

**VB**<br />
``` VB
Public Sub New ( 
	sequence As CAEXSequence(Of T),
	elements As IEnumerable(Of XElement)
)
```

**C++**<br />
``` C++
public:
CAEXSequenceEnumerator(
	CAEXSequence<T>^ sequence, 
	IEnumerable<XElement^>^ elements
)
```


#### Parameters
&nbsp;<dl><dt>sequence</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXSequence_1">Aml.Engine.CAEX.CAEXSequence</a>(<a href="T_Aml_Engine_CAEX_CAEXSequenceEnumerator_1">*T*</a>)<br />The CAEXSequence, defining the sequence of XML elements.</dd><dt>elements</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">System.Collections.Generic.IEnumerable</a>(<a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">XElement</a>)<br />The collection of XML elements of the CAEX sequence.</dd></dl>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXSequenceEnumerator_1">CAEXSequenceEnumerator(T) Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />