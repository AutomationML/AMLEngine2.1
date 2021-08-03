# SystemUnitClassTypeExtensions.Insert_InternalLink Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Inserts the specified InternalLink as the first InternalLink if nothing else if explicit defined.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use InternalLink.Insert")]
public static void Insert_InternalLink(
	this SystemUnitClassType systemUnitClass,
	InternalLinkType internalLinkElement,
	bool asFirst = true
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use InternalLink.Insert")>
Public Shared Sub Insert_InternalLink ( 
	systemUnitClass As SystemUnitClassType,
	internalLinkElement As InternalLinkType,
	Optional asFirst As Boolean = true
)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use InternalLink.Insert")]
static void Insert_InternalLink(
	SystemUnitClassType^ systemUnitClass, 
	InternalLinkType^ internalLinkElement, 
	bool asFirst = true
)
```


#### Parameters
&nbsp;<dl><dt>systemUnitClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SystemUnitClassType">Aml.Engine.CAEX.SystemUnitClassType</a><br />The SystemUnitClass object</dd><dt>internalLinkElement</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InternalLinkType">Aml.Engine.CAEX.InternalLinkType</a><br />The internal link element.</dd><dt>asFirst (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />Inserted at first position if set to `true`, otherwise appended at last position</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions">SystemUnitClassTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />