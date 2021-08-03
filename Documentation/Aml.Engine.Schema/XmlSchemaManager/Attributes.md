XmlSchemaManager.Attributes Method
==================================
AutomationML 2.1 APIGets the Schema Elements for all attributes of the specified child element of the specified parent element, if the defined parent child relation exists in the xml schema. If required is set to `true`, only the required attributes are returned. The default behaviour is, that all attributes - optional and required attributes - are returned.

  **Namespace:**  [Aml.Engine.Schema][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<XmlSchemaAttribute> Attributes(
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
 optional parameter, defining of only required attributes are returned, or all attributes.

#### Return Value
Type: [IEnumerable][4]&lt;[XmlSchemaAttribute][5]>  
 Enumeration of attribute definitions 

See Also
--------

#### Reference
[XmlSchemaManager Class][6]  
[Aml.Engine.Schema Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xname
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: https://docs.microsoft.com/dotnet/api/system.xml.schema.xmlschemaattribute
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png