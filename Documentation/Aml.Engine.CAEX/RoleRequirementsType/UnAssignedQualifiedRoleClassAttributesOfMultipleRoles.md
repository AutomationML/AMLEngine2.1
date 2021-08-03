RoleRequirementsType.UnAssignedQualifiedRoleClassAttributesOfMultipleRoles Property
===================================================================================
AutomationML 2.1 APIThis property supports the Multiple Roles concept in AutomationML 2.0, based on CAEX 2.15. The property is not applicable for documents, based on CAEX 3.0 and later. It gets the role class attributes of supported role class objects which are not assigned to this RoleRequirements instance. The returned Attributes are created with a qualified Name, including the supported role class name, a separator string "." and the attribute name.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<AttributeType> UnAssignedQualifiedRoleClassAttributesOfMultipleRoles { get; }
```

#### Property Value
Type: [IEnumerable][2]&lt;[AttributeType][3]>

See Also
--------

#### Reference
[RoleRequirementsType Class][4]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[3]: ../AttributeType/README.md
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png