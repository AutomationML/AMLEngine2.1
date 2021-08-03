XmlTypeCodeExtensions Class
===========================
This static class provides extension methods for the interpretation of [XmlTypeCode][1].


Inheritance Hierarchy
---------------------
[System.Object][2]  
  **Aml.Engine.Schema.XmlTypeCodeExtensions**  

  **Namespace:**  [Aml.Engine.Schema][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static class XmlTypeCodeExtensions
```

The **XmlTypeCodeExtensions** type exposes the following members.


Methods
-------

                                 | Name                           | Description                                                                                                                                                                                                         
-------------------------------- | ------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]![Static member] | [AttributeType][4]             | Gets the CLR-Type for the provided typeCode                                                                                                                                                                         
![Public method]![Static member] | [Default][5]                   | **Obsolete.**Returns the default value for XmlTypeCode                                                                                                                                                              
![Public method]![Static member] | [DefaultDecodedValue][6]       | Returns the default value for an XmlTypeCode. The data type of the returned object is the associated CLR type of the provided type code. The CLR type is available with the [AttributeType(XmlTypeCode)][4] method. 
![Public method]![Static member] | [DefaultEncodedValue][7]       | Converts the default value for the specified typeCode to a valid XML value string                                                                                                                                   
![Public method]![Static member] | [XmlTypeCodeFromSchemaType][8] | Gets the [XmlTypeCode][1] from the W3C XSD schema type string.                                                                                                                                                      


See Also
--------

#### Reference
[Aml.Engine.Schema Namespace][3]  

[1]: https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode
[2]: https://docs.microsoft.com/dotnet/api/system.object
[3]: ../README.md
[4]: AttributeType.md
[5]: Default.md
[6]: DefaultDecodedValue.md
[7]: DefaultEncodedValue.md
[8]: XmlTypeCodeFromSchemaType.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"