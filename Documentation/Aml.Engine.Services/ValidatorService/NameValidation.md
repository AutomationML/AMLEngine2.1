ValidatorService.NameValidation Method
======================================
Validates a name of a CAEX object. Names of CAEX classes or types (RoleClasses, InterfaceClasses, SystemUnitClasses and AttributeTypes), Attributes, Libraries and CAEX InstanceHierarchies shall be unique across its siblings or across all child elements of the same CAEX parent element over its life time. This shall assure that referencing a library, a class, a type or an attribute by its path delivers a unique result.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public (bool IsValid, string Message) NameValidation(
	CAEXObject caexObject,
	string name
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXObject][2]  
The CAEX object.

##### *name*
Type: [System.String][3]  
The name, which should be assigned to the object.

#### Return Value
Type: [ValueTuple][4]&lt;[Boolean][5], [String][3]>  
A value tuple, returning the validation result and a message
#### Implements
[IValidator.NameValidation(CAEXObject, String)][6]  


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
[6]: ../../Aml.Engine.Services.Interfaces/IValidator/NameValidation.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png