ObjectWithAMLAttributes.New_FrameAttribute Method
=================================================
AutomationML 2.1 APICreates a new Frame attribute for the [CAEXBase][1] if no Frame attribute exists. The provided values are used to initialize the Frame attribute values.

  **Namespace:**  [Aml.Engine.AmlObjects][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public FrameAttributeType New_FrameAttribute(
	FrameValues frameValues
)
```

#### Parameters

##### *frameValues*
Type: [Aml.Engine.AmlObjects.FrameValues][3]  
The frame values for initialization.

#### Return Value
Type: [FrameAttributeType][4]  
the new FrameAttributeType.

Remarks
-------
 AutomationML defines, that only one Frame attribute can be assigned to an object. If a Frame attribute exists, the frame values are set to the existing attribute. 

See Also
--------

#### Reference
[ObjectWithAMLAttributes Class][5]  
[Aml.Engine.AmlObjects Namespace][2]  

[1]: CAEXBase.md
[2]: ../README.md
[3]: ../FrameValues/README.md
[4]: ../FrameAttributeType/README.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png