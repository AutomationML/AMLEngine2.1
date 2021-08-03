# AttributeNameMappingType.RoleAttribute Property 
AutomationML 2.1 API 

Gets the RoleClass element which can be identified with the <a href="P_Aml_Engine_CAEX_AttributeNameMappingType_RoleAttributeName">RoleAttributeName</a> or sets the <a href="P_Aml_Engine_CAEX_AttributeNameMappingType_RoleAttributeName">RoleAttributeName</a> retrieved from the provided value.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public AttributeType RoleAttribute { get; set; }
```

**VB**<br />
``` VB
Public Property RoleAttribute As AttributeType
	Get
	Set
```

**C++**<br />
``` C++
public:
property AttributeType^ RoleAttribute {
	AttributeType^ get ();
	void set (AttributeType^ value);
}
```


#### Property Value
Type: <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a><br />The role attribute.

## Remarks
If the <a href="P_Aml_Engine_CAEX_AttributeNameMappingType_RoleAttributeName">RoleAttributeName</a> identifies a RoleRequirements Attribute and a RoleClass Attribute as well, the RoleClass Attribute is returned by the Getter.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_AttributeNameMappingType">AttributeNameMappingType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />