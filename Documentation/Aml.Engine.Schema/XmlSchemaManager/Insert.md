XmlSchemaManager.Insert Method
==============================
AutomationML 2.1 APIInserts an existing child node into the collection of child nodes of the specified parent node.

  **Namespace:**  [Aml.Engine.Schema][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool Insert(
	XElement parent,
	XElement child
)
```

#### Parameters

##### *parent*
Type: [System.Xml.Linq.XElement][2]  
The parent node

##### *child*
Type: [System.Xml.Linq.XElement][2]  
The child node

#### Return Value
Type: [Boolean][3]  
`true`, if the node has been inserted; `false` otherwise. 

See Also
--------

#### Reference
[XmlSchemaManager Class][4]  
[Aml.Engine.Schema Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png