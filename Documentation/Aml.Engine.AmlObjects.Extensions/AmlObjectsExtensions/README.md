AmlObjectsExtensions Class
==========================
This class provides extensions methods for the identification of properties of AML objects, using CAEX objects.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.AmlObjects.Extensions.AmlObjectsExtensions**  

  **Namespace:**  [Aml.Engine.AmlObjects.Extensions][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static class AmlObjectsExtensions
```

The **AmlObjectsExtensions** type exposes the following members.


Methods
-------

                                 | Name                                                                                                           | Description                                                                                                                                                                                                                                                                                                                                     
-------------------------------- | -------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]![Static member] | [AMLAttributes][3]                                                                                             | Conversion of any object which has an attribute collection to get access to specific AutomationML defined attributes.                                                                                                                                                                                                                           
![Public method]![Static member] | [AMLFacet][4]                                                                                                  | Converts an InternalElementType to an AMLFacet.                                                                                                                                                                                                                                                                                                 
![Public method]![Static member] | [AMLFile][5]                                                                                                   | Converts a CAEX file to an AML file.                                                                                                                                                                                                                                                                                                            
![Public method]![Static member] | [AMLGroup][6]                                                                                                  | Converts an InternalElementType to an AMLGroup.                                                                                                                                                                                                                                                                                                 
![Public method]![Static member] | [AMLPort][7]                                                                                                   | Converts an InternalElementType to an AMLPort.                                                                                                                                                                                                                                                                                                  
![Public method]![Static member] | [AMLSystemUnitClass][8]                                                                                        | Converts an SystemUnitClassType to an AMLSystemUnitClass.                                                                                                                                                                                                                                                                                       
![Public method]![Static member] | [AutomationMLVersion][9]                                                                                       | Gets the AutomationML version for this CAEXFile object.                                                                                                                                                                                                                                                                                         
![Public method]![Static member] | [ClearMetaInformation][10]                                                                                     | Removes all "Writer Header" specific meta information out of this CAEX file.                                                                                                                                                                                                                                                                    
![Public method]![Static member] | [DeleteMetaInformation][11]                                                                                    | This function deletes any existing meta information corresponding to the writerID.                                                                                                                                                                                                                                                              
![Public method]![Static member] | [FrameAttribute][12]                                                                                           | Gets a defined FrameAttribute from the [Attribute][13] collection of the [IObjectWithAttributes][14]. If no such attribute exists, `null` is returned.                                                                                                                                                                                          
![Public method]![Static member] | [GetMetaInformation(CAEXFileType)][15]                                                                         | This methods returns an Enumeration of all "WriterHeader" meta information out of an existing AutomationML file.                                                                                                                                                                                                                                
![Public method]![Static member] | [GetMetaInformation(CAEXFileType, String)][16]                                                                 | This function returns the MetaInformation corresponding to the writerID, otherwise null.                                                                                                                                                                                                                                                        
![Public method]![Static member] | [IsAMLFacet][17]                                                                                               | Determines whether the InternalElement instance is an AMLFacet.                                                                                                                                                                                                                                                                                 
![Public method]![Static member] | [IsAMLGroup][18]                                                                                               | Determines whether the InternalElement instance is an AMLGroup.                                                                                                                                                                                                                                                                                 
![Public method]![Static member] | [IsAMLObject][19]                                                                                              | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. 
![Public method]![Static member] | [IsAMLPort][20]                                                                                                | Determines whether the InternalElement instance is an AMLPort.                                                                                                                                                                                                                                                                                  
![Public method]![Static member] | [IsFacetAttribute][21]                                                                                         | Determines, if the attribute is an attribute of an AMLFacet.                                                                                                                                                                                                                                                                                    
![Public method]![Static member] | [IsFacetInterface][22]                                                                                         | Determines, if the ExternalInterface object is an ExternalInterface of an AMLFacet.                                                                                                                                                                                                                                                             
![Public method]![Static member] | [IsRefTypeAttribute][23]                                                                                       | Gets a value indicating whether this instance is a RefType attribute.                                                                                                                                                                                                                                                                           
![Public method]![Static member] | [IsRefURIAttribute][24]                                                                                        | Gets a value indicating whether this instance is a RefURI attribute.                                                                                                                                                                                                                                                                            
![Public method]![Static member] | [New_FrameAttribute][25]                                                                                       | Creates a new Frame attribute for the [IObjectWithAttributes][14] if no Frame attribute exists. The provided values are used to initialize the Frame attribute values.                                                                                                                                                                          
![Public method]![Static member] | [RefTypeAttribute][26]                                                                                         | Gets the RefTypeAttribute from the *objectWithAttributes* if one exists.                                                                                                                                                                                                                                                                        
![Public method]![Static member] | [RefURIAttribute][27]                                                                                          | Gets the RefURIAttribute from the *objectWithAttributes* if one exists.                                                                                                                                                                                                                                                                         
![Public method]![Static member] | [ReplaceMetaInformation][28]                                                                                   | This function replaces any existing meta information corresponding to the identical oldWriterID with the new meta information defined in the newMetainformation                                                                                                                                                                                 
![Public method]![Static member] | [SetMetaInformation(CAEXFileType, MetaInformation)][29]                                                        | This method is a short version of the setMetaInformation. Meta data with identical WriterID is replaced.                                                                                                                                                                                                                                        
![Public method]![Static member] | [SetMetaInformation(SourceDocumentInformationType, MetaInformation)][30]                                       | Sets the properties for the specified SourceDocumentInformation object using the provided MetaInformation                                                                                                                                                                                                                                       
![Public method]![Static member] | [SetMetaInformation(CAEXFileType, String, String, String, String, String, String, String, String, String)][31] | This function sets the meta information required from AutomationML standard. If meta information about the same writerID already exists, this meta information is replaced. These information comprise source information about the AutomationML file.                                                                                          
![Public method]![Static member] | [SetMetaInformationStandardAutomationMLLibrary][32]                                                            | This method labels this CAEX file as a standard AutomationML library coming from the AutomationML e.V. It removes all other meta information and should only be used from authorized persons in agreement with the AutomationML e.V.                                                                                                            
![Public method]![Static member] | [SetSourceDocumentInformation][33]                                                                             | This function sets the meta information required from AutomationML standard. If meta information about the same writerID already exists, this meta information is replaced. These information comprise source information about the AutomationML file.                                                                                          
![Public method]![Static member] | [ToRefTypeAttribute][34]                                                                                       | Converts an AttributeType to a RefTypeAttribute.                                                                                                                                                                                                                                                                                                
![Public method]![Static member] | [ToRefURIAttribute][35]                                                                                        | Converts an AttributeType to a RefUriAttribute.                                                                                                                                                                                                                                                                                                 


See Also
--------

#### Reference
[Aml.Engine.AmlObjects.Extensions Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: AMLAttributes.md
[4]: AMLFacet.md
[5]: AMLFile.md
[6]: AMLGroup.md
[7]: AMLPort.md
[8]: AMLSystemUnitClass.md
[9]: AutomationMLVersion.md
[10]: ClearMetaInformation.md
[11]: DeleteMetaInformation.md
[12]: FrameAttribute.md
[13]: ../../Aml.Engine.CAEX/IObjectWithAttributes/Attribute.md
[14]: ../../Aml.Engine.CAEX/IObjectWithAttributes/README.md
[15]: GetMetaInformation.md
[16]: GetMetaInformation_1.md
[17]: IsAMLFacet.md
[18]: IsAMLGroup.md
[19]: IsAMLObject.md
[20]: IsAMLPort.md
[21]: IsFacetAttribute.md
[22]: IsFacetInterface.md
[23]: IsRefTypeAttribute.md
[24]: IsRefURIAttribute.md
[25]: New_FrameAttribute.md
[26]: RefTypeAttribute.md
[27]: RefURIAttribute.md
[28]: ReplaceMetaInformation.md
[29]: SetMetaInformation.md
[30]: SetMetaInformation_2.md
[31]: SetMetaInformation_1.md
[32]: SetMetaInformationStandardAutomationMLLibrary.md
[33]: SetSourceDocumentInformation.md
[34]: ToRefTypeAttribute.md
[35]: ToRefURIAttribute.md
[36]: https://www.automationml.org
[37]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"