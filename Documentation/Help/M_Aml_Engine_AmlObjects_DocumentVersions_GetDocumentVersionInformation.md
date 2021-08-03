# DocumentVersions.GetDocumentVersionInformation Method 
AutomationML 2.1 API 

This function returns the DocumentVersion Information from the AutomationML document with the specified document Identifier, otherwise null.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static DocumentVersionInformation GetDocumentVersionInformation(
	this CAEXFileType myCAEXFile,
	string documentIdentifier
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function GetDocumentVersionInformation ( 
	myCAEXFile As CAEXFileType,
	documentIdentifier As String
) As DocumentVersionInformation
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static DocumentVersionInformation^ GetDocumentVersionInformation(
	CAEXFileType^ myCAEXFile, 
	String^ documentIdentifier
)
```


#### Parameters
&nbsp;<dl><dt>myCAEXFile</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXFileType">Aml.Engine.CAEX.CAEXFileType</a><br />this CAEX file of the AutomationML document.</dd><dt>documentIdentifier</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the Document Identifier</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_AmlObjects_DocumentVersionInformation">DocumentVersionInformation</a><br />This function returns the DocumentVersion - Information corresponding to the document Identifier, otherwise null.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_DocumentVersions">DocumentVersions Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />