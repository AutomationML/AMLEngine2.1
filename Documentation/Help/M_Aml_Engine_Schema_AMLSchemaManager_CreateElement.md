# AMLSchemaManager.CreateElement Method 
AutomationML 2.1 API 

Method overrides the <a href="M_Aml_Engine_Schema_XmlSchemaManager_CreateElement">CreateElement(XName, XName, Boolean)</a>. The created node is made to an AML node.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Schema">Aml.Engine.Schema</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public override XElement CreateElement(
	XName parentName,
	XName childName,
	bool allAttributes = false
)
```

**VB**<br />
``` VB
Public Overrides Function CreateElement ( 
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
) override
```


#### Parameters
&nbsp;<dl><dt>parentName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />Name of the child's parent</dd><dt>childName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />Name of the child</dd><dt>allAttributes (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />optional parameter to define, that not only required attributes, but all possible attributes should be created.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">XElement</a><br />The created XML node.

## See Also


#### Reference
<a href="T_Aml_Engine_Schema_AMLSchemaManager">AMLSchemaManager Class</a><br /><a href="N_Aml_Engine_Schema">Aml.Engine.Schema Namespace</a><br />