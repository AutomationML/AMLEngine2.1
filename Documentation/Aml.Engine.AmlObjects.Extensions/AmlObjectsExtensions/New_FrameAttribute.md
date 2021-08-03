AmlObjectsExtensions.New_FrameAttribute Method
==============================================
Creates a new Frame attribute for the [IObjectWithAttributes][1] if no Frame attribute exists. The provided values are used to initialize the Frame attribute values.

  **Namespace:**  [Aml.Engine.AmlObjects.Extensions][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static FrameAttributeType New_FrameAttribute(
	this IObjectWithAttributes caexObject,
	FrameValues frameValues = null
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.IObjectWithAttributes][1]  
The CAEX object.

##### *frameValues* (Optional)
Type: [Aml.Engine.AmlObjects.FrameValues][3]  
The frame values.

#### Return Value
Type: [FrameAttributeType][4]  
 the new FrameAttributeType. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IObjectWithAttributes][1]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

Exceptions
----------

Exception                  | Condition  
-------------------------- | ---------- 
[ArgumentNullException][7] | caexObject 
[ArgumentNullException][7] | caexObject 


See Also
--------

#### Reference
[AmlObjectsExtensions Class][8]  
[Aml.Engine.AmlObjects.Extensions Namespace][2]  

[1]: ../../Aml.Engine.CAEX/IObjectWithAttributes/README.md
[2]: ../README.md
[3]: ../../Aml.Engine.AmlObjects/FrameValues/README.md
[4]: ../../Aml.Engine.AmlObjects/FrameAttributeType/README.md
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png