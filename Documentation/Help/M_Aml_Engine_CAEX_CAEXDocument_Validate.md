# CAEXDocument.Validate Method 
AutomationML 2.1 API 

Checks if the document is schema compliant.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool Validate(
	out string[] violationLog
)
```

**VB**<br />
``` VB
Public Function Validate ( 
	<OutAttribute> ByRef violationLog As String()
) As Boolean
```

**C++**<br />
``` C++
public:
bool Validate(
	[OutAttribute] array<String^>^% violationLog
)
```


#### Parameters
&nbsp;<dl><dt>violationLog</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a>[]<br />Log of schema violations.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true`, if the CAEX document is schema compliant; otherwise `false`.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />