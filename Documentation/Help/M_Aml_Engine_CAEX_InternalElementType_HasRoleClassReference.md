# InternalElementType.HasRoleClassReference Method (RoleFamilyType, Boolean)
AutomationML 2.1 API 

Determines whether this InternalElement object has an associated reference to the specified RoleClass. If inheritance relations between role classes should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified RoleClass is either identical to a referenced RoleClass or a referenced RoleClass is derived from the specified RoleClass.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool HasRoleClassReference(
	RoleFamilyType roleClass,
	bool regardInheritance = false
)
```

**VB**<br />
``` VB
Public Function HasRoleClassReference ( 
	roleClass As RoleFamilyType,
	Optional regardInheritance As Boolean = false
) As Boolean
```

**C++**<br />
``` C++
public:
bool HasRoleClassReference(
	RoleFamilyType^ roleClass, 
	bool regardInheritance = false
)
```


#### Parameters
&nbsp;<dl><dt>roleClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_RoleFamilyType">Aml.Engine.CAEX.RoleFamilyType</a><br />The RoleClass object.</dd><dt>regardInheritance (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` inheritance relations are regarded (default is `false`).</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if this InternalElement object has an associated reference to the specified RoleClass; otherwise, `false`.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>roleClass</td></tr></table>

## Examples
This sample shows how to call the HasRoleClassReference(RoleFamilyType, Boolean) method using a standard base RoleClass from the <a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLibType_RoleClassLib">RoleClassLib(CAEXDocument)</a>
```
var amlBaseRoleClassLib = AutomationMLBaseRoleClassLibType.RoleClassLib (myDocument);
InternalElementType internalElement;
...
internalElement.HasRoleClassReference (amlBaseRoleClassLib.AutomationMLBaseRole);
```


## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType Class</a><br /><a href="Overload_Aml_Engine_CAEX_InternalElementType_HasRoleClassReference">HasRoleClassReference Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />