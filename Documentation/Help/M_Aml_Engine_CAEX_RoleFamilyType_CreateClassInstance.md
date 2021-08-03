# RoleFamilyType.CreateClassInstance Method 
AutomationML 2.1 API 

Creates a RoleRequirements object as an instance of this RoleClass object. All Base-Class references are resolved to create the instance - copying the Attribute and ExternalInterface objects to the created RoleRequirements object. The IDs of the ExternalInterface objects are made unique.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public RoleRequirementsType CreateClassInstance()
```

**VB**<br />
``` VB
Public Function CreateClassInstance As RoleRequirementsType
```

**C++**<br />
``` C++
public:
virtual RoleRequirementsType^ CreateClassInstance() sealed
```


#### Return Value
Type: <a href="T_Aml_Engine_CAEX_RoleRequirementsType">RoleRequirementsType</a><br />The RoleRequirements object

#### Implements
<a href="M_Aml_Engine_CAEX_IInstantiable_1_CreateClassInstance">IInstantiable(TINSTANCE).CreateClassInstance()</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_RoleFamilyType">RoleFamilyType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />