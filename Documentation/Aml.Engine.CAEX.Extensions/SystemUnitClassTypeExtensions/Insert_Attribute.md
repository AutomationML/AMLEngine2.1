SystemUnitClassTypeExtensions.Insert_Attribute Method
=====================================================
AutomationML 2.1 API

**Note: This API is now obsolete.**
Inserts an Attribute object in the Attribute collection of the *objectWithAttributes*.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use Attribute.Insert")]
public static void Insert_Attribute(
	this IObjectWithAttributes objectWithAttributes,
	AttributeType attributeElement
)
```

#### Parameters

##### *objectWithAttributes*
Type: [Aml.Engine.CAEX.IObjectWithAttributes][2]  
Any object with an Attribute collection.

##### *attributeElement*
Type: [Aml.Engine.CAEX.AttributeType][3]  
The Attribute object to insert

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IObjectWithAttributes][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

See Also
--------

#### Reference
[SystemUnitClassTypeExtensions Class][6]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IObjectWithAttributes/README.md
[3]: ../../Aml.Engine.CAEX/AttributeType/README.md
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png