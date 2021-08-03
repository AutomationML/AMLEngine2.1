# StringExtensions.IsInterfacePathWithID Method 
AutomationML 2.1 API 

Determines whether the specified path is an interface path containing an ID

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool IsInterfacePathWithID(
	this string path,
	string id,
	CAEXDocument.CAEXSchema schema
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function IsInterfacePathWithID ( 
	path As String,
	id As String,
	schema As CAEXDocument.CAEXSchema
) As Boolean
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static bool IsInterfacePathWithID(
	String^ path, 
	String^ id, 
	CAEXDocument.CAEXSchema schema
)
```


#### Parameters
&nbsp;<dl><dt>path</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The path.</dd><dt>id</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The identifier.</dd><dt>schema</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument_CAEXSchema">Aml.Engine.CAEX.CAEXDocument.CAEXSchema</a><br />The CAEX Version</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the specified path is an interface path with identifier; otherwise, `false`.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Remarks
Since CAEX Version 3.0 IDs cannot be part of a CAEXPath anymore

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_StringExtensions">StringExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />