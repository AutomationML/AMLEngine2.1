InternalElementType.AddRoleClassReference Method (String, Boolean, Boolean)
===========================================================================
Adds a RoleClass reference to this InternalElement object using the provided CAEX path, referencing a RoleClass object. The RoleClass reference is added as a [RoleRequirementsType][1] object. For CAEX documents which are based on CAEX version 2.15, only one RoleRequirement is allowed for an InternalElement. Additional RoleClass references are added as SupportedRoleClass objects.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IObjectWithRoleReference AddRoleClassReference(
	string roleClassReference,
	bool addUnique = true,
	bool addInstance = false
)
```

#### Parameters

##### *roleClassReference*
Type: [System.String][3]  
 The CAEX path referencing a RoleClass to be assigned to the InternalElement.

##### *addUnique* (Optional)
Type: [System.Boolean][4]  
 if set to `true` the reference is not added, if the same reference already exists.

##### *addInstance* (Optional)
Type: [System.Boolean][4]  
 if set to `true`, the reference is created as an instance of the RoleClass, identified by the provided roleClassReference, containing all ExternalInterfaces and Attributes of the RoleClass.

#### Return Value
Type: [IObjectWithRoleReference][5]  
 The new added RoleClass reference, which is either a RoleRequirement or a SupportedRoleClass. 

Exceptions
----------

Exception                  | Condition          
-------------------------- | ------------------ 
[ArgumentNullException][6] | roleClassReference 


Remarks
-------
 The default behaviour is, that only a reference to the role class is added and no instance of the class containing all Attributes and ExternalInterface objects. If an instance is required, set the optional parameter 'addInstance' to true or use the [CreateClassInstance()][7] and the [Insert(CAEXWrapper, Boolean)][8] methods, 

Examples
--------
 This sample shows how to call the **AddRoleClassReference(String, Boolean, Boolean)** method using a standard RoleClass path defined in the [AutomationMLBaseRoleClassLib][9]
```csharp
var myIH = myDocument.CAEXFile.InstanceHierarchy.Append ("myIH");
var myIE = myIH.InternalElement.Append("myIH");
myIE.AddRoleClassReference (AutomationMLBaseRoleClassLib.AutomationMLBaseRole);
```


See Also
--------

#### Reference
[InternalElementType Class][10]  
[Aml.Engine.CAEX Namespace][2]  

[1]: ../RoleRequirementsType/README.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: ../IObjectWithRoleReference/README.md
[6]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[7]: ../RoleFamilyType/CreateClassInstance.md
[8]: Insert.md
[9]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/README.md
[10]: README.md
[11]: https://www.automationml.org
[12]: ../../icons/logoShade.png