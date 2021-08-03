# NamedElementSequence(*T*).Item Property 
AutomationML 2.1 API 

Gets or sets the value at the specified index.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public abstract T this[
	int index
] { get; set; }
```

**VB**<br />
``` VB
Public MustOverride Default Property Item ( 
	index As Integer
) As T
	Get
	Set
```

**C++**<br />
``` C++
public:
virtual property T default[int index] {
	T get (int index) abstract;
	void set (int index, T value) abstract;
}
```


#### Parameters
&nbsp;<dl><dt>index</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.int32" target="_parent" rel="noopener noreferrer">System.Int32</a><br />The index of the element in the collection.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_NamedElementSequence_1">*T*</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_NamedElementSequence_1">NamedElementSequence(T) Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />