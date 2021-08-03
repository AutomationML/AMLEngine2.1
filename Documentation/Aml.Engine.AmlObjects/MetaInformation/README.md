MetaInformation Class
=====================
Class for modelling meta information as defined in the AutomationML standard. This class was originally designed for AML Versions based on CAEX 2.15. For later versions you can switch to the [SourceDocumentInformationType][1]. It is possible to set SourceDocumentInformation in a CAEX 3.0 document using this class. If this is applied, the MetaInformation is automatically transformed to SourceDocumentInformation. The transformation works in both directions.


Inheritance Hierarchy
---------------------
[System.Object][2]  
  **Aml.Engine.AmlObjects.MetaInformation**  

  **Namespace:**  [Aml.Engine.AmlObjects][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class MetaInformation
```

The **MetaInformation** type exposes the following members.


Constructors
------------

                 | Name                                                | Description                                                                                                                             
---------------- | --------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [MetaInformation()][4]                              | Initializes a new instance of the **MetaInformation** class.                                                                            
![Public method] | [MetaInformation(XElement)][5]                      | Initializes a new instance of the **MetaInformation** class, using a WriterHeader node to populate the properties.                      
![Public method] | [MetaInformation(SourceDocumentInformationType)][6] | Initializes a new instance of the **MetaInformation** class using the information provided from the specified SourceDocumentInformation 


Properties
----------

                   | Name                     | Description                                                                                 
------------------ | ------------------------ | ------------------------------------------------------------------------------------------- 
![Public property] | [LastWritingDateTime][7] | time stamp of the AutomationML export                                                       
![Public property] | [WriterID][8]            | the ID of the writer tool, maybe identical to the tools name if it is not subject of change 
![Public property] | [WriterName][9]          | the name of the writer tool (e.g. CoDeSys)                                                  
![Public property] | [WriterProjectID][10]    | ID of the project that contains the source engineering data                                 
![Public property] | [WriterProjectTitle][11] | name of the project that contains the source engineering data                               
![Public property] | [WriterRelease][12]      | release information about the writer tool, e.g. "beta12"                                    
![Public property] | [WriterVendor][13]       | the vendor of the writer tool, e.g. "3S"                                                    
![Public property] | [WriterVendorURL][14]    | the web URL of the vendor - helps to get in contact to the vendor                           
![Public property] | [WriterVersion][15]      | version of the writer tool, e.g. "3.4"                                                      


See Also
--------

#### Reference
[Aml.Engine.AmlObjects Namespace][3]  

[1]: ../../Aml.Engine.CAEX/SourceDocumentInformationType/README.md
[2]: https://docs.microsoft.com/dotnet/api/system.object
[3]: ../README.md
[4]: _ctor.md
[5]: _ctor_2.md
[6]: _ctor_1.md
[7]: LastWritingDateTime.md
[8]: WriterID.md
[9]: WriterName.md
[10]: WriterProjectID.md
[11]: WriterProjectTitle.md
[12]: WriterRelease.md
[13]: WriterVendor.md
[14]: WriterVendorURL.md
[15]: WriterVersion.md
[16]: https://www.automationml.org
[17]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"