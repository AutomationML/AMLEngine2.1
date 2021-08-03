# XmlSchemaManager.Attributes Method 
AutomationML 2.1 API 

Gets the Schema Elements for all attributes of the specified child element of the specified parent element, if the defined parent child relation exists in the xml schema. If required is set to `true`, only the required attributes are returned. The default behaviour is, that all attributes - optional and required attributes - are returned.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Schema">Aml.Engine.Schema</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<XmlSchemaAttribute> Attributes(
	XName parentName,
	XName childName,
	bool required = false
)
```

**VB**<br />
``` VB
Public Function Attributes ( 
	parentName As XName,
	childName As XName,
	Optional required As Boolean = false
) As IEnumerable(Of XmlSchemaAttribute)
```

**C++**<br />
``` C++
public:
IEnumerable<XmlSchemaAttribute^>^ Attributes(
	XName^ parentName, 
	XName^ childName, 
	bool required = false
)
```


#### Parameters
&nbsp;<dl><dt>parentName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />name of the child's parent</dd><dt>childName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />name of the child</dd><dt>required (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />optional parameter, defining of only required attributes are returned, or all attributes.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="https://docs.microsoft.com/dotnet/api/system.xml.schema.xmlschemaattribute" target="_parent" rel="noopener noreferrer">XmlSchemaAttribute</a>)<br />Enumeration of attribute definitions

## See Also


#### Reference
<a href="T_Aml_Engine_Schema_XmlSchemaManager">XmlSchemaManager Class</a><br /><a href="N_Aml_Engine_Schema">Aml.Engine.Schema Namespace</a><br />