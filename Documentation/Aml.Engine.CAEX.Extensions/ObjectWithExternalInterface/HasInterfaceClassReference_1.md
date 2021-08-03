ObjectWithExternalInterface.HasInterfaceClassReference Method (IObjectWithExternalInterface, String, Boolean)
=============================================================================================================
Determines whether this Object with ExternalInterfaces has an associated InterfaceClass reference with the specified CAEX path interface reference. If inheritance relations between interface classes should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified InterfaceClass is either identical to a referenced InterfaceClass or a referenced InterfaceClass is derived from the specified InterfaceClass.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static bool HasInterfaceClassReference(
	this IObjectWithExternalInterface objectWithExternalInterface,
	string interfaceReference,
	bool regardInheritance = false
)
```

#### Parameters

##### *objectWithExternalInterface*
Type: [Aml.Engine.CAEX.IObjectWithExternalInterface][2]  


##### *interfaceReference*
Type: [System.String][3]  
The interface reference.

##### *regardInheritance* (Optional)
Type: [System.Boolean][4]  
 if set to `true` inheritance relations are regarded (default is `false`).

#### Return Value
Type: [Boolean][4]  
`true` if this object has an associated InterfaceClass reference with the specified CAEX path interface reference; otherwise, `false`. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IObjectWithExternalInterface][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

Exceptions
----------

Exception                  | Condition          
-------------------------- | ------------------ 
[ArgumentNullException][7] | interfaceReference 


Examples
--------
 This sample shows how to call the **HasInterfaceClassReference(IObjectWithExternalInterface, String, Boolean)** method using a standard base InterfaceClass path from the [AutomationMLInterfaceClassLib][8]
```csharp
InternalElementType internalElement;
...
internalElement.HasInterfaceClassReference (AutomationMLInterfaceClassLib.COLLADA);
```


See Also
--------

#### Reference
[ObjectWithExternalInterface Class][9]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IObjectWithExternalInterface/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[8]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/README.md
[9]: README.md
[10]: https://www.automationml.org
[11]: ../../icons/logoShade.png