# SystemUnitFamilyType.AddRoleClassReference Method (String, Boolean)
AutomationML 2.1 API 

Adds a RoleClass reference to this SystemUnitClass object using the provided CAEX path, referencing a RoleClass object. The RoleClass reference is added as a <a href="T_Aml_Engine_CAEX_SupportedRoleClassType">SupportedRoleClassType</a> object.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IObjectWithRoleReference AddRoleClassReference(
	string roleClassReference,
	bool addUnique = true
)
```

**VB**<br />
``` VB
Public Function AddRoleClassReference ( 
	roleClassReference As String,
	Optional addUnique As Boolean = true
) As IObjectWithRoleReference
```

**C++**<br />
``` C++
public:
IObjectWithRoleReference^ AddRoleClassReference(
	String^ roleClassReference, 
	bool addUnique = true
)
```


#### Parameters
&nbsp;<dl><dt>roleClassReference</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The CAEX path referencing a RoleClass to be assigned to the SystemUnitClass.</dd><dt>addUnique (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` the reference is not added, if the same reference already exists.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_IObjectWithRoleReference">IObjectWithRoleReference</a><br />The new added RoleClass reference, which is a SupportedRoleClass.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>roleClassReference</td></tr></table>

## Examples
This sample shows how to call the AddRoleClassReference(String, Boolean) method using a standard RoleClass path defined in the <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>
```
var mySlib = myDocument.CAEXFile.SystemUnitClassLib.Append ("mySlib");
var mySuc = mySlib.SystemUnitClass.Append("mySuc");
mySuc.AddRoleClassReference (AutomationMLBaseRoleClassLib.AutomationMLBaseRole);
```


## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType Class</a><br /><a href="Overload_Aml_Engine_CAEX_SystemUnitFamilyType_AddRoleClassReference">AddRoleClassReference Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />