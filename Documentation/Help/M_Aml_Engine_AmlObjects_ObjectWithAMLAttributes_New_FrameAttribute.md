# ObjectWithAMLAttributes.New_FrameAttribute Method 
AutomationML 2.1 API 

Creates a new Frame attribute for the <a href="P_Aml_Engine_AmlObjects_ObjectWithAMLAttributes_CAEXBase">CAEXBase</a> if no Frame attribute exists. The provided values are used to initialize the Frame attribute values.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public FrameAttributeType New_FrameAttribute(
	FrameValues frameValues
)
```

**VB**<br />
``` VB
Public Function New_FrameAttribute ( 
	frameValues As FrameValues
) As FrameAttributeType
```

**C++**<br />
``` C++
public:
FrameAttributeType^ New_FrameAttribute(
	FrameValues^ frameValues
)
```


#### Parameters
&nbsp;<dl><dt>frameValues</dt><dd>Type: <a href="T_Aml_Engine_AmlObjects_FrameValues">Aml.Engine.AmlObjects.FrameValues</a><br />The frame values for initialization.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_AmlObjects_FrameAttributeType">FrameAttributeType</a><br />the new FrameAttributeType.

## Remarks
AutomationML defines, that only one Frame attribute can be assigned to an object. If a Frame attribute exists, the frame values are set to the existing attribute.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_ObjectWithAMLAttributes">ObjectWithAMLAttributes Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />