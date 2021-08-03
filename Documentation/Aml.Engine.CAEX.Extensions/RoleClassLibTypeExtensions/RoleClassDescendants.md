RoleClassLibTypeExtensions.RoleClassDescendants Method
======================================================


**Note: This API is now obsolete.**
Gets all descendant [RoleFamilyType][1] Objects in the RoleClassLib. RoleClasss on all levels are returned.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use roleClassLib.Descendants<RoleFamilyType> instead.")]
public static IEnumerable<RoleFamilyType> RoleClassDescendants(
	this RoleClassLibType roleClassLib
)
```

#### Parameters

##### *roleClassLib*
Type: [Aml.Engine.CAEX.RoleClassLibType][3]  
The RoleClassLib.

#### Return Value
Type: [IEnumerable][4]&lt;[RoleFamilyType][1]>  
 Enumeration of the RoleClass descendants. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [RoleClassLibType][3]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[RoleClassLibTypeExtensions Class][7]  
[Aml.Engine.CAEX.Extensions Namespace][2]  

[1]: ../../Aml.Engine.CAEX/RoleFamilyType/README.md
[2]: ../README.md
[3]: ../../Aml.Engine.CAEX/RoleClassLibType/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png