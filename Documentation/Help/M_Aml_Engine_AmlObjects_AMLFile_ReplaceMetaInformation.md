# AMLFile.ReplaceMetaInformation Method 
AutomationML 2.1 API 

This function replaces any existing meta information corresponding to the identical oldWriterID with the new meta information defined in the new Meta information

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool ReplaceMetaInformation(
	string oldWriterID,
	MetaInformation newMetainformation
)
```

**VB**<br />
``` VB
Public Function ReplaceMetaInformation ( 
	oldWriterID As String,
	newMetainformation As MetaInformation
) As Boolean
```

**C++**<br />
``` C++
public:
bool ReplaceMetaInformation(
	String^ oldWriterID, 
	MetaInformation^ newMetainformation
)
```


#### Parameters
&nbsp;<dl><dt>oldWriterID</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />writerID of the old meta information</dd><dt>newMetainformation</dt><dd>Type: <a href="T_Aml_Engine_AmlObjects_MetaInformation">Aml.Engine.AmlObjects.MetaInformation</a><br />substitute for the old version of meta information</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />true if succeeded, false if meta information about the oldWriterID is not found

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentexception" target="_parent" rel="noopener noreferrer">ArgumentException</a></td><td>oldWriterID</td></tr></table>

## Remarks
Extension Method originally designed for AutomationML Versions based on CAEX 2.15. If this method is applied to a CAEX 3.0 document, the information is transformed to a <a href="T_Aml_Engine_CAEX_SourceDocumentInformationType">SourceDocumentInformationType</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AMLFile">AMLFile Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />