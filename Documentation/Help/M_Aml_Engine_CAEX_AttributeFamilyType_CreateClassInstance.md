# AttributeFamilyType.CreateClassInstance Method 
AutomationML 2.1 API 

Creates a class instance for this AttributeType object. All inherited base classes are resolved in the resulting Attribute. The Attribute collection of the new Attribute instance contains all inherited attributes from base classes."/>

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public AttributeType CreateClassInstance()
```

**VB**<br />
``` VB
Public Function CreateClassInstance As AttributeType
```

**C++**<br />
``` C++
public:
virtual AttributeType^ CreateClassInstance() sealed
```


#### Return Value
Type: <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a><br />The created Attribute object.

#### Implements
<a href="M_Aml_Engine_CAEX_IInstantiable_1_CreateClassInstance">IInstantiable(TINSTANCE).CreateClassInstance()</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_AttributeFamilyType">AttributeFamilyType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br /><a href="M_Aml_Engine_CAEX_AttributeFamilyType_GetReferenceHierarchy">AttributeFamilyType.GetReferenceHierarchy()</a><br />