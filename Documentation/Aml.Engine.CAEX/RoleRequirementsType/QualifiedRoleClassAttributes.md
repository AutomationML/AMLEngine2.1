RoleRequirementsType.QualifiedRoleClassAttributes Property
==========================================================
Retrieves the [QualifiedAttributes][1] and gets the according original RoleClass Attribute of each qualified Attribute. This method is valid for documents based on CAEX 2.15 only. The qualification of attributes is a feature to assign multiple roles to an InternalElement.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<(RoleClassType RoleClass, AttributeType Attribute)> QualifiedRoleClassAttributes { get; }
```

#### Property Value
Type: [IEnumerable][3]&lt;[ValueTuple][4]&lt;[RoleClassType][5], [AttributeType][6]>>

See Also
--------

#### Reference
[RoleRequirementsType Class][7]  
[Aml.Engine.CAEX Namespace][2]  

[1]: QualifiedAttributes.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: https://docs.microsoft.com/dotnet/api/system.valuetuple-2
[5]: ../RoleClassType/README.md
[6]: ../AttributeType/README.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png