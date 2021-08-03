# LookupService.IsReferenced Method 
AutomationML 2.1 API 

Determines whether the specified CAEX object is referenced.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool IsReferenced(
	CAEXObject caexObject
)
```

**VB**<br />
``` VB
Public Function IsReferenced ( 
	caexObject As CAEXObject
) As Boolean
```

**C++**<br />
``` C++
public:
virtual bool IsReferenced(
	CAEXObject^ caexObject
) sealed
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXObject">Aml.Engine.CAEX.CAEXObject</a><br />The CAEX object.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the specified CAEX object is referenced; otherwise, `false`.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IQuery_IsReferenced">IQuery.IsReferenced(CAEXObject)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_LookupService">LookupService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />