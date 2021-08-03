# CAEXPathBuilder.IsValidAttributeReferenceID Method 
AutomationML 2.1 API 

Determines whether the ID is valid to be used in an attribute mirror reference.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool IsValidAttributeReferenceID(
	string idString,
	CAEXDocument document
)
```

**VB**<br />
``` VB
Public Shared Function IsValidAttributeReferenceID ( 
	idString As String,
	document As CAEXDocument
) As Boolean
```

**C++**<br />
``` C++
public:
static bool IsValidAttributeReferenceID(
	String^ idString, 
	CAEXDocument^ document
)
```


#### Parameters
&nbsp;<dl><dt>idString</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The identifier string.</dd><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the ID is valid to be used in an attribute mirror reference; otherwise, `false`.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />