# AutomationMLContainer.RelinkPart Method 
AutomationML 2.1 API 

Changes the uri of a package part. The part is removed and readded with the provided *newPartUri*. All relationships of the part are updated.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool RelinkPart(
	Uri oldPartUri,
	Uri newPartUri
)
```

**VB**<br />
``` VB
Public Function RelinkPart ( 
	oldPartUri As Uri,
	newPartUri As Uri
) As Boolean
```

**C++**<br />
``` C++
public:
bool RelinkPart(
	Uri^ oldPartUri, 
	Uri^ newPartUri
)
```


#### Parameters
&nbsp;<dl><dt>oldPartUri</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.uri" target="_parent" rel="noopener noreferrer">System.Uri</a><br /></dd><dt>newPartUri</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.uri" target="_parent" rel="noopener noreferrer">System.Uri</a><br /></dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if a part with the provided *oldPartUri* exists; otherwise false

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AutomationMLContainer">AutomationMLContainer Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />