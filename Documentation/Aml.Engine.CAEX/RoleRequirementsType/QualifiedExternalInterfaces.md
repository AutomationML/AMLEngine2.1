RoleRequirementsType.QualifiedExternalInterfaces Property
=========================================================
AutomationML 2.1 APIGets the collection of CAEX External Interfaces from the [ExternalInterface][1] which are qualified with the name of a SupportedRoleClass. This method is valid for documents based on CAEX 2.15 only. The qualification of ExternalInterfaces is a feature to assign multiple roles to an InternalElement and apply a mapping to the Interface objects.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<ExternalInterfaceType> QualifiedExternalInterfaces { get; }
```

#### Property Value
Type: [IEnumerable][3]&lt;[ExternalInterfaceType][4]>

See Also
--------

#### Reference
[RoleRequirementsType Class][5]  
[Aml.Engine.CAEX Namespace][2]  

[1]: ExternalInterface.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: ../ExternalInterfaceType/README.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png