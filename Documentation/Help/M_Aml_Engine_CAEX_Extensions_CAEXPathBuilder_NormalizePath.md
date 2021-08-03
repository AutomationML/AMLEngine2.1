# CAEXPathBuilder.NormalizePath Method 
AutomationML 2.1 API 

Normalization of a CAEXPath. A normalized path is freed of all path part delimiters '[' and ']' in case that there is no path part name containing a path separator character like '/'.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static string NormalizePath(
	string path,
	out bool isNormalized,
	CAEXDocument.CAEXSchema schema
)
```

**VB**<br />
``` VB
Public Shared Function NormalizePath ( 
	path As String,
	<OutAttribute> ByRef isNormalized As Boolean,
	schema As CAEXDocument.CAEXSchema
) As String
```

**C++**<br />
``` C++
public:
static String^ NormalizePath(
	String^ path, 
	[OutAttribute] bool% isNormalized, 
	CAEXDocument.CAEXSchema schema
)
```


#### Parameters
&nbsp;<dl><dt>path</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The path.</dd><dt>isNormalized</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` [is normalized].</dd><dt>schema</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument_CAEXSchema">Aml.Engine.CAEX.CAEXDocument.CAEXSchema</a><br />A CAEX schema version.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />the normalized path

## Remarks
Since CAEX Version 3.0 a '.' and ':' is no longer used as a path separator. Names, containing such a character will be normalized in Version 3.0 also.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />