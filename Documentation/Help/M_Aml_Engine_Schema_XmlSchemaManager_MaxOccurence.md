# XmlSchemaManager.MaxOccurence Method 
AutomationML 2.1 API 

Returned the maximal occurrence for child nodes with the specified name under a parent node with the specified name. For unbounded occurrences, the returned value is <a href="https://docs.microsoft.com/dotnet/api/system.decimal.maxvalue" target="_parent" rel="noopener noreferrer">MaxValue</a>. If the occurrence is `0`, the existence of a child with that name under a parent with that name is not allowed.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Schema">Aml.Engine.Schema</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public decimal MaxOccurence(
	string parentName,
	string childName
)
```

**VB**<br />
``` VB
Public Function MaxOccurence ( 
	parentName As String,
	childName As String
) As Decimal
```

**C++**<br />
``` C++
public:
Decimal MaxOccurence(
	String^ parentName, 
	String^ childName
)
```


#### Parameters
&nbsp;<dl><dt>parentName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Name of the child's parent</dd><dt>childName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Name of the child</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.decimal" target="_parent" rel="noopener noreferrer">Decimal</a><br />The maximal occurrence of children with the defined name.

## See Also


#### Reference
<a href="T_Aml_Engine_Schema_XmlSchemaManager">XmlSchemaManager Class</a><br /><a href="N_Aml_Engine_Schema">Aml.Engine.Schema Namespace</a><br />