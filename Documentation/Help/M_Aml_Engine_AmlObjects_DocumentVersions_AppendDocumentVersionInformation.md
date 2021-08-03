# DocumentVersions.AppendDocumentVersionInformation Method (CAEXFileType, DocumentVersionInformation, String)
AutomationML 2.1 API 

Appends the provided document version information to the AutomationML document

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool AppendDocumentVersionInformation(
	this CAEXFileType myCAEXFile,
	DocumentVersionInformation versionInformation,
	out string error
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function AppendDocumentVersionInformation ( 
	myCAEXFile As CAEXFileType,
	versionInformation As DocumentVersionInformation,
	<OutAttribute> ByRef error As String
) As Boolean
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static bool AppendDocumentVersionInformation(
	CAEXFileType^ myCAEXFile, 
	DocumentVersionInformation^ versionInformation, 
	[OutAttribute] String^% error
)
```


#### Parameters
&nbsp;<dl><dt>myCAEXFile</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXFileType">Aml.Engine.CAEX.CAEXFileType</a><br />The CAEX file of the AutomationML document.</dd><dt>versionInformation</dt><dd>Type: <a href="T_Aml_Engine_AmlObjects_DocumentVersionInformation">Aml.Engine.AmlObjects.DocumentVersionInformation</a><br />The version information.</dd><dt>error</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Out parameter containing error information if the method returns false. Possibles errors are:
&nbsp;<ul><li>No Document Identifier defined</li><li>DocumentVersion to be parsed is null</li><li>Negative value in version string</li><li>Bad number of components in version string</li><li>Non-integer value in version string</li><li>Number out of range in version string</li></ul></dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />true if the version information could be added, false otherwise.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_DocumentVersions">DocumentVersions Class</a><br /><a href="Overload_Aml_Engine_AmlObjects_DocumentVersions_AppendDocumentVersionInformation">AppendDocumentVersionInformation Overload</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />