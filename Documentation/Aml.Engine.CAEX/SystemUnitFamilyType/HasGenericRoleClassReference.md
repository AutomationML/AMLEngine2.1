SystemUnitFamilyType.HasGenericRoleClassReference Method (RoleFamilyType)
=========================================================================
Determines whether the specified RoleClass is more specific than any already associated RoleClass of this SystemUnitClass. This method doesn't check inherited RoleClass references from ancestors. If an assigned RoleClass is identical to the specified RoleClass, the result is `false`.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool HasGenericRoleClassReference(
	RoleFamilyType roleClass
)
```

#### Parameters

##### *roleClass*
Type: [Aml.Engine.CAEX.RoleFamilyType][2]  
The RoleClass object.

#### Return Value
Type: [Boolean][3]  
`true` if this SystemUnitFamilyType object has an associated RoleClass reference which is a generalization of the specified RoleClass (the RoleClass is more specific); otherwise, `false`. 

Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][4] | roleClass 


See Also
--------

#### Reference
[SystemUnitFamilyType Class][5]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../RoleFamilyType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png