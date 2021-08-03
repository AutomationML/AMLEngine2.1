# ICAEXSequence.Item Property (Int32)
AutomationML 2.1 API 

Gets a wrapper for the CAEX element in this sequence at the given position

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
ICAEXWrapper this[
	int i
] { get; set; }
```

**VB**<br />
``` VB
Default Property Item ( 
	i As Integer
) As ICAEXWrapper
	Get
	Set
```

**C++**<br />
``` C++
property ICAEXWrapper^ default[int i] {
	ICAEXWrapper^ get (int i);
	void set (int i, ICAEXWrapper^ value);
}
```


#### Parameters
&nbsp;<dl><dt>i</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.int32" target="_parent" rel="noopener noreferrer">System.Int32</a><br />index position of the element</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_ICAEXWrapper">ICAEXWrapper</a><br />The created CAEX wrapper.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_ICAEXSequence">ICAEXSequence Interface</a><br /><a href="Overload_Aml_Engine_CAEX_ICAEXSequence_Item">Item Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />