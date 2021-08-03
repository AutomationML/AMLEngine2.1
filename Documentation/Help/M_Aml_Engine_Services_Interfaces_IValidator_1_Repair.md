# IValidator(*RESULTTYPE*).Repair Method 
AutomationML 2.1 API 

Repairs the specified validated element.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
bool Repair(
	RESULTTYPE validation
)
```

**VB**<br />
``` VB
Function Repair ( 
	validation As RESULTTYPE
) As Boolean
```

**C++**<br />
``` C++
bool Repair(
	RESULTTYPE validation
)
```


#### Parameters
&nbsp;<dl><dt>validation</dt><dd>Type: <a href="T_Aml_Engine_Services_Interfaces_IValidator_1">*RESULTTYPE*</a><br />The validated element.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the element has been repaired, `false` otherwise.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IValidator_1">IValidator(RESULTTYPE) Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />