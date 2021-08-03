# AMLFile.SetMetaInformation Method (MetaInformation)
AutomationML 2.1 API 

This method is a short version of the setMetaInformation. Meta data with identical WriterID is replaced.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public void SetMetaInformation(
	MetaInformation metaInformation
)
```

**VB**<br />
``` VB
Public Sub SetMetaInformation ( 
	metaInformation As MetaInformation
)
```

**C++**<br />
``` C++
public:
void SetMetaInformation(
	MetaInformation^ metaInformation
)
```


#### Parameters
&nbsp;<dl><dt>metaInformation</dt><dd>Type: <a href="T_Aml_Engine_AmlObjects_MetaInformation">Aml.Engine.AmlObjects.MetaInformation</a><br />the structure MetaInformation</dd></dl>

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>metaInformation</td></tr></table>

## Remarks
Extension Method originally designed for AutomationML Versions based on CAEX 2.15. If this method is applied to a CAEX 3.0 document, the information is transformed to a <a href="T_Aml_Engine_CAEX_SourceDocumentInformationType">SourceDocumentInformationType</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AMLFile">AMLFile Class</a><br /><a href="Overload_Aml_Engine_AmlObjects_AMLFile_SetMetaInformation">SetMetaInformation Overload</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />