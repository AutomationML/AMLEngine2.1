XmlSchemaManager.HasSequenceOfSimpleElements Method
===================================================
Determines, if the schema defines a sequence of simple elements for the provided parent child combination.

  **Namespace:**  [Aml.Engine.Schema][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool HasSequenceOfSimpleElements(
	XName parentName,
	XName childName,
	out bool onlyOne
)
```

#### Parameters

##### *parentName*
Type: [System.Xml.Linq.XName][2]  
Name of the parent.

##### *childName*
Type: [System.Xml.Linq.XName][2]  
Name of the child.

##### *onlyOne*
Type: [System.Boolean][3]  
if set to `true` [only one].

#### Return Value
Type: [Boolean][3]  
`true` if the provided parent child combination consists of a sequence of simple elements; otherwise, `false`. 

See Also
--------

#### Reference
[XmlSchemaManager Class][4]  
[Aml.Engine.Schema Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xname
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png