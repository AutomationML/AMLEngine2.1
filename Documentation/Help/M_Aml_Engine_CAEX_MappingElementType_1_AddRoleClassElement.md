# MappingElementType(*T*).AddRoleClassElement Method 
AutomationML 2.1 API 

This method is an extension to the <a href="P_Aml_Engine_CAEX_MappingElementType_1_RoleClassElement">RoleClassElement</a> setter in case of MultipleRole assignments in AutomationML 2.0 based on CAEX 2.15. The method can assign a qualified RoleClassElement as a mapping element and will eventually create a missing RoleRequirement element for the qualified element. For Documents, based on CAEX 3.0 the behaviour of this method is identical to the <a href="P_Aml_Engine_CAEX_MappingElementType_1_RoleClassElement">RoleClassElement</a> setter.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public void AddRoleClassElement(
	T element
)
```

**VB**<br />
``` VB
Public Sub AddRoleClassElement ( 
	element As T
)
```

**C++**<br />
``` C++
public:
void AddRoleClassElement(
	T element
)
```


#### Parameters
&nbsp;<dl><dt>element</dt><dd>Type: <a href="T_Aml_Engine_CAEX_MappingElementType_1">*T*</a><br />The element.</dd></dl>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_MappingElementType_1">MappingElementType(T) Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />