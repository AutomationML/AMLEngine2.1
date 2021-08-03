IValidator&lt;RESULTTYPE> Interface
===================================
AutomationML 2.1 APIThis service interface is defined for the validation of an AML document. The type parameter of this generic interface defined the validation result type.

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public interface IValidator<RESULTTYPE> : IValidator, 
	IAMLService
where RESULTTYPE : IValidationResult

```

#### Type Parameters

##### *RESULTTYPE*
The type of the validation result

The **IValidator&lt;RESULTTYPE>** type exposes the following members.


Methods
-------

                 | Name                                                           | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                            
---------------- | -------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [IDValidation][2]                                              | Validates the ID of a CAEX object. IDs of CAEX objects shall be unique. (Inherited from [IValidator][3].)                                                                                                                                                                                                                                                                                                                                                              
![Public method] | [NameValidation][4]                                            | Validates a name of a CAEX object. Names of CAEX classes or types (RoleClasses, InterfaceClasses, SystemUnitClasses and AttributeTypes), Attributes, Libraries and CAEX InstanceHierarchies shall be unique across its siblings or across all child elements of the same CAEX parent element over its life time. This shall assure that referencing a library, a class, a type or an attribute by its path delivers a unique result. (Inherited from [IValidator][3].) 
![Public method] | [Repair][5]                                                    | Repairs the specified validated element.                                                                                                                                                                                                                                                                                                                                                                                                                               
![Public method] | [ValidateAliasReferences][6]                                   | Validates the alias references and returns the validation result describing possible repair options. The [IValidationResult][7] provides detailed information about available Repair Options and an additional Information Text.                                                                                                                                                                                                                                       
![Public method] | [ValidateAll(CAEXDocument, Boolean)][8]                        | Get Validation Information for all elements in the specified document, which have validation issues. The [IValidationResult][7] provides detailed information about available Repair Options and an additional Information Text.                                                                                                                                                                                                                                       
![Public method] | [ValidateAll(CAEXDocument, AutomationMLContainer, Boolean)][9] | Get Validation Information for all elements in the specified document, which have validation issues. The [IValidationResult][7] provides detailed information about available Repair Options and an additional Information Text. This method should be used, if the Document is loaded from an AutomationML container. The Validation service will check validity of external references which are packed parts of the container.                                      


See Also
--------

#### Reference
[Aml.Engine.Services.Interfaces Namespace][1]  
[Aml.Engine.Services.Interfaces.IValidator][3]  
[Aml.Engine.Services.Interfaces.IAutoUpdate][10]  

[1]: ../README.md
[2]: ../IValidator/IDValidation.md
[3]: ../IValidator/README.md
[4]: ../IValidator/NameValidation.md
[5]: Repair.md
[6]: ValidateAliasReferences.md
[7]: ../IValidationResult/README.md
[8]: ValidateAll_1.md
[9]: ValidateAll.md
[10]: ../IAutoUpdate/README.md
[11]: https://www.automationml.org
[12]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"