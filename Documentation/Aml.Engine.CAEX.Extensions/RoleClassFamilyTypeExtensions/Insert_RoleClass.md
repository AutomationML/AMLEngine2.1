RoleClassFamilyTypeExtensions.Insert_RoleClass Method
=====================================================
AutomationML 2.1 API

**Note: This API is now obsolete.**
Inserts the provided RoleClass as a subordinate child to this RoleClass.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use roleClassFamily.Insert(roleClass) instead.")]
public static void Insert_RoleClass(
	this RoleFamilyType roleClassAncestor,
	RoleFamilyType roleClass
)
```

#### Parameters

##### *roleClassAncestor*
Type: [Aml.Engine.CAEX.RoleFamilyType][2]  
The role class ancestor.

##### *roleClass*
Type: [Aml.Engine.CAEX.RoleFamilyType][2]  
The role class to be inserted.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [RoleFamilyType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][3] or [Extension Methods (C# Programming Guide)][4].

See Also
--------

#### Reference
[RoleClassFamilyTypeExtensions Class][5]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/RoleFamilyType/README.md
[3]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[4]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png