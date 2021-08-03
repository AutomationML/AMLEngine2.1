# CAEXPathBuilder.SeparatorChars Method 
AutomationML 2.1 API 

Gets the defined Separator characters according to the provided schema version.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static char[] SeparatorChars(
	CAEXDocument.CAEXSchema schema
)
```

**VB**<br />
``` VB
Public Shared Function SeparatorChars ( 
	schema As CAEXDocument.CAEXSchema
) As Char()
```

**C++**<br />
``` C++
public:
static array<wchar_t>^ SeparatorChars(
	CAEXDocument.CAEXSchema schema
)
```


#### Parameters
&nbsp;<dl><dt>schema</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument_CAEXSchema">Aml.Engine.CAEX.CAEXDocument.CAEXSchema</a><br />The schema.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.char" target="_parent" rel="noopener noreferrer">Char</a>[]<br />The defined separator characters, which can be used in a CAEX path.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />