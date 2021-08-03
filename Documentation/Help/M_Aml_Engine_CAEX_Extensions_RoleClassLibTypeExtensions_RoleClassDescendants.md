# RoleClassLibTypeExtensions.RoleClassDescendants Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Gets all descendant <a href="T_Aml_Engine_CAEX_RoleFamilyType">RoleFamilyType</a> Objects in the RoleClassLib. RoleClasss on all levels are returned.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use roleClassLib.Descendants<RoleFamilyType> instead.")]
public static IEnumerable<RoleFamilyType> RoleClassDescendants(
	this RoleClassLibType roleClassLib
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use roleClassLib.Descendants<RoleFamilyType> instead.")>
Public Shared Function RoleClassDescendants ( 
	roleClassLib As RoleClassLibType
) As IEnumerable(Of RoleFamilyType)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use roleClassLib.Descendants<RoleFamilyType> instead.")]
static IEnumerable<RoleFamilyType^>^ RoleClassDescendants(
	RoleClassLibType^ roleClassLib
)
```


#### Parameters
&nbsp;<dl><dt>roleClassLib</dt><dd>Type: <a href="T_Aml_Engine_CAEX_RoleClassLibType">Aml.Engine.CAEX.RoleClassLibType</a><br />The RoleClassLib.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_RoleFamilyType">RoleFamilyType</a>)<br />Enumeration of the RoleClass descendants.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_RoleClassLibType">RoleClassLibType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_RoleClassLibTypeExtensions">RoleClassLibTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />