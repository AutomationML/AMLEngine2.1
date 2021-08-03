ValidatorService.ValidateAllWithoutStrictID Method
==================================================
AutomationML 2.1 APIGet Validation Information for all elements in the specified document, which have validation issues. The [ValidationElement][1] provides detailed information about available Repair Options and an additional Information Text.

  **Namespace:**  [Aml.Engine.Services][2]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public IEnumerable<ValidationElement> ValidateAllWithoutStrictID(
	CAEXDocument document,
	AutomationMLContainer container = null,
	bool generateLongDescription = false
)
```

#### Parameters

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][3]  
The CAEX document.

##### *container* (Optional)
Type: [Aml.Engine.AmlObjects.AutomationMLContainer][4]  
 If set, the associated parts, defined in the AutomationML container are used to validate external references.

##### *generateLongDescription* (Optional)
Type: [System.Boolean][5]  
if set to `true` [generate long description].

#### Return Value
Type: [IEnumerable][6]&lt;[ValidationElement][1]>  
 An enumeration of validation information for CAEX objects. One CAEX object may have multiple occurrences with different validation issues in this collection. 

See Also
--------

#### Reference
[ValidatorService Class][7]  
[Aml.Engine.Services Namespace][2]  

[1]: ../ValidationElement/README.md
[2]: ../README.md
[3]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[4]: ../../Aml.Engine.AmlObjects/AutomationMLContainer/README.md
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png