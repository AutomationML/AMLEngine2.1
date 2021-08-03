RoleRequirementsType.HasRoleClassReference Method
=================================================
AutomationML 2.1 APIDetermines whether this RoleRequirements object has an associated reference to the provided RoleClass. If inheritance relations between RoleClasses should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified RoleClass is either identical to the referenced RoleClass or the referenced RoleClass is derived from the provided RoleClass.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool HasRoleClassReference(
	RoleFamilyType roleClass,
	bool regardInheritance = false
)
```

#### Parameters

##### *roleClass*
Type: [Aml.Engine.CAEX.RoleFamilyType][2]  
The RoleClass object.

##### *regardInheritance* (Optional)
Type: [System.Boolean][3]  
 if set to `true` inheritance relations are regarded (default is `false`).

#### Return Value
Type: [Boolean][3]  
`true` if this RoleRequirement object has an associated reference to the specified RoleClass; otherwise, `false`. 

Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][4] | roleClass 


See Also
--------

#### Reference
[RoleRequirementsType Class][5]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../RoleFamilyType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png