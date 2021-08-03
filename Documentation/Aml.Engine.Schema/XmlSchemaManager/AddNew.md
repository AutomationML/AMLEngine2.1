XmlSchemaManager.AddNew Method
==============================
Creates a new Xml-Element with the provided content and inserts it to the provided parent according to this schema instance.

  **Namespace:**  [Aml.Engine.Schema][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public virtual XElement AddNew(
	XElement parent,
	XName childName,
	Object content
)
```

#### Parameters

##### *parent*
Type: [System.Xml.Linq.XElement][2]  
The parent XML element.

##### *childName*
Type: [System.Xml.Linq.XName][3]  
The name of the child element.

##### *content*
Type: [System.Object][4]  
Initial content of the child.

#### Return Value
Type: [XElement][2]  
The created XML element.

See Also
--------

#### Reference
[XmlSchemaManager Class][5]  
[Aml.Engine.Schema Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[3]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xname
[4]: https://docs.microsoft.com/dotnet/api/system.object
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png