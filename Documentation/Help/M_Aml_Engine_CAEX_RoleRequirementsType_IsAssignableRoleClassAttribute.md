# RoleRequirementsType.IsAssignableRoleClassAttribute Method 
AutomationML 2.1 API 

This method supports the Multiple Roles concept in AutomationML 2.0, based on CAEX 2.15. The method is not applicable for documents, based on CAEX 3.0 and later. It tests, if the provided attribute is a role class attributes of a supported role class object which can be used in a Multiple role mapping and is assignable to this RoleRequirements instance

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool IsAssignableRoleClassAttribute(
	AttributeType attribute
)
```

**VB**<br />
``` VB
Public Function IsAssignableRoleClassAttribute ( 
	attribute As AttributeType
) As Boolean
```

**C++**<br />
``` C++
public:
bool IsAssignableRoleClassAttribute(
	AttributeType^ attribute
)
```


#### Parameters
&nbsp;<dl><dt>attribute</dt><dd>Type: <a href="T_Aml_Engine_CAEX_AttributeType">Aml.Engine.CAEX.AttributeType</a><br />The tested attribute.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the attribute is an assignable role class attribute; otherwise, `false`.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_RoleRequirementsType">RoleRequirementsType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />