SystemUnitFamilyType.AddRoleClassReference Method (RoleFamilyType, Boolean)
===========================================================================
Adds a RoleClass reference to this SystemUnitClass object using the provided RoleClass object. The RoleClass reference is added as a [SupportedRoleClassType][1] object.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IObjectWithRoleReference AddRoleClassReference(
	RoleFamilyType roleClass,
	bool addUnique = true
)
```

#### Parameters

##### *roleClass*
Type: [Aml.Engine.CAEX.RoleFamilyType][3]  
The RoleClass to be assigned to the SystemUnitClass.

##### *addUnique* (Optional)
Type: [System.Boolean][4]  
 if set to `true`, the RoleClass reference is not added, if a reference to the provided RoleClass already exists.

#### Return Value
Type: [IObjectWithRoleReference][5]  
The new added RoleClass reference.

Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][6] | roleClass 


Examples
--------
 This sample shows how to call the **AddRoleClassReference(RoleFamilyType, Boolean)** method using a standard base RoleClass from the [RoleClassLib(CAEXDocument)][7]
```csharp
var amlBaseRoleClassLib = AutomationMLBaseRoleClassLibType.RoleClassLib (myDocument);
var mySlib = myDocument.CAEXFile.SystemUnitClassLib.Append ("mySlib");
var mySuc = mySlib.SystemUnitClass.Append("mySuc");
mySuc.AddRoleClassReference (amlBaseRoleClassLib.AutomationMLBaseRole);
```


See Also
--------

#### Reference
[SystemUnitFamilyType Class][8]  
[Aml.Engine.CAEX Namespace][2]  

[1]: ../SupportedRoleClassType/README.md
[2]: ../README.md
[3]: ../RoleFamilyType/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: ../IObjectWithRoleReference/README.md
[6]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[7]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLibType/RoleClassLib.md
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png