# AMLEngineAdapter.Insert_RoleRequirements Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Inserting a RoleRequirement to this InternalElement. An exception is thrown if a RoleRequirements is already existent.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use Insert Method instead", false)]
public static void Insert_RoleRequirements(
	this InternalElementType internalElement,
	RoleRequirementsType roleRequirement
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use Insert Method instead", false)>
Public Shared Sub Insert_RoleRequirements ( 
	internalElement As InternalElementType,
	roleRequirement As RoleRequirementsType
)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use Insert Method instead", false)]
static void Insert_RoleRequirements(
	InternalElementType^ internalElement, 
	RoleRequirementsType^ roleRequirement
)
```


#### Parameters
&nbsp;<dl><dt>internalElement</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InternalElementType">Aml.Engine.CAEX.InternalElementType</a><br />The internal element.</dd><dt>roleRequirement</dt><dd>Type: <a href="T_Aml_Engine_CAEX_RoleRequirementsType">Aml.Engine.CAEX.RoleRequirementsType</a><br />The RoleRequirement to insert</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="T_Aml_Engine_CAEX_SchemaConformanceException">SchemaConformanceException</a></td><td>A RoleRequirements node is already existent. It is not allowed to add more than one RoleRequirements node to current element according to CAEX Schema</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />