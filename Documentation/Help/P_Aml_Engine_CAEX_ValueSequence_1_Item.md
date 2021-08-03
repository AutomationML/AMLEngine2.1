# ValueSequence(*TDataType*).Item Property 
AutomationML 2.1 API 

Gets the value of the CAEX object in this sequence at the given position

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public override TDataType this[
	int i
] { get; set; }
```

**VB**<br />
``` VB
Public Overrides Default Property Item ( 
	i As Integer
) As TDataType
	Get
	Set
```

**C++**<br />
``` C++
public:
virtual property TDataType default[int i] {
	TDataType get (int i) override;
	void set (int i, TDataType value) override;
}
```


#### Parameters
&nbsp;<dl><dt>i</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.int32" target="_parent" rel="noopener noreferrer">System.Int32</a><br />index position of the element</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_ValueSequence_1">*TDataType*</a><br />The value.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_ValueSequence_1">ValueSequence(TDataType) Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />