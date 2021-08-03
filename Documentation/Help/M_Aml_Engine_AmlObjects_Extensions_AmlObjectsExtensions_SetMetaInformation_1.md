# AmlObjectsExtensions.SetMetaInformation Method (CAEXFileType, String, String, String, String, String, String, String, String, String)
AutomationML 2.1 API 

This function sets the meta information required from AutomationML standard. If meta information about the same writerID already exists, this meta information is replaced. These information comprise source information about the AutomationML file.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects_Extensions">Aml.Engine.AmlObjects.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static void SetMetaInformation(
	this CAEXFileType caexFile,
	string writerName,
	string writerID,
	string writerVendor,
	string writerVendorURL,
	string writerVersion,
	string writerRelease,
	string lastWritingDateTime,
	string writerProjectTitle,
	string writerProjectID
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Sub SetMetaInformation ( 
	caexFile As CAEXFileType,
	writerName As String,
	writerID As String,
	writerVendor As String,
	writerVendorURL As String,
	writerVersion As String,
	writerRelease As String,
	lastWritingDateTime As String,
	writerProjectTitle As String,
	writerProjectID As String
)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static void SetMetaInformation(
	CAEXFileType^ caexFile, 
	String^ writerName, 
	String^ writerID, 
	String^ writerVendor, 
	String^ writerVendorURL, 
	String^ writerVersion, 
	String^ writerRelease, 
	String^ lastWritingDateTime, 
	String^ writerProjectTitle, 
	String^ writerProjectID
)
```


#### Parameters
&nbsp;<dl><dt>caexFile</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXFileType">Aml.Engine.CAEX.CAEXFileType</a><br />the CAEXFile</dd><dt>writerName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the name of the writing tool</dd><dt>writerID</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />an ID of the writing tool</dd><dt>writerVendor</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the tool vendors name</dd><dt>writerVendorURL</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the tools vendors URL</dd><dt>writerVersion</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the version of the writing tool</dd><dt>writerRelease</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the release number of the writing tool</dd><dt>lastWritingDateTime</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the date of the last writing time</dd><dt>writerProjectTitle</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the title of the written project</dd><dt>writerProjectID</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />an ID of the written project</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>caexFile</td></tr></table>

## Remarks
Extension Method for AutomationML Versions based on CAEX 2.15. If this method is called for a CAEX 3.0 or later Version, the call is redirected to the <a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_SetSourceDocumentInformation">SetSourceDocumentInformation(CAEXFileType, String, String, String, String, String, String, DateTime, String, String)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions Class</a><br /><a href="Overload_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_SetMetaInformation">SetMetaInformation Overload</a><br /><a href="N_Aml_Engine_AmlObjects_Extensions">Aml.Engine.AmlObjects.Extensions Namespace</a><br />