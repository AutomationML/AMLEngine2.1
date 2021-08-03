RoleRequirementsType.AssignQualifiedRoleClassInterface Method
=============================================================
This method supports the Multiple Roles concept in AutomationML 2.0, based on CAEX 2.15. The method is not applicable for documents, based on CAEX 3.0 and later. It tests, if the provided ExternalInterface object is a role class interface of a supported role class object which can be used in a Multiple role mapping and assigns it to this RoleRequirements instance.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public ExternalInterfaceType AssignQualifiedRoleClassInterface(
	ExternalInterfaceType externalInterface
)
```

#### Parameters

##### *externalInterface*
Type: [Aml.Engine.CAEX.ExternalInterfaceType][2]  
The tested external interface.

#### Return Value
Type: [ExternalInterfaceType][2]  
 the newly created and assigned ExternalInterface, if the ExternalInterface object is assigned to the role class interface; otherwise, `null`. 

See Also
--------

#### Reference
[RoleRequirementsType Class][3]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../ExternalInterfaceType/README.md
[3]: README.md
[4]: https://www.automationml.org
[5]: ../../icons/logoShade.png