# RoleClassLibTypeExtensions.New_RoleClass Method 
AutomationML 2.1 API 

Adding a new RoleClass to this RoleClassLib.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static RoleFamilyType New_RoleClass(
	this RoleClassLibType roleClassLib,
	string roleClassName
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function New_RoleClass ( 
	roleClassLib As RoleClassLibType,
	roleClassName As String
) As RoleFamilyType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static RoleFamilyType^ New_RoleClass(
	RoleClassLibType^ roleClassLib, 
	String^ roleClassName
)
```


#### Parameters
&nbsp;<dl><dt>roleClassLib</dt><dd>Type: <a href="T_Aml_Engine_CAEX_RoleClassLibType">Aml.Engine.CAEX.RoleClassLibType</a><br />The RoleClassLib object</dd><dt>roleClassName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Name of the RoleClass element.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_RoleFamilyType">RoleFamilyType</a><br />A new RoleClass

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_RoleClassLibType">RoleClassLibType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_RoleClassLibTypeExtensions">RoleClassLibTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />