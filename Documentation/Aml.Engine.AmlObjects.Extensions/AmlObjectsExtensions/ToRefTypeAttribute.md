AmlObjectsExtensions.ToRefTypeAttribute Method
==============================================
AutomationML 2.1 APIConverts an AttributeType to a RefTypeAttribute.

  **Namespace:**  [Aml.Engine.AmlObjects.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static RefTypeAttributeType ToRefTypeAttribute(
	this AttributeType attribute
)
```

#### Parameters

##### *attribute*
Type: [Aml.Engine.CAEX.AttributeType][2]  
The AttributeType object.

#### Return Value
Type: [RefTypeAttributeType][3]  
An RefTypeAttributeType object.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [AttributeType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

Remarks
-------
 The conversion doesn't create the RefTypeAttributeType. Use [Create(CAEXDocument)][6] method to create a RefTypeAttributeType. 

See Also
--------

#### Reference
[AmlObjectsExtensions Class][7]  
[Aml.Engine.AmlObjects.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/AttributeType/README.md
[3]: ../../Aml.Engine.AmlObjects/RefTypeAttributeType/README.md
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: ../../Aml.Engine.AmlObjects/RefTypeAttributeType/Create.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png