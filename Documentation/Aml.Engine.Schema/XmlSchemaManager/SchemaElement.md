XmlSchemaManager.SchemaElement Method
=====================================
AutomationML 2.1 APIGets the schema information for the provided parent child combination.

  **Namespace:**  [Aml.Engine.Schema][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public XmlSchemaElement SchemaElement(
	XName parentName,
	XName childName
)
```

#### Parameters

##### *parentName*
Type: [System.Xml.Linq.XName][2]  
name of the parent element

##### *childName*
Type: [System.Xml.Linq.XName][2]  
name of the child element

#### Return Value
Type: [XmlSchemaElement][3]  
returns `null`, if no schema information exists for the parent child combination.

See Also
--------

#### Reference
[XmlSchemaManager Class][4]  
[Aml.Engine.Schema Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xname
[3]: https://docs.microsoft.com/dotnet/api/system.xml.schema.xmlschemaelement
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png