XmlSchemaManager.CanAddNew Method
=================================
AutomationML 2.1 APIDetermines, if a child with the specified name can be added to the parent node. The method checks the specified minimal and maximal occurrences, defined for this relation in the xml schema.

  **Namespace:**  [Aml.Engine.Schema][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool CanAddNew(
	XElement parent,
	XName childName
)
```

#### Parameters

##### *parent*
Type: [System.Xml.Linq.XElement][2]  
The parent node

##### *childName*
Type: [System.Xml.Linq.XName][3]  
name of the child

#### Return Value
Type: [Boolean][4]  
`true`, if a child with that name can be added; `false` otherwise 

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