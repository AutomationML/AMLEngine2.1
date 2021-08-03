# CAEXSequence(*T*).ICAEXSequence.Prepend Method (ValueTuple(String, Object)[])
AutomationML 2.1 API 

Creates a new CAEX object and prepends it to already existing elements. The content of the new element can be defined using an array of tuples defining attribute names and their values.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
ICAEXWrapperICAEXSequence.Prepend(
	params (string , Object )[] attributeValueTuples
)
```

**VB**<br />
``` VB
Private Function Prepend ( 
	ParamArray attributeValueTuples As ( As String,  As Object)()
) As ICAEXWrapper Implements ICAEXSequence.Prepend
```

**C++**<br />
``` C++
private:
virtual ICAEXWrapper^ Prepend(
	... array<ValueTuple<String^, Object^>>^ attributeValueTuples
) sealed = ICAEXSequence::Prepend
```


#### Parameters
&nbsp;<dl><dt>attributeValueTuples</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.valuetuple-2" target="_parent" rel="noopener noreferrer">System.ValueTuple</a>(<a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>, <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">Object</a>)[]<br />The attribute value tuples.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_ICAEXWrapper">ICAEXWrapper</a><br />The created CAEX object.

#### Implements
<a href="M_Aml_Engine_CAEX_ICAEXSequence_Prepend_1">ICAEXSequence.Prepend(ValueTuple(String, Object)[])</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T) Class</a><br /><a href="Overload_Aml_Engine_CAEX_CAEXSequence_1_Aml_Engine_CAEX_ICAEXSequence_Prepend">Prepend Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />