# ValidatorService.NameValidation Method 
AutomationML 2.1 API 

Validates a name of a CAEX object. Names of CAEX classes or types (RoleClasses, InterfaceClasses, SystemUnitClasses and AttributeTypes), Attributes, Libraries and CAEX InstanceHierarchies shall be unique across its siblings or across all child elements of the same CAEX parent element over its life time. This shall assure that referencing a library, a class, a type or an attribute by its path delivers a unique result.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public (bool IsValid, string Message) NameValidation(
	CAEXObject caexObject,
	string name
)
```

**VB**<br />
``` VB
Public Function NameValidation ( 
	caexObject As CAEXObject,
	name As String
) As (IsValid As Boolean, Message As String)
```

**C++**<br />
``` C++
public:
virtual ValueTuple<bool, String^> NameValidation(
	CAEXObject^ caexObject, 
	String^ name
) sealed
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXObject">Aml.Engine.CAEX.CAEXObject</a><br />The CAEX object.</dd><dt>name</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The name, which should be assigned to the object.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.valuetuple-2" target="_parent" rel="noopener noreferrer">ValueTuple</a>(<a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a>, <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>)<br />A value tuple, returning the validation result and a message

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IValidator_NameValidation">IValidator.NameValidation(CAEXObject, String)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_ValidatorService">ValidatorService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />