# XmlSchemaManager.ChildElementNames Method 
AutomationML 2.1 API 

Gets the Names for all elements, which can be added to the child which is defined with the name of it's parent and the name of itself.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Schema">Aml.Engine.Schema</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<XName> ChildElementNames(
	XName parentName,
	XName childName,
	bool includeChoice
)
```

**VB**<br />
``` VB
Public Function ChildElementNames ( 
	parentName As XName,
	childName As XName,
	includeChoice As Boolean
) As IEnumerable(Of XName)
```

**C++**<br />
``` C++
public:
IEnumerable<XName^>^ ChildElementNames(
	XName^ parentName, 
	XName^ childName, 
	bool includeChoice
)
```


#### Parameters
&nbsp;<dl><dt>parentName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />Name of the child's parent.</dd><dt>childName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />Name of the child</dd><dt>includeChoice</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` [include choice].</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">XName</a>)<br />Enumeration of all names of possible child elements.

## See Also


#### Reference
<a href="T_Aml_Engine_Schema_XmlSchemaManager">XmlSchemaManager Class</a><br /><a href="N_Aml_Engine_Schema">Aml.Engine.Schema Namespace</a><br />