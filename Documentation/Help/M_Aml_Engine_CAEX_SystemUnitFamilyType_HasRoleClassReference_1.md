# SystemUnitFamilyType.HasRoleClassReference Method (String, Boolean)
AutomationML 2.1 API 

Determines whether this SystemUnitClass object has a SupportedRoleClass with the specified CAEX path reference. If inheritance relation should be regarded, the optional parameter 'regardInheritance' should be set.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool HasRoleClassReference(
	string roleClassReference,
	bool regardInheritance = false
)
```

**VB**<br />
``` VB
Public Function HasRoleClassReference ( 
	roleClassReference As String,
	Optional regardInheritance As Boolean = false
) As Boolean
```

**C++**<br />
``` C++
public:
bool HasRoleClassReference(
	String^ roleClassReference, 
	bool regardInheritance = false
)
```


#### Parameters
&nbsp;<dl><dt>roleClassReference</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The CAEX path to a RoleClass object.</dd><dt>regardInheritance (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` inheritance relations are regarded (default is `false`).</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if this SystemUnitClass object has a SupportedRoleClass with the specified CAEX path reference.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>roleClass</td></tr></table>

## Examples
This sample shows how to call the HasRoleClassReference(String, Boolean) method using a standard base RoleClass path from the <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>
```
SystemUnitFamilyType systemUnitClass;
...
systemUnitClass.HasRoleReference (AutomationMLBaseRoleClassLib.AutomationMLBaseRole);
```


## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType Class</a><br /><a href="Overload_Aml_Engine_CAEX_SystemUnitFamilyType_HasRoleClassReference">HasRoleClassReference Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />