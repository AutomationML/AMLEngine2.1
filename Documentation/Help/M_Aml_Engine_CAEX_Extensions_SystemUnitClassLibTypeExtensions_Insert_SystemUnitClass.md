# SystemUnitClassLibTypeExtensions.Insert_SystemUnitClass Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Inserts the provided SystemUnitClass into this SystemUnitClass library.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use systemUnitClassLib.Insert instead.")]
public static void Insert_SystemUnitClass(
	this SystemUnitClassLibType systemUnitClassLib,
	SystemUnitFamilyType systemUnitClass
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use systemUnitClassLib.Insert instead.")>
Public Shared Sub Insert_SystemUnitClass ( 
	systemUnitClassLib As SystemUnitClassLibType,
	systemUnitClass As SystemUnitFamilyType
)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use systemUnitClassLib.Insert instead.")]
static void Insert_SystemUnitClass(
	SystemUnitClassLibType^ systemUnitClassLib, 
	SystemUnitFamilyType^ systemUnitClass
)
```


#### Parameters
&nbsp;<dl><dt>systemUnitClassLib</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SystemUnitClassLibType">Aml.Engine.CAEX.SystemUnitClassLibType</a><br />The system unit class library.</dd><dt>systemUnitClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">Aml.Engine.CAEX.SystemUnitFamilyType</a><br />The system unit class.</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_SystemUnitClassLibType">SystemUnitClassLibType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassLibTypeExtensions">SystemUnitClassLibTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />