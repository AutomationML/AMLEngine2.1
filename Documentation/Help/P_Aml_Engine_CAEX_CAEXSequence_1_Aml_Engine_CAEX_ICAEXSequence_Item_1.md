# CAEXSequence(*T*).ICAEXSequence.Item Property (ValueTuple(String, String))
AutomationML 2.1 API 

Gets the first CAEX object with a specific attribute value from the sequence of elements

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
ICAEXWrapperICAEXSequence.this[
	(string Name, string Value) attributeValuePair
] { get; }
```

**VB**<br />
``` VB
Private ReadOnly Property Item ( 
	attributeValuePair As (Name As String, Value As String)
) As ICAEXWrapper Implements ICAEXSequence.Item
	Get
```

**C++**<br />
``` C++
private:
virtual property ICAEXWrapper^ Item[ValueTuple<String^, String^> attributeValuePair] {
	ICAEXWrapper^ get (ValueTuple<String^, String^> attributeValuePair) sealed = ICAEXSequence::Item::get;
}
```


#### Parameters
&nbsp;<dl><dt>attributeValuePair</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.valuetuple-2" target="_parent" rel="noopener noreferrer">System.ValueTuple</a>(<a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>, <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>)<br />Pair of attribute name and attribute value</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_ICAEXWrapper">ICAEXWrapper</a><br />the first CAEX object, which matches this condition.

#### Implements
<a href="P_Aml_Engine_CAEX_ICAEXSequence_Item_1">ICAEXSequence.Item(ValueTuple(String, String))</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T) Class</a><br /><a href="Overload_Aml_Engine_CAEX_CAEXSequence_1_Aml_Engine_CAEX_ICAEXSequence_Item">Item Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />