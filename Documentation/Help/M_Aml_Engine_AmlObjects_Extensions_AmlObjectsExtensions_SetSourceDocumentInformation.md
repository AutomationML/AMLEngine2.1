# AmlObjectsExtensions.SetSourceDocumentInformation Method 
AutomationML 2.1 API 

This function sets the meta information required from AutomationML standard. If meta information about the same writerID already exists, this meta information is replaced. These information comprise source information about the AutomationML file.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects_Extensions">Aml.Engine.AmlObjects.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static void SetSourceDocumentInformation(
	this CAEXFileType caexFile,
	string originName,
	string originID,
	string originVendor,
	string originVendorURL,
	string originVersion,
	string originRelease,
	DateTime lastWritingDateTime,
	string originProjectTitle,
	string originProjectID
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Sub SetSourceDocumentInformation ( 
	caexFile As CAEXFileType,
	originName As String,
	originID As String,
	originVendor As String,
	originVendorURL As String,
	originVersion As String,
	originRelease As String,
	lastWritingDateTime As DateTime,
	originProjectTitle As String,
	originProjectID As String
)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static void SetSourceDocumentInformation(
	CAEXFileType^ caexFile, 
	String^ originName, 
	String^ originID, 
	String^ originVendor, 
	String^ originVendorURL, 
	String^ originVersion, 
	String^ originRelease, 
	DateTime lastWritingDateTime, 
	String^ originProjectTitle, 
	String^ originProjectID
)
```


#### Parameters
&nbsp;<dl><dt>caexFile</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXFileType">Aml.Engine.CAEX.CAEXFileType</a><br />the CAEXFile</dd><dt>originName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the name of the writing tool</dd><dt>originID</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />an ID of the writing tool</dd><dt>originVendor</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the tool vendors name</dd><dt>originVendorURL</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the tools vendors URL</dd><dt>originVersion</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the version of the writing tool</dd><dt>originRelease</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the release number of the writing tool</dd><dt>lastWritingDateTime</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.datetime" target="_parent" rel="noopener noreferrer">System.DateTime</a><br />the date of the last writing time</dd><dt>originProjectTitle</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the title of the written project</dd><dt>originProjectID</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />an ID of the written project</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>caexFile</td></tr></table>

## Remarks
Extension Method for AutomationML Versions based on CAEX 3.0. If this method is called for an CAEX 2.15 Version, the call is redirected to the <a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_SetMetaInformation_1">SetMetaInformation(CAEXFileType, String, String, String, String, String, String, String, String, String)</a> .

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions Class</a><br /><a href="N_Aml_Engine_AmlObjects_Extensions">Aml.Engine.AmlObjects.Extensions Namespace</a><br />