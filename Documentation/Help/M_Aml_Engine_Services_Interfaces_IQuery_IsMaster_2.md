# IQuery.IsMaster Method (InternalElementType)
AutomationML 2.1 API 

Determines whether the specified InternalElement is referenced by other InternalElement objects called 'Mirrors'.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
bool IsMaster(
	InternalElementType element
)
```

**VB**<br />
``` VB
Function IsMaster ( 
	element As InternalElementType
) As Boolean
```

**C++**<br />
``` C++
bool IsMaster(
	InternalElementType^ element
)
```


#### Parameters
&nbsp;<dl><dt>element</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InternalElementType">Aml.Engine.CAEX.InternalElementType</a><br />The element.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the specified element is a 'Master'-InternalElement; otherwise, `false`.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IQuery">IQuery Interface</a><br /><a href="Overload_Aml_Engine_Services_Interfaces_IQuery_IsMaster">IsMaster Overload</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />