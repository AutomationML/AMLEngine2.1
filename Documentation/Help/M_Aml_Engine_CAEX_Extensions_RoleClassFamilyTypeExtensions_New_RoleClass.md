# RoleClassFamilyTypeExtensions.New_RoleClass Method 
AutomationML 2.1 API 

Adding a new RoleClass to this RoleClassFamily.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static RoleFamilyType New_RoleClass(
	this RoleFamilyType roleClassFamily,
	string roleClassName
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function New_RoleClass ( 
	roleClassFamily As RoleFamilyType,
	roleClassName As String
) As RoleFamilyType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static RoleFamilyType^ New_RoleClass(
	RoleFamilyType^ roleClassFamily, 
	String^ roleClassName
)
```


#### Parameters
&nbsp;<dl><dt>roleClassFamily</dt><dd>Type: <a href="T_Aml_Engine_CAEX_RoleFamilyType">Aml.Engine.CAEX.RoleFamilyType</a><br />The RoleClass object</dd><dt>roleClassName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Name of the RoleClass.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_RoleFamilyType">RoleFamilyType</a><br />A new RoleClass

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_RoleFamilyType">RoleFamilyType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_RoleClassFamilyTypeExtensions">RoleClassFamilyTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />