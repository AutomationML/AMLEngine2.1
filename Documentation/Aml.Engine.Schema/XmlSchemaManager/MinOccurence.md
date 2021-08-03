XmlSchemaManager.MinOccurence Method
====================================
AutomationML 2.1 APIThe minimal occurrence for child node with the defined name under a parent node with the defined name. If 0 is returned, the existence of a child node with that node is optional. If 1 is returned, the existence is mandatory.

  **Namespace:**  [Aml.Engine.Schema][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public decimal MinOccurence(
	XName parentName,
	XName childName
)
```

#### Parameters

##### *parentName*
Type: [System.Xml.Linq.XName][2]  
Name of the child's parent

##### *childName*
Type: [System.Xml.Linq.XName][2]  
Name of the child

#### Return Value
Type: [Decimal][3]  
`0` for optional occurrence or `1` for mandatory occurrence. A value of `-1` indicates that no occurrences are allowed at all. 

See Also
--------

#### Reference
[XmlSchemaManager Class][4]  
[Aml.Engine.Schema Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xname
[3]: https://docs.microsoft.com/dotnet/api/system.decimal
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png