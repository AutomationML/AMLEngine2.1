InternalElementType.HasRoleClassReference Method (String, Boolean)
==================================================================
AutomationML 2.1 APIDetermines whether this InternalElement object has an associated RoleClass reference with the specified CAEX path role reference. If inheritance relations between role classes should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified RoleClass is either identical to a referenced RoleClass or a referenced RoleClass is derived from the specified RoleClass.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool HasRoleClassReference(
	string roleReference,
	bool regardInheritance = false
)
```

#### Parameters

##### *roleReference*
Type: [System.String][2]  
The role reference.

##### *regardInheritance* (Optional)
Type: [System.Boolean][3]  
 if set to `true` inheritance relations are regarded (default is `false`).

#### Return Value
Type: [Boolean][3]  
`true` if this InternalElement object has an associated RoleClass reference with the specified CAEX path role reference; otherwise, `false`. 

Exceptions
----------

Exception                  | Condition     
-------------------------- | ------------- 
[ArgumentNullException][4] | roleReference 


Examples
--------
 This sample shows how to call the **HasRoleClassReference(String, Boolean)** method using a standard base RoleClass path from the [AutomationMLBaseRoleClassLib][5]
```csharp
InternalElementType internalElement;
...
internalElement.HasRoleClassReference (AutomationMLBaseRoleClassLib.AutomationMLBaseRole);
```


See Also
--------

#### Reference
[InternalElementType Class][6]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[5]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/README.md
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png