XmlTypeCodeExtensions.DefaultDecodedValue Method
================================================
AutomationML 2.1 APIReturns the default value for an XmlTypeCode. The data type of the returned object is the associated CLR type of the provided type code. The CLR type is available with the [AttributeType(XmlTypeCode)][1] method.

  **Namespace:**  [Aml.Engine.Schema][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static Object DefaultDecodedValue(
	this XmlTypeCode typeCode
)
```

#### Parameters

##### *typeCode*
Type: [System.Xml.Schema.XmlTypeCode][3]  
the type code

#### Return Value
Type: [Object][4]  
The default CLR type value, according to the provided type code.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [XmlTypeCode][3]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[XmlTypeCodeExtensions Class][7]  
[Aml.Engine.Schema Namespace][2]  

[1]: AttributeType.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode
[4]: https://docs.microsoft.com/dotnet/api/system.object
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png