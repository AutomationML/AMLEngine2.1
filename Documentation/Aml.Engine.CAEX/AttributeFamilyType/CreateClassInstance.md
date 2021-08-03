AttributeFamilyType.CreateClassInstance Method
==============================================
Creates a class instance for this AttributeType object. All inherited base classes are resolved in the resulting Attribute. The Attribute collection of the new Attribute instance contains all inherited attributes from base classes."/>

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public AttributeType CreateClassInstance()
```

#### Return Value
Type: [AttributeType][2]  
The created Attribute object.
#### Implements
[IInstantiable&lt;TINSTANCE>.CreateClassInstance()][3]  


See Also
--------

#### Reference
[AttributeFamilyType Class][4]  
[Aml.Engine.CAEX Namespace][1]  
[AttributeFamilyType.GetReferenceHierarchy()][5]  

[1]: ../README.md
[2]: ../AttributeType/README.md
[3]: ../IInstantiable_1/CreateClassInstance.md
[4]: README.md
[5]: GetReferenceHierarchy.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png