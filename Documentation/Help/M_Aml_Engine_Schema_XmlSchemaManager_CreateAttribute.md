# XmlSchemaManager.CreateAttribute Method 
AutomationML 2.1 API 

Creates the attribute with the provided name if this attribute is defined in this schema instance.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Schema">Aml.Engine.Schema</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public virtual XAttribute CreateAttribute(
	XElement element,
	string attributeName
)
```

**VB**<br />
``` VB
Public Overridable Function CreateAttribute ( 
	element As XElement,
	attributeName As String
) As XAttribute
```

**C++**<br />
``` C++
public:
virtual XAttribute^ CreateAttribute(
	XElement^ element, 
	String^ attributeName
)
```


#### Parameters
&nbsp;<dl><dt>element</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The element.</dd><dt>attributeName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Name of the attribute.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xattribute" target="_parent" rel="noopener noreferrer">XAttribute</a><br />The created XML attribute.

## See Also


#### Reference
<a href="T_Aml_Engine_Schema_XmlSchemaManager">XmlSchemaManager Class</a><br /><a href="N_Aml_Engine_Schema">Aml.Engine.Schema Namespace</a><br />