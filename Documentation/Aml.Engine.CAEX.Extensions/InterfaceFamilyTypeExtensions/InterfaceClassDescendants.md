InterfaceFamilyTypeExtensions.InterfaceClassDescendants Method
==============================================================
AutomationML 2.1 API

**Note: This API is now obsolete.**
Gets all descendant [InterfaceFamilyType][1] Objects of the InterfaceClass. InterfaceClasses on all levels are returned.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use interfaceClass.Descendants<InterfaceFamilyType> instead.")]
public static IEnumerable<InterfaceFamilyType> InterfaceClassDescendants(
	this InterfaceFamilyType interfaceClass
)
```

#### Parameters

##### *interfaceClass*
Type: [Aml.Engine.CAEX.InterfaceFamilyType][1]  
The InterfaceClass object

#### Return Value
Type: [IEnumerable][3]&lt;[InterfaceFamilyType][1]>  
IEnumerable&lt;InterfaceFamilyType>.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [InterfaceFamilyType][1]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

See Also
--------

#### Reference
[InterfaceFamilyTypeExtensions Class][6]  
[Aml.Engine.CAEX.Extensions Namespace][2]  

[1]: ../../Aml.Engine.CAEX/InterfaceFamilyType/README.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png