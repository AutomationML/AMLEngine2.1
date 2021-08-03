AmlObjectsExtensions.AMLAttributes Method
=========================================
Conversion of any object which has an attribute collection to get access to specific AutomationML defined attributes.

  **Namespace:**  [Aml.Engine.AmlObjects.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static ObjectWithAMLAttributes AMLAttributes(
	this IObjectWithAttributes caexObject
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.IObjectWithAttributes][2]  
The CAEX object, providing the attribute collection.

#### Return Value
Type: [ObjectWithAMLAttributes][3]  
The ObjectWithAMLAttributes which provides accessors for AutomationML defined attributes.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IObjectWithAttributes][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

Exceptions
----------

Exception                  | Condition  
-------------------------- | ---------- 
[ArgumentNullException][6] | caexObject 


See Also
--------

#### Reference
[AmlObjectsExtensions Class][7]  
[Aml.Engine.AmlObjects.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IObjectWithAttributes/README.md
[3]: ../../Aml.Engine.AmlObjects/ObjectWithAMLAttributes/README.md
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png