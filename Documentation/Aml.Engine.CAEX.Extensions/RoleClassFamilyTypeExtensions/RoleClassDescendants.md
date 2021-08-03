RoleClassFamilyTypeExtensions.RoleClassDescendants Method
=========================================================


**Note: This API is now obsolete.**
Gets all descendant [RoleFamilyType][1] Objects in the RoleClass. RoleClasses on all levels are returned.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use roleClassFamily.Descendants<RoleFamilyType>() instead.")]
public static IEnumerable<RoleFamilyType> RoleClassDescendants(
	this RoleFamilyType roleClassFamily
)
```

#### Parameters

##### *roleClassFamily*
Type: [Aml.Engine.CAEX.RoleFamilyType][1]  
The RoleClass object.

#### Return Value
Type: [IEnumerable][3]&lt;[RoleFamilyType][1]>  
 Enumeration of all descendant RoleClass objects. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [RoleFamilyType][1]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

See Also
--------

#### Reference
[RoleClassFamilyTypeExtensions Class][6]  
[Aml.Engine.CAEX.Extensions Namespace][2]  

[1]: ../../Aml.Engine.CAEX/RoleFamilyType/README.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png