XmlSchemaManager.ValueType Method
=================================
Returns the type code for a value that may be associated with the defined child.

  **Namespace:**  [Aml.Engine.Schema][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public XmlTypeCode ValueType(
	XName parentName,
	XName childName
)
```

#### Parameters

##### *parentName*
Type: [System.Xml.Linq.XName][2]  
Name of the parent

##### *childName*
Type: [System.Xml.Linq.XName][2]  
Name of the child

#### Return Value
Type: [XmlTypeCode][3]  
the XML type code.

See Also
--------

#### Reference
[XmlSchemaManager Class][4]  
[Aml.Engine.Schema Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xname
[3]: https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png