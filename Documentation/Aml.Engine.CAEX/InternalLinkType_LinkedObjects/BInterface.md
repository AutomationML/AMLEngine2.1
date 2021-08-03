InternalLinkType.LinkedObjects.BInterface Property
==================================================
AutomationML 2.1 APIGets the B-Interface of the InternalLink by interpretation of the [RefPartnerSideB][1] Attribute on first access. Consecutive reads will return the at first calculated value. A Reinterpretation is performed, when the respective InternalLink property [BInterface][2] is read or set.

  **Namespace:**  [Aml.Engine.CAEX][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public ExternalInterfaceType BInterface { get; }
```

#### Property Value
Type: [ExternalInterfaceType][4]

See Also
--------

#### Reference
[InternalLinkType.LinkedObjects Class][5]  
[Aml.Engine.CAEX Namespace][3]  

[1]: ../InternalLinkType/RefPartnerSideB.md
[2]: ../InternalLinkType/BInterface.md
[3]: ../README.md
[4]: ../ExternalInterfaceType/README.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png