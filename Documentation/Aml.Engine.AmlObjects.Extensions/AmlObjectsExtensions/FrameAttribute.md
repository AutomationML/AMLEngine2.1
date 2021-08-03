AmlObjectsExtensions.FrameAttribute Method
==========================================
AutomationML 2.1 APIGets a defined FrameAttribute from the [Attribute][1] collection of the [IObjectWithAttributes][2]. If no such attribute exists, `null` is returned.

  **Namespace:**  [Aml.Engine.AmlObjects.Extensions][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static FrameAttributeType FrameAttribute(
	this IObjectWithAttributes caexObject
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.IObjectWithAttributes][2]  
The CAEX object.

#### Return Value
Type: [FrameAttributeType][4]  
The FrameAttribute.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IObjectWithAttributes][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

Exceptions
----------

Exception                  | Condition  
-------------------------- | ---------- 
[ArgumentNullException][7] | caexObject 


See Also
--------

#### Reference
[AmlObjectsExtensions Class][8]  
[Aml.Engine.AmlObjects.Extensions Namespace][3]  

[1]: ../../Aml.Engine.CAEX/IObjectWithAttributes/Attribute.md
[2]: ../../Aml.Engine.CAEX/IObjectWithAttributes/README.md
[3]: ../README.md
[4]: ../../Aml.Engine.AmlObjects/FrameAttributeType/README.md
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png