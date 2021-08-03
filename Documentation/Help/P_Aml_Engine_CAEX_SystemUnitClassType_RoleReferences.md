# SystemUnitClassType.RoleReferences Property 
AutomationML 2.1 API 

Gets all role references for the SystemUnitClass. The collection includes all RoleRequirement objects and SupportedRoleClass objects.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public virtual IEnumerable<IObjectWithRoleReference> RoleReferences { get; }
```

**VB**<br />
``` VB
Public Overridable ReadOnly Property RoleReferences As IEnumerable(Of IObjectWithRoleReference)
	Get
```

**C++**<br />
``` C++
public:
virtual property IEnumerable<IObjectWithRoleReference^>^ RoleReferences {
	IEnumerable<IObjectWithRoleReference^>^ get ();
}
```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_IObjectWithRoleReference">IObjectWithRoleReference</a>)

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />