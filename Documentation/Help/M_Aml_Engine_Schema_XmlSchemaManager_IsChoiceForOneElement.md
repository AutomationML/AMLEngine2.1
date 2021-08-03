# XmlSchemaManager.IsChoiceForOneElement Method 
AutomationML 2.1 API 

Determines if the schema defines a choice of only one element for the provided schema element.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Schema">Aml.Engine.Schema</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool IsChoiceForOneElement(
	XmlSchemaElement schemaElement
)
```

**VB**<br />
``` VB
Public Function IsChoiceForOneElement ( 
	schemaElement As XmlSchemaElement
) As Boolean
```

**C++**<br />
``` C++
public:
bool IsChoiceForOneElement(
	XmlSchemaElement^ schemaElement
)
```


#### Parameters
&nbsp;<dl><dt>schemaElement</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.schema.xmlschemaelement" target="_parent" rel="noopener noreferrer">System.Xml.Schema.XmlSchemaElement</a><br />The schema element.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the specified schema element defines a choice of only one element; otherwise, `false`.

## See Also


#### Reference
<a href="T_Aml_Engine_Schema_XmlSchemaManager">XmlSchemaManager Class</a><br /><a href="N_Aml_Engine_Schema">Aml.Engine.Schema Namespace</a><br />