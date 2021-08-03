# IQuery.IsMaster Method (AttributeType)
AutomationML 2.1 API 

Determines whether the specified AttributeType is referenced by other AttributeType objects called 'Mirrors'.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
bool IsMaster(
	AttributeType attribute
)
```

**VB**<br />
``` VB
Function IsMaster ( 
	attribute As AttributeType
) As Boolean
```

**C++**<br />
``` C++
bool IsMaster(
	AttributeType^ attribute
)
```


#### Parameters
&nbsp;<dl><dt>attribute</dt><dd>Type: <a href="T_Aml_Engine_CAEX_AttributeType">Aml.Engine.CAEX.AttributeType</a><br />The attribute type</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the specified element is a 'Master'-Attribute; otherwise, `false`.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IQuery">IQuery Interface</a><br /><a href="Overload_Aml_Engine_Services_Interfaces_IQuery_IsMaster">IsMaster Overload</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />