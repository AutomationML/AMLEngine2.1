# ValidatorService.ValidateAliasReferences Method 
AutomationML 2.1 API 

Validates the alias references and returns the validation result describing possible repair options. The <a href="T_Aml_Engine_Services_ValidationElement">ValidationElement</a> provides detailed information about available Repair Options and an additional Information Text.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<ValidationElement> ValidateAliasReferences(
	CAEXDocument document,
	bool generateLongDescription = false
)
```

**VB**<br />
``` VB
Public Function ValidateAliasReferences ( 
	document As CAEXDocument,
	Optional generateLongDescription As Boolean = false
) As IEnumerable(Of ValidationElement)
```

**C++**<br />
``` C++
public:
virtual IEnumerable<ValidationElement^>^ ValidateAliasReferences(
	CAEXDocument^ document, 
	bool generateLongDescription = false
) sealed
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The CAEX document.</dd><dt>generateLongDescription (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` [generate long description].</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_Services_ValidationElement">ValidationElement</a>)<br />\[Missing <returns> documentation for "M:Aml.Engine.Services.ValidatorService.ValidateAliasReferences(Aml.Engine.CAEX.CAEXDocument,System.Boolean)"\]

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IValidator_1_ValidateAliasReferences">IValidator(RESULTTYPE).ValidateAliasReferences(CAEXDocument, Boolean)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_ValidatorService">ValidatorService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />