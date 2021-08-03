# ValidatorService.Repair Method 
AutomationML 2.1 API 

Repairs the specified validated element.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool Repair(
	ValidationElement validation
)
```

**VB**<br />
``` VB
Public Function Repair ( 
	validation As ValidationElement
) As Boolean
```

**C++**<br />
``` C++
public:
virtual bool Repair(
	ValidationElement^ validation
) sealed
```


#### Parameters
&nbsp;<dl><dt>validation</dt><dd>Type: <a href="T_Aml_Engine_Services_ValidationElement">Aml.Engine.Services.ValidationElement</a><br />The validated element.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the element has been repaired, `false` otherwise.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IValidator_1_Repair">IValidator(RESULTTYPE).Repair(RESULTTYPE)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_ValidatorService">ValidatorService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br /><a href="M_Aml_Engine_Services_ValidatorService_ValidateAll_1">ValidatorService.ValidateAll(CAEXDocument, Boolean)</a><br />