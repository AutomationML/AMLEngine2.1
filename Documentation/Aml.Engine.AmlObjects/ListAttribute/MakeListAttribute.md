ListAttribute.MakeListAttribute Method
======================================
Changes the semantic of the specified attribute and converts it to a list attribute. If the Attribute is already a list attribute or the attribute contains child attributes it will not be converted.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static bool MakeListAttribute(
	this AttributeType attribute,
	bool isOrdered = false
)
```

#### Parameters

##### *attribute*
Type: [Aml.Engine.CAEX.AttributeType][2]  
The attribute.

##### *isOrdered* (Optional)
Type: [System.Boolean][3]  
If set to `true` the attribute is converted to an ordered list attribute

#### Return Value
Type: [Boolean][3]  
true, if the conversion was done, otherwise false.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [AttributeType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

See Also
--------

#### Reference
[ListAttribute Class][6]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/AttributeType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png