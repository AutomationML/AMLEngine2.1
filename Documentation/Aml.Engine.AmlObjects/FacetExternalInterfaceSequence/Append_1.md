FacetExternalInterfaceSequence.Append Method (String)
=====================================================
Appends a new element with the provided name to this sequence. Before the ExternalInterface is appended, it is checked, if the ExternalInterface name is already used for any ExternalInterface of the AMLFacet parent.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public override ExternalInterfaceType Append(
	string name
)
```

#### Parameters

##### *name*
Type: [System.String][2]  
The name of the new ExternalInterface object.

#### Return Value
Type: [ExternalInterfaceType][3]  
The appended ExternalInterface.

See Also
--------

#### Reference
[FacetExternalInterfaceSequence Class][4]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png