RoleRequirementsType.IsAssignableRoleClassAttribute Method
==========================================================
This method supports the Multiple Roles concept in AutomationML 2.0, based on CAEX 2.15. The method is not applicable for documents, based on CAEX 3.0 and later. It tests, if the provided attribute is a role class attributes of a supported role class object which can be used in a Multiple role mapping and is assignable to this RoleRequirements instance

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool IsAssignableRoleClassAttribute(
	AttributeType attribute
)
```

#### Parameters

##### *attribute*
Type: [Aml.Engine.CAEX.AttributeType][2]  
The tested attribute.

#### Return Value
Type: [Boolean][3]  
`true` if the attribute is an assignable role class attribute; otherwise, `false`. 

See Also
--------

#### Reference
[RoleRequirementsType Class][4]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../AttributeType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png