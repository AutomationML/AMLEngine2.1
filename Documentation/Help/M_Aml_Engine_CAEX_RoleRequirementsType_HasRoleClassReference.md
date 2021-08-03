# RoleRequirementsType.HasRoleClassReference Method 
AutomationML 2.1 API 

Determines whether this RoleRequirements object has an associated reference to the provided RoleClass. If inheritance relations between RoleClasses should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified RoleClass is either identical to the referenced RoleClass or the referenced RoleClass is derived from the provided RoleClass.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool HasRoleClassReference(
	RoleFamilyType roleClass,
	bool regardInheritance = false
)
```

**VB**<br />
``` VB
Public Function HasRoleClassReference ( 
	roleClass As RoleFamilyType,
	Optional regardInheritance As Boolean = false
) As Boolean
```

**C++**<br />
``` C++
public:
bool HasRoleClassReference(
	RoleFamilyType^ roleClass, 
	bool regardInheritance = false
)
```


#### Parameters
&nbsp;<dl><dt>roleClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_RoleFamilyType">Aml.Engine.CAEX.RoleFamilyType</a><br />The RoleClass object.</dd><dt>regardInheritance (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` inheritance relations are regarded (default is `false`).</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if this RoleRequirement object has an associated reference to the specified RoleClass; otherwise, `false`.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>roleClass</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_RoleRequirementsType">RoleRequirementsType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />