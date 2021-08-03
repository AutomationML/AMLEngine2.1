# QueryService.IsMaster Method (AttributeType)
AutomationML 2.1 API 

Determines whether the specified attribute is a master attribute.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool IsMaster(
	AttributeType attribute
)
```

**VB**<br />
``` VB
Public Function IsMaster ( 
	attribute As AttributeType
) As Boolean
```

**C++**<br />
``` C++
public:
virtual bool IsMaster(
	AttributeType^ attribute
) sealed
```


#### Parameters
&nbsp;<dl><dt>attribute</dt><dd>Type: <a href="T_Aml_Engine_CAEX_AttributeType">Aml.Engine.CAEX.AttributeType</a><br />The attribute.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the specified attribute is master; otherwise, `false`.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IQuery_IsMaster">IQuery.IsMaster(AttributeType)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_QueryService">QueryService Class</a><br /><a href="Overload_Aml_Engine_Services_QueryService_IsMaster">IsMaster Overload</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />