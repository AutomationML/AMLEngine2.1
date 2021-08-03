AttributeNameMappingType.RoleAttribute Property
===============================================
Gets the RoleClass element which can be identified with the [RoleAttributeName][1] or sets the [RoleAttributeName][1] retrieved from the provided value.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public AttributeType RoleAttribute { get; set; }
```

#### Property Value
Type: [AttributeType][3]  
 The role attribute. 

Remarks
-------
 If the [RoleAttributeName][1] identifies a RoleRequirements Attribute and a RoleClass Attribute as well, the RoleClass Attribute is returned by the Getter. 

See Also
--------

#### Reference
[AttributeNameMappingType Class][4]  
[Aml.Engine.CAEX Namespace][2]  

[1]: RoleAttributeName.md
[2]: ../README.md
[3]: ../AttributeType/README.md
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png