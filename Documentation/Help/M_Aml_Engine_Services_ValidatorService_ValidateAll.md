# ValidatorService.ValidateAll Method (CAEXDocument, AutomationMLContainer, Boolean)
AutomationML 2.1 API 

Get Validation Information for all elements in the specified document, which have validation issues. The <a href="T_Aml_Engine_Services_Interfaces_IValidationResult">IValidationResult</a> provides detailed information about available Repair Options and an additional Information Text. This method should be used, if the Document is loaded from an AutomationML container. The Validation service will check validity of external references which are packed parts of the container.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<ValidationElement> ValidateAll(
	CAEXDocument document,
	AutomationMLContainer container,
	bool generateLongDescription = false
)
```

**VB**<br />
``` VB
Public Function ValidateAll ( 
	document As CAEXDocument,
	container As AutomationMLContainer,
	Optional generateLongDescription As Boolean = false
) As IEnumerable(Of ValidationElement)
```

**C++**<br />
``` C++
public:
virtual IEnumerable<ValidationElement^>^ ValidateAll(
	CAEXDocument^ document, 
	AutomationMLContainer^ container, 
	bool generateLongDescription = false
) sealed
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The CAEX document.</dd><dt>container</dt><dd>Type: <a href="T_Aml_Engine_AmlObjects_AutomationMLContainer">Aml.Engine.AmlObjects.AutomationMLContainer</a><br />The AutomationML container, containing the document source.</dd><dt>generateLongDescription (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` generate long description for each validation issue.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_Services_ValidationElement">ValidationElement</a>)<br />A collection of validation information for CAEX objects. One CAEX object may have multiple occurrences with different validation issues in this collection.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IValidator_1_ValidateAll">IValidator(RESULTTYPE).ValidateAll(CAEXDocument, AutomationMLContainer, Boolean)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_ValidatorService">ValidatorService Class</a><br /><a href="Overload_Aml_Engine_Services_ValidatorService_ValidateAll">ValidateAll Overload</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />