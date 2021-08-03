# CAEXPathBuilder.RemoveAlias Method 
AutomationML 2.1 API 

Removes the alias from the provided path if the path is <a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_IsReferenceWithAlias">IsReferenceWithAlias(String, CAEXDocument.CAEXSchema)</a>.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static string RemoveAlias(
	string path
)
```

**VB**<br />
``` VB
Public Shared Function RemoveAlias ( 
	path As String
) As String
```

**C++**<br />
``` C++
public:
static String^ RemoveAlias(
	String^ path
)
```


#### Parameters
&nbsp;<dl><dt>path</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The path.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />The path without the alias part.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />