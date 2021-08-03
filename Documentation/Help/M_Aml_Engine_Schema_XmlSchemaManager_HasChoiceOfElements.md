# XmlSchemaManager.HasChoiceOfElements Method 
AutomationML 2.1 API 

Determines, whether the schema element representing the parent - child relation has a content, which is restricted to a choice of elements. If onlyOne is set to true, there can not be more than one element added to the element

**Namespace:**&nbsp;<a href="N_Aml_Engine_Schema">Aml.Engine.Schema</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool HasChoiceOfElements(
	XName parentName,
	XName childName,
	out bool onlyOne
)
```

**VB**<br />
``` VB
Public Function HasChoiceOfElements ( 
	parentName As XName,
	childName As XName,
	<OutAttribute> ByRef onlyOne As Boolean
) As Boolean
```

**C++**<br />
``` C++
public:
bool HasChoiceOfElements(
	XName^ parentName, 
	XName^ childName, 
	[OutAttribute] bool% onlyOne
)
```


#### Parameters
&nbsp;<dl><dt>parentName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />Name of the parent.</dd><dt>childName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />Name of the child.</dd><dt>onlyOne</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` [only one].</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the specified parent to child relation is restricted to a choice of elements; otherwise, `false`.

## See Also


#### Reference
<a href="T_Aml_Engine_Schema_XmlSchemaManager">XmlSchemaManager Class</a><br /><a href="N_Aml_Engine_Schema">Aml.Engine.Schema Namespace</a><br />