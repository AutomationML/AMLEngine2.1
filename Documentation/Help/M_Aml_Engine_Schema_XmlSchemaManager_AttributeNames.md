# XmlSchemaManager.AttributeNames Method 
AutomationML 2.1 API 

Gets the Attribute names of the specified child element of the specified parent element.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Schema">Aml.Engine.Schema</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<string> AttributeNames(
	XName parentName,
	XName childName,
	bool required = false
)
```

**VB**<br />
``` VB
Public Function AttributeNames ( 
	parentName As XName,
	childName As XName,
	Optional required As Boolean = false
) As IEnumerable(Of String)
```

**C++**<br />
``` C++
public:
IEnumerable<String^>^ AttributeNames(
	XName^ parentName, 
	XName^ childName, 
	bool required = false
)
```


#### Parameters
&nbsp;<dl><dt>parentName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />name of the child's parent</dd><dt>childName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />name of the child</dd><dt>required (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />optional parameter, defining of only required attributes</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>)<br />Enumeration of attribute names

## See Also


#### Reference
<a href="T_Aml_Engine_Schema_XmlSchemaManager">XmlSchemaManager Class</a><br /><a href="N_Aml_Engine_Schema">Aml.Engine.Schema Namespace</a><br />