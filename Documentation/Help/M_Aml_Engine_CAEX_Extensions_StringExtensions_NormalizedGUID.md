# StringExtensions.NormalizedGUID Method 
AutomationML 2.1 API 

String extension method to normalize a GUID. If the string cannot be identified as a GUID the original string is returned

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static string NormalizedGUID(
	this string stringGuid
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function NormalizedGUID ( 
	stringGuid As String
) As String
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static String^ NormalizedGUID(
	String^ stringGuid
)
```


#### Parameters
&nbsp;<dl><dt>stringGuid</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The stringGuid.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />The normalized GUID if the provided string is a GUID; otherwise the original string is returned.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_StringExtensions">StringExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />