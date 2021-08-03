# XmlTypeCodeExtensions.Default Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Returns the default value for XmlTypeCode

**Namespace:**&nbsp;<a href="N_Aml_Engine_Schema">Aml.Engine.Schema</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Method Default is deprecated, please use DefaultDecodedValue or DefaultEncodedValue instead")]
public static Object Default(
	this XmlTypeCode typeCode
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Method Default is deprecated, please use DefaultDecodedValue or DefaultEncodedValue instead")>
Public Shared Function Default ( 
	typeCode As XmlTypeCode
) As Object
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Method Default is deprecated, please use DefaultDecodedValue or DefaultEncodedValue instead")]
static Object^ Default(
	XmlTypeCode typeCode
)
```


#### Parameters
&nbsp;<dl><dt>typeCode</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode" target="_parent" rel="noopener noreferrer">System.Xml.Schema.XmlTypeCode</a><br />Source</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">Object</a><br />The default value, according to the provided type code.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode" target="_parent" rel="noopener noreferrer">XmlTypeCode</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Schema_XmlTypeCodeExtensions">XmlTypeCodeExtensions Class</a><br /><a href="N_Aml_Engine_Schema">Aml.Engine.Schema Namespace</a><br />