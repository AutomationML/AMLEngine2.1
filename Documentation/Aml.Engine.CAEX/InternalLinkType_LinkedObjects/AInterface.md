InternalLinkType.LinkedObjects.AInterface Property
==================================================
Gets the A-Interface of the InternalLink by interpretation of the [RefPartnerSideA][1] Attribute on first access. Consecutive reads will return the at first calculated value. A Reinterpretation is performed, when the respective InternalLink property [AInterface][2] is read or set.

  **Namespace:**  [Aml.Engine.CAEX][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public ExternalInterfaceType AInterface { get; }
```

#### Property Value
Type: [ExternalInterfaceType][4]

See Also
--------

#### Reference
[InternalLinkType.LinkedObjects Class][5]  
[Aml.Engine.CAEX Namespace][3]  

[1]: ../InternalLinkType/RefPartnerSideA.md
[2]: ../InternalLinkType/AInterface.md
[3]: ../README.md
[4]: ../ExternalInterfaceType/README.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png