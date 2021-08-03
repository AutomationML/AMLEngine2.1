# AMLFile.GetMetaInformation Method (String)
AutomationML 2.1 API 

This function returns the MetaInformation corresponding to the writerID, otherwise null.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public MetaInformation GetMetaInformation(
	string writerID
)
```

**VB**<br />
``` VB
Public Function GetMetaInformation ( 
	writerID As String
) As MetaInformation
```

**C++**<br />
``` C++
public:
MetaInformation^ GetMetaInformation(
	String^ writerID
)
```


#### Parameters
&nbsp;<dl><dt>writerID</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the writerID</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_AmlObjects_MetaInformation">MetaInformation</a><br />This function returns the MetaInformation corresponding to the writerID, otherwise null.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentexception" target="_parent" rel="noopener noreferrer">ArgumentException</a></td><td>writerID</td></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentoutofrangeexception" target="_parent" rel="noopener noreferrer">ArgumentOutOfRangeException</a></td><td /></tr></table>

## Remarks
Extension Method originally designed for AutomationML Versions based on CAEX 2.15. If this method is applied to a CAEX 3.0 document, the information is transformed from a <a href="T_Aml_Engine_CAEX_SourceDocumentInformationType">SourceDocumentInformationType</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AMLFile">AMLFile Class</a><br /><a href="Overload_Aml_Engine_AmlObjects_AMLFile_GetMetaInformation">GetMetaInformation Overload</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />