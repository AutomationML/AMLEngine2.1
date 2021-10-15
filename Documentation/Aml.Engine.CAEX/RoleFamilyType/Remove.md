RoleFamilyType.Remove Method
============================
Removes this RoleClass from the document.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public override void Remove(
	bool removeRelations = false
)
```

#### Parameters

##### *removeRelations* (Optional)
Type: [System.Boolean][2]  
If set to `true`, all existing references found in RoleRequirements, SupportedRoleClasses or other RoleClasses are removed. RoleRequirements and SupportedRoleClass objects are removed from the document. In RoleClasses only the reference to the base class is removed.

#### Implements
[ICAEXWrapper.Remove(Boolean)][3]  
[ICAEXWrapper.Remove(Boolean)][3]  


See Also
--------

#### Reference
[RoleFamilyType Class][4]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.boolean
[3]: ../ICAEXWrapper/Remove.md
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png