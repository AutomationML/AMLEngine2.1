XmlSchemaManager.IsParent Method
================================
Determines, if the parent is allowed to contain a child with the provided name according to this schema instance.

  **Namespace:**  [Aml.Engine.Schema][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool IsParent(
	XElement parent,
	XName childName
)
```

#### Parameters

##### *parent*
Type: [System.Xml.Linq.XElement][2]  
The parent.

##### *childName*
Type: [System.Xml.Linq.XName][3]  
Name of the child.

#### Return Value
Type: [Boolean][4]  
`true` if the parent can contain a child element with that name; otherwise, `false`. 

See Also
--------

#### Reference
[XmlSchemaManager Class][5]  
[Aml.Engine.Schema Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[3]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xname
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png