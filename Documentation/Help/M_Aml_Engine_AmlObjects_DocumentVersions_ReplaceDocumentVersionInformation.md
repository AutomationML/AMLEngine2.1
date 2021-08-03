# DocumentVersions.ReplaceDocumentVersionInformation Method 
AutomationML 2.1 API 

This function replaces any existing DocumentVersion information corresponding to the identical oldDocumentID with the provided new DocumentVersion information.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool ReplaceDocumentVersionInformation(
	this CAEXFileType myCAEXFile,
	string oldDocumentID,
	DocumentVersionInformation newDocumentVersionInformation,
	out string error
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function ReplaceDocumentVersionInformation ( 
	myCAEXFile As CAEXFileType,
	oldDocumentID As String,
	newDocumentVersionInformation As DocumentVersionInformation,
	<OutAttribute> ByRef error As String
) As Boolean
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static bool ReplaceDocumentVersionInformation(
	CAEXFileType^ myCAEXFile, 
	String^ oldDocumentID, 
	DocumentVersionInformation^ newDocumentVersionInformation, 
	[OutAttribute] String^% error
)
```


#### Parameters
&nbsp;<dl><dt>myCAEXFile</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXFileType">Aml.Engine.CAEX.CAEXFileType</a><br />The CAEX file of the AutomationML document.</dd><dt>oldDocumentID</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Document identifier of the old DocumentVersion information</dd><dt>newDocumentVersionInformation</dt><dd>Type: <a href="T_Aml_Engine_AmlObjects_DocumentVersionInformation">Aml.Engine.AmlObjects.DocumentVersionInformation</a><br />substitute for the old version of DocumentVersion information</dd><dt>error</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />error information if provided values are invalid</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />true if succeeded, false if DocumentVersion information corresponding to the oldDocumentID is not found

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_DocumentVersions">DocumentVersions Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />