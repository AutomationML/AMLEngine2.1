# QueryService.InternalElementMirrors Method 
AutomationML 2.1 API 

Returns all Mirrors of the specified InternalElement

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<InternalElementType> InternalElementMirrors(
	InternalElementType master
)
```

**VB**<br />
``` VB
Public Function InternalElementMirrors ( 
	master As InternalElementType
) As IEnumerable(Of InternalElementType)
```

**C++**<br />
``` C++
public:
virtual IEnumerable<InternalElementType^>^ InternalElementMirrors(
	InternalElementType^ master
) sealed
```


#### Parameters
&nbsp;<dl><dt>master</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InternalElementType">Aml.Engine.CAEX.InternalElementType</a><br />The master.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a>)<br />An enumeration of mirror InternalElements

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IQuery_InternalElementMirrors">IQuery.InternalElementMirrors(InternalElementType)</a><br />

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td /></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_QueryService">QueryService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />