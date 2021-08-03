# XmlSchemaManager.Validate Method 
AutomationML 2.1 API 

Validates a document if it is conform to this schema instance.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Schema">Aml.Engine.Schema</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool Validate(
	XDocument source,
	out string[] messages
)
```

**VB**<br />
``` VB
Public Function Validate ( 
	source As XDocument,
	<OutAttribute> ByRef messages As String()
) As Boolean
```

**C++**<br />
``` C++
public:
bool Validate(
	XDocument^ source, 
	[OutAttribute] array<String^>^% messages
)
```


#### Parameters
&nbsp;<dl><dt>source</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xdocument" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XDocument</a><br />The source.</dd><dt>messages</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a>[]<br />The messages.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true`, if the validation was without errors; false, otherwise.

## See Also


#### Reference
<a href="T_Aml_Engine_Schema_XmlSchemaManager">XmlSchemaManager Class</a><br /><a href="N_Aml_Engine_Schema">Aml.Engine.Schema Namespace</a><br />