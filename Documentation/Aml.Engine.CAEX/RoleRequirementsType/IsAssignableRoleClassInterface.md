RoleRequirementsType.IsAssignableRoleClassInterface Method
==========================================================
AutomationML 2.1 APIThis method supports the Multiple Roles concept in AutomationML 2.0, based on CAEX 2.15. The method is not applicable for documents, based on CAEX 3.0 and later. It tests, if the provided ExternalInterface object is a role class interface of a supported role class object which can be used in a Multiple role mapping and is assignable to this RoleRequirements instance

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool IsAssignableRoleClassInterface(
	ExternalInterfaceType externalInterface
)
```

#### Parameters

##### *externalInterface*
Type: [Aml.Engine.CAEX.ExternalInterfaceType][2]  
The tested external interface.

#### Return Value
Type: [Boolean][3]  
`true` if the ExternalInterface object is an assignable role class interface; otherwise, `false`. 

See Also
--------

#### Reference
[RoleRequirementsType Class][4]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../ExternalInterfaceType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png