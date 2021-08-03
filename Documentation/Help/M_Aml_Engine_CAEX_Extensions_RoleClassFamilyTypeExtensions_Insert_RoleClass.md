# RoleClassFamilyTypeExtensions.Insert_RoleClass Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Inserts the provided RoleClass as a subordinate child to this RoleClass.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use roleClassFamily.Insert(roleClass) instead.")]
public static void Insert_RoleClass(
	this RoleFamilyType roleClassAncestor,
	RoleFamilyType roleClass
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use roleClassFamily.Insert(roleClass) instead.")>
Public Shared Sub Insert_RoleClass ( 
	roleClassAncestor As RoleFamilyType,
	roleClass As RoleFamilyType
)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use roleClassFamily.Insert(roleClass) instead.")]
static void Insert_RoleClass(
	RoleFamilyType^ roleClassAncestor, 
	RoleFamilyType^ roleClass
)
```


#### Parameters
&nbsp;<dl><dt>roleClassAncestor</dt><dd>Type: <a href="T_Aml_Engine_CAEX_RoleFamilyType">Aml.Engine.CAEX.RoleFamilyType</a><br />The role class ancestor.</dd><dt>roleClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_RoleFamilyType">Aml.Engine.CAEX.RoleFamilyType</a><br />The role class to be inserted.</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_RoleFamilyType">RoleFamilyType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_RoleClassFamilyTypeExtensions">RoleClassFamilyTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />