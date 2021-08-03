# RoleRequirementsType&nbsp;Implicit Conversion (RoleRequirementsType to ObjectWithAMLAttributes)
AutomationML 2.1 API 

Conversion to get access to specific AutomationML defined Attributes from the RoleRequirements object.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static implicit operator ObjectWithAMLAttributes (
	RoleRequirementsType roleRequirement
)
```

**VB**<br />
``` VB
Public Shared Widening Operator CType ( 
	roleRequirement As RoleRequirementsType
) As ObjectWithAMLAttributes
```

**C++**<br />
``` C++
static implicit operator ObjectWithAMLAttributes^ (
	RoleRequirementsType^ roleRequirement
)
```


#### Parameters
&nbsp;<dl><dt>roleRequirement</dt><dd>Type: <a href="T_Aml_Engine_CAEX_RoleRequirementsType">Aml.Engine.CAEX.RoleRequirementsType</a><br />The RoleRequirements object</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_AmlObjects_ObjectWithAMLAttributes">ObjectWithAMLAttributes</a><br />The result of the conversion.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_RoleRequirementsType">RoleRequirementsType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />