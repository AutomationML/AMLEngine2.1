# CAEXSequenceOfCAEXObjects(*T*).Append Method (String)
AutomationML 2.1 API 

Creates a new CAEX object with the specified name and appends it to the sequence.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public virtual T Append(
	string name
)
```

**VB**<br />
``` VB
Public Overridable Function Append ( 
	name As String
) As T
```

**C++**<br />
``` C++
public:
virtual T Append(
	String^ name
)
```


#### Parameters
&nbsp;<dl><dt>name</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the name of the CAEX object. If a <a href="T_Aml_Engine_Services_Interfaces_IUniqueName">IUniqueName</a></dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXSequenceOfCAEXObjects_1">*T*</a><br />the created CAEX object.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXSequenceOfCAEXObjects_1">CAEXSequenceOfCAEXObjects(T) Class</a><br /><a href="Overload_Aml_Engine_CAEX_CAEXSequenceOfCAEXObjects_1_Append">Append Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />