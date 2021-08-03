# CAEXPathBuilder.AliasFromReference Method 
AutomationML 2.1 API 

Gets the alias name from a reference. If the reference is not a reference with an alias, the return value is string.Empty.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static string AliasFromReference(
	string classReference,
	CAEXDocument.CAEXSchema schema
)
```

**VB**<br />
``` VB
Public Shared Function AliasFromReference ( 
	classReference As String,
	schema As CAEXDocument.CAEXSchema
) As String
```

**C++**<br />
``` C++
public:
static String^ AliasFromReference(
	String^ classReference, 
	CAEXDocument.CAEXSchema schema
)
```


#### Parameters
&nbsp;<dl><dt>classReference</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The class reference.</dd><dt>schema</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument_CAEXSchema">Aml.Engine.CAEX.CAEXDocument.CAEXSchema</a><br />The CAEX schema version.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />The Alias Name without the Ending AliasSeparator or string.empty

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />