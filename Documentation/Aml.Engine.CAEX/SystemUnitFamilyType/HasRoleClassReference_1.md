SystemUnitFamilyType.HasRoleClassReference Method (String, Boolean)
===================================================================
Determines whether this SystemUnitClass object has a SupportedRoleClass with the specified CAEX path reference. If inheritance relation should be regarded, the optional parameter 'regardInheritance' should be set.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool HasRoleClassReference(
	string roleClassReference,
	bool regardInheritance = false
)
```

#### Parameters

##### *roleClassReference*
Type: [System.String][2]  
The CAEX path to a RoleClass object.

##### *regardInheritance* (Optional)
Type: [System.Boolean][3]  
 if set to `true` inheritance relations are regarded (default is `false`).

#### Return Value
Type: [Boolean][3]  
`true` if this SystemUnitClass object has a SupportedRoleClass with the specified CAEX path reference. 

Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][4] | roleClass 


Examples
--------
 This sample shows how to call the **HasRoleClassReference(String, Boolean)** method using a standard base RoleClass path from the [AutomationMLBaseRoleClassLib][5]
```csharp
SystemUnitFamilyType systemUnitClass;
...
systemUnitClass.HasRoleReference (AutomationMLBaseRoleClassLib.AutomationMLBaseRole);
```


See Also
--------

#### Reference
[SystemUnitFamilyType Class][6]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[5]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/README.md
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png