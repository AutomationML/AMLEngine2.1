AMLFacet.SourceInterface Method
===============================
AutomationML 2.1 APIGets the original ExternalInterface from the [AssignedParentInterfaces()][1] which is related to this Facet Interface.

  **Namespace:**  [Aml.Engine.AmlObjects][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public ExternalInterfaceType SourceInterface(
	ExternalInterfaceType facetInterface
)
```

#### Parameters

##### *facetInterface*
Type: [Aml.Engine.CAEX.ExternalInterfaceType][3]  
The facet ExternalInterface.

#### Return Value
Type: [ExternalInterfaceType][3]  
An ExternalInterface from the parent with the same name.

Remarks
-------
 In CAEX 3.0 the Source Interface is the Master Interface of the *facetInterface*. CAEX 2.15 the Source Interface is the first identified Interface of the parent with an identical name. 

See Also
--------

#### Reference
[AMLFacet Class][4]  
[Aml.Engine.AmlObjects Namespace][2]  

[1]: AssignedParentInterfaces.md
[2]: ../README.md
[3]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png