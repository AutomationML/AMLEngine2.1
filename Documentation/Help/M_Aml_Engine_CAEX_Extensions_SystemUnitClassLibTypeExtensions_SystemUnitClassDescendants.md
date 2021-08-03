# SystemUnitClassLibTypeExtensions.SystemUnitClassDescendants Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Gets all descendant <a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType</a> Objects in the SystemUnitClassLib. SystemUnitClasss on all levels are returned.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use systemUnitClassLib.Descendants<SystemUnitFamilyType> instead.")]
public static IEnumerable<SystemUnitFamilyType> SystemUnitClassDescendants(
	this SystemUnitClassLibType systemUnitClassLib
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use systemUnitClassLib.Descendants<SystemUnitFamilyType> instead.")>
Public Shared Function SystemUnitClassDescendants ( 
	systemUnitClassLib As SystemUnitClassLibType
) As IEnumerable(Of SystemUnitFamilyType)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use systemUnitClassLib.Descendants<SystemUnitFamilyType> instead.")]
static IEnumerable<SystemUnitFamilyType^>^ SystemUnitClassDescendants(
	SystemUnitClassLibType^ systemUnitClassLib
)
```


#### Parameters
&nbsp;<dl><dt>systemUnitClassLib</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SystemUnitClassLibType">Aml.Engine.CAEX.SystemUnitClassLibType</a><br />The SystemUnitClassLib.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType</a>)<br />IEnumerable<SystemUnitFamilyType>.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_SystemUnitClassLibType">SystemUnitClassLibType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassLibTypeExtensions">SystemUnitClassLibTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />