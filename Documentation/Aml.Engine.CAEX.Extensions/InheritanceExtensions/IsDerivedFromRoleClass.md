InheritanceExtensions.IsDerivedFromRoleClass Method
===================================================
AutomationML 2.1 APIDetermines whether the specified role reference defines an inheritance relation from the role, uniquely identifiable by the given role class path. The role class path may contain an alias.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static bool IsDerivedFromRoleClass(
	this IObjectWithRoleReference roleReference,
	string roleClassPath
)
```

#### Parameters

##### *roleReference*
Type: [Aml.Engine.CAEX.IObjectWithRoleReference][2]  
The role reference - this is a supported role class or a role requirement.

##### *roleClassPath*
Type: [System.String][3]  
 A class path of a base role, which is tested for a possible inheritance relation to the specified role reference.

#### Return Value
Type: [Boolean][4]  
`true` if an inheritance relation is resolved; otherwise, `false`.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IObjectWithRoleReference][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[InheritanceExtensions Class][7]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IObjectWithRoleReference/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png