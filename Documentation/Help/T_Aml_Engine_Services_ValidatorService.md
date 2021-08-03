# ValidatorService Class
AutomationML 2.1 API 

This service is defined for the validation of an AML document. Additionally the service can also be used to repair specific invalid properties in a document.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.Services.ValidatorService<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class ValidatorService : IValidator<ValidationElement>, 
	IValidator, IAMLService
```

**VB**<br />
``` VB
Public Class ValidatorService
	Implements IValidator(Of ValidationElement), IValidator, 
	IAMLService
```

**C++**<br />
``` C++
public ref class ValidatorService : IValidator<ValidationElement^>, 
	IValidator, IAMLService
```

The ValidatorService type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_ValidatorService_IDValidation">IDValidation</a></td><td>
Validates the ID of a CAEX object. IDs of CAEX objects shall be unique.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_ValidatorService_NameValidation">NameValidation</a></td><td>
Validates a name of a CAEX object. Names of CAEX classes or types (RoleClasses, InterfaceClasses, SystemUnitClasses and AttributeTypes), Attributes, Libraries and CAEX InstanceHierarchies shall be unique across its siblings or across all child elements of the same CAEX parent element over its life time. This shall assure that referencing a library, a class, a type or an attribute by its path delivers a unique result.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ValidatorService_Register">Register</a></td><td>
Registers a new validator service.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_ValidatorService_Repair">Repair</a></td><td>
Repairs the specified validated element.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ValidatorService_UnRegister">UnRegister</a></td><td>
Unregisters the validator service.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_ValidatorService_ValidateAliasReferences">ValidateAliasReferences</a></td><td>
Validates the alias references and returns the validation result describing possible repair options. The <a href="T_Aml_Engine_Services_ValidationElement">ValidationElement</a> provides detailed information about available Repair Options and an additional Information Text.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_ValidatorService_ValidateAll_1">ValidateAll(CAEXDocument, Boolean)</a></td><td>
Get Validation Information for all elements in the specified document, which have validation issues. The <a href="T_Aml_Engine_Services_ValidationElement">ValidationElement</a> provides detailed information about available Repair Options and an additional Information Text.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_ValidatorService_ValidateAll">ValidateAll(CAEXDocument, AutomationMLContainer, Boolean)</a></td><td>
Get Validation Information for all elements in the specified document, which have validation issues. The <a href="T_Aml_Engine_Services_Interfaces_IValidationResult">IValidationResult</a> provides detailed information about available Repair Options and an additional Information Text. This method should be used, if the Document is loaded from an AutomationML container. The Validation service will check validity of external references which are packed parts of the container.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_ValidatorService_ValidateAllWithoutStrictID">ValidateAllWithoutStrictID</a></td><td>
Get Validation Information for all elements in the specified document, which have validation issues. The <a href="T_Aml_Engine_Services_ValidationElement">ValidationElement</a> provides detailed information about available Repair Options and an additional Information Text.</td></tr></table>&nbsp;
<a href="#validatorservice-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br /><a href="T_Aml_Engine_Services_Interfaces_IValidator">Aml.Engine.Services.Interfaces.IValidator</a><br /><a href="T_Aml_Engine_Services_ValidationElement">Aml.Engine.Services.ValidationElement</a><br />