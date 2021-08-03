# AMLEngineAdapter.New_RoleRequirements Method (InternalElementType, String)
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Adding a new RoleRequirements element to this InternalElement using the defined roleClassPath. It is only allowed to add one RoleRequirements node in CAEX 2.15.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use AddRoleClassReference Method instead.", false)]
public static RoleRequirementsType New_RoleRequirements(
	this InternalElementType internalElement,
	string roleClassPath
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use AddRoleClassReference Method instead.", false)>
Public Shared Function New_RoleRequirements ( 
	internalElement As InternalElementType,
	roleClassPath As String
) As RoleRequirementsType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use AddRoleClassReference Method instead.", false)]
static RoleRequirementsType^ New_RoleRequirements(
	InternalElementType^ internalElement, 
	String^ roleClassPath
)
```


#### Parameters
&nbsp;<dl><dt>internalElement</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InternalElementType">Aml.Engine.CAEX.InternalElementType</a><br />The internal element.</dd><dt>roleClassPath</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The role class path.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_RoleRequirementsType">RoleRequirementsType</a><br />RoleRequirementsType.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="Overload_Aml_Engine_Adapter_AMLEngineAdapter_New_RoleRequirements">New_RoleRequirements Overload</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />