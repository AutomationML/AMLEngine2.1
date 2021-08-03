FacetExternalInterfaceSequence.Insert Method
============================================
Inserts the specified ExternalInterface into this sequence. Before the ExternalInterface is inserted, it is checked, if it is a valid Facet-ExternalInterface.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public override ExternalInterfaceType Insert(
	ExternalInterfaceType extInterface,
	bool asFirst = true
)
```

#### Parameters

##### *extInterface*
Type: [Aml.Engine.CAEX.ExternalInterfaceType][2]  
The ExternalInterface.

##### *asFirst* (Optional)
Type: [System.Boolean][3]  
 optional parameter, if set to `true (default)` the element is prepended to already existing ones, otherwise it is appended.

#### Return Value
Type: [ExternalInterfaceType][2]  

[Missing &lt;returns> documentation for "M:Aml.Engine.AmlObjects.FacetExternalInterfaceSequence.Insert(Aml.Engine.CAEX.ExternalInterfaceType,System.Boolean)"]


See Also
--------

#### Reference
[FacetExternalInterfaceSequence Class][4]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png