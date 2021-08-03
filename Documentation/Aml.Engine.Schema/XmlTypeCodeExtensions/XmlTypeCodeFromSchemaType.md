XmlTypeCodeExtensions.XmlTypeCodeFromSchemaType Method
======================================================
AutomationML 2.1 APIGets the [XmlTypeCode][1] from the W3C XSD schema type string.

  **Namespace:**  [Aml.Engine.Schema][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static XmlTypeCode XmlTypeCodeFromSchemaType(
	this string schemaType
)
```

#### Parameters

##### *schemaType*
Type: [System.String][3]  
W3C XSD schema type, defined as xs:..., like xs:double and others.

#### Return Value
Type: [XmlTypeCode][1]  
 the XmlTypeCode. If the schemaType is not recognized, [None][1] is returned. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [String][3]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

See Also
--------

#### Reference
[XmlTypeCodeExtensions Class][6]  
[Aml.Engine.Schema Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png