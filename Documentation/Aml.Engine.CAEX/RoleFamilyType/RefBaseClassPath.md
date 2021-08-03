RoleFamilyType.RefBaseClassPath Property
========================================
AutomationML 2.1 APIGets and sets the path which references a base class. According to CAEX, a class shall not inherit from itself or from a derivative of itself, therefore any cyclic reference is denied.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public string RefBaseClassPath { get; set; }
```

#### Property Value
Type: [String][2]
#### Implements
[IClassWithBaseClassReference.RefBaseClassPath][3]  


See Also
--------

#### Reference
[RoleFamilyType Class][4]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: ../IClassWithBaseClassReference/RefBaseClassPath.md
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png