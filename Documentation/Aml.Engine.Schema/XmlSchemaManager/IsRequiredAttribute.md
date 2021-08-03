XmlSchemaManager.IsRequiredAttribute Method
===========================================
Determines, if the Attribute with the provided name is a required attribute when added to the parent child combination.

  **Namespace:**  [Aml.Engine.Schema][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool IsRequiredAttribute(
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
Type: [Boolean][4]  
`true` if the attribute is a required attribute in this parent child combination; otherwise, `false`. 

See Also
--------

#### Reference
[XmlSchemaManager Class][5]  
[Aml.Engine.Schema Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xname
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png