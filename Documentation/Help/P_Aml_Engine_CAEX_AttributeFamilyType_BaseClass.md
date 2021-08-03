# AttributeFamilyType.BaseClass Property 
AutomationML 2.1 API 

Gets and sets the base class for this AttributeType. Setting a base class creates a class to class inheritance relation. Base classes are defined using the CAEX-Attribute <a href="P_Aml_Engine_CAEX_AttributeTypeType_RefAttributeType">RefAttributeType</a> which is set to the CAEX-path of the base class. According to CAEX, a class shall not inherit from itself or from a derivative of itself, therefore any cyclic reference is denied.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public AttributeFamilyType BaseClass { get; set; }
```

**VB**<br />
``` VB
Public Property BaseClass As AttributeFamilyType
	Get
	Set
```

**C++**<br />
``` C++
public:
virtual property AttributeFamilyType^ BaseClass {
	AttributeFamilyType^ get () sealed;
	void set (AttributeFamilyType^ value) sealed;
}
```


#### Property Value
Type: <a href="T_Aml_Engine_CAEX_AttributeFamilyType">AttributeFamilyType</a>

#### Implements
<a href="P_Aml_Engine_CAEX_IClassWithBaseClassReference_1_BaseClass">IClassWithBaseClassReference(T).BaseClass</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_AttributeFamilyType">AttributeFamilyType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />