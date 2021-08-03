ObjectWithBaseClass.ReferencedClassName Method (InterfaceClassType)
===================================================================
AutomationML 2.1 APIName of the referenced InterfaceClass without path information.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static string ReferencedClassName(
	this InterfaceClassType interfaceClass
)
```

#### Parameters

##### *interfaceClass*
Type: [Aml.Engine.CAEX.InterfaceClassType][2]  
The interface Class.

#### Return Value
Type: [String][3]  
Name of the referenced Class, if exists; otherwise `string.Empty`
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [InterfaceClassType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

See Also
--------

#### Reference
[ObjectWithBaseClass Class][6]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/InterfaceClassType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png