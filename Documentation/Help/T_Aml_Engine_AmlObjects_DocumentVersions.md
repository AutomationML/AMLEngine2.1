# DocumentVersions Class
AutomationML 2.1 API 

The Class DocumentVersions defines extension methods for the <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a> to retrieve and manipulate document versions attached to a CAEXFile. The DocumentVersion feature is described in the AutomationML BPR 06 "Naming of related documents and their versions" .


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.AmlObjects.DocumentVersions<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static class DocumentVersions
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public NotInheritable Class DocumentVersions
```

**C++**<br />
``` C++
[ExtensionAttribute]
public ref class DocumentVersions abstract sealed
```

The DocumentVersions type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_DocumentVersions_AppendDocumentVersionInformation">AppendDocumentVersionInformation(CAEXFileType, DocumentVersionInformation, String)</a></td><td>
Appends the provided document version information to the AutomationML document</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_DocumentVersions_AppendDocumentVersionInformation_1">AppendDocumentVersionInformation(CAEXFileType, String, String, String)</a></td><td>
This function sets the DocumentVersion information for a referenced document. If DocumentVersion information about the same document Identifier already exists, this DocumentVersion information is replaced.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_DocumentVersions_CreateDocumentVersionsHeader">CreateDocumentVersionsHeader</a></td><td>
Creates the additional information representing a document versions header and appends it to the AutomationML document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_DocumentVersions_DeleteDocumentVersionInformation">DeleteDocumentVersionInformation</a></td><td>
This function deletes all existing DocumentVersion information from the AutomationML document corresponding to the documentID.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_DocumentVersions_DocumentVersionsHeader">DocumentVersionsHeader</a></td><td>
Get the Additional Information XML-Node from the CAEXFile, which represents the Document Versions node.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_DocumentVersions_GetAllDocumentVersionInformation">GetAllDocumentVersionInformation</a></td><td>
This methods returns an Enumeration of all Information related to document versions defined in the "DocumentVersions" information of an AutomationML document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_DocumentVersions_GetDocumentVersionInformation">GetDocumentVersionInformation</a></td><td>
This function returns the DocumentVersion Information from the AutomationML document with the specified document Identifier, otherwise null.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_DocumentVersions_ReplaceDocumentVersionInformation">ReplaceDocumentVersionInformation</a></td><td>
This function replaces any existing DocumentVersion information corresponding to the identical oldDocumentID with the provided new DocumentVersion information.</td></tr></table>&nbsp;
<a href="#documentversions-class">Back to Top</a>

## Fields
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_DocumentVersions_DocumentElementName">DocumentElementName</a></td><td>
The document element name</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_DocumentVersions_DocumentIdentifierAttributeName">DocumentIdentifierAttributeName</a></td><td>
The document identifier attribute name used in the Document element</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_DocumentVersions_DocumentVersionsAttributeName">DocumentVersionsAttributeName</a></td><td>
The document versions attribute name</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_DocumentVersions_DocumentVersionsAttributeValue">DocumentVersionsAttributeValue</a></td><td>
The document versions attribute value</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_DocumentVersions_VersionAttributeName">VersionAttributeName</a></td><td>
The version attribute name used in the document element</td></tr></table>&nbsp;
<a href="#documentversions-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br /><a href="T_Aml_Engine_AmlObjects_DocumentVersionInformation">Aml.Engine.AmlObjects.DocumentVersionInformation</a><br />