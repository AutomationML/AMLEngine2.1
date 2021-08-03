# ValidatorService.IDValidation Method 
AutomationML 2.1 API 

Validates the ID of a CAEX object. IDs of CAEX objects shall be unique.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public (bool IsValid, string Message) IDValidation(
	CAEXObject caexObject,
	string ID
)
```

**VB**<br />
``` VB
Public Function IDValidation ( 
	caexObject As CAEXObject,
	ID As String
) As (IsValid As Boolean, Message As String)
```

**C++**<br />
``` C++
public:
virtual ValueTuple<bool, String^> IDValidation(
	CAEXObject^ caexObject, 
	String^ ID
) sealed
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXObject">Aml.Engine.CAEX.CAEXObject</a><br />The CAEX object.</dd><dt>ID</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The ID, which should be assigned to the object. If no ID is defined, the uniqueness of the already assigned ID is evaluated.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.valuetuple-2" target="_parent" rel="noopener noreferrer">ValueTuple</a>(<a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a>, <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>)<br />A value tuple, returning the validation result and a message

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IValidator_IDValidation">IValidator.IDValidation(CAEXObject, String)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_ValidatorService">ValidatorService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />