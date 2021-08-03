# StringExtensions.IsGUID Method 
AutomationML 2.1 API 

string extension method to check if it as GUID

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool IsGUID(
	this string stringGuid,
	bool allowAnyString = false
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function IsGUID ( 
	stringGuid As String,
	Optional allowAnyString As Boolean = false
) As Boolean
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static bool IsGUID(
	String^ stringGuid, 
	bool allowAnyString = false
)
```


#### Parameters
&nbsp;<dl><dt>stringGuid</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The stringGuid.</dd><dt>allowAnyString (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />\[Missing <param name="allowAnyString"/> documentation for "M:Aml.Engine.CAEX.Extensions.StringExtensions.IsGUID(System.String,System.Boolean)"\]</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the specified expression is unique identifier; otherwise, `false`.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_StringExtensions">StringExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />