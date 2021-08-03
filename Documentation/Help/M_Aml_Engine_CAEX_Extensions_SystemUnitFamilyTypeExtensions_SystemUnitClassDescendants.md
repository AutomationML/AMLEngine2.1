# SystemUnitFamilyTypeExtensions.SystemUnitClassDescendants Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Gets all descendant <a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType</a> Objects in the SystemUnitClass. SystemUnitClasses on all levels are returned.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use systemUnitFamilyType.Descendants<SystemUnitFamilyType> instead.")]
public static IEnumerable<SystemUnitFamilyType> SystemUnitClassDescendants(
	this SystemUnitFamilyType systemUnitFamilyType
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use systemUnitFamilyType.Descendants<SystemUnitFamilyType> instead.")>
Public Shared Function SystemUnitClassDescendants ( 
	systemUnitFamilyType As SystemUnitFamilyType
) As IEnumerable(Of SystemUnitFamilyType)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use systemUnitFamilyType.Descendants<SystemUnitFamilyType> instead.")]
static IEnumerable<SystemUnitFamilyType^>^ SystemUnitClassDescendants(
	SystemUnitFamilyType^ systemUnitFamilyType
)
```


#### Parameters
&nbsp;<dl><dt>systemUnitFamilyType</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">Aml.Engine.CAEX.SystemUnitFamilyType</a><br />The SystemUnitClass.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType</a>)<br />An enumeration of all descendant SystemUnitClass objects.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_SystemUnitFamilyTypeExtensions">SystemUnitFamilyTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />