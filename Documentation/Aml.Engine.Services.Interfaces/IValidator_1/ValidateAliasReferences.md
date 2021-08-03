IValidator&lt;RESULTTYPE>.ValidateAliasReferences Method
========================================================
Validates the alias references and returns the validation result describing possible repair options. The [IValidationResult][1] provides detailed information about available Repair Options and an additional Information Text.

  **Namespace:**  [Aml.Engine.Services.Interfaces][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
IEnumerable<RESULTTYPE> ValidateAliasReferences(
	CAEXDocument document,
	bool generateLongDescription = false
)
```

#### Parameters

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][3]  
The CAEX document.

##### *generateLongDescription* (Optional)
Type: [System.Boolean][4]  
if set to `true` generate long description for each validation issue.

#### Return Value
Type: [IEnumerable][5]&lt;[RESULTTYPE][6]>  

[Missing &lt;returns> documentation for "M:Aml.Engine.Services.Interfaces.IValidator`1.ValidateAliasReferences(Aml.Engine.CAEX.CAEXDocument,System.Boolean)"]


See Also
--------

#### Reference
[IValidator&lt;RESULTTYPE> Interface][6]  
[Aml.Engine.Services.Interfaces Namespace][2]  

[1]: ../IValidationResult/README.md
[2]: ../README.md
[3]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png