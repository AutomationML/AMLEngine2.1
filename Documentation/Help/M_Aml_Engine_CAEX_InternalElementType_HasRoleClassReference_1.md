# InternalElementType.HasRoleClassReference Method (String, Boolean)
AutomationML 2.1 API 

Determines whether this InternalElement object has an associated RoleClass reference with the specified CAEX path role reference. If inheritance relations between role classes should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified RoleClass is either identical to a referenced RoleClass or a referenced RoleClass is derived from the specified RoleClass.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool HasRoleClassReference(
	string roleReference,
	bool regardInheritance = false
)
```

**VB**<br />
``` VB
Public Function HasRoleClassReference ( 
	roleReference As String,
	Optional regardInheritance As Boolean = false
) As Boolean
```

**C++**<br />
``` C++
public:
bool HasRoleClassReference(
	String^ roleReference, 
	bool regardInheritance = false
)
```


#### Parameters
&nbsp;<dl><dt>roleReference</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The role reference.</dd><dt>regardInheritance (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` inheritance relations are regarded (default is `false`).</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if this InternalElement object has an associated RoleClass reference with the specified CAEX path role reference; otherwise, `false`.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>roleReference</td></tr></table>

## Examples
This sample shows how to call the HasRoleClassReference(String, Boolean) method using a standard base RoleClass path from the <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLib">AutomationMLBaseRoleClassLib</a>
```
InternalElementType internalElement;
...
internalElement.HasRoleClassReference (AutomationMLBaseRoleClassLib.AutomationMLBaseRole);
```


## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType Class</a><br /><a href="Overload_Aml_Engine_CAEX_InternalElementType_HasRoleClassReference">HasRoleClassReference Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />