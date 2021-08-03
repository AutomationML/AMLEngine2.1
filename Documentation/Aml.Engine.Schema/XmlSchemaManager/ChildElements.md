XmlSchemaManager.ChildElements Method
=====================================
Gets the SchemaDefinition for all elements, which can be added to the child which is defined with the name of it's parent and the name of itself.

  **Namespace:**  [Aml.Engine.Schema][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<XmlSchemaElement> ChildElements(
	XName parentName,
	XName childName,
	bool includeChoice = false
)
```

#### Parameters

##### *parentName*
Type: [System.Xml.Linq.XName][2]  
Name of the child's parent.

##### *childName*
Type: [System.Xml.Linq.XName][2]  
Name of the child

##### *includeChoice* (Optional)
Type: [System.Boolean][3]  
if set to `true` [include choice].

#### Return Value
Type: [IEnumerable][4]&lt;[XmlSchemaElement][5]>  
Enumeration of all SchemaDefinitions of possible child elements.

See Also
--------

#### Reference
[XmlSchemaManager Class][6]  
[Aml.Engine.Schema Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xname
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: https://docs.microsoft.com/dotnet/api/system.xml.schema.xmlschemaelement
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png