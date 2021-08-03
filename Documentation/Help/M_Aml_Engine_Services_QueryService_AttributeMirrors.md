# QueryService.AttributeMirrors Method 
AutomationML 2.1 API 

Returns all Mirrors of the specified Attribute

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<AttributeType> AttributeMirrors(
	AttributeType master
)
```

**VB**<br />
``` VB
Public Function AttributeMirrors ( 
	master As AttributeType
) As IEnumerable(Of AttributeType)
```

**C++**<br />
``` C++
public:
virtual IEnumerable<AttributeType^>^ AttributeMirrors(
	AttributeType^ master
) sealed
```


#### Parameters
&nbsp;<dl><dt>master</dt><dd>Type: <a href="T_Aml_Engine_CAEX_AttributeType">Aml.Engine.CAEX.AttributeType</a><br />The master.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>)<br />An enumeration of mirror Attribute objects

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IQuery_AttributeMirrors">IQuery.AttributeMirrors(AttributeType)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_QueryService">QueryService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />