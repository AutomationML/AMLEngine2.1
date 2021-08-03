# IQuery.AttributeMirrors Method 
AutomationML 2.1 API 

Returns all Mirrors of the specified Attribute

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
IEnumerable<AttributeType> AttributeMirrors(
	AttributeType master
)
```

**VB**<br />
``` VB
Function AttributeMirrors ( 
	master As AttributeType
) As IEnumerable(Of AttributeType)
```

**C++**<br />
``` C++
IEnumerable<AttributeType^>^ AttributeMirrors(
	AttributeType^ master
)
```


#### Parameters
&nbsp;<dl><dt>master</dt><dd>Type: <a href="T_Aml_Engine_CAEX_AttributeType">Aml.Engine.CAEX.AttributeType</a><br />The master.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>)<br />An enumeration of mirror Attribute objects

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IQuery">IQuery Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />