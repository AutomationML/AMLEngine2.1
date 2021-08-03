InternalElementType.HasGenericRoleClassReference Method (RoleFamilyType)
========================================================================
AutomationML 2.1 APIDetermines whether this InternalElement object has an associated reference to a RoleClass which is a generalization of the specified *specificRoleClass* which means, that the specified RoleClass is more specific than any already associated RoleClass of this InternalElement.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool HasGenericRoleClassReference(
	RoleFamilyType specificRoleClass
)
```

#### Parameters

##### *specificRoleClass*
Type: [Aml.Engine.CAEX.RoleFamilyType][2]  
The RoleClass object.

#### Return Value
Type: [Boolean][3]  
`true` if this InternalElement object has an associated RoleClass, which is a generalization of the specified RoleClass; otherwise, `false`. 

Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][4] | roleClass 


See Also
--------

#### Reference
[InternalElementType Class][5]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../RoleFamilyType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png