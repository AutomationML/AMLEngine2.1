# MappingElementType(*T*).RoleClassElement Property 
AutomationML 2.1 API 

Gets the RoleClass element which can be identified with the <a href="P_Aml_Engine_CAEX_MappingElementType_1_RoleClassElementIdentifier">RoleClassElementIdentifier</a> or sets the <a href="P_Aml_Engine_CAEX_MappingElementType_1_RoleClassElementIdentifier">RoleClassElementIdentifier</a> extracted from the provided CAEXObject which shall be an AttributeType for an attribute mapping or an ExternalInterfaceType for an interface mapping. If the provided CAEXobject is not applicable for the Mapping, the <a href="P_Aml_Engine_CAEX_MappingElementType_1_RoleClassElementIdentifier">RoleClassElementIdentifier</a> is not changed.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public T RoleClassElement { get; set; }
```

**VB**<br />
``` VB
Public Property RoleClassElement As T
	Get
	Set
```

**C++**<br />
``` C++
public:
property T RoleClassElement {
	T get ();
	void set (T value);
}
```


#### Property Value
Type: <a href="T_Aml_Engine_CAEX_MappingElementType_1">*T*</a>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_MappingElementType_1">MappingElementType(T) Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />