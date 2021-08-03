# QueryService.IsMaster Method (InternalElementType)
AutomationML 2.1 API 

Determines whether the specified InternalElement is referenced by other InternalElement objects called 'Mirrors'.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool IsMaster(
	InternalElementType element
)
```

**VB**<br />
``` VB
Public Function IsMaster ( 
	element As InternalElementType
) As Boolean
```

**C++**<br />
``` C++
public:
virtual bool IsMaster(
	InternalElementType^ element
) sealed
```


#### Parameters
&nbsp;<dl><dt>element</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InternalElementType">Aml.Engine.CAEX.InternalElementType</a><br />The element.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the specified element is a 'Master'-InternalElement; otherwise, `false`.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IQuery_IsMaster_2">IQuery.IsMaster(InternalElementType)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_QueryService">QueryService Class</a><br /><a href="Overload_Aml_Engine_Services_QueryService_IsMaster">IsMaster Overload</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />