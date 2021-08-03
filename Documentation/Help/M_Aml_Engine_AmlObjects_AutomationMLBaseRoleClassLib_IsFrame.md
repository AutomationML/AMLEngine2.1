# AutomationMLBaseRoleClassLib.IsFrame Method 
AutomationML 2.1 API 

Determines whether the specified role reference defines an inheritance relation from the Frame RoleClass

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool IsFrame(
	this IObjectWithRoleReference role
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function IsFrame ( 
	role As IObjectWithRoleReference
) As Boolean
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static bool IsFrame(
	IObjectWithRoleReference^ role
)
```


#### Parameters
&nbsp;<dl><dt>role</dt><dd>Type: <a href="T_Aml_Engine_CAEX_IObjectWithRoleReference">Aml.Engine.CAEX.IObjectWithRoleReference</a><br />The role.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if an inheritance relation is resolved; otherwise, `false`.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_IObjectWithRoleReference">IObjectWithRoleReference</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />