# XmlTypeCodeExtensions.XmlTypeCodeFromSchemaType Method 
AutomationML 2.1 API 

Gets the <a href="https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode" target="_parent" rel="noopener noreferrer">XmlTypeCode</a> from the W3C XSD schema type string.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Schema">Aml.Engine.Schema</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static XmlTypeCode XmlTypeCodeFromSchemaType(
	this string schemaType
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function XmlTypeCodeFromSchemaType ( 
	schemaType As String
) As XmlTypeCode
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static XmlTypeCode XmlTypeCodeFromSchemaType(
	String^ schemaType
)
```


#### Parameters
&nbsp;<dl><dt>schemaType</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />W3C XSD schema type, defined as xs:..., like xs:double and others.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode" target="_parent" rel="noopener noreferrer">XmlTypeCode</a><br />the XmlTypeCode. If the schemaType is not recognized, <a href="https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode" target="_parent" rel="noopener noreferrer">None</a> is returned.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Schema_XmlTypeCodeExtensions">XmlTypeCodeExtensions Class</a><br /><a href="N_Aml_Engine_Schema">Aml.Engine.Schema Namespace</a><br />