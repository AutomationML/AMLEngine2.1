XmlSchemaManager.AttributeNames Method
======================================
AutomationML 2.1 APIGets the Attribute names of the specified child element of the specified parent element.

  **Namespace:**  [Aml.Engine.Schema][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<string> AttributeNames(
	XName parentName,
	XName childName,
	bool required = false
)
```

#### Parameters

##### *parentName*
Type: [System.Xml.Linq.XName][2]  
name of the child's parent

##### *childName*
Type: [System.Xml.Linq.XName][2]  
name of the child

##### *required* (Optional)
Type: [System.Boolean][3]  
optional parameter, defining of only required attributes

#### Return Value
Type: [IEnumerable][4]&lt;[String][5]>  
Enumeration of attribute names

See Also
--------

#### Reference
[XmlSchemaManager Class][6]  
[Aml.Engine.Schema Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xname
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: https://docs.microsoft.com/dotnet/api/system.string
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png