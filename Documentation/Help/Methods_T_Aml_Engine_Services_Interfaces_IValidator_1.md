# IValidator(*RESULTTYPE*) Methods
AutomationML 2.1 API 

The <a href="T_Aml_Engine_Services_Interfaces_IValidator_1">IValidator(RESULTTYPE)</a> generic type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IValidator_IDValidation">IDValidation</a></td><td>
Validates the ID of a CAEX object. IDs of CAEX objects shall be unique.
 (Inherited from <a href="T_Aml_Engine_Services_Interfaces_IValidator">IValidator</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IValidator_NameValidation">NameValidation</a></td><td>
Validates a name of a CAEX object. Names of CAEX classes or types (RoleClasses, InterfaceClasses, SystemUnitClasses and AttributeTypes), Attributes, Libraries and CAEX InstanceHierarchies shall be unique across its siblings or across all child elements of the same CAEX parent element over its life time. This shall assure that referencing a library, a class, a type or an attribute by its path delivers a unique result.
 (Inherited from <a href="T_Aml_Engine_Services_Interfaces_IValidator">IValidator</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IValidator_1_Repair">Repair</a></td><td>
Repairs the specified validated element.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IValidator_1_ValidateAliasReferences">ValidateAliasReferences</a></td><td>
Validates the alias references and returns the validation result describing possible repair options. The <a href="T_Aml_Engine_Services_Interfaces_IValidationResult">IValidationResult</a> provides detailed information about available Repair Options and an additional Information Text.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IValidator_1_ValidateAll_1">ValidateAll(CAEXDocument, Boolean)</a></td><td>
Get Validation Information for all elements in the specified document, which have validation issues. The <a href="T_Aml_Engine_Services_Interfaces_IValidationResult">IValidationResult</a> provides detailed information about available Repair Options and an additional Information Text.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IValidator_1_ValidateAll">ValidateAll(CAEXDocument, AutomationMLContainer, Boolean)</a></td><td>
Get Validation Information for all elements in the specified document, which have validation issues. The <a href="T_Aml_Engine_Services_Interfaces_IValidationResult">IValidationResult</a> provides detailed information about available Repair Options and an additional Information Text. This method should be used, if the Document is loaded from an AutomationML container. The Validation service will check validity of external references which are packed parts of the container.</td></tr></table>&nbsp;
<a href="#ivalidator(*resulttype*)-methods">Back to Top</a>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IValidator_1">IValidator(RESULTTYPE) Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />