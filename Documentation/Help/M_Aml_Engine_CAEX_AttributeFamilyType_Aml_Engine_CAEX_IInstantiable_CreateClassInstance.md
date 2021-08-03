# AttributeFamilyType.IInstantiable.CreateClassInstance Method 
AutomationML 2.1 API 

Creates a class instance for this AttributeType object. All inherited base classes are resolved in the resulting Attribute.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
CAEXWrapperIInstantiable.CreateClassInstance()
```

**VB**<br />
``` VB
Private Function CreateClassInstance As CAEXWrapper
	Implements IInstantiable.CreateClassInstance
```

**C++**<br />
``` C++
private:
virtual CAEXWrapper^ CreateClassInstance() sealed = IInstantiable::CreateClassInstance
```


#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a><br />A CAEXWrapper of the created Attribute object.

#### Implements
<a href="M_Aml_Engine_CAEX_IInstantiable_CreateClassInstance">IInstantiable.CreateClassInstance()</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_AttributeFamilyType">AttributeFamilyType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br /><a href="M_Aml_Engine_CAEX_AttributeFamilyType_GetReferenceHierarchy">AttributeFamilyType.GetReferenceHierarchy()</a><br />