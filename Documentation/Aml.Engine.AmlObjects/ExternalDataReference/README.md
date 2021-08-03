ExternalDataReference Class
===========================
This class provides methods to create and retrieve external data references as it is defined in the BPR document "ExternalDataReference" Version 1.0.0 from July 2016.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.AmlObjects.ExternalDataReference**  

  **Namespace:**  [Aml.Engine.AmlObjects][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static class ExternalDataReference
```

The **ExternalDataReference** type exposes the following members.


Methods
-------

                                 | Name                                                             | Description                                                                                                                                                                                                                                                                                                                                                                                                                                          
-------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]![Static member] | [AddAutomationMLBPRInterfaceClassLib][3]                         | Adds the AutomationMLBPRInterfaceClassLib containing all interface classes used to model external document references to the AMLDocument.                                                                                                                                                                                                                                                                                                            
![Public method]![Static member] | [AddAutomationMLBPRRoleClassLib][4]                              | Adds the AutomationMLBPRRoleClassLib containing all role classes used to model external document references to the AMLDocument.                                                                                                                                                                                                                                                                                                                      
![Public method]![Static member] | [AddDocumentElement][5]                                          | Adds a document element to the defined internalElement. A Document Element is semantically described with an attached role defined with the base role class [ExternalDataRoleClassPath][6] or a derived role class. If no role class path is given as a parameter the default is used. If the specified role class path can not be identified as a derived role from the [ExternalDataRoleClassPath][6] no document element is added (returns null). 
![Public method]![Static member] | [AddDocumentElementRole][7]                                      | Add a role reference to a external data role class or derived role class defined with the given role class path as a supported role class to the internal element. If the specified role class path can not be identified as a derived role from the [ExternalDataRoleClassPath][6] no role reference is added (returns false).                                                                                                                      
![Public method]![Static member] | [AddDocumentReference][8]                                        | Adds a document with the specified external reference interface to the document element. If the given internal element is not a document element or the defined class path to the external reference interface is not derived from the standard base class no interface is added.                                                                                                                                                                    
![Public method]![Static member] | [AddExternalDataReferenceLibraries][9]                           | Adds the external data reference libraries used to model external document references. It is checked, if the needed role- and interface libraries are contained in the AMLDocument. If this libs are missing, they are imported from an embedded resource stream. The current Version of the embedded libs is version 1.0.0.                                                                                                                         
![Public method]![Static member] | [AddLanguage][10]                                                | Adds a language attribute to the internal element. If this is the first language attribute, a simple attribute is added. If this is not the first, a language attribute list is used. A former created simple attribute is transferred to a list item.                                                                                                                                                                                               
![Public method]![Static member] | [AutomationMLBPRInterfaceClassLib][11]                           | Gets the AutomationMLBPRInterfaceClassLib containing all interface classes used to model external document references to the AMLDocument.                                                                                                                                                                                                                                                                                                            
![Public method]![Static member] | [AutomationMLBPRRoleClassLib][12]                                | Gets the AutomationMLBPRRoleClassLib containing all role classes used to model external document references to the AMLDocument.                                                                                                                                                                                                                                                                                                                      
![Public method]![Static member] | [DocumentElements][13]                                           | Gets all Internal Element Children from the specified internal element which are document elements.                                                                                                                                                                                                                                                                                                                                                  
![Public method]![Static member] | [ExternalDataReferenceInterfaceClass(CAEXFileType)][14]          | Gets the 'ExternalDataReference' InterfaceClass from the AML document.                                                                                                                                                                                                                                                                                                                                                                               
![Public method]![Static member] | [ExternalDataReferenceInterfaceClass(InterfaceClassLibType)][15] | Gets the ExternalDataReference InterfaceClass from the AutomationMLBPRInterfaceClassLib.                                                                                                                                                                                                                                                                                                                                                             
![Public method]![Static member] | [ExternalDataRoleClass(CAEXFileType)][16]                        | Gets the ExternalData RoleClass from the AML document.                                                                                                                                                                                                                                                                                                                                                                                               
![Public method]![Static member] | [ExternalDataRoleClass(RoleClassLibType)][17]                    | Gets the 'ExternalData' RoleClass from the AutomationMLBPRRoleClassLib.                                                                                                                                                                                                                                                                                                                                                                              
![Public method]![Static member] | [GetLanguages][18]                                               | Gets the languages, defined for the document element. If the given internal element is not a document element, the collection is empty.                                                                                                                                                                                                                                                                                                              
![Public method]![Static member] | [IsDocumentElement][19]                                          | Determines whether the specified internal element is a document element.                                                                                                                                                                                                                                                                                                                                                                             


Fields
------

                                | Name                                          | Description                                                                     
------------------------------- | --------------------------------------------- | ------------------------------------------------------------------------------- 
![Public field]![Static member] | [AutomationMLBPRInterfaceClassLibName][20]    | The name of the library containing interface classes specified in BPR documents 
![Public field]![Static member] | [AutomationMLBPRRoleClassLibName][21]         | The name of the library containing role classes specified in BPR documents      
![Public field]![Static member] | [ExternalDataReferenceInterfaceClassName][22] | The name for the ExternalDataReference interface class                          
![Public field]![Static member] | [ExternalDataReferenceInterfaceClassPath][23] | The class path for the ExternalDataReference interface class                    
![Public field]![Static member] | [ExternalDataRoleClassName][24]               | The name for the ExternalData role class                                        
![Public field]![Static member] | [ExternalDataRoleClassPath][6]                | The class path for the ExternalData role class                                  
![Public field]![Static member] | [LanguageAttributeName][25]                   | The language attribute name                                                     


See Also
--------

#### Reference
[Aml.Engine.AmlObjects Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: AddAutomationMLBPRInterfaceClassLib.md
[4]: AddAutomationMLBPRRoleClassLib.md
[5]: AddDocumentElement.md
[6]: ExternalDataRoleClassPath.md
[7]: AddDocumentElementRole.md
[8]: AddDocumentReference.md
[9]: AddExternalDataReferenceLibraries.md
[10]: AddLanguage.md
[11]: AutomationMLBPRInterfaceClassLib.md
[12]: AutomationMLBPRRoleClassLib.md
[13]: DocumentElements.md
[14]: ExternalDataReferenceInterfaceClass.md
[15]: ExternalDataReferenceInterfaceClass_1.md
[16]: ExternalDataRoleClass.md
[17]: ExternalDataRoleClass_1.md
[18]: GetLanguages.md
[19]: IsDocumentElement.md
[20]: AutomationMLBPRInterfaceClassLibName.md
[21]: AutomationMLBPRRoleClassLibName.md
[22]: ExternalDataReferenceInterfaceClassName.md
[23]: ExternalDataReferenceInterfaceClassPath.md
[24]: ExternalDataRoleClassName.md
[25]: LanguageAttributeName.md
[26]: https://www.automationml.org
[27]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"
[Public field]: ../../icons/pubfield.gif "Public field"