# CAEXPathBuilder.IsAlias Method 
AutomationML 2.1 API 

Determines whether the specified part of a path is an alias.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool IsAlias(
	string pathPart
)
```

**VB**<br />
``` VB
Public Shared Function IsAlias ( 
	pathPart As String
) As Boolean
```

**C++**<br />
``` C++
public:
static bool IsAlias(
	String^ pathPart
)
```


#### Parameters
&nbsp;<dl><dt>pathPart</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The path part.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the specified path part is an alias; otherwise, `false`.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />