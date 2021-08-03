ValidatorService.Repair Method
==============================
AutomationML 2.1 APIRepairs the specified validated element.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public bool Repair(
	ValidationElement validation
)
```

#### Parameters

##### *validation*
Type: [Aml.Engine.Services.ValidationElement][2]  
The validated element.

#### Return Value
Type: [Boolean][3]  
`true` if the element has been repaired, `false` otherwise. 
#### Implements
[IValidator&lt;RESULTTYPE>.Repair(RESULTTYPE)][4]  


See Also
--------

#### Reference
[ValidatorService Class][5]  
[Aml.Engine.Services Namespace][1]  
[ValidatorService.ValidateAll(CAEXDocument, Boolean)][6]  

[1]: ../README.md
[2]: ../ValidationElement/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: ../../Aml.Engine.Services.Interfaces/IValidator_1/Repair.md
[5]: README.md
[6]: ValidateAll_1.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png