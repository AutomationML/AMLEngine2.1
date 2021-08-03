# CAEXPathBuilder.ContainsPathSeparatorChars Method 
AutomationML 2.1 API 

Determines whether the specified name contains path separator chars.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool ContainsPathSeparatorChars(
	string name,
	CAEXDocument document
)
```

**VB**<br />
``` VB
Public Shared Function ContainsPathSeparatorChars ( 
	name As String,
	document As CAEXDocument
) As Boolean
```

**C++**<br />
``` C++
public:
static bool ContainsPathSeparatorChars(
	String^ name, 
	CAEXDocument^ document
)
```


#### Parameters
&nbsp;<dl><dt>name</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The name.</dd><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the specified name contains path separator chars; otherwise, `false`.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />