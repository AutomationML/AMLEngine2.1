# InternalElementType.HasGenericRoleClassReference Method (RoleFamilyType)
AutomationML 2.1 API 

Determines whether this InternalElement object has an associated reference to a RoleClass which is a generalization of the specified *specificRoleClass* which means, that the specified RoleClass is more specific than any already associated RoleClass of this InternalElement.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool HasGenericRoleClassReference(
	RoleFamilyType specificRoleClass
)
```

**VB**<br />
``` VB
Public Function HasGenericRoleClassReference ( 
	specificRoleClass As RoleFamilyType
) As Boolean
```

**C++**<br />
``` C++
public:
bool HasGenericRoleClassReference(
	RoleFamilyType^ specificRoleClass
)
```


#### Parameters
&nbsp;<dl><dt>specificRoleClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_RoleFamilyType">Aml.Engine.CAEX.RoleFamilyType</a><br />The RoleClass object.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if this InternalElement object has an associated RoleClass, which is a generalization of the specified RoleClass; otherwise, `false`.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>roleClass</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType Class</a><br /><a href="Overload_Aml_Engine_CAEX_InternalElementType_HasGenericRoleClassReference">HasGenericRoleClassReference Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />