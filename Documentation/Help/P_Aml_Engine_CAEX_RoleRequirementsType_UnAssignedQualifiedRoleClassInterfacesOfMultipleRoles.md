# RoleRequirementsType.UnAssignedQualifiedRoleClassInterfacesOfMultipleRoles Property 
AutomationML 2.1 API 

This property supports the Multiple Roles concept in AutomationML 2.0, based on CAEX 2.15. The property is not applicable for documents, based on CAEX 3.0 and later. It gets the role class interfaces of supported role class objects which are not assigned to this RoleRequirements instance. The returned ExternalInterfaces are created with a qualified Name, including the supported role class name, a separator string "." and the interface name.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<ExternalInterfaceType> UnAssignedQualifiedRoleClassInterfacesOfMultipleRoles { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property UnAssignedQualifiedRoleClassInterfacesOfMultipleRoles As IEnumerable(Of ExternalInterfaceType)
	Get
```

**C++**<br />
``` C++
public:
property IEnumerable<ExternalInterfaceType^>^ UnAssignedQualifiedRoleClassInterfacesOfMultipleRoles {
	IEnumerable<ExternalInterfaceType^>^ get ();
}
```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a>)

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_RoleRequirementsType">RoleRequirementsType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />