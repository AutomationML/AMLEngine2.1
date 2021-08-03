ValidatorService.ValidateAll Method (CAEXDocument, Boolean)
===========================================================
AutomationML 2.1 APIGet Validation Information for all elements in the specified document, which have validation issues. The [ValidationElement][1] provides detailed information about available Repair Options and an additional Information Text.

  **Namespace:**  [Aml.Engine.Services][2]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public IEnumerable<ValidationElement> ValidateAll(
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
if set to `true` [generate long description].

#### Return Value
Type: [IEnumerable][5]&lt;[ValidationElement][1]>  
 An enumeration of validation information for CAEX objects. One CAEX object may have multiple occurrences with different validation issues in this collection. 
#### Implements
[IValidator&lt;RESULTTYPE>.ValidateAll(CAEXDocument, Boolean)][6]  


See Also
--------

#### Reference
[ValidatorService Class][7]  
[Aml.Engine.Services Namespace][2]  

[1]: ../ValidationElement/README.md
[2]: ../README.md
[3]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[6]: ../../Aml.Engine.Services.Interfaces/IValidator_1/ValidateAll_1.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png