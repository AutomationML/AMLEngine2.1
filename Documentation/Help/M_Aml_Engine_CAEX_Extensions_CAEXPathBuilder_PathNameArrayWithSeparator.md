# CAEXPathBuilder.PathNameArrayWithSeparator Method 
AutomationML 2.1 API 

Returns the Path Part object names of a CAEX Path with the Separator Char at the Names End as an array of strings.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static string[] PathNameArrayWithSeparator(
	string path,
	CAEXDocument.CAEXSchema schema,
	bool onlyAlias = false
)
```

**VB**<br />
``` VB
Public Shared Function PathNameArrayWithSeparator ( 
	path As String,
	schema As CAEXDocument.CAEXSchema,
	Optional onlyAlias As Boolean = false
) As String()
```

**C++**<br />
``` C++
public:
static array<String^>^ PathNameArrayWithSeparator(
	String^ path, 
	CAEXDocument.CAEXSchema schema, 
	bool onlyAlias = false
)
```


#### Parameters
&nbsp;<dl><dt>path</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The full CAEX path.</dd><dt>schema</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument_CAEXSchema">Aml.Engine.CAEX.CAEXDocument.CAEXSchema</a><br />The CAEX schema version.</dd><dt>onlyAlias (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />optional parameter, specifying that only the alias char should be kept.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>[]<br />Array of path part names.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />