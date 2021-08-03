# CAEXSequenceOfCAEXObjects(*T*).Item Property (String[])
AutomationML 2.1 API 

Gets the CAEX object which can be identified with a CAEX path, where the path parts are defined in the provided array of names.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public T this[
	string[] caexObjectNames
] { get; }
```

**VB**<br />
``` VB
Public ReadOnly Default Property Item ( 
	caexObjectNames As String()
) As T
	Get
```

**C++**<br />
``` C++
public:
property T default[array<String^>^ caexObjectNames] {
	T get (array<String^>^ caexObjectNames);
}
```


#### Parameters
&nbsp;<dl><dt>caexObjectNames</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a>[]<br />The names extracted from a CAEX path.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXSequenceOfCAEXObjects_1">*T*</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXSequenceOfCAEXObjects_1">CAEXSequenceOfCAEXObjects(T) Class</a><br /><a href="Overload_Aml_Engine_CAEX_CAEXSequenceOfCAEXObjects_1_Item">Item Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />