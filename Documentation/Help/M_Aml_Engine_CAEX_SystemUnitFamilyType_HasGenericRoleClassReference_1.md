# SystemUnitFamilyType.HasGenericRoleClassReference Method (RoleRequirementsType)
AutomationML 2.1 API 

Determines whether the specified roleReference is more specific than any already associated SupportedRoleClass of this SystemUnitClass. This method doesn't check inherited RoleClass references from ancestors. If an assigned RoleClass is identical to the specified RoleClass, the result is `false`.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool HasGenericRoleClassReference(
	RoleRequirementsType roleReference
)
```

**VB**<br />
``` VB
Public Function HasGenericRoleClassReference ( 
	roleReference As RoleRequirementsType
) As Boolean
```

**C++**<br />
``` C++
public:
bool HasGenericRoleClassReference(
	RoleRequirementsType^ roleReference
)
```


#### Parameters
&nbsp;<dl><dt>roleReference</dt><dd>Type: <a href="T_Aml_Engine_CAEX_RoleRequirementsType">Aml.Engine.CAEX.RoleRequirementsType</a><br />The RoleReference object.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if this SystemUnitFamilyType object has an associated SupportedRoleClass reference which is a generalization of the specified RoleClass (the RoleClass is more specific); otherwise, `false`.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>roleClass</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType Class</a><br /><a href="Overload_Aml_Engine_CAEX_SystemUnitFamilyType_HasGenericRoleClassReference">HasGenericRoleClassReference Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />