ExternalInterfaceTypeExtensions.OfInterfaceClass Method
=======================================================
Gets all ExternalInterface objects from the specified *objectWithExternalInterface*, which are derived from an InterfaceClass, identified with the given *interfaceClassPath*.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IEnumerable<ExternalInterfaceType> OfInterfaceClass(
	this IObjectWithExternalInterface objectWithExternalInterface,
	string interfaceClassPath
)
```

#### Parameters

##### *objectWithExternalInterface*
Type: [Aml.Engine.CAEX.IObjectWithExternalInterface][2]  
The object with external interface.

##### *interfaceClassPath*
Type: [System.String][3]  
The interface class path.

#### Return Value
Type: [IEnumerable][4]&lt;[ExternalInterfaceType][5]>  
An enumeration of selected ExternalInterfaces of the given object.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IObjectWithExternalInterface][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

See Also
--------

#### Reference
[ExternalInterfaceTypeExtensions Class][8]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IObjectWithExternalInterface/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png