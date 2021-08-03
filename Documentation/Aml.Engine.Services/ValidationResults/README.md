ValidationResults Class
=======================
AutomationML 2.1 APIThis class defines methods to assist the interpretation of validation results.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.Services.ValidationResults**  

  **Namespace:**  [Aml.Engine.Services][2]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public static class ValidationResults
```

The **ValidationResults** type exposes the following members.


Methods
-------

                                 | Name                                    | Description                                                                                                                                      
-------------------------------- | --------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public method]![Static member] | [AliasReferenceValidationResults][3]    | Gets the Alias reference validation results from the validation result list.                                                                     
![Public method]![Static member] | [ClassPathValidationResults][4]         | Gets the CAEXPath validation results for CAEX classes from the validation result list.                                                           
![Public method]![Static member] | [EmptyIDRefs][5]                        | Gets the validation results for all elements with ID references which are empty.                                                                 
![Public method]![Static member] | [EmptyPathRefs][6]                      | Gets the validation results for all elements with CAEX path references which are not resolvable.                                                 
![Public method]![Static member] | [ExternalReferenceValidationResults][7] | Gets the File reference validation results from the validation result list.                                                                      
![Public method]![Static member] | [IDReferenceValidationResults][8]       | Gets the ID reference validation results from the validation result list.                                                                        
![Public method]![Static member] | [IDValidationResults][9]                | Gets the ID validation results from the validation result list.                                                                                  
![Public method]![Static member] | [InvalidAutomationMLVersion][10]        | Gets the validation results for all MetaData which are related to the AutomationML Version                                                       
![Public method]![Static member] | [InvalidIDs][11]                        | Gets the validation results for all elements with wrong formatted IDs.                                                                           
![Public method]![Static member] | [InvalidSchemaVersion][12]              | Gets the validation results for all MetaData which are related to the CAEX Schema Version                                                        
![Public method]![Static member] | [MetaDataValidationResults][13]         | Gets the MetaData validation results from the validation result list.                                                                            
![Public method]![Static member] | [MissingDocumentSourceInformation][14]  | Gets the validation results for all MetaData which are related to missing source information in an AML file.                                     
![Public method]![Static member] | [MissingIDs][15]                        | Gets the validation results for all elements with missing IDs.                                                                                   
![Public method]![Static member] | [NameReferenceValidationResults][16]    | Gets the Name reference validation results from the validation result list.                                                                      
![Public method]![Static member] | [NotRepairable][17]                     | Gets the validation results for all elements which are not repairable                                                                            
![Public method]![Static member] | [NotUniqueIDs][18]                      | Gets the validation results for all elements with IDs which are not unique in the document.                                                      
![Public method]![Static member] | [NotUniquePath][19]                     | Gets the validation results for all elements which are not uniquely identifiable with a CAEX path                                                
![Public method]![Static member] | [PathReferenceValidationResults][20]    | Gets the Path reference validation results from the validation result list.                                                                      
![Public method]![Static member] | [Repairable][21]                        | Gets the validation results for all elements which are repairable                                                                                
![Public method]![Static member] | [UnidentifiedAlias][22]                 | Gets the validation results for all elements with references to an Alias, but no ExternalReference with that Alias is defined.                   
![Public method]![Static member] | [UnresolvedIDRefs][23]                  | Gets the validation results for all elements with ID references which are not resolvable.                                                        
![Public method]![Static member] | [UnresolvedPathRefs][24]                | Gets the validation results for all elements with CAEX path references which are not resolvable.                                                 
![Public method]![Static member] | [UselessAlias][25]                      | Gets the validation results for all elements with references to an Alias, where the ExternalReference has been merged into the document already. 


See Also
--------

#### Reference
[Aml.Engine.Services Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: AliasReferenceValidationResults.md
[4]: ClassPathValidationResults.md
[5]: EmptyIDRefs.md
[6]: EmptyPathRefs.md
[7]: ExternalReferenceValidationResults.md
[8]: IDReferenceValidationResults.md
[9]: IDValidationResults.md
[10]: InvalidAutomationMLVersion.md
[11]: InvalidIDs.md
[12]: InvalidSchemaVersion.md
[13]: MetaDataValidationResults.md
[14]: MissingDocumentSourceInformation.md
[15]: MissingIDs.md
[16]: NameReferenceValidationResults.md
[17]: NotRepairable.md
[18]: NotUniqueIDs.md
[19]: NotUniquePath.md
[20]: PathReferenceValidationResults.md
[21]: Repairable.md
[22]: UnidentifiedAlias.md
[23]: UnresolvedIDRefs.md
[24]: UnresolvedPathRefs.md
[25]: UselessAlias.md
[26]: https://www.automationml.org
[27]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"