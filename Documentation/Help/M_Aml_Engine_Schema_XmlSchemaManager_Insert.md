# XmlSchemaManager.Insert Method 
AutomationML 2.1 API 

Inserts an existing child node into the collection of child nodes of the specified parent node.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Schema">Aml.Engine.Schema</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool Insert(
	XElement parent,
	XElement child
)
```

**VB**<br />
``` VB
Public Function Insert ( 
	parent As XElement,
	child As XElement
) As Boolean
```

**C++**<br />
``` C++
public:
bool Insert(
	XElement^ parent, 
	XElement^ child
)
```


#### Parameters
&nbsp;<dl><dt>parent</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The parent node</dd><dt>child</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The child node</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true`, if the node has been inserted; `false` otherwise.

## See Also


#### Reference
<a href="T_Aml_Engine_Schema_XmlSchemaManager">XmlSchemaManager Class</a><br /><a href="N_Aml_Engine_Schema">Aml.Engine.Schema Namespace</a><br />