# ValidationResults Class
AutomationML 2.1 API 

This class defines methods to assist the interpretation of validation results.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.Services.ValidationResults<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static class ValidationResults
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public NotInheritable Class ValidationResults
```

**C++**<br />
``` C++
[ExtensionAttribute]
public ref class ValidationResults abstract sealed
```

The ValidationResults type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ValidationResults_AliasReferenceValidationResults">AliasReferenceValidationResults</a></td><td>
Gets the Alias reference validation results from the validation result list.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ValidationResults_ClassPathValidationResults">ClassPathValidationResults</a></td><td>
Gets the CAEXPath validation results for CAEX classes from the validation result list.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ValidationResults_EmptyIDRefs">EmptyIDRefs</a></td><td>
Gets the validation results for all elements with ID references which are empty.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ValidationResults_EmptyPathRefs">EmptyPathRefs</a></td><td>
Gets the validation results for all elements with CAEX path references which are not resolvable.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ValidationResults_ExternalReferenceValidationResults">ExternalReferenceValidationResults</a></td><td>
Gets the File reference validation results from the validation result list.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ValidationResults_IDReferenceValidationResults">IDReferenceValidationResults</a></td><td>
Gets the ID reference validation results from the validation result list.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ValidationResults_IDValidationResults">IDValidationResults</a></td><td>
Gets the ID validation results from the validation result list.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ValidationResults_InvalidAutomationMLVersion">InvalidAutomationMLVersion</a></td><td>
Gets the validation results for all MetaData which are related to the AutomationML Version</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ValidationResults_InvalidIDs">InvalidIDs</a></td><td>
Gets the validation results for all elements with wrong formatted IDs.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ValidationResults_InvalidSchemaVersion">InvalidSchemaVersion</a></td><td>
Gets the validation results for all MetaData which are related to the CAEX Schema Version</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ValidationResults_MetaDataValidationResults">MetaDataValidationResults</a></td><td>
Gets the MetaData validation results from the validation result list.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ValidationResults_MissingDocumentSourceInformation">MissingDocumentSourceInformation</a></td><td>
Gets the validation results for all MetaData which are related to missing source information in an AML file.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ValidationResults_MissingIDs">MissingIDs</a></td><td>
Gets the validation results for all elements with missing IDs.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ValidationResults_NameReferenceValidationResults">NameReferenceValidationResults</a></td><td>
Gets the Name reference validation results from the validation result list.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ValidationResults_NotRepairable">NotRepairable</a></td><td>
Gets the validation results for all elements which are not repairable</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ValidationResults_NotUniqueIDs">NotUniqueIDs</a></td><td>
Gets the validation results for all elements with IDs which are not unique in the document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ValidationResults_NotUniquePath">NotUniquePath</a></td><td>
Gets the validation results for all elements which are not uniquely identifiable with a CAEX path</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ValidationResults_PathReferenceValidationResults">PathReferenceValidationResults</a></td><td>
Gets the Path reference validation results from the validation result list.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ValidationResults_Repairable">Repairable</a></td><td>
Gets the validation results for all elements which are repairable</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ValidationResults_UnidentifiedAlias">UnidentifiedAlias</a></td><td>
Gets the validation results for all elements with references to an Alias, but no ExternalReference with that Alias is defined.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ValidationResults_UnresolvedIDRefs">UnresolvedIDRefs</a></td><td>
Gets the validation results for all elements with ID references which are not resolvable.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ValidationResults_UnresolvedPathRefs">UnresolvedPathRefs</a></td><td>
Gets the validation results for all elements with CAEX path references which are not resolvable.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ValidationResults_UselessAlias">UselessAlias</a></td><td>
Gets the validation results for all elements with references to an Alias, where the ExternalReference has been merged into the document already.</td></tr></table>&nbsp;
<a href="#validationresults-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />