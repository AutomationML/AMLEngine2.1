ValidatorService.IDValidation Method
====================================
AutomationML 2.1 APIValidates the ID of a CAEX object. IDs of CAEX objects shall be unique.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public (bool IsValid, string Message) IDValidation(
	CAEXObject caexObject,
	string ID
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXObject][2]  
The CAEX object.

##### *ID*
Type: [System.String][3]  
 The ID, which should be assigned to the object. If no ID is defined, the uniqueness of the already assigned ID is evaluated.

#### Return Value
Type: [ValueTuple][4]&lt;[Boolean][5], [String][3]>  
A value tuple, returning the validation result and a message
#### Implements
[IValidator.IDValidation(CAEXObject, String)][6]  


See Also
--------

#### Reference
[ValidatorService Class][7]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXObject/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.valuetuple-2
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: ../../Aml.Engine.Services.Interfaces/IValidator/IDValidation.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png