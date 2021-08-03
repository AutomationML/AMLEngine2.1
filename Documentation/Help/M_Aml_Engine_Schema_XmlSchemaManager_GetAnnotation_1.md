# XmlSchemaManager.GetAnnotation Method (XmlSchemaAttribute)
AutomationML 2.1 API 

Gets the annotation from the schema attribute element.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Schema">Aml.Engine.Schema</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public string GetAnnotation(
	XmlSchemaAttribute schemaAttribute
)
```

**VB**<br />
``` VB
Public Function GetAnnotation ( 
	schemaAttribute As XmlSchemaAttribute
) As String
```

**C++**<br />
``` C++
public:
String^ GetAnnotation(
	XmlSchemaAttribute^ schemaAttribute
)
```


#### Parameters
&nbsp;<dl><dt>schemaAttribute</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.schema.xmlschemaattribute" target="_parent" rel="noopener noreferrer">System.Xml.Schema.XmlSchemaAttribute</a><br />The schema attribute.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />The annotation of the schema attribute, as it is defined in the schema.

## See Also


#### Reference
<a href="T_Aml_Engine_Schema_XmlSchemaManager">XmlSchemaManager Class</a><br /><a href="Overload_Aml_Engine_Schema_XmlSchemaManager_GetAnnotation">GetAnnotation Overload</a><br /><a href="N_Aml_Engine_Schema">Aml.Engine.Schema Namespace</a><br />