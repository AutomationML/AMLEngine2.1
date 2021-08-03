AttributeFamilyType.BaseClass Property
======================================
Gets and sets the base class for this AttributeType. Setting a base class creates a class to class inheritance relation. Base classes are defined using the CAEX-Attribute [RefAttributeType][1] which is set to the CAEX-path of the base class. According to CAEX, a class shall not inherit from itself or from a derivative of itself, therefore any cyclic reference is denied.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public AttributeFamilyType BaseClass { get; set; }
```

#### Property Value
Type: [AttributeFamilyType][3]
#### Implements
[IClassWithBaseClassReference&lt;T>.BaseClass][4]  


See Also
--------

#### Reference
[AttributeFamilyType Class][3]  
[Aml.Engine.CAEX Namespace][2]  

[1]: ../AttributeTypeType/RefAttributeType.md
[2]: ../README.md
[3]: README.md
[4]: ../IClassWithBaseClassReference_1/BaseClass.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png