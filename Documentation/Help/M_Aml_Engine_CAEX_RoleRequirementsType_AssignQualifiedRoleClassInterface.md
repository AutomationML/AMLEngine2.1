# RoleRequirementsType.AssignQualifiedRoleClassInterface Method 
AutomationML 2.1 API 

This method supports the Multiple Roles concept in AutomationML 2.0, based on CAEX 2.15. The method is not applicable for documents, based on CAEX 3.0 and later. It tests, if the provided ExternalInterface object is a role class interface of a supported role class object which can be used in a Multiple role mapping and assigns it to this RoleRequirements instance.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public ExternalInterfaceType AssignQualifiedRoleClassInterface(
	ExternalInterfaceType externalInterface
)
```

**VB**<br />
``` VB
Public Function AssignQualifiedRoleClassInterface ( 
	externalInterface As ExternalInterfaceType
) As ExternalInterfaceType
```

**C++**<br />
``` C++
public:
ExternalInterfaceType^ AssignQualifiedRoleClassInterface(
	ExternalInterfaceType^ externalInterface
)
```


#### Parameters
&nbsp;<dl><dt>externalInterface</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">Aml.Engine.CAEX.ExternalInterfaceType</a><br />The tested external interface.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a><br />the newly created and assigned ExternalInterface, if the ExternalInterface object is assigned to the role class interface; otherwise, `null`.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_RoleRequirementsType">RoleRequirementsType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />