# DocumentVersions.AppendDocumentVersionInformation Method (CAEXFileType, String, String, String)
AutomationML 2.1 API 

This function sets the DocumentVersion information for a referenced document. If DocumentVersion information about the same document Identifier already exists, this DocumentVersion information is replaced.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool AppendDocumentVersionInformation(
	this CAEXFileType myCAEXFile,
	string documentIdentifier,
	string documentVersion,
	out string error
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function AppendDocumentVersionInformation ( 
	myCAEXFile As CAEXFileType,
	documentIdentifier As String,
	documentVersion As String,
	<OutAttribute> ByRef error As String
) As Boolean
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static bool AppendDocumentVersionInformation(
	CAEXFileType^ myCAEXFile, 
	String^ documentIdentifier, 
	String^ documentVersion, 
	[OutAttribute] String^% error
)
```


#### Parameters
&nbsp;<dl><dt>myCAEXFile</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXFileType">Aml.Engine.CAEX.CAEXFileType</a><br />the CAEXFile of the AutomationML document</dd><dt>documentIdentifier</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The "DocumentIdentifier" shall define the name of the referenced document.</dd><dt>documentVersion</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The "Version" shall define the version range of the referenced document. The version number shall have three numbers separated by ".".</dd><dt>error</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Out parameter with error information if provided values are not valid or null. Possibles errors are:
&nbsp;<ul><li>No Document Identifier defined</li><li>DocumentVersion to be parsed is null</li><li>Negative value in version string</li><li>Bad number of components in version string</li><li>Non-integer value in version string</li><li>Number out of range in version string</li></ul></dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />true, if information is added, false otherwise.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_DocumentVersions">DocumentVersions Class</a><br /><a href="Overload_Aml_Engine_AmlObjects_DocumentVersions_AppendDocumentVersionInformation">AppendDocumentVersionInformation Overload</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />