# IValidator(*RESULTTYPE*).ValidateAliasReferences Method 
AutomationML 2.1 API 

Validates the alias references and returns the validation result describing possible repair options. The <a href="T_Aml_Engine_Services_Interfaces_IValidationResult">IValidationResult</a> provides detailed information about available Repair Options and an additional Information Text.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
IEnumerable<RESULTTYPE> ValidateAliasReferences(
	CAEXDocument document,
	bool generateLongDescription = false
)
```

**VB**<br />
``` VB
Function ValidateAliasReferences ( 
	document As CAEXDocument,
	Optional generateLongDescription As Boolean = false
) As IEnumerable(Of RESULTTYPE)
```

**C++**<br />
``` C++
IEnumerable<RESULTTYPE>^ ValidateAliasReferences(
	CAEXDocument^ document, 
	bool generateLongDescription = false
)
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The CAEX document.</dd><dt>generateLongDescription (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` generate long description for each validation issue.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_Services_Interfaces_IValidator_1">*RESULTTYPE*</a>)<br />\[Missing <returns> documentation for "M:Aml.Engine.Services.Interfaces.IValidator`1.ValidateAliasReferences(Aml.Engine.CAEX.CAEXDocument,System.Boolean)"\]

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IValidator_1">IValidator(RESULTTYPE) Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />