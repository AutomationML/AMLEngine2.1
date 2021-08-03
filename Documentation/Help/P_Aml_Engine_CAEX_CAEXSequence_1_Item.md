# CAEXSequence(*T*).Item Property (Int32)
AutomationML 2.1 API 

Gets a wrapper for the CAEX element in this sequence at the given position

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public override T this[
	int i
] { get; set; }
```

**VB**<br />
``` VB
Public Overrides Default Property Item ( 
	i As Integer
) As T
	Get
	Set
```

**C++**<br />
``` C++
public:
virtual property T default[int i] {
	T get (int i) override;
	void set (int i, T value) override;
}
```


#### Parameters
&nbsp;<dl><dt>i</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.int32" target="_parent" rel="noopener noreferrer">System.Int32</a><br />index position of the element</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXSequence_1">*T*</a><br />The created CAEX wrapper.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T) Class</a><br /><a href="Overload_Aml_Engine_CAEX_CAEXSequence_1_Item">Item Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />