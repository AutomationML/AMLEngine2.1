# CAEXEnumerable(*T*) Constructor (CAEXSequence(*T*), IEnumerable(XElement))
AutomationML 2.1 API 

Creates a new instance for a CAEXEnumerable with an associated CAEXSequence.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public CAEXEnumerable(
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
CAEXEnumerable(
	CAEXSequence<T>^ sequence, 
	IEnumerable<XElement^>^ elements
)
```


#### Parameters
&nbsp;<dl><dt>sequence</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXSequence_1">Aml.Engine.CAEX.CAEXSequence</a>(<a href="T_Aml_Engine_CAEX_CAEXEnumerable_1">*T*</a>)<br />The CAEXSequence containing the Xml-Element collection. If `null`, the specified Xml-Element collection is not associated with a CAEXSequence.</dd><dt>elements</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">System.Collections.Generic.IEnumerable</a>(<a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">XElement</a>)<br />The Xml-Element collection. If not associated to a CAEXSequence the specified sequence should be set to `null`.</dd></dl>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXEnumerable_1">CAEXEnumerable(T) Class</a><br /><a href="Overload_Aml_Engine_CAEX_CAEXEnumerable_1__ctor">CAEXEnumerable(T) Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />