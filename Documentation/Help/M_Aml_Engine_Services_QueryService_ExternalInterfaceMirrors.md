# QueryService.ExternalInterfaceMirrors Method 
AutomationML 2.1 API 

Returns all Mirrors of the specified ExternalInterface

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<ExternalInterfaceType> ExternalInterfaceMirrors(
	ExternalInterfaceType master
)
```

**VB**<br />
``` VB
Public Function ExternalInterfaceMirrors ( 
	master As ExternalInterfaceType
) As IEnumerable(Of ExternalInterfaceType)
```

**C++**<br />
``` C++
public:
virtual IEnumerable<ExternalInterfaceType^>^ ExternalInterfaceMirrors(
	ExternalInterfaceType^ master
) sealed
```


#### Parameters
&nbsp;<dl><dt>master</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">Aml.Engine.CAEX.ExternalInterfaceType</a><br />The master.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a>)<br />An enumeration of mirror ExternalInterface objects

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IQuery_ExternalInterfaceMirrors">IQuery.ExternalInterfaceMirrors(ExternalInterfaceType)</a><br />

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td /></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_QueryService">QueryService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />