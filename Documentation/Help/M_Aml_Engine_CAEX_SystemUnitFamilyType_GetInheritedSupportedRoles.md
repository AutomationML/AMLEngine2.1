# SystemUnitFamilyType.GetInheritedSupportedRoles Method 
AutomationML 2.1 API 

Gets a collection of SupportedRoleClasses objects of this SystemUnitClass and of all inherited BaseClasses. Duplicates are removed from the result.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<SupportedRoleClassType> GetInheritedSupportedRoles()
```

**VB**<br />
``` VB
Public Function GetInheritedSupportedRoles As IEnumerable(Of SupportedRoleClassType)
```

**C++**<br />
``` C++
public:
IEnumerable<SupportedRoleClassType^>^ GetInheritedSupportedRoles()
```


#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_SupportedRoleClassType">SupportedRoleClassType</a>)<br />A collection of SupportedRoleClass objects for this instance and its BaseClasses.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />