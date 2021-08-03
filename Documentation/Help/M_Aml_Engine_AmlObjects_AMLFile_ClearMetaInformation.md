# AMLFile.ClearMetaInformation Method 
AutomationML 2.1 API 

Removes all "Writer Header" specific meta information out of this CAEX file.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public void ClearMetaInformation()
```

**VB**<br />
``` VB
Public Sub ClearMetaInformation
```

**C++**<br />
``` C++
public:
void ClearMetaInformation()
```


## Remarks
Extension Method originally designed for AutomationML Versions based on CAEX 2.15. If this method is applied to a CAEX 3.0 document, the information is transformed to a <a href="T_Aml_Engine_CAEX_SourceDocumentInformationType">SourceDocumentInformationType</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AMLFile">AMLFile Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />