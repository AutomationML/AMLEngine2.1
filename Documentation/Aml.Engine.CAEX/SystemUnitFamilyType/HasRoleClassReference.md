SystemUnitFamilyType.HasRoleClassReference Method (RoleFamilyType, Boolean)
===========================================================================
AutomationML 2.1 APIDetermines whether this SystemUnitClass object has a SupportedRoleClass with a reference to the specified RoleClass. If inheritance relations between role classes should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified RoleClass is either identical to a referenced RoleClass or a referenced RoleClass is derived from the specified RoleClass. Independently of the *regardInheritanceOfRoleClasses* value, always the Role assignments to this SystemUnitClass and any ancestors of this SystemUnitClass are checked, using the [GetInheritedSupportedRoles()][1] method.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool HasRoleClassReference(
	RoleFamilyType roleClass,
	bool regardInheritanceOfRoleClasses = false
)
```

#### Parameters

##### *roleClass*
Type: [Aml.Engine.CAEX.RoleFamilyType][3]  
The RoleClass object.

##### *regardInheritanceOfRoleClasses* (Optional)
Type: [System.Boolean][4]  
 if set to `true` inheritance relations are regarded (default is `false`).

#### Return Value
Type: [Boolean][4]  
`true` if this SystemUnitClass object has a SupportedRoleClass with a reference to the specified RoleClass; otherwise, `false`. 

Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][5] | roleClass 


Examples
--------
 This sample shows how to call the **HasRoleClassReference(RoleFamilyType, Boolean)** method using a standard base RoleClass from the [RoleClassLib(CAEXDocument)][6]
```csharp
var amlBaseRoleClassLib = AutomationMLBaseRoleClassLibType.RoleClassLib (myDocument);
SystemUnitFamilyType systemUnitClass;
...
systemUnitClass.HasRoleClassReference (amlBaseRoleClassLib.AutomationMLBaseRole);
```


See Also
--------

#### Reference
[SystemUnitFamilyType Class][7]  
[Aml.Engine.CAEX Namespace][2]  

[1]: GetInheritedSupportedRoles.md
[2]: ../README.md
[3]: ../RoleFamilyType/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[6]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLibType/RoleClassLib.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png