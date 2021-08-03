ValidationTypeEnum Enumeration
==============================
Enumeration ValidationTypeEnum

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public enum ValidationTypeEnum
```


Members
-------

Member name                                     | Value | Description                                                                                                                                                         
----------------------------------------------- | ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
**IDValidation**                                | 0     | The identifier validation indicates ID related issues. like a double or missing ID or a wrong formatted ID. The issues are repairable, if the ID is not referenced. 
**ClassPathValidation**                         | 1     | The class path validation indicates a double ClassPath or missing Path                                                                                              
**AttributePathValidation**                     | 2     | The attribute path validation indicates a double AttributePath or missing Path                                                                                      
**PathReferenceValidation**                     | 3     | The path reference validation indicates a missing or unresolved reference to a class                                                                                
**NameValidation**                              | 4     | The name validation indicates a missing or not allowed name                                                                                                         
**IDReferenceValidation**                       | 5     | The ID reference validation indicates a missing or unresolved reference to an object with an ID                                                                     
**AliasValidation**                             | 6     | The alias validation                                                                                                                                                
**MergableAliasReferenceValidation**            | 7     | The validation result has constituted an alias in an external reference which is not merged                                                                         
**MissingAliasReferenceValidation**             | 8     | The validation result has constituted a missing alias in an external reference                                                                                      
**FileReferenceValidation**                     | 9     | The file reference validation indicates a wrong FilePath in an external reference, which couldn't be resolved to an existing file                                   
**RoleAttributeReferenceValidation**            | 10    | The role attribute reference validation indicates a wrong reference to a role Attribute in a Mapping                                                                
**RoleInterfaceReferenceValidation**            | 11    | The role Interface reference validation indicates a wrong reference to a role Interface in a Mapping                                                                
**SystemUnitClassAttributeReferenceValidation** | 12    | The SystemUnitClass attribute reference validation indicates a wrong reference to a SystemUnitClass Attribute in a Mapping                                          
**SystemUnitClassInterfaceReferenceValidation** | 13    | The SystemUnitClass Interface reference validation indicates a wrong reference to a SystemUnitClass Interface in a Mapping                                          
**CyclicDependency**                            | 14    | This Flag indicates a cyclic dependency between classes                                                                                                             
**AutomationMLMetaDataValidation**              | 15    | The automationML meta data validation indicates a couple of validation issues with metaData, as a missing schema name or writerHeader                               


See Also
--------

#### Reference
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: https://www.automationml.org
[3]: ../../icons/logoShade.png