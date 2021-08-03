# CAEXPathBuilder.PathPartObjectNames Method 
AutomationML 2.1 API 

Returns the Path Part object names of a CAEX Path. If any object name contains a path separator character the path part is enclosed in square brackets '[', ']'. The square brackets are removed from the object name in the returned result (default behaviour). If keepPathPartBrackets is set to true, square brackets are not removed.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static IEnumerable<string> PathPartObjectNames(
	string path,
	CAEXDocument.CAEXSchema schema,
	bool keepPathPartBrackets = false
)
```

**VB**<br />
``` VB
Public Shared Function PathPartObjectNames ( 
	path As String,
	schema As CAEXDocument.CAEXSchema,
	Optional keepPathPartBrackets As Boolean = false
) As IEnumerable(Of String)
```

**C++**<br />
``` C++
public:
static IEnumerable<String^>^ PathPartObjectNames(
	String^ path, 
	CAEXDocument.CAEXSchema schema, 
	bool keepPathPartBrackets = false
)
```


#### Parameters
&nbsp;<dl><dt>path</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The full CAEX path.</dd><dt>schema</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument_CAEXSchema">Aml.Engine.CAEX.CAEXDocument.CAEXSchema</a><br />The CAEX schema version.</dd><dt>keepPathPartBrackets (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />`false` (default); if `true`, object names may be enclosed in square brackets</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>)<br />IEnumerable<System.String>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />