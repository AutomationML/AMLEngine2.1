# CAEXPathBuilder.PathPartName Method 
AutomationML 2.1 API 

Transforms a name to a path Part (special characters are escaped).

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static string PathPartName(
	string name,
	CAEXDocument.CAEXSchema schema
)
```

**VB**<br />
``` VB
Public Shared Function PathPartName ( 
	name As String,
	schema As CAEXDocument.CAEXSchema
) As String
```

**C++**<br />
``` C++
public:
static String^ PathPartName(
	String^ name, 
	CAEXDocument.CAEXSchema schema
)
```


#### Parameters
&nbsp;<dl><dt>name</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The name.</dd><dt>schema</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument_CAEXSchema">Aml.Engine.CAEX.CAEXDocument.CAEXSchema</a><br />This method has different implementations according to the used CAEX Version</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />The transformed name that can be used as a path part.

## Remarks
Since CAEX Version 3.0 the Path separator characters '.' and ':' are eliminated.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />