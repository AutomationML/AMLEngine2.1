# DocumentVersions.DeleteDocumentVersionInformation Method 
AutomationML 2.1 API 

This function deletes all existing DocumentVersion information from the AutomationML document corresponding to the documentID.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool DeleteDocumentVersionInformation(
	this CAEXFileType myCAEXFile,
	string documentIdentifier
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function DeleteDocumentVersionInformation ( 
	myCAEXFile As CAEXFileType,
	documentIdentifier As String
) As Boolean
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static bool DeleteDocumentVersionInformation(
	CAEXFileType^ myCAEXFile, 
	String^ documentIdentifier
)
```


#### Parameters
&nbsp;<dl><dt>myCAEXFile</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXFileType">Aml.Engine.CAEX.CAEXFileType</a><br />this CAEX file of the AutomationML document</dd><dt>documentIdentifier</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Document Identifier of the document version information, which should be deleted</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />true if delete succeeded, false if documentID has not been found

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_DocumentVersions">DocumentVersions Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />