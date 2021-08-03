DocumentVersionInformation Class
================================
AutomationML 2.1 APIThis Class is defined for the modeling of document version information as defined in the AutomationML BPR 06 "Naming of related documents and their versions". [DocumentVersions][1] are stored as [AdditionalInformation][2] attached to the CAEXFile Node of the AMLDocument.


Inheritance Hierarchy
---------------------
[System.Object][3]  
  **Aml.Engine.AmlObjects.DocumentVersionInformation**  

  **Namespace:**  [Aml.Engine.AmlObjects][4]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class DocumentVersionInformation
```

The **DocumentVersionInformation** type exposes the following members.


Constructors
------------

                 | Name                                      | Description                                                                                                                                                                            
---------------- | ----------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [DocumentVersionInformation()][5]         | Initializes a new instance of the **DocumentVersionInformation** class.                                                                                                                
![Public method] | [DocumentVersionInformation(XElement)][6] | Initializes a new instance of the **DocumentVersionInformation** class using the provided XML node (this should be an [ADDITIONALINFORMATION_STRING][7]), containing document content. 


Properties
----------

                   | Name                    | Description                                                                                   
------------------ | ----------------------- | --------------------------------------------------------------------------------------------- 
![Public property] | [DocumentIdentifier][8] | The document attribute "DocumentIdentifier" shall define the name of the referenced document. 
![Public property] | [Version][9]            | The document attribute "Version" shall define the version range of the referenced document.   


See Also
--------

#### Reference
[Aml.Engine.AmlObjects Namespace][4]  

[1]: ../DocumentVersions/README.md
[2]: ../../Aml.Engine.CAEX/CAEXBasicObject/AdditionalInformation.md
[3]: https://docs.microsoft.com/dotnet/api/system.object
[4]: ../README.md
[5]: _ctor.md
[6]: _ctor_1.md
[7]: ../../Aml.Engine.CAEX/CAEX_CLASSModel_TagNames/ADDITIONALINFORMATION_STRING.md
[8]: DocumentIdentifier.md
[9]: Version.md
[10]: https://www.automationml.org
[11]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"