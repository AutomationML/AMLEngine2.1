# SystemUnitFamilyType.BaseClass Property 
AutomationML 2.1 API 

Gets and sets the BaseClass for this instance. According to CAEX, a class shall not inherit from itself or from a derivative of itself, therefore any cyclic reference is denied.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public SystemUnitFamilyType BaseClass { get; set; }
```

**VB**<br />
``` VB
Public Property BaseClass As SystemUnitFamilyType
	Get
	Set
```

**C++**<br />
``` C++
public:
virtual property SystemUnitFamilyType^ BaseClass {
	SystemUnitFamilyType^ get () sealed;
	void set (SystemUnitFamilyType^ value) sealed;
}
```


#### Property Value
Type: <a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType</a>

#### Implements
<a href="P_Aml_Engine_CAEX_IClassWithBaseClassReference_1_BaseClass">IClassWithBaseClassReference(T).BaseClass</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />