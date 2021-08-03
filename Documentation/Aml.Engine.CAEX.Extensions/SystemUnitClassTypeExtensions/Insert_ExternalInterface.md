SystemUnitClassTypeExtensions.Insert_ExternalInterface Method
=============================================================
AutomationML 2.1 API

**Note: This API is now obsolete.**
Inserting an ExternalInterface to the ExternalInterface-Collection of the *objectWithExternalInterface*. The Element is inserted at the first Element of any existing ExternalInterfaces if no other position is defined.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use ExternalInterface.Insert")]
public static void Insert_ExternalInterface(
	this IObjectWithExternalInterface objectWithExternalInterface,
	ExternalInterfaceType interfaceElement,
	bool asFirst = true
)
```

#### Parameters

##### *objectWithExternalInterface*
Type: [Aml.Engine.CAEX.IObjectWithExternalInterface][2]  
Any object with an ExternalInterface collection.

##### *interfaceElement*
Type: [Aml.Engine.CAEX.ExternalInterfaceType][3]  
The ExternalInterface object.

##### *asFirst* (Optional)
Type: [System.Boolean][4]  
Explicit definition of the position asFirst (true) or asLast (false)

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IObjectWithExternalInterface][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[SystemUnitClassTypeExtensions Class][7]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IObjectWithExternalInterface/README.md
[3]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png