AutomationMLContainer Class
===========================
Class AutomationMLContainer provides methods to save an AutomationML document and related documents which are needed for the interpretation or representation of AutomationML data into a single packed and zipped file. The various parts are assembled into this AutomationMLContainer. The Class provides methods to retrieve parts from a loaded container or for the assembly of parts into one single container. A Utility, to build a self containing container from a loaded CAEXDocument and the external referenced files, retrieved from the external references and ExternalInterface classes is defined in a special service.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.AmlObjects.AutomationMLContainer**  

  **Namespace:**  [Aml.Engine.AmlObjects][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class AutomationMLContainer : IDisposable
```

The **AutomationMLContainer** type exposes the following members.


Constructors
------------

                 | Name                                                                | Description                                                                                                                       
---------------- | ------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [AutomationMLContainer(Stream)][3]                                  | Initializes a new instance of the **AutomationMLContainer** class using the specified stream resource.                            
![Public method] | [AutomationMLContainer(String)][4]                                  | Initializes a new instance of the **AutomationMLContainer** class using the specified container file to load or save the package. 
![Public method] | [AutomationMLContainer(Stream, FileMode)][5]                        | Initializes a new instance of the **AutomationMLContainer** class using the specified stream resource.                            
![Public method] | [AutomationMLContainer(String, FileMode)][6]                        | Initializes a new instance of the **AutomationMLContainer** class using the specified container file to load or save the package. 
![Public method] | [AutomationMLContainer(Stream, FileMode, FileAccess)][7]            | Initializes a new instance of the **AutomationMLContainer** class using the specified stream resource.                            
![Public method] | [AutomationMLContainer(String, FileMode, FileAccess)][8]            | Initializes a new instance of the **AutomationMLContainer** class using the specified container file to load or save the package. 
![Public method] | [AutomationMLContainer(String, FileMode, FileAccess, FileShare)][9] | Initializes a new instance of the **AutomationMLContainer** class using the specified container file to load or save the package. 


Properties
----------

                   | Name                      | Description                                                         
------------------ | ------------------------- | ------------------------------------------------------------------- 
![Public property] | [CompressionMode][10]     | Gets or sets the compression mode which is [Normal][11] by default. 
![Public property] | [ContainerFilename][12]   | Gets the full path of the used container file.                      
![Public property] | [ExtractionDirectory][13] | Gets the full path of the directory, used for extraction.           
![Public property] | [Package][14]             | Gets the underlying package of this instance.                       


Methods
-------

                 | Name                                                                       | Description                                                                                                                                                                                                                                
---------------- | -------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public method] | [AddAnyContent(PackagePart, Stream, Uri, String, Boolean)][15]             | Adds any content from the specified stream resource to the package creating relationships to the package and to the part, containing the root document using the relationship type [AnyContent][16].                                       
![Public method] | [AddAnyContent(PackagePart, String, Uri, String, Boolean)][17]             | Adds any content to the package creating relationships to the package and to the part, containing the root document using the relationship type [AnyContent][16].                                                                          
![Public method] | [AddCAEXSchema(Stream, Uri)][18]                                           | Adds a CAEX schema part retrieved from a stream resource to the package and creates a package - part relationship to the package using the relationship type [CAEXSchema][19].                                                             
![Public method] | [AddCAEXSchema(String, Uri)][20]                                           | Adds a CAEX schema file to the package and creates a package - part relationship to the package using the relationship type [CAEXSchema][19]                                                                                               
![Public method] | [AddCollada(PackagePart, Stream, Uri, Boolean)][21]                        | Adds a COLLADA part read from the specified stream resource to the package and creates relationships to the package and to the root document using the [Collada][22].                                                                      
![Public method] | [AddCollada(PackagePart, String, Uri, Boolean)][23]                        | Adds a COLLADA file to the package and creates relationships to the package and to the root document using the [Collada][22].                                                                                                              
![Public method] | [AddColladaSchema(Stream, Uri)][24]                                        | Adds a COLLADA schema part from the stream resource to the package and creates a package - part relationship to the package using [ColladaSchema][25].                                                                                     
![Public method] | [AddColladaSchema(String, Uri)][26]                                        | Adds a COLLADA schema file to the package and creates a package - part relationship to the package using [ColladaSchema][25].                                                                                                              
![Public method] | [AddLibrary(Stream, Uri)][27]                                              | Adds a library stream to the package and creates a package - part relationship of type [Library][28].                                                                                                                                      
![Public method] | [AddLibrary(String, Uri)][29]                                              | Adds a library file to the package and creates a package - part relationship of type [Library][28].                                                                                                                                        
![Public method] | [AddLibrary(PackagePart, Stream, Uri, Boolean)][30]                        | Adds a library from a stream resource to the package and creates relationships to the package and to the part containing the root document using the relationship type [Library][28].                                                      
![Public method] | [AddLibrary(PackagePart, String, Uri, Boolean)][31]                        | Adds a library file to the package and creates relationships to the package and to the package containing the root document using the [Library][28].                                                                                       
![Public method] | [AddPLCopenXml(PackagePart, Stream, Uri, Boolean)][32]                     | Adds a PLCopenXml part read from a stream resource to the package and creates relationships to the package and to the package part containing the root document using the relationship type [PLCopenXml][33].                              
![Public method] | [AddPLCopenXml(PackagePart, String, Uri, Boolean)][34]                     | Adds a PLCopenXml file to the package and creates relationships to the package and to the package part containing the root document using the relationship type [PLCopenXml][33].                                                          
![Public method] | [AddPLCopenXmlSchema(Stream, Uri)][35]                                     | Adds a PLCopenXml schema part from a stream resource to the package and creates a package - part relationship of type [PLCopenXmlSchema][36].                                                                                              
![Public method] | [AddPLCopenXmlSchema(String, Uri)][37]                                     | Adds a PLCopenXml schema file to the package and creates a package - part relationship of type [PLCopenXmlSchema][36] to the package.                                                                                                      
![Public method] | [AddRoot(Stream, Uri)][38]                                                 | Adds a root AML file from a stream resource to the package and creates a package - part relationship of type [Root][39].                                                                                                                   
![Public method] | [AddRoot(String, Uri)][40]                                                 | Adds a root AML file to the package and creates a package - part relationship of type [Root][39].                                                                                                                                          
![Public method] | [CheckRelatedParts][41]                                                    | Returns an enumeration of the related parts for the specified part and relationship type.                                                                                                                                                  
![Public method] | [Close][42]                                                                | Saves and closes the package and all part streams.                                                                                                                                                                                         
![Public method] | [Dispose][43]                                                              | Performs application-defined tasks associated with the release, return or resetting of unmanaged resources.                                                                                                                                
![Public method] | [Extract(DirectoryInfo)][44]                                               | Extracts all parts in the package to the specified directory                                                                                                                                                                               
![Public method] | [Extract(DirectoryInfo, PackagePart)][45]                                  | Extracts the specified part in the package to the specified directory.                                                                                                                                                                     
![Public method] | [ExtractAllFiles][46]                                                      | Extracts all parts in the package to the specified directory                                                                                                                                                                               
![Public method] | [Flush][47]                                                                | Saves the contents of all parts and relationships, contained in the package.                                                                                                                                                               
![Public method] | [GetPart][48]                                                              | Returns the part with the given URI.                                                                                                                                                                                                       
![Public method] | [GetParts][49]                                                             | Returns an enumeration of all parts inside the package.                                                                                                                                                                                    
![Public method] | [GetPartsByRelationShipType][50]                                           | Returns an enumeration of all parts with the given relationship type from the package.                                                                                                                                                     
![Public method] | [GetRelatedPartByUri][51]                                                  | Gets the related part by URI.                                                                                                                                                                                                              
![Public method] | [GetRelatedParts(PackagePart)][52]                                         | Returns an enumeration of all related parts for the given part.                                                                                                                                                                            
![Public method] | [GetRelatedParts(PackagePart, AutomationMLContainer.RelationshipType)][53] | Returns an enumeration of the related parts for the specified part and relationship type.                                                                                                                                                  
![Public method] | [GetRelationShips][54]                                                     | Returns an enumeration of all contained relationships of this instance.                                                                                                                                                                    
![Public method] | [GetRelationShipsByType][55]                                               | Returns an enumeration of all relationships with the given relationship type.                                                                                                                                                              
![Public method] | [PartExists][56]                                                           | Determines, if a part with the specified part URI exists.                                                                                                                                                                                  
![Public method] | [RelationShipExists][57]                                                   | Determines, if the specified relationship type exists.                                                                                                                                                                                     
![Public method] | [RelinkPart][58]                                                           | Changes the Uri of a package part. The part is removed and readded with the provided *newPartUri*. All relationships of the part are updated.                                                                                              
![Public method] | [RootDocumentPath][59]                                                     | Gets the file path to the first root AML document when the container is already extracted. [Extract(DirectoryInfo)][44] If the container is created from a stream source or no root document is found, the return value is `string.Empty`. 
![Public method] | [RootDocumentStream][60]                                                   | Gets the stream of the first root AML document. If no root document is found, the return value is `null`.                                                                                                                                  
![Public method] | [Save][61]                                                                 | Saves the package and all part streams, the package is still open.                                                                                                                                                                         


Fields
------

                                | Name                       | Description                
------------------------------- | -------------------------- | -------------------------- 
![Public field]![Static member] | [AutomationMLMimeType][62] | The AutomationML MIME type 


See Also
--------

#### Reference
[Aml.Engine.AmlObjects Namespace][2]  
[System.IDisposable][63]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: _ctor.md
[4]: _ctor_3.md
[5]: _ctor_1.md
[6]: _ctor_4.md
[7]: _ctor_2.md
[8]: _ctor_5.md
[9]: _ctor_6.md
[10]: CompressionMode.md
[11]: https://docs.microsoft.com/dotnet/api/system.io.packaging.compressionoption
[12]: ContainerFilename.md
[13]: ExtractionDirectory.md
[14]: Package.md
[15]: AddAnyContent.md
[16]: ../AutomationMLContainer_RelationshipType/AnyContent.md
[17]: AddAnyContent_1.md
[18]: AddCAEXSchema.md
[19]: ../AutomationMLContainer_RelationshipType/CAEXSchema.md
[20]: AddCAEXSchema_1.md
[21]: AddCollada.md
[22]: ../AutomationMLContainer_RelationshipType/Collada.md
[23]: AddCollada_1.md
[24]: AddColladaSchema.md
[25]: ../AutomationMLContainer_RelationshipType/ColladaSchema.md
[26]: AddColladaSchema_1.md
[27]: AddLibrary_2.md
[28]: ../AutomationMLContainer_RelationshipType/Library.md
[29]: AddLibrary_3.md
[30]: AddLibrary.md
[31]: AddLibrary_1.md
[32]: AddPLCopenXml.md
[33]: ../AutomationMLContainer_RelationshipType/PLCopenXml.md
[34]: AddPLCopenXml_1.md
[35]: AddPLCopenXmlSchema.md
[36]: ../AutomationMLContainer_RelationshipType/PLCopenXmlSchema.md
[37]: AddPLCopenXmlSchema_1.md
[38]: AddRoot.md
[39]: ../AutomationMLContainer_RelationshipType/Root.md
[40]: AddRoot_1.md
[41]: CheckRelatedParts.md
[42]: Close.md
[43]: Dispose.md
[44]: Extract.md
[45]: Extract_1.md
[46]: ExtractAllFiles.md
[47]: Flush.md
[48]: GetPart.md
[49]: GetParts.md
[50]: GetPartsByRelationShipType.md
[51]: GetRelatedPartByUri.md
[52]: GetRelatedParts.md
[53]: GetRelatedParts_1.md
[54]: GetRelationShips.md
[55]: GetRelationShipsByType.md
[56]: PartExists.md
[57]: RelationShipExists.md
[58]: RelinkPart.md
[59]: RootDocumentPath.md
[60]: RootDocumentStream.md
[61]: Save.md
[62]: AutomationMLMimeType.md
[63]: https://docs.microsoft.com/dotnet/api/system.idisposable
[64]: https://www.automationml.org
[65]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public field]: ../../icons/pubfield.gif "Public field"
[Static member]: ../../icons/static.gif "Static member"