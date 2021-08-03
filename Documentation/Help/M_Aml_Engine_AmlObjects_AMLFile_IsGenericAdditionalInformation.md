# AMLFile.IsGenericAdditionalInformation Method 
AutomationML 2.1 API 

Determines whether the specified XML element represents an AdditionalInformation object, not using any specific syntax as the <a href="P_Aml_Engine_AmlObjects_AMLFile_DocumentVersion">DocumentVersion</a> or <a href="P_Aml_Engine_AmlObjects_AMLFile_WriterHeader">WriterHeader</a> elements.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool IsGenericAdditionalInformation(
	XElement element
)
```

**VB**<br />
``` VB
Public Function IsGenericAdditionalInformation ( 
	element As XElement
) As Boolean
```

**C++**<br />
``` C++
public:
bool IsGenericAdditionalInformation(
	XElement^ element
)
```


#### Parameters
&nbsp;<dl><dt>element</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The element.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the specified element is a generic AdditionalInformation element; otherwise, `false`.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AMLFile">AMLFile Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />