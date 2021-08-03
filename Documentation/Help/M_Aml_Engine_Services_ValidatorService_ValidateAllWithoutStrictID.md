# ValidatorService.ValidateAllWithoutStrictID Method 
AutomationML 2.1 API 

Get Validation Information for all elements in the specified document, which have validation issues. The <a href="T_Aml_Engine_Services_ValidationElement">ValidationElement</a> provides detailed information about available Repair Options and an additional Information Text.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<ValidationElement> ValidateAllWithoutStrictID(
	CAEXDocument document,
	AutomationMLContainer container = null,
	bool generateLongDescription = false
)
```

**VB**<br />
``` VB
Public Function ValidateAllWithoutStrictID ( 
	document As CAEXDocument,
	Optional container As AutomationMLContainer = Nothing,
	Optional generateLongDescription As Boolean = false
) As IEnumerable(Of ValidationElement)
```

**C++**<br />
``` C++
public:
IEnumerable<ValidationElement^>^ ValidateAllWithoutStrictID(
	CAEXDocument^ document, 
	AutomationMLContainer^ container = nullptr, 
	bool generateLongDescription = false
)
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The CAEX document.</dd><dt>container (Optional)</dt><dd>Type: <a href="T_Aml_Engine_AmlObjects_AutomationMLContainer">Aml.Engine.AmlObjects.AutomationMLContainer</a><br />If set, the associated parts, defined in the AutomationML container are used to validate external references.</dd><dt>generateLongDescription (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` [generate long description].</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_Services_ValidationElement">ValidationElement</a>)<br />An enumeration of validation information for CAEX objects. One CAEX object may have multiple occurrences with different validation issues in this collection.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_ValidatorService">ValidatorService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />