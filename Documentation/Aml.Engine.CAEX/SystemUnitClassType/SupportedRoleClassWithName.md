SystemUnitClassType.SupportedRoleClassWithName Method
=====================================================
AutomationML 2.1 APIGet the RoleClass from the sequence of [SupportedRoleClass][1] with the provided *roleClassName*.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public RoleFamilyType SupportedRoleClassWithName(
	string roleClassName
)
```

#### Parameters

##### *roleClassName*
Type: [System.String][3]  
Name of the role class.

#### Return Value
Type: [RoleFamilyType][4]  
The supported RoleClass object with the provided name if existent, otherwise `null`.

See Also
--------

#### Reference
[SystemUnitClassType Class][5]  
[Aml.Engine.CAEX Namespace][2]  

[1]: SupportedRoleClass.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: ../RoleFamilyType/README.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png