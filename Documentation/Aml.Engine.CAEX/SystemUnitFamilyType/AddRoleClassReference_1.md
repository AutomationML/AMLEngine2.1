SystemUnitFamilyType.AddRoleClassReference Method (String, Boolean)
===================================================================
Adds a RoleClass reference to this SystemUnitClass object using the provided CAEX path, referencing a RoleClass object. The RoleClass reference is added as a [SupportedRoleClassType][1] object.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IObjectWithRoleReference AddRoleClassReference(
	string roleClassReference,
	bool addUnique = true
)
```

#### Parameters

##### *roleClassReference*
Type: [System.String][3]  
 The CAEX path referencing a RoleClass to be assigned to the SystemUnitClass.

##### *addUnique* (Optional)
Type: [System.Boolean][4]  
 if set to `true` the reference is not added, if the same reference already exists.

#### Return Value
Type: [IObjectWithRoleReference][5]  
The new added RoleClass reference, which is a SupportedRoleClass.

Exceptions
----------

Exception                  | Condition          
-------------------------- | ------------------ 
[ArgumentNullException][6] | roleClassReference 


Examples
--------
 This sample shows how to call the **AddRoleClassReference(String, Boolean)** method using a standard RoleClass path defined in the [AutomationMLBaseRoleClassLib][7]
```csharp
var mySlib = myDocument.CAEXFile.SystemUnitClassLib.Append ("mySlib");
var mySuc = mySlib.SystemUnitClass.Append("mySuc");
mySuc.AddRoleClassReference (AutomationMLBaseRoleClassLib.AutomationMLBaseRole);
```


See Also
--------

#### Reference
[SystemUnitFamilyType Class][8]  
[Aml.Engine.CAEX Namespace][2]  

[1]: ../SupportedRoleClassType/README.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: ../IObjectWithRoleReference/README.md
[6]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[7]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/README.md
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png