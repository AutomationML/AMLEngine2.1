ObjectWithExternalInterface.InterfaceClassReferences Method
===========================================================
All external Interfaces of this Object with ExternalInterfaces with an associated InterfaceClass reference with the specified CAEX path interface reference. If inheritance relations between interface classes should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified InterfaceClass is either identical to a referenced InterfaceClass or a referenced InterfaceClass is derived from the specified InterfaceClass.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IEnumerable<ExternalInterfaceType> InterfaceClassReferences(
	this IObjectWithExternalInterface objectWithExternalInterface,
	string interfaceReference,
	bool regardInheritance = false
)
```

#### Parameters

##### *objectWithExternalInterface*
Type: [Aml.Engine.CAEX.IObjectWithExternalInterface][2]  

[Missing &lt;param name="objectWithExternalInterface"/> documentation for "M:Aml.Engine.CAEX.Extensions.ObjectWithExternalInterface.InterfaceClassReferences(Aml.Engine.CAEX.IObjectWithExternalInterface,System.String,System.Boolean)"]


##### *interfaceReference*
Type: [System.String][3]  
The interface reference.

##### *regardInheritance* (Optional)
Type: [System.Boolean][4]  
 if set to `true` inheritance relations are regarded (default is `false`).

#### Return Value
Type: [IEnumerable][5]&lt;[ExternalInterfaceType][6]>  
 All external interfaces with an associated InterfaceClass reference with the specified CAEX path interface reference. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IObjectWithExternalInterface][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][7] or [Extension Methods (C# Programming Guide)][8].

Exceptions
----------

Exception                  | Condition          
-------------------------- | ------------------ 
[ArgumentNullException][9] | interfaceReference 


See Also
--------

#### Reference
[ObjectWithExternalInterface Class][10]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IObjectWithExternalInterface/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[6]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[7]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[8]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[9]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[10]: README.md
[11]: https://www.automationml.org
[12]: ../../icons/logoShade.png