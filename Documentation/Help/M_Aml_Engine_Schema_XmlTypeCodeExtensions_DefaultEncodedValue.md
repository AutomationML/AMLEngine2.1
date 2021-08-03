# XmlTypeCodeExtensions.DefaultEncodedValue Method 
AutomationML 2.1 API 

Converts the default value for the specified typeCode to a valid XML value string

**Namespace:**&nbsp;<a href="N_Aml_Engine_Schema">Aml.Engine.Schema</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static string DefaultEncodedValue(
	this XmlTypeCode typeCode
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function DefaultEncodedValue ( 
	typeCode As XmlTypeCode
) As String
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static String^ DefaultEncodedValue(
	XmlTypeCode typeCode
)
```


#### Parameters
&nbsp;<dl><dt>typeCode</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode" target="_parent" rel="noopener noreferrer">System.Xml.Schema.XmlTypeCode</a><br />The <a href="https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode" target="_parent" rel="noopener noreferrer">XmlTypeCode</a></dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />The default XML value, according to the provided type code.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode" target="_parent" rel="noopener noreferrer">XmlTypeCode</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Schema_XmlTypeCodeExtensions">XmlTypeCodeExtensions Class</a><br /><a href="N_Aml_Engine_Schema">Aml.Engine.Schema Namespace</a><br />