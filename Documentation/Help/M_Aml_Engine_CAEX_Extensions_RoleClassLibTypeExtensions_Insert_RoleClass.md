# RoleClassLibTypeExtensions.Insert_RoleClass Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Inserts the provided RoleClass into this RoleClass library.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use roleClassLib.Insert instead.")]
public static void Insert_RoleClass(
	this RoleClassLibType roleClassLib,
	RoleFamilyType roleClass
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use roleClassLib.Insert instead.")>
Public Shared Sub Insert_RoleClass ( 
	roleClassLib As RoleClassLibType,
	roleClass As RoleFamilyType
)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use roleClassLib.Insert instead.")]
static void Insert_RoleClass(
	RoleClassLibType^ roleClassLib, 
	RoleFamilyType^ roleClass
)
```


#### Parameters
&nbsp;<dl><dt>roleClassLib</dt><dd>Type: <a href="T_Aml_Engine_CAEX_RoleClassLibType">Aml.Engine.CAEX.RoleClassLibType</a><br />The role class library.</dd><dt>roleClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_RoleFamilyType">Aml.Engine.CAEX.RoleFamilyType</a><br />The role class.</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_RoleClassLibType">RoleClassLibType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_RoleClassLibTypeExtensions">RoleClassLibTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />