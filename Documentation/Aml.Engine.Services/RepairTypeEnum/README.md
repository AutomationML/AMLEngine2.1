RepairTypeEnum Enumeration
==========================
Enumeration RepairTypeEnum

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
[FlagsAttribute]
public enum RepairTypeEnum
```


Members
-------

Member name                         | Value   | Description                                                                                                                                                                                 
----------------------------------- | ------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
**IDDefinitionOption**              | 8197    | The options which are related to ID validation issues                                                                                                                                       
**NameDefinitionOption**            | 136     | The options which are related to Name validation issues                                                                                                                                     
**IDReferenceOption**               | 32      | The options which are related to ID reference validation issues                                                                                                                             
**PathReferenceOption**             | 64      | The options which are related to Path reference validation issues                                                                                                                           
**GenerateUniqueIDWhenEmpty**       | 1       | This Flag cause the generation of a unique ID for all Empty IDs                                                                                                                             
**GenerateUniqueIDForDoubles**      | 4       | This Flag cause the generation of a unique ID for all Double IDs                                                                                                                            
**GenerateNameWhenEmpty**           | 8       | This Flag cause the renaming of all empty Names with an automatic name generation algorithm. To apply this method, a [UniqueNameService][2] has to be registered,                           
**RemoveEmptyReference**            | 16      | This Flag cause the removal of all references where the Reference Value is empty                                                                                                            
**RemoveUnresolvedIDReference**     | 32      | This Flag cause the removal of all ID References where the ID Value has not been resolved                                                                                                   
**RemoveUnresolvedPathReference**   | 64      | This Flag cause the removal of all Path References where the Path reference Value has not been resolved                                                                                     
**RenameClassPathForDoubles**       | 128     | This Flag cause the generation of a new name for an element, when it's CAEX-Path is double so that the Path is unique. To apply this method, a [UniqueNameService][2] has to be registered. 
**CreateWriterHeader**              | 256     | This Flag cause the generation of a writer header                                                                                                                                           
**CreateAutomationMLVersion**       | 512     | This Flag cause the generation of an AutomationML Version header                                                                                                                            
**SetSchemaVersion**                | 2048    | This Flag cause the correction of the Schema Version                                                                                                                                        
**GenerateValidGUID**               | 8192    | This Flag cause the generation of a new GUID for existing GUID's with invalid formats                                                                                                       
**RemoveAlias**                     | 32768   | This Flag cause the generation of a new reference without the alias                                                                                                                         
**CreateSourceDocumentInformation** | 131072  | This Flag cause the generation of source document information                                                                                                                               
**RemoveElement**                   | 262144  | This Flag cause the deletion of an element                                                                                                                                                  
**RemoveElementNotInScope**         | 524288  | This Flag cause the deletion of an element which reference an element out of the allowed scope.                                                                                             
**ChangeFileURL**                   | 1048576 | This Flag cause the generation of a valid file URL in an ExternalDataConnector to a localized file.                                                                                         
**RemoveUnresolvedNameReference**   | 2097152 | This Flag cause the removal of all Name References where the Name reference Value has not been resolved                                                                                     
**None**                            | 0       | The Option None indicates, that nothing should be done                                                                                                                                      


See Also
--------

#### Reference
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../UniqueNameService/README.md
[3]: https://www.automationml.org
[4]: ../../icons/logoShade.png