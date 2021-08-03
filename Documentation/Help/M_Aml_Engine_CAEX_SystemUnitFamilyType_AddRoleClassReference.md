# SystemUnitFamilyType.AddRoleClassReference Method (RoleFamilyType, Boolean)
AutomationML 2.1 API 

Adds a RoleClass reference to this SystemUnitClass object using the provided RoleClass object. The RoleClass reference is added as a <a href="T_Aml_Engine_CAEX_SupportedRoleClassType">SupportedRoleClassType</a> object.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IObjectWithRoleReference AddRoleClassReference(
	RoleFamilyType roleClass,
	bool addUnique = true
)
```

**VB**<br />
``` VB
Public Function AddRoleClassReference ( 
	roleClass As RoleFamilyType,
	Optional addUnique As Boolean = true
) As IObjectWithRoleReference
```

**C++**<br />
``` C++
public:
IObjectWithRoleReference^ AddRoleClassReference(
	RoleFamilyType^ roleClass, 
	bool addUnique = true
)
```


#### Parameters
&nbsp;<dl><dt>roleClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_RoleFamilyType">Aml.Engine.CAEX.RoleFamilyType</a><br />The RoleClass to be assigned to the SystemUnitClass.</dd><dt>addUnique (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true`, the RoleClass reference is not added, if a reference to the provided RoleClass already exists.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_IObjectWithRoleReference">IObjectWithRoleReference</a><br />The new added RoleClass reference.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>roleClass</td></tr></table>

## Examples
This sample shows how to call the AddRoleClassReference(RoleFamilyType, Boolean) method using a standard base RoleClass from the <a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLibType_RoleClassLib">RoleClassLib(CAEXDocument)</a>
```
var amlBaseRoleClassLib = AutomationMLBaseRoleClassLibType.RoleClassLib (myDocument);
var mySlib = myDocument.CAEXFile.SystemUnitClassLib.Append ("mySlib");
var mySuc = mySlib.SystemUnitClass.Append("mySuc");
mySuc.AddRoleClassReference (amlBaseRoleClassLib.AutomationMLBaseRole);
```


## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType Class</a><br /><a href="Overload_Aml_Engine_CAEX_SystemUnitFamilyType_AddRoleClassReference">AddRoleClassReference Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />