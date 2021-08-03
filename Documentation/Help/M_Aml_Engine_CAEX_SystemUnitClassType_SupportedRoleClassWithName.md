# SystemUnitClassType.SupportedRoleClassWithName Method 
AutomationML 2.1 API 

Get the RoleClass from the sequence of <a href="P_Aml_Engine_CAEX_SystemUnitClassType_SupportedRoleClass">SupportedRoleClass</a> with the provided *roleClassName*.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public RoleFamilyType SupportedRoleClassWithName(
	string roleClassName
)
```

**VB**<br />
``` VB
Public Function SupportedRoleClassWithName ( 
	roleClassName As String
) As RoleFamilyType
```

**C++**<br />
``` C++
public:
RoleFamilyType^ SupportedRoleClassWithName(
	String^ roleClassName
)
```


#### Parameters
&nbsp;<dl><dt>roleClassName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Name of the role class.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_RoleFamilyType">RoleFamilyType</a><br />The supported RoleClass object with the provided name if existent, otherwise `null`.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />