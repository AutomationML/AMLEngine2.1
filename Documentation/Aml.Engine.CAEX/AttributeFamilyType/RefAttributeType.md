AttributeFamilyType.RefAttributeType Property
=============================================
Gets and sets the RefAttributeType CAEX attribute of the Attribute object. This property is used to create class to class relations between AttributeType objects (classes). According to CAEX, a class shall not inherit from itself or from a derivative of itself, therefore any cyclic reference is denied.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public override string RefAttributeType { get; set; }
```

#### Property Value
Type: [String][2]

See Also
--------

#### Reference
[AttributeFamilyType Class][3]  
[Aml.Engine.CAEX Namespace][1]  
[AttributeFamilyType.AttributeType][4]  
[AttributeType.AttributeTypeReference][5]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: README.md
[4]: AttributeType.md
[5]: ../AttributeType/AttributeTypeReference.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png