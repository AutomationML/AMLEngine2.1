XmlSchemaManager.CreateAttribute Method
=======================================
Creates the attribute with the provided name if this attribute is defined in this schema instance.

  **Namespace:**  [Aml.Engine.Schema][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public virtual XAttribute CreateAttribute(
	XElement element,
	string attributeName
)
```

#### Parameters

##### *element*
Type: [System.Xml.Linq.XElement][2]  
The element.

##### *attributeName*
Type: [System.String][3]  
Name of the attribute.

#### Return Value
Type: [XAttribute][4]  
The created XML attribute.

See Also
--------

#### Reference
[XmlSchemaManager Class][5]  
[Aml.Engine.Schema Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xattribute
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png