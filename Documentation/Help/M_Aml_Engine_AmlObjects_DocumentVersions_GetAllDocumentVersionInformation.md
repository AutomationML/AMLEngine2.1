# DocumentVersions.GetAllDocumentVersionInformation Method 
AutomationML 2.1 API 

This methods returns an Enumeration of all Information related to document versions defined in the "DocumentVersions" information of an AutomationML document.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static IEnumerable<DocumentVersionInformation> GetAllDocumentVersionInformation(
	this CAEXFileType myCAEXFile
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function GetAllDocumentVersionInformation ( 
	myCAEXFile As CAEXFileType
) As IEnumerable(Of DocumentVersionInformation)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static IEnumerable<DocumentVersionInformation^>^ GetAllDocumentVersionInformation(
	CAEXFileType^ myCAEXFile
)
```


#### Parameters
&nbsp;<dl><dt>myCAEXFile</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXFileType">Aml.Engine.CAEX.CAEXFileType</a><br />the CAEX file of the AutomationML document.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_AmlObjects_DocumentVersionInformation">DocumentVersionInformation</a>)<br />Enumerable containing all Documents in the DocumentVersion information, or null if no DocumentVersion information exists.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_DocumentVersions">DocumentVersions Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />