# XmlSchemaManager.AddNew Method 
AutomationML 2.1 API 

Creates a new Xml-Element with the provided content and inserts it to the provided parent according to this schema instance.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Schema">Aml.Engine.Schema</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public virtual XElement AddNew(
	XElement parent,
	XName childName,
	Object content
)
```

**VB**<br />
``` VB
Public Overridable Function AddNew ( 
	parent As XElement,
	childName As XName,
	content As Object
) As XElement
```

**C++**<br />
``` C++
public:
virtual XElement^ AddNew(
	XElement^ parent, 
	XName^ childName, 
	Object^ content
)
```


#### Parameters
&nbsp;<dl><dt>parent</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The parent XML element.</dd><dt>childName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />The name of the child element.</dd><dt>content</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />Initial content of the child.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">XElement</a><br />The created XML element.

## See Also


#### Reference
<a href="T_Aml_Engine_Schema_XmlSchemaManager">XmlSchemaManager Class</a><br /><a href="N_Aml_Engine_Schema">Aml.Engine.Schema Namespace</a><br />