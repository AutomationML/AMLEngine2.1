XmlSchemaManager.Validate Method
================================
AutomationML 2.1 APIValidates a document if it is conform to this schema instance.

  **Namespace:**  [Aml.Engine.Schema][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool Validate(
	XDocument source,
	out string[] messages
)
```

#### Parameters

##### *source*
Type: [System.Xml.Linq.XDocument][2]  
The source.

##### *messages*
Type: [System.String][3][]  
The messages.

#### Return Value
Type: [Boolean][4]  
`true`, if the validation was without errors; false, otherwise.

See Also
--------

#### Reference
[XmlSchemaManager Class][5]  
[Aml.Engine.Schema Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xdocument
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png