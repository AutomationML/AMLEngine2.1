XmlSchemaManager.AttributeValueType Method (XName, XName, String)
=================================================================
AutomationML 2.1 APIGets the Attribute value types for the attribute with the defined name of a child element which belongs to the given parent. If `XmlTypeCode.Item` is returned, the value type is equal to the schema internal any type.

  **Namespace:**  [Aml.Engine.Schema][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public XmlTypeCode AttributeValueType(
	XName parentName,
	XName childName,
	string attributeName
)
```

#### Parameters

##### *parentName*
Type: [System.Xml.Linq.XName][2]  
Name of the parent.

##### *childName*
Type: [System.Xml.Linq.XName][2]  
Name of the child.

##### *attributeName*
Type: [System.String][3]  
Name of the attribute.

#### Return Value
Type: [XmlTypeCode][4]  
 The type code defined for the value. 

See Also
--------

#### Reference
[XmlSchemaManager Class][5]  
[Aml.Engine.Schema Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xname
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png