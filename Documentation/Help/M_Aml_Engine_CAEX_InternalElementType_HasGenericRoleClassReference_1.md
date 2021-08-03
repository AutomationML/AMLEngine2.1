# InternalElementType.HasGenericRoleClassReference Method (String)
AutomationML 2.1 API 

Determines whether this InternalElement object has an associated RoleClass reference which is a generalization of the specified CAEX path role reference.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool HasGenericRoleClassReference(
	string roleReference
)
```

**VB**<br />
``` VB
Public Function HasGenericRoleClassReference ( 
	roleReference As String
) As Boolean
```

**C++**<br />
``` C++
public:
bool HasGenericRoleClassReference(
	String^ roleReference
)
```


#### Parameters
&nbsp;<dl><dt>roleReference</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The role reference.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if this InternalElement object has an associated RoleClass reference which is a generalization of the specified CAEX path role reference; otherwise, `false`.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>roleReference</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType Class</a><br /><a href="Overload_Aml_Engine_CAEX_InternalElementType_HasGenericRoleClassReference">HasGenericRoleClassReference Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />