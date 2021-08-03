XmlSchemaManager.IsChoiceForOneElement Method
=============================================
AutomationML 2.1 APIDetermines if the schema defines a choice of only one element for the provided schema element.

  **Namespace:**  [Aml.Engine.Schema][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool IsChoiceForOneElement(
	XmlSchemaElement schemaElement
)
```

#### Parameters

##### *schemaElement*
Type: [System.Xml.Schema.XmlSchemaElement][2]  
The schema element.

#### Return Value
Type: [Boolean][3]  
`true` if the specified schema element defines a choice of only one element; otherwise, `false`. 

See Also
--------

#### Reference
[XmlSchemaManager Class][4]  
[Aml.Engine.Schema Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.schema.xmlschemaelement
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png