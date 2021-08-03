# SystemUnitFamilyTypeExtensions.Insert_SystemUnitClass Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Inserts the provided SystemUnitClass object as a subordinate child into this SystemUnitClass

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use systemUnitFamilyType.Insert instead.")]
public static void Insert_SystemUnitClass(
	this SystemUnitFamilyType systemUnitClassAncestor,
	SystemUnitFamilyType systemUnitClass
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use systemUnitFamilyType.Insert instead.")>
Public Shared Sub Insert_SystemUnitClass ( 
	systemUnitClassAncestor As SystemUnitFamilyType,
	systemUnitClass As SystemUnitFamilyType
)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use systemUnitFamilyType.Insert instead.")]
static void Insert_SystemUnitClass(
	SystemUnitFamilyType^ systemUnitClassAncestor, 
	SystemUnitFamilyType^ systemUnitClass
)
```


#### Parameters
&nbsp;<dl><dt>systemUnitClassAncestor</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">Aml.Engine.CAEX.SystemUnitFamilyType</a><br />The SystemUnitClass ancestor.</dd><dt>systemUnitClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">Aml.Engine.CAEX.SystemUnitFamilyType</a><br />The SystemUnitClass</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_SystemUnitFamilyTypeExtensions">SystemUnitFamilyTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />