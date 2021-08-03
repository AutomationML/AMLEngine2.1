# XmlSchemaManager.MinOccurence Method 
AutomationML 2.1 API 

The minimal occurrence for child node with the defined name under a parent node with the defined name. If 0 is returned, the existence of a child node with that node is optional. If 1 is returned, the existence is mandatory.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Schema">Aml.Engine.Schema</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public decimal MinOccurence(
	XName parentName,
	XName childName
)
```

**VB**<br />
``` VB
Public Function MinOccurence ( 
	parentName As XName,
	childName As XName
) As Decimal
```

**C++**<br />
``` C++
public:
Decimal MinOccurence(
	XName^ parentName, 
	XName^ childName
)
```


#### Parameters
&nbsp;<dl><dt>parentName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />Name of the child's parent</dd><dt>childName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />Name of the child</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.decimal" target="_parent" rel="noopener noreferrer">Decimal</a><br />`0` for optional occurrence or `1` for mandatory occurrence. A value of `-1` indicates that no occurrences are allowed at all.

## See Also


#### Reference
<a href="T_Aml_Engine_Schema_XmlSchemaManager">XmlSchemaManager Class</a><br /><a href="N_Aml_Engine_Schema">Aml.Engine.Schema Namespace</a><br />