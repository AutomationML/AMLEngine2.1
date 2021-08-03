DocumentVersions Class
======================
AutomationML 2.1 APIThe Class DocumentVersions defines extension methods for the [CAEXFileType][1] to retrieve and manipulate document versions attached to a CAEXFile. The DocumentVersion feature is described in the AutomationML BPR 06 "Naming of related documents and their versions" .


Inheritance Hierarchy
---------------------
[System.Object][2]  
  **Aml.Engine.AmlObjects.DocumentVersions**  

  **Namespace:**  [Aml.Engine.AmlObjects][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static class DocumentVersions
```

The **DocumentVersions** type exposes the following members.


Methods
-------

                                 | Name                                                                                    | Description                                                                                                                                                                                                   
-------------------------------- | --------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]![Static member] | [AppendDocumentVersionInformation(CAEXFileType, DocumentVersionInformation, String)][4] | Appends the provided document version information to the AutomationML document                                                                                                                                
![Public method]![Static member] | [AppendDocumentVersionInformation(CAEXFileType, String, String, String)][5]             | This function sets the DocumentVersion information for a referenced document. If DocumentVersion information about the same document Identifier already exists, this DocumentVersion information is replaced. 
![Public method]![Static member] | [CreateDocumentVersionsHeader][6]                                                       | Creates the additional information representing a document versions header and appends it to the AutomationML document.                                                                                       
![Public method]![Static member] | [DeleteDocumentVersionInformation][7]                                                   | This function deletes all existing DocumentVersion information from the AutomationML document corresponding to the documentID.                                                                                
![Public method]![Static member] | [DocumentVersionsHeader][8]                                                             | Get the Additional Information XML-Node from the CAEXFile, which represents the Document Versions node.                                                                                                       
![Public method]![Static member] | [GetAllDocumentVersionInformation][9]                                                   | This methods returns an Enumeration of all Information related to document versions defined in the "DocumentVersions" information of an AutomationML document.                                                
![Public method]![Static member] | [GetDocumentVersionInformation][10]                                                     | This function returns the DocumentVersion Information from the AutomationML document with the specified document Identifier, otherwise null.                                                                  
![Public method]![Static member] | [ReplaceDocumentVersionInformation][11]                                                 | This function replaces any existing DocumentVersion information corresponding to the identical oldDocumentID with the provided new DocumentVersion information.                                               


Fields
------

                                | Name                                  | Description                                                         
------------------------------- | ------------------------------------- | ------------------------------------------------------------------- 
![Public field]![Static member] | [DocumentElementName][12]             | The document element name                                           
![Public field]![Static member] | [DocumentIdentifierAttributeName][13] | The document identifier attribute name used in the Document element 
![Public field]![Static member] | [DocumentVersionsAttributeName][14]   | The document versions attribute name                                
![Public field]![Static member] | [DocumentVersionsAttributeValue][15]  | The document versions attribute value                               
![Public field]![Static member] | [VersionAttributeName][16]            | The version attribute name used in the document element             


See Also
--------

#### Reference
[Aml.Engine.AmlObjects Namespace][3]  
[Aml.Engine.AmlObjects.DocumentVersionInformation][17]  

[1]: ../../Aml.Engine.CAEX/CAEXFileType/README.md
[2]: https://docs.microsoft.com/dotnet/api/system.object
[3]: ../README.md
[4]: AppendDocumentVersionInformation.md
[5]: AppendDocumentVersionInformation_1.md
[6]: CreateDocumentVersionsHeader.md
[7]: DeleteDocumentVersionInformation.md
[8]: DocumentVersionsHeader.md
[9]: GetAllDocumentVersionInformation.md
[10]: GetDocumentVersionInformation.md
[11]: ReplaceDocumentVersionInformation.md
[12]: DocumentElementName.md
[13]: DocumentIdentifierAttributeName.md
[14]: DocumentVersionsAttributeName.md
[15]: DocumentVersionsAttributeValue.md
[16]: VersionAttributeName.md
[17]: ../DocumentVersionInformation/README.md
[18]: https://www.automationml.org
[19]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"
[Public field]: ../../icons/pubfield.gif "Public field"