# InternalElementType.ReplaceRoleClassReference Method 
AutomationML 2.1 API 

Replaces an existing role class reference to the provided role or any generic base role of the provided role by a new instance of the role class.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IObjectWithRoleReference ReplaceRoleClassReference(
	RoleFamilyType roleClass,
	bool addSupportedRoleClass = false
)
```

**VB**<br />
``` VB
Public Function ReplaceRoleClassReference ( 
	roleClass As RoleFamilyType,
	Optional addSupportedRoleClass As Boolean = false
) As IObjectWithRoleReference
```

**C++**<br />
``` C++
public:
IObjectWithRoleReference^ ReplaceRoleClassReference(
	RoleFamilyType^ roleClass, 
	bool addSupportedRoleClass = false
)
```


#### Parameters
&nbsp;<dl><dt>roleClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_RoleFamilyType">Aml.Engine.CAEX.RoleFamilyType</a><br />The role class.</dd><dt>addSupportedRoleClass (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` a supported role class is created.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_IObjectWithRoleReference">IObjectWithRoleReference</a><br />\[Missing <returns> documentation for "M:Aml.Engine.CAEX.InternalElementType.ReplaceRoleClassReference(Aml.Engine.CAEX.RoleFamilyType,System.Boolean)"\]

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>roleClass</td></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>roleClass</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />