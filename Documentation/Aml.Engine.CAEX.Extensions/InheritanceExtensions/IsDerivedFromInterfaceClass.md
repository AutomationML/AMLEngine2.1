InheritanceExtensions.IsDerivedFromInterfaceClass Method
========================================================
Determines whether the specified interface class has an inheritance relation from the interface class, uniquely identifiable by the given interface class path. The interface class path may contain an alias.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static bool IsDerivedFromInterfaceClass(
	this InterfaceClassType interfaceClass,
	string interfaceClassPath
)
```

#### Parameters

##### *interfaceClass*
Type: [Aml.Engine.CAEX.InterfaceClassType][2]  
The interface class.

##### *interfaceClassPath*
Type: [System.String][3]  
 Class path of a base interface class which is tested for a inheritance relation to the specified interface class, which is the more specific class in this relation.

#### Return Value
Type: [Boolean][4]  
`true` if an inheritance relation is resolved; otherwise, `false`.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [InterfaceClassType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[InheritanceExtensions Class][7]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/InterfaceClassType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png