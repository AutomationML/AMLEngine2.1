# AMLFile.SetSourceDocumentInformation Method 
AutomationML 2.1 API 

This function sets the meta information required from AutomationML standard. If meta information about the same writerID already exists, this meta information is replaced. These information comprise source information about the AutomationML file.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public void SetSourceDocumentInformation(
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
Public Sub SetSourceDocumentInformation ( 
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
void SetSourceDocumentInformation(
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
&nbsp;<dl><dt>originName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the name of the writing tool</dd><dt>originID</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />an ID of the writing tool</dd><dt>originVendor</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the tool vendors name</dd><dt>originVendorURL</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the tools vendors URL</dd><dt>originVersion</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the version of the writing tool</dd><dt>originRelease</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the release number of the writing tool</dd><dt>lastWritingDateTime</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.datetime" target="_parent" rel="noopener noreferrer">System.DateTime</a><br />the date of the last writing time</dd><dt>originProjectTitle</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the title of the written project</dd><dt>originProjectID</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />an ID of the written project</dd></dl>

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentexception" target="_parent" rel="noopener noreferrer">ArgumentException</a></td><td>originID</td></tr></table>

## Remarks
Extension Method for AutomationML Versions based on CAEX 3.0. If this method is called for an CAEX 2.15 Version, the call is redirected to the <a href="M_Aml_Engine_AmlObjects_AMLFile_SetMetaInformation_1">SetMetaInformation(String, String, String, String, String, String, String, String, String)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AMLFile">AMLFile Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />