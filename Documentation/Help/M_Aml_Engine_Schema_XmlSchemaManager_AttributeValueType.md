# XmlSchemaManager.AttributeValueType Method (XName, XName, String)
AutomationML 2.1 API 

Gets the Attribute value types for the attribute with the defined name of a child element which belongs to the given parent. If `XmlTypeCode.Item` is returned, the value type is equal to the schema internal any type.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Schema">Aml.Engine.Schema</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public XmlTypeCode AttributeValueType(
	XName parentName,
	XName childName,
	string attributeName
)
```

**VB**<br />
``` VB
Public Function AttributeValueType ( 
	parentName As XName,
	childName As XName,
	attributeName As String
) As XmlTypeCode
```

**C++**<br />
``` C++
public:
XmlTypeCode AttributeValueType(
	XName^ parentName, 
	XName^ childName, 
	String^ attributeName
)
```


#### Parameters
&nbsp;<dl><dt>parentName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />Name of the parent.</dd><dt>childName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />Name of the child.</dd><dt>attributeName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Name of the attribute.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode" target="_parent" rel="noopener noreferrer">XmlTypeCode</a><br />The type code defined for the value.

## See Also


#### Reference
<a href="T_Aml_Engine_Schema_XmlSchemaManager">XmlSchemaManager Class</a><br /><a href="Overload_Aml_Engine_Schema_XmlSchemaManager_AttributeValueType">AttributeValueType Overload</a><br /><a href="N_Aml_Engine_Schema">Aml.Engine.Schema Namespace</a><br />