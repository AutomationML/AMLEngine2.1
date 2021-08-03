# XmlSchemaManager.IsParent Method 
AutomationML 2.1 API 

Determines, if the parent is allowed to contain a child with the provided name according to this schema instance.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Schema">Aml.Engine.Schema</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool IsParent(
	XElement parent,
	XName childName
)
```

**VB**<br />
``` VB
Public Function IsParent ( 
	parent As XElement,
	childName As XName
) As Boolean
```

**C++**<br />
``` C++
public:
bool IsParent(
	XElement^ parent, 
	XName^ childName
)
```


#### Parameters
&nbsp;<dl><dt>parent</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The parent.</dd><dt>childName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />Name of the child.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the parent can contain a child element with that name; otherwise, `false`.

## See Also


#### Reference
<a href="T_Aml_Engine_Schema_XmlSchemaManager">XmlSchemaManager Class</a><br /><a href="N_Aml_Engine_Schema">Aml.Engine.Schema Namespace</a><br />