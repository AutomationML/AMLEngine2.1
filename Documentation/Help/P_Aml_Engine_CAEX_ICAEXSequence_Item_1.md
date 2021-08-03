# ICAEXSequence.Item Property (ValueTuple(String, String))
AutomationML 2.1 API 

Gets the first CAEX object with a specific attribute value from the sequence of elements

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
ICAEXWrapper this[
	(string Name, string Value) attributeValuePair
] { get; }
```

**VB**<br />
``` VB
ReadOnly Default Property Item ( 
	attributeValuePair As (Name As String, Value As String)
) As ICAEXWrapper
	Get
```

**C++**<br />
``` C++
property ICAEXWrapper^ default[ValueTuple<String^, String^> attributeValuePair] {
	ICAEXWrapper^ get (ValueTuple<String^, String^> attributeValuePair);
}
```


#### Parameters
&nbsp;<dl><dt>attributeValuePair</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.valuetuple-2" target="_parent" rel="noopener noreferrer">System.ValueTuple</a>(<a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>, <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>)<br />Pair of attribute name and attribute value</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_ICAEXWrapper">ICAEXWrapper</a><br />the first CAEX object, which matches this condition.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_ICAEXSequence">ICAEXSequence Interface</a><br /><a href="Overload_Aml_Engine_CAEX_ICAEXSequence_Item">Item Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />