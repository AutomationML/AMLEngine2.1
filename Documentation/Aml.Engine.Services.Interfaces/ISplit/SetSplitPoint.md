ISplit.SetSplitPoint Method
===========================
AutomationML 2.1 APISets the split point for the provided CAEX object. If the actual list of split points for the same document already contains a split point which is a child of the provided CAEX object, this existing split point is removed from the list.

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
void SetSplitPoint(
	ISplitPoint caexObject
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.Services.Interfaces.ISplitPoint][2]  
The CAEX object.


See Also
--------

#### Reference
[ISplit Interface][3]  
[Aml.Engine.Services.Interfaces Namespace][1]  

[1]: ../README.md
[2]: ../ISplitPoint/README.md
[3]: README.md
[4]: https://www.automationml.org
[5]: ../../icons/logoShade.png