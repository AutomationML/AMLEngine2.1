IValidator&lt;RESULTTYPE>.ValidateAll Method (CAEXDocument, AutomationMLContainer, Boolean)
===========================================================================================
AutomationML 2.1 APIGet Validation Information for all elements in the specified document, which have validation issues. The [IValidationResult][1] provides detailed information about available Repair Options and an additional Information Text. This method should be used, if the Document is loaded from an AutomationML container. The Validation service will check validity of external references which are packed parts of the container.

  **Namespace:**  [Aml.Engine.Services.Interfaces][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
IEnumerable<RESULTTYPE> ValidateAll(
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
Type: [IEnumerable][6]&lt;[RESULTTYPE][7]>  
 A collection of validation information for CAEX objects. One CAEX object may have multiple occurrences with different validation issues in this collection. 

See Also
--------

#### Reference
[IValidator&lt;RESULTTYPE> Interface][7]  
[Aml.Engine.Services.Interfaces Namespace][2]  

[1]: ../IValidationResult/README.md
[2]: ../README.md
[3]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[4]: ../../Aml.Engine.AmlObjects/AutomationMLContainer/README.md
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png