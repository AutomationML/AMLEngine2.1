AMLGroup.CAEXSequence Method
============================
AutomationML 2.1 APIGets the CAEXSequence owned by this CAEX object, which contains the specified CAEX object.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public override ICAEXSequence CAEXSequence(
	ICAEXWrapper caexObject
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.ICAEXWrapper][2]  
The CAEX object, contained in a sequence, owned by this CAEX object.

#### Return Value
Type: [ICAEXSequence][3]  
 The CAEX sequence or null, if no sequence exists, containing the specified CAEX object. 
#### Implements
[ICAEXBasicObject.CAEXSequence(ICAEXWrapper)][4]  
[ICAEXBasicObject.CAEXSequence(ICAEXWrapper)][4]  
[ICAEXBasicObject.CAEXSequence(ICAEXWrapper)][4]  


See Also
--------

#### Reference
[AMLGroup Class][5]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/ICAEXWrapper/README.md
[3]: ../../Aml.Engine.CAEX/ICAEXSequence/README.md
[4]: ../../Aml.Engine.CAEX/ICAEXBasicObject/CAEXSequence.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png