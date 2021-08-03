# AutomationMLContainer.PartExists Method 
AutomationML 2.1 API 

Determines, if a part with the specified part URI exists.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool PartExists(
	Uri partUri
)
```

**VB**<br />
``` VB
Public Function PartExists ( 
	partUri As Uri
) As Boolean
```

**C++**<br />
``` C++
public:
bool PartExists(
	Uri^ partUri
)
```


#### Parameters
&nbsp;<dl><dt>partUri</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.uri" target="_parent" rel="noopener noreferrer">System.Uri</a><br />The part URI.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the part exists, `false` otherwise.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AutomationMLContainer">AutomationMLContainer Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />