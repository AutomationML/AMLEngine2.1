ValidatorService Class
======================
This service is defined for the validation of an AML document. Additionally the service can also be used to repair specific invalid properties in a document.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.Services.ValidatorService**  

  **Namespace:**  [Aml.Engine.Services][2]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public class ValidatorService : IValidator<ValidationElement>, 
	IValidator, IAMLService
```

The **ValidatorService** type exposes the following members.


Methods
-------

                                 | Name                                                            | Description                                                                                                                                                                                                                                                                                                                                                                                                                          
-------------------------------- | --------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public method]                 | [IDValidation][3]                                               | Validates the ID of a CAEX object. IDs of CAEX objects shall be unique.                                                                                                                                                                                                                                                                                                                                                              
![Public method]                 | [NameValidation][4]                                             | Validates a name of a CAEX object. Names of CAEX classes or types (RoleClasses, InterfaceClasses, SystemUnitClasses and AttributeTypes), Attributes, Libraries and CAEX InstanceHierarchies shall be unique across its siblings or across all child elements of the same CAEX parent element over its life time. This shall assure that referencing a library, a class, a type or an attribute by its path delivers a unique result. 
![Public method]![Static member] | [Register][5]                                                   | Registers a new validator service.                                                                                                                                                                                                                                                                                                                                                                                                   
![Public method]                 | [Repair][6]                                                     | Repairs the specified validated element.                                                                                                                                                                                                                                                                                                                                                                                             
![Public method]![Static member] | [UnRegister][7]                                                 | Unregisters the validator service.                                                                                                                                                                                                                                                                                                                                                                                                   
![Public method]                 | [ValidateAliasReferences][8]                                    | Validates the alias references and returns the validation result describing possible repair options. The [ValidationElement][9] provides detailed information about available Repair Options and an additional Information Text.                                                                                                                                                                                                     
![Public method]                 | [ValidateAll(CAEXDocument, Boolean)][10]                        | Get Validation Information for all elements in the specified document, which have validation issues. The [ValidationElement][9] provides detailed information about available Repair Options and an additional Information Text.                                                                                                                                                                                                     
![Public method]                 | [ValidateAll(CAEXDocument, AutomationMLContainer, Boolean)][11] | Get Validation Information for all elements in the specified document, which have validation issues. The [IValidationResult][12] provides detailed information about available Repair Options and an additional Information Text. This method should be used, if the Document is loaded from an AutomationML container. The Validation service will check validity of external references which are packed parts of the container.   
![Public method]                 | [ValidateAllWithoutStrictID][13]                                | Get Validation Information for all elements in the specified document, which have validation issues. The [ValidationElement][9] provides detailed information about available Repair Options and an additional Information Text.                                                                                                                                                                                                     


See Also
--------

#### Reference
[Aml.Engine.Services Namespace][2]  
[Aml.Engine.Services.Interfaces.IValidator][14]  
[Aml.Engine.Services.ValidationElement][9]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: IDValidation.md
[4]: NameValidation.md
[5]: Register.md
[6]: Repair.md
[7]: UnRegister.md
[8]: ValidateAliasReferences.md
[9]: ../ValidationElement/README.md
[10]: ValidateAll_1.md
[11]: ValidateAll.md
[12]: ../../Aml.Engine.Services.Interfaces/IValidationResult/README.md
[13]: ValidateAllWithoutStrictID.md
[14]: ../../Aml.Engine.Services.Interfaces/IValidator/README.md
[15]: https://www.automationml.org
[16]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"