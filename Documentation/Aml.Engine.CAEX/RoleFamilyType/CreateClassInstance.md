RoleFamilyType.CreateClassInstance Method
=========================================
AutomationML 2.1 APICreates a RoleRequirements object as an instance of this RoleClass object. All Base-Class references are resolved to create the instance - copying the Attribute and ExternalInterface objects to the created RoleRequirements object. The IDs of the ExternalInterface objects are made unique.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public RoleRequirementsType CreateClassInstance()
```

#### Return Value
Type: [RoleRequirementsType][2]  
The RoleRequirements object
#### Implements
[IInstantiable&lt;TINSTANCE>.CreateClassInstance()][3]  


See Also
--------

#### Reference
[RoleFamilyType Class][4]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../RoleRequirementsType/README.md
[3]: ../IInstantiable_1/CreateClassInstance.md
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png