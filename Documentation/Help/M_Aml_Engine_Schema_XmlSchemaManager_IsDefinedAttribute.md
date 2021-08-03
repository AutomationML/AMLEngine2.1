# XmlSchemaManager.IsDefinedAttribute Method 
AutomationML 2.1 API 

Determines, if the Attribute with the provided is defined for this element

**Namespace:**&nbsp;<a href="N_Aml_Engine_Schema">Aml.Engine.Schema</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool IsDefinedAttribute(
	XName parentName,
	XName childName,
	string attributeName
)
```

**VB**<br />
``` VB
Public Function IsDefinedAttribute ( 
	parentName As XName,
	childName As XName,
	attributeName As String
) As Boolean
```

**C++**<br />
``` C++
public:
bool IsDefinedAttribute(
	XName^ parentName, 
	XName^ childName, 
	String^ attributeName
)
```


#### Parameters
&nbsp;<dl><dt>parentName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />Name of the parent.</dd><dt>childName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />Name of the child.</dd><dt>attributeName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Name of the attribute.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the attribute name is an allowed attribute for the child; otherwise, `false`.

## See Also


#### Reference
<a href="T_Aml_Engine_Schema_XmlSchemaManager">XmlSchemaManager Class</a><br /><a href="N_Aml_Engine_Schema">Aml.Engine.Schema Namespace</a><br />