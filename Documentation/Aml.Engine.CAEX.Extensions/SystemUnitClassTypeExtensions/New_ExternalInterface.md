SystemUnitClassTypeExtensions.New_ExternalInterface Method (IObjectWithExternalInterface, String, Boolean)
==========================================================================================================
AutomationML 2.1 APIAdding a new ExternalInterface instance to the ExternalInterface-Collection of the *objectWithExternalInterface*. The New ExternalInterface is inserted as the first ExternalInterface of any existing Interfaces if nothing else is explicit defined.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static ExternalInterfaceType New_ExternalInterface(
	this IObjectWithExternalInterface objectWithExternalInterface,
	string name,
	bool asFirst = true
)
```

#### Parameters

##### *objectWithExternalInterface*
Type: [Aml.Engine.CAEX.IObjectWithExternalInterface][2]  
Any object with an ExternalInterface collection.

##### *name*
Type: [System.String][3]  
The name of the new ExternalInterface

##### *asFirst* (Optional)
Type: [System.Boolean][4]  
If set to true, the interface is insert at first, otherwise at last Interface.

#### Return Value
Type: [ExternalInterfaceType][5]  
The new ExternalInterface
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IObjectWithExternalInterface][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

See Also
--------

#### Reference
[SystemUnitClassTypeExtensions Class][8]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IObjectWithExternalInterface/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png