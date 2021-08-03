# AMLFile.IsDocumentVersion Method 
AutomationML 2.1 API 

Determines whether the specified XML element represents an AdditionalInformation object, using the specific DocumentVersion syntax.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool IsDocumentVersion(
	XElement element
)
```

**VB**<br />
``` VB
Public Function IsDocumentVersion ( 
	element As XElement
) As Boolean
```

**C++**<br />
``` C++
public:
bool IsDocumentVersion(
	XElement^ element
)
```


#### Parameters
&nbsp;<dl><dt>element</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The element.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the specified element is a DocumentVersion element; otherwise, `false`.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AMLFile">AMLFile Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />