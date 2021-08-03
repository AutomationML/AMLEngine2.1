# XmlSchemaManager.CreateElement Method 
AutomationML 2.1 API 

Creates a new node with the specified child name in the given xmlDocument. The node is created with all required attributes and elements but is not inserted in the document tree at this point. Use <a href="M_Aml_Engine_Schema_XmlSchemaManager_Insert">Insert(XElement, XElement)</a> for insertion or <a href="M_Aml_Engine_Schema_XmlSchemaManager_InsertNew">InsertNew(XElement, XName, Boolean)</a> for a combined creation and insertion.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Schema">Aml.Engine.Schema</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public virtual XElement CreateElement(
	XName parentName,
	XName childName,
	bool allAttributes = false
)
```

**VB**<br />
``` VB
Public Overridable Function CreateElement ( 
	parentName As XName,
	childName As XName,
	Optional allAttributes As Boolean = false
) As XElement
```

**C++**<br />
``` C++
public:
virtual XElement^ CreateElement(
	XName^ parentName, 
	XName^ childName, 
	bool allAttributes = false
)
```


#### Parameters
&nbsp;<dl><dt>parentName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />Name of the child's parent</dd><dt>childName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />Name of the child</dd><dt>allAttributes (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />Optional parameter to define, that not only required attributes, but all possible attributes should be created.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">XElement</a><br />The created XML element.

## Remarks
The Method can be overridden by specific schema managers, to add additional properties to the created node, which can not be derived directly from the schema.

## See Also


#### Reference
<a href="T_Aml_Engine_Schema_XmlSchemaManager">XmlSchemaManager Class</a><br /><a href="N_Aml_Engine_Schema">Aml.Engine.Schema Namespace</a><br />