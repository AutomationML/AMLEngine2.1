# XmlSchemaManager.HasSequenceOfSimpleElements Method 
AutomationML 2.1 API 

Determines, if the schema defines a sequence of simple elements for the provided parent child combination.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Schema">Aml.Engine.Schema</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool HasSequenceOfSimpleElements(
	XName parentName,
	XName childName,
	out bool onlyOne
)
```

**VB**<br />
``` VB
Public Function HasSequenceOfSimpleElements ( 
	parentName As XName,
	childName As XName,
	<OutAttribute> ByRef onlyOne As Boolean
) As Boolean
```

**C++**<br />
``` C++
public:
bool HasSequenceOfSimpleElements(
	XName^ parentName, 
	XName^ childName, 
	[OutAttribute] bool% onlyOne
)
```


#### Parameters
&nbsp;<dl><dt>parentName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />Name of the parent.</dd><dt>childName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />Name of the child.</dd><dt>onlyOne</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` [only one].</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the provided parent child combination consists of a sequence of simple elements; otherwise, `false`.

## See Also


#### Reference
<a href="T_Aml_Engine_Schema_XmlSchemaManager">XmlSchemaManager Class</a><br /><a href="N_Aml_Engine_Schema">Aml.Engine.Schema Namespace</a><br />