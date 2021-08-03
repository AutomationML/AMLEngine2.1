# CAEXSequence(*T*).Append Method (ValueTuple(String, Object)[])
AutomationML 2.1 API 

Creates a new CAEX object and appends it to already existing elements. The content of the new element can be optionally defined using an array of tuples defining attribute names and their values.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public virtual T Append(
	params (string , Object )[] attributeValueTuples
)
```

**VB**<br />
``` VB
Public Overridable Function Append ( 
	ParamArray attributeValueTuples As ( As String,  As Object)()
) As T
```

**C++**<br />
``` C++
public:
virtual T Append(
	... array<ValueTuple<String^, Object^>>^ attributeValueTuples
)
```


#### Parameters
&nbsp;<dl><dt>attributeValueTuples</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.valuetuple-2" target="_parent" rel="noopener noreferrer">System.ValueTuple</a>(<a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>, <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">Object</a>)[]<br />The attribute value tuples.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXSequence_1">*T*</a><br />the created CAEX object.

## Examples
This sample shows how to apply this method: 
```
var doc = CAEXDocument.New();
var at =  doc.CAEXFile.AttributeTypeLib.Append (new Tuple <string,object>[] { Tuple.Create<string,object>("Name", "ALIB") });
```


## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T) Class</a><br /><a href="Overload_Aml_Engine_CAEX_CAEXSequence_1_Append">Append Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />