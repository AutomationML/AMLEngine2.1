ObjectWithBaseClass.GetDerivedInterfaces Method
===============================================
AutomationML 2.1 APIGets a list of ExternalInterface objects that are inherited from base classes. The List will also contain the elements own ExternalInterface objects, if the parameter is set (default). If an ExternalInterface is overwritten, only the last defined is contained.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static List<ExternalInterfaceType> GetDerivedInterfaces(
	this IClassWithExternalInterface classWithBaseClass,
	bool includeOwn = true
)
```

#### Parameters

##### *classWithBaseClass*
Type: [Aml.Engine.CAEX.IClassWithExternalInterface][2]  
The class with a possible base class reference for inheritance.

##### *includeOwn* (Optional)
Type: [System.Boolean][3]  
if set to `true` includes the elements own ExternalInterface objects; otherwise not

#### Return Value
Type: [List][4]&lt;[ExternalInterfaceType][5]>  
 A list of ExternalInterface objects 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IClassWithExternalInterface][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

See Also
--------

#### Reference
[ObjectWithBaseClass Class][8]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IClassWithExternalInterface/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.list-1
[5]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png