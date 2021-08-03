# AMLFile.SetMetaInformation Method (String, String, String, String, String, String, String, String, String)
AutomationML 2.1 API 

This function sets the meta information required from AutomationML standard. If meta information about the same writerID already exists, this meta information is replaced. These information comprise source information about the AutomationML file.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public void SetMetaInformation(
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
Public Sub SetMetaInformation ( 
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
void SetMetaInformation(
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
&nbsp;<dl><dt>writerName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the name of the writing tool</dd><dt>writerID</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />an ID of the writing tool</dd><dt>writerVendor</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the tool vendors name</dd><dt>writerVendorURL</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the tools vendors URL</dd><dt>writerVersion</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the version of the writing tool</dd><dt>writerRelease</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the release number of the writing tool</dd><dt>lastWritingDateTime</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the date of the last writing time</dd><dt>writerProjectTitle</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the title of the written project</dd><dt>writerProjectID</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />an ID of the written project</dd></dl>

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentexception" target="_parent" rel="noopener noreferrer">ArgumentException</a></td><td>writerID</td></tr></table>

## Remarks
Extension Method for AutomationML Versions based on CAEX 2.15. If this method is called for a CAEX 3.0 or later Version, the call is redirected to the <a href="M_Aml_Engine_AmlObjects_AMLFile_SetSourceDocumentInformation">SetSourceDocumentInformation(String, String, String, String, String, String, DateTime, String, String)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AMLFile">AMLFile Class</a><br /><a href="Overload_Aml_Engine_AmlObjects_AMLFile_SetMetaInformation">SetMetaInformation Overload</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />