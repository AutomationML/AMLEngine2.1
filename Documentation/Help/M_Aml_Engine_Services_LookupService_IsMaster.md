# LookupService.IsMaster Method (AttributeType)
AutomationML 2.1 API 

Determines whether the specified AttributeType is referenced by other AttributeType objects called 'Mirrors'.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool IsMaster(
	AttributeType element
)
```

**VB**<br />
``` VB
Public Function IsMaster ( 
	element As AttributeType
) As Boolean
```

**C++**<br />
``` C++
public:
virtual bool IsMaster(
	AttributeType^ element
) sealed
```


#### Parameters
&nbsp;<dl><dt>element</dt><dd>Type: <a href="T_Aml_Engine_CAEX_AttributeType">Aml.Engine.CAEX.AttributeType</a><br />The element.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the specified element is a 'Master'-Attribute; otherwise, `false`.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IQuery_IsMaster">IQuery.IsMaster(AttributeType)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_LookupService">LookupService Class</a><br /><a href="Overload_Aml_Engine_Services_LookupService_IsMaster">IsMaster Overload</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />