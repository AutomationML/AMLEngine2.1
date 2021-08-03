# SystemUnitFamilyType.CreateClassInstance Method 
AutomationML 2.1 API 

Creates an InternalElement as an instance of this class. All References to Base classes are resolved.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public InternalElementType CreateClassInstance()
```

**VB**<br />
``` VB
Public Function CreateClassInstance As InternalElementType
```

**C++**<br />
``` C++
public:
virtual InternalElementType^ CreateClassInstance() sealed
```


#### Return Value
Type: <a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a><br />The InternalElement

#### Implements
<a href="M_Aml_Engine_CAEX_IInstantiable_1_CreateClassInstance">IInstantiable(TINSTANCE).CreateClassInstance()</a><br />

## Remarks
If the document is based on CAEX 2.15 and the SystemUnitClass provides only one Supported role class, the created Internal Element will contain a role requirement object, representing the role.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />