# CAEXPathBuilder.CAEXPath Method (String[], CAEXDocument.CAEXSchema)
AutomationML 2.1 API 

Builds the Reference-Path which includes all names of CAEX objects in the given name array.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static string CAEXPath(
	string[] names,
	CAEXDocument.CAEXSchema schema
)
```

**VB**<br />
``` VB
Public Shared Function CAEXPath ( 
	names As String(),
	schema As CAEXDocument.CAEXSchema
) As String
```

**C++**<br />
``` C++
public:
static String^ CAEXPath(
	array<String^>^ names, 
	CAEXDocument.CAEXSchema schema
)
```


#### Parameters
&nbsp;<dl><dt>names</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a>[]<br />The names, which build the path parts.</dd><dt>schema</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument_CAEXSchema">Aml.Engine.CAEX.CAEXDocument.CAEXSchema</a><br />The CAEX schema version.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />The CAEX path created from the names array.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="Overload_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_CAEXPath">CAEXPath Overload</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />