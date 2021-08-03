ValidatorService.ValidateAll Method (CAEXDocument, AutomationMLContainer, Boolean)
==================================================================================
AutomationML 2.1 APIGet Validation Information for all elements in the specified document, which have validation issues. The [IValidationResult][1] provides detailed information about available Repair Options and an additional Information Text. This method should be used, if the Document is loaded from an AutomationML container. The Validation service will check validity of external references which are packed parts of the container.

  **Namespace:**  [Aml.Engine.Services][2]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public IEnumerable<ValidationElement> ValidateAll(
	CAEXDocument document,
	AutomationMLContainer container,
	bool generateLongDescription = false
)
```

#### Parameters

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][3]  
The CAEX document.

##### *container*
Type: [Aml.Engine.AmlObjects.AutomationMLContainer][4]  
The AutomationML container, containing the document source.

##### *generateLongDescription* (Optional)
Type: [System.Boolean][5]  
if set to `true` generate long description for each validation issue.

#### Return Value
Type: [IEnumerable][6]&lt;[ValidationElement][7]>  
 A collection of validation information for CAEX objects. One CAEX object may have multiple occurrences with different validation issues in this collection. 
#### Implements
[IValidator&lt;RESULTTYPE>.ValidateAll(CAEXDocument, AutomationMLContainer, Boolean)][8]  


See Also
--------

#### Reference
[ValidatorService Class][9]  
[Aml.Engine.Services Namespace][2]  

[1]: ../../Aml.Engine.Services.Interfaces/IValidationResult/README.md
[2]: ../README.md
[3]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[4]: ../../Aml.Engine.AmlObjects/AutomationMLContainer/README.md
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[7]: ../ValidationElement/README.md
[8]: ../../Aml.Engine.Services.Interfaces/IValidator_1/ValidateAll.md
[9]: README.md
[10]: https://www.automationml.org
[11]: ../../icons/logoShade.png