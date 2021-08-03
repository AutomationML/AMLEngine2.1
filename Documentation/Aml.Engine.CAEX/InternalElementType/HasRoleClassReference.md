InternalElementType.HasRoleClassReference Method (RoleFamilyType, Boolean)
==========================================================================
Determines whether this InternalElement object has an associated reference to the specified RoleClass. If inheritance relations between role classes should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified RoleClass is either identical to a referenced RoleClass or a referenced RoleClass is derived from the specified RoleClass.

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
`true` if this InternalElement object has an associated reference to the specified RoleClass; otherwise, `false`. 

Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][4] | roleClass 


Examples
--------
 This sample shows how to call the **HasRoleClassReference(RoleFamilyType, Boolean)** method using a standard base RoleClass from the [RoleClassLib(CAEXDocument)][5]
```csharp
var amlBaseRoleClassLib = AutomationMLBaseRoleClassLibType.RoleClassLib (myDocument);
InternalElementType internalElement;
...
internalElement.HasRoleClassReference (amlBaseRoleClassLib.AutomationMLBaseRole);
```


See Also
--------

#### Reference
[InternalElementType Class][6]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../RoleFamilyType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[5]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLibType/RoleClassLib.md
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png