# LookupService.IsMaster Method (ExternalInterfaceType)
AutomationML 2.1 API 

Determines whether the specified ExternalInterface is referenced by other ExternalInterface objects called 'Mirrors'.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool IsMaster(
	ExternalInterfaceType externalInterface
)
```

**VB**<br />
``` VB
Public Function IsMaster ( 
	externalInterface As ExternalInterfaceType
) As Boolean
```

**C++**<br />
``` C++
public:
virtual bool IsMaster(
	ExternalInterfaceType^ externalInterface
) sealed
```


#### Parameters
&nbsp;<dl><dt>externalInterface</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">Aml.Engine.CAEX.ExternalInterfaceType</a><br />The ExternalInterface element.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the specified element is a 'Master'-ExternalInterface; otherwise, `false`.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IQuery_IsMaster_1">IQuery.IsMaster(ExternalInterfaceType)</a><br />

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>externalInterface</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_LookupService">LookupService Class</a><br /><a href="Overload_Aml_Engine_Services_LookupService_IsMaster">IsMaster Overload</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />