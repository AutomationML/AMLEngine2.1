# XmlSchemaManager.AcceptsAny Method 
AutomationML 2.1 API 

Determines if the schema element accepts values of any type.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Schema">Aml.Engine.Schema</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool AcceptsAny(
	XmlSchemaElement schemaElement
)
```

**VB**<br />
``` VB
Public Function AcceptsAny ( 
	schemaElement As XmlSchemaElement
) As Boolean
```

**C++**<br />
``` C++
public:
bool AcceptsAny(
	XmlSchemaElement^ schemaElement
)
```


#### Parameters
&nbsp;<dl><dt>schemaElement</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.schema.xmlschemaelement" target="_parent" rel="noopener noreferrer">System.Xml.Schema.XmlSchemaElement</a><br />The schema element.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true`, if any types are accepted as values.

## See Also


#### Reference
<a href="T_Aml_Engine_Schema_XmlSchemaManager">XmlSchemaManager Class</a><br /><a href="N_Aml_Engine_Schema">Aml.Engine.Schema Namespace</a><br />