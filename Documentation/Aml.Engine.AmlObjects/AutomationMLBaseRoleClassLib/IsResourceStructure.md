AutomationMLBaseRoleClassLib.IsResourceStructure Method
=======================================================
AutomationML 2.1 APIDetermines whether the specified role reference defines an inheritance relation from the ResourceStructure RoleClass

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static bool IsResourceStructure(
	this IObjectWithRoleReference role
)
```

#### Parameters

##### *role*
Type: [Aml.Engine.CAEX.IObjectWithRoleReference][2]  
The role.

#### Return Value
Type: [Boolean][3]  
`true` if an inheritance relation is resolved; otherwise, `false`.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IObjectWithRoleReference][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

See Also
--------

#### Reference
[AutomationMLBaseRoleClassLib Class][6]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IObjectWithRoleReference/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png