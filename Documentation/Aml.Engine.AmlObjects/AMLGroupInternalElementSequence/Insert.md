AMLGroupInternalElementSequence.Insert Method
=============================================
AutomationML 2.1 APIInserts the specified InternalElement into this sequence. Before the InternalElement is inserted, it is checked, if it is a valid Group-InternalElement.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public override InternalElementType Insert(
	InternalElementType internalElement,
	bool asFirst = true
)
```

#### Parameters

##### *internalElement*
Type: [Aml.Engine.CAEX.InternalElementType][2]  
The InternalElement.

##### *asFirst* (Optional)
Type: [System.Boolean][3]  
 optional parameter, if set to `true (default)` the element is prepended to already existing ones, otherwise it is appended.

#### Return Value
Type: [InternalElementType][2]  

[Missing &lt;returns> documentation for "M:Aml.Engine.AmlObjects.AMLGroupInternalElementSequence.Insert(Aml.Engine.CAEX.InternalElementType,System.Boolean)"]


See Also
--------

#### Reference
[AMLGroupInternalElementSequence Class][4]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/InternalElementType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png