# AMLFile.DeleteMetaInformation Method 
AutomationML 2.1 API 

This function deletes any existing meta information corresponding to the writerID.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool DeleteMetaInformation(
	string writerID
)
```

**VB**<br />
``` VB
Public Function DeleteMetaInformation ( 
	writerID As String
) As Boolean
```

**C++**<br />
``` C++
public:
bool DeleteMetaInformation(
	String^ writerID
)
```


#### Parameters
&nbsp;<dl><dt>writerID</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Writer ID</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />true if delete succeeded, false if writerID has not been found

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentexception" target="_parent" rel="noopener noreferrer">ArgumentException</a></td><td>writerID</td></tr></table>

## Remarks
Extension Method originally designed for AutomationML Versions based on CAEX 2.15. If this method is applied to a CAEX 3.0 document, the information is transformed to a <a href="T_Aml_Engine_CAEX_SourceDocumentInformationType">SourceDocumentInformationType</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AMLFile">AMLFile Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />