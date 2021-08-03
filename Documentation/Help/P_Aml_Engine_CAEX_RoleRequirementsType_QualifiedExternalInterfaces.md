# RoleRequirementsType.QualifiedExternalInterfaces Property 
AutomationML 2.1 API 

Gets the collection of CAEX External Interfaces from the <a href="P_Aml_Engine_CAEX_RoleRequirementsType_ExternalInterface">ExternalInterface</a> which are qualified with the name of a SupportedRoleClass. This method is valid for documents based on CAEX 2.15 only. The qualification of ExternalInterfaces is a feature to assign multiple roles to an InternalElement and apply a mapping to the Interface objects.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<ExternalInterfaceType> QualifiedExternalInterfaces { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property QualifiedExternalInterfaces As IEnumerable(Of ExternalInterfaceType)
	Get
```

**C++**<br />
``` C++
public:
property IEnumerable<ExternalInterfaceType^>^ QualifiedExternalInterfaces {
	IEnumerable<ExternalInterfaceType^>^ get ();
}
```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a>)

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_RoleRequirementsType">RoleRequirementsType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />