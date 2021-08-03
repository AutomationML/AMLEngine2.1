# XmlSchemaManager.SchemaElement Method 
AutomationML 2.1 API 

Gets the schema information for the provided parent child combination.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Schema">Aml.Engine.Schema</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public XmlSchemaElement SchemaElement(
	XName parentName,
	XName childName
)
```

**VB**<br />
``` VB
Public Function SchemaElement ( 
	parentName As XName,
	childName As XName
) As XmlSchemaElement
```

**C++**<br />
``` C++
public:
XmlSchemaElement^ SchemaElement(
	XName^ parentName, 
	XName^ childName
)
```


#### Parameters
&nbsp;<dl><dt>parentName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />name of the parent element</dd><dt>childName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />name of the child element</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.schema.xmlschemaelement" target="_parent" rel="noopener noreferrer">XmlSchemaElement</a><br />returns `null`, if no schema information exists for the parent child combination.

## See Also


#### Reference
<a href="T_Aml_Engine_Schema_XmlSchemaManager">XmlSchemaManager Class</a><br /><a href="N_Aml_Engine_Schema">Aml.Engine.Schema Namespace</a><br />