# CAEXSequenceOfCAEXObjects(*T*).Item Property (String)
AutomationML 2.1 API 

Gets the first CAEX object with this name from the sequence of elements.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public T this[
	string name
] { get; }
```

**VB**<br />
``` VB
Public ReadOnly Default Property Item ( 
	name As String
) As T
	Get
```

**C++**<br />
``` C++
public:
property T default[String^ name] {
	T get (String^ name);
}
```


#### Parameters
&nbsp;<dl><dt>name</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the name of the CAEX object.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXSequenceOfCAEXObjects_1">*T*</a><br />a CAEX object

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXSequenceOfCAEXObjects_1">CAEXSequenceOfCAEXObjects(T) Class</a><br /><a href="Overload_Aml_Engine_CAEX_CAEXSequenceOfCAEXObjects_1_Item">Item Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />