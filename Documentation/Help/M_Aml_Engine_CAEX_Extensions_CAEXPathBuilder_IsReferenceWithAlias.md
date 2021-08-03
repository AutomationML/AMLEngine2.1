# CAEXPathBuilder.IsReferenceWithAlias Method 
AutomationML 2.1 API 

Determines whether the specified reference is defined with an alias separator.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool IsReferenceWithAlias(
	string classReference,
	CAEXDocument.CAEXSchema schema
)
```

**VB**<br />
``` VB
Public Shared Function IsReferenceWithAlias ( 
	classReference As String,
	schema As CAEXDocument.CAEXSchema
) As Boolean
```

**C++**<br />
``` C++
public:
static bool IsReferenceWithAlias(
	String^ classReference, 
	CAEXDocument.CAEXSchema schema
)
```


#### Parameters
&nbsp;<dl><dt>classReference</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The class reference string.</dd><dt>schema</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument_CAEXSchema">Aml.Engine.CAEX.CAEXDocument.CAEXSchema</a><br />The CAEX schema version.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the reference is a reference with an alias; otherwise, `false`.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />