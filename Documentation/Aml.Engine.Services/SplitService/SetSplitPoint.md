SplitService.SetSplitPoint Method
=================================
AutomationML 2.1 APISets the split point for the provided CAEX object. If the actual list of split points for the same document already contains a split point which is a child of the provided CAEX object, this existing split point is removed from the list.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public void SetSplitPoint(
	ISplitPoint caexObject
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.Services.Interfaces.ISplitPoint][2]  
The CAEX object.

#### Implements
[ISplit.SetSplitPoint(ISplitPoint)][3]  


See Also
--------

#### Reference
[SplitService Class][4]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.Services.Interfaces/ISplitPoint/README.md
[3]: ../../Aml.Engine.Services.Interfaces/ISplit/SetSplitPoint.md
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png